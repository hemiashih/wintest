using GashPortal.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : BaseController
    {
        //[Role("abc")]
        public ActionResult Index()
        {
            return View();
        }

        [Role("RoleTest")]
        public ActionResult RoleTest()
        {
            return View();
        }
    }
}