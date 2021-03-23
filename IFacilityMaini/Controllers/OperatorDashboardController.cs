using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class OperatorDashboardController : ControllerBase
    {
        private readonly IOperatorDashboard operatorDashboard;
        public OperatorDashboardController(IOperatorDashboard _operatorDashboard)
        {
            operatorDashboard = _operatorDashboard;
        }

        /// <summary>
        /// Redirect The Page
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("OperatorDashboard/RedirectThePage")]
        public async Task<IActionResult> RedirectThePage(string HostName, string IpAddress)
        {
            //calling DepartmentDAL busines layer
            CommonResponse response = operatorDashboard.RedirectThePage(HostName, IpAddress);
            return Ok(response);
        }

        /// <summary>
        /// Get The Machine Details
        /// </summary>
        /// <param name="HostName"></param>
        /// <param name="IpAddress"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("OperatorDashboard/GetTheMachineDetails")]
        public async Task<IActionResult> GetTheMachineDetails(string HostName, string IpAddress)
        {
            //calling DepartmentDAL busines layer
            CommonResponseGraph response = operatorDashboard.GetTheMachineDetails(HostName, IpAddress);
            return Ok(response);
        }

        /// <summary>
        /// Get Ip Address And HostName
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("OperatorDashboard/GetIpAddressAndHostName")]
        public async Task<IActionResult> GetIpAddressAndHostName()
        {
            //calling DepartmentDAL busines layer
            CommonResponse response = operatorDashboard.GetIpAddressAndHostName();
            return Ok(response);
        }

        /// <summary>
        /// Graph Details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("OperatorDashboard/GraphDetails")]
        public async Task<IActionResult> GraphDetails(int machineId)
        {
            //calling DepartmentDAL busines layer
            ResponseMessage response = operatorDashboard.GraphDetails(machineId);
            return Ok(response);
        }

        ///// <summary>
        ///// Check Mac Idle And Send To Msg
        ///// </summary>
        ///// <param name="machineId"></param>
        ///// <returns></returns>
        //[HttpGet]
        //[Route("OperatorDashboard/CheckMacIdleAndSendToMsg")]
        //public async Task<IActionResult> CheckMacIdleAndSendToMsg(int machineId)
        //{
        //    //calling DepartmentDAL busines layer
        //    CommonResponse response = operatorDashboard.CheckMacIdleAndSendToMsg(machineId);
        //    return Ok(response);
        //}

        [HttpGet]
        [Route("OperatorDashboard/ToolLifeManagement")]
        public async Task<IActionResult>ToolLifeManagement(int machineId)
        {
            //calling DepartmentDAL busines layer
            CommonResponse response = operatorDashboard.ToolLifeManagement(machineId);
            return Ok(response);
        }
    }
}