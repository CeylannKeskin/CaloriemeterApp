using Entities.Concrete;

namespace CalorieTracker_BLL
{
    public class Food_BLL : ICRUD<Food>
    {
        Food food;
        public void Create(Food entity)
        {
            BusinessLayer.db.Foods.Add(entity);
            BusinessLayer.db.SaveChanges();
        }

        public void Delete(Food entity)
        {
            BusinessLayer.db.Foods.Remove(Search(entity.FoodID.ToString()));
            BusinessLayer.db.SaveChanges();
        }

        public List<Food> List()
        {
            return BusinessLayer.db.Foods.ToList();
        }

        public Food Search(string searchVariable)
        {
            return BusinessLayer.db.Foods.Find(Convert.ToInt32(searchVariable));
        }
        public object SearchFoodCategoryList(string searchVariable)
        {
            var result = BusinessLayer.db.Foods.Where(x => x.FoodName.Contains(searchVariable)).Select(x => new
            {
                x.FoodID,
                x.FoodName,
                x.FoodCategory.CategoryName,
                x.Calorie,
                x.Protein,
                x.Carbonhydrate,
                x.Fat,
                x.FoodPicture,
                x.Counter
            }).OrderByDescending(x => x.Counter).ToList();
            return result;
        }
        public void Update(Food entity)
        {
            food = Search(entity.FoodID.ToString());
            food.FoodName = entity.FoodName;
            food.FoodCategoryID = entity.FoodCategoryID;
            food.Calorie = entity.Calorie;
            food.Fat = entity.Fat;
            food.Carbonhydrate = entity.Carbonhydrate;
            food.Protein = entity.Protein;
            food.Description = entity.Description;
            food.FoodPicture = entity.FoodPicture;
            BusinessLayer.db.SaveChanges();
        }
        public Food SearchFoodName(string searchVariable)
        {
            return BusinessLayer.db.Foods.FirstOrDefault(x => x.FoodName.Equals(searchVariable));
        }
    }
}