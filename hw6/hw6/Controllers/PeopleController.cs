using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hw6.Models;
using hw6.Models.FrontViewModel;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Diagnostics;


namespace hw6.Controllers
{
    public class PeopleController : Controller
    {

        //Where to access DB
        WideWorldImportersContext db = new WideWorldImportersContext();

        /// <summary>
        /// Index Controller Method
        /// </summary>
        /// <param name="searchData"></param>
        /// <returns></returns>
        // GET: People
        public ActionResult Index(String searchData)
        {
            searchData = Request.QueryString["searchBar"];

            if (String.IsNullOrEmpty(searchData))
            {
                ViewBag.display = false;
                return View();
            }
            else
            {
                ViewBag.display = true;
                ViewBag.isValid = db.People.Count(p => p.FullName.Contains(searchData));
                //Return related query
                return View(db.People.Where(p => p.FullName.Contains(searchData)).ToList());
            }
        }

        /// <summary>
        /// Show customer detail
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(int? id)
        {
            FEViewModel myVM = new FEViewModel();

            myVM.People = db.People.Find(id);

            ViewBag.display = false;

            //If bad input
            if (id == null || myVM.People == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            else if(myVM.People.Customers2.Count() > 0)   //If Primary Contact People
            {
                //Ok to show
                ViewBag.display = true;

                //Find Customer
                var customerID = myVM.People.Customers2.First().CustomerID;            
                myVM.Customers = db.Customers.Find(customerID);

                //LINQ Find Data
                int orderCount = myVM.Customers
                                     .Orders.SelectMany(i => i.Invoices)
                                     .SelectMany(il => il.InvoiceLines)
                                     .Count();
                var grossSales = myVM.Customers
                                     .Orders.SelectMany(i => i.Invoices)
                                     .SelectMany(il => il.InvoiceLines)
                                     .Sum(s => s.ExtendedPrice);
                var grossProfit = myVM.Customers
                                      .Orders.SelectMany(i => i.Invoices)
                                      .SelectMany(il => il.InvoiceLines)
                                      .Sum(s => s.LineProfit);
                myVM.InvoiceLines = myVM.Customers
                                        .Orders.SelectMany(i => i.Invoices)
                                        .SelectMany(il => il.InvoiceLines)
                                        .OrderByDescending(p => p.LineProfit)
                                        .Take(10).ToList();

                //Sign to ViewBag, ready return to UI
                ViewBag.OrderCount = orderCount;
                ViewBag.GrossSales = grossSales;
                ViewBag.GrossProfit = grossProfit;

            }

            return View(myVM);
        }
    }
}