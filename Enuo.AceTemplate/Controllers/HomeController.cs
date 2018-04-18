using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Enuo.AceTemplate.Models;

namespace Enuo.AceTemplate.Controllers
{
    /// <summary>
    /// Author: Terrence Sun
    /// Date：2018-4-18
    /// </summary>
    public class HomeController : Controller
    {
        public IActionResult Calendar()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult Widgets()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
