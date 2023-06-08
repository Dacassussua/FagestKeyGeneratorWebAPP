using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FagestKeyGenerator.WebAPP.Services.Interfaces;
using FagestKeyGenerator.WebAPP.Services;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace FagestKeyGenerator.WebAPP.Configuration
{
    public class Startup
    {
        public IConfiguration configRoot
        {
            get;
        }
        public Startup(IConfiguration configuration)
        {
            configRoot = configuration;
        }

        public IConfiguration Configuration { get; }

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddRazorPages();

        //}

        internal void Configure(IApplicationBuilder app, string environment)
        {
            app.UseCors("AllowAll");
        }
        //public void Configure(IApplicationBuilder app)
        //{

        //    app.UseCors("AllowAll");

        //}

    }
}