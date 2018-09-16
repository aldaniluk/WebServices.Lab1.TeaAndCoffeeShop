using BLL.Models;
using ORM;

namespace BLL.Mappers
{
    public static class TeaMapper
    {
        public static TeaBll Map(this Tea Tea)
        {
            return new TeaBll
            {
                Id = Tea.Id,
                Name = Tea.Name,
                Description = Tea.Description,
                TeaSort = (TeaSortBll)Tea.TeaSortId,
                MadeFromCountry = Tea.Country.Map(),
                PriceFor100Gr = Tea.PriceFor100Gr,
                Quality = (QualityBll)Tea.QualityId
            };
        }

        public static Tea Map(this TeaBll Tea)
        {
            return new Tea
            {
                Id = Tea.Id,
                Name = Tea.Name,
                Description = Tea.Description,
                TeaSortId = (int)Tea.TeaSort,
                MadeFromCountryId = Tea.MadeFromCountry.Id,
                PriceFor100Gr = Tea.PriceFor100Gr,
                QualityId = (int)Tea.Quality
            };
        }
    }
}