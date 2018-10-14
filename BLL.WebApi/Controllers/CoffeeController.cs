using BLL.Mappers;
using BLL.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BLL.WebApi.Controllers
{
    public class CoffeeController : ApiController
    {
        private readonly ICoffeeRepository coffeeRepository;

        public CoffeeController(ICoffeeRepository coffeeRepository)
        {
            this.coffeeRepository = coffeeRepository;
        }

        [HttpPost]
        public void Create([FromBody]CoffeeBll coffee)
        {
            coffeeRepository.Create(coffee.Map());
        }

        [HttpDelete]
        public void Delete([FromBody]CoffeeBll coffee)
        {
            coffeeRepository.Delete(coffee.Map());
        }

        [HttpGet]
        public List<CoffeeBll> Filter(CoffeeSortBll sort, Guid countryId)
        {
            return coffeeRepository.GetAll().Where(c => c.CoffeeSortId == (int)sort && c.Country.Id == countryId)
                .Select(CoffeeMapper.Map).ToList();
        }

        [HttpGet]
        public List<CoffeeBll> GetAll()
        {
            return coffeeRepository.GetAll().Select(CoffeeMapper.Map).ToList();
        }

        [HttpGet]
        public CoffeeBll GetById(Guid id)
        {
            return coffeeRepository.GetById(id).Map();
        }

        [HttpPut]
        public void Update([FromBody]CoffeeBll coffee)
        {
            coffeeRepository.Update(coffee.Map());
        }
    }
}
