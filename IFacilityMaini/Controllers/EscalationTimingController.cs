using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.EscalationTimingEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class EscalationTimingController : ControllerBase
    {
            private readonly IEscalationTiming EscTm;
            public EscalationTimingController(IEscalationTiming _EscTm)
            {
                EscTm = _EscTm;
            }

            /// <summary>
            /// View Multiple Plant 
            /// </summary>
            /// <returns></returns>
            [HttpGet]
            [Route("EscalationTiming/ViewMultipleCategory")]
            public async Task<IActionResult> ViewMultipleCategory()
            {
                CommonResponse response = EscTm.ViewMultipleCategory();
                return Ok(response);
            }

            /// <summary>
            /// Add And Update Machine Master
            /// </summary>
            /// <param name="data"></param>
            /// <returns></returns>
            [HttpPost]
            [Route("EscalationTiming/AddAndUpdateEscalationTiming")]
            public async Task<IActionResult> AddAndUpdateEscalationTiming(AddUpdateEscalationTm data)
            {
                CommonResponse response = EscTm.AddAndUpdateEscalationTiming(data);
                return Ok(response);
            }

            /// <summary>
            /// View Machine Details
            /// </summary>
            /// <returns></returns>
            [HttpGet]
            [Route("EscalationTiming/ViewEscalationTiming")]
            public async Task<IActionResult> ViewEscalationTiming()
            {
                CommonResponse response = EscTm.ViewEscalationTiming();
                return Ok(response);
            }

            /// <summary>
            /// View Machine Details By Id
            /// </summary>
            /// <param name="machineId"></param>
            /// <returns></returns>
            [HttpGet]
            [Route("EscalationTiming/ViewEscalationTimingById")]
            public async Task<IActionResult> ViewEscalationTimingById(int Id)
            {
                CommonResponse response = EscTm.ViewEscalationTimingById(Id);
                return Ok(response);
            }

            /// <summary>
            /// Delete Machine Details
            /// </summary>
            /// <param name="machineId"></param>
            /// <returns></returns>
            [HttpGet]
            [Route("EscalationTiming/DeleteEscalationTiming")]
            public async Task<IActionResult> DeleteEscalationTiming(int Id)
            {
                CommonResponse response = EscTm.DeleteEscalationTiming(Id);
                return Ok(response);
            }
        }
}