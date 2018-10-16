using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderingApplication.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderingApplication.Controllers
{
    public class ClientController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult NewClient()
        {
            var newClient = new Client();
            newClient.EmailPromos = new List<EmailPromo>()
            {
                new EmailPromo() { Id = 1, Title = "Weekly Deal", IsSubscribed = false },
                new EmailPromo() { Id = 2, Title = "Holiday Promos", IsSubscribed = false },
                new EmailPromo() { Id = 3, Title = "Company Newsletter", IsSubscribed = false },
                new EmailPromo() { Id = 4, Title = "New Products", IsSubscribed = false }
            };
            return View(newClient);
        }

        [HttpPost]
        public IActionResult NewClient(Client newClient)
        {  

            if (ModelState.IsValid)
            {
                //save update data to database
                return RedirectToAction("Index", "Home");
            }
            return View(newClient);
        }

        public IActionResult VerifyEmail(string email)
        {
            var emailList = new List<string>
            {
                "test@example.com",
                "hello@example.com",
                "world@example.com"
            };

            if (emailList.Contains(email))
            {
                return Json("Email is already taken");
            }

            return Json(true);
        }
    }


}
