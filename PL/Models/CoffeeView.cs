using BLL.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace PL.Models
{
    public class CoffeeView
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public CountryView MadeFromCountry { get; set; }

        [Required]
        public decimal PriceFor100Gr { get; set; }

        [Required]
        public CoffeeSortBll CoffeeSort { get; set; }

        [Required]
        public QualityBll Quality { get; set; }
    }
}