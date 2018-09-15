using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces;
using ORM;

namespace DAL.Repositories
{
    public class CoffeeSortRepository : ICoffeeSortRepository
    {
        private readonly TeaAndCoffeeDbContext context;

        public CoffeeSortRepository(TeaAndCoffeeDbContext context)
        {
            this.context = context;
        }

        public List<CoffeeSort> GetAll()
        {
            return context.Set<CoffeeSort>().ToList();
        }

        public CoffeeSort GetById(int id)
        {
            return context.Set<CoffeeSort>().FirstOrDefault(cs => cs.Id == id);
        }
    }
}
