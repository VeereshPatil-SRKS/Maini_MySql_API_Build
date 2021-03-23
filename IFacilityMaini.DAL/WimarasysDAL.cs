using IFacilityMaini.DAL.Resource;
using IFacilityMaini.DBModels;
using IFacilityMaini.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using IFacilityMaini.DAL.App_Start;
using static IFacilityMaini.EntityModels.WimarasysEntity;

namespace IFacilityMaini.DAL
{
    public class WimarasysDAL : IWimarasys
    {
        unitworksccsContext db = new unitworksccsContext();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(FgPartNoDAL));
        public static IConfiguration configuration;

        public WimarasysDAL(unitworksccsContext _db, IConfiguration _configuration)
        {
            db = _db;
            configuration = _configuration;
        }

        /// <summary>
        /// Get OperationNo Based On Part No
        /// </summary>
        /// <param name="partNo"></param>
        /// <returns></returns>
        public CommonResponse GetOperationNoBasedOnPartNo(string woNo)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblplanlinkagemaster
                             where wf.IsDeleted == 0 && wf.ProductionOrder == woNo
                             select new
                             {
                                 operation = wf.Operation
                             }).Distinct().ToList();
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
        /// Get Running Balance
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse GetRunningBalance(GetRunningQuantityCustom data)
        {
            CommonResponse obj = new CommonResponse();
            CommonFunction commonFunction = new CommonFunction();
            string correctedDate = commonFunction.GetCorrectedDate();
            DateTime correctedDate1 = Convert.ToDateTime(correctedDate);
            DateTime currentDateTime = DateTime.Now;
            //DateTime currentDateTime = Convert.ToDateTime("11-09-2020 09:00:00");
            string shift = commonFunction.GetCurrentShift();
            //string shift = "A";
            var shiftStartTime = db.UnitworkccsTblshiftMstr.Where(m => m.ShiftName == shift).Select(m => m.StartTime).FirstOrDefault();
            //var shiftStartTime = "06:00:00";
            var shiftStartDateTime = correctedDate + " " + shiftStartTime;
            DateTime shiftDateTime = Convert.ToDateTime(shiftStartDateTime);
            int Actual2 = 0;
            int TotalActualPart = 0;

            try
            {

                var check = db.UnitworkccsTblfgpartnodet.Where(wf => wf.CorrectedDate == correctedDate && wf.FgPartNo == data.partNo && wf.WorkOrderNo == data.woNo && wf.OperationNo == data.operation && wf.Shift == shift && wf.IsClosed != 1).Distinct().ToList();

                if (check.Count > 0)
                {
                    foreach(var item in check)
                    {
                        var machine = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == item.MachineId && m.IsPcb == 1).FirstOrDefault();

                        if (machine == null)
                        {
                            var parametermasterlistAll = db.UnitworkccsParametersMaster.Where(m => m.CorrectedDate == correctedDate1 && m.InsertedOn >= shiftDateTime && m.InsertedOn <= currentDateTime).ToList();
                            var parametermasterlist = parametermasterlistAll.Where(m => m.MachineId == item.MachineId && m.CorrectedDate == correctedDate1 && m.InsertedOn >= shiftDateTime && m.InsertedOn <= currentDateTime).ToList();
                            var TopRow = parametermasterlist.OrderByDescending(m => m.ParameterId).FirstOrDefault();
                            var LastRow = parametermasterlist.OrderBy(m => m.ParameterId).FirstOrDefault();

                            if (TopRow != null && LastRow != null)
                            {
                                Actual2 = Convert.ToInt32(TopRow.PartsTotal - LastRow.PartsTotal);
                            }

                            Actual2 = Actual2 * Convert.ToInt32(item.NoOfPartsPerCycle);
                            TotalActualPart += Actual2;
                        }
                        else
                        {
                            var parametermasterlistLast = db.UnitworkccsTblpartscountandcutting.Where(m => m.MachineId == item.MachineId && m.CorrectedDate == correctedDate1 && m.StartTime >= shiftDateTime && m.EndTime <= currentDateTime).ToList().Sum(m => m.PartCount);

                            Actual2 = parametermasterlistLast;
                            TotalActualPart += Actual2;
                        }
                    }

                    var dbCheck = db.UnitworkccsTblfgpartnodet.Where(wf => wf.CorrectedDate == correctedDate && wf.FgPartNo == data.partNo && wf.WorkOrderNo == data.woNo && wf.OperationNo == data.operation && wf.Shift == shift && wf.IsClosed != 1).FirstOrDefault();
                    GetRunningBalanceQuantityDetails getRunningBalanceQuantityDetails = new GetRunningBalanceQuantityDetails();
                    if (dbCheck != null)
                    {
                        if (TotalActualPart != 0)
                        {
                            getRunningBalanceQuantityDetails.idealCycleTime = dbCheck.IdealCycleTime;
                            getRunningBalanceQuantityDetails.unit = dbCheck.Unit;
                            decimal woBalanceQ = Convert.ToDecimal(dbCheck.PartCountMethod);
                            int wo = Convert.ToInt32(woBalanceQ);
                            getRunningBalanceQuantityDetails.runningBalance = wo - TotalActualPart;
                        }
                        else
                        {
                            getRunningBalanceQuantityDetails.idealCycleTime = dbCheck.IdealCycleTime;
                            getRunningBalanceQuantityDetails.unit = dbCheck.Unit;
                            decimal woBalanceQ = Convert.ToDecimal(dbCheck.PartCountMethod);
                            int wo = Convert.ToInt32(woBalanceQ);
                            getRunningBalanceQuantityDetails.runningBalance = wo;
                        }
                    }
                    obj.isStatus = true;
                    obj.response = getRunningBalanceQuantityDetails;
                }
                else
                {
                    var planVisageData = db.UnitworkccsTblplanlinkagemaster.Where(m => m.FgPartNo == data.partNo && m.ProductionOrder == data.woNo && m.Operation == data.operation).FirstOrDefault();
                    GetRunningBalanceQuantityDetails getRunningBalanceQuantityDetails = new GetRunningBalanceQuantityDetails();
                    if (planVisageData != null)
                    {
                        getRunningBalanceQuantityDetails.idealCycleTime = planVisageData.IdealCycleTime;
                        getRunningBalanceQuantityDetails.unit = planVisageData.Unit;
                        getRunningBalanceQuantityDetails.runningBalance = Convert.ToInt32(planVisageData.WorkOrderQty - planVisageData.WorkOrderCompletedQty);
                    }
                    obj.isStatus = true;
                    obj.response = getRunningBalanceQuantityDetails;
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
        /// Get Wo Number
        /// </summary>
        /// <param name="partNo"></param>
        /// <param name="machineNo"></param>
        /// <returns></returns>
        public CommonResponse GetWoNumber(string partNo)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblplanlinkagemaster
                             where wf.FgPartNo == partNo
                             select new
                             {
                                 wf.ProductionOrder
                             }).Distinct().ToList();
                if(check.Count > 0)
                {
                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    obj.isStatus = true;
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
        /// Defect Codes
        /// </summary>
        /// <param name="partNo"></param>
        /// <returns></returns>
        public CommonResponse DefectCodes(string partNo)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check  = (from wf in db.UnitworkccsTblproductwisedefectcodes
                                         where wf.IsDeleted == 0 && wf.PartNo == partNo
                                         select new
                                         {
                                             defectCodeId = wf.DefectCodeId,
                                             DefectCodeName = db.UnitworkccsTbldefectcodemaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeName).FirstOrDefault() + " - " + db.UnitworkccsTbldefectcodemaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeDesc).FirstOrDefault()
                                         }).ToList();

                if(check.Count > 0)
                {
                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    var dbCheck = (from wf in db.UnitworkccsTblgeneraldefectcodes
                                 where wf.IsDeleted == 0
                                 select new
                                 {
                                     DefectCodeId = wf.GeneralDefectCodeId,
                                     DefectCodeName = wf.DefectCodeName + " - " + wf.DefectCodeDesc
                                 }).ToList();

                    if (dbCheck.Count > 0)
                    {
                        obj.isStatus = true;
                        obj.response = dbCheck;
                    }
                    else
                    {
                        obj.isStatus = false;
                        obj.response = ResourceResponse.NoItemsFound;
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
        /// Get Part No Deatails
        /// </summary>
        /// <param name="partNo"></param>
        /// <returns></returns>
        public CommonResponse GetPartNoDeatails(string partNo)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblfgandcellallocation
                             where wf.PartNo == partNo && wf.IsDeleted == 0
                             select new
                             {
                                 subCellFinalId = wf.SubCellFinalId,
                                 cellFinalId = wf.CellFinalId,
                                 subcellName = db.UnitworkccsTblcell.Where(m => m.CellId == wf.SubCellFinalId).Select(m => m.CellName).FirstOrDefault(),
                                 cellName = db.UnitworkccsTblshop.Where(m => m.ShopId == wf.CellFinalId).Select(m => m.ShopName).FirstOrDefault(),
                                 partName = wf.PartName
                             });

                if(check != null)
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
        /// Get General Defect Codes
        /// </summary>
        /// <returns></returns>
        public CommonResponse GetGeneralDefectCodes()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblgeneraldefectcodes
                             where wf.IsDeleted == 0
                             select new
                             {
                                 defectCodeName = wf.DefectCodeName,
                                 defectCodeDesc = wf.DefectCodeDesc,
                                 generalDefectCodeId = wf.GeneralDefectCodeId
                             });

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
        /// Get Fg Part No
        /// </summary>
        /// <param name="plantId"></param>
        /// <returns></returns>
        public CommonResponse GetFgPartNo(int plantId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblfgandcellallocation
                             where wf.PlantId == plantId && wf.IsDeleted == 0
                             select new
                             {
                                 partNo = wf.PartNo,
                                 partName = wf.PartName
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
        /// Get Child Part No
        /// </summary>
        /// <param name="partNo"></param>
        /// <returns></returns>
        public CommonResponse GetChildPartNo(string partNo)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblchildfgpartno
                             where wf.FgPartNo == partNo && wf.IsDeleted == 0
                             select new
                             {
                                 childFgPartNo = wf.ChildFgPartNo,
                                 childPartNoDesc = wf.ChildPartNoDesc
                             }).ToList();

                if (check.Count > 0)
                {
                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = ResourceResponse.FailureMessage;
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
        /// Get Machine List
        /// </summary>
        /// <param name="plantId"></param>
        /// <returns></returns>
        public CommonResponse GetMachineList(int plantId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblmachinedetails
                             where wf.PlantId == plantId && wf.IsDeleted == 0
                             select new
                             {
                                 machineId = wf.MachineId,
                                 machineName = wf.MachineName,
                                 wf.MachineDescription,
                                 wf.MachineDisplayName,
                                 cellId = wf.CellId,
                                 shopId = wf.ShopId
                             }).ToList();

                if (check.Count > 0)
                {
                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = ResourceResponse.FailureMessage;
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




    }
}
