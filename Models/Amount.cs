using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Amount data (currency, value, etc.)
    /// </summary>
    public class Amount
    {
        /// <summary>
        /// Amount in minor unit (CHF 1.00 ⇒ Value=100). Only Integer values will be accepted!
        /// Example: 100 
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// ISO 4217 3-letter currency code (CHF, USD, EUR, ...)
        /// Example: CHF
        /// </summary>
        public string CurrencyCode { get; set; }
    }
}
