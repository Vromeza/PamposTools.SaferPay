using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Optional. Options which only apply to IDEAL
    /// </summary>
    public class Ideal
    {
        /// <summary>
        /// Preselect the iDEAL issuer. If specified together with PaymentMethods preselection of iDEAL,
        /// the user is redirected directly to the issuer bank.
        /// If the IssuerId is set, it is mandatory to use iDEAL in PaymentMethods.
        /// </summary>
        public string IssuerId { get; set; }
    }
}
