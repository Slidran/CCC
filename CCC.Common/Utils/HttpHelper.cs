using Newtonsoft.Json;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CCC.Common.Utils
{
    [ExcludeFromCodeCoverage]
    public static class HttpHelper
    {
        public static async Task<T> GetAsync<T>(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    var result = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<T>(result);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static async Task<T> GetAsync<T>(string url, object content)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var request = new HttpRequestMessage
                    {
                        RequestUri = new Uri(url),
                        Method = HttpMethod.Get,
                    };
                    
                    request.Content = new ByteArrayContent(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(content)));

                    request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var response = await client.SendAsync(request);
                    response.EnsureSuccessStatusCode();

                    var result = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<T>(result);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
