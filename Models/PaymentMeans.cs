using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Information about the means of payment
    /// </summary>
    public class PaymentMeans
    {
        /// <summary>
        /// Brand information
        /// </summary>
        public Brand Brand { get; set; }

        /// <summary>
        /// Means of payment formatted / masked for display purposes
        /// Example: DisplayText
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// Name of Wallet, if the transaction was done by a wallet
        /// Example: MasterPass
        /// </summary>
        public string Wallet { get; set; }

        /// <summary>
        /// Card data
        /// </summary>
        public Card Card { get; set; }

        /// <summary>
        /// Bank account data for direct debit transactions.
        /// </summary>
        public BankAccount BankAccount { get; set; }

        /// <summary>
        /// Twint data
        /// </summary>
        public Twint Twint { get; set; }
    }
}
