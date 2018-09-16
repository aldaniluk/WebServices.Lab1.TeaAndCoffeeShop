using BLL.Models;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace BLL.Services
{
    [ServiceContract]
    public interface ITeaService
    {
        [OperationContract]
        List<TeaBll> GetAll();

        [OperationContract]
        TeaBll GetById(Guid id);

        [OperationContract]
        void Update(TeaBll coffee);

        [OperationContract]
        void Delete(TeaBll coffee);

        [OperationContract]
        void Create(TeaBll coffee);
    }
}
