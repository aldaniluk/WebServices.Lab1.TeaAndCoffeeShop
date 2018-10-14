using BLL.Mappers;
using BLL.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BLL.WebApi.Controllers
{
    public class TeaController : ApiController
    {
        private readonly ITeaRepository TeaRepository;

        public TeaController(ITeaRepository TeaRepository)
        {
            this.TeaRepository = TeaRepository;
        }

        [HttpPost]
        public void Create([FromBody]TeaBll Tea)
        {
            TeaRepository.Create(Tea.Map());
        }

        [HttpDelete]
        public void Delete([FromBody]TeaBll Tea)
        {
            TeaRepository.Delete(Tea.Map());
        }

        [HttpGet]
        public List<TeaBll> GetAll()
        {
            return TeaRepository.GetAll().Select(TeaMapper.Map).ToList();
        }

        [HttpGet]
        public TeaBll GetById(Guid id)
        {
            return TeaRepository.GetById(id).Map();
        }

        [HttpPut]
        public void Update([FromBody]TeaBll Tea)
        {
            TeaRepository.Update(Tea.Map());
        }
    }
}
