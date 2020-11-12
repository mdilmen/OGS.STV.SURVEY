using Newtonsoft.Json;
using OGS.STV.SURVEY.Http;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Services
{
    public class MailHttpClient
    {
        private readonly HttpClient _client;

        public MailHttpClient(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://api.relateddigital.com/resta/api");
            _client.Timeout = new TimeSpan(0, 0, 30);
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<string> GetToken()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "api/auth/login");
                var serializedRequest = JsonConvert.SerializeObject(new TokenRequestModel() { UserName = "oyakyatirim_live_wsuser", Password = "oyak#y4tir1" });
                //request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));                
                request.Content = new StringContent(serializedRequest);
                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = await _client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var tokenResponse = JsonConvert.DeserializeObject<TokenResponseModel>(await response.Content.ReadAsStringAsync());
                return tokenResponse.ServiceTicket;
            }
            catch (Exception ex)
            {
                throw new Exception($"GetToken Api failed {ex.Message}.");
                //throw;
            }
        }
        public async Task<bool> PostSendMail(CancellationToken cancellationToken, string authToken,MailRequestModel mailRequest)
        {
            //InvoiceResponseModel invoice = new InvoiceResponseModel();
            var serializedMailRequest = JsonConvert.SerializeObject(mailRequest);

            var request = new HttpRequestMessage(HttpMethod.Post, "api/post/PostHtml");

            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.Authorization = new AuthenticationHeaderValue(authToken);
            request.Content = new StringContent(serializedMailRequest);
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            try
            {
                var response = await _client.SendAsync(request, cancellationToken);
                response.EnsureSuccessStatusCode();
                var mailResponse = JsonConvert.DeserializeObject<MailResponseModel>(await response.Content.ReadAsStringAsync());
                return mailResponse.Success;
            }
            catch (OperationCanceledException ocException)
            {                
                return false;
            }
            catch (Exception ex)
            {             
                throw new Exception($"UpdateInvoices Api failed {ex.Message}.");
             
            }
        }
    }
}
