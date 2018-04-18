using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Enuo.AceTemplate.Controllers
{

    /// <summary>
    /// Author: Terrence Sun
    /// Date：2018-4-18
    /// </summary>
    public class DefaultController : Controller
    {
        public IActionResult Blank()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View();
        }
        public IActionResult Error404()
        {
            return View();
        }
        public IActionResult Error500()
        {
            return View();
        }
        public IActionResult GridLayout()
        {
            return View();
        } 
    }
}