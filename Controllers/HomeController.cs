using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Test01.Models;

namespace Test01.Controllers
{
    public partial class HomeController : Controller
    {
        public ActionResult Index()
        {   
            // InitializeComponent();
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;
			string mystring = "";
            //create DBContext object
          /*
            var ctx = new TestContext();
            var test = new TestClass(){ Name = "Blub blup test" };

			//Add Student object into Students DBset
			ctx.Tests.Add(test);

			// call SaveChanges method to save student into database
			ctx.SaveChanges();
            			
			foreach (var item in ctx.Tests.ToList())
			{
				mystring += item.Name+"</br>";
				//item.Name = "This is a Test";
			}
			ctx.SaveChanges();
            */

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor + " >>> " + mystring;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            return View();
        }
    }
}
