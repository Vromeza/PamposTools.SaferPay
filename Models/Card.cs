using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Card data
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Masked card number
        /// Example: 912345xxxxxx1234
        /// </summary>
        public string MaskedNumber { get; set; }

        /// <summary>
        /// Year of expiration
        /// Example: 2015 
        /// </summary>
        public int ExpYear { get; set; }

        /// <summary>
        /// Month of expiration (eg 9 for September)
        /// Example: 9 
        /// </summary>
        public int ExpMonth { get; set; }

        /// <summary>
        /// Name of the card holder (if known)
        /// Example: John Doe
        /// </summary>
        public string HolderName { get; set; }

        /// <summary>
        /// The Segment of card holder. Only returned for Alias/AssertInsert, Alias/InsertDirect and Alias/Update calls if available.
        /// Possible values: UNSPECIFIED, CONSUMER, CORPORATE, CORPORATE_AND_CONSUMER.
        /// Example: CORPORATE
        /// </summary>
        public string HolderSegment { get; set; }

        /// <summary>
        /// ISO 2-letter country code of the card origin (if available)
        /// Example: CH
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// The HashValue, if the hash generation is configured for the customer.
        /// </summary>
        public string HashValue { get; set; }
    }
}
