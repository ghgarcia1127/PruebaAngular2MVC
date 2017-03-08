using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gallery.Controllers
{
    [RoutePrefix("collections")]
    public class CollectionsController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
    }
}