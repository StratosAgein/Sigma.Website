using Sigma.Website.Models;
using Sigma.Website.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Sigma.Website.Controllers
{
    public class DashboardController : BaseController
    {
        public UserService _userService { get; set; }
        public DashboardController()
        {
            _userService = new UserService();
        }
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(string Email, string Password)
        {
            Authenticate result = await _userService.AuthenticateUser(Email, Password);
            return Json(new { Authentication = result}, JsonRequestBehavior.AllowGet);
        }

        public async Task<ActionResult> Wizard()
        {
            string sub = Subdomain;
            return View();
        }

        public ActionResult Start()
        {
            return View();
        }
    }
}