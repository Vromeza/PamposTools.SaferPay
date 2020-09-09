using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class PaymentOptions
    {
        /// <summary>
        /// Indicates the desired transaction type. When set to true the transaction is processed as a pre-authorization otherwise as a final authorization. 
        /// Please note that not all payment methods support both options and the effective transaction type is determined by Saferpay.
        /// </summary>
        public bool PreAuth { get; set; }
    }
}
