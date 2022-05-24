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
            var legocity = new LegoCity();
            return View(legocity);
        }
    }
}
