using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Account
    {
        public int AccountID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public int? Age { get; set; }
        public AccountType AccountType { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime UpdatedTime { get; set; }
        public DateTime? PassivedTime { get; set; }


        public User User { get; set; }
    }
}
