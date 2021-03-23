using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.ToolLifeEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ToolLifeController : ControllerBase
    {
        private readonly IToolLife toolLife;
        public ToolLifeController(IToolLife _toolLife)
        {
            toolLife = _toolLife;
        }

        /// <summary>
        /// ScanToolData
        /// </summary>
        /// <param name="toolNumber"></param>
        /// <param name="machineId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ToolLife/ScanToolData")]
        public async Task<ActionResult> ScanToolData(string toolNumber, int machineId, string fgCode)
        {
            CommonResponse commonResponse = new CommonResponse();
            commonResponse = toolLife.ScanToolData(toolNumber, machineId,fgCode);
            return Ok(commonResponse);
        }

        /// <summary>
        /// Add And Edit Tool And Socket Details
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("ToolLife/AddAndEditToolAndSocketDetails")]
        public async Task<IActionResult> AddAndEditToolAndSocketDetails(TblToolAndSocketDetailsCustom data)
        {
            //calling DepartmentDAL busines layer
            CommonResponse response = toolLife.AddAndEditToolAndSocketDetails(data);
            return Ok(response);
        }

        /// <summary>
        /// GetToolLife
        /// </summary>
        /// <param name="socketNumber"></param>
        /// <param name="machineId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ToolLife/GetToolLife")]
        public async Task<ActionResult> GetToolLife(string socketNumber, int machineId)
        {
            CommonResponse commonResponse = new CommonResponse();
            commonResponse = toolLife.GetToolLife(socketNumber, machineId);
            return Ok(commonResponse);
        }

        /// <summary>
        /// DeleteToolFromSocket
        /// </summary>
        /// <param name="socketNumber"></param>
        /// <param name="machineId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ToolLife/DeleteToolFromSocket")]
        public async Task<ActionResult> DeleteToolFromSocket(string socketNumber, int machineId)
        {
            CommonResponse commonResponse = new CommonResponse();
            commonResponse = toolLife.DeleteToolFromSocket(socketNumber, machineId);
            return Ok(commonResponse);
        }
    }
}