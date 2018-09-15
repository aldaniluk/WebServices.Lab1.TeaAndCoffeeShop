using DAL.Interfaces;
using ORM;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class TeaSortRepository : ITeaSortRepository
    {
        private readonly TeaAndCoffeeDbContext context;

        public TeaSortRepository(TeaAndCoffeeDbContext context)
        {
            this.context = context;
        }

        public List<TeaSort> GetAll()
        {
            return context.Set<TeaSort>().ToList();
        }

        public TeaSort GetById(int id)
        {
            return context.Set<TeaSort>().FirstOrDefault(ts => ts.Id == id);
        }
    }
}
