using System.Collections.Generic;
using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers
{
    [Route("apt/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepository _repository;

        public UserController(IUserRepository userRepository)
        {
            _repository = userRepository;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] User value)
        {
            _repository.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User value)
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