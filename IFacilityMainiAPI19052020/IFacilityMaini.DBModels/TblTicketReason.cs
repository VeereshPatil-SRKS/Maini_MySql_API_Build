using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblTicketReason
    {
        public int TktReasonId { get; set; }
        public string ReasonName { get; set; }
        public string ReasonDesc { get; set; }
        public int? CategoryId { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
