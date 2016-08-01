using CSRFInMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSRFInMVCApplication.Controllers
{
    public class CollageController : Controller
    {
        //
        // GET: /Collage/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult collageInfo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult collageInfo(CollageInfo _clgInfo)
        {
            return View(_clgInfo);
        }
    }
}
