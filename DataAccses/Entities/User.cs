using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Entity
{
    public class User
    {
        public int id_pk { get; set; }
        public string password { get; set; }
        public string alt_password { get; set; }
        public List<Account> Accounts = new List<Account>();

        //CONSTRUCTORS
        public User()
        {
        }

        public User(int id_pk, string password, string alt_password)
        {
            this.id_pk = id_pk;
            this.password = password;
            this.alt_password = alt_password;
        }
    }
}
