using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class BillPayOptions
    {
        /// <summary>
        /// Number of days to delay the due date of the invoice / direct debit (see billpay for specifics)
        /// Example: 10 
        /// </summary>
        public int DelayInDays { get; set; }
    }
}
