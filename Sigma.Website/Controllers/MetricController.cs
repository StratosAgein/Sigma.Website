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
    public class MetricController : Controller
    {
        public MetricService _metricService { get; set; }

        public MetricController()
        {
            _metricService = new MetricService();
        }
        public async Task<ActionResult> Index()
        {
            return View();
        }
        public async Task<ActionResult> Create()
        {
            return View();
        }
        public async Task<ActionResult> Edit(Guid MetricId)
        {
            return View();
        }
        public async Task<ActionResult> Delete(Guid MetricId)
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> GetAllMetrics()
        {
            IEnumerable<Metric> result = await _metricService.GetAllMetrics();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public async Task<JsonResult> GetMetricById(string MetricId)
        {
            Metric result = await _metricService.GetMetricById(MetricId);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public async Task<JsonResult> CreateMetric(MetricViewModel metric)
        {
            if (ModelState.IsValid)
            {
                Metric _metric = AutoMapperConfiguration.Mapper.Map<Metric>(metric);
                bool result = await _metricService.CreateMetric(_metric);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<JsonResult> EditMetric(MetricViewModel metric)
        {
            if (ModelState.IsValid)
            {
                Metric _metric = AutoMapperConfiguration.Mapper.Map<Metric>(metric);
                bool result = await _metricService.EditMetric(_metric);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<JsonResult> DeleteMetric(string metricId)
        {
            if (ModelState.IsValid)
            {
                bool result = await _metricService.DeleteMetric(metricId);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}
