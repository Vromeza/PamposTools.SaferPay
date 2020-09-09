using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Information about the payer
    /// </summary>
    public class Payer
    {
        /// <summary>
        /// IPv4 address of the card holder / payer if available. Dotted quad notation.
        /// Example: 111.111.111.111 
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Language to force Saferpay to display something to the payer in a certain language. Per default, Saferpay will determine the language, using the payers browser agent.
        /// Code-List:
        /// de - German
        /// de-ch - Swiss German
        /// en - English
        /// fr - French
        /// da - Danish
        /// cs - Czech
        /// es - Spanish
        /// et - Estonian
        /// hr - Croatian
        /// it - Italian
        /// hu - Hungarian
        /// lv - Latvian
        /// lt - Lithuanian
        /// nl - Dutch
        /// nn - Norwegian
        /// pl - Polish
        /// pt - Portuguese
        /// ru - Russian
        /// ro - Romanian
        /// sk - Slovak
        /// sl - Slovenian
        /// fi - Finnish
        /// sv - Swedish
        /// tr - Turkish
        /// el - Greek
        /// ja - Japanese
        /// zh - Chinese
        /// Example: de
        /// </summary>
        public string LanguageCode { get; set; }

        /// <summary>
        /// Information on the payers delivery address
        /// </summary>
        public PayerAddress DeliveryAddress { get; set; }

        /// <summary>
        /// Information on the payers billing address
        /// </summary>
        public PayerAddress BillingAddress { get; set; }

        /// <summary>
        /// Payer identifier defined by the merchant / shop. Use a unique id for your customer (a UUID is highly recommended).
        /// For GDPR reasons, we don't recommend using an id which contains personal data (eg. no name).
        /// Id[1..50]
        /// </summary>
        public string Id { get; set; }
    }
}
