namespace Personal.Finance.Calculation
{
    public class IncomeCalculator : IIncomeCalculator
    {
        public decimal CalculateGrossIncome(decimal netIncome, decimal expenditure)
        {
            return netIncome - expenditure;
        }
    }
}
