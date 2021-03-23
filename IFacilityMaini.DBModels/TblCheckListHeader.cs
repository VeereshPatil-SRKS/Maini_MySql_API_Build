using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblCheckListHeader
    {
        public int HeaderId { get; set; }
        public int? PlantId { get; set; }
        public string PlantName { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? MakeId { get; set; }
        public string MakeName { get; set; }
        public DateTime? CreationDate { get; set; }
        public int RevNo { get; set; }
        public DateTime? LastRevDate { get; set; }
        public string CheckListNo { get; set; }
        public int? PreparedBy { get; set; }
        public DateTime? PreparedByDate { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedByDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? IsDeleted { get; set; }
        public int? IsPrepared { get; set; }
        public int? IsApproved { get; set; }
        public int? IsEditApproved { get; set; }
        public int? PreviousChecklistHeaderId { get; set; }
    }
}
