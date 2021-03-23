using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tbldowntimecategory
    {
        public Tbldowntimecategory()
        {
            Tbldowntimedetails = new HashSet<Tbldowntimedetails>();
        }

        public int DtcId { get; set; }
        public string Dtcategory { get; set; }
        public string DtcategoryDesc { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<Tbldowntimedetails> Tbldowntimedetails { get; set; }
    }
}
