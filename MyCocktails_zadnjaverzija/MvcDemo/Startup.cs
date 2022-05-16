using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using MyCocktails.DbModels;
using MyCocktails.Repositories;
using MyCocktails.Services;

namespace MyCocktails
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private void SetupDbContext(IServiceCollection service)
        {
            var conString = Configuration.GetConnectionString("pma");
             service.AddDbContext<COCKTAILSContext>(options => options.UseSqlServer(conString));
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddNewtonsoftJson();
            services.AddControllersWithViews();
            services.AddScoped<IngredientsRepository>();
            services.AddScoped<IngredientsService>();
            services.AddScoped<UserCocktailRepository>();
            services.AddScoped<UserCocktailService>();
            services.AddScoped<AdminRepository>();
            services.AddScoped<AdminService>();
            SetupDbContext(services);
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromSeconds(3600);
            });
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
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
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   "SignIn",
                   "cocktails/signIn",
                   new { controller = "Authentication", action = "SignIn" }
                   );
                endpoints.MapControllerRoute(
                   "SignUn",
                   "cocktails/signUp",
                   new { controller = "Authentication", action = "SignUp" }
                   );
                endpoints.MapControllerRoute(
                   name: "PmfIngredientss",
                    pattern:"pmfst/ingredientss",
                    defaults:  new {controller = "cocktails", action = "ingredients"}
                );
                endpoints.MapControllerRoute(
                   "AdminSignin",
                   "cocktails/adminsignIn",
                   new { controller = "Authentication", action = "AdminSignIn" }
                   );
                endpoints.MapControllerRoute(
                    "AdminHome",
                    "cocktails/adminhome",
                    new { controller = "Admin", action = "adminHome" }
                    );
                endpoints.MapControllerRoute(
                   "Logout",
                   "cocktails/logout",
                   new { controller = "Home", action = "Logout" }
                   );
                endpoints.MapControllerRoute(
                   "Homepage",
                  "cocktails/homepage",
                  new { controller = "Home", action = "Pocetna" }
                  );
                endpoints.MapControllerRoute(
                    name: "PmfGlasses",
                    pattern: "pmfst/glasses",
                    defaults: new {controller = "glasses", action = "glasses"}
                );
                endpoints.MapControllerRoute(
                    name: "PmfGlasses",
                    pattern: "pmfst/glass",
                    defaults: new { controller = "glasses", action = "glass" }
                );
                endpoints.MapControllerRoute(
                    name: "CocktailForm",
                    pattern: "pmfst/addcocktail",
                    defaults: new { controller = "Home", action = "CocktailForm" }
                );
                endpoints.MapControllerRoute(
                   name: "Category",
                   pattern: "pmfst/category",
                   defaults: new { controller = "Home", action = "Category" }
               );
                endpoints.MapControllerRoute(
                   name: "MyCocktails",
                   pattern: "pmfst/mycocktails",
                   defaults: new { controller = "Home", action = "MyCocktails" }
               );
                endpoints.MapControllerRoute(
               name: "PmfIngredient",
               pattern: "pmfst/ingredient",
               defaults: new { controller = "cocktails", action = "Ingredient" }
           );
                endpoints.MapControllerRoute(
                name: "PmfCocktail",
                pattern: "pmfst/cocktail",
                defaults: new { controller = "cocktails", action = "Cocktail" }
                );
                endpoints.MapControllerRoute(
                name: "PmfUserCocktail",
                pattern: "pmfst/usercocktail",
                defaults: new { controller = "userCocktail", action = "UserCocktail" }
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}