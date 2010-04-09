<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcDynamicForms.Form>" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    MVC Dynamic Form
</asp:Content>
<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        /* You can build in client side funcationality with dynamic forms also. 
        jQuery is very good for this sort of thing. */

        $(function() {

            // hide error labels when the user clicks on the offending input element
            $('div.MvcFieldWrapper :input').focus(function() {
                $(this).closest('div.MvcFieldWrapper').children('label.MvcDynamicFieldError').fadeOut();
            });
        });
    </script>

    <h2>
        Dynamically Generated Form</h2>
    <%Html.BeginForm(); %>
    
    <%--
    Here we are calling Form.RenderHtml, which returns a string containing all of the form's html.
    We pass true to the method which tells it to format the html with indentation and whitespace, making
    it much more human readable. This should only be used when debugging, not for production, as it slows
    performance.
    
    The RenderHtml() method doesn't render any form elements nor submit buttons. As you can see,
    we have surrounded the RenderHtml() method call with the needed elements for form submission.
        --%>
    
    <%=Model.RenderHtml(true) %>
    
    
    <input type="submit" value="Submit" />
    <%Html.EndForm(); %>
</asp:Content>
