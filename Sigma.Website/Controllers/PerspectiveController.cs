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
    public class PerspectiveController : Controller
    {
        public PerspectiveService _perspectiveService { get; set; }
        public PerspectiveController()
        {
            _perspectiveService = new PerspectiveService();
        }
        public async Task<ActionResult> Index()
        {
            return View();
        }
        public async Task<ActionResult> Create()
        {
            return View();
        }
        public async Task<ActionResult> Edit(Guid PerspectiveId)
        {
            return View();
        }
        public async Task<ActionResult> Delete(Guid PerspectiveId)
        {
            return View();
        }
        [HttpGet]
        public async Task<JsonResult> GetAllPerspective()
        {
            IEnumerable<Perspective> result = await _perspectiveService.GetAllPerspective();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public async Task<JsonResult> GetPerspectiveById(string PerspectiveId)
        {
            Perspective result = await _perspectiveService.GetPerspectiveById(PerspectiveId);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public async Task<JsonResult> CreatePerspective(PerspectiveViewModel Perspective)
        {
            if (ModelState.IsValid)
            {
                Perspective _Perspective = AutoMapperConfiguration.Mapper.Map<Perspective>(Perspective);
                bool result = await _perspectiveService.CreatePerspective(_Perspective);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<JsonResult> EditPerspective(PerspectiveViewModel Perspective)
        {
            if (ModelState.IsValid)
            {
                Perspective _Perspective = AutoMapperConfiguration.Mapper.Map<Perspective>(Perspective);
                bool result = await _perspectiveService.EditPerspective(_Perspective);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<JsonResult> DeletePerspective(string PerspectiveId)
        {
            if (ModelState.IsValid)
            {
                bool result = await _perspectiveService.DeletePerspective(PerspectiveId);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}