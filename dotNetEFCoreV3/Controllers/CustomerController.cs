using dotNetEFCoreV3.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace dotNetEFCoreV3.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<CustomerEntity> entities = _context.customerEntities.ToList();
            return View(entities);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            CustomerEntity customer = _context.customerEntities.Find(id);
            return View(customer);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("CustomerName, Email, Password")] CustomerEntity request)
        {
            _context.customerEntities.Add(request);
            _context.SaveChanges();

            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.customerEntities.Find(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Update([Bind("Id, CustomerName, Email, Password")] CustomerEntity request)
        {
            //update entity
            _context.customerEntities.Update(request);

            //commit to database
            _context.SaveChanges();
            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entity = _context.customerEntities.Find(id);
            if (entity == null)
            {
                return Redirect("GetAll");
            }

            //hapus dari entity
            _context.customerEntities.Remove(entity);

            //commit to database
            _context.SaveChanges();
            return Redirect("GetAll");

        }
    }
}
