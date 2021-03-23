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


        /// <summary>
        /// View Multiple category
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Operator/ViewMultiplecategory")]
        public async Task<IActionResult> ViewMultiplecategory()
        {
            CommonResponse response = operators.ViewMultipleCategory();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple shift
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Operator/ViewMultipleshift")]
        public async Task<IActionResult> ViewMultipleshift()
        {
            CommonResponse response = operators.ViewMultipleShift();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple cell
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Operator/ViewMultiplecell")]
        public async Task<IActionResult> ViewMultiplecell()
        {
            CommonResponse response = operators.ViewMultipleCell();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple subcell
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Operator/ViewMultiplesubcell")]
        public async Task<IActionResult> ViewMultiplesubcell()
        {
            CommonResponse response = operators.ViewMultipleSubcell();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple machineMame
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Operator/ViewMultiplemachinename")]
        public async Task<IActionResult> ViewMultiplemachinename()
        {
            CommonResponse response = operators.ViewMultipleMachinename();
            return Ok(response);
        }


        /// <summary>
        /// Add Update Operator
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Operator/AddUpdateOperator")]
        public async Task<IActionResult>AddUpdateOperator(List<AddUpdateOperator> data)
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


    }
}
