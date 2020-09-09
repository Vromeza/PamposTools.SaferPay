using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class TransactionCaptureRequest : RequestBase
    {
        /// <summary>
        /// Reference to authorization.
        /// Exactly one element must be set.
        /// </summary>
        public TransactionReference TransactionReference { get; set; }

        /// <summary>
        /// Currency must match the original transaction currency (request will be declined if currency does not match)
        /// </summary>
        public Amount Amount { get; set; }

        /// <summary>
        /// Optional Billpay specific options.
        /// </summary>
        public BillPayOptions BillPay { get; set; }

        /// <summary>
        /// Optional pending notification capture options for Paydirekt transactions.
        /// </summary>
        public PendingNotificationCaptureOptions PendingNotification { get; set; }

        /// <summary>
        /// Optional Marketplace capture parameters.
        /// </summary>
        public MarketplaceCaptureOptions Marketplace { get; set; }
    }
}
