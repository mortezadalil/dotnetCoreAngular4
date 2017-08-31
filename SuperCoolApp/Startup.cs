using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SuperCoolApp.BL.Service;
using SuperCoolApp.BL.Service.Interface;
using SuperCoolApp.DAL;
using SuperCoolApp.DAL.Repository;
using SuperCoolApp.Domain.IRepository;

namespace SuperCoolApp
{
  public class Startup
  {
    

    public IConfiguration Configuration { get; }
    public Startup(IHostingEnvironment env)
    {
      var builder = new ConfigurationBuilder()
        .SetBasePath(env.ContentRootPath)
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
        .AddEnvironmentVariables();
      Configuration = builder.Build();
    }
    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<CodemyDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultLocalDb")));
      // Add framework services.


      
      // Adds the services required for building
      services.AddMvc();
      services.AddScoped<IUnitOfWork, UnitOfWork>();

      // Add application services.
      services.AddTransient<IUserDetailService, UserDetailService>();
    }


    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
    {
      // Redirect any non-API calls to the Angular application
      // so our application can handle the routing
      app.Use(async (context, next) =>
      {
        await next();
        if (context.Response.StatusCode == 404 &&
            !Path.HasExtension(context.Request.Path.Value) &&
            !context.Request.Path.Value.StartsWith("/api/"))
        {
          context.Request.Path = "/index.html";
          await next();
        }
      });
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      // Configures application for usage as API
      // with default route of '/api/[Controller]'
      app.UseMvcWithDefaultRoute();

      // Configures applcation to serve the index.html file from /wwwroot
      // when you access the server from a web browser
      app.UseDefaultFiles();
      app.UseStaticFiles();
    }
  }
}


//loggerFactory.AddConsole();

//            if (env.IsDevelopment())
//            {
//                app.UseDeveloperExceptionPage();
//            }
