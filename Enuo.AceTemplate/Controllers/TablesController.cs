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
    public class TablesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult jqGrid()
        {
            return View();
        }
    }
}