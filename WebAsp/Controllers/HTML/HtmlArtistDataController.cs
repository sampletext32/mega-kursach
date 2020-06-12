using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers.HTML
{
    [Route("html/[controller")]
    public class HtmlArtistDataController : Controller
    {
        private IArtistDataRepository _repository;

        public HtmlArtistDataController(IArtistDataRepository artistDataRepository)
        {
            _repository = artistDataRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var artists = _repository.GetAll();
            return View(artists);
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
        public ActionResult Create([FromForm] ArtistData artist)
        {
            try
            {
                _repository.Add(artist);

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
        public ActionResult Edit(int id, [FromForm] ArtistData artist)
        {
            try
            {
                _repository.Update(artist);

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
            ArtistData artist = _repository.GetById(id);
            if (artist != null)
            {
                _repository.Remove(artist);
            }

            return RedirectToAction("Index");
        }
    }
}