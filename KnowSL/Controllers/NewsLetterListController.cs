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
    public class NewsLetterListController : Controller
    {
        private DB_9B214B_ProductKnowledgeEntities2 db = new DB_9B214B_ProductKnowledgeEntities2();

        //
        // GET: /NewsLetterList/

        public ViewResult Index()
        {
            return View(db.NewsLetters.ToList());
        }

        //
        // GET: /NewsLetterList/Details/5

        public ViewResult Details(int id)
        {
            NewsLetter newsletter = db.NewsLetters.Single(n => n.NewsLetterID == id);
            return View(newsletter);
        }

        //
        // GET: /NewsLetterList/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /NewsLetterList/Create

        [HttpPost]
        public ActionResult Create(NewsLetter newsletter)
        {
            if (ModelState.IsValid)
            {
                db.NewsLetters.AddObject(newsletter);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(newsletter);
        }
        
        //
        // GET: /NewsLetterList/Edit/5
 
        public ActionResult Edit(int id)
        {
            NewsLetter newsletter = db.NewsLetters.Single(n => n.NewsLetterID == id);
            return View(newsletter);
        }

        //
        // POST: /NewsLetterList/Edit/5

        [HttpPost]
        public ActionResult Edit(NewsLetter newsletter)
        {
            if (ModelState.IsValid)
            {
                db.NewsLetters.Attach(newsletter);
                db.ObjectStateManager.ChangeObjectState(newsletter, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newsletter);
        }

        //
        // GET: /NewsLetterList/Delete/5
 
        public ActionResult Delete(int id)
        {
            NewsLetter newsletter = db.NewsLetters.Single(n => n.NewsLetterID == id);
            return View(newsletter);
        }

        //
        // POST: /NewsLetterList/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            NewsLetter newsletter = db.NewsLetters.Single(n => n.NewsLetterID == id);
            db.NewsLetters.DeleteObject(newsletter);
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