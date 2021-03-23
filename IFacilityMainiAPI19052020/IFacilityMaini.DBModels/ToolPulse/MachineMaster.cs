using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class MachineMaster
    {
        public int MachineId { get; set; }
        public string MachineInvNo { get; set; }
        public string Ipaddress { get; set; }
        public int? MachineType { get; set; }
        public string ControllerType { get; set; }
        public DateTime InsertedOn { get; set; }
        public string InsertedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public int IsDeleted { get; set; }
        public string MachineModel { get; set; }
        public string MachineMake { get; set; }
        public string ModelType { get; set; }
        public string MachineDispName { get; set; }
        public int? ProgramNum { get; set; }
        public short? IsParameters { get; set; }
    }
}
