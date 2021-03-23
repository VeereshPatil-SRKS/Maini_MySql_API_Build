using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Opcuttimereport
    {
        public int IdOpCutTimeReport { get; set; }
        public double Operatingtimes { get; set; }
        public double Cuttingtimes { get; set; }
        public double PowerOnTime { get; set; }
        public TimeSpan Timeinserted { get; set; }
        public int Shift { get; set; }
        public string ReportDate { get; set; }
    }
}
