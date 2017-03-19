using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore.Controllers
{
    public class SignInController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignIn(UserModel u)
        {
            if (!ModelState.IsValid)
            {
                ViewData["results"] = "Invalid Login";
                return View(u);
            }
            //return View("Index");
            return View();
        }
    }
}
