using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers.HTML
{
    [Route("html/[controller]")]
    public class CountryController : Controller
    {
        private ICountryRepository _repository;

        public CountryController(ICountryRepository countryRepository)
        {
            _repository = countryRepository;
        }

        // GET: CountryController
        [HttpGet]
        public ActionResult Index()
        {
            var countries = _repository.GetAll();
            return View(countries);
        }

        // GET: CountryController/Details/5
        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            return View(_repository.GetById(id));
        }

        // GET: CountryController/Create
        [HttpGet("create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: CountryController/Create
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

        // GET: CountryController/Edit/5
        [HttpGet("edit/{id}")]
        public ActionResult Edit(int id)
        {
            return View(_repository.GetById(id));
        }

        // POST: CountryController/Edit/5
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

        // GET: CountryController/Delete/5
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