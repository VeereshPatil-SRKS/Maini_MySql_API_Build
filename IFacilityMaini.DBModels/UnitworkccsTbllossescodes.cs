using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTbllossescodes
    {
        public UnitworkccsTbllossescodes()
        {
            UnitworkccsTblemailescalationReasonLevel1Navigation = new HashSet<UnitworkccsTblemailescalation>();
            UnitworkccsTblemailescalationReasonLevel2Navigation = new HashSet<UnitworkccsTblemailescalation>();
            UnitworkccsTblemailescalationReasonLevel3Navigation = new HashSet<UnitworkccsTblemailescalation>();
            UnitworkccsTblescalationlog = new HashSet<UnitworkccsTblescalationlog>();
            UnitworkccsTbllivemode = new HashSet<UnitworkccsTbllivemode>();
            UnitworkccsTbllossofentry = new HashSet<UnitworkccsTbllossofentry>();
            UnitworkccsTblmodeBreakdown = new HashSet<UnitworkccsTblmode>();
            UnitworkccsTblmodeLossCode = new HashSet<UnitworkccsTblmode>();
            UnitworkccsTblmodetemp = new HashSet<UnitworkccsTblmodetemp>();
            UnitworkccsTblsetupmaint = new HashSet<UnitworkccsTblsetupmaint>();
        }

        public int LossCodeId { get; set; }
        public string LossCode { get; set; }
        public string LossCodeDesc { get; set; }
        public string MessageType { get; set; }
        public int LossCodesLevel { get; set; }
        public int? LossCodesLevel1Id { get; set; }
        public int? LossCodesLevel2Id { get; set; }
        public string ContributeTo { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? EndCode { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int ServerTabCheck { get; set; }
        public int ServerTabFlagSync { get; set; }
        public decimal TargetPercent { get; set; }

        public virtual ICollection<UnitworkccsTblemailescalation> UnitworkccsTblemailescalationReasonLevel1Navigation { get; set; }
        public virtual ICollection<UnitworkccsTblemailescalation> UnitworkccsTblemailescalationReasonLevel2Navigation { get; set; }
        public virtual ICollection<UnitworkccsTblemailescalation> UnitworkccsTblemailescalationReasonLevel3Navigation { get; set; }
        public virtual ICollection<UnitworkccsTblescalationlog> UnitworkccsTblescalationlog { get; set; }
        public virtual ICollection<UnitworkccsTbllivemode> UnitworkccsTbllivemode { get; set; }
        public virtual ICollection<UnitworkccsTbllossofentry> UnitworkccsTbllossofentry { get; set; }
        public virtual ICollection<UnitworkccsTblmode> UnitworkccsTblmodeBreakdown { get; set; }
        public virtual ICollection<UnitworkccsTblmode> UnitworkccsTblmodeLossCode { get; set; }
        public virtual ICollection<UnitworkccsTblmodetemp> UnitworkccsTblmodetemp { get; set; }
        public virtual ICollection<UnitworkccsTblsetupmaint> UnitworkccsTblsetupmaint { get; set; }
    }
}
