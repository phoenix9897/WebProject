using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class Controller2 : Controller
    {
        public IActionResult Hakkinda()
        {
            return View();
        }

        public IActionResult Iletisim()
        {
            return View();
        }
    }
}
