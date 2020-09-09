using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class Error
    {
        /// <summary>
        /// Name / id of the error.
        /// Example: ErrorName
        /// </summary>
        public string ErrorName { get; set; }

        /// <summary>
        /// Description of the error.
        /// Example: ErrorMessage
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
