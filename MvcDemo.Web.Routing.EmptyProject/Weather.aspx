﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Weather.aspx.cs" Inherits="MvcDemo.Web.Routing.EmptyProject.Weather" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>Route:</td>
                <td><%=RouteData.Route!=null ? RouteData.Route.GetType().FullName:"null" %></td>
            </tr>
            <tr>
                <td>RouteHandler:</td>
                <td><%=RouteData.RouteHandler != null ? RouteData.RouteHandler.GetType().FullName:"null" %></td>
            </tr>
            <tr>
                <td>Values:</td>
                <td>
                    <ul>
                    <%foreach (var item in RouteData.Values)
                      {%>
                    <li>
                        <%=item.Key%>=<%=item.Value%>
                    </li>
                          <% } %>
                        </ul>

                </td>
            </tr>
            <tr>
                <td>Data Tokens:</td>
                <td>
                    <ul>
                        <% foreach( var item in RouteData.DataTokens){ %>
                        <li>
                            <%=item.Key %>=<%=item.Value %>
                        </li>
                        <% } %>
                    </ul>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
