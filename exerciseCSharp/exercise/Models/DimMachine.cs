﻿using System;
using System.Collections.Generic;

namespace exercise.Models
{
    public partial class DimMachine
    {
        public DimMachine()
        {
            FactItmachines = new HashSet<FactItmachine>();
            FactItslas = new HashSet<FactItsla>();
        }

        public int MachineKey { get; set; }
        public string? MachineLabel { get; set; }
        public int StoreKey { get; set; }
        public string MachineType { get; set; } = null!;
        public string MachineName { get; set; } = null!;
        public string MachineDescription { get; set; } = null!;
        public string VendorName { get; set; } = null!;
        public string MachineOs { get; set; } = null!;
        public string MachineSource { get; set; } = null!;
        public string? MachineHardware { get; set; }
        public string MachineSoftware { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime ServiceStartDate { get; set; }
        public DateTime? DecommissionDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? EtlloadId { get; set; }
        public DateTime? LoadDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual DimStore StoreKeyNavigation { get; set; } = null!;
        public virtual ICollection<FactItmachine> FactItmachines { get; set; }
        public virtual ICollection<FactItsla> FactItslas { get; set; }
    }
}
