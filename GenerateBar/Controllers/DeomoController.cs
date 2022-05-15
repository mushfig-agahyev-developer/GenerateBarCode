using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GenerateBar.Controllers
{
    [Route("Demo")]
    public class DeomoController : Controller
    {
        [Route("~/")]
        [Route("")]
        [Route("Index")]

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("generate")]
        public IActionResult Generate(string productId)
        {
            ViewBag.productId = productId;
            return View("Index");
        }

    }
}