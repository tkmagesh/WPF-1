namespace MyWPFApp
{
    public class SalaryCalculator
    {
        public double CalculateSalary(double Basic, double Hra, double Da, double Tax)
        {
            var gross = Basic + Hra + Da;
            return gross - (gross * (Tax / 100));
        }

    }
}