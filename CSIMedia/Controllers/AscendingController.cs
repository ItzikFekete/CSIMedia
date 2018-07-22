using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSIMedia.Controllers
{
    public class AscendingController : Controller
    {
        // GET: Ascending
        public ActionResult Index()
        {
            return View();
        }

        // GET: Ascending/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ascending/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ascending/Create
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

        // GET: Ascending/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ascending/Edit/5
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

        // GET: Ascending/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ascending/Delete/5
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
