using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleServer.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }

        public string Echo(string data)
        {
            return data;
        }
    }
}
