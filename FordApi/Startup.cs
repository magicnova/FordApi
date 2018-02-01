using System.IO;
using System.Text;
using Ford.Domain;
using Ford.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Swagger;

namespace FordApi
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile($"Config/appsettings.{env.EnvironmentName}.json")
                .Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            new Container().Module(services, Configuration);
            services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "Ford API",
                        Version = "v1",
                        Description =
                            "This API will return cars made by Ford and you can create or update as well. Mongo database is required, configure it in the configuration file!"
                    });
                swagger.IncludeXmlComments(Path.Combine(PlatformServices.Default.Application.ApplicationBasePath,
                    "FordApi.xml"));
                swagger.OrderActionsBy(sort => sort.GroupName);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseExceptionHandler(errorApp =>
            {
                errorApp.Run(async context =>
                {
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    context.Response.ContentType = "application/json";

                    var error = context.Features.Get<IExceptionHandlerFeature>();
                    if (error != null)
                        await context.Response.WriteAsync(
                            JsonConvert.SerializeObject(
                                new Error
                                {
                                    Status = StatusCodes.Status500InternalServerError,
                                    Message = error.Error.Message
                                }), Encoding.UTF8);
                });
            });

            app.UseMvc();
            app.UseSwagger();

            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ford API V1"); });
        }
    }
}