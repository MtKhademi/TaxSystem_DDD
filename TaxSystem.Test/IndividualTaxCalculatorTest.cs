using FluentAssertions;
using TaxSystem.Entities;

namespace TaxSystem.Test
{
    public class UnitTest1
    {
        [Fact]
        public void When_nonTaxResident_Expect_get_exception_not_resident()
        {
            // arrange
            TaxPayer payer = new TaxPayer { TaxCitizen = false };
            IndividualTaxCalculator calculaot = new IndividualTaxCalculator();
            string exceptionMessage = "No tax cirizen for NON-TAX residents";

            // act
            var act = () => calculaot.CalculatorTaxPercentage(payer);

            // assert
            act.Should().Throw<InvalidOperationException>()
                .WithMessage(exceptionMessage);

        }


        [Fact]
        public void When_HasDisability_Expect_get_zero_for_taxPercentage()
        {
            // arrange
            TaxPayer payer = new TaxPayer { TaxCitizen = true, HasDisability = true };
            IndividualTaxCalculator calculaot = new IndividualTaxCalculator();

            // act
            var result = calculaot.CalculatorTaxPercentage(payer);

            // assert
            result.Should().Be(0);

        }
    }
}