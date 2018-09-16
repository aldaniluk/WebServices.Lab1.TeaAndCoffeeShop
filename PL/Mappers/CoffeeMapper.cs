using System;
using BLL.Models;
using PL.Models;

namespace PL.Mappers
{
    public static class CoffeeMapper
    {
        public static CoffeeView Map(this CoffeeBll coffee)
        {
            return new CoffeeView
            {
                Id = coffee.Id,
                Name = coffee.Name,
                Description = coffee.Description,
                CoffeeSort = coffee.CoffeeSort,
                MadeFromCountry = coffee.MadeFromCountry.Map(),
                PriceFor100Gr = coffee.PriceFor100Gr,
                Quality = coffee.Quality
            };
        }

        public static CoffeeBll Map(this CoffeeView coffee)
        {
            return new CoffeeBll
            {
                Id = coffee.Id,
                Name = coffee.Name,
                Description = coffee.Description,
                CoffeeSort = coffee.CoffeeSort,
                MadeFromCountry = coffee.MadeFromCountry.Map(),
                PriceFor100Gr = coffee.PriceFor100Gr,
                Quality = coffee.Quality
            };
        }
    }
}