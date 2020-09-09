using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public abstract class RequestBase
    {
        /// <summary>
        /// General information about the request.
        /// </summary>
        public RequestHeader RequestHeader { get; set; }
    }
}
