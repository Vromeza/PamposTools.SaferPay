using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class PaymentPageAssertRequest : RequestBase
    {
        /// <summary>
        /// Token returned by initial call.
        /// Id[1..50]
        /// Example: 234uhfh78234hlasdfh8234e
        /// </summary>
        public string Token { get; set; }
    }
}
