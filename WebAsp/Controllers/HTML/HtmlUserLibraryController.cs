using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers.HTML
{
    [Route("html/[controller]")]
    public class HtmlUserLibraryController : Controller
    {
        private IUserLibraryRepository _repository;

        public HtmlUserLibraryController(IUserLibraryRepository userLibraryRepository)
        {
            _repository = userLibraryRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var libraries = _repository.GetAll();
            return View(libraries);
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
        public ActionResult Create([FromForm] UserLibrary library)
        {
            try
            {
                _repository.Add(library);

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
        public ActionResult Edit(int id, [FromForm] UserLibrary library)
        {
            try
            {
                _repository.Update(library);

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
            UserLibrary library = _repository.GetById(id);
            if (library != null)
            {
                _repository.Remove(library);
            }

            return RedirectToAction("Index");
        }
    }
}