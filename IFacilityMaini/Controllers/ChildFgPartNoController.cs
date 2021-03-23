using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.ChildFgPartNoEntity;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ChildFgPartNoController : ControllerBase
    {
        private readonly IChildFgPartNo childFgPartNo;
        public ChildFgPartNoController(IChildFgPartNo _childFgPartNo)
        {
            childFgPartNo = _childFgPartNo;
        }

        /// <summary>
        /// Upload Child Fg Part No
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ChildFgPartNo/UploadChildFgPartNo")]
        public async Task<IActionResult> UploadChildFgPartNo(List<UploadChildPartNo> data)
        {
            CommonResponse response = childFgPartNo.UploadChildFgPartNo(data);
            return Ok(response);
        }

        /// <summary>
        /// Add Child Fg Part No
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ChildFgPartNo/AddChildFgPartNo")]
        public async Task<IActionResult> AddChildFgPartNo(CustomChildPartNo data)
        {
            CommonResponse response = childFgPartNo.AddChildFgPartNo(data);
            return Ok(response);
        }

        /// <summary>
        /// View Multiple Child Fg Part No
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ChildFgPartNo/ViewMultipleChildFgPartNo")]
        public async Task<IActionResult> ViewMultipleChildFgPartNo()
        {
            CommonResponse response = childFgPartNo.ViewMultipleChildFgPartNo();
            return Ok(response);
        }

        /// <summary>
        /// Delete Child Fg Part No
        /// </summary>
        /// <param name="childFgPartId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ChildFgPartNo/DeleteChildFgPartNo")]
        public async Task<IActionResult> DeleteChildFgPartNo(int childFgPartId)
        {
            CommonResponse response = childFgPartNo.DeleteChildFgPartNo(childFgPartId);
            return Ok(response);
        }
    }
}
