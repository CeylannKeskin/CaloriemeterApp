using Entities;
using Entities.Concrete;
using KaloriTakipUygulamasi_DAL.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipUygulamasi_DAL
{
    public class KTUContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Repast> Repasts { get; set; }
        public DbSet<UserFood> UserFoods { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=CalorieTrackerDB;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Account_CFG())
                .ApplyConfiguration(new Food_CFG())
                .ApplyConfiguration(new FoodCategory_CFG())
                .ApplyConfiguration(new Repast_CFG())
                .ApplyConfiguration(new User_CFG())
                .ApplyConfiguration(new UserFood_CFG());
        }
    }
}
