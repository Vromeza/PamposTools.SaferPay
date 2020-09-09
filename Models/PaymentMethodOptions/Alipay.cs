using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Optional. Options which only apply to Alipay.
    /// </summary>
    public class Alipay
    {
        /// <summary>
        /// Preselect the Alipay local wallet. May only be used in conjunction with special Alipay integrations.
        /// Iso885915[1..64]
        /// Example: "TNG" 
        /// </summary>
        public string LocalWallet { get; set; }
    }
}
