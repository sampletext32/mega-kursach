using System.Collections.Generic;
using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers.API
{
    [Route("api/[controller")]
    [ApiController]
    public class UserLibraryController : ControllerBase
    {
        private IUserLibraryRepository _repository;

        public UserLibraryController(IUserLibraryRepository userLibraryRepository)
        {
            _repository = userLibraryRepository;
        }

        [HttpGet]
        public IEnumerable<UserLibrary> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public UserLibrary Get(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] UserLibrary value)
        {
            _repository.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UserLibrary value)
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