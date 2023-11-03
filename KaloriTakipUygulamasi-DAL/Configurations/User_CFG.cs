using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipUygulamasi_DAL.Configurations
{
    public class User_CFG : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey("AccountID");
            builder.HasOne(x => x.Account).WithOne(x => x.User);
            builder.HasMany(x => x.Repasts).WithMany(x => x.Users);
            builder.Property(x => x.DailyCalories).HasColumnName("Daily Calorie");
            builder.Property(x=>x.DailyProtein).HasColumnName("Daily Protein");
            builder.Property(x=>x.DailyFat).HasColumnName("Daily Fat");
            builder.Property(x=>x.DailyCarbonhydrate).HasColumnName("Daily Carbonhydrate");
            builder.Property(x => x.LimitOfCalories).HasColumnName("Limit Of Calories");
            builder.Property(x => x.RepastID).HasColumnName("Repast");
            builder.Property(x => x.UserBMI).HasColumnName("User BMI");
            builder.Property(x => x.BMIStatus).HasColumnName("BMI Status").HasColumnType("nvarchar").HasMaxLength(11);
            builder.HasData(new User
            {
                AccountID = 1,
                Height = 183,
                Weight = 89,
                UserBMI = 2
            });
        }
    }
}
