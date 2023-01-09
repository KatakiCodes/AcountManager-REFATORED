using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.ObjectValue
{
    public static class Cache
    {
        public static UserModel user = new UserModel();
        public static List<AccountModel> account = new List<AccountModel>();
    }
}
