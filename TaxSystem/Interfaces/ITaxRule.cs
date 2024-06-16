using TaxSystem.Entities;

namespace TaxSystem.Interfaces;

public interface ITaxRule
{
    int CalcualteTaxPercentage(TaxPayer taxPayer, int currentPercentage);
}
