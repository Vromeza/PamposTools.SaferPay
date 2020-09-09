using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class BankAccount
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

        /// <summary>
        /// ISO 2-letter country code of the IBAN origin (if available)
        /// Example: CH
        /// </summary>
        public string CountryCode { get; set; }
    }
}
