using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces;
using ORM;

namespace DAL.Repositories
{
    public class CoffeeRepository : ICoffeeRepository
    {
        private readonly TeaAndCoffeeDbContext context;

        public CoffeeRepository(TeaAndCoffeeDbContext context)
        {
            this.context = context;
        }

        public List<Coffee> GetAll()
        {
            return context.Set<Coffee>().ToList();
        }

        public Coffee GetById(Guid id)
        {
            return context.Set<Coffee>().FirstOrDefault(c => c.Id == id);
        }

        public void Create(Coffee entity)
        {
            context.Set<Coffee>().Add(entity);
            context.SaveChanges();
        }

        public void Update(Coffee entity)
        {
            Coffee coffeeToUpdate = context.Set<Coffee>().FirstOrDefault(c => c.Id == entity.Id);
            context.Entry(coffeeToUpdate).CurrentValues.SetValues(entity);
            context.SaveChanges();
        }

        public void Delete(Coffee entity)
        {
            Coffee coffee = context.Set<Coffee>().FirstOrDefault(c => c.Id == entity.Id);
            context.Set<Coffee>().Remove(coffee);
            context.SaveChanges();
        }
    }
}
