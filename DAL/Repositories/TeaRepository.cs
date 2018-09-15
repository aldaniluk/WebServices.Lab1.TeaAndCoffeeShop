using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces;
using ORM;

namespace DAL.Repositories
{
    public class TeaRepository : ITeaRepository
    {
        private readonly TeaAndCoffeeDbContext context;

        public TeaRepository(TeaAndCoffeeDbContext context)
        {
            this.context = context;
        }

        public List<Tea> GetAll()
        {
            return context.Set<Tea>().ToList();
        }

        public Tea GetById(Guid id)
        {
            return context.Set<Tea>().FirstOrDefault(t => t.Id == id);
        }

        public void Create(Tea entity)
        {
            context.Set<Tea>().Add(entity);
            context.SaveChanges();
        }

        public void Update(Tea entity)
        {
            Tea teaToUpdate = context.Set<Tea>().FirstOrDefault(t => t.Id == entity.Id);
            context.Entry(teaToUpdate).CurrentValues.SetValues(entity);
            context.SaveChanges();
        }

        public void Delete(Tea entity)
        {
            Tea tea = context.Set<Tea>().FirstOrDefault(t => t.Id == entity.Id);
            context.Set<Tea>().Remove(tea);
            context.SaveChanges();
        }
    }
}
