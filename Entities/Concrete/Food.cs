using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Food
    {
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public int? FoodCategoryID { get; set; }
        public double? Calorie { get; set; }
        public double? Fat { get; set; }
        public double? Carbonhydrate { get; set; }
        public double? Protein { get; set; }
        public string? Description { get; set; }
        public string? FoodPicture { get; set; }
        public double? Amount { get; set; }
        public int? Counter { get; set; } = 0;
        public ICollection<UserFood>? UserFoods { get; set; }

        public FoodCategory? FoodCategory { get; set; }
        public Food()
        {
            UserFoods = new HashSet<UserFood>();
        }

    }
}
