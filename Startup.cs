using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RowVehiclePoolMVC.Context;
using Microsoft.AspNetCore.Authentication.Negotiate;
using RowVehiclePoolMVC.Settings;
using System;
using MailKit;

namespace RowVehiclePoolMVC
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
            services.AddAuthentication(NegotiateDefaults.AuthenticationScheme).AddNegotiate();
            services.AddAuthorization(options => { options.FallbackPolicy = options.DefaultPolicy; });
            services.AddDistributedMemoryCache(); // <- This service

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(1200);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddHttpContextAccessor();
            services.AddSession();
            services.AddDbContext<RvpAppContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ROWVehiclePool_ConnectionString")));
            services.AddDbContext<RvpAppBudContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("BudgetInfo_ConnectionString")));
            services.AddDbContext<RvpAppEqpContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Equipment_ConnectionString")));
            services.AddDbContext<RvpAppAlltContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Allotments_ConnectionString")));
            //services.AddDbContext<RvpAppSecurityContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("Security_ConnectionString")));
            services.AddControllersWithViews();
            var mailSettings = Configuration.GetSection("MailSettings");
            services.AddTransient<Services.IMailService, Services.MailService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
