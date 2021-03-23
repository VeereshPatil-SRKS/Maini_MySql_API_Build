using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblpmsdetails
    {
        public int Pmsid { get; set; }
        public int MachineId { get; set; }
        public string PmstartDate { get; set; }
        public string PmendDate { get; set; }
        public int? IsCompleted { get; set; }
        public int? IsSubmitted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }
    }
}
