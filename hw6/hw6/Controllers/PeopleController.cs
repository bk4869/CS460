using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hw6.Models;
using hw6.Models.FrontViewModel;
using System.Data;




namespace hw6.Controllers
{
    public class PeopleController : Controller
    {
        WideWorldImportersContext db = new WideWorldImportersContext();

        // GET: People
        public ActionResult Index(String searchData)
        {
            FEViewModel vm = new FEViewModel();

            searchData = Request.QueryString["searchBar"];

            //searchData = "Cristina Longo";
            Console.WriteLine("Reach GOT Data");

            if (String.IsNullOrEmpty(searchData))
            {
                Console.WriteLine("Null OR EMPTY");
                ViewBag.display = false;
                return View();
            }
            else
            {
                ViewBag.display = true;
                ViewBag.isValid = db.People.Count(p => p.FullName.Contains(searchData));
                return View(db.People.Where(p => p.FullName.Contains(searchData)).ToList());
            }
        }

        public ActionResult Info(int? id)
        {
            return View();
        }
    }
}