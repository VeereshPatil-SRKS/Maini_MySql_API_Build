using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class OperatingTimeReportPdf
    {
        public int OperatingId { get; set; }
        public double Operatingtimes { get; set; }
        public TimeSpan? Operatingtimeinserted { get; set; }
        public int OperatingShift { get; set; }
        public string OperatingDate { get; set; }
        public int? MachineId { get; set; }
        public int? MonthNum { get; set; }
        public int? WeekNum { get; set; }
        public int? YearNum { get; set; }
    }
}
