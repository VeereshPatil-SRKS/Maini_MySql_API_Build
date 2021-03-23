using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblSmsDetails
    {
        public int SmsId { get; set; }
        public int? MachineId { get; set; }
        public string ContactNo { get; set; }
        public int? TicketId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }
        public string ResponseId { get; set; }
        public string IdleResponseId { get; set; }
        public int? IdleSms { get; set; }
        public string Shift { get; set; }
        public string Message { get; set; }
        public string CorrectedDate { get; set; }
    }
}
