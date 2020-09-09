using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class Notification
    {
        /// <summary>
        /// Email addresses to which a confirmation email will be sent to the merchants after successful authorizations.
        /// A maximum of 10 email addresses is allowed.
        /// Example: ["merchant1@saferpay.com", "merchant2@saferpay.com"]
        /// </summary>
        public List<string> MerchantEmails { get; set; }

        /// <summary>
        /// Email address to which a confirmation email will be sent to the payer after successful authorizations.
        /// Example: payer @saferpay.com
        /// </summary>
        public string PayerEmail { get; set; }

        /// <summary>
        /// Url to which Saferpay will send the asynchronous confirmation for the transaction. Supported schemes are http and https. You also have to make sure to support the GET-method.
        /// Example: https://merchanthost/notify 
        /// </summary>
        public string NotifyUrl { get; set; }
    }
}
