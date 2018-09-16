using BLL.Models;
using ORM;

namespace BLL.Mappers
{
    public static class CountryMapper
    {
        public static CountryBll Map(this Country country)
        {
            return new CountryBll
            {
                Id = country.Id,
                Name = country.Name
            };
        }
    }
}