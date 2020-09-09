using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Recurring/Installment options – cannot be combined with Installment.
    /// </summary>
    public class RecurringOptions
    {
        /// <summary>
        /// If set to true, the authorization may later be referenced for recurring followup transactions.
        /// </summary>
        public bool Initial { get; set; }
    }
}
