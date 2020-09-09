using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Information about the SCD registration outcome
    /// </summary>
    public class RegistrationResult
    {
        /// <summary>
        /// Result of registration
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// If Success is 'true', information about the alias
        /// </summary>
        public Alias Alias { get; set; }

        /// <summary>
        /// If Success is 'false', information on why the registration failed
        /// </summary>
        public Error Error { get; set; }

        /// <summary>
        /// contains information whether the alias is saved with the strong authentication details or not.
        /// </summary>
        public AuthenticationResult AuthenticationResult { get; set; }
    }
}
