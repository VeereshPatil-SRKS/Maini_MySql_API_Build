using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class PcbParameters
    {
        public int ParameterId { get; set; }
        public string ParameterType { get; set; }
        public string Description { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int PinNumber { get; set; }
        public string LogFile { get; set; }
        public int MachineId { get; set; }
        public int HighValue { get; set; }
        public string ColorCode { get; set; }
        public int IsPulse { get; set; }
    }
}
