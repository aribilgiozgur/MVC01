using MVC01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC01.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact() {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactUser user) {
            /*String name = formCol.Get("firstName");
            String surname = formCol.Get("lastName");
            String email = formCol.Get("eMail");
            DateTime dateOfBirth = DateTime.Parse(formCol.Get("dateOfBirth"));
            */
            /*Insert işlemi...*/

            return View("Index");
        }

        

    }
}
