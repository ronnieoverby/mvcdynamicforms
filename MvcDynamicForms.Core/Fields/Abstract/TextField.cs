using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MvcDynamicForms.Fields
{
    /// <summary>
    /// Represents an html input field that will accept a text response from the user.
    /// </summary>
    [Serializable]
    public abstract class TextField : InputField
    {
        private string _regexMessage = "Invalid";

        /// <summary>
        /// A regular expression that will be applied to the user's text respone for validation.
        /// </summary>
        public string RegularExpression { get; set; }
        /// <summary>
        /// The error message that is displayed to the user when their response does no match the regular expression.
        /// </summary>
        public string RegexMessage
        {
            get
            {
                return _regexMessage;
            }
            set
            {
                _regexMessage = value;
            }
        }
        private string _value;
        public string Value
        {
            get
            {
                return _value ?? "";
            }
            set
            {
                _value = value;
            }
        }

        public override string Response
        {
            get { return Value.Trim(); }
        }
        public override bool Validate()
        {
            if (string.IsNullOrEmpty(Response))
            {
                if (Required)
                {
                    // invalid: is required and no response has been given
                    Error = RequiredMessage;
                    return false;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(RegularExpression))
                {
                    var regex = new Regex(RegularExpression);
                    if (!regex.IsMatch(Value))
                    {
                        // invalid: has regex and response doesn't match
                        Error = RegexMessage;
                        return false;
                    }
                }
            }

            // is valid
            ClearError();
            return true;
        }
    }
}