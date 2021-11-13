namespace TaxCalculationTests
{
    public class TaxHelper
    {
        public static decimal GetTaxResult(decimal income)
        {
            decimal result = 0;

            result += GetLevel1Tax(income, new TaxRate()
            {
                Lower = 0m,
                Upper = 540000m,
                Rate = 0.05m,
            });

            result += GetLevel1Tax(income, new TaxRate()
            {
                Lower = 540000,
                Upper = 1210000,
                Rate = 0.12m,
            });
            
            result += GetLevel1Tax(income, new TaxRate()
            {
                Lower = 1210000,
                Upper =2420000,
                Rate = 0.2m,
            });
            result += GetLevel1Tax(income, new TaxRate()
            {
                Lower = 2420000,
                Upper =4530000 ,
                Rate = 0.3m,
            });

            result += GetLevel1Tax(income, new TaxRate()
            {
                Lower = 4530000,
                Upper = 10310000,
                Rate = 0.4m,
            });

            result += GetLevel1Tax(income, new TaxRate()
            {
                Lower = 10310000,
                Upper = decimal.MaxValue,
                Rate = 0.5m,
            });


            return result;
        }

        private static decimal GetLevel1Tax(decimal income, TaxRate taxRate)
        {
            return taxRate.GetTaxAmount(income);

            // decimal result = 0;
            // if (income > taxRate.Lower && income <= taxRate.Upper)
            // {
            //     result += (income - taxRate.Lower) * taxRate.Rate;
            // }
            //
            // if (income > taxRate.Upper)
            // {
            //     result += (taxRate.Upper - taxRate.Lower) * taxRate.Rate;
            // }
            //
            // return result;
        }
    }

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