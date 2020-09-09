using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Optional order information
    /// </summary>
    public class Order
    {
        public List<OrderItem> Items { get; set; }
    }
}
