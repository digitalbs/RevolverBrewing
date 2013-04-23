using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Revolver.Models;

namespace Revolver.Controllers
{
    public class StoreController : Controller
    {
        private OrdersContext db = new OrdersContext();

        //
        // GET: /Store/

        public ActionResult Index()
        {
            return View(db.ProductDTOes.ToList());
        }

        //
        // GET: /Store/Details/5

        public ActionResult Details(int id = 0)
        {
            ProductDTO productdto = db.ProductDTOes.Find(id);
            if (productdto == null)
            {
                return HttpNotFound();
            }
            return View(productdto);
        }

        //
        // GET: /Store/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Store/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductDTO productdto)
        {
            if (ModelState.IsValid)
            {
                db.ProductDTOes.Add(productdto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(productdto);
        }

        //
        // GET: /Store/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ProductDTO productdto = db.ProductDTOes.Find(id);
            if (productdto == null)
            {
                return HttpNotFound();
            }
            return View(productdto);
        }

        //
        // POST: /Store/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductDTO productdto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productdto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productdto);
        }

        //
        // GET: /Store/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ProductDTO productdto = db.ProductDTOes.Find(id);
            if (productdto == null)
            {
                return HttpNotFound();
            }
            return View(productdto);
        }

        //
        // POST: /Store/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductDTO productdto = db.ProductDTOes.Find(id);
            db.ProductDTOes.Remove(productdto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}