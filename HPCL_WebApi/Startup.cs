using HPCL.DataRepository.DBDapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Reflection;
using System.IO;
using HPCL.Infrastructure.Swagger;
using HPCL.DataRepository.Account;
using HPCL_WebApi.ActionFilters;
using HPCL_WebApi.ErrorHelper;
using Newtonsoft.Json.Serialization;
using HPCL.DataRepository.Settings;
using HPCL.DataRepository.Officer;

namespace HPCL_WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            // services.add
            // services.AddEntityFramework()

            //Register dapper in scope
            //

            //services.AddDbContext<HPCLAppContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("HPCLConnectionString")));


            //services.AddSingleton<_IDapperContext, DapperContext>();

            services.AddSingleton<DapperContext>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<ISettingsRepository, SettingsRepository>();
            services.AddScoped<IOfficerRepository, OfficerRepository>();
            // services.AddControllers();
            services.AddControllers(config =>
            {
                config.Filters.Add(typeof(LoggingFilterAttribute));
            })
             .AddNewtonsoftJson(options =>
             {
                 options.SerializerSettings.TraceWriter = new NLogTraceWriter();
                 //options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                
             }); ;

            //services.AddSwaggerGen();
            services.AddSwaggerGen(options =>
            {
                options.OperationFilter<AuthorizationHeaderParameterOperationFilter>();
                options.SwaggerDoc("v2", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "MQWebAPI",
                    Version = "v2",
                    //Description = "Sample service for Learner",
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                options.IncludeXmlComments(xmlPath);
            });

            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo

            //        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            //    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            //    c.IncludeXmlComments(xmlPath);
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            var path = Directory.GetCurrentDirectory();
            loggerFactory.AddFile($"{path}\\Logs\\Log.txt");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v2/swagger.json", "PlaceInfo Services"));

        }
    }
}
