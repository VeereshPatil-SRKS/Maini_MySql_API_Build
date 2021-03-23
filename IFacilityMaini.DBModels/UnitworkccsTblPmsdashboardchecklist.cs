using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblPmsdashboardchecklist
    {
        public int Id { get; set; }
        public int CheckListHeaderId { get; set; }
        public int CheckListDetailsId { get; set; }
        public int? RoleId { get; set; }
        public byte? IsNumaric { get; set; }
        public byte? IsText { get; set; }
        public string NumaricComment { get; set; }
        public string TextComment { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? IsDeleted { get; set; }
        public int? IsApproved { get; set; }
    }
}
