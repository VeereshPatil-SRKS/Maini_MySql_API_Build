using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class ControlPlan
    {
        public ControlPlan()
        {
            CpDetails = new HashSet<CpDetails>();
        }

        public int Id { get; set; }
        public string Cell { get; set; }
        public string SubCell { get; set; }
        public string FgNumber { get; set; }
        public string FgDescription { get; set; }
        public string ChildPartNumber { get; set; }
        public string RoutingNumber { get; set; }
        public string ControlPlanNumber { get; set; }
        public int? RevisionNumber { get; set; }
        public DateTime? RevisionDate { get; set; }
        public string Plant { get; set; }
        public string ControlPlanType { get; set; }
        public string CustomerRefNumber { get; set; }
        public string MppPartNumber { get; set; }
        public string CustomerRevNumber { get; set; }
        public string KeyContactDetails { get; set; }
        public string CoreTeam { get; set; }
        public string SupplierCode { get; set; }
        public DateTime? CustomerApprovalDate { get; set; }
        public string PreparedBy { get; set; }
        public int? FirstCheck { get; set; }
        public string FirstCheckedBy { get; set; }
        public int? SecondCheck { get; set; }
        public string SecondCheckedBy { get; set; }
        public int? ThirdCheck { get; set; }
        public string ThirdCheckedBy { get; set; }
        public int? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? FirstCheckedDate { get; set; }
        public DateTime? SecondCheckedDate { get; set; }
        public DateTime? ThirdCheckedDate { get; set; }
        public DateTime? PreparedDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? PostToCheck { get; set; }
        public int? Frequency { get; set; }
        public int? Days { get; set; }

        public virtual ICollection<CpDetails> CpDetails { get; set; }
    }
}
