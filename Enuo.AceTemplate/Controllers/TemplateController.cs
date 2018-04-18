using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Enuo.AceTemplate.Controllers
{
    /// <summary>
    /// Author: Terrence Sun
    /// Date：2018-4-18
    /// </summary>
    public class TemplateController : Controller
    {
        public IActionResult UserProfile()
        {
            return View();
        }
        public IActionResult Inbox()
        {
            return View();
        }
        public IActionResult PricingTables()
        {
            return View();
        }
        public IActionResult Invoice()
        {
            return View();
        }
        public IActionResult Timeline()
        {
            return View();
        }
        public IActionResult SearchResults()
        {
            return View();
        }
        public IActionResult EmailTemplates()
        {
            return View();
        }

        public IActionResult SimpleTable()
        {
            return View();
        }
    }
}