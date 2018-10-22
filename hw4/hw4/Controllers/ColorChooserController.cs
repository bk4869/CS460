using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;

namespace hw4.Controllers
{
    public class ColorChooserController : Controller
    {
        // GET: ColorChooser
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ColorChooser()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hexColor1">Color 1 in Hex input by user</param>
        /// <param name="hexColor2">Color 2 in Hex input by user</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ColorChooser(string hexColor1, string hexColor2)
        {
            //Hex color input from user.
            hexColor1 = Request.Form["inputColor1"];
            hexColor2 = Request.Form["inputColor2"];

            //Create Color instance from HTML Hex
            Color color1 = ColorTranslator.FromHtml(hexColor1);
            Color color2 = ColorTranslator.FromHtml(hexColor2);

            //Initial the four properties of result Color. 
            int newColorA = 0;
            int newColorR = 0;
            int newColorG = 0;
            int newColorB = 0;


            if(color1.A + color2.A >= 255)
            {
                newColorA = 255;
            }else
            {
                newColorA = color1.A + color2.A;
            }

            if(color1.R + color2.R >= 255)
            {
                newColorR = 255;
            }
            else
            {
                newColorR = color1.R + color2.R;
            }

            if (color1.G + color2.G >= 255)
            {
                newColorG = 255;
            }
            else
            {
                newColorG = color1.G + color2.G;
            }

            if (color1.B + color2.B >= 255)
            {
                newColorB = 255;
            }
            else
            {
                newColorB = color1.B + color2.B;
            }



            return View();
        }
    }
}