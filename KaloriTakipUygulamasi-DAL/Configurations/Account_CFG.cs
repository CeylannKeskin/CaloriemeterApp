using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Entities.Enums;

namespace KaloriTakipUygulamasi_DAL.Configurations
{
    public class Account_CFG : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts");
            builder.HasKey(x => x.AccountID);
            builder.Property(x => x.Email).HasMaxLength(50).HasColumnType("nvarchar").IsRequired();
            builder.Property(x => x.Country).HasMaxLength(50).HasColumnType("nvarchar");
            builder.Property(x => x.City).HasMaxLength(50).HasColumnType("nvarchar");
            builder.Property(x => x.BirthDate).HasColumnType("smalldatetime").HasColumnName("Birth Date");
            builder.Property(x => x.AccountType).HasColumnName("Account Type").HasColumnType("nvarchar").HasMaxLength(5);
            builder.Property(x => x.Password).HasMaxLength(50).HasColumnType("nvarchar").IsRequired();
            builder.Property(x => x.FirstName).HasColumnName("First Name").HasMaxLength(30).HasColumnType("nvarchar").IsRequired();
            builder.Property(x => x.LastName).HasColumnName("Last Name").HasMaxLength(30).HasColumnType("nvarchar").IsRequired();
            builder.Ignore(x => x.IsActive);
            builder.Property(x => x.CreatedTime).HasColumnName("Created Time").HasColumnType("smalldatetime");
            builder.Property(x => x.UpdatedTime).HasColumnName("Updated Time").HasColumnType("smalldatetime");
            builder.Property(x => x.PassivedTime).HasColumnName("Passived Time").HasColumnType("smalldatetime");
            builder.HasData(new Account
            {
                AccountID = 1,
                FirstName = "Samet",
                LastName = "Arslan",
                Email = "sametarsl@gmail.com",
                Password = "nG9E5OVTK0GbLkh38JIzZubiS1A=",
                Country = "Türkiye",
                City = "İstanbul",
                Gender = true,
                BirthDate = DateTime.Now,
                AccountType = AccountType.Admin,
                CreatedTime = DateTime.Now,
                UpdatedTime = DateTime.Now,
                IsActive = true,
                Age = 32
            });

        }
    }
}
