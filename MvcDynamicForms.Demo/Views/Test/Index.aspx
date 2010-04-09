<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcDynamicForms.Form>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        $(function() {
            
        });
    </script>

    <%Html.BeginForm(); %>
    <%=Model.RenderHtml(true) %>
    <input type="submit" />
    <%Html.EndForm(); %>
</asp:Content>
