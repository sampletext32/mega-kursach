using Entities;
using Infrastructure.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers
{
    [Route("api/[controller]")]
    public class HtmlDistributorDataController : Controller
    {
        private IDistributorDataRepository _repository;

        public HtmlDistributorDataController(IDistributorDataRepository distributorDataRepository)
        {
            _repository = distributorDataRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var distributors = _repository.GetAll();
            return View(distributors);
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
        public ActionResult Create([FromForm] DistributorData distributors)
        {
            try
            {
                _repository.Add(distributors);

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
        public ActionResult Edit(int id, [FromForm] DistributorData distributor)
        {
            try
            {
                _repository.Update(distributor);

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
            DistributorData distributor = _repository.GetById(id);
            if (distributor != null)
            {
                _repository.Remove(distributor);
            }

            return RedirectToAction("Index");
        }
    }
}