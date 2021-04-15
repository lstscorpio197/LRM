using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DTT.LRM.Web.Controllers.TaiSan
{
    public class TaiSanController : Controller
    {
        // GET: TaiSan
        public ActionResult Index()
        {
            return View("~/App/Main/views/TaiSan/index.cshtml");
        }
    }
}