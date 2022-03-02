using System;
using System.Collections.Generic;

namespace exercise.Models
{
    public partial class DimProductCategory
    {
        public DimProductCategory()
        {
            DimProductSubcategories = new HashSet<DimProductSubcategory>();
            FactStrategyPlans = new HashSet<FactStrategyPlan>();
        }

        public int ProductCategoryKey { get; set; }
        public string? ProductCategoryLabel { get; set; }
        public string ProductCategoryName { get; set; } = null!;
        public string ProductCategoryDescription { get; set; } = null!;
        public int? EtlloadId { get; set; }
        public DateTime? LoadDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<DimProductSubcategory> DimProductSubcategories { get; set; }
        public virtual ICollection<FactStrategyPlan> FactStrategyPlans { get; set; }
    }
}
