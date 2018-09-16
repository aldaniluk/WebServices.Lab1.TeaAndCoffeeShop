using System.Collections.Generic;
using System.Linq;
using BLL.Mappers;
using BLL.Models;
using DAL.Interfaces;

namespace BLL.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }

        public List<CountryBll> GetAll()
        {
            return countryRepository.GetAll().Select(CountryMapper.Map).ToList();
        }
    }
}
