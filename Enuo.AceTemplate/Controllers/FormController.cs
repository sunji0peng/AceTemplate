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
    public class FormController : Controller
    {
        public IActionResult FormElement1()
        {
            return View();
        }
        public IActionResult FormElement2()
        {
            return View();
        }
        public IActionResult FormWizard()
        {
            return View();
        }
        public IActionResult Wysiwyg()
        {
            return View();
        }
        public IActionResult Dropzone()
        {
            return View();
        }
    }
}