﻿using Microsoft.AspNetCore.Mvc;

namespace RapidApiProject.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
