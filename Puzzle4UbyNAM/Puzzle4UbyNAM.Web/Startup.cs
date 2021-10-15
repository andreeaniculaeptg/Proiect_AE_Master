using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.SqlServer.Management.Smo;
using Puzzle4UbyNAM.DataAccess;
using Puzzle4UbyNAM.DataAccess.Interfaces;
using Puzzle4UbyNAM.DataAccess.Repository;
using Puzzle4UbyNAM.Models;
using Puzzle4UbyNAM.Models.Entites;
using Puzzle4UbyNAM.Models.Interfaces;
using Puzzle4UbyNAM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Puzzle4UbyNAM.Web
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
            services.AddDbContext<Puzzle4UbyNAMContext>(option => option.UseSqlServer(Configuration.GetConnectionString("AppDbConn")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddEntityFrameworkStores<Puzzle4UbyNAMContext>()
                    .AddDefaultTokenProviders();    //AA

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";

            }); //AA

            services.AddControllersWithViews();

            services.AddSingleton(MapperConfig.GetMapper());

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(60);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            #region Services

            services.AddScoped<IProductTypeService, ProductTypeService>();
            services.AddScoped<IProductBrandService, ProductBrandService>();
            services.AddScoped<IProductService, ProductService>();

            #endregion Services

            #region Repository

            services.AddScoped<IRepository<ProductType, int>, Repository<ProductType, int>>();
            services.AddScoped<IRepository<ProductBrand, int>, Repository<ProductBrand, int>>();
            services.AddScoped<IRepository<Product, int>, Repository<Product, int>>();

            #endregion Repository
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();        //AA

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
