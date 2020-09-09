using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class MarketplaceCaptureOptions
    {
        /// <summary>
        /// The id of the marketplace submerchant on whose behalf the capture or refund capture is being made.
        /// Id[1..15]
        /// </summary>
        public string SupermerchantId { get; set; }

        /// <summary>
        /// The marketplace fee that will be charged from the marketplace to the submerchant.
        /// The properties Fee and FeeRefund cannot be used simultaneously.
        /// </summary>
        public Amount Fee { get; set; }

        /// <summary>
        /// The fee amount that will be refunded from the marketplace to the submerchant.
        /// The properties Fee and FeeRefund cannot be used simultaneously.
        /// </summary>
        public Amount FeeRefund { get; set; }
    }
}
