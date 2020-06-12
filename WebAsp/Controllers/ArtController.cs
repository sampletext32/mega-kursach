using System.Collections;
using System.Collections.Generic;
using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtController : ControllerBase
    {
        private IArtRepository _repository;

        public ArtController(IArtRepository artRepository)
        {
            _repository = artRepository;
        }

        [HttpGet]
        public IEnumerable<Art> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Art Get(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Art value)
        {
            _repository.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Art value)
        {
            value.Id = id;
            _repository.Update(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Remove(_repository.GetById(id));
        }
    }
}