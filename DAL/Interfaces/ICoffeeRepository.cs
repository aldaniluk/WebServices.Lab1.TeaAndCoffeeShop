using ORM;
using System;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    interface ICoffeeRepository
    {
        List<Coffee> GetAll();

        Coffee GetById(Guid id);

        void Create(Coffee entity);

        void Update(Coffee entity);

        void Delete(Coffee entity);
    }
}
