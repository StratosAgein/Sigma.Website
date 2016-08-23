using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sigma.Website.Controllers
{
    public class BaseController : Controller
    {
        protected string Subdomain
        {
            get { return (string)Request.RequestContext.RouteData.Values["subdomain"]; }
        }
        public BaseController()
        {

        }
    }
}