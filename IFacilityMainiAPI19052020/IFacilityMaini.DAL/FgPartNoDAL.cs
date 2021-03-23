using IFacilityMaini.DAL.Resource;
using IFacilityMaini.DBModels;
using IFacilityMaini.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.FgPartNoEntity;
using IFacilityMaini.DAL.App_Start;

namespace IFacilityMaini.DAL
{
    public class FgPartNoDAL : IFgPartNo
    {
        unitworksccsContext db = new unitworksccsContext();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(FgPartNoDAL));
        public static IConfiguration configuration;

        public FgPartNoDAL(unitworksccsContext _db, IConfiguration _configuration)
        {
            db = _db;
            configuration = _configuration;
        }

        /// <summary>
        /// Get Fg Part Details
        /// </summary>
        /// <param name="machineId"></param>
        /// <returns></returns>
        public CommonResponse GetFgPartDetails(int machineId)
        {
            CommonResponse obj = new CommonResponse();
            CommonFunction commonFunction = new CommonFunction();
            string shift = commonFunction.GetCurrentShift();
            int ShiftID = commonFunction.ShiftDet();
            string correctedDate = commonFunction.GetCorrectedDate();
            DateTime currentDateTime = DateTime.Now;
            List<GetFgPartDetails> getFgPartDetailsList = new List<GetFgPartDetails>();

            try
            {
                var machineName = db.Tblmachinedetails.Where(m => m.MachineId == machineId).Select(m => m.MachineName).FirstOrDefault();

                var noOfPartPerCycle = db.Tblmachinedetails.Where(m => m.MachineId == machineId).Select(m => m.NoOfPartsPerCycle).FirstOrDefault();

                var check = (from wf in db.TblPlanLinkageMaster
                             where wf.ResourceId == machineName && wf.ShiftId == ShiftID
                             select new
                             {
                                 ProductionOrder = wf.ProductionOrder,
                                 RoutingId = wf.RoutingId,
                                 WorkOrderQty = wf.WorkOrderQty,
                                 Operation = wf.Operation,
                                 PlanLinkageId = wf.PlanLinkageId,
                                 FgPartNo = wf.FgPartNo
                             }).FirstOrDefault();

                if (check != null)
                {
                    GetFgPartDetails getFgPartDetails = new GetFgPartDetails();
                    getFgPartDetails.FgPartNo = check.FgPartNo;
                    getFgPartDetails.NoOfPartsPerCycle = noOfPartPerCycle;
                    getFgPartDetails.Operation = check.Operation;
                    getFgPartDetails.PlanLinkageId = check.PlanLinkageId;
                    getFgPartDetails.ProductionOrder = check.ProductionOrder;
                    getFgPartDetails.RoutingId = check.RoutingId;
                    getFgPartDetails.WorkOrderQty = check.WorkOrderQty;
                    getFgPartDetailsList.Add(getFgPartDetails);

                    obj.isStatus = true;
                    obj.response = getFgPartDetailsList;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = ResourceResponse.NoItemsFound;
                }
            }
            catch (Exception ex)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        ///// <summary>
        ///// Get WorkOrder No
        ///// </summary>
        ///// <param name="machineId"></param>
        ///// <returns></returns>
        //public CommonResponse GetWorkOrderNo(int machineId)
        //{
        //    CommonResponse obj = new CommonResponse();
        //    CommonFunction commonFunction = new CommonFunction();
        //    string shift = commonFunction.GetCurrentShift();
        //    try
        //    {
        //        var check = db.Tblmachinedetails.Where(m => m.MachineId == machineId).Select(m => m.MachineName).FirstOrDefault();
        //        var shiftId = db.TblshiftMstr.Where(m => m.ShiftName == shift).Select(m => m.ShiftId).FirstOrDefault();

        //        var dbCheck = (from wf in db.TblPlanLinkageMaster
        //                       where wf.ResourceId == check && wf.ShiftId == shiftId
        //                       select new
        //                       {
        //                           ProductionOrder = wf.ProductionOrder,
        //                           PlanLinkageId = wf.PlanLinkageId
        //                       }).ToList();
        //        if (dbCheck.Count > 0)
        //        {
        //            obj.isStatus = true;
        //            obj.response = dbCheck;
        //        }
        //        else
        //        {
        //            obj.isStatus = false;
        //            obj.response = "No Items Found";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        obj.isStatus = false;
        //        obj.response = ResourceResponse.FailureMessage;
        //    }
        //    return obj;
        //}

        ///// <summary>
        ///// View Multiple Part No
        ///// </summary>
        ///// <param name="ProductionOrder"></param>
        ///// <returns></returns>
        //public CommonResponse ViewMultiplePartNo(string ProductionOrder, int PlanLinkageId)
        //{
        //    CommonResponse obj = new CommonResponse();
        //    try
        //    {
        //        var check = (from wf in db.TblPlanLinkageMaster
        //                     where wf.IsDeleted == 0 && wf.ProductionOrder == ProductionOrder && wf.PlanLinkageId == PlanLinkageId
        //                     select new
        //                     {
        //                         FgPartNo = wf.FgPartNo,
        //                         PlanLinkageId = wf.PlanLinkageId
        //                     }).ToList();
        //        if (check.Count > 0)
        //        {
        //            obj.isStatus = true;
        //            obj.response = check;
        //        }
        //        else
        //        {
        //            obj.isStatus = false;
        //            obj.response = ResourceResponse.NoItemsFound;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        obj.isStatus = false;
        //        obj.response = ResourceResponse.FailureMessage;
        //    }
        //    return obj;
        //}

        ///// <summary>
        ///// Get Operation No
        ///// </summary>
        ///// <param name="FgPartNo"></param>
        ///// <returns></returns>
        //public CommonResponse GetOperationNo(string FgPartNo, int PlanLinkageId)
        //{
        //    CommonResponse obj = new CommonResponse();
        //    try
        //    {
        //        var check = (from wf in db.TblPlanLinkageMaster
        //                     where wf.IsDeleted == 0 && wf.FgPartNo == FgPartNo && wf.PlanLinkageId == PlanLinkageId
        //                     select new
        //                     {
        //                         OperationNo = wf.Operation,
        //                         RoutingId = wf.RoutingId,
        //                         PlanLinkageId = wf.PlanLinkageId
        //                     }).ToList();
        //        if (check.Count > 0)
        //        {
        //            obj.isStatus = true;
        //            obj.response = check;
        //        }
        //        else
        //        {
        //            obj.isStatus = false;
        //            obj.response = ResourceResponse.NoItemsFound;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        obj.isStatus = false;
        //        obj.response = ResourceResponse.FailureMessage;
        //    }
        //    return obj;
        //}

        ///// <summary>
        ///// Get WorkOrder Qty
        ///// </summary>
        ///// <param name="operationNo"></param>
        ///// <returns></returns>
        //public CommonResponse GetWorkOrderQty(int operationNo, int PlanLinkageId)
        //{
        //    CommonResponse obj = new CommonResponse();
        //    try
        //    {
        //        var check = (from wf in db.TblPlanLinkageMaster
        //                     where wf.IsDeleted == 0 && wf.Operation == operationNo && wf.PlanLinkageId == PlanLinkageId
        //                     select new
        //                     {
        //                         WorkOrderQty = wf.WorkOrderQty,
        //                         PlanLinkageId = wf.PlanLinkageId
        //                     }).ToList();
        //        if (check.Count > 0)
        //        {
        //            obj.isStatus = true;
        //            obj.response = check;
        //        }
        //        else
        //        {
        //            obj.isStatus = false;
        //            obj.response = ResourceResponse.NoItemsFound;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        obj.isStatus = false;
        //        obj.response = ResourceResponse.FailureMessage;
        //    }
        //    return obj;
        //}

        ///// <summary>
        ///// View Multiple Part No
        ///// </summary>
        ///// <param name="opearationNo"></param>
        ///// <returns></returns>
        //public CommonResponse ViewMultiplePartNo(int opearationNo,int machineId)
        //{
        //    CommonResponse obj = new CommonResponse();
        //    try
        //    {
        //        var machineName = db.Tblmachinedetails.Where(m => m.MachineId == machineId).Select(m => m.MachineName).FirstOrDefault();

        //        var check = (from wf in db.Tblparts
        //                     where wf.IsDeleted == 0 && wf.OperationNo == Convert.ToString(opearationNo) && wf.ResourceId == machineName
        //                     select new
        //                     {
        //                         PartId = wf.PartId,
        //                         PartNo = wf.Fgcode
        //                     }).ToList();
        //        if (check.Count > 0)
        //        {
        //            obj.isStatus = true;
        //            obj.response = check;
        //        }
        //        else
        //        {
        //            obj.isStatus = false;
        //            obj.response = ResourceResponse.NoItemsFound;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        obj.isStatus = false;
        //        obj.response = ResourceResponse.FailureMessage;
        //    }
        //    return obj;
        //}

        /// <summary>
        /// Add Update Fg Part No
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public GeneralResponse AddUpdateFgPartNo(AddUpdateFgPartNo data)
        {
            GeneralResponse obj = new GeneralResponse();
            CommonFunction commonFunction = new CommonFunction();
            try
            {
                string shift = commonFunction.GetCurrentShift();
                string correctedDate = commonFunction.GetCorrectedDate();
                var loginTrackerDetails = commonFunction.GetLoginTrackerDetailsLastRow(correctedDate, data.machineId);
                var machineName = db.Tblmachinedetails.Where(m => m.MachineId == data.machineId && m.IsDeleted == 0).Select(m => m.MachineName).FirstOrDefault();

                if (loginTrackerDetails != null)
                {
                    #region Add and Update FGPart
                    var check = db.TblFgPartNoDet.Where(m => m.FgPartId == data.fgPartId).FirstOrDefault();
                    if (check == null)
                    {
                        TblFgPartNoDet tblFgPartNoDet = new TblFgPartNoDet();
                        tblFgPartNoDet.OperationNo = data.operationNo;
                        tblFgPartNoDet.NoOfPartsPerCycle = data.noOfPartsPerCycle;
                        tblFgPartNoDet.PartCountMethod = data.partsCountMethod;
                        tblFgPartNoDet.WorkOrderNo = data.workOrderNo;
                        tblFgPartNoDet.IsDeleted = 0;
                        tblFgPartNoDet.CreatedOn = DateTime.Now;
                        tblFgPartNoDet.MachineId = data.machineId;
                        tblFgPartNoDet.OperatorId = data.operatorId;
                        tblFgPartNoDet.MachineId = data.machineId;
                        tblFgPartNoDet.CorrectedDate = correctedDate;
                        tblFgPartNoDet.StartDate = DateTime.Now;
                        tblFgPartNoDet.Shift = shift;
                        tblFgPartNoDet.PlanLinkageId = data.planLinkageId;
                        db.TblFgPartNoDet.Add(tblFgPartNoDet);
                        db.SaveChanges();
                        obj.fgPartId = tblFgPartNoDet.FgPartId;
                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;
                        obj.partNo = db.TblPlanLinkageMaster.Where(m => m.PlanLinkageId == tblFgPartNoDet.PlanLinkageId).Select(m => m.FgPartNo).FirstOrDefault();
                    }
                    else
                    {
                        //var fgPartNo = db.TblPlanLinkageMaster.Where(m => m.PlanLinkageId == data.partId).Select(m => m.FgPartNo).FirstOrDefault();
                        //var partId = db.Tblparts.Where(m => m.Fgcode == fgPartNo && m.ResourceId == machineName).Select(m => m.PartId).FirstOrDefault();
                        //if (partId > 0)
                        //{
                        //    check.PartId = partId;
                        //}
                        //check.PartId = data.partId;
                        check.OperationNo = data.operationNo;
                        check.NoOfPartsPerCycle = data.noOfPartsPerCycle;
                        check.PartCountMethod = data.partsCountMethod;
                        check.WorkOrderNo = data.workOrderNo;
                        check.IsDeleted = 0;
                        check.ModifiedOn = DateTime.Now;
                        check.OperatorId = data.operatorId;
                        check.MachineId = data.machineId;
                        check.CorrectedDate = correctedDate;
                        check.PlanLinkageId = data.planLinkageId;
                        check.Shift = shift;
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.UpdatedSuccessMessage;
                        obj.fgPartId = check.FgPartId;
                        obj.partNo = db.TblPlanLinkageMaster.Where(m => m.PlanLinkageId == check.PlanLinkageId).Select(m => m.FgPartNo).FirstOrDefault();
                    }
                    #endregion

                    #region Update last row of logged in user details 
                    loginTrackerDetails.CurrentFgpart = obj.fgPartId;
                    db.LoginTrackerDetails.Update(loginTrackerDetails);
                    db.SaveChanges();
                    #endregion
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = ResourceResponse.LoginAgain;
                }
            }
            catch (Exception e)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            commonFunction.LogFile(obj.response);
            return obj;
        }

        /// <summary>
        /// View Multiple Fg Part No
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleFgPartNo(int machineId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                CommonFunction commonFunction = new CommonFunction();
                string shift = commonFunction.GetCurrentShift();
                string correctedDate = commonFunction.GetCorrectedDate();
                int shopId = 0;
                int cellId = 0;
                var check = (from wf in db.TblFgPartNoDet
                             where wf.IsDeleted == 0 && wf.CorrectedDate == correctedDate && wf.MachineId == machineId && wf.IsClosed != 1
                             select new
                             {
                                 fgpartId = wf.FgPartId,
                                 partNo = db.TblPlanLinkageMaster.Where(m => m.PlanLinkageId == wf.PlanLinkageId).Select(m => m.FgPartNo).FirstOrDefault(),
                                 partDesc = db.TblPlanLinkageMaster.Where(m => m.PlanLinkageId == wf.PlanLinkageId).Select(m => m.PartName).FirstOrDefault(),
                                 partId = wf.PartId,
                                 shopId = db.Tblmachinedetails.Where(m => m.MachineId == machineId).Select(m => m.ShopId).FirstOrDefault(),
                                 cellName = db.TblCellFinalMaster.Where(m => m.CellFinalId == shopId).Select(m => m.CellFinalName).FirstOrDefault(),
                                 cellId = db.Tblmachinedetails.Where(m => m.MachineId == machineId).Select(m => m.CellId).FirstOrDefault(),
                                 subCellName = db.TblSubCellFinalMaster.Where(m => m.SubCellFinalId == cellId).Select(m => m.SubCellFinalName).FirstOrDefault(),
                                 machineName = db.Tblmachinedetails.Where(m => m.MachineId == machineId).Select(m => m.MachineName).FirstOrDefault(),
                                 PartCountMethod = wf.PartCountMethod,
                                 WorkOrderNo = wf.WorkOrderNo,
                                 OperationNo = wf.OperationNo,
                                 NoOfPartsPerCycle = wf.NoOfPartsPerCycle
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
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// View Multiple Fg Part No
        /// </summary>
        /// <param name="fgPartId"></param>
        /// <returns></returns>
        public CommonResponse ViewMultipleFgPartNoById(int fgPartId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblFgPartNoDet
                             where wf.IsDeleted == 0 && wf.FgPartId == fgPartId && wf.IsClosed != 1
                             select new
                             {
                                 fgpartId = wf.FgPartId,
                                 partNo = db.TblPlanLinkageMaster.Where(m => m.PlanLinkageId == wf.PlanLinkageId).Select(m => m.FgPartNo).FirstOrDefault(),
                                 partDesc = db.TblPlanLinkageMaster.Where(m => m.PlanLinkageId == wf.PlanLinkageId).Select(m => m.PartName).FirstOrDefault(),
                                 //partId = wf.PartId,
                                 PartCountMethod = wf.PartCountMethod,
                                 WorkOrderNo = wf.WorkOrderNo,
                                 OperationNo = wf.OperationNo,
                                 NoOfPartsPerCycle = wf.NoOfPartsPerCycle,
                                 PlanLinkageId = wf.PlanLinkageId
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
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Close Fg Part No
        /// </summary>
        /// <param name="fgPartId"></param>
        /// <returns></returns>
        public CommonResponse CloseFgPartNo(int fgPartId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                CommonFunction commonFunction = new CommonFunction();
                string shift = commonFunction.GetCurrentShift();
                string correctedDate = commonFunction.GetCorrectedDate();

                var check = db.TblFgPartNoDet.Where(m => m.FgPartId == fgPartId && m.IsDeleted == 0).FirstOrDefault();
                if (check != null)
                {
                    check.IsClosed = 1;
                    check.ClosedDate = DateTime.Now;
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = "Fg Part Number Closed Successfully";
                }

                #region Update last row of logged in user details 

                var loginTrackerDetails = commonFunction.GetLoginTrackerDetailsLastRow(check.CorrectedDate, Convert.ToInt32(check.MachineId));
                if (loginTrackerDetails != null)
                {
                    var check1 = db.LoginTrackerDetails.Where(m => m.MachineId == check.MachineId && m.CorrectedDate == check.CorrectedDate && m.CurrentFgpart == check.FgPartId).FirstOrDefault();
                    if (check1 != null)
                    {
                        check1.CurrentFgpart = null;
                        db.SaveChanges();
                    }
                }

                #endregion
            }
            catch (Exception e)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }
    }
}
