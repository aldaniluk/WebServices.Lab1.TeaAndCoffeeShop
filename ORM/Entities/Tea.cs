namespace ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tea")]
    public partial class Tea
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public decimal PriceFor100Gr { get; set; }

        public Guid MadeFromCountryId { get; set; }

        public int TeaSortId { get; set; }

        public int QualityId { get; set; }

        public virtual Country Country { get; set; }

        public virtual Quality Quality { get; set; }

        public virtual TeaSort TeaSort { get; set; }
    }
}
