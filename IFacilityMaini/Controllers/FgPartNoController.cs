using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.FgPartNoEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class FgPartNoController : ControllerBase
    {
        private readonly IFgPartNo fgPartNo;
        public FgPartNoController(IFgPartNo _fgPartNo)
        {
            fgPartNo = _fgPartNo;
        }

        /// <summary>
        /// Get Fg Part Details
        /// </summary>
        /// <param name="machineId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("FgPartNo/GetFgPartDetails")]
        public async Task<IActionResult> GetFgPartDetails(int machineId)
        {
            CommonResponse response = fgPartNo.GetFgPartDetails(machineId);
            return Ok(response);
        }

        /// <summary>
        /// Get WorkOrder No
        /// </summary>
        /// <param name="machineId"></param>
        /// <returns></returns>
        //[HttpGet]
        //[Route("FgPartNo/GetWorkOrderNo")]
        //public async Task<IActionResult> GetWorkOrderNo(int machineId)
        //{
        //    CommonResponse response = fgPartNo.GetWorkOrderNo(machineId);
        //    return Ok(response);
        //}


        ///// <summary>
        ///// View Multiple Part No
        ///// </summary>
        ///// <param name="ProductionOrder"></param>
        ///// <returns></returns>
        //[HttpGet]
        //[Route("FgPartNo/ViewMultiplePartNo")]
        //public async Task<IActionResult> ViewMultiplePartNo(string ProductionOrder, int PlanLinkageId)
        //{
        //    CommonResponse response = fgPartNo.ViewMultiplePartNo(ProductionOrder, PlanLinkageId);
        //    return Ok(response);
        //}

        ///// <summary>
        ///// Get Operation No
        ///// </summary>
        ///// <param name="FgPartNo"></param>
        ///// <returns></returns>
        //[HttpGet]
        //[Route("FgPartNo/GetOperationNo")]
        //public async Task<IActionResult> GetOperationNo(string FgPartNo, int PlanLinkageId)
        //{
        //    CommonResponse response = fgPartNo.GetOperationNo(FgPartNo, PlanLinkageId);
        //    return Ok(response);
        //}

        ///// <summary>
        ///// Get WorkOrder Qty
        ///// </summary>
        ///// <param name="operationNo"></param>
        ///// <returns></returns>
        //[HttpGet]
        //[Route("FgPartNo/GetWorkOrderQty")]
        //public async Task<IActionResult> GetWorkOrderQty(int operationNo, int PlanLinkageId)
        //{
        //    CommonResponse response = fgPartNo.GetWorkOrderQty(operationNo, PlanLinkageId);
        //    return Ok(response);
        //}

        ///// <summary>
        ///// View Multiple Part No
        ///// </summary>
        ///// <param name="opearationNo"></param>
        ///// <returns></returns>
        //[HttpGet]
        //[Route("FgPartNo/ViewMultiplePartNo")]
        //public async Task<IActionResult> ViewMultiplePartNo(int opearationNo, int machineId)
        //{
        //    CommonResponse response = fgPartNo.ViewMultiplePartNo(opearationNo, machineId);
        //    return Ok(response);
        //}

        /// <summary>
        /// Add Update Fg Part No
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("FgPartNo/AddUpdateFgPartNo")]
        public async Task<IActionResult> AddUpdateFgPartNo(AddUpdateFgPartNo data)
        {
            GeneralResponse response = fgPartNo.AddUpdateFgPartNo(data);
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Fg Part No
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("FgPartNo/ViewMultipleFgPartNo")]
        public async Task<IActionResult> ViewMultipleFgPartNo(int machineId)
        {
            CommonResponse response = fgPartNo.ViewMultipleFgPartNo(machineId);
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Fg Part No By Id
        /// </summary>
        /// <param name="fgPartId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("FgPartNo/ViewMultipleFgPartNoById")]
        public async Task<IActionResult> ViewMultipleFgPartNoById(int fgPartId)
        {
            CommonResponse response = fgPartNo.ViewMultipleFgPartNoById(fgPartId);
            return Ok(response);
        }

        /// <summary>
        /// Close Fg Part No
        /// </summary>
        /// <param name="fgPartId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("FgPartNo/CloseFgPartNo")]
        public async Task<IActionResult> CloseFgPartNo(int fgPartId)
        {
            CommonResponse response = fgPartNo.CloseFgPartNo(fgPartId);
            return Ok(response);
        }
    }
}