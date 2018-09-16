using System;

namespace BLL.Models
{
    public class CoffeeBll
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public CountryBll MadeFromCountry { get; set; }

        public decimal PriceFor100Gr { get; set; }

        public CoffeeSortBll CoffeeSort { get; set; }

        public QualityBll QualityId { get; set; }
    }
}