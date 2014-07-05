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

        public string EchoThreeParam(string data1, int data2, float data3)
        {
            return string.Format("data1={0}&data2={1}&data3={2}", data1, data2, data3);
        }
    }
}
