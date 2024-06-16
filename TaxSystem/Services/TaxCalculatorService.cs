using TaxSystem.Entities;
using TaxSystem.Infra;
using TaxSystem.Interfaces;

namespace TaxSystem.Services;

public class TaxCalculatorService
{
    public TaxPayer CalclutorTaxPercentage(TaxPayer taxPayer)
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
