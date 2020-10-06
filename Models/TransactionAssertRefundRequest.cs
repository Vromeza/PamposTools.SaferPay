using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class TransactionAssertRefundRequest : RequestBase
    {
        /// <summary>
        /// Reference to authorization.
        /// </summary>
        public TransactionReference TransactionReference { get; set; }
    }
}
