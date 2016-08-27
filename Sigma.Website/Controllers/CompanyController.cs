using Sigma.Website.Infraestructure;
using Sigma.Website.Models.Entities;
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


        [HttpGet]
        public async Task<JsonResult> GetAllCompany()
        {
            IEnumerable<Company> result = await _companyService.GetAllCompanies();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public async Task<JsonResult> GetCompanyById(string CompanyId)
        {
            Company result = await _companyService.GetCompanyById(CompanyId);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<JsonResult> CreateCompany(CompanyViewModel company)
        {
            if (ModelState.IsValid)
            {
                Company _company = AutoMapperConfiguration.Mapper.Map<Company>(company);
                bool result = await _companyService.CreateCompany(_company);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<JsonResult> EditCompany(CompanyViewModel company)
        {
            if (ModelState.IsValid)
            {
                Company _company = AutoMapperConfiguration.Mapper.Map<Company>(company);
                bool result = await _companyService.EditCompany(_company);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<JsonResult> DeleteCompany(string companyId)
        {
            if (ModelState.IsValid)
            {
                bool result = await _companyService.DeleteCompany(companyId);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}