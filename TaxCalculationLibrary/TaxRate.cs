namespace TaxCalculationLibrary
{
    public class TaxRate
    {
        public decimal Lower { get; set; }
        public decimal Upper { get; set; }
        public decimal Rate { get; set; }

        public decimal GetTaxAmount(decimal income)
        {
            if (income > Lower && income <= Upper)
            {
                return (income - Lower) * Rate;
            }

            if (income > Upper)
            {
                return (Upper - Lower) * Rate;
            }

            return 0;
        }
    }
}