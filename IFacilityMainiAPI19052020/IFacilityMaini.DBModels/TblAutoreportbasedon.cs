using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblAutoreportbasedon
    {
        public TblAutoreportbasedon()
        {
            TblAutoreportsetting = new HashSet<TblAutoreportsetting>();
        }

        public int BasedOnId { get; set; }
        public string BasedOn { get; set; }
        public string Desc { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }

        public virtual ICollection<TblAutoreportsetting> TblAutoreportsetting { get; set; }
    }
}
