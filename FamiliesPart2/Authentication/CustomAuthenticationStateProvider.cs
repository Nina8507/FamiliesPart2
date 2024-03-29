﻿using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using FamiliesPart2.Data;
using FamiliesPart2.Data.UserService;
using FamiliesPart2.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;

namespace FamiliesPart2.Authentication
{
    public class CustomAuthenticationStateProvider:AuthenticationStateProvider
    {
         private readonly IJSRuntime jsRuntime;
        private readonly IUserService userService;

        private User cachedUser;
        
        public CustomAuthenticationStateProvider(IJSRuntime jsRuntime, IUserService userService)
        {
            this.jsRuntime = jsRuntime;
            this.userService = userService;
        }
        
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            if (cachedUser == null)
            {
                string userAsJson = await jsRuntime.InvokeAsync<string>
                    ("sessionStorage.getItem", "currentUser");
                if (!string.IsNullOrEmpty(userAsJson))
                {
                    User temp = JsonSerializer.Deserialize<User>(userAsJson);
                    await ValidateLoginAsync(temp.Username, temp.Password);
                }
            }
            else
            {
                identity = SetupClaimsForUser(cachedUser);
            }

            ClaimsPrincipal cachedClaimsPrincipal = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(cachedClaimsPrincipal));
        }
        
        public async Task ValidateLoginAsync(string username, string password)
        {
            Console.WriteLine("Validating log in");
            
            if (string.IsNullOrEmpty(username)) throw new Exception("Enter username");
            if (string.IsNullOrEmpty(password)) throw new Exception("Enter password");

            ClaimsIdentity identity = new ClaimsIdentity();
            try
            {
                User user = await userService.ValidateLoginAsync(username, password);
                identity = SetupClaimsForUser(user);
                string serializedData = JsonSerializer.Serialize(user);
                await jsRuntime.InvokeVoidAsync
                    ("sessionStorage.setItem", "currentUser", serializedData);
                cachedUser = user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw e;
            }
            
            NotifyAuthenticationStateChanged(Task.FromResult(
                new AuthenticationState(new ClaimsPrincipal(identity))));
        }
        
        public async Task LogoutAsync()
        {
            cachedUser = null;
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            await jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", "");
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
        private ClaimsIdentity SetupClaimsForUser(User user)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, user.Username));
            claims.Add(new Claim("Role", user.Role));
            ClaimsIdentity identity = new ClaimsIdentity(claims, "apiauth_type");
            return identity; 
        }
    }
}