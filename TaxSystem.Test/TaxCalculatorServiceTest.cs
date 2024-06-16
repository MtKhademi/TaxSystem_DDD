using FluentAssertions;
using TaxSystem.Entities;
using TaxSystem.Services;

namespace TaxSystem.Test;

public class TaxCalculatorServiceTest
{
    private TaxCalculatorService _taxCalculatorService = new TaxCalculatorService();

    [Fact]
    public void When_person_is_sinel_Expect_get_currect_taxPercentage()
    {
        //Arrange
        TaxPayer payer = new TaxPayer
        {
            GrossIncome = 300_000,
            IsSingle = true,
            HasBusiness = false,
            HealthInsuranceAnnualPremium = 300,
            IsResidentOrCitizen = true
        };

        //ACT
        var result = _taxCalculatorService.CalclutorTaxPercentage(payer);

        //ASSERTION
        result.TaxedAmount.Should().Be(78000.0);

    }
}