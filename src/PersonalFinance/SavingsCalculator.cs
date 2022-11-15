namespace PersonalFinance.Calculation
{
    public class SavingsCalculator : ISavingsCalculator
    {
        public decimal CalculateSavings(decimal grossIncome, int percentage)
        {
            return grossIncome * (percentage/100);
        }
    }
}
