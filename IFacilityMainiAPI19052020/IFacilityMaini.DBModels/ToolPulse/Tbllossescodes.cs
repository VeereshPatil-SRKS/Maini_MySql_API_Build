using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tbllossescodes
    {
        public Tbllossescodes()
        {
            Tblbreakdown = new HashSet<Tblbreakdown>();
            TblemailescalationReasonLevel1Navigation = new HashSet<Tblemailescalation>();
            TblemailescalationReasonLevel2Navigation = new HashSet<Tblemailescalation>();
            TblemailescalationReasonLevel3Navigation = new HashSet<Tblemailescalation>();
            Tblescalationlog = new HashSet<Tblescalationlog>();
            Tbllivelossofentry = new HashSet<Tbllivelossofentry>();
            Tbllivelossofentryrep = new HashSet<Tbllivelossofentryrep>();
            Tbllivemanuallossofentry = new HashSet<Tbllivemanuallossofentry>();
            Tbllivemanuallossofentryrep = new HashSet<Tbllivemanuallossofentryrep>();
            Tbllossofentry = new HashSet<Tbllossofentry>();
            Tblmanuallossofentry = new HashSet<Tblmanuallossofentry>();
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

        public virtual ICollection<Tblbreakdown> Tblbreakdown { get; set; }
        public virtual ICollection<Tblemailescalation> TblemailescalationReasonLevel1Navigation { get; set; }
        public virtual ICollection<Tblemailescalation> TblemailescalationReasonLevel2Navigation { get; set; }
        public virtual ICollection<Tblemailescalation> TblemailescalationReasonLevel3Navigation { get; set; }
        public virtual ICollection<Tblescalationlog> Tblescalationlog { get; set; }
        public virtual ICollection<Tbllivelossofentry> Tbllivelossofentry { get; set; }
        public virtual ICollection<Tbllivelossofentryrep> Tbllivelossofentryrep { get; set; }
        public virtual ICollection<Tbllivemanuallossofentry> Tbllivemanuallossofentry { get; set; }
        public virtual ICollection<Tbllivemanuallossofentryrep> Tbllivemanuallossofentryrep { get; set; }
        public virtual ICollection<Tbllossofentry> Tbllossofentry { get; set; }
        public virtual ICollection<Tblmanuallossofentry> Tblmanuallossofentry { get; set; }
    }
}
