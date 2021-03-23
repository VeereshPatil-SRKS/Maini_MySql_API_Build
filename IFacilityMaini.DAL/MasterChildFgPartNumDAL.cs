using IFacilityMaini.DAL.Helpers;
using IFacilityMaini.DAL.Resource;
using IFacilityMaini.DBModels;
using IFacilityMaini.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.MasterChildFgPartNumEntity;

namespace IFacilityMaini.DAL
{
    public class MasterChildFgPartNumDAL : IMasterChildFgPartNum
    {
        unitworksccsContext db = new unitworksccsContext();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(AllMainMastersDAL));
        public static IConfiguration configuration;
        private readonly AppSettings appSettings;

        public MasterChildFgPartNumDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings)
        {
            db = _db;
            configuration = _configuration;
            appSettings = _appSettings.Value;
        }
        #region  1)ChildFgPartNo
        public CommonResponse AddUpdateChildFgPartNo(addChildfgPartNoDet data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTblchildfgpartno.Where(m => m.ChildFgpartId == data.childFgpartId && m.IsDeleted == 0).FirstOrDefault();
                if (check == null)
                {
                    UnitworkccsTblchildfgpartno UnitworkccsTblchildfgpartnodet = new UnitworkccsTblchildfgpartno();
                    UnitworkccsTblchildfgpartnodet.ChildFgpartId = data.childFgpartId;
                    UnitworkccsTblchildfgpartnodet.ChildFgPartNo = data.fgPartNo;
                    UnitworkccsTblchildfgpartnodet.FgPartNo = data.fgPartNo;
                    UnitworkccsTblchildfgpartnodet.ChildPartNoDesc = data.childPartNoDesc;
                    UnitworkccsTblchildfgpartnodet.FgPartDesc = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == data.fgPartNo).Select(m => m.PartName).FirstOrDefault();
                    UnitworkccsTblchildfgpartnodet.IsDeleted = 0;
                    UnitworkccsTblchildfgpartnodet.CreatedBy = 1;
                    UnitworkccsTblchildfgpartnodet.CreatedOn = DateTime.Now;
                    db.UnitworkccsTblchildfgpartno.Add(UnitworkccsTblchildfgpartnodet);
                    db.SaveChanges();

                    obj.isStatus = true;
                    obj.response = ResourceResponse.AddedSuccessMessage;
                }
                else
                {
                    //check.ChildFgpartId = data.ChildFgpartId;
                    check.ChildFgPartNo = data.childFgPartNo;
                    check.FgPartNo = data.fgPartNo;
                    check.FgPartDesc = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == data.fgPartNo).Select(m => m.PartName).FirstOrDefault();

                    check.ChildPartNoDesc = data.childPartNoDesc;
                    check.ModifiedBy = 2;
                    check.ModifiedOn = DateTime.Now;
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
        public CommonResponse ViewMultipleChildFgPartNo()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblchildfgpartno
                             where wf.IsDeleted == 0
                             select new
                             {
                                 childFgpartId = wf.ChildFgpartId,
                                 childFgPartNo = wf.ChildFgPartNo,
                                 childPartNoDesc = wf.ChildPartNoDesc,
                                 fgPartNo = wf.FgPartNo,
                                 fgPartDesc = wf.FgPartDesc
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

        public CommonResponse ViewMultipleChildFgPartNoById(int childFgpartId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblchildfgpartno
                             where wf.IsDeleted == 0 && wf.ChildFgpartId == childFgpartId
                             select new
                             {
                                 childFgpartId = wf.ChildFgpartId,
                                 childFgPartNo = wf.ChildFgPartNo,
                                 childPartNoDesc = wf.ChildPartNoDesc,
                                 fgPartNo = wf.FgPartNo,
                                 fgPartDesc = wf.FgPartDesc
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
        public CommonResponse DeleteChildFgPartNo(int childFgpartId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTblchildfgpartno.Where(m => m.ChildFgpartId == childFgpartId && m.IsDeleted == 0).FirstOrDefault();
                if (check != null)
                {
                    check.IsDeleted = 1;
                    check.ModifiedBy = 3;
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

        #endregion

        #region  2)FgAndCellAllocation

        //public CommonResponse AddUpdateFgAndCellAllocation(addFgAndCellAllocationDet data)
        //{
        //    CommonResponse obj = new CommonResponse();
        //    try
        //    {
        //            var check = db.UnitworkccsTblfgandcellallocation.Where(m => m.FgAndCellAllocationId == data.fgAndCellAllocationId).FirstOrDefault();
        //            if (check == null)
        //            {
        //                UnitworkccsTblfgandcellallocation tblFgAndCellAllocation = new UnitworkccsTblfgandcellallocation();

        //                //tblFgAndCellAllocation.PlantId = data.plantId;
        //                tblFgAndCellAllocation.PartNo = data.partNo;
        //                tblFgAndCellAllocation.PartName = data.partDesc;
        //               // tblFgAndCellAllocation.DmcCodeStatus = data.dmcCodeStatus;
        //                //tblFgAndCellAllocation.CellFinalId = data.cellFinalId;
        //                //tblFgAndCellAllocation.SubCellFinalId = data.subFinalId;
        //                tblFgAndCellAllocation.IsDeleted = 0;
        //                tblFgAndCellAllocation.CreatedOn = DateTime.Now;
        //                db.UnitworkccsTblfgandcellallocation.Add(tblFgAndCellAllocation);
        //                db.SaveChanges();
        //                obj.isStatus = true;
        //                obj.response = ResourceResponse.AddedSuccessMessage;
        //            }
        //            else
        //            {
        //                //check.PlantId = data.plantId;
        //                check.PartNo = data.partNo;
        //                check.PartName = data.partDesc;
        //               // check.DmcCodeStatus = data.dmcCodeStatus;
        //                //check.CellFinalId = data.cellFinalId;
        //                //check.SubCellFinalId = data.subFinalId;
        //                check.IsDeleted = 0;
        //                check.ModifiedOn = DateTime.Now;
        //                db.SaveChanges();
        //                obj.isStatus = true;
        //                obj.response = ResourceResponse.UpdatedSuccessMessage;
        //            }
        //    }
        //    catch (Exception e)
        //    {
        //        obj.isStatus = false;
        //        obj.response = ResourceResponse.FailureMessage;
        //    }
        //    return obj;
        //}
        public CommonResponse ViewMultipleFgAndCellAllocation()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblfgandcellallocation
                             where wf.IsDeleted == 0
                             select new
                             {
                                 fgAndCellAllocationId = wf.FgAndCellAllocationId,
                                 plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == wf.PlantId).Select(m => m.PlantName).FirstOrDefault(),
                                 plantId = wf.PlantId,
                                 //partNo = db.Tblparts.Where(m => m.PartId == wf.PartId).Select(m => m.Fgcode).FirstOrDefault(),
                                 //partId = wf.PartId,
                                 //partDesc = db.Tblparts.Where(m => m.PartId == wf.PartId).Select(m => m.PartName).FirstOrDefault(),
                                 partNo = wf.PartNo,
                                 partDesc = wf.PartName,
                                 cellFinalId = wf.CellFinalId,
                                 cellFinalName = db.UnitworkccsTblshop.Where(m => m.ShopId == wf.CellFinalId).Select(m => m.ShopName).FirstOrDefault(),
                                 subCellFinalId = wf.SubCellFinalId,
                                 subCellFinalName = db.UnitworkccsTblcell.Where(m => m.CellId == wf.SubCellFinalId).Select(m => m.CellName).FirstOrDefault(),
                                 dmcCodeStatus = wf.DmcCodeStatus
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
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        //public CommonResponse ViewMultipleFgAndCellAllocationById(int fgAndCellAllocationId)
        //{
        //    CommonResponse obj = new CommonResponse();
        //    try
        //    {
        //        var check = (from wf in db.UnitworkccsTblfgandcellallocation
        //                     where wf.IsDeleted == 0 && wf.FgAndCellAllocationId == fgAndCellAllocationId
        //                     select new
        //                     {
        //                         fgAndCellAllocationId = wf.FgAndCellAllocationId,
        //                         plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == wf.PlantId).Select(m => m.PlantName).FirstOrDefault(),
        //                         plantId = wf.PlantId,
        //                         //partNo = db.Tblparts.Where(m => m.PartId == wf.PartId).Select(m => m.Fgcode).FirstOrDefault(),
        //                         //partId = wf.PartId,
        //                         //partDesc = db.Tblparts.Where(m => m.PartId == wf.PartId).Select(m => m.PartName).FirstOrDefault(),
        //                         partNo = wf.PartNo,
        //                         partDesc = wf.PartName,
        //                         cellFinalId = wf.CellFinalId,
        //                         cellFinalName = db.UnitworkccsTblshop.Where(m => m.ShopId == wf.CellFinalId).Select(m => m.ShopName).FirstOrDefault(),
        //                         subCellFinalId = wf.SubCellFinalId,
        //                         subCellFinalName = db.UnitworkccsTblcell.Where(m => m.CellId == wf.SubCellFinalId).Select(m => m.CellName).FirstOrDefault(),
        //                         dmcCodeStatus = wf.DmcCodeStatus
        //                     }).FirstOrDefault();
        //        if (check != null)
        //        {
        //            obj.isStatus = true;
        //            obj.response = check;
        //        }
        //        else
        //        {
        //            obj.isStatus = false;
        //            obj.response = "No Items Found";
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        obj.isStatus = false;
        //        obj.response = ResourceResponse.FailureMessage;
        //    }
        //    return obj;
        //}
        //public CommonResponse DeleteChildFgAndCellAllocation(int fgAndCellAllocationId)
        //{
        //    CommonResponse obj = new CommonResponse();
        //    try
        //    {
        //        var check = db.UnitworkccsTblfgandcellallocation.Where(m => m.FgAndCellAllocationId == fgAndCellAllocationId).FirstOrDefault();
        //        if (check != null)
        //        {
        //            check.IsDeleted = 1;
        //            check.ModifiedOn = DateTime.Now;
        //            db.SaveChanges();
        //            obj.isStatus = true;
        //            obj.response = ResourceResponse.DeletedSuccessMessage;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        obj.isStatus = false;
        //        obj.response = ResourceResponse.FailureMessage;
        //    }
        //    return obj;
        //}
        #endregion
    }
}
