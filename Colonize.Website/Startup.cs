using Colonize.Website.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Colonize.Website
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>() // <== LÄGG TILL! 
                .AddEntityFrameworkStores<ApplicationDbContext>();

            // Här gör vi att man endast kan komma åt admin som administrator! 
            // Lägg till "IsAdministrator" i AuthorizeAreaFolder
            services.AddAuthorization(options =>
                   options.AddPolicy("IsAdministrator", policy =>
                   policy.RequireRole("Administrator")));

            // Här gör vi admin till restricted area! 
            services.AddRazorPages()
                .AddRazorPagesOptions(options =>
                {
                    options.Conventions.AuthorizeAreaFolder("Admin", "/", "IsAdministrator");
                })
                .AddRazorRuntimeCompilation();

            // Håll info i minnet för varukorg! 
            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(60); // timear ut efter 60 sek
                // options.Cookie.HttpOnly = true;

                // Make the session cookie essential
                options.Cookie.IsEssential = true;
            });


    }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // Middleware! 
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession(); // Lägg till för att använda session! 

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
