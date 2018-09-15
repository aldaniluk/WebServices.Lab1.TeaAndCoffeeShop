using DAL.Interfaces;
using ORM;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly TeaAndCoffeeDbContext context;

        public CountryRepository(TeaAndCoffeeDbContext context)
        {
            this.context = context;
        }

        public List<Country> GetAll()
        {
            return context.Set<Country>().ToList();
        }

        public Country GetById(Guid id)
        {
            return context.Set<Country>().FirstOrDefault(c => c.Id == id);
        }
    }
}
