using dotNetEFCoreV3.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace dotNetEFCoreV3.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CompanyController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<CompanyEntity> entities = _context.CompanyEntities.ToList();
            return View(entities);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            CompanyEntity company = _context.CompanyEntities.Find(id);
            return View(company);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("CompanyName, Segmentasi, Address, Logo")]CompanyEntity request)
        {
            _context.CompanyEntities.Add(request);
            _context.SaveChanges();

            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.CompanyEntities.Find(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Update([Bind("Id, CompanyName, Segmentasi, Address, Logo")] CompanyEntity request)
        {
            //update entity
            _context.CompanyEntities.Update(request);

            //commit to database
            _context.SaveChanges();
            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entity = _context.CompanyEntities.Find(id);
            if (entity == null)
            {
                return Redirect("GetAll");
            }

            //hapus dari entity
            _context.CompanyEntities.Remove(entity);

            //commit to database
            _context.SaveChanges();
            return Redirect("GetAll");

        }

    }
}
