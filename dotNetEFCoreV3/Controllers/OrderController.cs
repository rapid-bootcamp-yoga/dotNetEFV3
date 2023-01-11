using dotNetEFCoreV3.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotNetEFCoreV3.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<OrderEntity> entities = _context.OrderEntities.ToList();
            return View(entities);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            OrderEntity order = _context.OrderEntities.Find(id);
            return View(order);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("Count, Description, ProductId")] OrderEntity request)
        {
            _context.OrderEntities.Add(request);
            _context.SaveChanges();

            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.OrderEntities.Find(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Update([Bind("Id, Count, Description, ProductId")] OrderEntity request)
        {
            //update entity
            _context.OrderEntities.Update(request);

            //commit to database
            _context.SaveChanges();
            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entity = _context.OrderEntities.Find(id);
            if (entity == null)
            {
                return Redirect("GetAll");
            }
            //hapus dari entity
            _context.OrderEntities.Remove(entity);

            //commit to database
            _context.SaveChanges();
            return Redirect("GetAll");

        }
    }

   
}
