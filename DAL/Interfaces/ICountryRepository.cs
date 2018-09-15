using ORM;
using System;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface ICountryRepository
    {
        List<Country> GetAll();

        Country GetById(Guid id);
    }
}
