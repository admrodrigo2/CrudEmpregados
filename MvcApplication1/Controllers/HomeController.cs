using Ext.Net;
using Ext.Net.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}