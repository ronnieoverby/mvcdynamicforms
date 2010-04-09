using System.Linq;
using MvcDynamicForms.Fields;
using System.Web.Mvc;

namespace MvcDynamicForms.Demo.Models
{
    public static class FormProvider
    {
        public static Form GetForm()
        {
            /*
             * This method sets up the Form and Field objects that 
             * are needed to dynamically generate html forms at runtime.
             * 
             * Of course, there are other ways of going about defining your forms and their fields.
             * I used a static class in this demo application for simplicity.
             * In the real world, you could store your field definitions anywhere.
             * 
             * For example, you could create a database table to store all 
             * of the data needed to create the form fields below.
             * Some of your end users could have access to some kind of interface to create, update,
             * or delete the form field definitions in the database.
             * This described scenario was actually the inspiration for this project.
             * 
             * There are 7 different Field types that can be used to construct the form:
             *  - TextBox (single line text input)
             *  - Textarea (multi line text input)
             *  - Checkbox
             *  - CheckboxList
             *  - RadioList
             *  - Select (Drop down lists and List boxes)
             *  - Literal (Any custom html at all. For display purposes only (no user input))
             *  
             * Each Field type have a few things in common:
             *  - Title property: Used when storing end user's responses.
             *  - Prompt property: Question asked to the user for each field.
             *  - DisplayOrder property: The order that the field is displayed to the user.
             *  - Required property: Is the user required to complete the field?
             *  - InputHtmlAttributes: Allows the developer to set the input elements html attributes
             *  
             * There are other properties and behaviors that some Field types do not share with each other.
             * Take a look through the members of each Type to see what you can do.
             * Much of each type's unique functionality is demonstrated below.
             * Feel free to tinker around in this file, changing and adding fields.
             * Don't forget to add newly created fields to the Form.
             * 
             * The Form object is the object that contains all of your Field objects, 
             * triggers validation and rendering, and lets the developer access user responses.
             * When constructing your form, you can use Form.AddFields() to get your Fields
             * into the form (imagine that!).
             * 
             * Check out
             *    /Controllers/HomeController.cs
             *    /Views/Home/Demo.aspx
             *    /Views/Home/Responses.aspx
             * to learn how to use the Form object in your web application.
             */

            // create fields
            var chong = new Literal
            {
                  Template = string.Format(@"<p id=""{0}"">{1}</p>",PlaceHolders.FieldWrapperId,PlaceHolders.Literal),
                  Html = "Howdy y'all!"
            };

            var yesNo = new RadioList
            {
                Key = "yesNo",
                Prompt = "Do you want to fill out this form?",
                ResponseTitle = "Wanted To Fill Out Form",
                CommaDelimitedChoices = "Yes,No",
                Required = true
            };
            yesNo.Choices.Single(x => x.Text == "No").Selected = true;

            var name = new TextBox
            {
                Key="name",
                Prompt = "Full Name",
                Required = true
            };

            var email = new TextBox
            {
                Key = "email",
                Prompt = "Email Address",
                RegularExpression = RegexPatterns.EmailAddress,
                Required = true,
                Value = "rdodontplay@gmail.com"

            };
            yesNo.AddDataValue("children", new[] { name.Key, email.Key }, true);

            // create form and add fields to it
            var form = new Form();
            
            form.AddFields(chong,yesNo, name, email);

            return form;
        }
    }
}
