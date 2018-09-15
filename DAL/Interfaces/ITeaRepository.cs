using ORM;
using System;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    interface ITeaRepository
    {
        List<Tea> GetAll();

        Tea GetById(Guid id);

        void Create(Tea entity);

        void Update(Tea entity);

        void Delete(Tea entity);
    }
}
