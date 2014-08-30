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
    public class IngredientDescriptionController : Controller
    {
        private DB_9B214B_ProductKnowledgeEntities2 db = new DB_9B214B_ProductKnowledgeEntities2();

        //
        // GET: /IngredientDescription/

        public ViewResult Index()
        {
            return View(db.IngredientDescriptions.ToList());
        }

        //
        // GET: /IngredientDescription/Details/5

        public ViewResult Details(int id)
        {
            IngredientDescription ingredientdescription = db.IngredientDescriptions.Single(i => i.IngredientDescriptionID == id);
            return View(ingredientdescription);
        }

        //
        // GET: /IngredientDescription/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /IngredientDescription/Create

        [HttpPost]
        public ActionResult Create(IngredientDescription ingredientdescription)
        {
            if (ModelState.IsValid)
            {
                db.IngredientDescriptions.AddObject(ingredientdescription);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(ingredientdescription);
        }
        
        //
        // GET: /IngredientDescription/Edit/5
 
        public ActionResult Edit(int id)
        {
            IngredientDescription ingredientdescription = db.IngredientDescriptions.Single(i => i.IngredientDescriptionID == id);
            return View(ingredientdescription);
        }

        //
        // POST: /IngredientDescription/Edit/5

        [HttpPost]
        public ActionResult Edit(IngredientDescription ingredientdescription)
        {
            if (ModelState.IsValid)
            {
                db.IngredientDescriptions.Attach(ingredientdescription);
                db.ObjectStateManager.ChangeObjectState(ingredientdescription, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ingredientdescription);
        }

        //
        // GET: /IngredientDescription/Delete/5
 
        public ActionResult Delete(int id)
        {
            IngredientDescription ingredientdescription = db.IngredientDescriptions.Single(i => i.IngredientDescriptionID == id);
            return View(ingredientdescription);
        }

        //
        // POST: /IngredientDescription/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            IngredientDescription ingredientdescription = db.IngredientDescriptions.Single(i => i.IngredientDescriptionID == id);
            db.IngredientDescriptions.DeleteObject(ingredientdescription);
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