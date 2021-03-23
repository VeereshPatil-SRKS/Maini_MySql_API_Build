using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tbltoollifeoperator
    {
        public int ToolLifeId { get; set; }
        public int MachineId { get; set; }
        public string ToolNo { get; set; }
        public string ToolName { get; set; }
        public string ToolCtcode { get; set; }
        public int ToolIdadmin { get; set; }
        public int? StandardToolLife { get; set; }
        public int Toollifecounter { get; set; }
        public DateTime? InsertedOn { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int IsReset { get; set; }
        public int IsDeleted { get; set; }
        public int ResetCounter { get; set; }
        public int? Hmiid { get; set; }
        public int? Sync { get; set; }
        public bool? IsCompleted { get; set; }
        public bool IsCycleStart { get; set; }
        public string ResetReason { get; set; }

        public virtual Tblmachinedetails Machine { get; set; }
    }
}
