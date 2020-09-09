using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class TransactionCancelResponse : ResponseBase
    {
        /// <summary>
        /// Id of the referenced transaction.
        /// Example: qiuwerhfi23h4189asdhflk23489
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// OrderId of the referenced transaction. If present.
        /// Example: c52ad18472354511ab2c33b59e796901
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// Date and time of cancel.
        /// Example: 2014-04-25T08:33:44.159+01:00 
        /// </summary>
        public DateTime Date { get; set; }
    }
}
