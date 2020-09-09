using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Dcc information, if applicable
    /// </summary>
    public class DccInformation
    {
        /// <summary>
        /// Amount in payer’s currency
        /// </summary>
        public Amount PayerAmount { get; set; }
    }
}
