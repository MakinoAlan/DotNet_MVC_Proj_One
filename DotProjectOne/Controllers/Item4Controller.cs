using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotProjectOne.Controllers
{
    public class Item4Controller : Controller
    {
        public ActionResult Index()
        {
            return View ("~/Views/Item/item4.cshtml");
        }
    }
}
