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

        [HttpPost]
        public ActionResult BetaUserList(UserLoginModel creds)
        {
            if (creds != null && !String.IsNullOrWhiteSpace(creds.UserName) && !String.IsNullOrWhiteSpace(creds.Password))
            {

                var viewModel = new List<NewsLetter>();

                if (creds.UserName.ToLower() == @"eric@knowsl.com"
                    && creds.Password == @"July20!4")
                {

                    HttpCookie aCookie = new HttpCookie("userInfo");
                    aCookie.Value = DateTime.Now.ToString();
                    aCookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(aCookie);
                    viewModel = new NewsLetterService().GetAll();
                }

                if (Request.Cookies["userInfo"] != null)
                {
                    return View(viewModel);
                }
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
