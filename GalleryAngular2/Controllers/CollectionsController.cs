using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GalleryAngular2.Controllers
{
    public class CollectionsController : Controller
    {
        // GET: Collections
        public ActionResult Index()
        {
            return View();
        }

        // GET: Collections/:id
        public ActionResult Detail(Guid id)
        {
            return View();
        }
    }
}