using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblparts
    {
        public int PartId { get; set; }
        public string PartNo { get; set; }
        public string PartDesc { get; set; }
        public string PartName { get; set; }
        public int IdleCycleTime { get; set; }
        public int UnitDesc { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? MachineId { get; set; }
        public int? PlantId { get; set; }
        public string PlantCode { get; set; }
        public string Uom { get; set; }
        public string MaterialType { get; set; }

        public virtual Tblmachinedetails Machine { get; set; }
        public virtual Tblunit UnitDescNavigation { get; set; }
    }
}
