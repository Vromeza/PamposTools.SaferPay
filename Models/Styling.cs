using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class Styling
    {
        /// <summary>
        /// When enabled, then ContentSecurity/SAQ-A is requested, which leads to the CSS being loaded from the saferpay server.
        /// </summary>
        public bool ContentSecurityEnabled { get; set; }

        /// <summary>
        /// This parameter let you customize the appearance of the displayed payment pages. Per default a lightweight responsive styling will be applied.
        /// If you don't want any styling use 'NONE'.
        /// Possible values: DEFAULT, SIX, NONE.
        /// Example: DEFAULT
        /// </summary>
        public string Theme { get; set; }
    }
}
