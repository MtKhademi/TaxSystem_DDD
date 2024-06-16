using TaxSystem.Entities;
using TaxSystem.Interfaces;

namespace TaxSystem.Infra.TaxRules;

public class RetierdRule : ITaxRule
{
    public int CalcualteTaxPercentage(TaxPayer taxPayer, int currentPercentage)
    {
        if (taxPayer.IsRetierd)
            return 0;
        return 1;
    }
}
