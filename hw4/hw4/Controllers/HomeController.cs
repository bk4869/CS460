using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hw4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /// <summary>
        /// Convert Miles to Metric
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Converter()
        {
            //Get user input
            double inputMiles = Convert.ToDouble(Request.QueryString["miles"]);
            string inputUnit = Request.QueryString["metricUnit"];

            //Init result variables 
            double resultNum = 0;
            string resultUnit = null;
            string resultDisplay = null;

            //Finding the right Metric and count the result
            if (inputMiles != 0)
            {
                if (inputUnit == "millimeters")
                {
                    resultNum = inputMiles * 1609344;
                }
                else if (inputUnit == "centimeters")
                {
                    resultNum = inputMiles * 160934.4;
                }
                else if (inputUnit == "meters")
                {
                    resultNum = inputMiles * 1609.344;
                }
                else if (inputUnit == "kilometers")
                {
                    resultNum = inputMiles * 1.609344;
                }

                resultUnit = inputUnit;
                resultDisplay = inputMiles + " miles is equal to " + resultNum + " " + resultUnit; 
            }

            //Return front end
            ViewData["result"] = resultDisplay;

            return View();
        }

    }
}