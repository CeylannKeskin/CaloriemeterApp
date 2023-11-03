using Entities.Concrete;

namespace CalorieTracker_BLL
{
    public class FoodCategory_BLL : ICRUD<FoodCategory>
    {
        FoodCategory foodCategory;
        public void Create(FoodCategory entity)
        {
            BusinessLayer.db.FoodCategories.Add(entity);
            BusinessLayer.db.SaveChanges();
        }

        public void Delete(FoodCategory entity)
        {
            BusinessLayer.db.FoodCategories.Remove(Search(entity.FoodCategoryID.ToString()));
            BusinessLayer.db.SaveChanges();
        }

        public List<FoodCategory> List()
        {
            return BusinessLayer.db.FoodCategories.ToList();
        }

        public FoodCategory Search(string searchVariable)
        {
            return BusinessLayer.db.FoodCategories.Find(Convert.ToInt32(searchVariable));
        }

        public void Update(FoodCategory entity)
        {
            foodCategory = Search(entity.FoodCategoryID.ToString());
            foodCategory.CategoryName = entity.CategoryName;
            foodCategory.CategoryPicture = entity.CategoryPicture;
            BusinessLayer.db.SaveChanges();
        }
    }
}