using System.IO;
using FamiliesPart2.Authentication;
using FamiliesPart2.Data;
using FamiliesPart2.Data.AdultService;
using FamiliesPart2.Data.FamilyService;
using FamiliesPart2.Data.Imp;
using FamiliesPart2.Data.UserService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace FamiliesPart2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<IFamilyService, CloudFamilyService>();
            services.AddScoped<IAdultService, CloudAdultService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            services.AddAuthorization(options =>
            {
                options.AddPolicy("MustBeManager", policy =>
                    policy.RequireAuthenticatedUser().RequireClaim("Role", "Manager"));
                options.AddPolicy("MustBeAnalyst", policy => 
                    policy.RequireAuthenticatedUser().RequireClaim("Role", "Analyst"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "StaticFolder")),
                RequestPath = "/StaticFolder"
            });
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}