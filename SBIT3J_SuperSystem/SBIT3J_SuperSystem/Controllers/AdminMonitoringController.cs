using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBIT3J_SuperSystem.Controllers
{
    public class AdminMonitoringController : Controller
    {
        // GET: AdminMonitoring
        public ActionResult Index() // Revenue Dashboard
        {
            return View(); // View the overall Summary Income of the company
            //ISSUE: finished interface but need a dynamic data
        }
        public ActionResult SalesRevenue()
        {
            return View(); // The sale performance of the specified date
            //ISSUE: have an API chart (line 113)
        }
        public ActionResult ProductRevenue()
        {
            return View(); // The product performance of the specified date
            //ISSUE:
        }
        public ActionResult CompanyProfit()
        {
            return View();
            //ISSUE: finished interface but need a dynamic data
        }
        public ActionResult LossesDashboard()
        {
            return View();
            //ISSUE: The th side cannot center the text
        }

        public ActionResult CashierActivities()
        {
            return View();
        }

        public ActionResult OverallActivities()
        {
            return View();
        }

        public ActionResult Inventory()
        {
            return View();
        }
    }
}