// <copyright file="Program.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

namespace RaceHub.Motors.API
{
    using System.Security.Claims;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.IdentityModel.Tokens;
    using RaceHub.Motors.API.DAL.Context;
    using RaceHub.Motors.API.DAL.Repository;
    using RaceHub.Motors.API.DAL.Repository.Interfaces;
    using RaceHub.Motors.API.Services;
    using RaceHub.Motors.API.Services.Interfaces;

    /// <summary>
    /// This class is the driver class for the API.
    /// </summary>
    public class Program
    {
        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Authority = $"https://{builder.Configuration["Auth0:Domain"]}/";
                    options.Audience = builder.Configuration["Auth0:Audience"];
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        NameClaimType = ClaimTypes.NameIdentifier,
                    };
                });

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("read:data", policy => policy.Requirements.Add(new HasScopeRequirement("read:data", domain)));
            });

            builder.Services.AddSingleton<IAuthorizationHandler, HasScopeHandler>();

            builder.Services.AddTransient<IEngineRepository, EngineRepository>();
            builder.Services.AddTransient<IDrivetrainRepository, DrivetrainRepository>();
            builder.Services.AddTransient<IVehicleColorRepository, VehicleColorRepository>();
            builder.Services.AddTransient<IManufacturerRepository, ManufacturerRepository>();
            builder.Services.AddTransient<IVehicleRepository, VehicleRepository>();
            builder.Services.AddTransient<IVehicleTypeRepository, VehicleTypeRepository>();

            builder.Services.AddTransient<IEngineService, EngineService>();
            builder.Services.AddTransient<IDrivetrainService, DrivetrainService>();
            builder.Services.AddTransient<IVehicleColorService, VehicleColorService>();
            builder.Services.AddTransient<IManufacturerService, ManufacturerService>();
            builder.Services.AddTransient<IVehicleTypeService, VehicleTypeService>();
            builder.Services.AddTransient<IVehicleService, VehicleService>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1",
                    Title = "RaceHub Motors API",
                    Description = "A simple .NET API that will be able to interact with a database.",
                });

                var xmlFileName = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFileName));
            });

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.WithOrigins("http://localhost:4200").WithMethods("POST", "GET", "PUT", "DELETE").AllowAnyHeader();
                });
            });

            builder.Services.AddDbContext<RaceHubMotorsContext>(options =>
            {
                options.UseSqlServer(builder.Configuration["ConnectionString"]);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors();

            app.UseAuthorization();

            app.UseAuthentication();

            app.MapControllers();

            app.Run();
        }
    }
}