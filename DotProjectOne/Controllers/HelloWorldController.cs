using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotProjectOne.Controllers
{
    public class HelloWorldController : Controller
    {

        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}
