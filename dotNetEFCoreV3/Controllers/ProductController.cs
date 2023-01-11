using dotNetEFCoreV3.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace dotNetEFCoreV3.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<ProductEntity> entities = _context.productEntities.ToList();
            return View(entities);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            ProductEntity product = _context.productEntities.Find(id);
            return View(product);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("ProductName, Category, Price")] ProductEntity request)
        {
            _context.productEntities.Add(request);
            _context.SaveChanges();

            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.productEntities.Find(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Update([Bind("Id, ProductName, Category, Price")] ProductEntity request)
        {
            //update entity
            _context.productEntities.Update(request);

            //commit to database
            _context.SaveChanges();
            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entity = _context.productEntities.Find(id);
            if (entity == null)
            {
                return Redirect("GetAll");
            }

            //hapus dari entity
            _context.productEntities.Remove(entity);

            //commit to database
            _context.SaveChanges();
            return Redirect("GetAll");

        }
    }
}
