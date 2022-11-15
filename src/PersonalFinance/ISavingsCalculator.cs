namespace PersonalFinance.Calculation
{
    public interface ISavingsCalculator
    {
        decimal CalculateSavings(decimal grossIncome, int percentage);
    }
}
