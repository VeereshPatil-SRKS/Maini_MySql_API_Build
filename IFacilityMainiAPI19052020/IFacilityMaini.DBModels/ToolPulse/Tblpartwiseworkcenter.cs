using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblpartwiseworkcenter
    {
        public int PartWiseWcId { get; set; }
        public int WorkCenterId { get; set; }
        public int MeasuringUnitId { get; set; }
        public short IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Tblmachinedetails WorkCenter { get; set; }
    }
}
