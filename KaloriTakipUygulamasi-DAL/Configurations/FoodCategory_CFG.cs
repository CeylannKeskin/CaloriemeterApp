using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipUygulamasi_DAL.Configurations
{
    public class FoodCategory_CFG : IEntityTypeConfiguration<FoodCategory>
    {
        public void Configure(EntityTypeBuilder<FoodCategory> builder)
        {
            builder.ToTable("Food Categories");
            builder.HasMany(x => x.Foods).WithOne(x => x.FoodCategory).HasForeignKey(x => x.FoodCategoryID);
            builder.Property(x=>x.CategoryName).HasColumnType("nvarchar").HasMaxLength(50).HasColumnName("Category Name").HasMaxLength(50).IsRequired();
            builder.Property(x=>x.CategoryPicture).HasColumnType("nvarchar").HasMaxLength(250).HasColumnName("Category Picture");
            builder.Ignore(x => x.FoodID);
            builder.HasData(
                            new FoodCategory { FoodCategoryID = 1, CategoryName = "Meats", CategoryPicture = "../../../images/foodcategoryicons/meat.png" },

                            new FoodCategory { FoodCategoryID = 2, CategoryName = "Poultry", CategoryPicture = "../../../images/foodcategoryicons/poultry.png" },

                            new FoodCategory { FoodCategoryID = 3, CategoryName = "Vegetables and Legumes", CategoryPicture = "../../../images/foodcategoryicons/vegetable.png" },

                            new FoodCategory { FoodCategoryID = 4, CategoryName = "Grain Products", CategoryPicture = "../../../images/foodcategoryicons/grain.png" },

                            new FoodCategory { FoodCategoryID = 5, CategoryName = "Eggs", CategoryPicture = "../../../images/foodcategoryicons/egg.png" },

                            new FoodCategory { FoodCategoryID = 6, CategoryName = "Dairy Products", CategoryPicture = "../../../images/foodcategoryicons/dairy.png" },

                            new FoodCategory { FoodCategoryID = 7, CategoryName = "Fruits", CategoryPicture = "../../../images/foodcategoryicons/fruit.png" },

                            new FoodCategory { FoodCategoryID = 8, CategoryName = "Soups", CategoryPicture = "../../../images/foodcategoryicons/soups.png" },

                            new FoodCategory { FoodCategoryID = 9, CategoryName = "Main Dishes", CategoryPicture = "../../../images/foodcategoryicons/MainDishes.png" },

                            new FoodCategory { FoodCategoryID = 10, CategoryName = "Complementary Meals", CategoryPicture = "../../../images/foodcategoryicons/ComplementaryMeals.png" },

                            new FoodCategory { FoodCategoryID = 11, CategoryName = "Salads", CategoryPicture = "../../../images/foodcategoryicons/Salads.png" },

                            new FoodCategory { FoodCategoryID = 12, CategoryName = "Desserts", CategoryPicture = "../../../images/foodcategoryicons/Desserts.png" }
                            );
        }
    }
}
