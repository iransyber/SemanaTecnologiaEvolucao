using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SemanaTecnologiaEvolucao.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        // GET: dashboard
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
    }
}