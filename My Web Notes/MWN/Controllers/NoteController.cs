using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MWN.Controllers
{
    public class NoteController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Woohoo(int i)
        {
            ViewData["i"] = i;
            return View();
        }


    }
}