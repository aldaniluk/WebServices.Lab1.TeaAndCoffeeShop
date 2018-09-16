using BLL.Mappers;
using BLL.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class TeaService : ITeaService
    {
        private readonly ITeaRepository TeaRepository;

        public TeaService(ITeaRepository TeaRepository)
        {
            this.TeaRepository = TeaRepository;
        }

        public void Create(TeaBll Tea)
        {
            TeaRepository.Create(Tea.Map());
        }

        public void Delete(TeaBll Tea)
        {
            TeaRepository.Delete(Tea.Map());
        }

        public List<TeaBll> GetAll()
        {
            return TeaRepository.GetAll().Select(TeaMapper.Map).ToList();
        }

        public TeaBll GetById(Guid id)
        {
            return TeaRepository.GetById(id).Map();
        }

        public void Update(TeaBll Tea)
        {
            TeaRepository.Update(Tea.Map());
        }
    }
}
