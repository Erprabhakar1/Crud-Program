
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.MyDatabase;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            db214Entities obj = new db214Entities();
            List<EmpModel> empobj = new List<EmpModel>();
            var res = obj.tbl__employee.ToList();
            foreach (var item in res)
            {
                empobj.Add(new EmpModel
                {
                    id=item.id,
                    name=item.name,
                    email=item.email
                });
            }
            return View(empobj);
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
    }
}