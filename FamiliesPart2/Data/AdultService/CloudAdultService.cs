using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FamiliesPart2.Models;

namespace FamiliesPart2.Data.AdultService
{
    public class CloudAdultService:IService<Adult>
    {
        private string uri = "https://localhost:5001";
        private readonly HttpClient _client;

        public CloudAdultService()
        {
            _client = new HttpClient();
        }
        public async Task<IList<Adult>> GetAllAsync()
        {
            HttpResponseMessage responseMessage = await _client.GetAsync("https://localhost:5001/Adult");
            Console.WriteLine(responseMessage.Content);
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                Console.WriteLine(result);
                IList<Adult> adults = JsonSerializer.Deserialize<IList<Adult>>(result, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                 return adults;
            }

            throw new Exception("Error in uploading!");
        }

        public async Task<Adult> GetByIdAsync(int adultId)
        {
            HttpResponseMessage response = await _client.GetAsync($"https://localhost:5001/Adult/{adultId}");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                throw new Exception($@"Error: {response.StatusCode}, {response.StatusCode}");
            } 
            string result = await response.Content.ReadAsStringAsync(); 
             Adult adult = JsonSerializer.Deserialize<Adult>(result, new JsonSerializerOptions 
             {
                 PropertyNamingPolicy = JsonNamingPolicy.CamelCase
             });
            return adult;
        }

        public async Task AddAsync(Adult adult)
        {
            string adultAsJson = JsonSerializer.Serialize(adult);
            StringContent content = new StringContent(
                adultAsJson, Encoding.UTF8, "application/json");
            Console.WriteLine(adultAsJson);
            HttpResponseMessage response = await _client.PostAsync(uri + "/Adult", content);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                Console.WriteLine($@"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task RemoveAsync(int adultId)
        {
            HttpResponseMessage response = await _client.DeleteAsync($"https://localhost:5001/Adult/{adultId}");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                throw new Exception($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task UpdateAsync(Adult adult)
        {
            string adultAsJson = JsonSerializer.Serialize(adult);
            StringContent content = new StringContent(adultAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PatchAsync(uri +"/Adult/{id}", content);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                Console.WriteLine($@"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }
    }
}