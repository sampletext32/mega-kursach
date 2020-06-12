using System.Collections.Generic;
using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers.API
{
    [Route("api/[controller")]
    [ApiController]
    public class ArtistDataController : ControllerBase
    {
        private IArtistDataRepository _repository;

        public ArtistDataController(IArtistDataRepository artistDataRepository)
        {
            _repository = artistDataRepository;
        }

        [HttpGet]
        public IEnumerable<ArtistData> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public ArtistData Get(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] ArtistData value)
        {
            _repository.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ArtistData value)
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