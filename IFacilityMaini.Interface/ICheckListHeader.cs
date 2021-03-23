using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CheckListHeaderEntity;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.Interface
{
    public interface ICheckListHeader
    {
        CommonResponse ViewMultiplePlants();
        CommonResponse ViewMultipleCategory();
        CommonResponse ViewMultipleMake(int categoryId);
        CommonResponse GenerateCheckListNo(genNo data);
        CommonResponse AddAndEditCheckListHeader(addHeader data);
        CommonResponse ViewMultipleCheckListHeader();
        CommonResponse ViewMultipleCheckListHeaderByOperatorId(int operatorId);
        CommonResponse ViewCheckListPlantId(int plantId);
        CommonResponse ViewCheckListPlantCategoryId(int cateroryId);
        CommonResponse ViewCheckListHeaderId(int HeaderId);
        CommonResponse SendCheckListToApprover(int HeaderId);
        CommonResponse DeleteCheckListHeader(int HeaderId);
        CommonResponse ViewMultipleHeaderIds(int makeId);
        CommonResponse ViewMultiplePlantNames();
        CommonResponse ViewMultipleCategoryNames(int PlantId);
        CommonResponse ViewMultipleMakeNames(int categoryId);
        CommonResponse ViewMultipleMachineList(int makeId, int categoryId);
        CommonResponse AddAndEditHeaderMachines(addMachines data);
        CommonResponse ViewMultipleHeaderMachines();
        CommonResponse DeleteHeaderMachine(int HeaderId);
        CommonResponse FulldetailsForRevButton(int headerId);
        CommonResponse UpdateCheckListHeader(addHeader data);
    }
}
