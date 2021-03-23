//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using IFacilityMaini.EntityModels;
//using IFacilityMaini.Interface;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using static IFacilityMaini.EntityModels.CommonEntity;

//namespace IFacilityMaini.Controllers
//{
//    //[Route("api/[controller]")]
//    [ApiController]
//    public class VendorController : ControllerBase
//    {
//        private readonly IVendor vendor;
//        public VendorController(IVendor _vendor)
//        {
//            vendor = _vendor;
//        }

//        /// <summary>
//        /// Upload Vendor Details
//        /// </summary>
//        /// <param name="data"></param>
//        /// <returns></returns>
//        [HttpPost]
//        [Route("Vendor/UploadVendorDetails")]
//        public async Task<IActionResult> UploadVendorDetails(List<VendorEntity> data)
//        {
//            CommonResponse response = vendor.UploadVendorDetails(data);
//            return Ok(response);
//        }

//        /// <summary>
//        /// View Vendor Details
//        /// </summary>
//        /// <returns></returns>
//        [HttpGet]
//        [Route("Vendor/ViewVendorDetails")]
//        public async Task<IActionResult> ViewVendorDetails()
//        {
//            CommonResponse response = vendor.ViewVendorDetails();
//            return Ok(response);
//        }
//    }
//}
