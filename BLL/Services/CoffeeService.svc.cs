using System;
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

        public void Create(CoffeeBll coffee)
        {
            coffeeRepository.Create(coffee.Map());
        }

        public void Delete(CoffeeBll coffee)
        {
            coffeeRepository.Delete(coffee.Map());
        }

        public List<CoffeeBll> GetAll()
        {
            return coffeeRepository.GetAll().Select(CoffeeMapper.Map).ToList();
        }

        public CoffeeBll GetById(Guid id)
        {
            return coffeeRepository.GetById(id).Map();
        }

        public void Update(CoffeeBll coffee)
        {
            coffeeRepository.Update(coffee.Map());
        }
    }
}
