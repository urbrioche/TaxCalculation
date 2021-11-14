using System.Collections.Generic;

namespace TaxCalculationLibrary
{
    public interface IRepository
    {
        IEnumerable<TaxRate> GetTaxRates();
    }
}