namespace Personal.Finance.Calculation
{
    public interface IIncomeCalculator
    {
        decimal CalculateGrossIncome(decimal netIncome, decimal expenditure);
    }
}
