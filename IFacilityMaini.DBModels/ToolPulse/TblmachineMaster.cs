using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class TblmachineMaster
    {
        public int MachineId { get; set; }
        public string MachineInvNo { get; set; }
        public string Ipaddress { get; set; }
        public int? MachineType { get; set; }
        public string ControllerType { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
