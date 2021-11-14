using System.Linq;

namespace TaxCalculationLibrary
{
    public class TaxHelper
    {
        public static decimal GetTaxResult(decimal income)
        {
            var repository = new Repository();
            var rates = repository.GetTaxRates();
            return rates.Sum(rate => rate.GetTaxAmount(income));
        }
    }
}