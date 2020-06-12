using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers
{
    [Route("html/[controller]")]
    public class HtmlCountryController : Controller
    {
        private ICountryRepository _repository;

        public HtmlCountryController(ICountryRepository countryRepository)
        {
            _repository = countryRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var countries = _repository.GetAll();
            return View(countries);
        }


        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            return View(_repository.GetById(id));
        }

        [HttpGet("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Country country)
        {
            try
            {
                _repository.Add(country);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet("edit/{id}")]
        public ActionResult Edit(int id)
        {
            return View(_repository.GetById(id));
        }

        [HttpPost("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm] Country country)
        {
            try
            {
                _repository.Update(country);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpDelete("delete/{id}")]
        public ActionResult Delete(int id)
        {
            Country country = _repository.GetById(id);
            if (country != null)
            {
                _repository.Remove(country);
            }

            return RedirectToAction("Index");
        }
    }
}