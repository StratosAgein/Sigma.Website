using Sigma.Website.Models;
using Sigma.Website.Services;
using Sigma.Website.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Sigma.Website.Controllers
{
    public class CompanyController : Controller
    {
        private CompanyService _companyService { get; set; }

        public CompanyController()
        {
            _companyService = new CompanyService();
        }

        public async Task<ActionResult> Index()
        {
            return View();
        }
        public async Task<ActionResult> Create()
        {
            return View();
        }
        public async Task<ActionResult> Edit(Guid CompanyId)
        {
            return View();
        }
        public async Task<ActionResult> Delete(Guid CompanyId)
        {
            return View();
        }

        public async Task<JsonResult> CreateCompany(CompanyViewModel company)
        {
            if (ModelState.IsValid)
            {
                Company _company = new Company();
                bool result = await _companyService.CreateCompany(_company);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}