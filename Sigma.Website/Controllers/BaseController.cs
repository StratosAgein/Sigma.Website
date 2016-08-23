using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sigma.Website.Controllers
{
    public class BaseController : Controller
    {
        protected string Company
        {
            get { return (string)Request.RequestContext.RouteData.Values["Company"]; }
        }
        public BaseController()
        {

        }
    }
}