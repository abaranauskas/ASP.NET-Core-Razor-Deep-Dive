using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderingApplication.Models;

namespace OrderingApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var orders = new List<OrderSummary>()
            {
                new OrderSummary() {Stage="Intake", Name = "Donec id elit non", LastUpdated = DateTime.Now.AddDays(-2), Description = "Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new OrderSummary() {Stage="Billing", Name = "Maecenas sed diam eget risus", LastUpdated = DateTime.Now.AddDays(-3), Description = "Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new OrderSummary() {Stage="Shipped", Name = "Maecenas sed diam eget risus", LastUpdated = DateTime.Now.AddDays(-8), Description = "Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new OrderSummary() { Name = "Donec id elit non", LastUpdated = DateTime.Now.AddDays(-2), Description = "Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new OrderSummary() { Name = "Maecenas sed diam eget risus", LastUpdated = DateTime.Now.AddDays(-5), Description = "Maecenas sed diam eget risus varius blandit. Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new OrderSummary() { Name = "Donec id elit non", LastUpdated = DateTime.Now.AddDays(-15), Description = "Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." }
            };

            ViewBag.Orders = orders;

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Vote(int id)
        {
            return ViewComponent("SurveyWidget", new { ProductId = id });
        }
    }
}
