using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class OperatingTimeReport
    {
        public int OperatingId { get; set; }
        public double Operatingtimes { get; set; }
        public TimeSpan Operatingtimeinserted { get; set; }
        public int OperatingShift { get; set; }
        public string OperatingDate { get; set; }
    }
}
