using AvaKids.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaKids.Controllers
{
    public class DoChoiController : Controller
    {
        public IActionResult DoChoiLego()
        {
            var product = new Product();
            return View(product);
        }
    }

    

}
