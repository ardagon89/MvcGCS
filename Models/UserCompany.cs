using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCS.Models
{
    public class UserCompany
    {
        public User vuser { get; set; }
        public Company vcompany { get; set; }
        public UserCompany(User user, Company company)
        {
            this.vuser = user;
            this.vcompany = company;
        }

    }
}
