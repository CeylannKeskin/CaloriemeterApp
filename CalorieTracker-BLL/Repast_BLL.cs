using Entities.Concrete;

namespace CalorieTracker_BLL
{
    public class Repast_BLL : ICRUD<Repast>
    {
        Repast repast;
        public void Create(Repast entity)
        {
            BusinessLayer.db.Repasts.Add(entity);
            BusinessLayer.db.SaveChanges();
        }

        public void Delete(Repast entity)
        {
            BusinessLayer.db.Repasts.Remove(Search(entity.RepastID.ToString()));
            BusinessLayer.db.SaveChanges();
        }

        public List<Repast> List()
        {
            return BusinessLayer.db.Repasts.ToList();
        }

        public Repast Search(string searchVariable)
        {
            return BusinessLayer.db.Repasts.Find(Convert.ToInt32(searchVariable));
        }

        public void Update(Repast entity)
        {
            repast = Search(entity.RepastID.ToString());
            repast.RepastName = entity.RepastName;
            BusinessLayer.db.SaveChanges();
        }
    }
}