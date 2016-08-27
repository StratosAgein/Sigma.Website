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
    public class BalanceScoreCardController : Controller
    {
        public BalanceScoreCardService _balanceScoreCardService { get; set; }
        public BalanceScoreCardController()
        {
            _balanceScoreCardService = new BalanceScoreCardService();
        }

        public async Task<ActionResult> Index()
        {
            return View();
        }
        public async Task<ActionResult> Create()
        {
            return View();
        }
        public async Task<ActionResult> Edit(Guid BalanceScoreCardId)
        {
            return View();
        }
        public async Task<ActionResult> Delete(Guid BalanceScoreCardId)
        {
            return View();
        }


        [HttpGet]
        public async Task<JsonResult> GetAllBalanceScoreCard()
        {
            IEnumerable<BalanceScoreCard> result = await _balanceScoreCardService.GetAllBalanceScoreCard();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public async Task<JsonResult> GetBalanceScoreCardById(string BalanceScoreCardId)
        {
            BalanceScoreCard result = await _balanceScoreCardService.GetBalanceScoreCardById(BalanceScoreCardId);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<JsonResult> CreateBalanceScoreCard(BalanceScoreCardViewModel balance)
        {
            if (ModelState.IsValid)
            {
                BalanceScoreCard _balance = AutoMapperConfiguration.Mapper.Map<BalanceScoreCard>(balance);
                bool result = await _balanceScoreCardService.CreateBalanceScoreCard(_balance);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<JsonResult> EditBalanceScoreCard(BalanceScoreCardViewModel balance)
        {
            if (ModelState.IsValid)
            {
                BalanceScoreCard _balance = AutoMapperConfiguration.Mapper.Map<BalanceScoreCard>(balance);
                bool result = await _balanceScoreCardService.EditBalanceScoreCard(_balance);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<JsonResult> DeleteBalanceScoreCard(string balanceId)
        {
            if (ModelState.IsValid)
            {
                bool result = await _balanceScoreCardService.DeleteBalanceScoreCard(balanceId);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}
