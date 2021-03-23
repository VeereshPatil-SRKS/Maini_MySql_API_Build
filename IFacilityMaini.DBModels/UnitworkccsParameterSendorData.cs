using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsParameterSendorData
    {
        public int ParameterSensorDataId { get; set; }
        public int? MachineId { get; set; }
        public DateTime? SensorDataCapturedTime { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? CorrectedDate { get; set; }
    }
}
