using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblescalationlog
    {
        public int Elid { get; set; }
        public int? EscalationId { get; set; }
        public int? LossCodeId { get; set; }
        public int IsIdle { get; set; }
        public DateTime? EscalationSentOn { get; set; }
        public string CorrectedDate { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? Wcid { get; set; }

        public virtual Tbllossescodes LossCode { get; set; }
    }
}
