using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CheckListDetailsEntity;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CheckListDetailsController : ControllerBase
    {
        private readonly ICheckListDetails checkListDetails;
        public CheckListDetailsController(ICheckListDetails _checkListDetails)
        {
            checkListDetails = _checkListDetails;
        }

        [HttpPost]
        [Route("CheckListDetails/AddAndEditCheckListDetails")]
        public async Task<IActionResult> AddAndEditCheckListDetails(addCheckList data)
        {
            CommonResponse response = checkListDetails.AddAndEditCheckListDetails(data);
            return Ok(response);
        }

        [HttpGet]
        [Route("CheckListDetails/ViewMultipleCheckListDetails")]
        public async Task<IActionResult> ViewMultipleCheckListDetails()
        {
            CommonResponse response = checkListDetails.ViewMultipleCheckListDetails();
            return Ok(response);
        }


        [HttpGet]
        [Route("CheckListDetails/ViewMultipleCheckListDetailsByHeaderId")]
        public async Task<IActionResult> ViewMultipleCheckListDetailsByHeaderId(int headerId)
        {
            CommonResponseWithStatus response = checkListDetails.ViewMultipleCheckListDetailsByHeaderId(headerId);
            return Ok(response);
        }



        [HttpGet]
        [Route("CheckListDetails/ForREVIconViewMultipleCheckListDetailsByHeaderId")]
        public async Task<IActionResult> ForREVIconViewMultipleCheckListDetailsByHeaderId(int headerId)
        {
            CommonResponseWithStatus response = checkListDetails.ForREVIconViewMultipleCheckListDetailsByHeaderId(headerId);
            return Ok(response);
        }



        [HttpGet]
        [Route("CheckListDetails/ViewCheckListById")]
        public async Task<IActionResult> ViewCheckListById(int id)
        {
            CommonResponse response = checkListDetails.ViewCheckListById(id);
            return Ok(response);
        }

        [HttpGet]
        [Route("CheckListDetails/DeleteCheckListDetails")]
        public async Task<IActionResult> DeleteCheckListDetails(int id)
        {
            CommonResponse response = checkListDetails.DeleteCheckListDetails(id);
            return Ok(response);
        }

        [HttpPost]
        [Route("CheckListDetails/ApprovedCheckList")]
        public async Task<IActionResult> ApprovedCheckList(approveDet data)
        {
            CommonResponse response = checkListDetails.ApprovedCheckList(data);
            return Ok(response);
        }


        [HttpPost]
        [Route("CheckListDetails/UploadCheckListDetails")]
        public async Task<IActionResult> UploadCheckListDetails(uploadCK data)
        {
            CommonResponse response = checkListDetails.UploadCheckListDetails(data);
            return Ok(response);
        }

        [HttpPost]
        [Route("CheckListDetails/DownLoadCheckListDetails")]
        public async Task<IActionResult> DownLoadCheckListDetails(int headerId)
        {
            CommonResponse response = checkListDetails.DownLoadCheckListDetails(headerId);
            return Ok(response);
        }



    }
}
