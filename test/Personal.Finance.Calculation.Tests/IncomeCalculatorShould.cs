using FluentAssertions;

namespace Personal.Finance.Calculation.Tests
{
    public class IncomeCalculatorShould
    {
        [Theory]
        [InlineData(10000, 1000)]
        [InlineData(1000, 999)]
        [InlineData(100, 80)]
        public void CalculateGrossIncome(decimal netIncome, decimal expenditure)
        {
            var incomeCalculator = new IncomeCalculator();

            var result = incomeCalculator.CalculateGrossIncome(netIncome, expenditure);

            result.Should().Be(netIncome - expenditure);
        }
    }
}
