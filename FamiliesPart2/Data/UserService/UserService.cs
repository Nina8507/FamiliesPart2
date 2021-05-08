using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FamiliesPart2.Models;

namespace FamiliesPart2.Data.UserService
{
    public class UserService:IUserService, IService<User>
    {
        private readonly HttpClient _client;
        private string uri = "https://localhost:5001";

        public UserService()
        {
            _client = new HttpClient();
        }
        public async  Task<User> ValidateLoginAsync(string username, string password)
        {
            HttpResponseMessage responseMessage = await _client.GetAsync
                ($"https://localhost:5001/User?username={username}&password={password}");
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                string userAsJson = await responseMessage.Content.ReadAsStringAsync();
                User resultUser = JsonSerializer.Deserialize<User>(userAsJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return resultUser;
            }

            throw new Exception($"{await responseMessage.Content.ReadAsStringAsync()}");
        }

        public async Task<IList<User>> GetAllAsync()
        {
            HttpResponseMessage responseMessage = await _client.GetAsync("https://localhost:5001/User");
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                List<User> users = JsonSerializer.Deserialize<List<User>>(result, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return users;
            }

            throw new Exception("Error in uploading!");
        }

        public async Task<User> GetByIdAsync(int userId)
        {
            HttpResponseMessage response = await _client.GetAsync(uri + $"/User/{userId}");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                throw new Exception($@"Error: {response.StatusCode}, {response.StatusCode}");
            } 
            string result = await response.Content.ReadAsStringAsync(); 
            User user = JsonSerializer.Deserialize<User>(result, new JsonSerializerOptions 
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return user;
        }

        public async Task AddAsync(User user)
        {
            string userAsJson = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(
                userAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync($"{uri}/User", content);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                Console.WriteLine($@"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task RemoveAsync(int userId)
        {
            HttpResponseMessage response = await _client.DeleteAsync($"{uri}/User/{userId}");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                throw new Exception($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task UpdateAsync(User user)
        {
            string userAsJson = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(userAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PatchAsync($"{uri}/User/{user.Id}", content);
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