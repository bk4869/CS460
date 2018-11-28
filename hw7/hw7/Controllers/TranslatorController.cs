using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace hw7.Controllers
{
    public class TranslatorController : Controller
    {
        // GET: Translator
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult Sticker(string userInput)
        {

            string apiKey = System.Web.Configuration.WebConfigurationManager.AppSettings["ApiKey"];
            string apiURL = "https://api.giphy.com/v1/stickers/translate?api_key=" + apiKey + "&s=" + userInput;
            Debug.WriteLine(apiURL);
            Console.WriteLine(apiURL);
            
            WebRequest apiRequest = WebRequest.Create(apiURL);
            WebResponse getResponse = apiRequest.GetResponse();

            Stream data = apiRequest.GetResponse().GetResponseStream();

            string convString = new StreamReader(data).ReadToEnd();

            //string convString = apiURL;

            var jsonSerialize = new System.Web.Script.Serialization.JavaScriptSerializer();
            var jsonObj = jsonSerialize.DeserializeObject(convString);

            data.Close();
            getResponse.Close();

            return Json(jsonObj, JsonRequestBehavior.AllowGet);
        }
    }
}