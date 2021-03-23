using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblProductWiseDefectCode
    {
        public int ProductWiseDefectCodeId { get; set; }
        public int? Trim { get; set; }
        public int? PlantId { get; set; }
        public string PartNo { get; set; }
        public int? DefectCodeId { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string PartName { get; set; }
    }
}
