using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers
{
    [Route("html/[controller")]
    public class HtmlArtController : Controller
    {
        private IArtRepository _repository;

        public HtmlArtController(IArtRepository artRepository)
        {
            _repository = artRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var arts = _repository.GetAll();
            return View(arts);
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Art art)
        {
            try
            {
                _repository.Add(art);

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
        public ActionResult Edit(int id, [FromForm] Art art)
        {
            try
            {
                _repository.Update(art);

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
            Art art = _repository.GetById(id);
            if (art != null)
            {
                _repository.Remove(art);
            }

            return RedirectToAction("Index");
        }
    }
}