using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using FamiliesPart2.Models;

namespace FamiliesPart2.Data.UserService
{
    public class UserService:IUserService
    {
        private readonly HttpClient client = new HttpClient();
        public async  Task<User> ValidateLoginAsync(string username, string password)
        {
            HttpResponseMessage responseMessage = await client.GetAsync
                ($"https://localhost:5001/users?username={username}&password={password}");
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                string userAsJson = await responseMessage.Content.ReadAsStringAsync();
                User resultUser = JsonSerializer.Deserialize<User>(userAsJson, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });
                return resultUser;
            }

            throw new Exception($"{await responseMessage.Content.ReadAsStringAsync()}");
        }
    }
}