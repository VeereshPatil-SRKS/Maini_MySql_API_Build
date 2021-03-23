using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblrejectqty
    {
        public int Rqid { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Rid { get; set; }
        public int? Woid { get; set; }
        public int? IsFinished { get; set; }
        public string CorrectedDate { get; set; }
        public int? ShiftId { get; set; }
        public int? RejectQty { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? IsDeleted { get; set; }

        public virtual Tblrejectreason R { get; set; }
        public virtual Tblworkorderentry Wo { get; set; }
    }
}
