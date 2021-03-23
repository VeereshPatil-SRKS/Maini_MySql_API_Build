using IFacilityMaini.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.Interface
{
    public interface IVendor
    {
        CommonResponse UploadVendorDetails(List<VendorEntity> data);
        CommonResponse ViewVendorDetails();
        CommonResponse AddUpdateVendorDetails(VendorEntity data);
        CommonResponse ViewMultipleVendorDetails();
        CommonResponse ViewMultipleVendorDetailsById(int VendorId);
        CommonResponse DeleteVendorDetails(int VendorId);
    }
}
