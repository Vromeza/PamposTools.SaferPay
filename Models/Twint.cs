using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class Twint
    {
        /// <summary>
        /// Twint token expiry date
        /// Example: 2019-11-08T12:29:37.000+01:00 
        /// </summary>
        public DateTime CertificateExpirationDate { get; set; }
    }
}
