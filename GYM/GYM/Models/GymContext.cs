using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using GYM.Models;

namespace GYM.Models
{
    public class GymContext : DbContext
    {
        public GymContext() : base("GYM")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GymContext, Migrations.Configuration>("GYM"));
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PreRegisterationForm> PreRegisterationForms { get; set; }
        public DbSet<User> Users { get; set; }
    }
}