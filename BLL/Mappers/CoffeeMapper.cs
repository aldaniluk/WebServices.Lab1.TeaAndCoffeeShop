using BLL.Models;
using ORM;

namespace BLL.Mappers
{
    public static class CoffeeMapper
    {
        public static CoffeeBll Map(this Coffee coffee)
        {
            return new CoffeeBll
            {
                Id = coffee.Id,
                Name = coffee.Name,
                Description = coffee.Description,
                CoffeeSort = (CoffeeSortBll)coffee.CoffeeSortId,
                MadeFromCountry = coffee.Country.Map(),
                PriceFor100Gr = coffee.PriceFor100Gr,
                QualityId = (QualityBll)coffee.QualityId
            };
        }
    }
}