using FluentAssertions;
using PersonalFinance.Domain;
using PersonalFinance.Calculation;

namespace PersonalFinance.Calculation.Tests
{
    public class ExpenditureCalculatorShould
    {
        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(30)]
        public void ReturnSumOfExpenditure_GivenEnumerableOfExpenditure(decimal amount)
        {
            var expenditureCalculator = new ExpenditureCalculator();

            var expenditures = new List<Expenditure>
            {
                new Expenditure { Amount = amount },
                new Expenditure { Amount = amount*2 },
                new Expenditure { Amount = amount*3 }
            };

            var result = expenditureCalculator.CalculateExpenditure(expenditures);

            result.Should().Be(amount*6);
        }
    }
}