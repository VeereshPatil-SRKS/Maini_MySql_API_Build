using IFacilityMaini.EntityModels;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.Controllers
{
        [ApiController]
        public class ToolNameMasterController : ControllerBase
        {
            private readonly IToolNameMaster toolNameMaster;
            public ToolNameMasterController(IToolNameMaster _toolNameMaster)
            {
                toolNameMaster = _toolNameMaster;
            }

            /// <summary>
            /// Upload AddUpdateToolNameMaster
            /// </summary>
            /// <param name="data"></param>
            /// <returns></returns>
            /// 
            [HttpPost]
            [Route("ToolNameMasterController/AddUpdateToolNameMaster")]
            public async Task<IActionResult> AddUpdateToolNameMaster(ToolNameMasterEntity data)
            {
                CommonResponse response = toolNameMaster.AddUpdateToolNameMaster(data);
                return Ok(response);
            }

            /// <summary>
            ///  ViewToolNameMaster
            /// </summary>
            /// <param name="data"></param>
            /// <returns></returns>
            /// 
            [HttpGet]
            [Route("ToolNameMasterController/ViewToolNameMaster")]
            public async Task<IActionResult> ViewToolNameMaster()
            {
                CommonResponse response = toolNameMaster.ViewToolNameMaster();
                return Ok(response);
            }
            /// <summary>
            ///  ViewToolNameMasterById
            /// </summary>
            /// <param name="data"></param>
            /// <returns></returns>
            /// 
            [HttpGet]
            [Route("ToolNameMasterController/ViewToolNameMasterById")]
            public async Task<IActionResult> ViewToolNameMasterById(int toolId)
            {
                CommonResponse response = toolNameMaster.ViewToolNameMasterById(toolId);
                return Ok(response);
            }
            /// <summary>
            ///  DeleteToolNameMaster
            /// </summary>
            /// <param name="data"></param>
            /// <returns></returns>
            /// 
            [HttpGet]
            [Route("ToolNameMasterController/DeleteToolNameMaster")]
            public async Task<IActionResult> DeleteToolNameMaster(int toolId)
            {
                CommonResponse response = toolNameMaster.DeleteToolNameMaster(toolId);
                return Ok(response);
            }
        }
}
