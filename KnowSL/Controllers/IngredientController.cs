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
    public class IngredientController : Controller
    {
        private DB_9B214B_ProductKnowledgeEntities2 db = new DB_9B214B_ProductKnowledgeEntities2();

        //
        // GET: /Ingredient/

        public ViewResult Index()
        {
            return View(db.Ingredients.ToList());
        }

        //
        // GET: /Ingredient/Details/5

        public ViewResult Details(int id)
        {
            Ingredient ingredient = db.Ingredients.Single(i => i.IngredientID == id);
            return View(ingredient);
        }

        //
        // GET: /Ingredient/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Ingredient/Create

        [HttpPost]
        public ActionResult Create(Ingredient ingredient)
        {
            if (ModelState.IsValid)
            {
                db.Ingredients.AddObject(ingredient);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(ingredient);
        }
        
        //
        // GET: /Ingredient/Edit/5
 
        public ActionResult Edit(int id)
        {
            Ingredient ingredient = db.Ingredients.Single(i => i.IngredientID == id);
            return View(ingredient);
        }

        //
        // POST: /Ingredient/Edit/5

        [HttpPost]
        public ActionResult Edit(Ingredient ingredient)
        {
            if (ModelState.IsValid)
            {
                db.Ingredients.Attach(ingredient);
                db.ObjectStateManager.ChangeObjectState(ingredient, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ingredient);
        }

        //
        // GET: /Ingredient/Delete/5
 
        public ActionResult Delete(int id)
        {
            Ingredient ingredient = db.Ingredients.Single(i => i.IngredientID == id);
            return View(ingredient);
        }

        //
        // POST: /Ingredient/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Ingredient ingredient = db.Ingredients.Single(i => i.IngredientID == id);
            db.Ingredients.DeleteObject(ingredient);
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