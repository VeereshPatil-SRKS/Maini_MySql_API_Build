using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.TicketEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicket ticket;
        public TicketController(ITicket _ticket)
        {
            ticket = _ticket;
        }

        /// <summary>
        /// View Multiple Category
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Ticket/ViewMultipleCategory")]
        public async Task<IActionResult> ViewMultipleCategory()
        {
            CommonResponse response = ticket.ViewMultipleCategory();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Class
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Ticket/ViewMultipleClass")]
        public async Task<IActionResult> ViewMultipleClass()
        {
            CommonResponse response = ticket.ViewMultipleClass();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Status
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Ticket/ViewMultipleStatus")]
        public async Task<IActionResult> ViewMultipleStatus()
        {
            CommonResponse response = ticket.ViewMultipleStatus();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Reasons
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Ticket/ViewMultipleReasons")]
        public async Task<IActionResult> ViewMultipleReasons(int CategoryId)
        {
            CommonResponse response = ticket.ViewMultipleReasons(CategoryId);
            return Ok(response);
        }

        /// <summary>
        /// Add Update Ticket
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Ticket/AddUpdateTicket")]
        public async Task<IActionResult> AddUpdateTicket(AddUpdateTicket data)
        {

            CommonResponseWithIds response = ticket.AddUpdateTicket(data);
            return Ok(response);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Ticket/ViewIssuedTickets")]
        public async Task<IActionResult> ViewIssuedTickets(int supportTeamId)
        {
            CommonResponse response = ticket.ViewIssuedTickets(supportTeamId);
            return Ok(response);
        }

        /// <summary>
        /// Support Team Accept Ack
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Ticket/SupportTeamAcceptAck")]
        public async Task<IActionResult> SupportTeamAcceptAck(ApproveOrRejectBySupportTeam data)
        {

            CommonResponse response = ticket.SupportTeamAcceptAck(data);
            return Ok(response);
        }

        /// <summary>
        /// Support Team Close Ack
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Ticket/SupportTeamCloseAck")]
        public async Task<IActionResult> SupportTeamCloseAck(ApproveOrRejectBySupportTeam data)
        {
            CommonResponse response = ticket.SupportTeamCloseAck(data);
            return Ok(response);
        }

        /// <summary>
        /// View Tickets To Operator
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Ticket/ViewTicketsToOperator")]
        public async Task<IActionResult> ViewTicketsToOperator(int operatorId)
        {
            CommonResponse response = ticket.ViewTicketsToOperator(operatorId);
            return Ok(response);
        }

        /// <summary>
        /// Operator Accepts Acknowledge
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Ticket/OperatorAcceptsAck")]
        public async Task<IActionResult> OperatorAcceptsAck(OperatorAccept data)
        {
            CommonResponse response = ticket.OperatorAcceptsAck(data);
            return Ok(response);
        }

        /// <summary>
        /// Operator Reject Acknowledge
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Ticket/OperatorRejectAck")]
        public async Task<IActionResult> OperatorRejectAck(OperatorReject data)
        {
            CommonResponse response = ticket.OperatorRejectAck(data);
            return Ok(response);
        }

        /// <summary>
        /// View Tickets To Maintainance Team
        /// </summary>
        /// <param name="HostName"></param>
        /// <param name="IpAddress"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Ticket/ViewTicketsToMaintainanceTeam")]
        public async Task<IActionResult> ViewTicketsToMaintainanceTeam(string HostName, string IpAddress)
        {
            CommonResponse response = ticket.ViewTicketsToMaintainanceTeam( HostName, IpAddress);
            return Ok(response);
        }

        /// <summary>
        /// View Tickets For Operator
        /// </summary>
        /// <param name="machineId"></param>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Ticket/ViewTicketsForOperator")]
        public async Task<IActionResult> ViewTicketsForOperator(int machineId, int operatorId)
        {
            CommonResponse response = ticket.ViewTicketsForOperator(machineId, operatorId);
            return Ok(response);
        }

        /// <summary>
        /// Close Ticket (Accept With Deviation)
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Ticket/CloseTicket")]
        public async Task<IActionResult> CloseTicket(AcceptWithDeviation data)
        {
            CommonResponse response = ticket.CloseTicket(data);
            return Ok(response);
        }
    }
}