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
    internal class Repast_CFG : IEntityTypeConfiguration<Repast>
    {
        public void Configure(EntityTypeBuilder<Repast> builder)
        {
            builder.ToTable("Repasts");
            builder.HasMany(x => x.Users).WithMany(x => x.Repasts);
            builder.Property(x=>x.RepastName).HasColumnName("Repast Name").HasMaxLength(10).HasColumnType("nvarchar").IsRequired();
            builder.Ignore(x => x.AccountID);
            builder.HasData(
                new Repast { RepastID = 1, RepastName = "Breakfast" },
                new Repast { RepastID = 2, RepastName = "Lunch" },
                new Repast { RepastID = 3, RepastName = "Dinner" },
                new Repast { RepastID = 4, RepastName = "Snack" }
                );
        }
    }
}
