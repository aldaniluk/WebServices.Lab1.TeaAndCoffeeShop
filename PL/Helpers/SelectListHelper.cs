using PL.CountryServiceReference;
using PL.Mappers;
using PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PL.Helpers
{
    public static class SelectListHelper
    {
        public static SelectList GetCountries(ICountryService countryService)
        {
            List<CountryView> countries = countryService.GetAll().OrderBy(c => c.Name).Select(CountryMapper.Map)
                .ToList();

            return new SelectList(countries, "Id", "Name");
        }

        public static SelectList GetEnum<T>() where T : struct
        {
            IEnumerable<T> enumValues = Enum.GetValues(typeof(T)).Cast<T>();

            return new SelectList(enumValues.Select(ev => new
            {
                Id = (int)(object)ev,
                Name = ev.ToString()
            }),
            "Id", "Name");
        }
    }
}