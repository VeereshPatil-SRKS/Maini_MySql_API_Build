using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblRaisedTicket
    {
        public int TicketId { get; set; }
        public string TicketNo { get; set; }
        public int? MachineId { get; set; }
        public DateTime? TicketOpenDate { get; set; }
        public int? OperatorId { get; set; }
        public int? PartId { get; set; }
        public int? ClassId { get; set; }
        public int? CategoryId { get; set; }
        public int? StatusId { get; set; }
        public int? ReasonId { get; set; }
        public int? RoleId { get; set; }
        public int? Status { get; set; }
        public string Comments { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public string CorrectedDate { get; set; }
        public DateTime? TicketClosedDate { get; set; }
        public int? AlarmId { get; set; }
    }
}
