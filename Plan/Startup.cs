using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Plan.Data.Entities;
using Plan.intereces;
using Plan.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plan
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
            services.AddIdentity<DbUser, DbRole>(options =>
            {
                options.Stores.MaxLengthForKeys = 128;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 5;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.User.AllowedUserNameCharacters= "éöóêåíãøùçõ¿ºæäëîðïàâ³ôÿ÷ñìèòüáþ" +
                "ÉÖÓÊÅÍÃØÙÇÕ¯ªÆÄËÎÐÏÀÂ²Ôß×ÑÌÈÒÜÁÞ"+"qwertyuiopasdfghjklzxcvbnm"+"QWERTYUIOPASDFGHJKLZXCVBNM"+"@._1234567890";
            })
              .AddEntityFrameworkStores<AppDBContent>()
              .AddDefaultTokenProviders();
                       

            services.AddDbContext<AppDBContent>(opt =>
                opt.UseSqlServer(Configuration
                    .GetConnectionString("DefaultConnection")));

            services.AddTransient<IRepository, TeacherRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddControllersWithViews();
            services.AddMvc();
            services.AddMemoryCache();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                      name: "default",
                    pattern: "{controller=Account}/{action=Login}/{id?}");
            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetService<AppDBContent>();
                SeederDB.Initial(content);
            }

            SeederRole.SeedData(app.ApplicationServices, env, this.Configuration);
        }
    }
}
