using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class CuttingTimeReportPdf
    {
        public int CuttingId { get; set; }
        public double Cuttingtimes { get; set; }
        public TimeSpan? Cuttingtimeinserted { get; set; }
        public int CuttingShift { get; set; }
        public string CuttingDate { get; set; }
        public int? MachineId { get; set; }
        public int? MonthNum { get; set; }
        public int? WeekNum { get; set; }
        public int? YearNum { get; set; }
    }
}
