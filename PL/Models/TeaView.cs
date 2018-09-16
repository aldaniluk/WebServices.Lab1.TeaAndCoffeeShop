using BLL.Models;
using System;

namespace PL.Models
{
    public class TeaView
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public CountryView MadeFromCountry { get; set; }

        public decimal PriceFor100Gr { get; set; }

        public TeaSortBll TeaSort { get; set; }

        public QualityBll Quality { get; set; }
    }
}