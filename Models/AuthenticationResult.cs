using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class AuthenticationResult
    {
        /// <summary>
        /// The result of the card holder authentication.
        /// Possible values: OK, NOT_SUPPORTED.
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// More details, if available. Contents may change at any time, so don’t parse it.
        /// Example: Card holder authentication with 3DSv2 successful.
        /// </summary>
        public string Message { get; set; }
    }
}
