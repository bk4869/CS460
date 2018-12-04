using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hw8.Models;

namespace hw8.Controllers
{
    public class AuctionHouseController : Controller
    {
        private AuctionHouseContext db = new AuctionHouseContext();

        // GET: AuctionHouse
        public ActionResult Index()
        {
            return View();
        }
    }
}