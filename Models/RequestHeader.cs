﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// General information about the request.
    /// </summary>
    public class RequestHeader
    {
        /// <summary>
        /// Version number of the interface specification. For new implementations, the newest Version should be used.
        /// 
        /// Possible values: 1.0, 1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 1.7, 1.8, 1.9, 1.10, 1.11, 1.12, 1.13, 1.14, 1.15, 1.16, 1.17, 1.18
        /// Example: 1.18
        /// 
        /// MANDATORY
        /// </summary>
        public string SpecVersion { get; set; }

        /// <summary>
        /// Saferpay customer id. Part of the Saferpay AccountID, which has the following format: 123123-12345678. The first Value is your CustomerID.
        /// 
        /// Numeric[1..8]
        /// Example: 123123
        /// 
        /// MANDATORY
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Id generated by merchant system, for debugging purposes. Should be unique for each new request.
        /// If a request is retried due to an error, use the same request id. In this case, the RetryIndicator should be increased instead, to indicate a subsequent attempt.
        /// 
        /// Id[1..50]
        /// Example: 33e8af17-35c1-4165-a343-c1c86a320f3b
        /// 
        /// MANDATORY
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// 0 if this specific request is attempted for the first time, >=1 if it is a retry.
        /// 
        /// Range: inclusive between 0 and 9
        /// Example: 0
        /// 
        /// MANDATORY
        /// </summary>
        public int RetryIndicator { get; set; }

        /// <summary>
        /// Information about the caller (merchant host)
        /// </summary>
        public ClientInfo ClientInfo { get; set; }
    }
}
