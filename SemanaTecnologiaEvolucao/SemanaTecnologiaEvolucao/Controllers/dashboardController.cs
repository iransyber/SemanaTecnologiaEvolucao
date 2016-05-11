using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace SemanaTecnologiaEvolucao.Controllers
{
    [EnableCors("*", "*", "*")]
    [Authorize]
    public class DashboardController : Controller
    {
        // GET: dashboard
        //[AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
    }
}