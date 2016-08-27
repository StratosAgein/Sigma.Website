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
    public class ClientController : Controller
    {
        public ClientService _clientService { get; set; }

        public ClientController()
        {
            _clientService = new ClientService();
        }
        public async Task<ActionResult> Index()
        {
            return View();
        }
        public async Task<ActionResult> Create()
        {
            return View();
        }
        public async Task<ActionResult> Edit(Guid ClientId)
        {
            return View();
        }
        public async Task<ActionResult> Delete(Guid ClientId)
        {
            return View();
        }
        [HttpGet]
        public async Task<JsonResult> GetAllClients()
        {
            IEnumerable<Client> result = await _clientService.GetAllClients();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public async Task<JsonResult> GetClientById(string ClientId)
        {
            Client result = await _clientService.GetClientById(ClientId);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<JsonResult> CreateClient(HttpClientCertificate client)
        {
            if (ModelState.IsValid)
            {
                Client _client = AutoMapperConfiguration.Mapper.Map<Client>(client);
                bool result = await _clientService.CreateClient(_client);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<JsonResult> EditClient(ClientViewModel client)
        {
            if (ModelState.IsValid)
            {
                Client _client = AutoMapperConfiguration.Mapper.Map<Client>(client);
                bool result = await _clientService.EditClient(_client);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<JsonResult> DeleteClient(string clientId)
        {
            if (ModelState.IsValid)
            {
                bool result = await _clientService.DeleteClient(clientId);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}
