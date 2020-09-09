using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class RiskFactors
    {
        /// <summary>
        /// Delivery method
        /// Possible values: EMAIL, SHOP, HOMEDELIVERY, PICKUP, HQ.
        /// </summary>
        public string DeliveryType { get; set; }

        /// <summary>
        /// Date and Time (ISO 8601) when user account was created
        /// Example: 2018-05-25T18:12:43Z
        /// 2018-05-25T19:12:43+01:00 
        /// </summary>
        public DateTime AccountCreationDate { get; set; }

        /// <summary>
        /// Date and Time (ISO 8601) when the account password was changed last time
        /// Example: 2018-05-25T18:12:43Z
        /// 2018-05-25T19:12:43+01:00 
        /// </summary>
        public DateTime PasswordLastChangeDate { get; set; }
    }
}
