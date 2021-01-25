using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OGS.STV.SURVEY.Http;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Services
{
    public class MailHttpClient
    {
        private readonly HttpClient _client;
        private readonly ILogger<MailHttpClient> _logger;

        public MailHttpClient(HttpClient client, ILogger<MailHttpClient> logger)
        {
            _client = client;
            _logger = logger;
            _client.BaseAddress = new Uri("https://api.relateddigital.com/resta/api");
            _client.Timeout = new TimeSpan(0, 0, 30);
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<string> GetToken(CancellationToken cancellationToken)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "api/auth/login");
                var serializedRequest = JsonConvert.SerializeObject(new TokenRequestModel() { UserName = "oyakyatirim_live_wsuser", Password = "oyak#y4tir1" });         
                request.Content = new StringContent(serializedRequest);
                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = await _client.SendAsync(request,cancellationToken);
                if(!response.IsSuccessStatusCode)
                {
                    var ex = new Exception("API Failure");
                    ex.Data.Add("API Route", $"POST {request.RequestUri}");
                    ex.Data.Add("API Status", (int)response.StatusCode);
                    _logger.LogWarning("API Error when calling {APIRoute} : {APIStatus}", $"Get {request.RequestUri}", (int)response.StatusCode);
                    throw ex;
                }

                var tokenResponse = JsonConvert.DeserializeObject<TokenResponseModel>(await response.Content.ReadAsStringAsync());
                return tokenResponse.ServiceTicket;
        }
            catch (Exception ex)
            {
                throw new Exception($"GetToken Api failed {ex.Message}.");                                
            }
}
        public async Task<bool> PostSendMail(CancellationToken cancellationToken, string authToken,MailRequestModel mailRequest)
        {           
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
            catch (Exception ex)
            {             
                throw new Exception($"UpdateInvoices Api failed {ex.Message}.");             
            }
        }
    }
}
