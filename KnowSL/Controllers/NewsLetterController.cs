using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnowSL.Models;
using KnowSL.Enumerations;
using KnowSL.Services;
using KnowSL.Database;

namespace KnowSL.Controllers
{
    public class NewsLetterController : Controller
    {

        [HttpPost]
        public ActionResult Register(PilotSignupModel model)
        {
            String message = @"";
            if (ModelState.IsValid)
            {
                // Attempt to add to news letter pilot signup
                PilotSignupStatus createStatus = new NewsLetterService().CreateOrUpdate(model.Email);

                if (createStatus == PilotSignupStatus.Success)
                {
                    //success
                    message = @"Thank you for signing up.";
                }
                else
                {
                    //fail
                }
            }

            return RedirectToAction("Index", "Home", new { message = message });
        }

        [Authorize]
        public ActionResult BetaUserList()
        {
            var viewModel = new NewsLetterService().GetAll();
            return View("Dashboard", viewModel);

        }
    }
}
