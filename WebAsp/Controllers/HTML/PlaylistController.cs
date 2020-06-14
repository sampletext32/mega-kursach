using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers.HTML
{
    [Route("html/[controller]")]
    public class PlaylistController : Controller
    {
        private IPlaylistRepository _repository;

        public PlaylistController(IPlaylistRepository playlistRepository)
        {
            _repository = playlistRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var playlists = _repository.GetAll();
            return View(playlists);
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
        public ActionResult Create([FromForm] Playlist playlist)
        {
            try
            {
                _repository.Add(playlist);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return new BadRequestResult();
            }
        }

        [HttpGet("edit/{id}")]
        public ActionResult Edit(int id)
        {
            return View(_repository.GetById(id));
        }

        [HttpPost("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm] Playlist playlist)
        {
            try
            {
                _repository.Update(playlist);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return new BadRequestResult();
            }
        }

        [HttpDelete("delete/{id}")]
        public ActionResult Delete(int id)
        {
            Playlist playlist = _repository.GetById(id);
            if (playlist != null)
            {
                _repository.Remove(playlist);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return new BadRequestResult();
            }
        }
    }
}