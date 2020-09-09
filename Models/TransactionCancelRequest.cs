using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class TransactionCancelRequest : RequestBase
    {
        /// <summary>
        /// Reference to transaction to be canceled.
        /// Exactly one element must be set.
        /// </summary>
        public TransactionReference TransactionReference { get; set; }
    }
}
