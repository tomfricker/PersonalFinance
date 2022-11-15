using PersonalFinance.Domain;

namespace PersonalFinance.Calculation
{
    public interface IExpenditureCalculator
    {
        decimal CalculateExpenditure(IEnumerable<Expenditure> expenditures);
    }
}
