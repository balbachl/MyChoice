using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyChoice.Controllers
{
    public class AnimalsController : Controller
    {
        // GET: Animals
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string selCategory)
        {
            var endangeredType = HttpUtility.HtmlEncode(selCategory);
            var viewName = "";
            switch (endangeredType)
            {
                case "Critical":
                    viewName= "Critical";
                    break;
                case "Endangered":
                    viewName = "Endangered";
                    break;
                case "Near Threatened":
                    viewName = "nearThreatened";
                    break;
                case "Vulnerable":
                    viewName = "Vulnerable";
                    break;
                default:
                    viewName = "LeastThreatened";
                    break;
            }
            return View(viewName);
        }
       
        [HttpPost]
        public ActionResult AnimalAdoptionForm(string name, string donation)
        {
            if (name == "")
                name = "animal";
            ViewBag.message = "Thank you for your wonderful donation of " + donation;
            ViewBag.message += ".  The " + name + " you adopted will greatly benefit from your generousity.";
            return View("ThankYou");
        }
        public ActionResult AnimalAdoptionForm()
        {
            return View();
        }
    }
}