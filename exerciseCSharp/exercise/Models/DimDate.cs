using System;
using System.Collections.Generic;

namespace exercise.Models
{
    public partial class DimDate
    {
        public DimDate()
        {
            FactExchangeRates = new HashSet<FactExchangeRate>();
            FactInventories = new HashSet<FactInventory>();
            FactItmachines = new HashSet<FactItmachine>();
            FactItslas = new HashSet<FactItsla>();
            FactOnlineSales = new HashSet<FactOnlineSale>();
            FactSales = new HashSet<FactSale>();
            FactSalesQuota = new HashSet<FactSalesQuotum>();
            FactStrategyPlans = new HashSet<FactStrategyPlan>();
        }

        public DateTime Datekey { get; set; }
        public string FullDateLabel { get; set; } = null!;
        public string DateDescription { get; set; } = null!;
        public int CalendarYear { get; set; }
        public string CalendarYearLabel { get; set; } = null!;
        public int CalendarHalfYear { get; set; }
        public string CalendarHalfYearLabel { get; set; } = null!;
        public int CalendarQuarter { get; set; }
        public string? CalendarQuarterLabel { get; set; }
        public int CalendarMonth { get; set; }
        public string CalendarMonthLabel { get; set; } = null!;
        public int CalendarWeek { get; set; }
        public string CalendarWeekLabel { get; set; } = null!;
        public int CalendarDayOfWeek { get; set; }
        public string CalendarDayOfWeekLabel { get; set; } = null!;
        public int FiscalYear { get; set; }
        public string FiscalYearLabel { get; set; } = null!;
        public int FiscalHalfYear { get; set; }
        public string FiscalHalfYearLabel { get; set; } = null!;
        public int FiscalQuarter { get; set; }
        public string FiscalQuarterLabel { get; set; } = null!;
        public int FiscalMonth { get; set; }
        public string FiscalMonthLabel { get; set; } = null!;
        public string IsWorkDay { get; set; } = null!;
        public int IsHoliday { get; set; }
        public string HolidayName { get; set; } = null!;
        public string? EuropeSeason { get; set; }
        public string? NorthAmericaSeason { get; set; }
        public string? AsiaSeason { get; set; }

        public virtual ICollection<FactExchangeRate> FactExchangeRates { get; set; }
        public virtual ICollection<FactInventory> FactInventories { get; set; }
        public virtual ICollection<FactItmachine> FactItmachines { get; set; }
        public virtual ICollection<FactItsla> FactItslas { get; set; }
        public virtual ICollection<FactOnlineSale> FactOnlineSales { get; set; }
        public virtual ICollection<FactSale> FactSales { get; set; }
        public virtual ICollection<FactSalesQuotum> FactSalesQuota { get; set; }
        public virtual ICollection<FactStrategyPlan> FactStrategyPlans { get; set; }
    }
}
