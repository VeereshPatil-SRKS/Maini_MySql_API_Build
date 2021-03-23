using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class OpcuttimereportPdf
    {
        public int IdOpCutTimeReportPdf { get; set; }
        public double Operatingtimes { get; set; }
        public double Cuttingtimes { get; set; }
        public int Shift { get; set; }
        public string ReportDate { get; set; }
        public double PowerOnTime { get; set; }
    }
}
