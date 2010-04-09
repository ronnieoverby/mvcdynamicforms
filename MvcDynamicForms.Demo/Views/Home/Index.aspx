<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    MVC Dynamic Forms
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Thanks for trying MVC Dynamic Forms!</h2>
    <p>
        This web application demonstrates how you can use MVC Dynamic Forms. To learn more,
        study these files in the MvcDynamicForms.Demo project:
    </p>
    <ul>
        <li><b>/Models/FormProvider.cs</b> - Shows how to construct the Form and Field objects.</li>
        <li><b>/Controllers/HomeController.cs</b> - Shows how to use the Form and Field objects
            in your web applicaiton.</li>
        <li><b>/Views/Home/Demo.aspx</b> - Shows how to render the form in your views and demonstrates
            some basic client side funcationality.</li>
        <li><b>/Content/DynamicForm.css</b> - Explains how to style the dynamically generated
            form.</li>
        <li><b>/Views/Home/Responses.aspx</b> - Shows how to make use of the user's responses
            to dynamically generated form fields.</li>
    </ul>
    <p>
        <a href="http://mvcdynamicforms.codeplex.com" target="_blank">MVC Dynamic Forms on CodePlex</a>
    </p>
</asp:Content>
