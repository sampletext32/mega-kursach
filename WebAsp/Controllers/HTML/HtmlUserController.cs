using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers.HTML
{
    [Route("html/[controller")]
    public class HtmlUserController : Controller
    {
        private IUserRepository _repository;

        public HtmlUserController(IUserRepository userRepository)
        {
            _repository = userRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var users = _repository.GetAll();
            return View(users);
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
        public ActionResult Create([FromForm] User user)
        {
            try
            {
                _repository.Add(user);

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
        public ActionResult Edit(int id, [FromForm] User user)
        {
            try
            {
                _repository.Update(user);

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
            User user = _repository.GetById(id);
            if (user != null)
            {
                _repository.Remove(user);
            }

            return RedirectToAction("Index");
        }
    }
}