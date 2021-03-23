using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblemailescalation
    {
        public int EmailEscalationId { get; set; }
        public string EmailEscalationName { get; set; }
        public string MessageType { get; set; }
        public int? ReasonLevel1 { get; set; }
        public int? ReasonLevel2 { get; set; }
        public int? ReasonLevel3 { get; set; }
        public int? PlantId { get; set; }
        public int? ShopId { get; set; }
        public int? CellId { get; set; }
        public int? WorkCenterId { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public string ToList { get; set; }
        public string CcList { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual Tblcell Cell { get; set; }
        public virtual Tblplant Plant { get; set; }
        public virtual Tbllossescodes ReasonLevel1Navigation { get; set; }
        public virtual Tbllossescodes ReasonLevel2Navigation { get; set; }
        public virtual Tbllossescodes ReasonLevel3Navigation { get; set; }
        public virtual Tblshop Shop { get; set; }
        public virtual Tblmachinedetails WorkCenter { get; set; }
    }
}
