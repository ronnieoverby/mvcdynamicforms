<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcDynamicForms.Form>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        $(function() {

            // hide error labels when the user clicks on the offending input element
            $(':input').focus(function() {
                $(this).closest('td').children('label.MvcDynamicFieldError').fadeOut();
            });
        });
    </script>

    <%Html.BeginForm(); %>
    <%=Model.RenderHtml(true) %>
    <input type="submit" />
    <%Html.EndForm(); %>
</asp:Content>
