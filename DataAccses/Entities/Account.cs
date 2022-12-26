using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Entity
{
    public class Account
    {
        //Properties
       public int id_pk { get; set; }
       public string plataform { get; set; }
       public string email { get; set; }
       public string password { get; set; }
       public string user { get; set; }
       public int contact { get; set; }

        //Constructor
        public Account()
        {

        }

        public Account(int id_pk, string plataform, string email, string password, string user, int contact)
        {
            this.id_pk = id_pk;
            this.plataform = plataform;
            this.email = email;
            this.password = password;
            this.user = user;
            this.contact = contact;
        }

    }
}
