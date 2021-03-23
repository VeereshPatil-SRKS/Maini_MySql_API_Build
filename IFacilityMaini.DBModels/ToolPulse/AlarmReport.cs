using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class AlarmReport
    {
        public int Reportid { get; set; }
        public int? Slno { get; set; }
        public string Alarmno { get; set; }
        public string Alarmdescn { get; set; }
        public DateTime? Alarmdatetime { get; set; }
    }
}
