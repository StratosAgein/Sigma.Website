using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sigma.Website.Services;
using Sigma.Website.Models;
using System.Threading.Tasks;

namespace Sigma.Website.Controllers
{
    public class OrganizationalUnitController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}