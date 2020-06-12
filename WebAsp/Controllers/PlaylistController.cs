using System.Collections.Generic;
using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        private IPlaylistRepository _repository;

        public PlaylistController(IPlaylistRepository playlistRepository)
        {
            _repository = playlistRepository;
        }

        [HttpGet]
        public IEnumerable<Playlist> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Playlist Get(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Playlist value)
        {
            _repository.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Playlist value)
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