using TaxSystem.Entities;
using TaxSystem.Interfaces;

namespace TaxSystem.Infra.TaxRules
{
    internal class SingleRule : ITaxRule
    {
        public TaxPayer CalcualteTaxPercentage(TaxPayer taxPayer, double currentPercentage)
        {
            if (taxPayer.IsSingle)
                taxPayer.TaxedAmount += (taxPayer.GrossIncome - 40_000) * 0.1;

            return taxPayer;
        }
    }
}
