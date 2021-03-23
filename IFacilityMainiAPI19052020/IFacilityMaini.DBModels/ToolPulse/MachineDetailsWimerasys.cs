using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class MachineDetailsWimerasys
    {
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public int? TransmissionFrequency { get; set; }
        public string LoggerType { get; set; }
        public string MachineIp { get; set; }
        public int? MachinePort { get; set; }
        public int? NumOfAxis { get; set; }
        public int? ToolGroupNum { get; set; }
        public int? NumberOfCurrent { get; set; }
        public int? NumberOfTemperature { get; set; }
        public int? NumberOfPresure { get; set; }
        public int? NumberOfLevel { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
