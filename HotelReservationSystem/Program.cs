
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using HotelReservationSystem.AutoFac;
using HotelReservationSystem.Data;
using HotelReservationSystem.Extentions;
using HotelReservationSystem.Helpers;
using HotelReservationSystem.Middlewares;
using HotelReservationSystem.Profiles.Roomprofiles;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HotelReservationSystem;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDependencies(builder.Configuration);

        builder.Services.AddSingleton<PayPalAuthService>(sp =>
        new PayPalAuthService(
        builder.Configuration["PayPal:ClientId"],
        builder.Configuration["PayPal:ClientSecret"]));


        builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
        builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
            builder.RegisterModule(new AutoFacModule()));

        builder.Services.AddAutoMapper(typeof(RoomProfile));

        var app = builder.Build();

        app.TransactionMiddleware();

        MapperHelper.Mapper = app.Services.GetService<IMapper>()!;

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseAuthentication();
        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
