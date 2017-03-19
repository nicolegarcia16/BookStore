using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        List<BookModel> b;
        public IActionResult Index()
        {
            b = createAndAddBooks();
            return View(b);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult SignIn()
        {
            //ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Order()
        {
            return View("Order");
            //List<BookModel> books = createAndAddBooks();
            //BookModel thisBook = books.First(book => book.ID == id);

            //return View(thisBook);
        }

        public List<BookModel> createAndAddBooks()
        {
            List<BookModel> b = new List<BookModel>
            {
                new BookModel
                {
                    ID = 1,
                    name = "Sense and Sensibility",
                    author = "Jane Austen",
                    price = 9.00,
                    isbnNumber = 12345
                },
                new BookModel
                {
                    ID = 2,
                    name = "Pride and Prejudice",
                    author = "Jane Austen",
                    price = 10.00,
                    isbnNumber = 67891
                },
                new BookModel
                {
                    ID = 3,
                    name = "Jane Eyre",
                    author = "Charlotte Bronte",
                    price = 12.00,
                    isbnNumber = 23456
                },
                new BookModel
                {
                    ID = 4,
                    name = "1984",
                    author = "George Orwell",
                    price = 8.50,
                    isbnNumber = 78912
                },
                new BookModel
                {
                    ID = 5,
                    name = "The Great Gatsby",
                    author = "F. Scott Fitzgerald",
                    price = 10.00,
                    isbnNumber = 34567
                },
                new BookModel
                {
                    ID = 6,
                    name = "Dracula",
                    author = "Brahm Stoker",
                    price = 10.00,
                    isbnNumber = 89123
                }
            };

            return b;
        }
    }
}
