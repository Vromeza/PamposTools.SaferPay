using System.Collections;
using System.Collections.Generic;

namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Optional pending notification capture options for Paydirekt transactions.
    /// </summary>
    public class PendingNotification
    {
        /// <summary>
        /// Email addresses to which a confirmation email will be sent to the merchants after successful authorizations. 
        /// A maximum of 10 email addresses is allowed.
        /// </summary>
        public ICollection<string> MerchantEmails { get; set; }

        /// <summary>
        /// Url which is called by Saferpay if an action could not be completed synchronously and was reported with a ‘pending’ state (eg CAPTURE_PENDING).
        /// Up until now, this is only applicable for Paydirekt transactions.
        /// </summary>
        public string NotifyUrl { get; set; }
    }
}
