using SomethingToDo.App_Start;
using SomethingToDo.DependencyInjection;
using SomethingToDo.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SomethingToDo
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var container = DependencyInjectionConfiguration.Register();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityResolver(container);

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            TestService test = new TestService();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (this.Context.Request.Path.Contains("signalr/"))
            {
                this.Context.Response.AddHeader("Access-Control-Allow-Headers", "accept,origin,authorization,content-type");
            }
        }
    }
}
