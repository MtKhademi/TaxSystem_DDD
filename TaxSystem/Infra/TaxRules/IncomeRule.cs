using TaxSystem.Entities;
using TaxSystem.Interfaces;

namespace TaxSystem.Infra.TaxRules
{
    internal class IncomeRule : ITaxRule
    {
        public TaxPayer CalcualteTaxPercentage(TaxPayer taxPayer, double currentPercentage)
        {
            int grossIncomeAmount = 40_000;

            if (taxPayer.GrossIncome < grossIncomeAmount) taxPayer.TaxedAmount = 0;
            else
            {
                taxPayer.TaxedAmount += (taxPayer.GrossIncome - grossIncomeAmount) * 0.1;
            }

            return taxPayer;
        }
    }
}
