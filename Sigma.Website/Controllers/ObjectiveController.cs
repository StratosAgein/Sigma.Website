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
    public class ObjectiveController : Controller
    {
        public ObjectiveService _objectiveService { get; set; }
        public ObjectiveController()
        {
            _objectiveService = new ObjectiveService();
        }
        public async Task<ActionResult> Index()
        {
            return View();
        }
        public async Task<ActionResult> Create()
        {
            return View();
        }
        public async Task<ActionResult> Edit(Guid ObjectiveId)
        {
            return View();
        }
        public async Task<ActionResult> Delete(Guid ObjectiveId)
        {
            return View();
        }
        [HttpGet]
        public async Task<JsonResult> GetAllObjectives()
        {
            IEnumerable<Objective> result = await _objectiveService.GetAllObjectives();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public async Task<JsonResult> GetObjectiveById(string ObjectiveId)
        {
            Objective result = await _objectiveService.GetObjectiveById(ObjectiveId);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<JsonResult> CreateObjective(ObjectiveViewModel objective)
        {
            if (ModelState.IsValid)
            {
                Objective _objective = AutoMapperConfiguration.Mapper.Map<Objective>(objective);
                bool result = await _objectiveService.CreateObjective(_objective);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<JsonResult> EditObjective(ObjectiveViewModel objective)
        {
            if (ModelState.IsValid)
            {
                Objective _objective = AutoMapperConfiguration.Mapper.Map<Objective>(objective);
                bool result = await _objectiveService.EditObjective(_objective);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<JsonResult> DeleteObjective(string ObjectiveId)
        {
            if (ModelState.IsValid)
            {
                bool result = await _objectiveService.DeleteObjective(ObjectiveId);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}