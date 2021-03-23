using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class TblTicketRaisedDet
    {
        public int TicketRaisedDetId { get; set; }
        public int? TicketId { get; set; }
        public string TicketNo { get; set; }
        public int? OperatorId { get; set; }
        public int? SupportTeamId { get; set; }
        public int? IsStatus { get; set; }
        public DateTime? SupportTeamAckDate { get; set; }
        public DateTime? SupportTeamClosureDate { get; set; }
        public int? IfOperatorAccepts { get; set; }
        public DateTime? OperatorAcceptRejectDate { get; set; }
        public string Reason { get; set; }
        public string CommentsByOperator { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
