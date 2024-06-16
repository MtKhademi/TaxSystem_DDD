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

    public int CalculateTaxPercentage(TaxPayer taxPayer)
    {
        int taxPercentage = 0;
        foreach (var rule in _rules)
        {
            taxPercentage = Math.Max(taxPercentage, rule.CalcualteTaxPercentage(taxPayer, taxPercentage));
        }

        return taxPercentage;
    }

}
