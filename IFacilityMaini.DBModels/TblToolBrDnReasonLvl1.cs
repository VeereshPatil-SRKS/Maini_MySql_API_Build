using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblToolBrDnReasonLvl1
    {
        public int Id { get; set; }
        public int ReasonId { get; set; }
        public string ReasonName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
