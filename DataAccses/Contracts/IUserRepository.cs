using DataAccses.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Contracts
{
    public interface IUserRepository : IGenericRepository<User>
    {
        //Other Methods
    }
}
