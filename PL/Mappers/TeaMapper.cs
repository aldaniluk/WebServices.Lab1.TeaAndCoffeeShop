using System;
using BLL.Models;
using PL.Models;

namespace PL.Mappers
{
    public static class TeaMapper
    {
        public static TeaView Map(this TeaBll tea)
        {
            return new TeaView
            {
                Id = tea.Id,
                Name = tea.Name,
                Description = tea.Description,
                TeaSort = tea.TeaSort,
                MadeFromCountry = tea.MadeFromCountry.Map(),
                PriceFor100Gr = tea.PriceFor100Gr,
                Quality = tea.Quality
            };
        }

        public static TeaBll Map(this TeaView tea)
        {
            return new TeaBll
            {
                Id = tea.Id,
                Name = tea.Name,
                Description = tea.Description,
                TeaSort = tea.TeaSort,
                MadeFromCountry = tea.MadeFromCountry.Map(),
                PriceFor100Gr = tea.PriceFor100Gr,
                Quality = tea.Quality
            };
        }
    }
}