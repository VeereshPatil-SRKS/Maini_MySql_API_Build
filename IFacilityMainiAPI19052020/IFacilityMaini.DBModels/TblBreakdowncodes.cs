using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblBreakdowncodes
    {
        public TblBreakdowncodes()
        {
            TblBreakDownTickect = new HashSet<TblBreakDownTickect>();
        }

        public int BreakdownId { get; set; }
        public string BreakdownCode { get; set; }
        public string BreakdownDesc { get; set; }
        public string MessageType { get; set; }
        public int BreakdownLevel { get; set; }
        public int? BreakdownLevel1Id { get; set; }
        public int? BreakdownLevel2Id { get; set; }
        public string ContributeTo { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? EndCode { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int ServerTabCheck { get; set; }
        public int ServerTabFlagSync { get; set; }
        public decimal TargetPercent { get; set; }

        public virtual ICollection<TblBreakDownTickect> TblBreakDownTickect { get; set; }
    }
}
