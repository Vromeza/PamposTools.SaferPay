using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Optional. May be used to set specific options for some payment methods.
    /// </summary>
    public class PaymentMethodOptions
    {
        /// <summary>
        /// Optional. Options which only apply to Alipay.
        /// </summary>
        public Alipay Alipay { get; set; }

        /// <summary>
        /// Optional. Options which only apply to IDEAL.
        /// </summary>
        public Ideal Ideal { get; set; }
    }
}
