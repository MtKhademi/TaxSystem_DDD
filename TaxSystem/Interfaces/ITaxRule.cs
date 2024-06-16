using TaxSystem.Entities;

namespace TaxSystem.Interfaces;

public interface ITaxRule
{
    TaxPayer CalcualteTaxPercentage(TaxPayer taxPayer, double currentPercentage);
}
