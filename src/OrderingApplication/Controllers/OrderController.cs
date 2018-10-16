using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderingApplication.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderingApplication.Controllers
{
    public class OrderController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult NewOrder()
        {
            var newOrder = new Order();
            newOrder.Products = new List<OrderProductVM>()
            {
                new OrderProductVM() { Id = 1, Name = "Hoodie" },
                new OrderProductVM() { Id = 2, Name = "T-Shirt" },
                new OrderProductVM() { Id = 3, Name = "Banner" },
                new OrderProductVM() { Id = 4, Name = "Table Cloth" },
                new OrderProductVM() { Id = 5, Name = "Streamers" }
            };
            return View(newOrder);
        }

        [HttpPost]
        public IActionResult NewOrder(Order newOrder)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
