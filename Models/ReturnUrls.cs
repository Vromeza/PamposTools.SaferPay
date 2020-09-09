using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class ReturnUrls
    {
        /// <summary>
        /// Return url for successful transaction
        /// Example: https://merchanthost/success 
        /// </summary>
        public string Success { get; set; }

        /// <summary>
        /// Return url for failed transaction
        /// Example: https://merchanthost/fail 
        /// </summary>
        public string Fail { get; set; }

        /// <summary>
        /// Return url for transaction aborted by the payer.
        /// Example: https://merchanthost/abort 
        /// </summary>
        public string Abort { get; set; }
    }
}
