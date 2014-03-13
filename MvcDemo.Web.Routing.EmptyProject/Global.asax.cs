using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;

namespace MvcDemo.Web.Routing.EmptyProject
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.RouteExistingFiles = true;
            var defaults=new RouteValueDictionary(){{"name","*"},{"id","*"}};
            var defaults2=new RouteValueDictionary(){{"filename","google"},{"extension","html"},{"pathinfo",@"zhihu/will"}};
            RouteTable.Routes.MapPageRoute("TestDemo", "employees/{name}/{id}", "~/Index.aspx", true, defaults);
            //RouteTable.Routes.MapPageRoute("TestDemo2", "weather/{filename}.{extension}/{*pathinfo}", "~/PathTest.aspx", true);
            Route route = new Route("weather/{filename}.{extension}/{*pathinfo}", defaults2, new PageRouteHandler("~/PathTest.aspx", false));
            RouteTable.Routes.Add(route);

            var defaults3 = new RouteValueDictionary { { "areacode", "0755" }, { "days", 3 } };
            var constrains=new RouteValueDictionary{{"areacode",@"0\d{2,3}"},{"days","[1-3]"},{"httpMethod",new HttpMethodConstraint("POST")}};
            var datatokens = new RouteValueDictionary { { "defaultCity", "Shenzhen" }, { "defaultDays", 2 } };
            RouteTable.Routes.MapPageRoute("TestDemo3", "Report/{areacode}/{days}", "~/Weather.aspx", false, defaults3,null, datatokens);
            RouteTable.Routes.AppendTrailingSlash = true;
            RouteTable.Routes.LowercaseUrls = true;

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}