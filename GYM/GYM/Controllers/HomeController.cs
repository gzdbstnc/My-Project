using GYM.Models;
using System.Web.Mvc;

namespace GYM.Controllers
{
    public class HomeController : Controller
    {
        GymContext _db = new GymContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PreRegisteration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PreRegisteration(PreRegisterationForm model)

        {
            if (ModelState.IsValid)

            {
                PreRegisterationForm preRegisteration = new PreRegisterationForm();
                preRegisteration.Name = model.Name;
                preRegisteration.Surname = model.Surname;
                preRegisteration.Branches = model.Branches;
                preRegisteration.Facilities = model.Facilities;
                preRegisteration.Coach = model.Coach;
                preRegisteration.Phone = model.Phone;
                preRegisteration.Session = model.Session;

                _db.PreRegisterationForms.Add(preRegisteration);
                _db.SaveChanges();
            }
          
            //var preRegisteration = new PreRegisterationForm()
            //{
            //    Name=model.Name,
            //    Surname = model.Surname,
            //    Branches =model.Branches,
            //    Facilities=model.Facilities,
            //    Coach=model.Coach,
            //    Session=model.Session,
            //    Phone=model.Phone
            //};


            //_db.PreRegisterationForms.Add(preRegisteration);
            //_db.SaveChanges();


            return RedirectToAction("PreRegisteration", "Home");


        }

        public ActionResult Payment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Payment(Payment model)
        {
            if (ModelState.IsValid)
            {
                Payment payment = new Payment();
                payment.Dues = model.Dues;
                payment.DuesTime = model.DuesTime;
                payment.TCNo = model.TCNo;


                _db.Payments.Add(payment);
                _db.SaveChanges();
            }           
            return RedirectToAction("Payment", "Home");
        }

    public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Facilities()
        {
            return View();
        }

        public ActionResult Branches()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }
    }
}