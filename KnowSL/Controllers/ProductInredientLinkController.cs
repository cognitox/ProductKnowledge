using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnowSL.ContextDB;

namespace KnowSL.Controllers
{
    [Authorize]
    public class ProductInredientLinkController : Controller
    {
        private DB_9B214B_ProductKnowledgeEntities2 db = new DB_9B214B_ProductKnowledgeEntities2();

        //
        // GET: /ProductInredientLink/

        public ViewResult Index()
        {
            return View(db.ProductIngredientLinks.ToList());
        }

        //
        // GET: /ProductInredientLink/Details/5

        public ViewResult Details(int id)
        {
            ProductIngredientLink productingredientlink = db.ProductIngredientLinks.Single(p => p.ProductIngredientLinkID == id);
            return View(productingredientlink);
        }

        //
        // GET: /ProductInredientLink/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /ProductInredientLink/Create

        [HttpPost]
        public ActionResult Create(ProductIngredientLink productingredientlink)
        {
            if (ModelState.IsValid)
            {
                db.ProductIngredientLinks.AddObject(productingredientlink);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(productingredientlink);
        }
        
        //
        // GET: /ProductInredientLink/Edit/5
 
        public ActionResult Edit(int id)
        {
            ProductIngredientLink productingredientlink = db.ProductIngredientLinks.Single(p => p.ProductIngredientLinkID == id);
            return View(productingredientlink);
        }

        //
        // POST: /ProductInredientLink/Edit/5

        [HttpPost]
        public ActionResult Edit(ProductIngredientLink productingredientlink)
        {
            if (ModelState.IsValid)
            {
                db.ProductIngredientLinks.Attach(productingredientlink);
                db.ObjectStateManager.ChangeObjectState(productingredientlink, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productingredientlink);
        }

        //
        // GET: /ProductInredientLink/Delete/5
 
        public ActionResult Delete(int id)
        {
            ProductIngredientLink productingredientlink = db.ProductIngredientLinks.Single(p => p.ProductIngredientLinkID == id);
            return View(productingredientlink);
        }

        //
        // POST: /ProductInredientLink/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            ProductIngredientLink productingredientlink = db.ProductIngredientLinks.Single(p => p.ProductIngredientLinkID == id);
            db.ProductIngredientLinks.DeleteObject(productingredientlink);
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