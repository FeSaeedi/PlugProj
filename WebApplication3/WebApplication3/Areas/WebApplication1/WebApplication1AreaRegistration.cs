using System.Web.Mvc;

namespace WebApplication3.Areas.WebApplication1
{
    public class WebApplication1AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "WebApplication1";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            //context.MapRoute(
            //    "WebApplication1_default",
            //    "WebApplication1/{controller}/{action}/{id}",
            //    new { action = "Index", id = UrlParameter.Optional }
            //);
            context.MapRoute(
           "forum_default",
           "Forum/{controller}/{action}/{id}",
           new { action = "Index", id = UrlParameter.Optional },
           namespaces: new string[] { "WebApplication1.Controllers" }
           );
        }
    }
}