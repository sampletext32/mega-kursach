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

        // GET: HtmlCountryController
        [HttpGet]
        public ActionResult Index()
        {
            var countries = _repository.GetAll();
            return View(countries);
        }

        // GET: HtmlCountryController/Details/5
        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            return View(_repository.GetById(id));
        }

        // GET: HtmlCountryController/Create
        [HttpGet("create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: HtmlCountryController/Create
        [HttpPost]
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

        // GET: HtmlCountryController/Edit/5
        [HttpGet("edit/{id}")]
        public ActionResult Edit(int id)
        {
            return View(_repository.GetById(id));
        }

        // POST: HtmlCountryController/Edit/5
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

        // GET: HtmlCountryController/Delete/5
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