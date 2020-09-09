using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class OrderItem
    {
        /// <summary>
        /// Order item type
        /// Possible values: DIGITAL, PHYSICAL, SERVICE, GIFTCARD, DISCOUNT, SHIPPINGFEE, SALESTAX, SURCHARGE.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Product id
        /// Utf8[1..100]
        /// Example: C123192
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Product variant id
        /// Utf8[1..100]
        /// Example: C123192-red
        /// </summary>
        public string VariantId { get; set; }

        /// <summary>
        /// Product name
        /// Utf8[1..200]
        /// Example: red swiss army knife
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Category name
        /// Utf8[1..100]
        /// Example: knifes
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Product description
        /// Utf8[1..200]
        /// Example: The well known swiss army knife
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The quantity of the order item
        /// Example: 3 
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Price per single item in minor unit (CHF 2.00 ⇒ Value=200). Only Integer values will be accepted!
        /// Example: 200 
        /// </summary>
        public string UnitPrice { get; set; }

        /// <summary>
        /// Flag, which indicates that the order item is a pre order. Per default, it is not a pre order.
        /// Example: true 
        /// </summary>
        public bool IsPreOrder { get; set; }

        /// <summary>
        /// Tax rate of the item price in hundredth of a percent. e.g. value 125 means 1.25%
        /// Valid values are 0-99999
        /// Range: inclusive between 0 and 99999
        /// Example: 2100 
        /// </summary>
        public string TaxRate { get; set; }

        /// <summary>
        /// Tax amount which is included in the item price
        /// Example: 42 
        /// </summary>
        public string TaxAmount { get; set; }

        /// <summary>
        /// Discount amount including tax
        /// Example: 10 
        /// </summary>
        public string DiscountAmount { get; set; }
    }
}
