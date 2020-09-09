﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class Payment
    {
        /// <summary>
        /// Amount data (currency, value, etc.)
        /// </summary>
        public Amount Amount { get; set; }

        /// <summary>
        /// Unambiguous order identifier defined by the merchant / shop. This identifier might be used as reference later on.
        /// Id[1..80]
        /// Example: c52ad18472354511ab2c33b59e796901
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// Text which will be printed on payer's debit note. Supported by SIX Acquiring. No guarantee that it will show up on the payer's debit note, because his bank has to support it too.
        /// Please note that maximum allowed characters are rarely supported.It's usually around 10-12.
        /// Utf8[1..50]
        /// Example: Payernote
        /// </summary>
        public string PayerNote { get; set; }

        /// <summary>
        /// A human readable description provided by the merchant that will be displayed in Payment Page.
        /// Utf8[1..1000]
        /// Example: Description of payment
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Mandate reference of the payment. Needed for German direct debits (ELV) only. The value has to be unique.
        /// Id[1..35]
        /// Example: MandateId
        /// </summary>
        public string MandateId { get; set; }

        /// <summary>
        /// Specific payment options
        /// </summary>
        public PaymentOptions Options { get; set; }

        /// <summary>
        /// Recurring options – cannot be combined with Installment.
        /// </summary>
        public RecurringOptions Recurring { get; set; }

        /// <summary>
        /// Installment options – cannot be combined with Recurring.
        /// </summary>
        public RecurringOptions Installment { get; set; }
    }
}
