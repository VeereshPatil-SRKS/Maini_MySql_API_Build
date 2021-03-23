using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class MainTimeRep
    {
        public int MainTimeRepId { get; set; }
        public double CuttingTime { get; set; }
        public double OperatingTime { get; set; }
        public double PowerOnTime { get; set; }
        public string CorrectedDate { get; set; }
        public int Shift { get; set; }
        public int MachineId { get; set; }
        public int? MonthNum { get; set; }
        public int? WeekNum { get; set; }
        public int? YearNum { get; set; }
        public string MonthName { get; set; }
        public string WeekRange { get; set; }
    }
}
