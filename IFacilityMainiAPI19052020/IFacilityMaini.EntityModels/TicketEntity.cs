using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class TicketEntity
    {
        public class AddUpdateTicket
        {
            public int ticketId { get; set; }
            public int machineId { get; set; }
            public int operatorId { get; set; }
            public int classId { get; set; }
            public int statusId { get; set; }
            public int alarmId { get; set; }
            public int categoryId { get; set; }
            public int reasonId { get; set; }
            public string comments { get; set; }
        }

        public class ApproveOrRejectBySupportTeam
        {
            public int ticketId { get; set; }
            public int machineId { get; set; }
            public int supportTeamId { get; set; }
            public string reason { get; set; }
        }

        public class StatusOfTicket
        {
            public int ticketId { get; set; }
            public string className { get; set; }
            public int classId { get; set; }
            public string statusName { get; set; }
            public int statusId { get; set; }
            public int reasonId { get; set; }
            public string reasonName { get; set; }
            public string categoryName { get; set; }
            public int categoryId { get; set; }
            public string ticketNo { get; set; }
            public string ticketOpenDate { get; set; }
            public int operatorId { get; set; }
            public int status { get; set; }
            public string ticketStatus { get; set; }
            public int machineId { get; set; }
            public int maintainanceTeamAccept { get; set; }
            public string operatorReason { get; set; }
        }

        public class OperatorAccept
        {
            public int ticketId { get; set; }
            public string reason { get; set; }
            public int operatorId { get; set; }
            public int machineId { get; set; }
        }

        public class OperatorReject
        {
            public int ticketId { get; set; }
            public string reason { get; set; }
            public string commentsByOperator { get; set; }
            public int operatorId { get; set; }
            public int machineId { get; set; }
        }

        public class AcceptWithDeviation
        {
            public int ticketId { get; set; }
            public int operatorId { get; set; }
            public int machineId { get; set; }
            public string reason { get; set; }
        }

        public class ViewDetailsToOperator
        {
            public int ticketId { get; set; }
            public string className { get; set; }
            public int classId { get; set; }
            public string statusName { get; set; }
            public int statusId { get; set; }
            public int reasonId { get; set; }
            public string reasonName { get; set; }
            public string categoryName { get; set; }
            public int categoryId { get; set; }
            public string ticketNo { get; set; }
            public string ticketOpenDate { get; set; }
            public int operatorId { get; set; }
            public string operatorName { get; set; }
            public int status { get; set; }
            public string ticketStatus { get; set; }
            public int machineId { get; set; }
            public string machineName { get; set; }
            public string maintainanceName { get; set; }
            public string maintainanceTeamAcceptDate { get; set; }
            public string maintainanceTeamCloseDate { get; set; }
            public string commentsByOperator { get; set; }
            public string maintanceAcceptReason { get; set; }
            public string maintanceClosedReason { get; set; }
        }
    }
}
