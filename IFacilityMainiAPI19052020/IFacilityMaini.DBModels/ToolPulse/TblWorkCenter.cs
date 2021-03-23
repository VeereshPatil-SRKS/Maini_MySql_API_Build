using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class TblWorkCenter
    {
        public long WorkCenterId { get; set; }
        public string WorkCenterName { get; set; }
        public string WorkCenterDescription { get; set; }
        public string PlantCode { get; set; }
        public long? PlantId { get; set; }
        public string WoCode { get; set; }
        public string CostCenter { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public long? ModifiedBy { get; set; }
    }
}
