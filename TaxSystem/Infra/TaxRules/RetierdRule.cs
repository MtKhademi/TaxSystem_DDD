using TaxSystem.Entities;
using TaxSystem.Interfaces;

namespace TaxSystem.Infra.TaxRules;

public class RetierdRule : ITaxRule
{
    public TaxPayer CalcualteTaxPercentage(TaxPayer taxPayer, double currentPercentage)
    {
        if (taxPayer.IsRetierd) taxPayer.TaxedAmount = 0;
        else taxPayer.TaxedAmount = 1;
        return taxPayer;
    }
}
