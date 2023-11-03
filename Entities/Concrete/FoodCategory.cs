using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class FoodCategory
    {
        public int FoodCategoryID { get; set; }
        public string CategoryName { get; set; }
        public string? CategoryPicture { get; set; }
        public int FoodID { get; set; }
        public ICollection<Food>? Foods { get; set; }

        public FoodCategory()
        {
            Foods = new HashSet<Food>();
        }
    }
}
