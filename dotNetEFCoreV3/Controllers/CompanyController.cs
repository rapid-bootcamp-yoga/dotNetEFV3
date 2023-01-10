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

    }
}
