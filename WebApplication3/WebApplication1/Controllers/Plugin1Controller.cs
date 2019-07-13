using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Plugin1.Controllers
{
    [Export("Plugin1", typeof(IController))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class Plugin1Controller : Controller
    {
        // GET: Plugin1
        public ActionResult Index()
        {
            return View();
        }

        // GET: Plugin1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Plugin1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Plugin1/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Plugin1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Plugin1/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Plugin1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Plugin1/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
