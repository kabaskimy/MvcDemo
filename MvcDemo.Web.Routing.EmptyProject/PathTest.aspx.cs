using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Routing;

namespace MvcDemo.Web.Routing.EmptyProject
{
    public partial class PathTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.RouteData != null)
            {
                foreach (var item in this.RouteData.Values)
                {
                    Response.Write("key=" + item.Key + " ;value=" + item.Value);
                    Response.Write(@"<br>");
                }
                if (RouteData.Route != null)
                {
                    Route route = RouteData.Route as Route;
                    if (route != null && route.DataTokens != null)
                    {
                        Response.Write(route.DataTokens.Count);
                    }
                    else
                    {
                        if (route == null)
                        {
                            Response.Write("route value is null");
                        }
                        else
                        {
                            Response.Write("route DataToken value is null");
                        }
                    }
                }
            }
            else
            {
                Response.Write("RouteData is null");
            }


        }
    }
}