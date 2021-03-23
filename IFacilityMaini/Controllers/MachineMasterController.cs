using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.MachineMasterEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class MachineMasterController : ControllerBase
    {
        private readonly IMachineMaster machineMaster;
        public MachineMasterController(IMachineMaster _machineMaster)
        {
            machineMaster = _machineMaster;
        }

        /// <summary>
        /// View Multiple Plant
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("MachineMaster/ViewMultiplePlant")]
        public async Task<IActionResult> ViewMultiplePlant()
        {
            CommonResponse response = machineMaster.ViewMultiplePlant();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Cell
        /// </summary>
        /// <param name="plantId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("MachineMaster/ViewMultipleCell")]
        public async Task<IActionResult> ViewMultipleCell(int plantId)
        {
            CommonResponse response = machineMaster.ViewMultipleCell(plantId);
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Sub Cell
        /// </summary>
        /// <param name="shopId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("MachineMaster/ViewMultipleSubCell")]
        public async Task<IActionResult> ViewMultipleSubCell(int shopId)
        {
            CommonResponse response = machineMaster.ViewMultipleSubCell(shopId);
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Machine Category
        /// </summary>
        /// <param name="plantId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("MachineMaster/ViewMultipleMachineCategory")]
        public async Task<IActionResult> ViewMultipleMachineCategory(int plantId)
        {
            CommonResponse response = machineMaster.ViewMultipleMachineCategory(plantId);
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Make
        /// </summary>
        /// <param name="machineCategoryId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("MachineMaster/ViewMultipleMake")]
        public async Task<IActionResult> ViewMultipleMake(int machineCategoryId)
        {
            CommonResponse response = machineMaster.ViewMultipleMake(machineCategoryId);
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Tall Stock Availibility
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("MachineMaster/ViewMultipleTallStockAvailibility")]
        public async Task<IActionResult> ViewMultipleTallStockAvailibility()
        {
            CommonResponse response = machineMaster.ViewMultipleTallStockAvailibility();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple No Of Axis()
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("MachineMaster/ViewMultipleNoOfAxis")]
        public async Task<IActionResult> ViewMultipleNoOfAxis()
        {
            CommonResponse response = machineMaster.ViewMultipleNoOfAxis();
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Pallet
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("MachineMaster/ViewMultiplePallet")]
        public async Task<IActionResult> ViewMultiplePallet()
        {
            CommonResponse response = machineMaster.ViewMultiplePallet();
            return Ok(response);
        }

        /// <summary>
        /// Add And Update Machine Master
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("MachineMaster/AddAndUpdateMachineMaster")]
        public async Task<IActionResult> AddAndUpdateMachineMaster(AddUpdateMachine data)
        {
            CommonResponse response = machineMaster.AddAndUpdateMachineMaster(data);
            return Ok(response);
        }

        /// <summary>
        /// View Machine Details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("MachineMaster/ViewMachineDetails")]
        public async Task<IActionResult> ViewMachineDetails()
        {
            CommonResponse response = machineMaster.ViewMachineDetails();
            return Ok(response);
        }

        /// <summary>
        /// View Machine Details By Id
        /// </summary>
        /// <param name="machineId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("MachineMaster/ViewMachineDetailsById")]
        public async Task<IActionResult> ViewMachineDetailsById(int machineId)
        {
            CommonResponse response = machineMaster.ViewMachineDetailsById(machineId);
            return Ok(response);
        }

        /// <summary>
        /// Delete Machine Details
        /// </summary>
        /// <param name="machineId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("MachineMaster/DeleteMachineDetails")]
        public async Task<IActionResult> DeleteMachineDetails(int machineId)
        {
            CommonResponse response = machineMaster.DeleteMachineDetails(machineId);
            return Ok(response);
        }

        /// <summary>
        /// Upload Machine Master
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("MachineMaster/UploadMachineMaster")]
        public async Task<IActionResult> UploadMachineMaster(List<UploadMachine> data)
        {
            CommonResponse response = machineMaster.UploadMachineMaster(data);
            return Ok(response);
        }

        /// <summary>
        /// Download Machine Master
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("MachineMaster/DownloadMachineMaster")]
        public async Task<IActionResult> DownloadMachineMaster()
        {
            CommonResponse response = machineMaster.DownloadMachineMaster();
            return Ok(response);
        }
    }
}