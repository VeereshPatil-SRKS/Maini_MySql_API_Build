using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class ParameterSendorData
    {
        public int ParameterSensorDataId { get; set; }
        public int? MachineId { get; set; }
        public DateTime? SensorDataCapturedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? CorrectedDate { get; set; }
    }
}
