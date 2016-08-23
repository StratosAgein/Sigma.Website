using Sigma.Website.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sigma.Website.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult NotFound()
        {
            ErrorViewmodel error = new ErrorViewmodel()
            {
                NumberTitle = "404",
                Title = "Sorry but we couldn't find this page",
                Description = "This page you are looking for does not exist."
            };
            return View(error);
        }

        public ActionResult AccessDenied()
        {
            ErrorViewmodel error = new ErrorViewmodel()
            {
                NumberTitle = "403",
                Title = "Access denied",
                Description = "This page you are looking for does not exist."
            };
            return View(error);
        }

        public ActionResult InternalServer()
        {
            ErrorViewmodel error = new ErrorViewmodel()
            {
                NumberTitle = "500",
                Title = "Internal Server Error",
                Description = "We track these errors automatically, but if the problem persists feel free to contact us. In the meantime, try refreshing."
            };
            return View(error);
        }
    }
}