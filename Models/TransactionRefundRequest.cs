using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class TransactionRefundRequest : RequestBase
    {
        /// <summary>
        /// Information about the refund (amount, currency, ...)
        /// </summary>
        public Refund Refund { get; set; }

        /// <summary>
        /// Reference to the capture you want to refund.
        /// </summary>
        public CaptureReference CaptureReference { get; set; }

        /// <summary>
        /// Optional pending notification capture options for Paydirekt transactions.
        /// </summary>
        public PendingNotification PendingNotification { get; set; }
    }
}
