using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Infrastructure
{
    public class ApiCaller<T> where T : class
    {
        HttpClient client;
        private readonly string _baseUrl = "https://reqres.in/api/";

        public ApiCaller()
        {
            client = new HttpClient();
        }

        public async Task<T> SendRequest(string resource)
        {
            var response = await client.GetAsync(_baseUrl + resource);
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(content);

            return result;
        }

        public async Task<string> SendPostRequest(string resource, object body)
        {
            var json = JsonConvert.SerializeObject(body);
            var content = new StringContent(json, UnicodeEncoding.UTF8, "application/json");

            var response = await client.PostAsync(_baseUrl + resource, content);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
