using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.EntityModels;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.Controllers
{
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IVendor vendor;
        public VendorController(IVendor _vendor)
        {
            vendor = _vendor;
        }

        /// <summary>
        /// Upload Vendor Details
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        //[HttpPost]
        //[Route("Vendor/UploadVendorDetails")]
        //public async Task<IActionResult> UploadVendorDetails(List<VendorEntity> data)
        //{
        //    CommonResponse response = vendor.UploadVendorDetails(data);
        //    return Ok(response);
        //}

        ///// <summary>
        ///// View Vendor Details
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet]
        //[Route("Vendor/ViewVendorDetails")]
        //public async Task<IActionResult> ViewVendorDetails()
        //{
        //    CommonResponse response = vendor.ViewVendorDetails();
        //    return Ok(response);
        //}

        [HttpPost]
        [Route("VendorController/AddUpdateVendorDetails")]
        public async Task<IActionResult> AddUpdateVendorDetails(VendorEntity data)
        {
            CommonResponse response = vendor.AddUpdateVendorDetails(data);
            return Ok(response);
        }


        [HttpGet]
        [Route("VendorController/ViewMultipleVendorDetails")]
        public async Task<IActionResult> ViewMultipleVendorDetails()
        {
            CommonResponse response = vendor.ViewMultipleVendorDetails();
            return Ok(response);
        }


        [HttpGet]
        [Route("VendorController/ViewMultipleVendorDetailsById")]
        public async Task<IActionResult> ViewMultipleVendorDetailsById(int vendorId)
        {
            CommonResponse response = vendor.ViewMultipleVendorDetailsById(vendorId);
            return Ok(response);
        }


        [HttpGet]
        [Route("VendorController/DeleteVendorDetails")]
        public async Task<IActionResult> DeleteVendorDetails(int vendorId)
        {
            CommonResponse response = vendor.DeleteVendorDetails(vendorId);
            return Ok(response);
        }
    }
}
