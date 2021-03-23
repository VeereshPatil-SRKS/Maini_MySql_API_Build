using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class ParametersMaster
    {
        public int ParameterId { get; set; }
        public int SetupTime { get; set; }
        public int OperatingTime { get; set; }
        public int PowerOnTime { get; set; }
        public int? PartsCount { get; set; }
        public DateTime? InsertedOn { get; set; }
        public int? MachineId { get; set; }
        public int? Shift { get; set; }
        public DateTime? CorrectedDate { get; set; }
        public string AutoCutTime { get; set; }
        public string TotalCutTime { get; set; }
        public int? PartsTotal { get; set; }
        public string CuttingTime { get; set; }
        public int AutoMode { get; set; }
    }
}
