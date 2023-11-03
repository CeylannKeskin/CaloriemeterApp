using Entities.Concrete;
using KaloriTakipUygulamasi_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTracker_BLL
{
    public class BusinessLayer
    {
        public static KTUContext? db;

        public BusinessLayer()
        {
            db = new KTUContext();

            Accounts = new Account_BLL();
            Foods = new Food_BLL();
            FoodCategories = new FoodCategory_BLL();
            Repasts = new Repast_BLL();
            Users = new User_BLL();
            UserFoods = new UserFood_BLL();
        }

        public Account_BLL Accounts { get; set; }
        public Food_BLL Foods { get; set; }
        public FoodCategory_BLL FoodCategories { get; set; }
        public Repast_BLL Repasts { get; set; }
        public User_BLL Users { get; set; }
        public UserFood_BLL UserFoods { get; set; }
    }
}
