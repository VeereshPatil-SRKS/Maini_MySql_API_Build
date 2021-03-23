using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.WimarasysEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class WimarasysController : ControllerBase
    {
        private readonly IWimarasys wimarasys;
        public WimarasysController(IWimarasys _wimarasys)
        {
            wimarasys = _wimarasys;
        }

        /// <summary>
        /// Get Operation No Based On PartNo
        /// </summary>
        /// <param name="partNo"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Wimarasys/GetOperationNoBasedOnPartNo")]
        public async Task<IActionResult> GetOperationNoBasedOnPartNo(string woNo)
        {
            CommonResponse response = wimarasys.GetOperationNoBasedOnPartNo(woNo);
            return Ok(response);
        }

        /// <summary>
        /// Get Running Balance
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Wimarasys/GetRunningBalance")]
        public async Task<IActionResult> GetRunningBalance(GetRunningQuantityCustom data)
        {
            CommonResponse response = wimarasys.GetRunningBalance(data);
            return Ok(response);
        }

        /// <summary>
        /// Get Wo Number
        /// </summary>
        /// <param name="partNo"></param>
        /// <param name="machineNo"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Wimarasys/GetWoNumber")]
        public async Task<IActionResult> GetWoNumber(string partNo)
        {
            CommonResponse response = wimarasys.GetWoNumber(partNo);
            return Ok(response);
        }

        /// <summary>
        /// Defect Codes
        /// </summary>
        /// <param name="partNo"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Wimarasys/DefectCodes")]
        public async Task<IActionResult> DefectCodes(string partNo)
        {
            CommonResponse response = wimarasys.DefectCodes(partNo);
            return Ok(response);
        }

        /// <summary>
        /// Get Part No Deatails
        /// </summary>
        /// <param name="partNo"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Wimarasys/GetPartNoDeatails")]
        public async Task<IActionResult> GetPartNoDeatails(string partNo)
        {
            CommonResponse response = wimarasys.GetPartNoDeatails(partNo);
            return Ok(response);
        }

        /// <summary>
        /// Get General Defect Codes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Wimarasys/GetGeneralDefectCodes")]
        public async Task<IActionResult> GetGeneralDefectCodes()
        {
            CommonResponse response = wimarasys.GetGeneralDefectCodes();
            return Ok(response);
        }





        /// <summary>
        /// Get Fg Part No
        /// </summary>
        /// <param name="plantId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Wimarasys/GetFgPartNo")]
        public async Task<IActionResult> GetFgPartNo(int plantId)
        {
            CommonResponse response = wimarasys.GetFgPartNo(plantId);
            return Ok(response);
        }

        /// <summary>
        /// Get Child Part No
        /// </summary>
        /// <param name="partNo"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Wimarasys/GetChildPartNo")]
        public async Task<IActionResult> GetChildPartNo(string partNo)
        {
            CommonResponse response = wimarasys.GetChildPartNo(partNo);
            return Ok(response);
        }

        /// <summary>
        /// Get Machine List
        /// </summary>
        /// <param name="plantId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Wimarasys/GetMachineList")]
        public async Task<IActionResult> GetMachineList(int plantId)
        {
            CommonResponse response = wimarasys.GetMachineList(plantId);
            return Ok(response);
        }

    }
}
