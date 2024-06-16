using TaxSystem.Entities;
using TaxSystem.Infra;
using TaxSystem.Interfaces;

namespace TaxSystem.services;

public class TaxCalculatorService
{
    public int CalclutorTaxPercentage(TaxPayer taxPayer)
    {

        var ruleType = typeof(ITaxRule);
        IEnumerable<ITaxRule> rules =
            GetType().Assembly.GetTypes()
            .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
            .Select(r => Activator.CreateInstance(r) as ITaxRule);

        var engine = new TaxRuleEngine(rules);

        return engine.CalculateTaxPercentage(taxPayer);


    }
}
