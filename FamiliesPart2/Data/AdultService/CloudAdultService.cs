using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FamiliesPart2.Models;

namespace FamiliesPart2.Data.AdultService
{
    public class CloudAdultService:IAdultService
    {
        private string uri = "https://localhost:5001";
        private readonly HttpClient _client;

        public CloudAdultService()
        {
            _client = new HttpClient();
        }
        public async Task<IList<Adult>> GetAllAdultsAsync()
        {
            HttpResponseMessage responseMessage = await _client.GetAsync("https://localhost:5001/adult");
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                List<Adult> adults = JsonSerializer.Deserialize<List<Adult>>(result, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                 return adults;
            }

            throw new Exception("Error in uploading!");
        }

        public async Task<Adult> GetAdultAsync(int id)
        {
            HttpResponseMessage response = await _client.GetAsync(uri + $"/adult/{id}");
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

        public async Task AddAdultAsync(Adult adult)
        {
            string adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(
                adultAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync(uri + "/adult", content);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                Console.WriteLine($@"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task RemoveAdultAsync(int adultId)
        {
            HttpResponseMessage response = await _client.DeleteAsync($"{uri}/adult/{adultId}");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                throw new Exception($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task UpdateAdultAsync(Adult adult)
        {
            string adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PatchAsync($"{uri}/adult/{adult.Id}", content);
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