using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblLivecbmparameters
    {
        public int CbmpId { get; set; }
        public int MachineId { get; set; }
        public int SensorGroupId { get; set; }
        public string Ipaddress { get; set; }
        public int MemoryAddress { get; set; }
        public int SensorValue { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string CorrectedDate { get; set; }
        public int? IsConverted { get; set; }
    }
}
