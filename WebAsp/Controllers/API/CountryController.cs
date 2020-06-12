using System.Collections.Generic;
using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAsp.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private ICountryRepository _repository;

        public CountryController(ICountryRepository countryRepository)
        {
            _repository = countryRepository;
        }

        // GET: api/<CountryController>
        [HttpGet]
        public IEnumerable<Country> Get()
        {
            return _repository.GetAll();
        }

        // GET api/<CountryController>/5
        [HttpGet("{id}")]
        public Country Get(int id)
        {
            return _repository.GetById(id);
        }

        // POST api/<CountryController>
        [HttpPost]
        public void Post([FromBody] Country value)
        {
            _repository.Add(value);
        }

        // PUT api/<CountryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Country value)
        {
            value.Id = id;
            _repository.Update(value);
        }

        // DELETE api/<CountryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Remove(_repository.GetById(id));
        }
    }
}
