using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.PMSDashBoardEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class PMSDashBoardController : ControllerBase
    {
        private readonly IPMSDashBoard pmdash;
        public PMSDashBoardController(IPMSDashBoard _pmdash)
        {
            pmdash = _pmdash;
        }

        [HttpPost]
        [Route("PMSDash/ApproveCheckList")]
        public async Task<IActionResult> ApproveCheckList(approveDetPM data)
        {
            CommonResponse response = pmdash.ApproveCheckList(data);
            return Ok(response);
        }

        [HttpGet]
        [Route("PMSDash/ViewMultipleCheckListHeaderPMS")]
        public async Task<IActionResult> ViewMultipleCheckListHeaderPMS()
        {
            CommonResponse response = pmdash.ViewMultipleCheckListHeaderPMS();
            return Ok(response);
        }

        [HttpGet]
        [Route("PMSDash/ViewMultipleCheckListDetailsPMS")]
        public async Task<IActionResult> ViewMultipleCheckListDetailsPMS(int headerId)
        {
            CommonResponse response = pmdash.ViewMultipleCheckListDetailsPMS(headerId);
            return Ok(response);
        }
    }
}
