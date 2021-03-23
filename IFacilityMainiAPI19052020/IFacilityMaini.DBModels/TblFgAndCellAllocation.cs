using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblFgAndCellAllocation
    {
        public int FgAndCellAllocationId { get; set; }
        public int? PlantId { get; set; }
        public string PartNo { get; set; }
        public int? CellFinalId { get; set; }
        public int? SubCellFinalId { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string PartName { get; set; }
        public string DmcCodeStatus { get; set; }
    }
}
