using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class PetGuideController : Controller
    {
        // GET: PetGuide
        public ActionResult Index()
        {
            return View();
        }
    }
}