using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class TransactionReference
    {
        /// <summary>
        /// Id of the referenced transaction.
        /// AlphaNumeric[1..64]
        /// Example: 723n4MAjMdhjSAhAKEUdA8jtl9jb
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// Unambiguous OrderId of the referenced transaction.
        /// Id[1..80]
        /// Example: c52ad18472354511ab2c33b59e796901
        /// </summary>
        public string OrderId { get; set; }
    }
}
