namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Information about the refund (amount, currency, ...)
    /// </summary>
    public class Refund
    {
        /// <summary>
        /// Amount data
        /// </summary>
        public Amount Amount { get; set; }

        /// <summary>
        /// Reference defined by the merchant.
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// The date by which the invoice needs to be settled
        /// </summary>
        public string Description { get; set; }
    }
}
