using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hw4.Controllers
{
    public class ColorChooserController : Controller
    {
        // GET: ColorChooser
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult ColorChooser(string c1, string c2)
        {
            return View();
        }
    }
}