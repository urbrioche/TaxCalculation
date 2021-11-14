using System.Collections.Generic;
using System.Linq;

namespace TaxCalculationLibrary
{
    public class TaxCalculation
    {
        private readonly Repository _repository;

        public TaxCalculation(Repository repository)
        {
            _repository = repository;
        }

        public decimal GetTaxResult(decimal income)
        {
            return _repository.GetTaxRates().Sum(rate => rate.GetTaxAmount(income));
        }
    }
}