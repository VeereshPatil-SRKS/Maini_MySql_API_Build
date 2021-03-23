using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.MasterChildFgPartNumEntity;

namespace IFacilityMaini.Controllers
{
    //[ApiController]
    //[Route("api/[controller]")]
    public class MasterChildFgPartNumController : ControllerBase
    {
        private readonly IMasterChildFgPartNum allChildFgPartMasters;
        public MasterChildFgPartNumController(IMasterChildFgPartNum _allChildFgPartMasters)
        {
            allChildFgPartMasters = _allChildFgPartMasters;
        }

        #region  1) CRUD operations of ChildFgPartNo
        /// <summary>
        /// AddUpdateChildFgPartNo
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("MasterChildFgPartNumController/AddUpdateChildFgPartNo")]
        public async Task<IActionResult> AddUpdateChildFgPartNo([FromBody] addChildfgPartNoDet data)
        {
            CommonResponse response = allChildFgPartMasters.AddUpdateChildFgPartNo(data);
            return Ok(response);
        }

        /// <summary>
        /// ViewMultipleChildFgPartNo
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("MasterChildFgPartNumController/ViewMultipleChildFgPartNo")]
        public async Task<IActionResult> ViewMultipleChildFgPartNo()
        {
            CommonResponse response = allChildFgPartMasters.ViewMultipleChildFgPartNo();
            return Ok(response);
        }

        /// <summary>
        /// ViewMultipleChildFgPartNoById
        /// </summary>
        /// <param name="childFgpartId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("MasterChildFgPartNumController/ViewMultipleChildFgPartNoById")]
        public async Task<IActionResult> ViewMultipleChildFgPartNoById(int childFgpartId)
        {
            CommonResponse response = allChildFgPartMasters.ViewMultipleChildFgPartNoById(childFgpartId);
            return Ok(response);
        }

        /// <summary>
        /// DeleteChildFgPartNo
        /// </summary>
        /// <param name="childFgpartId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("MasterChildFgPartNumController/DeleteChildFgPartNo")]
        public async Task<IActionResult> DeleteChildFgPartNo(int childFgpartId)
        {
            CommonResponse response = allChildFgPartMasters.DeleteChildFgPartNo(childFgpartId);
            return Ok(response);
        }
        #endregion

        #region  1) CRUD operations of FgAndCellAllocation

        ///// <summary>
        ///// AddUpdateFgAndCellAllocation
        ///// </summary>
        ///// <returns></returns>
        //[HttpPost]
        //[Route("MasterChildFgPartNumController/AddUpdateFgAndCellAllocation")]
        //public async Task<IActionResult> AddUpdateFgAndCellAllocation(addFgAndCellAllocationDet data)
        //{
        //    CommonResponse response = allChildFgPartMasters.AddUpdateFgAndCellAllocation(data);
        //    return Ok(response);
        //}

        /// <summary>
        /// ViewMultipleFgAndCellAllocation
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("MasterChildFgPartNumController/ViewMultipleFgAndCellAllocation")]
        public async Task<IActionResult> ViewMultipleFgAndCellAllocation()
        {
            CommonResponse response = allChildFgPartMasters.ViewMultipleFgAndCellAllocation();
            return Ok(response);
        }

        ///// <summary>
        ///// ViewMultipleFgAndCellAllocationById
        ///// </summary>
        ///// <param name="fgAndCellAllocationId"></param>
        ///// <returns></returns>
        //[HttpGet]
        //[Route("MasterChildFgPartNumController/ViewMultipleFgAndCellAllocationById")]
        //public async Task<IActionResult> ViewMultipleFgAndCellAllocationById(int fgAndCellAllocationId)
        //{
        //    CommonResponse response = allChildFgPartMasters.ViewMultipleFgAndCellAllocationById(fgAndCellAllocationId);
        //    return Ok(response);
        //}

        ///// <summary>
        ///// DeleteFgAndCellAllocation
        ///// </summary>
        ///// <param name="fgAndCellAllocationId"></param>
        ///// <returns></returns>
        //[HttpGet]
        //[Route("MasterChildFgPartNumController/DeleteFgAndCellAllocation")]
        //public async Task<IActionResult> DeleteFgAndCellAllocation(int fgAndCellAllocationId)
        //{
        //    CommonResponse response = allChildFgPartMasters.DeleteChildFgAndCellAllocation(fgAndCellAllocationId);
        //    return Ok(response);
        //}
        #endregion
    }
}
