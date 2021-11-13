namespace TaxCalculationTests
{
    public class TaxHelper
    {
        public static decimal GetTaxResult(decimal income)
        {
            var result = GetLevel1Tax(income);

            if (income > 540000 && income <= 1210000)
            {
                result += (income - 540000) * 0.12m;
            }

            if (income > 1210000)
            {
                result += (1210000 - 540000) * 0.12m;
            }

            if (income > 1210000 && income <= 2420000)
            {
                result += (income - 1210000) * 0.2m;
            }

            if (income > 2420000)
            {
                result += (2420000 - 1210000) * 0.2m;
            }

            if (income > 2420000 && income <= 4530000)
            {
                result += (income - 2420000) * 0.3m;
            }

            if (income > 4530000)
            {
                result += (4530000 - 2420000) * 0.3m;
            }

            if (income > 4530000 && income <= 10310000)
            {
                result += (income - 4530000) * 0.4m;
            }

            if (income > 10310000)
            {
                result += (10310000 - 4530000) * 0.4m;
            }

            if (income > 10310000)
            {
                result += (income - 10310000) * 0.5m;
            }


            return result;
        }

        private static decimal GetLevel1Tax(decimal income)
        {
            decimal result = 0;

            var taxRate = new TaxRate()
            {
                Lower = 0m,
                Upper = 540000m,
                Rate = 0.05m,
            };

            if (income > taxRate.Lower && income <= taxRate.Upper)
            {
                result += (income - taxRate.Lower) * taxRate.Rate;
            }

            if (income > taxRate.Upper)
            {
                result += (taxRate.Upper - taxRate.Lower) * taxRate.Rate;
            }

            return result;
        }
    }

    public class TaxRate
    {
        public decimal Lower { get; set; }
        public decimal Upper { get; set; }
        public decimal Rate { get; set; }
    }
}