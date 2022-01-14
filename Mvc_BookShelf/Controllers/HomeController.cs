using Microsoft.AspNetCore.Mvc;
using Mvc_BookShelf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_BookShelf.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var books = new List<Books>
            {
                new Books(){Id=1,BookName="Chess",Writer="Zweig"},
                new Books(){Id=2,BookName="The Stand",Writer="Stephen King"},
                new Books(){Id=3,BookName="The Death of Ivan Ilyich",Writer="Leo Tolstoy"},
                new Books(){Id=4,BookName="The Brothers Karamazov",Writer="Fyodor Dostoevsky"},
                new Books(){Id=5,BookName="The Gambler",Writer="Fyodor Dostoevsky"}
            };
            return View(books);
        }
    }
}
