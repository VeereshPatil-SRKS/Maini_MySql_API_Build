using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.TicketEntity;

namespace IFacilityMaini.Interface
{
    public interface ITicket
    {
        CommonResponse ViewMultipleCategory();
        CommonResponse ViewMultipleClass();
        CommonResponse ViewMultipleStatus();
        CommonResponse ViewMultipleReasons(int CategoryId);
        CommonResponseWithIds AddUpdateTicket(AddUpdateTicket data);
        CommonResponse ViewIssuedTickets(int supportTeamId);
        CommonResponse SupportTeamAcceptAck(ApproveOrRejectBySupportTeam data);
        CommonResponse SupportTeamCloseAck(ApproveOrRejectBySupportTeam data);
        CommonResponse ViewTicketsToOperator(int operatorId);
        CommonResponse OperatorAcceptsAck(OperatorAccept data);
        CommonResponse OperatorRejectAck(OperatorReject data);
        CommonResponse ViewTicketsToMaintainanceTeam(string HostName, string IpAddress);
        CommonResponse ViewTicketsForOperator(int machineId, int operatorId);
        CommonResponse CloseTicket(AcceptWithDeviation data);
    }
}
