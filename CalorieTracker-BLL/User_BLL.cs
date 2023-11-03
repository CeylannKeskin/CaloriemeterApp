using Entities.Concrete;

namespace CalorieTracker_BLL
{
    public class User_BLL : ICRUD<User>
    {
        User user;
        public void Create(User entity)
        {
            BusinessLayer.db.Users.Add(entity);
            BusinessLayer.db.SaveChanges();
        }

        public void Delete(User entity)
        {
            BusinessLayer.db.Users.Remove(Search(entity.AccountID.ToString()));
            BusinessLayer.db.SaveChanges();
        }

        public List<User> List()
        {
            return BusinessLayer.db.Users.ToList();
        }

        public User Search(string searchVariable)
        {
            return BusinessLayer.db.Users.Find(Convert.ToInt32(searchVariable));
        }

        public void Update(User entity)
        {
            user = Search(entity.AccountID.ToString());
            user.DailyCalories = entity.DailyCalories;
            user.DailyFat = entity.DailyFat;
            user.DailyCarbonhydrate = entity.DailyCarbonhydrate;
            user.DailyProtein = entity.DailyProtein;
            user.LimitOfCalories = entity.LimitOfCalories;
            user.Height = entity.Height;
            user.Weight = entity.Weight;

            BusinessLayer.db.SaveChanges();
        }
    }
}