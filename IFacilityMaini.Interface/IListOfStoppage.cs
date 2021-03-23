using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.ListOfStoppageEntity;

namespace IFacilityMaini.Interface
{
    public interface IListOfStoppage
    {
        CommonResponse AddUpdateListOfStoppage(List<AddAndEditStoppage> data);
        CommonResponse ViewMultipleListOfStoppage();
        CommonResponse DeleteListOfStoppage(int stoppagesId);
        CommonResponse ViewMultipleSources();
        CommonResponse ViewMultipleCategory();
        CommonResponse DownloadListOfStoppageDetails();
        CommonResponse UploadListOfStoppage(List<UploadStoppage> data);
    }
}
