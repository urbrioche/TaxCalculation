namespace TaxCalculationTests
{
    public class TaxHelper
    {
        public static decimal GetTaxResult(decimal income)
        {
            decimal result = 0;
            var level1Tax = GetLevel1Tax(income);

            result += level1Tax;
            var level2Tax = GetLevel2Tax(income);

            result += level2Tax;
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

        private static decimal GetLevel2Tax(decimal income)
        {
            var taxRate = new TaxRate()
            {
                Lower = 540000,
                Upper = 1210000,
                Rate = 0.12m,
            };
            return GetTaxAmount(income, taxRate);
        }

        private static decimal GetTaxAmount(decimal income, TaxRate taxRate)
        {
            var result = 0m;
            if (income > taxRate.Lower && income <= taxRate.Upper)
            {
                result = (income - taxRate.Lower) * taxRate.Rate;
            }

            if (income > taxRate.Upper)
            {
                result = (taxRate.Upper - taxRate.Lower) * taxRate.Rate;
            }

            return result;
        }

        private static decimal GetLevel1Tax(decimal income)
        {

            var taxRate = new TaxRate()
            {
                Lower = 0m,
                Upper = 540000m,
                Rate = 0.05m,
            };

            return GetTaxAmount(income, taxRate);

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
    }
}