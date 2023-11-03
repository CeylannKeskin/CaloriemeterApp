using Entities.Concrete;
using KaloriTakipUygulamasi_DAL;

namespace CalorieTracker_BLL
{
    public class UserFood_BLL : ICRUD<UserFood>
    {
        KTUContext db = new KTUContext();
        UserFood userFood;
        public void Create(UserFood entity)
        {
            BusinessLayer.db.UserFoods.Add(entity);
            BusinessLayer.db.SaveChanges();
        }

        public void Delete(UserFood entity)
        {
            BusinessLayer.db.UserFoods.Remove(Search(entity.UserFoodID.ToString()));
            BusinessLayer.db.SaveChanges();
        }
        public object SelectedFoods(User user)
        {
            DateTime now = DateTime.Now;
            var result = db.UserFoods.Where(x => x.AccountID == user.AccountID &&
                                                 x.AddedTime != null &&
                                                 x.AddedTime.Value.Day == now.Day &&
                                                 x.AddedTime.Value.Month == now.Month &&
                                                 x.AddedTime.Value.Year == now.Year)
                                    .Join(db.Foods, userfood => userfood.FoodID, food => food.FoodID, (userfood, food) => new { userfood, food })
                                    .Join(db.Repasts, u => u.userfood.RepastID, repast => repast.RepastID, (u, repast) => new { u.userfood, u.food, repast })
                                    .Select(x => new
                                    {
                                        UserFoodID = x.userfood.UserFoodID,
                                        FoodName = x.food.FoodName,
                                        Calorie = x.userfood.Calorie,
                                        Carbonhydrate = x.userfood.Carbonhydrate,
                                        Protein = x.userfood.Protein,
                                        Fat = x.userfood.Fat,
                                        Amount = x.userfood.Amount,
                                        RepastName = x.repast.RepastName,
                                        AddedTime = x.userfood.AddedTime,
                                    }).ToList();

            return result;
        }

        public List<UserFood> List()
        {
            return BusinessLayer.db.UserFoods.ToList();
        }

        public UserFood Search(string searchVariable)
        {
            return BusinessLayer.db.UserFoods.Find(Convert.ToInt32(searchVariable));
        }

        public void Update(UserFood entity)
        {
            userFood = Search(entity.UserFoodID.ToString());
            userFood.FoodID = entity.FoodID;
            userFood.Calorie = entity.Calorie;
            userFood.Fat = entity.Fat;
            userFood.Carbonhydrate = entity.Carbonhydrate;
            userFood.Protein = entity.Protein;
            userFood.Amount = entity.Amount;
            userFood.AddedTime = DateTime.Now;

            BusinessLayer.db.SaveChanges();
        }
    }
}