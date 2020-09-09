using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class InstallmentPlan
    {
        /// <summary>
        /// Number of Installments. Valid values are 2–99.
        /// Range: inclusive between 2 and 99
        /// </summary>
        public int NumberOfInstallments { get; set; }

        /// <summary>
        /// Interest rate in hundredth of a percent. e.g. value 125 means 1.25%.
        /// Valid values are 0-99999
        /// </summary>
        public string InterestRate { get; set; }

        /// <summary>
        /// Installment Fee
        /// </summary>
        public Amount InstallmentFee { get; set; }

        /// <summary>
        /// Annual percentage rate in hundredth of a percent. e.g. value 125 means 1.25%.
        /// Valid values are 0-99999
        /// </summary>
        public string AnnualPercentageRate { get; set; }

        /// <summary>
        /// First Installment Amount
        /// </summary>
        public Amount FirstInstallmentAmount { get; set; }

        /// <summary>
        /// Subsequent Installment Amount
        /// </summary>
        public Amount SubsequentInstallmentAmount { get; set; }

        /// <summary>
        /// Total Amount Due
        /// </summary>
        public Amount TotalAmountDue { get; set; }
    }
}
