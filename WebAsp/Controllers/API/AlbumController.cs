using System.Collections.Generic;
using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private IAlbumRepository _repository;

        public AlbumController(IAlbumRepository albumRepository)
        {
            _repository = albumRepository;
        }

        [HttpGet]
        public IEnumerable<Album> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Album Get(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Album value)
        {
            _repository.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Album value)
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