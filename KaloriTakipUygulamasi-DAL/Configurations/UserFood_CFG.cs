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
    public class UserFood_CFG : IEntityTypeConfiguration<UserFood>
    {
        public void Configure(EntityTypeBuilder<UserFood> builder)
        {
            builder.HasKey(x => x.UserFoodID);
            builder.HasOne(x => x.Users).WithMany(x => x.UserFoods);
            builder.HasOne(x => x.Foods).WithMany(x => x.UserFoods);
            builder.HasOne(x => x.Repast).WithMany(x => x.UserFoods);
            builder.Property(x => x.UserFoodID).HasColumnName("User Food ID");
            builder.Property(x => x.AddedTime).HasColumnType("datetime").HasColumnName("Added Time").IsRequired();
            builder.Property(x => x.RepastID).HasColumnName("Repast ID");
            builder.Property(x => x.FoodID).HasColumnName("Food ID").IsRequired();
            builder.Property(x => x.AccountID).HasColumnName("Account ID").IsRequired();
        }
    }
}
