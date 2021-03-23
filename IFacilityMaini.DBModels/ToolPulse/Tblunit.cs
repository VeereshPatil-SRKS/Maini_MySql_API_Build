using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblunit
    {
        public Tblunit()
        {
            Tblparts = new HashSet<Tblparts>();
        }

        public int UId { get; set; }
        public string Unit { get; set; }
        public string UnitDesc { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<Tblparts> Tblparts { get; set; }
    }
}
