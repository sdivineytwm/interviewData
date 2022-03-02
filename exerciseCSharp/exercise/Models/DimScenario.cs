using System;
using System.Collections.Generic;

namespace exercise.Models
{
    public partial class DimScenario
    {
        public DimScenario()
        {
            FactSalesQuota = new HashSet<FactSalesQuotum>();
            FactStrategyPlans = new HashSet<FactStrategyPlan>();
        }

        public int ScenarioKey { get; set; }
        public string ScenarioLabel { get; set; } = null!;
        public string? ScenarioName { get; set; }
        public string? ScenarioDescription { get; set; }
        public int? EtlloadId { get; set; }
        public DateTime? LoadDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<FactSalesQuotum> FactSalesQuota { get; set; }
        public virtual ICollection<FactStrategyPlan> FactStrategyPlans { get; set; }
    }
}
