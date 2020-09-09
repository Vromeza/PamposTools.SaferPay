using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class ErrorResponse
    {
        public ResponseHeader ResponseHeader { get; set; }
        public string Behavior { get; set; }
        public string ErrorName { get; set; }
        public string ErrorMessage { get; set; }
        public string TransactionId { get; set; }
        public List<string> ErrorDetail { get; set; }
        public string ProcessorName { get; set; }
        public string ProcessorResult { get; set; }
        public string ProcessorMessage { get; set; }
    }
}
