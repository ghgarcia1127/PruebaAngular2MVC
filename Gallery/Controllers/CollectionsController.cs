using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Gallery.Dtos;
using Gallery.Models;
using Gallery.ApiControllers;

namespace Gallery.Controllers
{
    public class CollectionsController : Controller
    {
        CollectionController api = new CollectionController();
        // GET: Collections
        public ActionResult Index()
        {
            return View();
        }

        // GET: Collections/Details/5
        public ActionResult Details(Guid? id)
        {
            return View();
        }

        // GET: Collections/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Collection collection)
        {
            try
            {
                api.Add(collection);
                return RedirectToAction("Index", "Collections");
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}
