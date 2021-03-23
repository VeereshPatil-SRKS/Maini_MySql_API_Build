using IFacilityMaini.DAL.Helpers;
using IFacilityMaini.DAL.Resource;
using IFacilityMaini.DBModels;
using IFacilityMaini.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.MachineMasterEntity;

namespace IFacilityMaini.DAL
{
    public class MachineMasterDAL : IMachineMaster
    {
        unitworksccsContext db = new unitworksccsContext();
        private readonly AppSettings appSettings;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(MachineMasterDAL));
        public static IConfiguration configuration;

        public MachineMasterDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings)
        {
            db = _db;
            configuration = _configuration;
            appSettings = _appSettings.Value;
        }

        /// <summary>
        /// View Multiple Plant 
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultiplePlant()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblplant
                             where wf.IsDeleted == 0
                             select new
                             {
                                 plantId = wf.PlantId,
                                 plantCode = wf.PlantCode
                             }).ToList();
                if (check.Count > 0)
                {
                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = "No Items Found";
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// View Multiple Cell
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleCell(int plantId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblshop
                             where wf.IsDeleted == 0 && wf.PlantId == plantId
                             select new
                             {
                                 shopId = wf.ShopId,
                                 shopName = wf.ShopName,
                                 shopDesc = wf.ShopDesc
                             }).Distinct().ToList();

                if (check.Count > 0)
                {
                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = "No Items Found";
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// View Multiple Sub Cell
        /// </summary>
        /// <param name="shopId"></param>
        /// <returns></returns>
        public CommonResponse ViewMultipleSubCell(int shopId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblcell
                             where wf.IsDeleted == 0 && wf.ShopId == shopId
                             select new
                             {
                                 cellId = wf.CellId,
                                 cellName = wf.CellName,
                                 cellDesc = wf.CellDesc
                             }).Distinct().ToList();

                if (check.Count > 0)
                {
                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = "No Items Found";
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// View Multiple Machine Category
        /// </summary>
        /// <param name="plantId"></param>
        /// <returns></returns>
        public CommonResponse ViewMultipleMachineCategory(int plantId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblmachinecategorynames
                             where wf.PlantId == plantId && wf.IsDeleted == 0
                             select new
                             {
                                 machineCategoryId = wf.MachineCategoryId,
                                 machineCategoryName = wf.MachineCategoryName
                             }).ToList();
                if(check.Count > 0)
                {
                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = ResourceResponse.NoItemsFound;
                }
            }
            catch(Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// View Multiple Tall Stock Availibility
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleTallStockAvailibility()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTbltallstockavailibility
                             where wf.IsDeleted == 0
                             select new
                             {
                                 tallStockAvailibilityId = wf.TallStockAvailId,
                                 tallStockAvailibilityName = wf.TallStockAvailName
                             }).ToList();
                if(check.Count > 0)
                {
                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = ResourceResponse.NoItemsFound;
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// View Multiple No Of Axis
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleNoOfAxis()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblnoofaxis
                             where wf.IsDeleted == 0
                             select new
                             {
                                 noOfAxisId = wf.NoOfAxisId,
                                 noOfAxis = wf.NoOfAxis
                             }).ToList();
                if (check.Count > 0)
                {
                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = ResourceResponse.NoItemsFound;
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// View Multiple Pallet
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultiplePallet()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblpallet
                             where wf.IsDeleted == 0
                             select new
                             {
                                 palletId = wf.PalletId,
                                 palletName = wf.PalletName
                             }).ToList();
                if (check.Count > 0)
                {
                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = ResourceResponse.NoItemsFound;
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        public CommonResponse ViewMultipleMake(int machineCategoryId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblMachinemakedetails
                             where wf.MachineCategoryId == machineCategoryId && wf.IsDeleted == 0
                             select new
                             {
                                 makeId = wf.MakeId,
                                 makeName = wf.MakeName
                             }).ToList();
                if (check.Count > 0)
                {
                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = ResourceResponse.NoItemsFound;
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Add And Update Machine Master
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse AddAndUpdateMachineMaster(AddUpdateMachine data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == data.machineId).FirstOrDefault();
                if (check == null)
                {
                    try
                    {
                        UnitworkccsTblmachinedetails tblmachinedetails = new UnitworkccsTblmachinedetails();
                        tblmachinedetails.PlantId = data.plantId;
                        tblmachinedetails.ShopId = data.shopId;
                        tblmachinedetails.CellId = data.cellId;
                        tblmachinedetails.Ipaddress = data.ipAddress;
                        tblmachinedetails.MachineName = data.machineNo;
                        tblmachinedetails.MachineDisplayName = data.machineNo;
                        tblmachinedetails.MachinePockets = Convert.ToInt32(data.noOfToolStation);
                        tblmachinedetails.Mmmgroup = data.mmmGroup;
                        tblmachinedetails.MachineDescription = data.machineName;
                        tblmachinedetails.DedicatedOrShared = data.dedicatedOrShared;
                        tblmachinedetails.PrimaryOrSecondary = data.primaryOrSecondary;
                        tblmachinedetails.MachineCategoryId = data.machineCategoryId;
                        tblmachinedetails.MachineMake = Convert.ToString(data.makeId);
                        tblmachinedetails.MachineSpec = data.machineSpec;
                        tblmachinedetails.ChuckOrRodSize = Convert.ToInt32(data.chuckOrRodSize);
                        tblmachinedetails.TallStockAvailId = Convert.ToInt32(data.tallStockAvailibilityId);
                        tblmachinedetails.NoOfAxisId = Convert.ToInt32(data.noOfAxisId);
                        tblmachinedetails.TableSize = data.tableSize;
                        tblmachinedetails.PalletId = Convert.ToInt32(data.palletId);
                        tblmachinedetails.Category = data.criticalOrNonCritical;

                        if (data.machineBelongTo == "Wimarasys")
                        {
                            tblmachinedetails.IsWimerasys = 1;
                            tblmachinedetails.MachineModelType = 99;
                        }
                        else
                        {
                            if (data.controllerType == "FANUC")
                            {
                                tblmachinedetails.ControllerType = "FANUC";
                                tblmachinedetails.MachineModelType = 1;
                            }
                            else if (data.controllerType == "DL")
                            {
                                tblmachinedetails.ControllerType = "DL";
                                tblmachinedetails.IsPcb = 1;
                                tblmachinedetails.MachineModelType = 4;
                            }
                        }

                        tblmachinedetails.IsNormalWc = 0;
                        tblmachinedetails.CreatedOn = DateTime.Now;
                        tblmachinedetails.InsertedOn = Convert.ToString(DateTime.Now);
                        tblmachinedetails.InsertedBy = 1;
                        tblmachinedetails.EnableLockLogic = 0;
                        tblmachinedetails.ServerTabFlagSync = 0;
                        tblmachinedetails.ServerTabCheck = 0;
                        tblmachinedetails.IsShiftWise = 0;
                        tblmachinedetails.IsDeleted = 0;
                        tblmachinedetails.IsDlversion = 0;
                        db.UnitworkccsTblmachinedetails.Add(tblmachinedetails);
                        db.SaveChanges();

                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;
                    }
                    catch (Exception e)
                    {
                        log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                        obj.isStatus = false;
                        obj.response = ResourceResponse.FailureMessage;
                    }
                }
                else
                {
                    check.PlantId = data.plantId;
                    check.ShopId = Convert.ToInt32(data.shopId);
                    check.CellId = Convert.ToInt32(data.cellId);
                    check.Ipaddress = data.ipAddress;
                    check.MachineName = data.machineNo;
                    check.MachineDisplayName = data.machineName;
                    check.MachinePockets = Convert.ToInt32(data.noOfToolStation);
                    check.Mmmgroup = data.mmmGroup;
                    check.MachineDescription = data.machineName;
                    check.DedicatedOrShared = data.dedicatedOrShared;
                    check.PrimaryOrSecondary = data.primaryOrSecondary;
                    check.MachineCategoryId = data.machineCategoryId;
                    check.MachineMake = Convert.ToString(data.makeId);
                    check.MachineSpec = data.machineSpec;
                    check.ChuckOrRodSize = Convert.ToInt32(data.chuckOrRodSize);
                    check.TallStockAvailId = Convert.ToInt32(data.tallStockAvailibilityId);
                    check.NoOfAxisId = Convert.ToInt32(data.noOfAxisId);
                    check.TableSize = data.tableSize;
                    check.PalletId = Convert.ToInt32(data.palletId);
                    check.Category = data.criticalOrNonCritical;

                    if (data.machineBelongTo == "Wimarasys")
                    {
                        check.IsWimerasys = 1;
                        check.MachineModelType = 99;
                    }
                    else
                    {
                        if (data.controllerType == "FANUC")
                        {
                            check.ControllerType = "FANUC";
                            check.MachineModelType = 1;
                        }
                        else if (data.controllerType == "DL")
                        {
                            check.ControllerType = "DL";
                            check.IsPcb = 1;
                            check.MachineModelType = 4;
                        }
                    }

                    check.IsNormalWc = 0;
                    check.CreatedOn = DateTime.Now;
                    check.InsertedOn = Convert.ToString(DateTime.Now);
                    check.InsertedBy = 1;
                    check.EnableLockLogic = 0;
                    check.ServerTabFlagSync = 0;
                    check.ServerTabCheck = 0;
                    check.IsShiftWise = 0;
                    check.IsDeleted = 0;
                    check.IsDlversion = 0;
                    db.SaveChanges();

                    obj.isStatus = true;
                    obj.response = ResourceResponse.UpdatedSuccessMessage;
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// View Machine Details
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMachineDetails()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblmachinedetails
                             where wf.IsDeleted == 0
                             select new
                             {
                                 machineId = wf.MachineId,
                                 machineNo = wf.MachineName,
                                 machineName = wf.MachineDescription,
                                 noOfToolStation = wf.MachinePockets,
                                 machineDescription = wf.MachineDescription,
                                 machineDisplayName = wf.MachineDisplayName,
                                 plantId = wf.PlantId,
                                 plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == wf.PlantId).Select(m => m.PlantCode).FirstOrDefault(),
                                 cellId = wf.ShopId,
                                 cellName = db.UnitworkccsTblshop.Where(m => m.ShopId == wf.ShopId).Select(m => m.ShopName).FirstOrDefault(),
                                 subCellId = wf.CellId,
                                 subCellName = db.UnitworkccsTblcell.Where(m => m.CellId == wf.CellId).Select(m => m.CellName).FirstOrDefault(),
                                 ipaddress = wf.Ipaddress,
                                 isWimerasys = wf.IsWimerasys,
                                 controllerType = wf.ControllerType,
                                 isPcb = wf.IsPcb,
                                 criticalOrNonCritical = wf.Category,
                                 mmmGroup = wf.Mmmgroup,
                                 dedicatedOrShared = wf.DedicatedOrShared,
                                 primaryOrSecondary = wf.PrimaryOrSecondary,
                                 machineCategoryId = wf.MachineCategoryId,
                                 machineCategoryName = db.UnitworkccsTblmachinecategorynames.Where(m=>m.MachineCategoryId == wf.MachineCategoryId).Select(m=>m.MachineCategoryName).FirstOrDefault(),
                                 makeId = wf.MachineMake,
                                 makeName = db.UnitworkccsTblMachinemakedetails.Where(m=>m.MakeId == Convert.ToInt32(wf.MachineMake)).Select(m=>m.MakeName).FirstOrDefault(),
                                 machineSpec = wf.MachineSpec,
                                 chuckOrRodSize = wf.ChuckOrRodSize,
                                 tallStockAvailibilityId = wf.TallStockAvailId,
                                 tallStockAvailibility = db.UnitworkccsTbltallstockavailibility.Where(m=>m.TallStockAvailId == wf.TallStockAvailId).Select(m=>m.TallStockAvailName).FirstOrDefault(),
                                 noOfAxisId = wf.NoOfAxisId,
                                 noOfAxisName = db.UnitworkccsTblnoofaxis.Where(m=>m.NoOfAxisId == wf.NoOfAxisId).Select(m=>m.NoOfAxis).FirstOrDefault(),
                                 tableSize = wf.TableSize,
                                 palletId = wf.PalletId,
                                 palletName = db.UnitworkccsTblpallet.Where(m=>m.PalletId == wf.PalletId).Select(m=>m.PalletName).FirstOrDefault(),
                             }).ToList();

                List<ViewMachineMaster> viewMachineMasters = new List<ViewMachineMaster>();
                if (check.Count > 0)
                {
                    foreach(var item in check)
                    {
                        ViewMachineMaster viewMachineMaster = new ViewMachineMaster();
                        viewMachineMaster.machineId = item.machineId;
                        viewMachineMaster.machineNo = item.machineNo;
                        viewMachineMaster.machineName = item.machineName;
                        viewMachineMaster.machineCategoryId = item.machineCategoryId;
                        viewMachineMaster.machineCategoryName = item.machineCategoryName;
                        viewMachineMaster.mmmGroup = item.mmmGroup;
                        viewMachineMaster.cellId = item.cellId;
                        viewMachineMaster.cellName = item.cellName;
                        viewMachineMaster.subCellId = item.subCellId;
                        viewMachineMaster.subCellName = item.subCellName;
                        viewMachineMaster.tableSize = item.tableSize;
                        viewMachineMaster.primaryOrSecondary = item.primaryOrSecondary;
                        viewMachineMaster.criticalOrNonCritical = item.criticalOrNonCritical;
                        viewMachineMaster.dedicatedOrShared = item.dedicatedOrShared;
                        viewMachineMaster.ipaddress = item.ipaddress;
                        viewMachineMaster.isPcb = item.isPcb;
                        viewMachineMaster.isWimerasys =Convert.ToBoolean( item.isWimerasys);
                        viewMachineMaster.machineDescription = item.machineDescription;
                        viewMachineMaster.machineDisplayName = item.machineDisplayName;
                        viewMachineMaster.noOfToolStation = item.noOfToolStation;
                        viewMachineMaster.plantCode = item.plantCode;
                        viewMachineMaster.plantId = item.plantId;
                        if(item.tallStockAvailibilityId == 0)
                        {
                            viewMachineMaster.tallStockAvailibilityId = null;
                        }
                        else
                        {
                            viewMachineMaster.tallStockAvailibilityId = Convert.ToString(item.tallStockAvailibilityId);
                        }
                        viewMachineMaster.tallStockAvailibility = item.tallStockAvailibility;
                        if(item.palletId == 0)
                        {
                            viewMachineMaster.palletId = null;
                        }
                        else
                        {
                            viewMachineMaster.palletId = Convert.ToString(item.palletId);
                        }
                        viewMachineMaster.palletName = item.palletName;
                        if(item.noOfAxisId == 0)
                        {
                            viewMachineMaster.noOfAxisId = null;
                        }
                        else
                        {
                            viewMachineMaster.noOfAxisId = Convert.ToString(item.noOfAxisId);
                        }
                        viewMachineMaster.noOfAxisName = item.noOfAxisName;
                        viewMachineMaster.makeId = item.makeId;
                        viewMachineMaster.makeName = item.makeName;
                        viewMachineMaster.chuckOrRodSize = item.chuckOrRodSize;
                        viewMachineMaster.machineSpec = item.machineSpec;
                        viewMachineMaster.controllerType = item.controllerType;
                        viewMachineMasters.Add(viewMachineMaster);
                    }
                    obj.isStatus = true;
                    obj.response = viewMachineMasters;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = ResourceResponse.NoItemsFound;
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// View Machine Details By Id
        /// </summary>
        /// <param name="machineId"></param>
        /// <returns></returns>
        public CommonResponse ViewMachineDetailsById(int machineId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblmachinedetails
                             where wf.IsDeleted == 0 && wf.MachineId == machineId
                             select new
                             {
                                 machineId = wf.MachineId,
                                 machineName = wf.MachineName,
                                 machinePockets = wf.MachinePockets,
                                 noOfPartsPerCycle = wf.NoOfPartsPerCycle,
                                 machineDescription = wf.MachineDescription,
                                 machineDisplayName = wf.MachineDisplayName,
                                 plantId = wf.PlantId,
                                 plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == wf.PlantId).Select(m => m.PlantCode).FirstOrDefault(),
                                 cellId = wf.ShopId,
                                 cellName = db.UnitworkccsTblshop.Where(m => m.ShopId == wf.ShopId).Select(m => m.ShopName).FirstOrDefault(),
                                 subCellId = wf.CellId,
                                 subCellName = db.UnitworkccsTblcell.Where(m => m.CellId == wf.CellId).Select(m => m.CellName).FirstOrDefault(),
                                 ipaddress = wf.Ipaddress,
                                 isWimerasys = wf.IsWimerasys,
                                 controllerType = wf.ControllerType,
                                 Category = wf.Category
                             }).FirstOrDefault();

                if (check != null)
                {
                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = ResourceResponse.NoItemsFound;
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Delete Machine Details
        /// </summary>
        /// <param name="machineId"></param>
        /// <returns></returns>
        public CommonResponse DeleteMachineDetails(int machineId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == machineId).FirstOrDefault();
                if (check != null)
                {
                    check.IsDeleted = 1;
                    check.ModifiedOn = DateTime.Now;
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.DeletedSuccessMessage;
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Upload Machine Master
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse UploadMachineMaster(List<UploadMachine> data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check1 = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0).ToList();
                check1.ForEach(m => m.IsDeleted = 1);
                db.SaveChanges();

                foreach (var item in data)
                {
                    var check = db.UnitworkccsTblmachinedetails.Where(m => m.MachineName == item.machineNo).FirstOrDefault();
                    if (check == null)
                    {
                        UnitworkccsTblmachinedetails tblmachinedetails = new UnitworkccsTblmachinedetails();
                        if (item.plantNo != null)
                        {
                            var plantId = db.UnitworkccsTblplant.Where(m => m.PlantCode == item.plantNo).Select(m => m.PlantId).FirstOrDefault();
                            tblmachinedetails.PlantId = plantId;
                        }

                        if (item.cellName != null)
                        {
                            var cellId = db.UnitworkccsTblshop.Where(m => m.ShopName == item.cellName).Select(m => m.ShopId).FirstOrDefault();
                            tblmachinedetails.ShopId = cellId;
                        }
                        else
                        {
                            var cellId = db.UnitworkccsTblshop.Where(m => m.ShopName == "Default").Select(m => m.ShopId).FirstOrDefault();
                            tblmachinedetails.ShopId = cellId;
                        }

                        if (item.subCellName != null)
                        {
                            var subCellId = db.UnitworkccsTblcell.Where(m => m.CellName == item.subCellName).Select(m => m.CellId).FirstOrDefault();
                            tblmachinedetails.CellId = subCellId;
                        }
                        else
                        {
                            var subCellId = db.UnitworkccsTblcell.Where(m => m.CellName == "Default").Select(m => m.CellId).FirstOrDefault();
                            tblmachinedetails.CellId = subCellId;
                        }

                        if(item.tallStockAvailibility != null)
                        {
                            var tallStockId = db.UnitworkccsTbltallstockavailibility.Where(m => m.TallStockAvailName == item.tallStockAvailibility).Select(m => m.TallStockAvailId).FirstOrDefault();
                            if(tallStockId != 0)
                            {
                                tblmachinedetails.TallStockAvailId = tallStockId;
                            }
                        }

                        if(item.noOfAxis != 0)
                        {
                            var noOfAxisId = db.UnitworkccsTblnoofaxis.Where(m => m.NoOfAxis == item.noOfAxis).Select(m => m.NoOfAxisId).FirstOrDefault();
                            if(noOfAxisId != 0)
                            {
                                tblmachinedetails.NoOfAxisId = noOfAxisId;
                            }
                        }

                        if(item.pallet != null)
                        {
                            var palletId = db.UnitworkccsTblpallet.Where(m => m.PalletName == item.pallet).Select(m => m.PalletId).FirstOrDefault();
                            if (palletId != 0)
                            {
                                tblmachinedetails.PalletId = palletId;
                            }
                        }

                        if(item.machineCategory != null)
                        {
                            var machineCategoryId = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryName == item.machineCategory).Select(m => m.MachineCategoryId).FirstOrDefault();
                            if(machineCategoryId != 0)
                            {
                                tblmachinedetails.MachineCategoryId = machineCategoryId;
                            }
                        }

                        if(item.machineMake != null)
                        {
                            var machineMakeId = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeName == item.machineMake).Select(m => m.MakeId).FirstOrDefault();
                            if(machineMakeId != 0)
                            {
                                tblmachinedetails.MachineMake = Convert.ToString(machineMakeId);
                            }
                        }

                        tblmachinedetails.Mmmgroup = item.mmmGroup;
                        tblmachinedetails.DedicatedOrShared = item.dedicatedOrShared;
                        tblmachinedetails.PrimaryOrSecondary = item.primaryOrSecondary;
                        tblmachinedetails.MachineSpec = item.machineSpec;
                        tblmachinedetails.ChuckOrRodSize = item.chuckOrRodSize;
                        tblmachinedetails.TableSize = item.tableSize;
                        tblmachinedetails.Category = item.criticalOrNonCritical;
                        tblmachinedetails.Ipaddress = item.ipAddress;
                        tblmachinedetails.MachineName = item.machineNo;
                        tblmachinedetails.MachineDescription = item.machineName;
                        tblmachinedetails.MachineDisplayName = item.machineNo;
                        tblmachinedetails.MachinePockets = item.noOfToolStation;

                        if (item.machineBelongTo == "Wimarasys")
                        {
                            tblmachinedetails.IsWimerasys = 1;
                            tblmachinedetails.MachineModelType = 99;
                        }
                        else if (item.machineBelongTo == "SRKS")
                        {
                            if (item.controllerType == "FANUC")
                            {
                                tblmachinedetails.ControllerType = "FANUC";
                                tblmachinedetails.MachineModelType = 1;
                            }
                            else if (item.controllerType == "DL")
                            {
                                tblmachinedetails.ControllerType = "DL";
                                tblmachinedetails.IsPcb = 1;
                                tblmachinedetails.MachineModelType = 4;
                            }
                        }
                        else if (item.machineBelongTo == null)
                        {
                            tblmachinedetails.IsWimerasys = 0;
                            tblmachinedetails.ControllerType = null;
                            tblmachinedetails.IsPcb = null;
                        }

                        tblmachinedetails.IsNormalWc = 0;
                        tblmachinedetails.CreatedOn = DateTime.Now;
                        tblmachinedetails.InsertedOn = Convert.ToString(DateTime.Now);
                        tblmachinedetails.InsertedBy = 1;
                        tblmachinedetails.EnableLockLogic = 0;
                        tblmachinedetails.ServerTabFlagSync = 0;
                        tblmachinedetails.ServerTabCheck = 0;
                        tblmachinedetails.IsShiftWise = 0;
                        tblmachinedetails.IsDeleted = 0;
                        tblmachinedetails.IsDlversion = 0;
                        db.UnitworkccsTblmachinedetails.Add(tblmachinedetails);
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;
                    }
                    else
                    {
                        if (item.plantNo != null)
                        {
                            var plantId = db.UnitworkccsTblplant.Where(m => m.PlantCode == item.plantNo).Select(m => m.PlantId).FirstOrDefault();
                            check.PlantId = plantId;
                        }


                        if (item.cellName != null)
                        {
                            var cellId = db.UnitworkccsTblshop.Where(m => m.ShopName == item.cellName).Select(m => m.ShopId).FirstOrDefault();
                            check.ShopId = cellId;
                        }


                        if (item.subCellName != null)
                        {
                            var subCellId = db.UnitworkccsTblcell.Where(m => m.CellName == item.subCellName).Select(m => m.CellId).FirstOrDefault();
                            check.CellId = subCellId;
                        }

                        if (item.tallStockAvailibility != null)
                        {
                            var tallStockId = db.UnitworkccsTbltallstockavailibility.Where(m => m.TallStockAvailName == item.tallStockAvailibility).Select(m => m.TallStockAvailId).FirstOrDefault();
                            if (tallStockId != 0)
                            {
                                check.TallStockAvailId = tallStockId;
                            }
                        }

                        if (item.noOfAxis != 0)
                        {
                            var noOfAxisId = db.UnitworkccsTblnoofaxis.Where(m => m.NoOfAxis == item.noOfAxis).Select(m => m.NoOfAxisId).FirstOrDefault();
                            if (noOfAxisId != 0)
                            {
                                check.NoOfAxisId = noOfAxisId;
                            }
                        }

                        if (item.pallet != null)
                        {
                            var palletId = db.UnitworkccsTblpallet.Where(m => m.PalletName == item.pallet).Select(m => m.PalletId).FirstOrDefault();
                            if (palletId != 0)
                            {
                                check.PalletId = palletId;
                            }
                        }

                        if (item.machineCategory != null)
                        {
                            var machineCategoryId = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryName == item.machineCategory).Select(m => m.MachineCategoryId).FirstOrDefault();
                            if (machineCategoryId != 0)
                            {
                                check.MachineCategoryId = machineCategoryId;
                            }
                        }

                        if (item.machineMake != null)
                        {
                            var machineMakeId = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeName == item.machineMake).Select(m => m.MakeId).FirstOrDefault();
                            if (machineMakeId != 0)
                            {
                                check.MachineMake = Convert.ToString(machineMakeId);
                            }
                        }

                        check.Mmmgroup = item.mmmGroup;
                        check.DedicatedOrShared = item.dedicatedOrShared;
                        check.PrimaryOrSecondary = item.primaryOrSecondary;
                        check.MachineSpec = item.machineSpec;
                        check.ChuckOrRodSize = item.chuckOrRodSize;
                        check.TableSize = item.tableSize;
                        check.Category = item.criticalOrNonCritical;
                        check.Ipaddress = item.ipAddress;
                        check.MachineName = item.machineNo;
                        check.MachineDescription = item.machineName;
                        check.MachineDisplayName = item.machineNo;
                        check.MachinePockets = item.noOfToolStation;

                        if (item.machineBelongTo == "Wimarasys")
                        {
                            check.IsWimerasys = 1;
                            check.MachineModelType = 99;
                        }
                        else
                        {
                            if (item.controllerType == "FANUC")
                            {
                                check.ControllerType = "FANUC";
                                check.MachineModelType = 1;
                            }
                            else if (item.controllerType == "DL")
                            {
                                check.ControllerType = "DL";
                                check.IsPcb = 1;
                                check.MachineModelType = 4;
                            }
                        }

                        check.IsNormalWc = 0;
                        check.CreatedOn = DateTime.Now;
                        check.InsertedOn = Convert.ToString(DateTime.Now);
                        check.InsertedBy = 1;
                        check.EnableLockLogic = 0;
                        check.ServerTabFlagSync = 0;
                        check.ServerTabCheck = 0;
                        check.IsShiftWise = 0;
                        check.IsDeleted = 0;
                        check.IsDlversion = 0;
                        db.SaveChanges();

                        obj.isStatus = true;
                        obj.response = ResourceResponse.UpdatedSuccessMessage;
                    }
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Download Machine Master
        /// </summary>
        /// <returns></returns>
        public CommonResponse DownloadMachineMaster()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                FileInfo templateFile = new FileInfo(@"C:\SRKS_ifacility\MainTemplate\MachineMaster.xlsx");
                ExcelPackage templatep = new ExcelPackage(templateFile);
                ExcelWorksheet Templatews = templatep.Workbook.Worksheets[0];
                //  ExcelWorksheet TemplateGraph = templatep.Workbook.Worksheets[1];

                //excel file save and  downloaded link
                string ImageUrlSave = appSettings.ImageUrlSave;
                string ImageUrl = appSettings.ImageUrl;
                String FileDir = ImageUrlSave + "\\" + "MachineMaster_" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
                String retrivalPath = ImageUrl + "MachineMaster_" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
                FileInfo newFile = new FileInfo(FileDir);
                if (newFile.Exists)
                {
                    try
                    {
                        newFile.Delete();  // ensures we create a new workbook
                        newFile = new FileInfo(FileDir);
                    }
                    catch (Exception ex)
                    {
                        obj.response = ResourceResponse.ExceptionMessage; ;
                    }
                }

                //Using the File for generation and populating it
                ExcelPackage p = null;
                p = new ExcelPackage(newFile);
                ExcelWorksheet worksheet = null;
              
                try
                {
                    worksheet = p.Workbook.Worksheets.Add(DateTime.Now.ToString("yyyy-MM-dd"), Templatews);
                    //  worksheetGraph = p.Workbook.Worksheets.Add("Graphs", TemplateGraph);
                }
                catch { }
                if (worksheet == null)
                {
                    worksheet = p.Workbook.Worksheets.Add(DateTime.Now.ToString("yyyy-MM-dd") + "1", Templatews);
                    //  worksheetGraph = p.Workbook.Worksheets.Add(System.DateTime.Now.ToString("dd-MM-yyyy") + "Graph", TemplateGraph);
                }

                int sheetcount = p.Workbook.Worksheets.Count;
                p.Workbook.Worksheets.MoveToStart(sheetcount - 1);
                worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Cells.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                int StartRow = 2;

                var check = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0).ToList();
                foreach(var item in check)
                {
                    worksheet.Cells["A" + StartRow].Value = db.UnitworkccsTblplant.Where(m => m.PlantId == item.PlantId).Select(m => m.PlantCode).FirstOrDefault();
                    worksheet.Cells["B" + StartRow].Value = db.UnitworkccsTblshop.Where(m => m.ShopId == item.ShopId).Select(m => m.ShopName).FirstOrDefault();
                    worksheet.Cells["C" + StartRow].Value = db.UnitworkccsTblcell.Where(m => m.CellId == item.CellId).Select(m => m.CellName).FirstOrDefault();
                    worksheet.Cells["D" + StartRow].Value = item.MachineName;
                    worksheet.Cells["E" + StartRow].Value = item.Mmmgroup;
                    worksheet.Cells["F" + StartRow].Value = item.MachineDescription;
                    worksheet.Cells["G" + StartRow].Value = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == Convert.ToInt32(item.MachineMake)).Select(m => m.MakeName).FirstOrDefault();
                    worksheet.Cells["H" + StartRow].Value = item.DedicatedOrShared;
                    worksheet.Cells["I" + StartRow].Value = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == item.MachineCategoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
                    worksheet.Cells["J" + StartRow].Value = item.PrimaryOrSecondary;
                    worksheet.Cells["K" + StartRow].Value = item.MachineSpec;
                    worksheet.Cells["L" + StartRow].Value = item.ChuckOrRodSize;
                    worksheet.Cells["M" + StartRow].Value = item.MachinePockets;
                    worksheet.Cells["N" + StartRow].Value = db.UnitworkccsTbltallstockavailibility.Where(m => m.TallStockAvailId == item.TallStockAvailId).Select(m => m.TallStockAvailName).FirstOrDefault();
                    worksheet.Cells["O" + StartRow].Value = db.UnitworkccsTblnoofaxis.Where(m => m.NoOfAxisId == item.NoOfAxisId).Select(m => m.NoOfAxis).FirstOrDefault();
                    worksheet.Cells["P" + StartRow].Value = item.TableSize;
                    worksheet.Cells["Q" + StartRow].Value = db.UnitworkccsTblpallet.Where(m => m.PalletId == item.PalletId).Select(m => m.PalletName).FirstOrDefault();
                    worksheet.Cells["R" + StartRow].Value = item.Category;
                    worksheet.Cells["S" + StartRow].Value = item.Ipaddress;
                    if(item.IsWimerasys == 1)
                    {
                        worksheet.Cells["T" + StartRow].Value = "Wimerasys";
                    }
                    else
                    {
                        worksheet.Cells["T" + StartRow].Value = "SRKS";
                    }
                    StartRow++;
                }
                p.Save();
                obj.isStatus = true;
                obj.response = retrivalPath;
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }
    }
}
