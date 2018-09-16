using System.Collections.Generic;
using System.Linq;
using BLL.Mappers;
using BLL.Models;
using DAL.Interfaces;

namespace BLL.Services
{
    public class CoffeeService : ICoffeeService
    {
        private readonly ICoffeeRepository coffeeRepository;

        public CoffeeService(ICoffeeRepository coffeeRepository)
        {
            this.coffeeRepository = coffeeRepository;
        }

        public List<CoffeeBll> GetAll()
        {
            return coffeeRepository.GetAll().Select(CoffeeMapper.Map).ToList();
        }
    }
}
