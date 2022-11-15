using Personal.Finance.Calculation;
using Personal.Finance.Domain;

namespace PersonalFinanceCalculators
{
    public class ExpenditureCalculator : IExpenditureCalculator
    {
        public decimal CalculateExpenditure(IEnumerable<Expenditure> expenditures)
        {
            return expenditures.Sum(e => e.Amount);
        }
    }
}