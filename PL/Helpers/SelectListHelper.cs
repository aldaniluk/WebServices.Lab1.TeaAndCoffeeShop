using BLL.Models;
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
        public static SelectList GetCountries()
        {
            List<CountryView> countries = ParseFromResponseHelper.GetObject<List<CountryBll>>("Country")
                .OrderBy(c => c.Name).Select(CountryMapper.Map).ToList();

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