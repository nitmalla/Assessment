using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assessment.UI.Models;

namespace Assessment.UI.Controllers
{
    public class QuestionController : Controller
    {

        public IActionResult AddQuestion()
        {
            return View();
        }

    }
}
