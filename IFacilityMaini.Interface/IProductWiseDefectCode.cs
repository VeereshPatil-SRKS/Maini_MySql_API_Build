using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.ProductWiseDefectCodeEntity;

namespace IFacilityMaini.Interface
{
    public interface IProductWiseDefectCode
    {
        CommonResponse AddUpdateProductWiseDefectCode(List<AddEditProuctWiseDefectCodes> data);
        CommonResponse ViewMultipleProductWiseDefectCode();
        CommonResponse DeleteProductWiseDefectCode(int productWiseDefectCodeId);
        CommonResponse ViewMultiplePlantCodes();
        CommonResponse ViewMultiplePartName();
        CommonResponse ViewMultipleDefectCode();
        CommonResponse AddDefectCode(List<AddDefectCodes> data);
        CommonResponse AddGeneralDefectCodes(List<AddDefectCodes> data);
        CommonResponse DownloadProductWiseDefectCode();
        CommonResponse UploadProductWiseDefectCode(List<UploadProuctWiseDefectCodes> data);
    }
}
