using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CheckListDetailsEntity;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.Interface
{
    public interface ICheckListDetails
    {
        CommonResponse AddAndEditCheckListDetails(addCheckList data);
        CommonResponse ViewMultipleCheckListDetails();
        CommonResponseWithStatus ViewMultipleCheckListDetailsByHeaderId(int headerId);

        CommonResponseWithStatus ForREVIconViewMultipleCheckListDetailsByHeaderId(int headerId);

        CommonResponse ViewCheckListById(int id);
        CommonResponse DeleteCheckListDetails(int id);
        CommonResponse ApprovedCheckList(approveDet data);

        CommonResponse UploadCheckListDetails(uploadCK data);
        CommonResponse DownLoadCheckListDetails(int headerId);
        


    }
}
