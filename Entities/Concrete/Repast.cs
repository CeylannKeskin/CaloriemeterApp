using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Repast
    {
        public int RepastID { get; set; }
        public string RepastName { get; set; }

        public int? AccountID { get; set; }
        public ICollection<User>? Users { get; set; }
        public ICollection<UserFood>? UserFoods { get; set; }
        public Repast()
        {
            Users = new HashSet<User>();
            UserFoods = new HashSet<UserFood>();
        }
    }
}
