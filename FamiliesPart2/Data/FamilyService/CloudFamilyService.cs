using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FamiliesPart2.Models;

namespace FamiliesPart2.Data.FamilyService
{
    public class CloudFamilyService:IService<Family>
    {
        private string uri = "http://localhost:5001";
        private readonly HttpClient _client;

        public CloudFamilyService()
        {
            _client = new HttpClient();
        }

        public async Task<IList<Family>> GetAllAsync()
        {
            
            HttpResponseMessage responseMessage = await _client.GetAsync("https://localhost:5001/Family");
            if (responseMessage.IsSuccessStatusCode)
           {
               string result = await responseMessage.Content.ReadAsStringAsync();
               Console.WriteLine(result);
               IList<Family> families = JsonSerializer.Deserialize<IList<Family>>(result, new JsonSerializerOptions
               {
                   PropertyNameCaseInsensitive = true
               });
               return families;
           }

           throw new Exception("Error in uploading!");
        }

        public async Task<Family> GetByIdAsync(int familyId)
        {
            HttpResponseMessage response = await _client.GetAsync(uri + $"/Family/{familyId}");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                throw new Exception($@"Error: {response.StatusCode}, {response.StatusCode}");
            } 
            string result = await response.Content.ReadAsStringAsync(); 
            Family family = JsonSerializer.Deserialize<Family>(result, new JsonSerializerOptions 
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return family;
        }

        public async Task AddAsync(Family family)
        {
            string familyAsJson = JsonSerializer.Serialize(family);
            StringContent content = new StringContent(
                familyAsJson, Encoding.UTF8, "application/json");
            Console.WriteLine(familyAsJson);
            HttpResponseMessage response = await _client.PostAsync($"https://localhost:5001/Family", content);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                Console.WriteLine($@"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task RemoveAsync(int familyId)
        {
            HttpResponseMessage response = await _client.DeleteAsync($"{uri}/Family/{familyId}");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                throw new Exception($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task UpdateAsync(Family family)
        {
             string familyAsJson = JsonSerializer.Serialize(family);
             StringContent content = new StringContent(familyAsJson, Encoding.UTF8, "application/json");
             HttpResponseMessage response = await _client.PatchAsync($"{uri}/Family/{family.Id}", content);
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