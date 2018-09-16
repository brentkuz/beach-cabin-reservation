using System;
using BeachCabinReservation.Data;
using BeachCabinReservation.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BeachCabinReservation.Areas.Identity.IdentityHostingStartup))]
namespace BeachCabinReservation.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AppDataContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AppConnectionString")));

                services.AddDefaultIdentity<AppUser>()
                    .AddEntityFrameworkStores<AppDataContext>();
            });
        }
    }
}