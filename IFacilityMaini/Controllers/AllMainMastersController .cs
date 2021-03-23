using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.AllMainMastersEntity;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class AllMainMastersController : ControllerBase
    {
        private readonly IAllMainMasters allMasters;
        public AllMainMastersController(IAllMainMasters _allMasters)
        {
            allMasters = _allMasters;
        }


        #region 1)plant Master CRUD operation


        [HttpPost]
        [Route("AllMainMasters/AddUpdatePlant")]
        public async Task<IActionResult> AddUpdatePlant(addPlantDet data)
        {
            CommonResponse response = allMasters.AddUpdatePlant(data);
            return Ok(response);
        }


        [HttpGet]
        [Route("AllMainMasters/ViewMultiplePlant")]
        public async Task<IActionResult> ViewMultiplePlant()
        {
            CommonResponse response = allMasters.ViewMultiplePlant();
            return Ok(response);
        }


        [HttpGet]
        [Route("AllMainMasters/ViewMultiplePlantById")]
        public async Task<IActionResult> ViewMultiplePlantById(int plantId)
        {
            CommonResponse response = allMasters.ViewMultiplePlantById(plantId);
            return Ok(response);
        }


        [HttpGet]
        [Route("AllMainMasters/DeletePlant")]
        public async Task<IActionResult> DeletePlant(int plantId)
        {
            CommonResponse response = allMasters.DeletePlant(plantId);
            return Ok(response);
        }


        #endregion


        #region 2) Cell Master CRUD operation


        [HttpPost]
        [Route("AllMainMasters/AddUpdateCell")]
        public async Task<IActionResult> AddUpdateCell(addCellDet data)
        {
            CommonResponse response = allMasters.AddUpdateCell(data);
            return Ok(response);
        }


        [HttpGet]
        [Route("AllMainMasters/ViewMultipleCell")]
        public async Task<IActionResult> ViewMultipleCell()
        {
            CommonResponse response = allMasters.ViewMultipleCell();
            return Ok(response);
        }

        [HttpGet]
        [Route("AllMainMasters/DeleteCell")]
        public async Task<IActionResult> DeleteCell(int cellId)
        {
            CommonResponse response = allMasters.DeleteCell(cellId);
            return Ok(response);
        }


        // this API for Drop down by Plant Id
        [HttpGet]
        [Route("AllMainMasters/ViewMultipleCellByPlantId")]
        public async Task<IActionResult> ViewMultipleCellByPlantId(int plantId)
        {
            CommonResponse response = allMasters.ViewMultipleCellByPlantId(plantId);
            return Ok(response);
        }



        #endregion



        #region 3) SubCell Master CRUD operation

        [HttpPost]
        [Route("AllMainMasters/AddUpdateSubCell")]
        public async Task<IActionResult> AddUpdateSubCell(addSubCellDet data)
        {
            CommonResponse response = allMasters.AddUpdateSubCell(data);
            return Ok(response);
        }


        [HttpGet]
        [Route("AllMainMasters/ViewMultipleSubCell")]
        public async Task<IActionResult> ViewMultipleSubCell()
        {
            CommonResponse response = allMasters.ViewMultipleSubCell();
            return Ok(response);
        }

        [HttpGet]
        [Route("AllMainMasters/DeleteSubCell")]
        public async Task<IActionResult> DeleteSubCell(int subCellId)
        {
            CommonResponse response = allMasters.DeleteSubCell(subCellId);
            return Ok(response);
        }


        // this API for Drop down by Cell Id
        [HttpGet]
        [Route("AllMainMasters/ViewMultipleSubCellByCellId")]
        public async Task<IActionResult> ViewMultipleSubCellByCellId(int cellId)
        {
            CommonResponse response = allMasters.ViewMultipleSubCellByCellId(cellId);
            return Ok(response);
        }


        #endregion


        #region 4) Defect Code Master CRUD operation


        [HttpPost]
        [Route("AllMainMasters/AddUpdateDefectCode")]
        public async Task<IActionResult> AddUpdateDefectCode(addDefectCodeDet data)
        {
            CommonResponse response = allMasters.AddUpdateDefectCode(data);
            return Ok(response);
        }


        [HttpGet]
        [Route("AllMainMasters/ViewMultipleDefectCode")]
        public async Task<IActionResult> ViewMultipleDefectCode()
        {
            CommonResponse response = allMasters.ViewMultipleDefectCode();
            return Ok(response);
        }



        [HttpGet]
        [Route("AllMainMasters/DeleteDefectCode")]
        public async Task<IActionResult> DeleteDefectCode(int id)
        {
            CommonResponse response = allMasters.DeleteDefectCode(id);
            return Ok(response);
        }


        #endregion

        #region 5) Category Master CRUD operation


        [HttpPost]
        [Route("AllMainMasters/AddUpdateCategoryMaster")]
        public async Task<IActionResult> AddUpdateCategoryMaster(addCategoryMasterDet data)
        {
            CommonResponse response = allMasters.AddUpdateCategoryMaster(data);
            return Ok(response);
        }


        [HttpGet]
        [Route("AllMainMasters/ViewMultipleCategoryMaster")]
        public async Task<IActionResult> ViewMultipleCategoryMaster()
        {
            CommonResponse response = allMasters.ViewMultipleCategoryMaster();
            return Ok(response);
        }



        [HttpGet]
        [Route("AllMainMasters/DeleteCategoryMaster")]
        public async Task<IActionResult> DeleteCategoryMaster(int id)
        {
            CommonResponse response = allMasters.DeleteCategoryMaster(id);
            return Ok(response);
        }


        #endregion

        #region 6)  Roles Master CRUD operation


        [HttpPost]
        [Route("AllMainMasters/AddUpdateRoles")]
        public async Task<IActionResult> AddUpdateRoles(addRolesDet data)
        {
            CommonResponse response = allMasters.AddUpdateRoles(data);
            return Ok(response);
        }


        [HttpGet]
        [Route("AllMainMasters/ViewMultipleRoles")]
        public async Task<IActionResult> ViewMultipleRoles()
        {
            CommonResponse response = allMasters.ViewMultipleRoles();
            return Ok(response);
        }



        [HttpGet]
        [Route("AllMainMasters/DeleteRoles")]
        public async Task<IActionResult> DeleteRoles(int id)
        {
            CommonResponse response = allMasters.DeleteRoles(id);
            return Ok(response);
        }


        #endregion

        #region 7) Business master CRUD operation


        [HttpPost]
        [Route("AllMainMasters/AddUpdateBusiness")]
        public async Task<IActionResult> AddUpdateBusiness(addBusinessDet data)
        {
            CommonResponse response = allMasters.AddUpdateBusiness(data);
            return Ok(response);
        }


        [HttpGet]
        [Route("AllMainMasters/ViewMultipleBusiness")]
        public async Task<IActionResult> ViewMultipleBusiness()
        {
            CommonResponse response = allMasters.ViewMultipleBusiness();
            return Ok(response);
        }



        [HttpGet]
        [Route("AllMainMasters/DeleteBusiness")]
        public async Task<IActionResult> DeleteBusiness(int id)
        {
            CommonResponse response = allMasters.DeleteBusiness(id);
            return Ok(response);
        }


        #endregion



        #region 8) Department master CRUD operation


        [HttpPost]
        [Route("AllMainMasters/AddUpdateDepartment")]
        public async Task<IActionResult> AddUpdateDepartment(addDepartmentDet data)
        {
            CommonResponse response = allMasters.AddUpdateDepartment(data);
            return Ok(response);
        }


        [HttpGet]
        [Route("AllMainMasters/ViewMultipleDepartment")]
        public async Task<IActionResult> ViewMultipleDepartment()
        {
            CommonResponse response = allMasters.ViewMultipleDepartment();
            return Ok(response);
        }



        [HttpGet]
        [Route("AllMainMasters/DeleteDepartment")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            CommonResponse response = allMasters.DeleteDepartment(id);
            return Ok(response);
        }


        #endregion

        #region 9)  Employee Category master CRUD operation


        [HttpPost]
        [Route("AllMainMasters/AddUpdateEmployeeCategory")]
        public async Task<IActionResult> AddUpdateEmployeeCategory(addEmpCategoryDet data)
        {
            CommonResponse response = allMasters.AddUpdateEmployeeCategory(data);
            return Ok(response);
        }


        [HttpGet]
        [Route("AllMainMasters/ViewMultipleEmployeeCategory")]
        public async Task<IActionResult> ViewMultipleEmployeeCategory()
        {
            CommonResponse response = allMasters.ViewMultipleEmployeeCategory();
            return Ok(response);
        }



        [HttpGet]
        [Route("AllMainMasters/DeleteEmployeeCategory")]
        public async Task<IActionResult> DeleteEmployeeCategory(int id)
        {
            CommonResponse response = allMasters.DeleteEmployeeCategory(id);
            return Ok(response);
        }


        #endregion



        #region 10)  Machine Category master CRUD operation


        [HttpPost]
        [Route("AllMainMasters/AddUpdateMachineCategory")]
        public async Task<IActionResult> AddUpdateMachineCategory(addMacCatDet data)
        {
            CommonResponse response = allMasters.AddUpdateMachineCategory(data);
            return Ok(response);
        }


        [HttpGet]
        [Route("AllMainMasters/ViewMultipleMachineCategory")]
        public async Task<IActionResult> ViewMultipleMachineCategory()
        {
            CommonResponse response = allMasters.ViewMultipleMachineCategory();
            return Ok(response);
        }

        [HttpGet]
        [Route("AllMainMasters/ViewMultipleMachineCategeryByPlantId")]
        public async Task<IActionResult> ViewMultipleMachineCategoryByPlantId(int plantId)
        {
            CommonResponse response = allMasters.ViewMultipleMachineCategoryByPlantId(plantId);
            return Ok(response);
        }

        [HttpGet]
        [Route("AllMainMasters/DeleteMachineCategory")]
        public async Task<IActionResult> DeleteMachineCategory(int id)
        {
            CommonResponse response = allMasters.DeleteMachineCategory(id);
            return Ok(response);
        }


        #endregion


        #region 11) Machine Make master CRUD operation


        [HttpPost]
        [Route("AllMainMasters/AddUpdateMachineMake")]
        public async Task<IActionResult> AddUpdateMachineMake(addMacMakeDet data)
        {
            CommonResponse response = allMasters.AddUpdateMachineMake(data);
            return Ok(response);
        }


        [HttpGet]
        [Route("AllMainMasters/ViewMultipleMachineMake")]
        public async Task<IActionResult> ViewMultipleMachineMake()
        {
            CommonResponse response = allMasters.ViewMultipleMachineMake();
            return Ok(response);
        }

        [HttpGet]
        [Route("AllMainMasters/ViewMultipleMachineMakeByPlantIdCategoryId")]
        public async Task<IActionResult> ViewMultipleMachineMakeByPlantIdCategoryId(int plantId, int categoryId)
        {
            CommonResponse response = allMasters.ViewMultipleMachineMakeByPlantIdCategoryId(plantId, categoryId);
            return Ok(response);
        }

        [HttpGet]
        [Route("AllMainMasters/DeleteMachineMake")]
        public async Task<IActionResult> DeleteMachineMake(int id)
        {
            CommonResponse response = allMasters.DeleteMachineMake(id);
            return Ok(response);
        }


        #endregion

        #region 12) No Of Axis master CRUD operation


        [HttpPost]
        [Route("AllMainMasters/AddUpdateNoOfAxis")]
        public async Task<IActionResult> AddUpdateNoOfAxis(addAxisDet data)
        {
            CommonResponse response = allMasters.AddUpdateNoOfAxis(data);
            return Ok(response);
        }


        [HttpGet]
        [Route("AllMainMasters/ViewMultipleNoOfAxis")]
        public async Task<IActionResult> ViewMultipleNoOfAxis()
        {
            CommonResponse response = allMasters.ViewMultipleNoOfAxis();
            return Ok(response);
        }



        [HttpGet]
        [Route("AllMainMasters/DeleteNoOfAxis")]
        public async Task<IActionResult> DeleteNoOfAxis(int id)
        {
            CommonResponse response = allMasters.DeleteNoOfAxis(id);
            return Ok(response);
        }


        #endregion


        #region 13) Fall Stock Availability CRUD operation


        [HttpPost]
        [Route("AllMainMasters/AddUpdateFallStockAvailability")]
        public async Task<IActionResult> AddUpdateFallStockAvailability(addFallStockDet data)
        {
            CommonResponse response = allMasters.AddUpdateFallStockAvailability(data);
            return Ok(response);
        }


        [HttpGet]
        [Route("AllMainMasters/ViewMultipleFallStockAvailability")]
        public async Task<IActionResult> ViewMultipleFallStockAvailability()
        {
            CommonResponse response = allMasters.ViewMultipleFallStockAvailability();
            return Ok(response);
        }



        [HttpGet]
        [Route("AllMainMasters/DeleteFallStockAvailability")]
        public async Task<IActionResult> DeleteFallStockAvailability(int id)
        {
            CommonResponse response = allMasters.DeleteFallStockAvailability(id);
            return Ok(response);
        }


        #endregion

        #region 14) Pallet CRUD operation


        [HttpPost]
        [Route("AllMainMasters/AddUpdatePallet")]
        public async Task<IActionResult> AddUpdatePallet(addPalletDet data)
        {
            CommonResponse response = allMasters.AddUpdatePallet(data);
            return Ok(response);
        }


        [HttpGet]
        [Route("AllMainMasters/ViewMultiplePallet")]
        public async Task<IActionResult> ViewMultiplePallet()
        {
            CommonResponse response = allMasters.ViewMultiplePallet();
            return Ok(response);
        }



        [HttpGet]
        [Route("AllMainMasters/DeletePallet")]
        public async Task<IActionResult> DeletePallet(int id)
        {
            CommonResponse response = allMasters.DeletePallet(id);
            return Ok(response);
        }


        #endregion

    }
}
