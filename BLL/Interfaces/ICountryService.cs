using BLL.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace BLL.Services
{
    [ServiceContract]
    [ServiceKnownType(typeof(CountryBll))]
    public interface ICountryService
    {
        [OperationContract]
        List<CountryBll> GetAll();
    }
}
