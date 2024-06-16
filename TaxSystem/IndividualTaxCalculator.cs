using TaxSystem.Entities;

namespace TaxSystem;

public interface ITaxRule
{
    int CalcualteTaxPercentage(TaxPayer taxPayer, int currentPercentage);
}

public class RetierdRule : ITaxRule
{
    public int CalcualteTaxPercentage(TaxPayer taxPayer, int currentPercentage)
    {
        if (taxPayer.IsRetierd)
            return 0;
        return 1;
    }
}

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


public class TaxCalculator
{
    public int CalclutorTaxPercentage(TaxPayer taxPayer)
    {

        var ruleType = typeof(ITaxRule);
        IEnumerable<ITaxRule> rules =
            this.GetType().Assembly.GetTypes()
            .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
            .Select(r => Activator.CreateInstance(r) as ITaxRule);

        var engine = new TaxRuleEngine(rules);

        return engine.CalculateTaxPercentage(taxPayer);


    }
}

public class IndividualTaxCalculator
{
    public int CalculatorTaxPercentage(TaxPayer taxPayer)
    {

        if (!taxPayer.TaxCitizen)
            throw new InvalidOperationException("No tax cirizen for NON-TAX residents");
        else
        {
            if (taxPayer.HasDisability)
            {
                return 0;
            }
            else
            {
                if (taxPayer.IsMuslim)
                {
                    if (taxPayer.ZakatPaid > 10_000 && taxPayer.ZakatPaid < 50_000)
                    {
                        return 5;
                    }
                    else if (taxPayer.ZakatPaid > 50_000 && taxPayer.ZakatPaid < 100_000)
                    {
                        return 5;
                    }
                    else if (taxPayer.ZakatPaid > 100_000 && taxPayer.ZakatPaid < 500_000)
                    {
                        return 5;
                    }
                }

                if (taxPayer.IsRetierd)
                    return 1;

            }
        }



        return 0;
    }
}
