using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaKids.Controllers
{
    public class BimTaController : Controller
    {
        public IActionResult DanhSachBimTa()
        {
            return View();
        }
    }
}
