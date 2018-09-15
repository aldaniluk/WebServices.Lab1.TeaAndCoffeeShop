using ORM;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface ITeaSortRepository
    {
        List<TeaSort> GetAll();

        TeaSort GetById(int id);
    }
}
