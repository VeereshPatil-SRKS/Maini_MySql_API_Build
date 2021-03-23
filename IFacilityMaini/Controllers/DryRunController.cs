using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.DryRunEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class DryRunController : ControllerBase
    {
        private readonly IDryRun dryRun;
        public DryRunController(IDryRun _dryRun)
        {
            dryRun = _dryRun;
        }

        [HttpPost]
        [Route("DryRun/AddDryRun")]
        public async Task<IActionResult> AddDryRun(DryRunDetails data)
        {
            CommonResponseWithIds response = dryRun.AddDryRun(data);
            return Ok(response);
        }

        /// <summary>
        /// Close Dry Run
        /// </summary>
        /// <param name="dryRunId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("DryRun/CloseDryRun")]
        public async Task<IActionResult> CloseDryRun(int dryRunId, int userId)
        {
            CommonResponse response = dryRun.CloseDryRun(dryRunId, userId);
            return Ok(response);
        }

        [HttpGet]
        [Route("DryRun/AutomaticCloseDryRun")]
        public async Task<IActionResult> AutomaticCloseDryRun(int dryRunId)
        {
            CommonResponse response = dryRun.AutomaticCloseDryRun(dryRunId);
            return Ok(response);
        }
    }
}