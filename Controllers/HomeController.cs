using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TemplateAngularNetcore.Models;

namespace TemplateAngularNetcore.Controllers
{
    public class HomeController : Controller
    {
        private DataContext context;
        
        public HomeController(DataContext ctx) {
            context = ctx;
        }


        public IActionResult Index()
        {
            ViewData["Message"] = "Your application description page.";
            return View(context.Products.First());
        }

  
    }
}
