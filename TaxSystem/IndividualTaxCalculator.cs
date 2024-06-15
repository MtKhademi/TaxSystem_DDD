using TaxSystem.Entities;

namespace TaxSystem;

public class IndividualTaxCalculator
{
    public int CalculatorTaxPercentage(TaxPayer taxPayer)
    {

        if (!taxPayer.TaxCitizen)
            throw new InvalidOperationException("No tax cirizen for NON-TAX residents");



        return 0;
    }
}
