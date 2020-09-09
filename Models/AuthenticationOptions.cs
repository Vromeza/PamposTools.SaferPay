using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Strong Customer Authentication (exemptions, ...)
    /// </summary>
    public class AuthenticationOptions
    {
        /// <summary>
        /// Type of Exemption
        /// Possible values: LOW_VALUE, TRANSACTION_RISK_ANALYSIS.
        /// </summary>
        public string Exemption { get; set; }

        /// <summary>
        /// 3DS Secure challenge options
        /// Possible values: AVOID, FORCE.
        /// </summary>
        public string ThreeDsChallenge { get; set; }
    }
}
