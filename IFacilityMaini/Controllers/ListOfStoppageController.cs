using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.ListOfStoppageEntity;
using static IFacilityMaini.EntityModels.ProductWiseDefectCodeEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ListOfStoppageController : ControllerBase
    {
        private readonly IListOfStoppage listOfStoppage;
        public ListOfStoppageController(IListOfStoppage _listOfStoppage)
        {
            listOfStoppage = _listOfStoppage;
        }

        /// <summary>
        /// Add Update List Of Stoppage
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ListOfStoppage/AddUpdateListOfStoppage")]
        public async Task<IActionResult> AddUpdateListOfStoppage(List<AddAndEditStoppage> data)
        {
            //calling DepartmentDAL busines layer
            CommonResponse response = listOfStoppage.AddUpdateListOfStoppage(data);
            return Ok(response);
        }

        /// <summary>
        /// View Multiple List Of Stoppage
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ListOfStoppage/ViewMultipleListOfStoppage")]
        public async Task<IActionResult> ViewMultipleListOfStoppage()
        {
            //calling DepartmentDAL busines layer
            CommonResponse response = listOfStoppage.ViewMultipleListOfStoppage();
            return Ok(response);
        }

        /// <summary>
        /// Delete List Of Stoppage
        /// </summary>
        /// <param name="stoppagesId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ListOfStoppage/DeleteListOfStoppage")]
        public async Task<IActionResult> DeleteListOfStoppage(int stoppagesId)
        {
            //calling DepartmentDAL busines layer
            CommonResponse response = listOfStoppage.DeleteListOfStoppage(stoppagesId);
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Sources
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ListOfStoppage/ViewMultipleSources")]
        public async Task<IActionResult> ViewMultipleSources()
        {
            //calling DepartmentDAL busines layer
            CommonResponse response = listOfStoppage.ViewMultipleSources();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Category
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ListOfStoppage/ViewMultipleCategory")]
        public async Task<IActionResult> ViewMultipleCategory()
        {
            //calling DepartmentDAL busines layer
            CommonResponse response = listOfStoppage.ViewMultipleCategory();
            return Ok(response);
        }

        [HttpPost]
        [Route("ListOfStoppage/DownloadListOfStoppageDetails")]
        public async Task<IActionResult> DownloadListOfStoppageDetails()
        {
            CommonResponse response = listOfStoppage.DownloadListOfStoppageDetails();
            return Ok(response);
        }

        /// <summary>
        /// Upload List Of Stoppage
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ListOfStoppage/UploadListOfStoppage")]
        public async Task<IActionResult> UploadListOfStoppage(List<UploadStoppage> data)
        {
            CommonResponse response = listOfStoppage.UploadListOfStoppage(data);
            return Ok(response);
        }
    }
}