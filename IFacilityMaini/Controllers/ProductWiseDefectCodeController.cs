using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.ProductWiseDefectCodeEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ProductWiseDefectCodeController : ControllerBase
    {

        private readonly IProductWiseDefectCode productWiseDefectCode;
        public ProductWiseDefectCodeController(IProductWiseDefectCode _productWiseDefectCode)
        {
            productWiseDefectCode = _productWiseDefectCode;
        }

        /// <summary>
        /// AddUpdateProductWiseDefectCode
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ProductWiseDefectCode/AddUpdateProductWiseDefectCode")]
        public async Task<IActionResult> AddUpdateProductWiseDefectCode(List<AddEditProuctWiseDefectCodes> data)
        {
            
            CommonResponse response = productWiseDefectCode.AddUpdateProductWiseDefectCode(data);
            return Ok(response);
        }

        /// <summary>
        /// ViewMultipleProductWiseDefectCode
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ProductWiseDefectCode/ViewMultipleProductWiseDefectCode")]
        public async Task<IActionResult> ViewMultipleProductWiseDefectCode()
        {
            //calling DepartmentDAL busines layer
            CommonResponse response = productWiseDefectCode.ViewMultipleProductWiseDefectCode();
            return Ok(response);
        }

        /// <summary>
        /// DeleteProductWiseDefectCode
        /// </summary>
        /// <param name="productWiseDefectCodeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ProductWiseDefectCode/DeleteProductWiseDefectCode")]
        public async Task<IActionResult> DeleteProductWiseDefectCode(int productWiseDefectCodeId)
        {
            //calling DepartmentDAL busines layer
            CommonResponse response = productWiseDefectCode.DeleteProductWiseDefectCode(productWiseDefectCodeId);
            return Ok(response);
        }

        [HttpGet]
        [Route("ProductWiseDefectCode/ViewMultiplePlantCodes")]
        public async Task<IActionResult> ViewMultiplePlantCodes()
        {
            //calling DepartmentDAL busines layer
            CommonResponse response = productWiseDefectCode.ViewMultiplePlantCodes();
            return Ok(response);
        }

        [HttpGet]
        [Route("ProductWiseDefectCode/ViewMultiplePartName")]
        public async Task<IActionResult> ViewMultiplePartName()
        {
            //calling DepartmentDAL busines layer
            CommonResponse response = productWiseDefectCode.ViewMultiplePartName();
            return Ok(response);
        }

        [HttpGet]
        [Route("ProductWiseDefectCode/ViewMultipleDefectCode")]
        public async Task<IActionResult> ViewMultipleDefectCode()
        {
            //calling DepartmentDAL busines layer
            CommonResponse response = productWiseDefectCode.ViewMultipleDefectCode();
            return Ok(response);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ProductWiseDefectCode/AddDefectCode")]
        public async Task<IActionResult> AddDefectCode(List<AddDefectCodes> data)
        {
            //calling DepartmentDAL busines layer
            CommonResponse response = productWiseDefectCode.AddDefectCode(data);
            return Ok(response);
        }

        /// <summary>
        /// Add General Defect Codes
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ProductWiseDefectCode/AddGeneralDefectCodes")]
        public async Task<IActionResult> AddGeneralDefectCodes(List<AddDefectCodes> data)
        {
            //calling DepartmentDAL busines layer
            CommonResponse response = productWiseDefectCode.AddGeneralDefectCodes(data);
            return Ok(response);
        }

        [HttpPost]
        [Route("ProductWiseDefectCode/DownloadProductWiseDefectCode")]
        public async Task<IActionResult> DownloadProductWiseDefectCode()
        {
            //calling DepartmentDAL busines layer
            CommonResponse response = productWiseDefectCode.DownloadProductWiseDefectCode();
            return Ok(response);
        }

        /// <summary>
        /// Upload Product Wise Defect Code
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ProductWiseDefectCode/UploadProductWiseDefectCode")]
        public async Task<IActionResult> UploadProductWiseDefectCode(List<UploadProuctWiseDefectCodes> data)
        {
            //calling DepartmentDAL busines layer
            CommonResponse response = productWiseDefectCode.UploadProductWiseDefectCode(data);
            return Ok(response);
        }
    }
}