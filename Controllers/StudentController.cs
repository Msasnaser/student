﻿using Microsoft.AspNetCore.Mvc;

namespace studentExample.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
