using System.Collections.Generic;

namespace TaxCalculationLibrary
{
    public class Repository
    {
        public IEnumerable<TaxRate> GetTaxRates()
        {
            var rate1 = new TaxRate()
            {
                Lower = 0m,
                Upper = 540000m,
                Rate = 0.05m,
            };
            var rate2 = new TaxRate()
            {
                Lower = 540000,
                Upper = 1210000,
                Rate = 0.12m,
            };
            var rate3 = new TaxRate()
            {
                Lower = 1210000,
                Upper = 2420000,
                Rate = 0.2m,
            };
            var rate4 = new TaxRate()
            {
                Lower = 2420000,
                Upper = 4530000,
                Rate = 0.3m,
            };
            var rate5 = new TaxRate()
            {
                Lower = 4530000,
                Upper = 10310000,
                Rate = 0.4m,
            };
            var rate6 = new TaxRate()
            {
                Lower = 10310000,
                Upper = decimal.MaxValue,
                Rate = 0.5m,
            };

            var rates = new[]
            {
                rate1, rate2, rate3, rate4, rate5, rate6
            };
            return rates;
        }
    }
}