<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcDynamicForms.Form>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    MVC Dynamic Form Responses
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        MVC Dynamic Form Responses</h2>
    <table>
        <tr>
            <th>
                Field Title
            </th>
            <th>
                Field Response
            </th>
        </tr>
        <%
            /* I'm going to simply echo the responses
             * back to the user, but you could do anything
             * you wanted to with these responses
             * (like storing them in a database).
             * 
             * passing true to GetResponses()
             * causes it to only return fields
             * that were completed by the user.
             * false returns everything.
             * */
            foreach (var response in Model.GetResponses(true))
          {%>
        <tr>
            <td>
                <%=response.Title %>
            </td>
            <td>
                <%=response.Value %>
            </td>
        </tr>
        <%} %>
    </table>
</asp:Content>
