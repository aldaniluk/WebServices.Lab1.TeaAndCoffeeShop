using DAL.Interfaces;
using ORM;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class QualityRepository : IQualityRepository
    {
        private readonly TeaAndCoffeeDbContext context;

        public QualityRepository(TeaAndCoffeeDbContext context)
        {
            this.context = context;
        }

        public List<Quality> GetAll()
        {
            return context.Set<Quality>().ToList();
        }

        public Quality GetById(int id)
        {
            return context.Set<Quality>().FirstOrDefault(q => q.Id == id);
        }
    }
}
