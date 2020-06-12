using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers.HTML
{
    [Route("html/[controller]")]
    public class TrackController : Controller
    {
        private ITrackRepository _repository;

        public TrackController(ITrackRepository trackRepository)
        {
            _repository = trackRepository;
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

        [HttpGet("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Track track)
        {
            try
            {
                _repository.Add(track);

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
        public ActionResult Edit(int id, [FromForm] Track track)
        {
            try
            {
                _repository.Update(track);

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
            Track track = _repository.GetById(id);
            if (track != null)
            {
                _repository.Remove(track);
            }

            return RedirectToAction("Index");
        }
    }
}