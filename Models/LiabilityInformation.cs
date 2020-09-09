using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class LiabilityInformation
    {
        /// <summary>
        /// Is liability shifted for this transaction
        /// </summary>
        public bool LiabilityShift { get; set; }

        /// <summary>
        /// Indicates who takes the liability for the transaction
        /// </summary>
        public string LiableEntity { get; set; }

        /// <summary>
        /// Details about ThreeDs if applicable
        /// </summary>
        public ThreeDs ThreeDs { get; set; }
    }
}
