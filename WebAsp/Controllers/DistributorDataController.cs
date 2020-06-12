using System.Collections.Generic;
using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributorDataController : ControllerBase
    {
        private IDistributorDataRepository _repository;

        public DistributorDataController(IDistributorDataRepository distributorDataRepository)
        {
            _repository = distributorDataRepository;
        }

        [HttpGet]
        public IEnumerable<DistributorData> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public DistributorData Get(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] DistributorData value)
        {
            _repository.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DistributorData value)
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