using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.EscationMatrixEntity;

namespace IFacilityMaini.Controllers
{

    [ApiController]
    public class EscalationMatrixController : ControllerBase
    {
        private readonly IEscationMatrix escationMatrix;
        public EscalationMatrixController(IEscationMatrix _escationMatrix)
        {
            escationMatrix = _escationMatrix;
        }

        /// <summary>
        /// Upload Escalation Matrix Details
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("EscalationMatrix/UploadEscalationMatrixDetails")]
        public async Task<IActionResult> UploadEscalationMatrixDetails(List<EscalationMatrixDetails> data)
        {
            CommonResponse response = escationMatrix.UploadEscalationMatrixDetails(data);
            return Ok(response);
        }

        /// <summary>
        /// Add And Edit Escalation Matrix
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("EscalationMatrix/AddAndEditEscalationMatrix")]
        public async Task<IActionResult> AddAndEditEscalationMatrix(EscalationMatrixCustom data)
        {
            CommonResponse response = escationMatrix.AddAndEditEscalationMatrix(data);
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Escalation Matrix
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("EscalationMatrix/ViewMultipleEscalationMatrix")]
        public async Task<IActionResult> ViewMultipleEscalationMatrix()
        {
            CommonResponse response = escationMatrix.ViewMultipleEscalationMatrix();
            return Ok(response);
        }

        /// <summary>
        /// View Escalation Matrix By Id
        /// </summary>
        /// <param name="escalationId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("EscalationMatrix/ViewEscalationMatrixById")]
        public async Task<IActionResult> ViewEscalationMatrixById(long escalationId)
        {
            CommonResponse response = escationMatrix.ViewEscalationMatrixById(escalationId);
            return Ok(response);
        }

        /// <summary>
        /// Delete Escalation Matrix
        /// </summary>
        /// <param name="escalationId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("EscalationMatrix/DeleteEscalationMatrix")]
        public async Task<IActionResult> DeleteEscalationMatrix(long escalationId)
        {
            CommonResponse response = escationMatrix.DeleteEscalationMatrix(escalationId);
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Roles
        /// </summary>
        /// <returns></returns>
        //[HttpGet]
        //[Route("EscalationMatrix/ViewMultipleRoles")]
        //public async Task<IActionResult> ViewMultipleRoles()
        //{
        //    CommonResponse response = escationMatrix.ViewMultipleRoles();
        //    return Ok(response);
        //}


        /// <summary>
        /// View Multiple Plants
        /// </summary>
        /// <returns></returns>
        //[HttpGet]
        //[Route("EscalationMatrix/ViewMultiplePlants")]
        //public async Task<IActionResult> ViewMultiplePlants()
        //{
        //    CommonResponse response = escationMatrix.ViewMultiplePlants();
        //    return Ok(response);
        //}

        [HttpGet]
        [Route("EscalationMatrix/ViewMultipleOperatorDetails")]
        public async Task<IActionResult> ViewMultipleOperatorDetails()
        {
            CommonResponse response = escationMatrix.ViewMultipleOperatorDetails();
            return Ok(response);
        }




        /// <summary>
        /// View Multiple Cell
        /// </summary>
        /// <param name="plantId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("EscalationMatrix/ViewMultipleCell")]
        public async Task<IActionResult> ViewMultipleCell()
        {
            CommonResponse response = escationMatrix.ViewMultipleCell();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Sub cell
        /// </summary>
        /// <param name="cellId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("EscalationMatrix/ViewMultipleSubcell")]
        public async Task<IActionResult> ViewMultipleSubcell(string cellId)
        {
            CommonResponse response = escationMatrix.ViewMultipleSubcell(cellId);
            return Ok(response);
        }


        /// <summary>
        /// View Multiple Category
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("EscalationMatrix/ViewMultipleCategory")]
        public async Task<IActionResult> ViewMultipleCategory()
        {
            CommonResponse response = escationMatrix.ViewMultipleCategory();
            return Ok(response);
        }

        [HttpGet]
        [Route("EscalationMatrix/ViewMultipleShift")]
        public async Task<IActionResult> ViewMultipleShift()
        {
            CommonResponse response = escationMatrix.ViewMultipleShift();
            return Ok(response);
        }

        [HttpPost]
        [Route("EscalationMatrix/DownloadEscalationMatrixDetails")]
        public async Task<IActionResult> DownloadEscalationMatrixDetails()
        {
            CommonResponse response = escationMatrix.DownloadEscalationMatrixDetails();
            return Ok(response);
        }
    }
}