using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class Brand
    {
        /// <summary>
        /// alphanumeric id of the payment method / brand
        /// Possible values: ALIPAY, AMEX, BANCONTACT, BONUS, DINERS, DIRECTDEBIT, EPRZELEWY, EPS, GIROPAY, IDEAL, INVOICE, JCB, MAESTRO, MASTERCARD, MYONE, PAYPAL, PAYDIREKT, POSTCARD, POSTFINANCE, SAFERPAYTEST, SOFORT, TWINT, UNIONPAY, VISA, VPAY, KLARNA.
        /// </summary>
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Name of the Brand (Visa, Mastercard, an so on – might change over time, only use for display, never for parsing). Only use it for display, never for parsing and/or mapping! Use PaymentMethod instead.
        /// Example: SaferpayTestCard
        /// </summary>
        public string Name { get; set; }
    }
}
