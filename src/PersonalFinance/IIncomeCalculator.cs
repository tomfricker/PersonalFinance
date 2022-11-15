namespace PersonalFinance.Calculation
{
    public interface IIncomeCalculator
    {
        decimal CalculateGrossIncome(decimal netIncome, decimal expenditure);
    }
}
