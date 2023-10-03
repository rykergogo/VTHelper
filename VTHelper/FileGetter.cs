using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace VTHelper
{
    internal class FileGetter
    {
        public static string bodyData = "";
        private static void jsonSetter(string json)
        {
            bodyData = json;
        }
        public static async Task FileGetAsync(string hash, string api)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://www.virustotal.com/api/v3/files/" + hash),
                Headers =
                {
                    { "accept", "application/json" },
                    { "x-apikey", api},
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                jsonSetter(body);
            }
        }
    }
}
