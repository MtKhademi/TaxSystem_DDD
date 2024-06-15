using TaxSystem.Entities;

namespace TaxSystem;

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
                    if(taxPayer.ZakatPaid>10_000 && taxPayer.ZakatPaid < 50_000)
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
