using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Direct Debit information, if applicable
    /// </summary>
    public class DirectDebitResponse
    {
        /// <summary>
        /// The unique Mandate reference, required for german direct debit payments.
        /// </summary>
        public string MandateId { get; set; }

        /// <summary>
        /// Creditor id, required for german direct debit payments.
        /// </summary>
        public string CreditorId { get; set; }
    }
}
