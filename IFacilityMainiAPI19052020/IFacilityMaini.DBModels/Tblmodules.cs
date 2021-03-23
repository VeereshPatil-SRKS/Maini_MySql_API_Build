using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblmodules
    {
        public Tblmodules()
        {
            Tblrolemodulelink = new HashSet<Tblrolemodulelink>();
        }

        public int ModuleId { get; set; }
        public string Module { get; set; }
        public string ModuleDesc { get; set; }
        public string ModuleDispName { get; set; }
        public DateTime? InsertedOn { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }

        public virtual ICollection<Tblrolemodulelink> Tblrolemodulelink { get; set; }
    }
}
