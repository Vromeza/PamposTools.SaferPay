using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Information about the transaction
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Type of transaction. One of 'PAYMENT'
        /// Possible values: PAYMENT.
        /// Example: PAYMENT
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Current status of the transaction. One of 'AUTHORIZED','CANCELED', 'CAPTURED' or 'PENDING' (PENDING is only used for paydirekt at the moment)
        /// Possible values: AUTHORIZED, CANCELED, CAPTURED, PENDING.
        /// Example: AUTHORIZED
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Unique Saferpay transaction id. Used to reference the transaction in any further step.
        /// Example: K5OYS9Ad6Ex4rASU1IM1b3CEU8bb
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Unique Saferpay capture id.
        /// Available if the transaction was already captured(Status: CAPTURED).
        /// Must be stored for later reference(eg refund).
        /// Id[1..64]
        /// Example: ECthWpbv1SI6SAIdU2p6AIC1bppA
        /// </summary>
        public string CaptureId { get; set; }

        /// <summary>
        /// Date / time of the authorization
        /// Example: 2011-09-23T14:57:23.023+02.00 
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Amount (currency, value, etc.) that has been authorized.
        /// </summary>
        public Amount Amount { get; set; }

        /// <summary>
        /// OrderId given with request
        /// Id[1..80]
        /// Example: c52ad18472354511ab2c33b59e796901
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// Name of the acquirer
        /// Example: AcquirerName
        /// </summary>
        public string AcquirerName { get; set; }

        /// <summary>
        /// Reference id of the acquirer (if available)
        /// Example: AcquirerReference
        /// </summary>
        public string AcquirerReference { get; set; }

        /// <summary>
        /// Unique SIX transaction reference.
        /// Example: 0:0:3:K5OYS9Ad6Ex4rASU1IM1b3CEU8bb
        /// </summary>
        public string SixTransactionReference { get; set; }

        /// <summary>
        /// Approval id of the acquirer (if available)
        /// Example: AcquirerReference
        /// </summary>
        public string ApprovalCode { get; set; }

        /// <summary>
        /// Direct Debit information, if applicable
        /// Example: AcquirerReference
        /// </summary>
        public DirectDebitResponse DirectDebit { get; set; }

        /// <summary>
        /// Invoice information, if applicable
        /// </summary>
        public Invoice Invoice { get; set; }
    }
}
