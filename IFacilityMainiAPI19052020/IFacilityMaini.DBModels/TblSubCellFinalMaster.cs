using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblSubCellFinalMaster
    {
        public int SubCellFinalId { get; set; }
        public string SubCellFinalName { get; set; }
        public string SubCellFinalDesc { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? CellFinalId { get; set; }
    }
}
