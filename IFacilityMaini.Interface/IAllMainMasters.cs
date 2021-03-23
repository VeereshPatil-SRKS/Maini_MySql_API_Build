using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.AllMainMastersEntity;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.Interface
{
    public interface IAllMainMasters
    {
        #region 1) Plant  Master
        CommonResponse AddUpdatePlant(addPlantDet data);
        CommonResponse ViewMultiplePlant();


        CommonResponse ViewMultiplePlantById(int plantId);



        CommonResponse DeletePlant(int plantId);

        #endregion

        #region 2) Cell  Master
        CommonResponse AddUpdateCell(addCellDet data);
        CommonResponse ViewMultipleCell();


        CommonResponse ViewMultipleCellByPlantId(int plantId);



        CommonResponse DeleteCell(int cellId);

        #endregion


        #region 3) Sub Cell  Master
        CommonResponse AddUpdateSubCell(addSubCellDet data);
        CommonResponse ViewMultipleSubCell();


        CommonResponse ViewMultipleSubCellByCellId(int cellId);



        CommonResponse DeleteSubCell(int subCellId);

        #endregion

        #region 4) Defect code  Master
        CommonResponse AddUpdateDefectCode(addDefectCodeDet data);
        CommonResponse ViewMultipleDefectCode();

        CommonResponse DeleteDefectCode(int id);

        #endregion


        #region 5) Category Master  Master
        CommonResponse AddUpdateCategoryMaster(addCategoryMasterDet data);
        CommonResponse ViewMultipleCategoryMaster();

        CommonResponse DeleteCategoryMaster(int id);

        #endregion


        #region 6) Roles Master
        CommonResponse AddUpdateRoles(addRolesDet data);
        CommonResponse ViewMultipleRoles();

        CommonResponse DeleteRoles(int id);

        #endregion

        #region 7) Business Master
        CommonResponse AddUpdateBusiness(addBusinessDet data);
        CommonResponse ViewMultipleBusiness();

        CommonResponse DeleteBusiness(int id);

        #endregion

        #region 8) Department Master
        CommonResponse AddUpdateDepartment(addDepartmentDet data);
        CommonResponse ViewMultipleDepartment();

        CommonResponse DeleteDepartment(int id);

        #endregion

        #region 9) Employee Category Master
        CommonResponse AddUpdateEmployeeCategory(addEmpCategoryDet data);
        CommonResponse ViewMultipleEmployeeCategory();

        CommonResponse DeleteEmployeeCategory(int id);

        #endregion


        #region 10) Machine Category  Master
        CommonResponse AddUpdateMachineCategory(addMacCatDet data);
        CommonResponse ViewMultipleMachineCategory();
        CommonResponse ViewMultipleMachineCategoryByPlantId(int plantId);
        CommonResponse DeleteMachineCategory(int id);

        #endregion

        #region 11) Machine Make  Master
        CommonResponse AddUpdateMachineMake(addMacMakeDet data);
        CommonResponse ViewMultipleMachineMake();
        CommonResponse ViewMultipleMachineMakeByPlantIdCategoryId(int plantId, int categoryId);
        CommonResponse DeleteMachineMake(int id);

        #endregion

        #region 12)  No Of Axis Master
        CommonResponse AddUpdateNoOfAxis(addAxisDet data);
        CommonResponse ViewMultipleNoOfAxis();

        CommonResponse DeleteNoOfAxis(int id);

        #endregion


        #region 13) Fall Stock Availability Master
        CommonResponse AddUpdateFallStockAvailability(addFallStockDet data);
        CommonResponse ViewMultipleFallStockAvailability();

        CommonResponse DeleteFallStockAvailability(int id);

        #endregion

        #region 14)  Pallet Master
        CommonResponse AddUpdatePallet(addPalletDet data);
        CommonResponse ViewMultiplePallet();

        CommonResponse DeletePallet(int id);

        #endregion

    }
}
