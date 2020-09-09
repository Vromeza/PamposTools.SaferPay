using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Information about the caller (merchant host)
    /// </summary>
    public class ClientInfo
    {
        /// <summary>
        /// Name and version of the shop software
        /// Iso885915[1..100]
        /// Example: My Shop
        /// </summary>
        public string ShopInfo { get; set; }

        /// <summary>
        /// Information on the operating system
        /// Iso885915[1..100]
        /// Example: Windows Server 2013 
        /// </summary>
        public string OsInfo { get; set; }
    }
}
