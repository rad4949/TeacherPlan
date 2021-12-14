using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.Data.Entities
{
    public class SeederRole
    {
        public static void SeedData(IServiceProvider services,
           IWebHostEnvironment env, IConfiguration config)
        {
            using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var manager = scope.ServiceProvider.GetRequiredService<UserManager<DbUser>>();
                var managerRole = scope.ServiceProvider.GetRequiredService<RoleManager<DbRole>>();
                var context = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                var roleName = "Admin";
                var result = managerRole.CreateAsync(new DbRole
                {
                    Name = roleName
                }).Result;

                roleName = "Manager";
                result = managerRole.CreateAsync(new DbRole
                {
                    Name = roleName
                }).Result;

                roleName = "Teacher";
                result = managerRole.CreateAsync(new DbRole
                {
                    Name = roleName
                }).Result;

                string email = "teacher@gmail.com";
                var user = new DbUser
                {
                    Email = email,
                    UserName = email,
                    PhoneNumber = "0508779868"
                };
                result = manager.CreateAsync(user, "qwerty-0").Result;
                result = manager.AddToRoleAsync(user, roleName).Result;

                email = "admin@gmail.com";
                var admin = new DbUser
                {
                    Email = email,
                    UserName = email,
                    PhoneNumber = "0665001700"
                };
                result = manager.CreateAsync(admin, "qwerty-0").Result;
                result = manager.AddToRoleAsync(admin, "Admin").Result;
            }
        }
    }
}
