using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
<<<<<<< HEAD
using System.Web.Optimization;
=======
>>>>>>> d61e690431a2ddf3838ab979ed31e49a720ad2de
using System.Web.Routing;

namespace Nero
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
<<<<<<< HEAD

=======
>>>>>>> d61e690431a2ddf3838ab979ed31e49a720ad2de
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
<<<<<<< HEAD
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
=======
>>>>>>> d61e690431a2ddf3838ab979ed31e49a720ad2de
        }
    }
}