using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Plan.Data.Entities
{
    public class AppDBContent : IdentityDbContext<DbUser, DbRole, long, IdentityUserClaim<long>,
                                            DbUserRole, IdentityUserLogin<long>,
                                            IdentityRoleClaim<long>, IdentityUserToken<long>>
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }
        public DbSet<CharacteristicGroupsSemestr1> Characteristic1Semestr { get; set; } 
        public DbSet<CharacteristicGroupsSemestr2> Characteristic2Semestr { get; set; } 
        public DbSet<LectureClassesTableSemestr1> LectureClassesSemestr1 { get; set; } 
        public DbSet<LectureClassesTableSemestr2> LectureClassesSemestr2 { get; set; } 
        public DbSet<LectureClassesTableNameSum> LectureClassesNameSums { get; set; } 
        public DbSet<ControlMeasuresSemestr1> ControlSemestr1 { get; set; } 
        public DbSet<ControlMeasuresSemestr2> ControlSemestr2 { get; set; } 
        public DbSet<MethodicalWork> MethodicalWork { get; set; } 
        public DbSet<ScientificWork> ScientificWork { get; set; } 
        public DbSet<OrganizationalWork> OrganizationalWork { get; set; } 
        public DbSet<EducationalActivities> EducationalActivities { get; set; }  
        public DbSet<ChangesWorkPlan> ChangesWorkPlan { get; set; }  
        public DbSet<OtherTypesWork> OtherTypesWork { get; set; }   
        public DbSet<OtherTypesWorkSemestr2> OtherTypesWorkSemestr2 { get; set; }   
        public DbSet<WorkloadSum> WorkloadSum { get; set; }   
        public DbSet<UserNames> UserNames { get; set; }   
        public DbSet<NameSubject> NameSubject { get; set; }   
         

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<DbUserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });
        }
    }
}
