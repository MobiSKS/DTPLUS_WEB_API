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
using HPCL.DataRepository.Settings;
using HPCL.DataRepository.Officer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using HPCL_WebApi.ExceptionFilter;
using HPCL.DataRepository.Customer;
using HPCL.DataRepository.HQ;
using HPCL.DataRepository.Merchant;
using HPCL.DataRepository.Card;
using HPCL.DataRepository.RegionalOffice;
using HPCL.DataRepository.ZonalOffice;
using HPCL.DataRepository.Transaction;
using HPCL.DataRepository.Login;
using HPCL.DataRepository.City;
using HPCL.DataRepository.Country;
using HPCL.DataRepository.CountryRegion;
using HPCL.DataRepository.CountryZone;
using HPCL.DataRepository.District;
using HPCL.DataRepository.State;

namespace HPCL_WebApi
{
    public class Startup
    {
        private readonly string _policyName = "CorsPolicy";
        private readonly string _anotherPolicy = "AnotherCorsPolicy";       
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(opt =>
            {
                opt.AddPolicy(name: _policyName, builder =>
                {
                    builder.WithOrigins("https://localhost:5155")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
                opt.AddPolicy(name: _anotherPolicy, builder =>
                {
                    builder.WithOrigins("https://localhost:5021")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });

                opt.AddPolicy(name: _anotherPolicy, builder =>
                {
                    builder.WithOrigins("http://180.179.222.161/dtpwebapi")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });

            //services.add
            //services.AddEntityFramework()
            //Register dapper in scope
            //services.AddDbContext<HPCLAppContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("HPCLConnectionString")));
            //services.AddSingleton<_IDapperContext, DapperContext>();

            services.AddSingleton<DapperContext>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<ISettingsRepository, SettingsRepository>();
            services.AddScoped<IOfficerRepository, OfficerRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IHQRepository, HQRepository>();
            services.AddScoped<IMerchantRepository, MerchantRepository>();
            services.AddScoped<ICardRepository, CardRepository>();
            services.AddScoped<ICardRepository, CardRepository>();
            services.AddScoped<IRegionalOfficeRepository, RegionalOfficeRepository>();
            services.AddScoped<IZonalOfficeRepository, ZonalOfficeRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IStateRepository, StateRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IDistrictRepository, DistrictRepository>();
            services.AddScoped<ICountryRegionRepository, CountryRegionRepository>();
            services.AddScoped<ICountryZoneRepository, CountryZoneRepository>();
            

            services.AddScoped<CustomAuthenticationFilter>();
            services.Configure<ApiBehaviorOptions>(opt =>
            {
                opt.SuppressModelStateInvalidFilter = true;
            });
          
            //services.AddMvc(options =>
            //{
            //    options.Filters.Add(typeof(ValidateModelAttribute));
            //});
            services.AddMvc(
                config =>
                {
                    config.Filters.Add(typeof(CustomExceptionFilter));
                    config.Filters.Add(typeof(ValidateModelAttribute));
                }
            );//.AddFluentValidation();
            // services.AddControllers();
            services.AddControllers(config =>
            {
                config.Filters.Add(typeof(LoggingFilterAttribute));
            })

             .AddNewtonsoftJson(options =>
             {
                // options.SerializerSettings.TraceWriter = new NLogTraceWriter();
              //   options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                
             });

            services.AddControllers().AddNewtonsoftJson();
            services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            // If using IIS:
            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

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
            app.UseCors(_policyName);
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            //app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v2/swagger.json", "PlaceInfo Services"));
            app.UseSwaggerUI(options => options.SwaggerEndpoint("../swagger/v2/swagger.json", "PlaceInfo Services"));

        }
    }
}
