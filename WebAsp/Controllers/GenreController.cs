using System.Collections;
using System.Collections.Generic;
using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private IGenreRepository _repository;

        public GenreController(IGenreRepository genreRepository)
        {
            _repository = genreRepository;
        }

        [HttpGet]
        public IEnumerable<Genre> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Genre Get(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Genre value)
        {
            _repository.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Genre value)
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