namespace MyCVCSharp.Models
{
    public class TaxModel
    {
        public decimal AnnualIncome { get; set; }
        public decimal TaxAmount { get; private set; } 
        public decimal TaxRate { get; set; } = 0.03m;  

        public void CalculateTax()
        {
            if (AnnualIncome <= 150000)
            {
                TaxAmount = AnnualIncome * TaxRate;
            }
            else if (AnnualIncome > 150000 && AnnualIncome <= 400000)
            {
                TaxAmount = 150000 * TaxRate + (AnnualIncome - 150000) * 0.02m;  
            }
            else if (AnnualIncome > 400000)
            {
                TaxAmount = 150000 * TaxRate + 250000 * 0.03m + (AnnualIncome - 400000) * 0.05m;  
            }
            else
            {
                TaxAmount = AnnualIncome * TaxRate;
            }
        }
    }
}
