using System.Collections.Generic;
using System.Linq;
using BLL.Mappers;
using BLL.Models;
using DAL.Repositories;
using ORM;

namespace BLL.Services
{
    public class CoffeeService : ICoffeeService
    {
        private readonly CoffeeRepository coffeeRepository;

        public CoffeeService()
        {
            var context = new TeaAndCoffeeDbContext();
            this.coffeeRepository = new CoffeeRepository(context);
        }

        public List<CoffeeBll> GetAll()
        {
            return coffeeRepository.GetAll().Select(CoffeeMapper.Map).ToList();
        }
    }
}
