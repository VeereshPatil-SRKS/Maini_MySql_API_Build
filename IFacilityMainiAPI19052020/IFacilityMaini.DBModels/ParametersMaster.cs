using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class ParametersMaster
    {
        public int ParameterId { get; set; }
        public string SetupTime { get; set; }
        public string OperatingTime { get; set; }
        public string PowerOnTime { get; set; }
        public double? PartsCount { get; set; }
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
