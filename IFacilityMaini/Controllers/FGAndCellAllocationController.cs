using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.FGAndCellAllocationEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class FGAndCellAllocationController : ControllerBase
    {
        private readonly IFGAndCellAllocation fgAndCellAllocation;
        public FGAndCellAllocationController(IFGAndCellAllocation _fgAndCellAllocation)
        {
            fgAndCellAllocation = _fgAndCellAllocation;
        }

        /// <summary>
        /// View Multiple Plant Codes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("FGAndCellAllocation/ViewMultiplePlantCodes")]
        public async Task<IActionResult> ViewMultiplePlantCodes()
        {
            CommonResponse response = fgAndCellAllocation.ViewMultiplePlantCodes();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Part Name
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("FGAndCellAllocation/ViewMultiplePartName")]
        public async Task<IActionResult> ViewMultiplePartName()
        {
            CommonResponse response = fgAndCellAllocation.ViewMultiplePartName();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Cell Final
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("FGAndCellAllocation/ViewMultipleCellFinal")]
        public async Task<IActionResult> ViewMultipleCellFinal()
        {
            CommonResponse response = fgAndCellAllocation.ViewMultipleCellFinal();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Sub Cell Final
        /// </summary>
        /// <param name="cellFinalId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("FGAndCellAllocation/ViewMultipleSubCellFinal")]
        public async Task<IActionResult> ViewMultipleSubCellFinal(int cellFinalId)
        {
            CommonResponse response = fgAndCellAllocation.ViewMultipleSubCellFinal(cellFinalId);
            return Ok(response);
        }

        /// <summary>
        /// Add Update Fg And Cell Allocation
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("FGAndCellAllocation/AddUpdateFgAndCellAllocation")]
        public async Task<IActionResult> AddUpdateFgAndCellAllocation(List<AddUpdateFgCellAllocation> data)
        {
            CommonResponse response = fgAndCellAllocation.AddUpdateFgAndCellAllocation(data);
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Fg And Cell Allocation
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("FGAndCellAllocation/ViewMultipleFgAndCellAllocation")]
        public async Task<IActionResult> ViewMultipleFgAndCellAllocation()
        {
            CommonResponse response = fgAndCellAllocation.ViewMultipleFgAndCellAllocation();
            return Ok(response);
        }

        /// <summary>
        /// Delete Fg And Cell Allocation
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("FGAndCellAllocation/DeleteFgAndCellAllocation")]
        public async Task<IActionResult> DeleteFgAndCellAllocation(int fgAndCellAllocationId)
        {
            CommonResponse response = fgAndCellAllocation.DeleteFgAndCellAllocation(fgAndCellAllocationId);
            return Ok(response);
        }

        /// <summary>
        /// Upload Plan Linkage Master
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("FGAndCellAllocation/UploadPlanLinkageMaster")]
        public async Task<IActionResult> UploadPlanLinkageMaster(List<ReadPlanLinkage> data)
        {
            CommonResponse response = fgAndCellAllocation.UploadPlanLinkageMaster(data);
            return Ok(response);
        }

        /// <summary>
        /// Read Plan Visage Master
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("FGAndCellAllocation/ReadPlanVisageMaster")]
        public async Task<IActionResult> ReadPlanVisageMaster()
        {
            CommonResponse response = fgAndCellAllocation.ReadPlanVisageMaster();
            return Ok(response);
        }

        [HttpGet]
        [Route("FGAndCellAllocation/DownloadFGpartCellAllocation")]
        public async Task<IActionResult> DownloadFGpartCellAllocation()
        {
            CommonResponse response = fgAndCellAllocation.DownloadFGpartCellAllocation();
            return Ok(response);
        }

        /// <summary>
        /// Upload Fg And Cell Allocation
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("FGAndCellAllocation/UploadFgAndCellAllocation")]
        public async Task<IActionResult> UploadFgAndCellAllocation(List<UploadFgAndCellAllocation> data)
        {
            CommonResponse response = fgAndCellAllocation.UploadFgAndCellAllocation(data);
            return Ok(response);
        }
    }
}