namespace PamposTools.SaferPay.Models
{
    /// <summary>
    /// Reference to the capture you want to refund.
    /// </summary>
    public class CaptureReference
    {
        /// <summary>
        /// Id of the referenced capture.
        /// </summary>
        public string CaptureId { get; set; }

        /// <summary>
        /// Id of the referenced transaction. This should only be used if you don't have the CaptureId of the referenced Capture (probably, because it was performed with an older SpecVersion)
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// Unambiguous OrderId of the referenced transaction.
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// OrderPartId of the referenced capture if a partial capture should be referenced and the CaptureId/TransactionId of the partial capture is not available.
        /// </summary>
        public string OrderPartId { get; set; }
    }
}
