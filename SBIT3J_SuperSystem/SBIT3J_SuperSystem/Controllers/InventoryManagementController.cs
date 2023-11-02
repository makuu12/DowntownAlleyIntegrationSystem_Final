using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBIT3J_SuperSystem.Controllers
{
    public class InventoryManagementController : Controller
    {
        // GET: InventoryManagement
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Inventory()
        {
            return View();
        }
        public ActionResult InventoryArchives()
        {
            return View();
        }
        public ActionResult Restock()
        {
            return View();
        }
        public ActionResult Returns()
        {
            return View();
        }
    }
}