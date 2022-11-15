using PersonalFinance.Calculation;
using PersonalFinance.Domain;

namespace PersonalFinance.Calculation
{
    public class ExpenditureCalculator : IExpenditureCalculator
    {
        public decimal CalculateExpenditure(IEnumerable<Expenditure> expenditures)
        {
            return expenditures.Sum(e => e.Amount);
        }
    }
}