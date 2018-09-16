using System;

namespace BLL.Models
{
    public class TeaBll
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public CountryBll MadeFromCountry { get; set; }

        public decimal PriceFor100Gr { get; set; }

        public TeaSortBll TeaSort { get; set; }

        public QualityBll Quality { get; set; }
    }
}