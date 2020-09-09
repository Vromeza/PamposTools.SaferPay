using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class PaymentPageInitializeRequest : RequestBase
    {
        /// <summary>
        /// This parameter let you define your payment page config (PPConfig) by name. If this parameters is not set, your default PPConfig will be applied if available.
        /// When the PPConfig can't be found (e.g. wrong name), the Saferpay basic style will be applied to the payment page.
        /// 
        /// Id[1..20]
        /// Example: name of your payment page config(case-insensitive)
        /// </summary>
        public string ConfigSet { get; set; }

        /// <summary>
        /// Saferpay terminal id
        /// 
        /// Numeric[8..8]
        /// Example: 12345678
        /// </summary>
        public string TerminalId { get; set; }

        /// <summary>
        /// Information about the payment (amount, currency, ...)
        /// </summary>
        public Payment Payment { get; set; }

        /// <summary>
        /// Used to restrict the means of payment which are available to the payer for this transaction. If only one payment method id is set, the payment selection step will be skipped.
        /// Possible values: ALIPAY, AMEX, BANCONTACT, BONUS, DINERS, DIRECTDEBIT, EPRZELEWY, EPS, GIROPAY, IDEAL, INVOICE, JCB, MAESTRO, MASTERCARD, MYONE, PAYPAL, PAYDIREKT, POSTCARD, POSTFINANCE, SAFERPAYTEST, SOFORT, TWINT, UNIONPAY, VISA, VPAY, KLARNA.
        /// Example: ["VISA", "MASTERCARD"]
        /// </summary>
        public List<string> PaymentMethods { get; set; }

        /// <summary>
        /// Optional. May be used to set specific options for some payment methods.
        /// </summary>
        public PaymentMethodOptions PaymentMethodsOptions { get; set; }

        /// <summary>
        /// Strong Customer Authentication (exemptions, ...)
        /// </summary>
        public AuthenticationOptions Authentication { get; set; }

        /// <summary>
        /// Used to control if wallets should be enabled on the payment selection page and to go directly to the given wallet (if exactly one wallet is filled and PaymentMethods is not set).
        /// Possible values: MASTERPASS, APPLEPAY.
        /// Example: ["MASTERPASS"]
        /// </summary>
        public List<string> Wallets { get; set; }

        /// <summary>
        /// Information about the payer
        /// </summary>
        public Payer Payer { get; set; }

        /// <summary>
        /// If the given means of payment should be stored in Saferpay Secure Card Data storage (if applicable)
        /// </summary>
        public Alias RegisterAlias { get; set; }

        /// <summary>
        /// Urls which are to be used to redirect the payer back to the shop if the transaction requires some kind of browser redirection (3d-secure, dcc)
        /// These Urls are used by Saferpay to redirect the shopper back to the merchant shop.You may add query string parameters to identify your session, but please be aware that the shopper could modify these parameters inside the browser!
        /// The whole url including query string parameters should be as short as possible to prevent issues with specific browsers and must not exceed 2000 characters.
        /// Note: you should not add sensitive data to the query string, as its contents is plainly visible inside the browser and will be logged by our web servers.
        /// </summary>
        public ReturnUrls ReturnUrls { get; set; }

        /// <summary>
        /// Notification options
        /// </summary>
        public Notification Notification { get; set; }

        /// <summary>
        /// Styling options
        /// </summary>
        public Styling Styling { get; set; }

        /// <summary>
        /// Used to have the payer enter his billing address in the payment process.
        /// </summary>
        public AddressForm BillingAddressForm { get; set; }

        /// <summary>
        /// Used to have the payer enter his delivery address in the payment process.
        /// </summary>
        public AddressForm DeliveryAddressForm { get; set; }

        /// <summary>
        /// Options for card data entry form (if applicable)
        /// </summary>
        public CardForm CardForm { get; set; }

        /// <summary>
        /// Optional Condition for Authorization (only 3DSv2), to control, whether or not, transactions without LiabilityShift should be accepted. Important Note: This only filters out transactions, where the condition is conclusive before the authorization itself. It is possible, that LiabilityShift is rejected after the authorization. Please always check the ThreeDs container, within the authorization-response, to be 100% sure, if LiabilityShift applies, or not!
        /// Default: IF_ALLOWED_BY_SCHEME(empty)
        /// Possible values: WITH_LIABILITY_SHIFT, IF_ALLOWED_BY_SCHEME.
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// Optional order information
        /// </summary>
        public Order Order { get; set; }

        /// <summary>
        /// Optional risk factors
        /// </summary>
        public RiskFactors RiskFactors { get; set; }
    }
}
