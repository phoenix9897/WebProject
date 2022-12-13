using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Controllers
{
    public class Controller1 : Controller
    {
        public IActionResult Giris()
        {
            return View();
        }

        public IActionResult Anasayfa()
        {
            return View(); 
        }

        public IActionResult Urunler()
        {
            return View(); 
        }
       
    }

    
}
