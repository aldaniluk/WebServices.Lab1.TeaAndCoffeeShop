using BLL.Mappers;
using BLL.Models;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BLL.WebApi.Controllers
{
    public class CountryController : ApiController
    {
        private readonly ICountryRepository countryRepository;

        public CountryController(ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }

        [HttpGet]
        public List<CountryBll> GetAll()
        {
            return countryRepository.GetAll().Select(CountryMapper.Map).ToList();
        }
    }
}
