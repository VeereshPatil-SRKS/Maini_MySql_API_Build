using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tbllossescodes
    {
        public Tbllossescodes()
        {
            TblSetupMaint = new HashSet<TblSetupMaint>();
            Tblbreakdown = new HashSet<Tblbreakdown>();
            TblemailescalationReasonLevel1Navigation = new HashSet<Tblemailescalation>();
            TblemailescalationReasonLevel2Navigation = new HashSet<Tblemailescalation>();
            TblemailescalationReasonLevel3Navigation = new HashSet<Tblemailescalation>();
            Tblescalationlog = new HashSet<Tblescalationlog>();
            Tbllivemode = new HashSet<Tbllivemode>();
            Tbllossofentry = new HashSet<Tbllossofentry>();
            TblmodeBreakdown = new HashSet<Tblmode>();
            TblmodeLossCode = new HashSet<Tblmode>();
            Tblmodetemp = new HashSet<Tblmodetemp>();
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

        public virtual ICollection<TblSetupMaint> TblSetupMaint { get; set; }
        public virtual ICollection<Tblbreakdown> Tblbreakdown { get; set; }
        public virtual ICollection<Tblemailescalation> TblemailescalationReasonLevel1Navigation { get; set; }
        public virtual ICollection<Tblemailescalation> TblemailescalationReasonLevel2Navigation { get; set; }
        public virtual ICollection<Tblemailescalation> TblemailescalationReasonLevel3Navigation { get; set; }
        public virtual ICollection<Tblescalationlog> Tblescalationlog { get; set; }
        public virtual ICollection<Tbllivemode> Tbllivemode { get; set; }
        public virtual ICollection<Tbllossofentry> Tbllossofentry { get; set; }
        public virtual ICollection<Tblmode> TblmodeBreakdown { get; set; }
        public virtual ICollection<Tblmode> TblmodeLossCode { get; set; }
        public virtual ICollection<Tblmodetemp> Tblmodetemp { get; set; }
    }
}
