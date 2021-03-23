using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblLivecbmdetails
    {
        public int Cbmdetailsid { get; set; }
        public int? MachineId { get; set; }
        public int? SensorMasterId { get; set; }
        public int? SensorValues { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public string CorrectedDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
