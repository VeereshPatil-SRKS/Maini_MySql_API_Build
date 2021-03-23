using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblSystemConfig
    {
        public int SystemConfigId { get; set; }
        public string MachineId { get; set; }
        public string PcHostName { get; set; }
        public string PcMacAddress { get; set; }
        public string PcIpAddress { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }
    }
}
