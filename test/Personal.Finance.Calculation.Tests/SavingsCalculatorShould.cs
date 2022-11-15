using FluentAssertions;

namespace Personal.Finance.Calculation.Tests
{
    public class SavingsCalculatorShould
    {
        [Theory]
        [InlineData(100, 10)]
        [InlineData(1000, 30)]
        [InlineData(10000, 50)]
        public void CalculatePercentageOfGrossIncome(decimal grossIncome, int percentage)
        {
            var savingsCalculator = new SavingsCalculator();

            var result = savingsCalculator.CalculateSavings(grossIncome, percentage);

            result.Should().Be(grossIncome*(percentage/100));
        }
    }
}
