using BLL.Models;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace BLL.Services
{
    [ServiceContract]
    [ServiceKnownType(typeof(CountryBll))]
    public interface ICoffeeService
    {
        [OperationContract]
        List<CoffeeBll> GetAll();

        [OperationContract]
        CoffeeBll GetById(Guid id);

        [OperationContract]
        void Update(CoffeeBll coffee);

        [OperationContract]
        void Delete(CoffeeBll coffee);

        [OperationContract]
        void Create(CoffeeBll coffee);
    }
}
