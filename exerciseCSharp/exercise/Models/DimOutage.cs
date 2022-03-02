using System;
using System.Collections.Generic;

namespace exercise.Models
{
    public partial class DimOutage
    {
        public DimOutage()
        {
            FactItslas = new HashSet<FactItsla>();
        }

        public int OutageKey { get; set; }
        public string OutageLabel { get; set; } = null!;
        public string OutageName { get; set; } = null!;
        public string OutageDescription { get; set; } = null!;
        public string OutageType { get; set; } = null!;
        public string OutageTypeDescription { get; set; } = null!;
        public string OutageSubType { get; set; } = null!;
        public string OutageSubTypeDescription { get; set; } = null!;
        public int? EtlloadId { get; set; }
        public DateTime? LoadDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<FactItsla> FactItslas { get; set; }
    }
}
