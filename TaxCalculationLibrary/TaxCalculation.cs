using System.Linq;

namespace TaxCalculationLibrary
{
    public class TaxCalculation
    {
        private readonly IRepository _repository;

        public TaxCalculation(IRepository repository)
        {
            _repository = repository;
        }

        public decimal GetTaxResult(decimal income)
        {
            return _repository.GetTaxRates().Sum(rate => rate.GetTaxAmount(income));
        }
    }
}