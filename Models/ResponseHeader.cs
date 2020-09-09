using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class ResponseHeader
    {
        /// <summary>
        /// Version number of the interface specification.
        /// Possible values: 1.0, 1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 1.7, 1.8, 1.9, 1.10, 1.11, 1.12, 1.13, 1.14, 1.15, 1.16, 1.17, 1.18
        /// Example: 1.18 
        /// </summary>
        public string SpecVersion { get; set; }

        /// <summary>
        /// RequestId of the original request header
        /// Id[1..50]
        /// Example: 33e8af17-35c1-4165-a343-c1c86a320f3b
        /// </summary>
        public string RequestId { get; set; }
    }
}
