using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers.HTML
{
    [Route("html/[controller]")]
    public class HtmlAlbumController : Controller
    {
        private IAlbumRepository _repository;

        public HtmlAlbumController(IAlbumRepository albumRepository)
        {
            _repository = albumRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var albums = _repository.GetAll();
            return View(albums);
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
        public ActionResult Create([FromForm] Album album)
        {
            try
            {
                _repository.Add(album);

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
        public ActionResult Edit(int id, [FromForm] Album album)
        {
            try
            {
                _repository.Update(album);

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
            Album album = _repository.GetById(id);
            if (album != null)
            {
                _repository.Remove(album);
            }

            return RedirectToAction("Index");
        }
    }
}