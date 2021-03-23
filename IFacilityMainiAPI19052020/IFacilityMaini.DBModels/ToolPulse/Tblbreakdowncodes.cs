using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblbreakdowncodes
    {
        public int BreakDownCodeId { get; set; }
        public string BreakDownCode { get; set; }
        public string BreakDownCodeDesc { get; set; }
        public string MessageType { get; set; }
        public int BreakDownCodesLevel { get; set; }
        public int? BreakDownCodesLevel1Id { get; set; }
        public int? BreakDownCodesLevel2Id { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string ContributeTo { get; set; }
    }
}
