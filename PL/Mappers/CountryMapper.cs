using BLL.Models;
using PL.Models;
using System;

namespace PL.Mappers
{
    public static class CountryMapper
    {
        public static CountryView Map(this CountryBll country)
        {
            return new CountryView
            {
                Id = country.Id,
                Name = country.Name
            };
        }

        public static CountryBll Map(this CountryView country)
        {
            return new CountryBll
            {
                Id = country.Id,
                Name = country.Name
            };
        }
    }
}