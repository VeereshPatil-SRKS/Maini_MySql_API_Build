using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.OperatorEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class OperatorController : ControllerBase
    {
        private readonly IOperator operators;
        public OperatorController(IOperator _operators)
        {
            operators = _operators;
        }

        /// <summary>
        /// View Multiple Departments
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Operator/ViewMultipleDepartments")]
        public async Task<IActionResult> ViewMultipleDepartments()
        {
            CommonResponse response = operators.ViewMultipleDepartments();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Category Details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Operator/ViewMultipleCategoryDetails")]
        public async Task<IActionResult> ViewMultipleCategoryDetails()
        {
            CommonResponse response = operators.ViewMultipleCategoryDetails();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Business
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Operator/ViewMultipleBusiness")]
        public async Task<IActionResult> ViewMultipleBusiness()
        {
            CommonResponse response = operators.ViewMultipleBusiness();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Part Name
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Operator/ViewMultipleRoles")]
        public async Task<IActionResult> ViewMultipleRoles()
        {
            CommonResponse response = operators.ViewMultipleRoles();
            return Ok(response);
        }


        ///// <summary>
        ///// View Multiple category
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet]
        //[Route("Operator/ViewMultiplecategory")]
        //public async Task<IActionResult> ViewMultiplecategory()
        //{
        //    CommonResponse response = operators.ViewMultipleCategory();
        //    return Ok(response);
        //}

        /// <summary>
        /// View Multiple Plants
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Operator/ViewMultiplePlants")]
        public async Task<IActionResult> ViewMultiplePlants()
        {
            CommonResponse response = operators.ViewMultiplePlants();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple cell
        /// </summary>
        /// <param name="plantId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Operator/ViewMultiplecell")]
        public async Task<IActionResult> ViewMultiplecell(int plantId)
        {
            CommonResponse response = operators.ViewMultipleCell(plantId);
            return Ok(response);
        }

        /// <summary>
        /// View Multiple sub cell
        /// </summary>
        /// <param name="cellId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Operator/ViewMultiplesubcell")]
        public async Task<IActionResult> ViewMultiplesubcell(int cellId)
        {
            CommonResponse response = operators.ViewMultipleSubcell(cellId);
            return Ok(response);
        }

        ///// <summary>
        ///// View Multiple machine name
        ///// </summary>
        ///// <param name="cellId"></param>
        ///// <param name="subCellId"></param>
        ///// <returns></returns>
        //[HttpGet]
        //[Route("Operator/ViewMultiplemachinename")]
        //public async Task<IActionResult> ViewMultiplemachinename(int cellId, int subCellId)
        //{
        //    CommonResponse response = operators.ViewMultipleMachinename(cellId, subCellId);
        //    return Ok(response);
        //}


        /// <summary>
        /// Add Update Operator
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Operator/AddUpdateOperator")]
        public async Task<IActionResult>AddUpdateOperator(AddUpdateOperator data)
        {
            CommonResponse response = operators.AddUpdateOperator(data);
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Operator
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Operator/ViewMultipleOperator")]
        public async Task<IActionResult> ViewMultipleOperator()
        {
            CommonResponse response = operators.ViewMultipleOperator();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Operator By Id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Operator/ViewMultipleOperatorById")]
        public async Task<IActionResult> ViewMultipleOperatorById(int opId)
        {
            CommonResponse response = operators.ViewMultipleOperatorById(opId);
            return Ok(response);
        }

        /// <summary>
        /// Delete Operator
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Operator/DeleteOperator")]
        public async Task<IActionResult> DeleteOperator(int opId)
        {
            CommonResponse response = operators.DeleteOperator(opId);
            return Ok(response);
        }

        /// <summary>
        /// Upload Operators
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Operator/UploadOperators")]
        public async Task<IActionResult> UploadOperators(List<OperatorCustom> data)
        {
            CommonResponse response = operators.UploadOperators(data);
            return Ok(response);
        }

        [HttpPost]
        [Route("Operator/DownLoadOperatorsDetails")]
        public async Task<IActionResult> DownLoadOperatorsDetails()
        {
            CommonResponse response = operators.DownLoadOperatorsDetails();
            return Ok(response);
        }
    }
}
