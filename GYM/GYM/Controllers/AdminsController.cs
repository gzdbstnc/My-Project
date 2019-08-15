using GYM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using GYM.Helpers;

namespace GYM.Controllers
{
    public class AdminsController : Controller
    {
        GymContext _db = new GymContext();
        //HashHelper _hash = new HashHelper();

        // GET: User
        public ActionResult FormPage()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]

        public ActionResult FormPage(User model)

        {

            if (ModelState.IsValid)

            {
                User user = new User();
                user.Email = model.Email;
                var password = StringHelper.CreateMD5(model.Password);
                user.Password = password;

                _db.Users.Add(user);
                _db.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }

        //public ActionResult Login()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]

        //public ActionResult Login(User model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        User user = new User();
        //        user.Email = model.Email;
        //        user.Password = model.Password;
        //        //_db.Users.Add(user);
        //        // _db.SaveChanges();
        //    }

        //    return RedirectToAction("Index", "Home");
        //}
    }
}