using MicCheck.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Microsoft.EntityFrameworkCore;
using MicCheck.Data.Entities;
using Microsoft.AspNetCore.DataProtection;
using MicCheck.API.Middlewares;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using MicCheck.API.Services.Interfaces;
using MicCheck.API.Services;
using MicCheck.Core.Repositories.Interfaces;
using MicCheck.Data.Repositories;
using MicCheck.Data.Repositories.Interfaces;
using Microsoft.OpenApi.Models;
using System;
using Autofac;

namespace MicCheck.API
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
            string connectionString = Configuration.GetConnectionString("DatabaseConnection");
            string jwtKey = Configuration.GetValue<string>("JWTSecret");

            services.AddControllers();

            // Injects DbContext
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            // Implementing JWT authentication 
            byte[] key = Encoding.ASCII.GetBytes(jwtKey);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            });

            // Adding Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MicCheck.API", Version = "v1" });
            });  

            // Add cors
            services.AddCors(o => o.AddPolicy("Policy", builder =>
            {
                builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            }));

            // Services declarations
            services.AddScoped<IBandService, BandService>();
            services.AddScoped<IFanService, FanService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddSingleton<ISecurityService, SecurityService>();

            // Repositories
            services.AddScoped<IBandRepository, BandRepository>();
            services.AddScoped<IFanBandRepository, FanBandRepository>();
            services.AddScoped<IFanRepository, FanRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MicCheck.API v1"));
            }

            using(var scope = app.ApplicationServices.CreateScope())
            {
                // Ensures database creation
                scope.ServiceProvider.GetRequiredService<ApplicationDbContext>().Database.EnsureCreated();
            }

            app.UseCors("Policy");

            // With this line we configure the Exception Middleware
            app.ConfigureExceptionHandler(logger);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "api/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
