using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblholdcodes
    {
        public int HoldCodeId { get; set; }
        public string HoldCode { get; set; }
        public string HoldCodeDesc { get; set; }
        public string MessageType { get; set; }
        public int HoldCodesLevel { get; set; }
        public int? HoldCodesLevel1Id { get; set; }
        public int? HoldCodesLevel2Id { get; set; }
        public string ContributeTo { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? EndCode { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int ServerTabFlagSync { get; set; }
        public int ServerTabCheck { get; set; }
    }
}
