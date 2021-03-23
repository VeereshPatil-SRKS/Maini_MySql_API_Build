using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.ReworkAndRejectionEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ReworkAndRejectionController : ControllerBase
    {
        private readonly IReworkAndRejection reworkAndRejection;
        public ReworkAndRejectionController(IReworkAndRejection _reworkAndRejection)
        {
            reworkAndRejection = _reworkAndRejection;
        }

        /// <summary>
        /// View Multiple Defect Code
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ReworkAndRejection/ViewMultipleDefectCode")]
        public async Task<IActionResult> ViewMultipleDefectCode(int fgPartId, int machineId)
        {
            CommonResponse response = reworkAndRejection.ViewMultipleDefectCode(fgPartId, machineId);
            return Ok(response);
        }

        /// <summary>
        /// Add Rejection Details
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ReworkAndRejection/AddRejectionDetails")]
        public async Task<IActionResult> AddRejectionDetails(AddRejection data)
        {
            CommonResponse response = reworkAndRejection.AddRejectionDetails(data);
            return Ok(response);
        }

        /// <summary>
        /// Delete Rejection Details
        /// </summary>
        /// <param name="rejectionId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ReworkAndRejection/DeleteRejectionDetails")]
        public async Task<IActionResult> DeleteRejectionDetails(int rejectionId)
        {
            CommonResponse response = reworkAndRejection.DeleteRejectionDetails(rejectionId);
            return Ok(response);
        }

        /// <summary>
        /// View Rejection Details
        /// </summary>
        /// <param name="machineId"></param>
        /// <param name="fgPartId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ReworkAndRejection/ViewRejectionDetails")]
        public async Task<IActionResult> ViewRejectionDetails(int machineId, int fgPartId)
        {
            CommonResponse response = reworkAndRejection.ViewRejectionDetails(machineId, fgPartId);
            return Ok(response);
        }

        /// <summary>
        /// Add Rework Details
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ReworkAndRejection/AddReworkDetails")]
        public async Task<IActionResult> AddReworkDetails(AddRework data)
        {
            CommonResponse response = reworkAndRejection.AddReworkDetails(data);
            return Ok(response);
        }

        /// <summary>
        /// Delete Rework Details
        /// </summary>
        /// <param name="reworkId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ReworkAndRejection/DeleteReworkDetails")]
        public async Task<IActionResult> DeleteReworkDetails(int reworkId)
        {
            CommonResponse response = reworkAndRejection.DeleteReworkDetails(reworkId);
            return Ok(response);
        }

        /// <summary>
        /// View Rework Details
        /// </summary>
        /// <param name="machineId"></param>
        /// <param name="fgPartId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ReworkAndRejection/ViewReworkDetails")]
        public async Task<IActionResult> ViewReworkDetails(int machineId, int fgPartId)
        {
            CommonResponse response = reworkAndRejection.ViewReworkDetails(machineId, fgPartId);
            return Ok(response);
        }
    }
}