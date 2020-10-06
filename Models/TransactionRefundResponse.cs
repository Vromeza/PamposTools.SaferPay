using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class TransactionRefundResponse : ResponseBase
    {
        /// <summary>
        /// Information about the transaction
        /// </summary>
        public Transaction Transaction { get; set; }

        /// <summary>
        /// Information about the means of payment
        /// </summary>
        public PaymentMeans PaymentMeans { get; set; }

        /// <summary>
        /// Dcc information, if applicable
        /// </summary>
        public DccInformation Dcc { get; set; }
    }
}
