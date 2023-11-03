using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTracker_BLL
{
    public interface ICRUD<T> where T : class
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Search(string searchVariable);
        List<T> List();
    }
}
