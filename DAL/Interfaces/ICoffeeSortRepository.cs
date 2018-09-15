using ORM;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface ICoffeeSortRepository
    {
        List<CoffeeSort> GetAll();

        CoffeeSort GetById(int id);
    }
}
