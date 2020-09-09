using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class IssuerInstallments
    {
        /// <summary>
        /// A maximum number of 12 fixed installment plans
        /// If InstallmentPlans is present, CustomPlan must not be present
        /// </summary>
        public List<InstallmentPlan> InstallmentPlans { get; set; }

        /// <summary>
        /// An installment plan with customizable numbers of installments
        /// If CustomPlan is present, InstallmentPlans must not be present
        ///An installment plan with customizable numbers of installments
        /// </summary>
        public CustomInstallmentPlan CustomPlan { get; set; }

        /// <summary>
        /// Receipt Free Text
        /// </summary>
        public string ReceiptFreeText { get; set; }
    }
}
