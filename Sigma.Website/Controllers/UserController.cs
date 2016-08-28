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
    public class UserController : Controller
    {
        public UserService _userService { get; set; }
        public UserController()
        {
            _userService = new UserService();
        }
        public async Task<ActionResult> Index()
        {
            return View();
        }

        public async Task<ActionResult> Create()
        {
            return View();
        }
        public async Task<ActionResult> Edit(Guid UserId)
        {
            return View();
        }
        public async Task<ActionResult> Delete(Guid UserId)
        {
            return View();
        }
        [HttpGet]
        public async Task<JsonResult> GetAllUsers()
        {
            IEnumerable<User> result = await _userService.GetAllUsers();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public async Task<JsonResult> GetPerspectiveById(string PerspectiveId)
        {
            User result = await _userService.GetUserById(PerspectiveId);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public async Task<JsonResult> CreatePerspective(UserViewModel User)
        {
            if (ModelState.IsValid)
            {
                User _Perspective = AutoMapperConfiguration.Mapper.Map<User>(User);
                bool result = await _userService.CreateUser(_Perspective);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<JsonResult> EditPerspective(UserViewModel User)
        {
            if (ModelState.IsValid)
            {
                User _user = AutoMapperConfiguration.Mapper.Map<User>(User);
                bool result = await _userService.EditUser(_user);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<JsonResult> DeletePerspective(string UserId)
        {
            if (ModelState.IsValid)
            {
                bool result = await _userService.DeleteUser(UserId);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}