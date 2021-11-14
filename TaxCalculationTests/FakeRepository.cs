using System.Collections.Generic;
using TaxCalculationLibrary;

namespace TaxCalculationTests
{
    public class FakeRepository : IRepository
    {
        public IEnumerable<TaxRate> GetTaxRates()
        {
            return new[]
            {
                new TaxRate()
                {
                    Lower = 0m,
                    Upper = 540000m,
                    Rate = 0.05m,
                },
                new TaxRate()
                {
                    Lower = 540000,
                    Upper = 1210000,
                    Rate = 0.12m,
                },
                new TaxRate()
                {
                    Lower = 1210000,
                    Upper = 2420000,
                    Rate = 0.2m,
                },
                new TaxRate()
                {
                    Lower = 2420000,
                    Upper = 4530000,
                    Rate = 0.3m,
                },
                new TaxRate()
                {
                    Lower = 4530000,
                    Upper = 10310000,
                    Rate = 0.4m,
                },
                new TaxRate()
                {
                    Lower = 10310000,
                    Upper = decimal.MaxValue,
                    Rate = 0.5m,
                }
            };
        }
    }
}