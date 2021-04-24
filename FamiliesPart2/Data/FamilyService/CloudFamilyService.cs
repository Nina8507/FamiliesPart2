using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using FamiliesPart2.Data.FamilyService;
using FamiliesPart2.Models;

namespace FamiliesPart2.Data.Imp
{
    public class CloudFamilyService:IFamilyService
    {
        private string uri = "http://localhost:5001";
        private readonly HttpClient _client;

        public CloudFamilyService()
        {
            _client = new HttpClient();
        }

        public async Task<IList<Family>> GetFamiliesAsync()
        {
           /* HttpResponseMessage response = await _client.GetAsync(uri + $"/families");

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                throw new Exception($@"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }

            string result = await response.Content.ReadAsStringAsync();
            IList<Family> families = JsonSerializer.Deserialize<IList<Family>>(result, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return families;*/
           Task<string> stringAsync = _client.GetStringAsync(uri + $"families");
           string message = await stringAsync;
           List<Family> result = JsonSerializer.Deserialize<List<Family>>(message, new JsonSerializerOptions
           {
               PropertyNameCaseInsensitive = true
           });
           return result;
        }
    }
}