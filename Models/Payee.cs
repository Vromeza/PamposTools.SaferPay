using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Information about the payee, eg billpay, who is responsible for collecting the bill
    /// </summary>
    public class Payee
    {
        /// <summary>
        /// International Bank Account Number in electronical format (without spaces).
        /// AlphaNumeric[1..50]
        /// Example: DE12500105170648489890
        /// </summary>
        public string IBAN { get; set; }

        /// <summary>
        /// Name of the account holder.
        /// Iso885915[1..50]
        /// Example: John Doe
        /// </summary>
        public string HolderName { get; set; }

        /// <summary>
        /// Bank Identifier Code without spaces.
        /// AlphaNumeric[8..11]
        /// Example: INGDDEFFXXX
        /// </summary>
        public string BIC { get; set; }

        /// <summary>
        /// Name of the Bank.
        /// </summary>
        public string BankName { get; set; }
    }
}
