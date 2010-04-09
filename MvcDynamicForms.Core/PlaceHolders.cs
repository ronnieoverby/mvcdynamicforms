
using System.Text;
using System.Collections.Generic;
namespace MvcDynamicForms
{
    /// <summary>
    /// Static class containing place holder tokens to be used with form and field templates.
    /// </summary>
    public static class PlaceHolders
    {
        private const string FIELDS = "1e6e1ef1-8acc-48b7-b1e8-705893b0411c";
        private const string INPUT = "2bb514da-20ef-483a-9441-d03d83d0471a";
        private const string PROMPT = "3cb27d35-c390-440a-9114-838e8ba0acf3";
        private const string ERROR = "0c9cb943-e4b1-480e-ba27-bc1cba8ceefe";
        private const string LITERAL = "9a119965-583e-4874-9442-201b0f082fd6";
        private const string SERIALIZEDFORM = "592a069d-b1b2-4489-9fc2-6dc2f5d57ca3";
        private const string DATASCRIPT = "e535d8d3-1e7b-4f1d-a3a4-2e55e9c3c0c4";
        private const string FIELDWRAPPERID = "0ec5e0a1-a01a-4384-9f73-5c06ab2db5d3";

        /// <summary>
        /// Place holder for fields' rendered HTML.
        /// For use only with the Form.Template property.
        /// </summary>
        public static string Fields
        {
            get
            {
                return FIELDS;
            }
        }
        /// <summary>
        /// Place holder for an InputField's input elements. 
        /// For use only with the InputField.Template property.
        /// </summary>
        public static string Input
        {
            get
            {
                return INPUT;
            }
        }
        /// <summary>
        /// Place holder for an InputField's prompt label element. 
        /// For use only with the InputField.Template property.
        /// </summary>
        public static string Prompt
        {
            get
            {
                return PROMPT;
            }
        }
        /// <summary>
        /// Place holder for an InputField's error label element. 
        /// For use only with the InputField.Template property.
        /// </summary>
        public static string Error
        {
            get
            {
                return ERROR;
            }
        }
        /// <summary>
        /// Place holder for a Literal field's html. 
        /// For use only with the Literal.Template property.
        /// </summary>
        public static string Literal
        {
            get
            {
                return LITERAL;
            }
        }
        /// <summary>
        /// Place holder for a Form's serialized state as a hidden html input element. 
        /// For use only with the Form.Template property.
        /// </summary>
        public static string SerializedForm
        {
            get
            {
                return SERIALIZEDFORM;
            }
        }
        /// <summary>
        /// Place holder for Form's Fields' client-side data represented as JSON in an HTML script element.
        /// For use only with the Form.Template property.
        /// </summary>
        public static string DataScript
        {
            get
            {
                return DATASCRIPT;
            }
        }
        /// <summary>
        /// Place holder for a Field's wrapping element's ID attribute value.
        /// The wrapping element is given a unique ID for DOM manipulation purposes.
        /// For use only with the Field.Template property.
        /// </summary>
        public static string FieldWrapperId
        {
            get
            {
                return FIELDWRAPPERID;
            }
        }        

        internal static StringBuilder RemoveAll(StringBuilder html)
        {
            return html
                .Replace(FIELDS, string.Empty)
                .Replace(INPUT, string.Empty)
                .Replace(PROMPT, string.Empty)
                .Replace(ERROR, string.Empty)
                .Replace(LITERAL, string.Empty)
                .Replace(SERIALIZEDFORM, string.Empty)
                .Replace(DATASCRIPT, string.Empty)
                .Replace(FIELDWRAPPERID, string.Empty);
        }
    }
}