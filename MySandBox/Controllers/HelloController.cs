﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace MySandBox.Controllers
{
    public class HelloController : Controller
    {
        public class Person
        {
            public string Name { get; set; }
            public DateTime Birthdate { get; set; }
            public bool Married { get; set; }
        }

        private string GetJSonData()
        {
            var output =
            new List<Person>()
            {
                            new Person(){
                                Name = "Hello World",
                                Birthdate = DateTime.Now,
                                Married = false
                            },
                            new Person(){
                                Name = "Arie Ribbens",
                                Birthdate = DateTime.Now,
                                Married = true
                            },
                            new Person(){
                                Name = "Rob Williams",
                                Birthdate = DateTime.Now,
                                Married = true
                            }

            }.ToList();

            return JsonConvert.SerializeObject(output);
        }

        // GET: JustTheData
        public ActionResult JustTheData()
        {
            return Json(GetJSonData(), JsonRequestBehavior.AllowGet);
        }
        // GET: Hello
        public ActionResult Index()
        {
            return View("Index","", GetJSonData());
        }
    }
}