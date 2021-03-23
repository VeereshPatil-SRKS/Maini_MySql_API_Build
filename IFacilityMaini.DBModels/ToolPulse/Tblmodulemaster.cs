using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblmodulemaster
    {
        public Tblmodulemaster()
        {
            Tblroleplaymaster = new HashSet<Tblroleplaymaster>();
        }

        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<Tblroleplaymaster> Tblroleplaymaster { get; set; }
    }
}
