namespace ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Coffee")]
    public partial class Coffee
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public Guid MadeFromCountryId { get; set; }

        public decimal PriceFor100Gr { get; set; }

        public int CoffeeSortId { get; set; }

        public int QualityId { get; set; }

        public virtual CoffeeSort CoffeeSort { get; set; }

        public virtual Country Country { get; set; }

        public virtual Quality Quality { get; set; }
    }
}
