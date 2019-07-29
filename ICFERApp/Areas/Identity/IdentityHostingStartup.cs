using System;
using ICFERApp.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(ICFERApp.Areas.Identity.IdentityHostingStartup))]
namespace ICFERApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
//            builder.ConfigureServices((context, services) => {
//                services.AddDbContext<ICFERAppIdentityDbContext>(options =>
//                    options.UseSqlServer(
//                        context.Configuration.GetConnectionString("ICFERAppIdentityDbContextConnection")));
//
//                services.AddDefaultIdentity<IdentityUser>()
//                    .AddEntityFrameworkStores<ICFERAppIdentityDbContext>();
//            });
        }
    }
}