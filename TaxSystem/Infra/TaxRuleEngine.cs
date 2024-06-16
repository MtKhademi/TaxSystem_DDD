using TaxSystem.Entities;
using TaxSystem.Interfaces;

namespace TaxSystem.Infra;

public class TaxRuleEngine
{
    List<ITaxRule> _rules = new List<ITaxRule>();
    public TaxRuleEngine(IEnumerable<ITaxRule> rules)
    {
        _rules.AddRange(rules);
    }

    public TaxPayer CalculateTaxPercentage(TaxPayer taxPayer)
    {
        foreach (var rule in _rules)
        {
            taxPayer.TaxedAmount += rule.CalcualteTaxPercentage(taxPayer, taxPayer.TaxedAmount).TaxedAmount;
        }

        return taxPayer;
    }

}
