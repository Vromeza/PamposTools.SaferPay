using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class CardForm
    {
        /// <summary>
        /// This parameter lets you customize the holder name field on the card entry form. Per default, a mandatory holder name field is shown.
        /// Possible values: NONE, MANDATORY.
        /// Example: MANDATORY
        /// </summary>
        public string HolderName { get; set; }
    }
}
