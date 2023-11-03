using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserFood
    {
        public int UserFoodID { get; set; }

        public int AccountID { get; set; }
        public int FoodID { get; set; }
        public double? Calorie { get; set; }
        public double? Fat { get; set; }
        public double? Carbonhydrate { get; set; }
        public double? Protein { get; set; }
        public double? Amount { get; set; }
        public int? RepastID { get; set; }
        public DateTime? AddedTime { get; set; }
        public User? Users { get; set; }
        public Food? Foods { get; set; }
        public Repast? Repast { get; set; }

    }
}
