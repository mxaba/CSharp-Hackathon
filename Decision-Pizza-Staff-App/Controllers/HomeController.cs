﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Decision_Pizza_Staff_App.Models;

namespace Decision_Pizza_Staff_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWaiterLogic login;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IWaiterLogic login)
        {
            _logger = logger;
            this.login = login;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Manager()
        {
            return View();
        }

        public IActionResult WaitersPage(WaiterManager waiterManager)
        {
            // var modelToBePassed = 
            return View(waiterManager);
        }

        public IActionResult TimeSlots(WaiterManager waiterManager)
        {
            return View(waiterManager);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
