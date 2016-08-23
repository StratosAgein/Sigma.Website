using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sigma.Website.Services;
using Sigma.Website.Models.Entities;
using System.Threading.Tasks;

namespace Sigma.Website.Controllers
{
    public class EquipoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateEdit()
        {
            return View();
        }
        async public Task<JsonResult> GetEquipos()
        {
            EquipoService service = new EquipoService();
            return Json(await service.GetEquipos(), JsonRequestBehavior.AllowGet);
        }
        async public Task<JsonResult> GetEquipo(string Id)
        {
            EquipoService service = new EquipoService();
            return Json(await service.GetEquipo(Id), JsonRequestBehavior.AllowGet);
        }
        async public Task<string> UpdateEquipo(Equipo entity)
        {
            EquipoService service = new EquipoService();
            return await service.AddEquipo(entity) ? "registro guardado." : "Error guardando el registro.";
        }
        async public Task<string> AddEquipo(Equipo entity)
        {
            EquipoService service = new EquipoService();
            return await service.AddEquipo(entity) ? "registro guardado." : "Error guardando el registro.";
        }
        async public Task<string> DeleteEquipo(string Id)
        {
            EquipoService service = new EquipoService();
            return await service.DeleteEquipo(Id) ? "registro eliminado." : "Error eliminando el registro.";
        }
    }
}