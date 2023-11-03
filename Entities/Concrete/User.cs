using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User
    {
        public int AccountID { get; set; }
        public double? DailyCalories { get; set; } = 0;
        public double? DailyFat { get; set; } = 0;
        public double? DailyCarbonhydrate { get; set; } = 0;
        public double? DailyProtein { get; set; } = 0;
        public double? LimitOfCalories { get; set; } = 0;
        public double? LimitOfProtein { get; set; } = 0;
        public double? LimitOfCarbonhydrate { get; set; } = 0;
        public double? LimitOfFat { get; set; } = 0;
        public double? Height { get; set; } = 0;
        public double? Weight { get; set; } = 0;
        public double? UserBMI { get; set; }
        public BMIStatus? BMIStatus { get; set; }
        public double? BMR { get; set; } //Basal Metabolic Rate

        // public double AmountOfWater { get; set; }
        public int? RepastID { get; set; }
        public ICollection<Repast>? Repasts { get; set; }
        public ICollection<UserFood>? UserFoods { get; set; }

        public Account? Account { get; set; }

        public User()
        {
            Repasts = new HashSet<Repast>();
            UserFoods = new HashSet<UserFood>();
        }
    }
}
