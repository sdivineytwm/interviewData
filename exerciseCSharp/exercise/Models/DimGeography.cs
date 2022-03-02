using System;
using System.Collections.Generic;

namespace exercise.Models
{
    public partial class DimGeography
    {
        public DimGeography()
        {
            DimCustomers = new HashSet<DimCustomer>();
            DimSalesTerritories = new HashSet<DimSalesTerritory>();
            DimStores = new HashSet<DimStore>();
        }

        public int GeographyKey { get; set; }
        public string GeographyType { get; set; } = null!;
        public string ContinentName { get; set; } = null!;
        public string? CityName { get; set; }
        public string? StateProvinceName { get; set; }
        public string? RegionCountryName { get; set; }
        public int? EtlloadId { get; set; }
        public DateTime? LoadDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<DimCustomer> DimCustomers { get; set; }
        public virtual ICollection<DimSalesTerritory> DimSalesTerritories { get; set; }
        public virtual ICollection<DimStore> DimStores { get; set; }
    }
}
