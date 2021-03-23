using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblLivetblsensorvalue
    {
        public int Sensorvalueid { get; set; }
        public int? MachineId { get; set; }
        public int? SensorMasterId { get; set; }
        public int? SensorValues { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? ValueDateTime { get; set; }
        public string CorrectedDate { get; set; }
        public int? IsConverted { get; set; }
    }
}
