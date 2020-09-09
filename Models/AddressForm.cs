using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class AddressForm
    {
        /// <summary>
        /// Specifies whether to show the address form or not.
        /// </summary>
        public bool Display { get; set; }

        /// <summary>
        /// List of fields which the payer must enter to proceed with the payment.
        /// Possible values: CITY, COMPANY, COUNTRY, EMAIL, FIRSTNAME, LASTNAME, PHONE, SALUTATION, STATE, STREET, ZIP.
        /// Example: ["FIRSTNAME", "LASTNAME", "PHONE"]
        /// </summary>
        public List<string> MandatoryFields { get; set; }
    }
}
