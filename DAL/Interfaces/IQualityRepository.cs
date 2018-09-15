using ORM;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IQualityRepository
    {
        List<Quality> GetAll();

        Quality GetById(int id);
    }
}
