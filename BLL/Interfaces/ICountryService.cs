using BLL.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace BLL.Services
{
    [ServiceContract]
    public interface ICountryService
    {
        [OperationContract]
        List<CountryBll> GetAll();
    }
}
