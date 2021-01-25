using Newtonsoft.Json;
using OGS.STV.SURVEY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Services
{
    public class ValidationHttpClient
    {
        private readonly HttpClient _client;

        public ValidationHttpClient(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("http://www.stlmed.org/api/membership/check_card");
            _client.Timeout = new TimeSpan(0, 0, 30);
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<bool> Validate(string cardNo)
        {
            try
            {
                var encodedContent = new FormUrlEncodedContent(new List<KeyValuePair<string, string>>{
                new KeyValuePair<string, string>("card_no", cardNo)
                });
                var request = new HttpRequestMessage(HttpMethod.Post, "")
                {
                    Content = encodedContent
                };
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));

                var response = await _client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var validationResponse = JsonConvert.DeserializeObject<SisliResponseModel>(await response.Content.ReadAsStringAsync());
                if (validationResponse.Status != null)
                {
                    if (validationResponse.Status == "ok")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                
                return false;
            }
        }
    }
}
