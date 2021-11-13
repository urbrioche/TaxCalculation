using System.Collections.Generic;
using System.Linq;

namespace TaxCalculationTests
{
    public class TaxHelper
    {
        public static decimal GetTaxResult(decimal income)
        {
            var rates = GetTaxRates();

            return rates.Sum(rate => rate.GetTaxAmount(income));
        }

        private static IEnumerable<TaxRate> GetTaxRates()
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