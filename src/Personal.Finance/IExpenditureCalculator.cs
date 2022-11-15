using Personal.Finance.Domain;

namespace Personal.Finance.Calculation
{
    public interface IExpenditureCalculator
    {
        decimal CalculateExpenditure(IEnumerable<Expenditure> expenditures);
    }
}
