using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers
{
    [Route("html/[controller]")]
    public class HtmlGenreController : Controller
    {
        private IGenreRepository _repository;

        public HtmlGenreController(IGenreRepository genreRepository)
        {
            _repository = genreRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var tracks = _repository.GetAll();
            return View(tracks);
        }

        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            return View(_repository.GetById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Genre genre)
        {
            try
            {
                _repository.Add(genre);
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

        // POST: HtmlCountryController/Edit/5
        [HttpPost("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm] Genre genre)
        {
            try
            {
                _repository.Update(genre);

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
            Genre genre = _repository.GetById(id);
            if (genre != null)
            {
                _repository.Remove(genre);
            }

            return RedirectToAction("Index");
        }
    }
}