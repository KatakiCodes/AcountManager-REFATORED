using System;
using System.Collections.Generic;

namespace DataAccses.Contracts
{
    public interface IGenericRepository<Entity> where Entity:class
    {
        int Add(Entity entity);
        int Remove(int id);
        int Update(Entity entity);
        IEnumerable<Entity> GetAll();

    }
}
