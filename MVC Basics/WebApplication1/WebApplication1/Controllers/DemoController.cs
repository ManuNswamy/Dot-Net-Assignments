using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1.Controllers
{
    public class DemoController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            var controller = (string)requestContext.RouteData.Values["controller"];
            var action = (string)requestContext.RouteData.Values["action"];
            requestContext.HttpContext.Response.Write(
            string.Format("Controller: {0}, Action: {1}", controller, action));
        }
    }
}