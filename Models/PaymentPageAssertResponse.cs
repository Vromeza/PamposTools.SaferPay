﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class PaymentPageAssertResponse : ResponseBase
    {
        /// <summary>
        /// Information about the transaction
        /// </summary>
        public Transaction Transaction { get; set; }

        /// <summary>
        /// Information about the means of payment
        /// </summary>
        public PaymentMeans PaymentMeans { get; set; }

        /// <summary>
        /// Information about the payer / card holder
        /// </summary>
        public Payer Payer { get; set; }

        /// <summary>
        /// Information about the SCD registration outcome
        /// </summary>
        public RegistrationResult RegistrationResult { get; set; }

        /// <summary>
        /// LiabilityShift information, replaces ThreeDs Info from api version 1.8
        /// </summary>
        public LiabilityInformation Liability { get; set; }

        /// <summary>
        /// Dcc information, if applicable
        /// </summary>
        public DccInformation Dcc { get; set; }

        /// <summary>
        /// Mastercard card issuer installment payment options, if applicable
        /// </summary>
        public IssuerInstallments MasterCardIssuerInstallments { get; set; }
    }
}
