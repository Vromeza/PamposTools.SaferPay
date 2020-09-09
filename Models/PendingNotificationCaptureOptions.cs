using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Optional pending notification capture options for Paydirekt transactions.
    /// </summary>
    public class PendingNotificationCaptureOptions
    {
        /// <summary>
        /// Email addresses to which a confirmation email will be sent to the merchants after successful authorizations.
        /// A maximum of 10 email addresses is allowed.
        /// Example: ["merchant1@saferpay.com", "merchant2@saferpay.com"]
        /// </summary>
        public List<string> MerchantEmails { get; set; }

        /// <summary>
        /// Url which is called by Saferpay if an action could not be completed synchronously and was reported with a ‘pending’ state (eg CAPTURE_PENDING). Up until now, this is only applicable for Paydirekt transactions.
        /// Example: https://merchanthost/pendingnotify 
        /// </summary>
        public string NotifyUrl { get; set; }
    }
}
