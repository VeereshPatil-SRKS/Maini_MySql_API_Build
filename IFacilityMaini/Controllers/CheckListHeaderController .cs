using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CheckListHeaderEntity;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CheckListHeaderController : ControllerBase
    {
        private readonly ICheckListHeader checkListHeader;
        public CheckListHeaderController(ICheckListHeader _checkListHeader)
        {
            checkListHeader = _checkListHeader;
        }

        [HttpGet]
        [Route("CheckListHeader/ViewMultiplePlants")]
        public async Task<IActionResult> ViewMultiplePlants()
        {
            CommonResponse response = checkListHeader.ViewMultiplePlants();
            return Ok(response);
        }


        [HttpGet]
        [Route("CheckListHeader/ViewMultipleCategory")]
        public async Task<IActionResult> ViewMultipleCategory()
        {
            CommonResponse response = checkListHeader.ViewMultipleCategory();
            return Ok(response);
        }


        [HttpGet]
        [Route("CheckListHeader/ViewMultipleMake")]
        public async Task<IActionResult> ViewMultipleMake(int categoryId)
        {
            CommonResponse response = checkListHeader.ViewMultipleMake(categoryId);
            return Ok(response);
        }



        [HttpPost]
        [Route("CheckListHeader/GenerateCheckListNo")]
        public async Task<IActionResult> GenerateCheckListNo(genNo data)
        {
            CommonResponse response = checkListHeader.GenerateCheckListNo(data);
            return Ok(response);
        }


        [HttpPost]
        [Route("CheckListHeader/AddAndEditCheckListHeader")]
        public async Task<IActionResult> AddAndEditCheckListHeader(addHeader data)
        {
            CommonResponse response = checkListHeader.AddAndEditCheckListHeader(data);
            return Ok(response);
        }

        [HttpGet]
        [Route("CheckListHeader/ViewMultipleCheckListHeader")]
        public async Task<IActionResult> ViewMultipleCheckListHeader()
        {
            CommonResponse response = checkListHeader.ViewMultipleCheckListHeader();
            return Ok(response);
        }


        [HttpGet]
        [Route("CheckListHeader/ViewMultipleCheckListHeaderByOperatorId")]
        public async Task<IActionResult> ViewMultipleCheckListHeaderByOperatorId(int operatorId)
        {
            CommonResponse response = checkListHeader.ViewMultipleCheckListHeaderByOperatorId(operatorId);
            return Ok(response);
        }


        [HttpGet]
        [Route("CheckListHeader/ViewCheckListPlantId")]
        public async Task<IActionResult> ViewCheckListPlantId(int plantId)
        {
            CommonResponse response = checkListHeader.ViewCheckListPlantId(plantId);
            return Ok(response);
        }


        [HttpGet]
        [Route("CheckListHeader/ViewCheckListPlantCategoryId")]
        public async Task<IActionResult> ViewCheckListPlantCategoryId( int cateroryId)
        {
            CommonResponse response = checkListHeader.ViewCheckListPlantCategoryId(cateroryId);
            return Ok(response);
        }

        [HttpGet]
        [Route("CheckListHeader/ViewCheckListHeaderId")]
        public async Task<IActionResult> ViewCheckListHeaderId(int HeaderId)
        {
            CommonResponse response = checkListHeader.ViewCheckListHeaderId(HeaderId);
            return Ok(response);
        }


        [HttpGet]
        [Route("CheckListHeader/SendCheckListToApprover")]
        public async Task<IActionResult> SendCheckListToApprover(int HeaderId)
        {
            CommonResponse response = checkListHeader.SendCheckListToApprover(HeaderId);
            return Ok(response);
        }



        [HttpGet]
        [Route("CheckListHeader/DeleteCheckListHeader")]
        public async Task<IActionResult> DeleteCheckListHeader(int HeaderId)
        {
            CommonResponse response = checkListHeader.DeleteCheckListHeader(HeaderId);
            return Ok(response);
        }


        [HttpGet]
        [Route("CheckListHeader/ViewMultipleHeaderIds")]
        public async Task<IActionResult> ViewMultipleHeaderIds(int makeId)
        {
            CommonResponse response = checkListHeader.ViewMultipleHeaderIds(makeId);
            return Ok(response);
        }



        [HttpGet]
        [Route("CheckListHeader/ViewMultiplePlantNames")]
        public async Task<IActionResult> ViewMultiplePlantNames()
        {
            CommonResponse response = checkListHeader.ViewMultiplePlantNames();
            return Ok(response);
        }


        [HttpGet]
        [Route("CheckListHeader/ViewMultipleCategoryNames")]
        public async Task<IActionResult> ViewMultipleCategoryNames(int PlantId)
        {
            CommonResponse response = checkListHeader.ViewMultipleCategoryNames(PlantId);
            return Ok(response);
        }


        [HttpGet]
        [Route("CheckListHeader/ViewMultipleMakeNames")]
        public async Task<IActionResult> ViewMultipleMakeNames(int categoryId)
        {
            CommonResponse response = checkListHeader.ViewMultipleMakeNames(categoryId);
            return Ok(response);
        }

        [HttpGet]
        [Route("CheckListHeader/ViewMultipleMachineList")]
        public async Task<IActionResult> ViewMultipleMachineList(int makeId, int categoryId)
        {
            CommonResponse response = checkListHeader.ViewMultipleMachineList(makeId, categoryId);
            return Ok(response);
        }

        [HttpPost]
        [Route("CheckListHeader/AddAndEditHeaderMachines")]
        public async Task<IActionResult> AddAndEditHeaderMachines(addMachines data)
        {
            CommonResponse response = checkListHeader.AddAndEditHeaderMachines(data);
            return Ok(response);
        }

        [HttpGet]
        [Route("CheckListHeader/ViewMultipleHeaderMachines")]
        public async Task<IActionResult> ViewMultipleHeaderMachines()
        {
            CommonResponse response = checkListHeader.ViewMultipleHeaderMachines();
            return Ok(response);
        }


        [HttpGet]
        [Route("CheckListHeader/DeleteHeaderMachine")]
        public async Task<IActionResult> DeleteHeaderMachine(int HeaderId)
        {
            CommonResponse response = checkListHeader.DeleteHeaderMachine(HeaderId);
            return Ok(response);
        }

        [HttpGet]
        [Route("CheckListHeader/FulldetailsForRevButton")]
        public async Task<IActionResult> FulldetailsForRevButton(int headerId)
        {
            CommonResponse response = checkListHeader.FulldetailsForRevButton(headerId);
            return Ok(response);
        }

        /// <summary>
        /// Update Check List Header
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CheckListHeader/UpdateCheckListHeader")]
        public async Task<IActionResult> UpdateCheckListHeader(addHeader data)
        {
            CommonResponse response = checkListHeader.UpdateCheckListHeader(data);
            return Ok(response);
        }
    }
}
