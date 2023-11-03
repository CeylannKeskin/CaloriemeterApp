using Entities.Concrete;
using Entities.Enums;
using System.Security.Cryptography.X509Certificates;

namespace CalorieTracker_BLL
{
    
    public class Account_BLL : ICRUD<Account>
    {
        Account? account;

        public void Create(Account entity)
        {
            BusinessLayer.db.Accounts.Add(entity);
            BusinessLayer.db.SaveChanges();
        }

        public void Delete(Account entity)
        {
            account = BusinessLayer.db.Accounts.FirstOrDefault(x => x.AccountID == entity.AccountID);
            account.PassivedTime = DateTime.Now;
            account.IsActive = false;
            BusinessLayer.db.SaveChanges();
        }

        public List<Account> List()
        {
            return BusinessLayer.db.Accounts.ToList();
        }

        public Account Search(string searchVariable)
        {

            return BusinessLayer.db.Accounts.FirstOrDefault(x => x.Email == searchVariable);
            
        }

        public void Update(Account entity)
        {
            account = Search(entity.Email);
            account.FirstName = entity.FirstName;
            account.LastName = entity.LastName;
            account.Email = entity.Email;
            account.Password = entity.Password;
            account.City = entity.City;
            account.Country = entity.Country;
            account.BirthDate = entity.BirthDate;
            account.UpdatedTime = entity.UpdatedTime = DateTime.Now;

            BusinessLayer.db.SaveChanges();
        }
    }
}