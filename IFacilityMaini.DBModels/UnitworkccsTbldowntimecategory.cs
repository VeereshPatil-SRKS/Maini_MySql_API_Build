using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTbldowntimecategory
    {
        public UnitworkccsTbldowntimecategory()
        {
            UnitworkccsTbldowntimedetails = new HashSet<UnitworkccsTbldowntimedetails>();
        }

        public int DtcId { get; set; }
        public string Dtcategory { get; set; }
        public string DtcategoryDesc { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<UnitworkccsTbldowntimedetails> UnitworkccsTbldowntimedetails { get; set; }
    }
}
