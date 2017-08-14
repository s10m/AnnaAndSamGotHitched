using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnnaAndSamGotHitched.ViewModels;

namespace AnnaAndSamGotHitched.Controllers
{
    public class MemoriesController : Controller
    {
        public IActionResult Index()
        {
            return View(new MemoryListingViewModel());
        }
    }
}