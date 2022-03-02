using System;
using System.Collections.Generic;

namespace exercise.Models
{
    public partial class DimCurrency
    {
        public DimCurrency()
        {
            FactExchangeRates = new HashSet<FactExchangeRate>();
            FactInventories = new HashSet<FactInventory>();
            FactOnlineSales = new HashSet<FactOnlineSale>();
            FactSales = new HashSet<FactSale>();
            FactSalesQuota = new HashSet<FactSalesQuotum>();
            FactStrategyPlans = new HashSet<FactStrategyPlan>();
        }

        public int CurrencyKey { get; set; }
        public string CurrencyLabel { get; set; } = null!;
        public string CurrencyName { get; set; } = null!;
        public string CurrencyDescription { get; set; } = null!;
        public int? EtlloadId { get; set; }
        public DateTime? LoadDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<FactExchangeRate> FactExchangeRates { get; set; }
        public virtual ICollection<FactInventory> FactInventories { get; set; }
        public virtual ICollection<FactOnlineSale> FactOnlineSales { get; set; }
        public virtual ICollection<FactSale> FactSales { get; set; }
        public virtual ICollection<FactSalesQuotum> FactSalesQuota { get; set; }
        public virtual ICollection<FactStrategyPlan> FactStrategyPlans { get; set; }
    }
}
