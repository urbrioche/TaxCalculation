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

            if (income > 0 && income <= 540000)
            {
                result += (income - 0) * 0.05m;
            }

            if (income > 540000)
            {
                result += (540000 - 0) * 0.05m;
            }

            return result;
        }
    }
}