namespace Personal.Finance.Calculation
{
    public interface ISavingsCalculator
    {
        decimal CalculateSavings(decimal grossIncome, int percentage);
    }
}
