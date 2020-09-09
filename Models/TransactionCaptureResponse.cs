using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class TransactionCaptureResponse : ResponseBase
    {
        /// <summary>
        /// CaptureId of the created capture. Must be stored for later reference (eg refund).
        /// Id[1..64]
        /// Example: ECthWpbv1SI6SAIdU2p6AIC1bppA_c
        /// </summary>
        public string CaptureId { get; set; }

        /// <summary>
        /// Current status of the capture. (PENDING is only used for paydirekt at the moment)
        /// Possible values: PENDING, CAPTURED.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Date and time of capture. Not set if the capture state is pending.
        /// Example: 2014-04-25T08:33:44.159+01:00 
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Optional infos for invoice based payments.
        /// </summary>
        public Invoice Invoice { get; set; }
    }
}
