using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblrejectreason
    {
        public Tblrejectreason()
        {
            Tblrejectqty = new HashSet<Tblrejectqty>();
        }

        public int Rid { get; set; }
        public string RejectName { get; set; }
        public string RejectNameDesc { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string CorrectedDate { get; set; }
        public int? Cellid { get; set; }
        public int? Machineid { get; set; }
        public int IsMaint { get; set; }
        public int IsProd { get; set; }

        public virtual Tblcell Cell { get; set; }
        public virtual Tblmachinedetails Machine { get; set; }
        public virtual ICollection<Tblrejectqty> Tblrejectqty { get; set; }
    }
}
