﻿using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _411018523李永傑.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Music()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Music(string name, int? number)
        {
            var result = "";
            if (number.HasValue)
            {
                if (number == 1)
                {
                    result = "do";
                }
                if (number == 2)
                {
                    result = "re";
                }
                if (number == 3)
                {
                    result = "mi";
                }
                if (number == 4)
                {
                    result = "fa";
                }
                if (number == 5)
                {
                    result = "so";
                }
                if (number == 6)
                {
                    result = "la";
                }
                if (number == 7)
                {
                    result = "xi";
                }
                if (number == 8)
                {
                    result = "錯誤";
                }
            }
            ViewBag.Name = name;
            ViewBag.Result = result;
            return View();
        }
    }
}