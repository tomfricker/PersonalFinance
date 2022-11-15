namespace Personal.Finance.Calculation
{
    public class SavingsCalculator : ISavingsCalculator
    {
        public decimal CalculateSavings(decimal grossIncome, int percentage)
        {
            return grossIncome * (percentage/100);
        }
    }
}
