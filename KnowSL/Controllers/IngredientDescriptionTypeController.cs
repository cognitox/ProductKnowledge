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
    public class IngredientDescriptionTypeController : Controller
    {
        private DB_9B214B_ProductKnowledgeEntities2 db = new DB_9B214B_ProductKnowledgeEntities2();

        //
        // GET: /IngredientDescriptionType/

        public ViewResult Index()
        {
            return View(db.IngredientDescriptionTypes.ToList());
        }

        //
        // GET: /IngredientDescriptionType/Details/5

        public ViewResult Details(int id)
        {
            IngredientDescriptionType ingredientdescriptiontype = db.IngredientDescriptionTypes.Single(i => i.IngredientDescriptionTypeID == id);
            return View(ingredientdescriptiontype);
        }

        //
        // GET: /IngredientDescriptionType/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /IngredientDescriptionType/Create

        [HttpPost]
        public ActionResult Create(IngredientDescriptionType ingredientdescriptiontype)
        {
            if (ModelState.IsValid)
            {
                db.IngredientDescriptionTypes.AddObject(ingredientdescriptiontype);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(ingredientdescriptiontype);
        }
        
        //
        // GET: /IngredientDescriptionType/Edit/5
 
        public ActionResult Edit(int id)
        {
            IngredientDescriptionType ingredientdescriptiontype = db.IngredientDescriptionTypes.Single(i => i.IngredientDescriptionTypeID == id);
            return View(ingredientdescriptiontype);
        }

        //
        // POST: /IngredientDescriptionType/Edit/5

        [HttpPost]
        public ActionResult Edit(IngredientDescriptionType ingredientdescriptiontype)
        {
            if (ModelState.IsValid)
            {
                db.IngredientDescriptionTypes.Attach(ingredientdescriptiontype);
                db.ObjectStateManager.ChangeObjectState(ingredientdescriptiontype, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ingredientdescriptiontype);
        }

        //
        // GET: /IngredientDescriptionType/Delete/5
 
        public ActionResult Delete(int id)
        {
            IngredientDescriptionType ingredientdescriptiontype = db.IngredientDescriptionTypes.Single(i => i.IngredientDescriptionTypeID == id);
            return View(ingredientdescriptiontype);
        }

        //
        // POST: /IngredientDescriptionType/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            IngredientDescriptionType ingredientdescriptiontype = db.IngredientDescriptionTypes.Single(i => i.IngredientDescriptionTypeID == id);
            db.IngredientDescriptionTypes.DeleteObject(ingredientdescriptiontype);
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