using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class PaymentPageInitializeResponse : ResponseBase
    {
        /// <summary>
        /// Token for later referencing
        /// Example: 234uhfh78234hlasdfh8234e1234
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Expiration date / time of the generated token in ISO 8601 format in UTC. After this time, the token won’t be accepted for any further action.
        /// Example: 2011-07-14T19:43:37+01:00 
        /// </summary>
        public DateTime Expiration { get; set; }

        /// <summary>
        /// Redirecturl for the payment page transaction. Simply add this to a "Pay Now"-button or do an automatic redirect.
        /// Example: https://www.saferpay.com/vt2/api/PaymentPage/1234/12341234/z2p7a0plpgsd41m97wjvm5jza 
        /// </summary>
        public string RedirectUrl { get; set; }
    }
}
