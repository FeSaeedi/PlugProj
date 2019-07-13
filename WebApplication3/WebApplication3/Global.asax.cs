using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebApplication3.App_Start;
using WebApplication3.Factories;

namespace WebApplication3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var pluginFolders = new List<string>();

            var plugins = Directory.GetDirectories(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Modules")).ToList();

            plugins.ForEach(s =>
            {
                var di = new DirectoryInfo(s);
                pluginFolders.Add(di.Name);
            });

            



            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Bootstrapper.Compose(pluginFolders);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory());
            ViewEngines.Engines.Add(new CustomViewEngine(pluginFolders));
        }
    }
}
