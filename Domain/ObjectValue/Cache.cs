using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.ObjectValue
{
    public class Cache
    {
        private UserModel user;
        private AccountModel account;
        public Cache()
        {
            user = new UserModel();
            account = new AccountModel();
        }
    }
}
