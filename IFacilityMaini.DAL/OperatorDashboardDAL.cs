using IFacilityMaini.DAL.App_Start;
using IFacilityMaini.DAL.Helpers;
using IFacilityMaini.DAL.Resource;
using IFacilityMaini.DBModels;
using IFacilityMaini.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.OperatorDashboardEntity;

namespace IFacilityMaini.DAL
{
    public class OperatorDashboardDAL : IOperatorDashboard
    {
        unitworksccsContext db = new unitworksccsContext();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(OperatorDashboardDAL));
        public static IConfiguration configuration;
        private readonly AppSettings appSettings;

        public OperatorDashboardDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings)
        {
            db = _db;
            configuration = _configuration;
            appSettings = _appSettings.Value;
        }

        /// <summary>
        /// Redirect The Page
        /// </summary>
        /// <param name="HostName"></param>
        /// <param name="IpAddress"></param>
        /// <returns></returns>
        public CommonResponse RedirectThePage(string HostName, string IpAddress)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTblsystemconfig.Where(m => m.PcHostName == HostName && m.PcIpAddress == IpAddress && m.IsDeleted == 0).FirstOrDefault();
                if (check != null)
                {
                    obj.isStatus = true;
                    obj.response = "Operator Page";
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = "Login Page";
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

        ///// <summary>
        ///// Get The Machine Details
        ///// </summary>
        ///// <param name="HostName"></param>
        ///// <param name="IpAddress"></param>
        ///// <returns></returns>
        //public CommonResponse GetTheMachineDetails(string HostName, string IpAddress)
        //{
        //    CommonResponse obj = new CommonResponse();
        //    try
        //    {
        //        var check = (from wf in db.UnitworkccsTblsystemconfig
        //                     where wf.PcHostName == HostName && wf.PcIpAddress == IpAddress && wf.IsDeleted == 0
        //                     select new
        //                     {
        //                        wf.MachineId,
        //                        wf.SystemConfigId
        //                     }).FirstOrDefault();

        //        string[] ids = check.MachineId.Split(',');
        //        List<MachineDetails> MachineDetailsList = new List<MachineDetails>();

        //        foreach (var item in ids)
        //        {
        //            int machineId = Convert.ToInt32(item);
        //            var dbCheck = (from wf in db.UnitworkccsTblmachinedetails
        //                           where wf.MachineId == machineId && wf.IsDeleted == 0
        //                           select new
        //                           {
        //                               machineId = wf.MachineId,
        //                               machineInvNo = wf.MachineInvNo,
        //                               machineDispName = wf.MachineDispName,
        //                               machineMake = wf.MachineMake,
        //                               machineModel = wf.MachineModel,
        //                               plantId = wf.PlantId,
        //                               shopId = wf.ShopId,
        //                               cellD = wf.CellD
        //                           }).FirstOrDefault();

        //            if (dbCheck != null)
        //            {
        //                MachineDetails machineDetails = new MachineDetails();
        //                machineDetails.machineId = dbCheck.machineId;
        //                machineDetails.machineInvNo = dbCheck.machineInvNo;
        //                machineDetails.machineMake = dbCheck.machineMake;
        //                machineDetails.machineModel = dbCheck.machineModel;
        //                machineDetails.plantId = Convert.ToInt32(dbCheck.plantId);
        //                machineDetails.shopId = Convert.ToInt32(dbCheck.shopId);
        //                machineDetails.cellId = Convert.ToInt32(dbCheck.cellD);
        //                MachineDetailsList.Add(machineDetails);
        //            }
        //        }
        //        obj.isStatus = true;
        //        obj.response = MachineDetailsList;
        //    }
        //    catch(Exception e)
        //    {
        //        obj.isStatus = false;
        //        obj.response = ResourceResponse.FailureMessage;
        //    }
        //    return obj;
        //}

        /// <summary>
        /// Get The Machine Details
        /// </summary>
        /// <param name="HostName"></param>
        /// <param name="IpAddress"></param>
        /// <returns></returns>
        public CommonResponseGraph GetTheMachineDetails(string HostName, string IpAddress)
        {
            CommonResponseGraph obj = new CommonResponseGraph();
            try
            {
                CommonFunction commonFunction = new CommonFunction();
                ResponseMessage objgraph = new ResponseMessage();
                string shift = commonFunction.GetCurrentShift();
                string correctedDate = commonFunction.GetCorrectedDate();
                bool flag = false;
                int machineId = 0;
                int ticketId = 0;

                var check = (from wf in db.UnitworkccsTblsystemconfig
                             where wf.PcHostName == HostName && wf.PcIpAddress == IpAddress && wf.IsDeleted == 0
                             select new
                             {
                                 MachineId = wf.MachineId,
                                 SystemConfigId = wf.SystemConfigId
                             }).FirstOrDefault();

                string[] ids = check.MachineId.Split(',');
                List<MachineDetails> MachineDetailsList = new List<MachineDetails>();

                foreach (var item in ids)
                {
                    try
                    {
                        machineId = Convert.ToInt32(item);
                    }
                    catch (Exception e)
                    {
                        log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                        obj.isStatus = false;
                        obj.response = 1;
                    }

                    objgraph = GraphDetails(machineId);
                    if (objgraph.isStatus == false)
                    {
                        Response response = new Response();
                        graphDetails graphDetails = new graphDetails();
                        graphDetails.propOee = Convert.ToDouble(0.1);
                        graphDetails.availblity = Convert.ToDouble(0.1);
                        graphDetails.performance = Convert.ToDouble(0.1);
                        graphDetails.quality = Convert.ToDouble(0.1);
                        graphDetails.runningBalance = 0;
                        graphDetails.woBalance = 0;

                        tableDetails tableDetails = new tableDetails();
                        tablePartsDetails tablePartsDetails1 = new tablePartsDetails();
                        tablePartsDetails1.actual = 0;
                        tablePartsDetails1.target = 0;
                        tablePartsDetails1.rejectionQty = 0;
                        tablePartsDetails1.reworkQty = 0;
                        tablePartsDetails1.okQty = 0;
                        tableDetails.partCountShiftDetails = tablePartsDetails1;

                        tablePartsDetails tablePartsDetails2 = new tablePartsDetails();
                        tablePartsDetails2.actual = 0;
                        tablePartsDetails2.target = 0;
                        tablePartsDetails2.okQty = 0;
                        tableDetails.totalPartHrDetails = tablePartsDetails2;

                        tablePartsDetails tablePartsDetails3 = new tablePartsDetails();
                        tablePartsDetails3.actual = 0;
                        tablePartsDetails3.target = 0;
                        tableDetails.trialPartCountDetails = tablePartsDetails3;

                        tablePartsDetails tablePartsDetails4 = new tablePartsDetails();
                        tablePartsDetails4.actual = 0;
                        tablePartsDetails4.target = 0;
                        tableDetails.dryRunCountDetails = tablePartsDetails4;


                        obj.isStatus = true;
                        response.graphDetails = graphDetails;
                        response.tableDetails = tableDetails;
                        objgraph.isStatus = true;
                        objgraph.response = response;
                    }
                    var dbCheck = (from wf in db.UnitworkccsTblmachinedetails
                                   where wf.MachineId == machineId && wf.IsDeleted == 0
                                   select new
                                   {
                                       machineId = wf.MachineId,
                                       machineInvNo = wf.MachineName,
                                       machineDispName = wf.MachineDisplayName,
                                       machineMake = wf.MachineMake,
                                       machineModel = wf.MachineModel,
                                       plantId = wf.PlantId,
                                       shopId = wf.ShopId,
                                       cellD = wf.CellId,
                                       //ticketDetails = db.UnitworkccsTblraisedticket.Where(m => m.IsDeleted == 0 && m.MachineId == wf.MachineId).OrderByDescending(m => m.TicketId).FirstOrDefault(),
                                   }).FirstOrDefault();

                    if (dbCheck != null)
                    {
                        CheckMacIdleAndSendToMsg(machineId);

                        //SendSms(machineId);

                        var UnitworkccsLogintrackerdetails = db.UnitworkccsLogintrackerdetails.Where(m => m.CorrectedDate == correctedDate && m.MachineId == dbCheck.machineId && m.IsLoggedIn == 0).OrderByDescending(m => m.LoginTrackerDetailsId).FirstOrDefault();

                        var ticketStatus = db.UnitworkccsTblraisedticket.Where(m => m.MachineId == dbCheck.machineId && m.Status != 4 && m.Status != 5).OrderByDescending(m => m.TicketId).FirstOrDefault();

                        MachineDetails machineDetails = new MachineDetails();

                        machineDetails.machineId = dbCheck.machineId;
                        machineDetails.machineInvNo = dbCheck.machineInvNo;
                        machineDetails.machineMake = dbCheck.machineMake;
                        machineDetails.machineModel = dbCheck.machineModel;
                        //machineDetails.woBalanceQty = 23;
                        //machineDetails.runningBalance = 67;
                        //machineDetails.cellName = db.UnitworkccsTblcellFinalMaster.Where(m => m.CellFinalId == dbCheck.shopId).Select(m => m.CellFinalName).FirstOrDefault();
                        //machineDetails.subCellName = db.TblSubCellFinalMaster.Where(m => m.SubCellFinalId == dbCheck.cellD).Select(m => m.SubCellFinalName).FirstOrDefault();
                        //machineDetails.UnitworkccsTblraisedticket = dbCheck.ticketDetails;
                        if (UnitworkccsLogintrackerdetails != null)
                        {
                            machineDetails.FgPartId = UnitworkccsLogintrackerdetails.CurrentFgpart;
                            if (UnitworkccsLogintrackerdetails.CurrentFgpart != null)
                            {
                                machineDetails.fgPartFlag = true;

                                var fgPart = db.UnitworkccsTblfgpartnodet.Where(m => m.FgPartId == UnitworkccsLogintrackerdetails.CurrentFgpart).FirstOrDefault();

                                if (fgPart != null)
                                {
                                    machineDetails.partNo = db.UnitworkccsTblplanlinkagemaster.Where(m => m.PlanLinkageId == fgPart.PlanLinkageId).Select(m => m.FgPartNo).FirstOrDefault();
                                    var partNo = db.UnitworkccsTblplanlinkagemaster.Where(m => m.PlanLinkageId == fgPart.PlanLinkageId).Select(m => m.FgPartNo).FirstOrDefault();
                                    machineDetails.dmcCodeStatus = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.DmcCodeStatus).FirstOrDefault();
                                    var cellId = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.CellFinalId).FirstOrDefault();
                                    var subCellId = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.SubCellFinalId).FirstOrDefault();
                                    machineDetails.cellName = db.UnitworkccsTblshop.Where(m => m.ShopId == cellId).Select(m => m.ShopName).FirstOrDefault();
                                    machineDetails.subCellName = db.UnitworkccsTblcell.Where(m => m.CellId == subCellId).Select(m => m.CellName).FirstOrDefault();
                                    try
                                    {
                                        machineDetails.operationNo = Convert.ToInt32(fgPart.OperationNo);
                                    }
                                    catch (Exception e)
                                    {
                                        log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                                        obj.isStatus = false;
                                        obj.response = 2;
                                    }
                                    machineDetails.workOrderNo = fgPart.WorkOrderNo;
                                    machineDetails.fgPartDesc = db.UnitworkccsTblplanlinkagemaster.Where(m => m.PlanLinkageId == fgPart.PlanLinkageId).Select(m => m.PartName).FirstOrDefault();

                                    var dryRun = db.UnitworkccsTbldryrun.Where(m => m.FgPartId == fgPart.FgPartId && m.MachineId == dbCheck.machineId).OrderByDescending(m => m.DryRunId).FirstOrDefault();
                                    if (dryRun != null)
                                    {
                                        if (dryRun.StartDate != null && dryRun.EndDate == null)
                                        {
                                            machineDetails.dryRunFlag = 1;
                                            machineDetails.dryRunId = dryRun.DryRunId;
                                            machineDetails.dryRunStatus = "Dry Run is in Progress";
                                            machineDetails.dryRunUserName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == dryRun.UserId).Select(m => m.OperatorName).FirstOrDefault();

                                        }
                                        else if (dryRun.StartDate != null && dryRun.EndDate != null)
                                        {
                                            machineDetails.dryRunFlag = 0;
                                            machineDetails.dryRunId = 0;
                                            machineDetails.dryRunStatus = "";
                                        }
                                    }
                                }
                            }
                            //machineDetails.ticketId = UnitworkccsLogintrackerdetails.CurrentTicketRaisedId;
                            machineDetails.isLoggedIn = Convert.ToBoolean(UnitworkccsLogintrackerdetails.IsLoggedIn);
                            machineDetails.shift = UnitworkccsLogintrackerdetails.Shift;
                            machineDetails.operatorName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == UnitworkccsLogintrackerdetails.OperatorId).Select(m => m.OperatorName).FirstOrDefault();
                            if (UnitworkccsLogintrackerdetails.CurrentFgpart == null)
                            {
                                machineDetails.fgPartFlag = false;
                            }
                            //else
                            //{
                            //    machineDetails.fgPartFlag = true;
                            //}
                            var checkTicketRaisedOrNot = db.UnitworkccsTblraisedticket.Where(m => m.MachineId == dbCheck.machineId && m.Status == 1).ToList();
                            if (checkTicketRaisedOrNot.Count == 0)
                            {
                                machineDetails.dtTicketFlag = false;
                                machineDetails.ticketClsByMaintainTeam = 0;
                                machineDetails.status = "";

                                if (ticketStatus != null)
                                {

                                    var maintainanceCheck = db.UnitworkccsTblticketraiseddet.Where(m => m.MachineId == ticketStatus.MachineId && m.IfSupportTeamOpen == 2 && m.IsStatus == 3).ToList();

                                    if (maintainanceCheck.Count == 0)
                                    {
                                        flag = false;
                                    }
                                    else
                                    {
                                        flag = true;
                                    }

                                    if (flag == true)
                                    {
                                        machineDetails.ticketClsByMaintainTeam = 2;
                                    }

                                    var className = db.UnitworkccsTblclassmaster.Where(m => m.ClassId == ticketStatus.ClassId).Select(m => m.ClassName).FirstOrDefault();
                                    var statusName = db.UnitworkccsTblstatusmaster.Where(m => m.StatusId == ticketStatus.StatusId).Select(m => m.StatusName).FirstOrDefault();
                                    var reasonName = db.UnitworkccsTblstoppage.Where(m => m.StoppagesId == ticketStatus.ReasonId).Select(m => m.AlramDesc).FirstOrDefault();

                                    if (statusName == "Running with Issue" && className == "Downtime")
                                    {
                                        machineDetails.status = className + "-" + statusName + "-" + "BDR" + "-" + reasonName;
                                        machineDetails.statusColor = "Yellow";
                                    }
                                    else if (statusName == "Stopped" && className == "Downtime")
                                    {
                                        machineDetails.status = className + "-" + statusName + "-" + "BDS" + "-" + reasonName;
                                        machineDetails.statusColor = "Red";
                                    }
                                    else if (className == "Improvement")
                                    {
                                        machineDetails.status = className + "-" + "IMP" + "-" + reasonName;
                                    }
                                    machineDetails.dtTicketFlag = true;
                                }
                            }

                            else
                            {
                                machineDetails.dtTicketFlag = true;
                                var checkStatus = db.UnitworkccsTblraisedticket.Where(m => m.MachineId == dbCheck.machineId).ToList();
                                foreach (var item1 in checkStatus)
                                {
                                    try
                                    {
                                        ticketId = Convert.ToInt32(item1.TicketId);
                                    }
                                    catch (Exception e)
                                    {
                                        log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                                        obj.isStatus = false;
                                        obj.response = 3;
                                    }

                                    var maintainanceCheck = db.UnitworkccsTblticketraiseddet.Where(m => m.TicketId == ticketId && m.IfSupportTeamOpen == 2 && m.IsStatus == 3).FirstOrDefault();

                                    if (maintainanceCheck == null)
                                    {
                                        flag = false;
                                    }
                                    else
                                    {
                                        flag = true;
                                        break;
                                    }
                                }

                                if (flag == true)
                                {
                                    machineDetails.ticketClsByMaintainTeam = 2;
                                }


                                if (ticketStatus != null)
                                {
                                    var className = db.UnitworkccsTblclassmaster.Where(m => m.ClassId == ticketStatus.ClassId).Select(m => m.ClassName).FirstOrDefault();
                                    var statusName = db.UnitworkccsTblstatusmaster.Where(m => m.StatusId == ticketStatus.StatusId).Select(m => m.StatusName).FirstOrDefault();
                                    var reasonName = db.UnitworkccsTblstoppage.Where(m => m.StoppagesId == ticketStatus.ReasonId).Select(m => m.AlramDesc).FirstOrDefault();

                                    if (statusName == "Running with Issue" && className == "Downtime")
                                    {
                                        machineDetails.status = className + "-" + statusName + "-" + "BDR" + "-" + reasonName;
                                        machineDetails.statusColor = "Yellow";
                                    }
                                    else if (statusName == "Stopped" && className == "Downtime")
                                    {
                                        machineDetails.status = className + "-" + statusName + "-" + "BDS" + "-" + reasonName;
                                        machineDetails.statusColor = "Red";
                                    }
                                    else if (className == "Improvement")
                                    {
                                        machineDetails.status = className + "-" + "IMP" + "-" + reasonName;
                                    }
                                }
                            }
                            machineDetails.operatorId = UnitworkccsLogintrackerdetails.OperatorId;
                            DateTime LoginDateTime = Convert.ToDateTime(UnitworkccsLogintrackerdetails.LoginDateTime);
                            string dt = LoginDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                            string[] dateTime = dt.Split(' ');

                            machineDetails.loginDate = Convert.ToString(dateTime[0]);
                            machineDetails.loginTime = Convert.ToString(dateTime[1]);
                            //machineDetails.loginTime = dt;



                            DateTime currentDateTime = DateTime.Now;
                            //string currentTime = currentDateTime.ToString("yyyy-MM-dd HH:mm:00");

                            #region Automatic Logout and close fgPart

                            string firstShiftEnd = correctedDate + " " + "14:00:00";
                            string firstShiftEnd1 = correctedDate + " " + "14:03:00";
                            string secondShiftEnd = correctedDate + " " + "22:00:00";
                            string secondShiftEnd1 = correctedDate + " " + "22:03:00";
                            string thirdShiftEnd = correctedDate + " " + "06:00:00";
                            string thirdShiftEnd1 = correctedDate + " " + "06:03:00";

                            DateTime f = Convert.ToDateTime(firstShiftEnd);
                            DateTime f1 = Convert.ToDateTime(firstShiftEnd1);

                            DateTime s = Convert.ToDateTime(secondShiftEnd);
                            DateTime s1 = Convert.ToDateTime(secondShiftEnd1);

                            DateTime t = Convert.ToDateTime(thirdShiftEnd);
                            DateTime t1 = Convert.ToDateTime(thirdShiftEnd1);

                            if (currentDateTime >= f && currentDateTime <= f1)
                            {
                                if (UnitworkccsLogintrackerdetails.CurrentFgpart != null)
                                {
                                    var fgPart = db.UnitworkccsTblfgpartnodet.Where(m => m.FgPartId == UnitworkccsLogintrackerdetails.CurrentFgpart).FirstOrDefault();

                                    if (fgPart != null)
                                    {
                                        fgPart.IsClosed = 1;
                                        fgPart.ClosedDate = DateTime.Now;
                                        db.SaveChanges();
                                        obj.isStatus = true;
                                        obj.response = "Fg Part Number Closed Successfully";

                                        machineDetails.fgPartFlag = false;
                                        machineDetails.FgPartId = 0;
                                        machineDetails.partNo = null;
                                        machineDetails.operationNo = 0;
                                        machineDetails.workOrderNo = null;
                                        machineDetails.fgPartDesc = null;

                                    }

                                    #region Update last row of logged in user details 

                                    UnitworkccsLogintrackerdetails = commonFunction.GetLoginTrackerDetailsLastRow(fgPart.CorrectedDate, Convert.ToInt32(fgPart.MachineId));
                                    if (UnitworkccsLogintrackerdetails != null)
                                    {
                                        var check1 = db.UnitworkccsLogintrackerdetails.Where(m => m.MachineId == fgPart.MachineId && m.CorrectedDate == fgPart.CorrectedDate && m.CurrentFgpart == fgPart.FgPartId).FirstOrDefault();
                                        if (check1 != null)
                                        {
                                            check1.CurrentFgpart = null;
                                            check1.LogoutDateTime = DateTime.Now;
                                            check1.IsLoggedIn = 0;
                                            db.SaveChanges();
                                            obj.isStatus = true;
                                            obj.response = "Logout Successfully";

                                            machineDetails.isLoggedIn = Convert.ToBoolean(check1.IsLoggedIn);
                                            machineDetails.operatorId = 0;
                                            machineDetails.operatorName = null;
                                            machineDetails.loginTime = null;
                                            machineDetails.shift = null;
                                        }
                                    }
                                    #endregion
                                }
                            }
                            else if (currentDateTime >= s && currentDateTime <= s1)
                            {
                                if (UnitworkccsLogintrackerdetails.CurrentFgpart != null)
                                {
                                    var fgPart = db.UnitworkccsTblfgpartnodet.Where(m => m.FgPartId == UnitworkccsLogintrackerdetails.CurrentFgpart).FirstOrDefault();

                                    if (fgPart != null)
                                    {

                                        fgPart.IsClosed = 1;
                                        fgPart.ClosedDate = DateTime.Now;
                                        db.SaveChanges();
                                        obj.isStatus = true;
                                        obj.response = "Fg Part Number Closed Successfully";

                                        machineDetails.fgPartFlag = false;
                                        machineDetails.FgPartId = 0;
                                        machineDetails.partNo = null;
                                        machineDetails.operationNo = 0;
                                        machineDetails.workOrderNo = null;
                                        machineDetails.fgPartDesc = null;
                                    }

                                    #region Update last row of logged in user details 

                                    UnitworkccsLogintrackerdetails = commonFunction.GetLoginTrackerDetailsLastRow(fgPart.CorrectedDate, Convert.ToInt32(fgPart.MachineId));
                                    if (UnitworkccsLogintrackerdetails != null)
                                    {
                                        var check1 = db.UnitworkccsLogintrackerdetails.Where(m => m.MachineId == fgPart.MachineId && m.CorrectedDate == fgPart.CorrectedDate && m.CurrentFgpart == fgPart.FgPartId).FirstOrDefault();
                                        if (check1 != null)
                                        {
                                            check1.CurrentFgpart = null;
                                            check1.LogoutDateTime = DateTime.Now;
                                            check1.IsLoggedIn = 0;
                                            db.SaveChanges();
                                            obj.isStatus = true;
                                            obj.response = "Logout Successfully";

                                            machineDetails.isLoggedIn = Convert.ToBoolean(check1.IsLoggedIn);
                                            machineDetails.operatorId = 0;
                                            machineDetails.operatorName = null;
                                            machineDetails.loginTime = null;
                                            machineDetails.shift = null;
                                        }
                                    }
                                    #endregion
                                }
                            }
                            else if (currentDateTime >= t && currentDateTime <= t1)
                            {
                                if (UnitworkccsLogintrackerdetails.CurrentFgpart != null)
                                {
                                    var fgPart = db.UnitworkccsTblfgpartnodet.Where(m => m.FgPartId == UnitworkccsLogintrackerdetails.CurrentFgpart).FirstOrDefault();

                                    if (fgPart != null)
                                    {

                                        fgPart.IsClosed = 1;
                                        fgPart.ClosedDate = DateTime.Now;
                                        db.SaveChanges();
                                        obj.isStatus = true;
                                        obj.response = "Fg Part Number Closed Successfully";

                                        machineDetails.fgPartFlag = false;
                                        machineDetails.FgPartId = 0;
                                        machineDetails.partNo = null;
                                        machineDetails.operationNo = 0;
                                        machineDetails.workOrderNo = null;
                                        machineDetails.fgPartDesc = null;
                                    }

                                    #region Update last row of logged in user details 

                                    UnitworkccsLogintrackerdetails = commonFunction.GetLoginTrackerDetailsLastRow(fgPart.CorrectedDate, Convert.ToInt32(fgPart.MachineId));
                                    if (UnitworkccsLogintrackerdetails != null)
                                    {
                                        var check1 = db.UnitworkccsLogintrackerdetails.Where(m => m.MachineId == fgPart.MachineId && m.CorrectedDate == fgPart.CorrectedDate && m.CurrentFgpart == fgPart.FgPartId).FirstOrDefault();
                                        if (check1 != null)
                                        {
                                            check1.CurrentFgpart = null;
                                            check1.LogoutDateTime = DateTime.Now;
                                            check1.IsLoggedIn = 0;
                                            db.SaveChanges();
                                            obj.isStatus = true;
                                            obj.response = "Logout Successfully";

                                            machineDetails.isLoggedIn = Convert.ToBoolean(check1.IsLoggedIn);
                                            machineDetails.operatorId = 0;
                                            machineDetails.operatorName = null;
                                            machineDetails.loginTime = null;
                                            machineDetails.shift = null;
                                        }
                                    }
                                    #endregion
                                }
                            }
                            #endregion
                        }
                        machineDetails.responseGraph = objgraph;
                        MachineDetailsList.Add(machineDetails);
                    }
                }
                obj.isStatus = true;
                obj.response = MachineDetailsList;

            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = e;
            }
            return obj;
        }

        /// <summary>
        /// Get Ip Address And HostName
        /// </summary>
        /// <returns></returns>
        public CommonResponse GetIpAddressAndHostName()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblipaddress
                             where wf.IsDeleted == 0
                             select new
                             {
                                 HostName = wf.HostName,
                                 IpAddress = wf.IpAddress,
                                 IpAddressId = wf.IpAddressId
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
        /// Graph Details
        /// </summary>
        /// <returns></returns>
        public ResponseMessage GraphDetails(int machineId)
        {
            ResponseMessage obj = new ResponseMessage();
            try
            {
                CommonFunction commonFunction = new CommonFunction();
                string shift = commonFunction.GetCurrentShift();
                string correctedDate = commonFunction.GetCorrectedDate();
                DateTime currentDateTime = DateTime.Now;

                double AvailabilityPercentage = Convert.ToDouble(0.1);
                double PerformancePercentage = Convert.ToDouble(0.1);
                double QualityPercentage = Convert.ToDouble(0.1);
                double OEEPercentage = Convert.ToDouble(0.1);
                int Actual = 0;
                double Target = 0;
                int? trialCount = 0;
                int Actual2 = 0;
                int Target2 = 0;
                double Quality = 0;
                int? runningBalance = 0;
                int? OverAllRunningBalance = 0;
                int? ActualValue = 0;
                int? RemainingRunningBalance = 0;
                DateTime correctedDate1 = Convert.ToDateTime(correctedDate);
                var shiftStartTime = db.UnitworkccsTblshiftMstr.Where(m => m.ShiftName == shift).Select(m => m.StartTime).FirstOrDefault();
                var shiftStartDateTime = correctedDate + " " + shiftStartTime;
                DateTime shiftDateTime = Convert.ToDateTime(shiftStartDateTime);
                int? TotalActualPart = 0;

                OEEDashboard oEE = new OEEDashboard();
                oEE = OEE1(machineId);

                AvailabilityPercentage = Math.Round(oEE.AvailabilityPercentage, 2);
                PerformancePercentage = Math.Round(oEE.PerformancePercentage, 2);
                OEEPercentage = Math.Round(oEE.OEEPercentage, 2);
                Quality = Math.Round(oEE.Quality, 2);
                Actual = oEE.Actual;
                Target = oEE.Target;

                if (AvailabilityPercentage >= 100)
                {
                    AvailabilityPercentage = 99.99;
                }
                if (PerformancePercentage >= 100)
                {
                    PerformancePercentage = 99.99;
                }
                if (OEEPercentage >= 100)
                {
                    OEEPercentage = 99.99;
                }
                if (Quality >= 100)
                {
                    Quality = 99.99;
                }

                OEEPercentage = Math.Round(((AvailabilityPercentage * PerformancePercentage * Quality) / 1000000), 2) * 100;

                if (OEEPercentage >= 100)
                {
                    OEEPercentage = 99.99;
                }

                //trialCount = GetTrialCount(machineId);



                var check1 = (from wf in db.UnitworkccsTblfgpartnodet
                              where wf.MachineId == machineId && wf.CorrectedDate == correctedDate && wf.StartDate != null && wf.Shift == shift && wf.IsClosed != 1
                              orderby wf.FgPartId descending
                              select new
                              {
                                  FgPartId = wf.FgPartId,
                                  PlanLinkageId = wf.PlanLinkageId,
                                  StartDate = wf.StartDate,
                                  ClosedDate = wf.ClosedDate,
                                  NoOfPartsPerCycle = wf.NoOfPartsPerCycle,
                                  scheduledQty = wf.ScheduledQty,
                                  workOrderCompletedQty = wf.WorkOrderCompletedQty,
                                  partCountMethod = wf.PartCountMethod,
                                  workOrderNo = wf.WorkOrderNo,
                                  fgPartNo = wf.FgPartNo,
                                  operationNo = wf.OperationNo
                              }).FirstOrDefault();

                if (check1 != null)
                {

                    GetPartCountPerShift(machineId, out Actual2, out Target2);

                    GetTrialCount(machineId);

                    var checkTicket = db.UnitworkccsTblraisedticket.Where(m => m.MachineId == machineId && (m.Status == 1 || m.Status == 2 || m.Status == 3)).OrderByDescending(m => m.TicketId).FirstOrDefault();

                    if (checkTicket != null)
                    {
                        trialCount = db.UnitworkccsTbltrialpartcount.Where(m => m.MachineId == machineId && m.TicketOpenDate != null && m.TicketCloseDate == null && m.TicketId == checkTicket.TicketId && m.Shift == shift && m.CorrectedDate == correctedDate).Sum(m => m.TrialPartCount);

                        trialCount = trialCount * Convert.ToInt32(check1.NoOfPartsPerCycle);
                    }
                    else
                    {
                        var checkTicketClose = db.UnitworkccsTblraisedticket.Where(m => m.MachineId == machineId && (m.Status == 4 || m.Status == 5)).OrderByDescending(m => m.TicketId).FirstOrDefault();
                        if (checkTicketClose != null)
                        {
                            if (checkTicketClose.TicketClosedDate != null)
                            {
                                DateTime ticketCloseDate = Convert.ToDateTime(checkTicketClose.TicketClosedDate);
                                string tktClosedDate = ticketCloseDate.ToString("yyyy-MM-dd");

                                if (Convert.ToDateTime(correctedDate) <= Convert.ToDateTime(tktClosedDate))
                                {
                                    trialCount = db.UnitworkccsTbltrialpartcount.Where(m => m.MachineId == machineId && m.TicketOpenDate != null && m.TicketId == checkTicketClose.TicketId && m.Shift == shift && m.CorrectedDate == correctedDate).Sum(m => m.TrialPartCount);

                                    trialCount = trialCount * Convert.ToInt32(check1.NoOfPartsPerCycle);
                                }
                                else
                                {
                                    trialCount = 0;
                                }
                            }
                        }
                    }

                    //int? woBalanceQty = Convert.ToInt32(check1.partCountMethod);
                    //runningBalance = woBalanceQty - Actual2;

                    //var fgPartData = db.UnitworkccsTblfgpartnodet.Where(wf => wf.MachineId == machineId && wf.CorrectedDate == correctedDate && wf.StartDate != null && wf.Shift == shift && wf.IsClosed != 1).OrderByDescending(wf => wf.FgPartId).FirstOrDefault();

                    //if(fgPartData != null)
                    //{
                    //    fgPartData.RunningBalance = runningBalance;
                    //    db.SaveChanges();
                    //}

                    //var woDet = db.UnitworkccsTblfgpartnodet.Where(m => m.WorkOrderNo == fgPartData.WorkOrderNo && m.FgPartNo == fgPartData.FgPartNo && m.OperationNo == fgPartData.OperationNo && m.IsClosed != 1  && m.CorrectedDate == correctedDate && m.Shift == shift).ToList();

                    //foreach (var item in woDet)
                    //{
                    //    if(item.RunningBalance != null)
                    //    {
                    //        TotalrunningBalance += item.RunningBalance;
                    //    }
                    //}

                    //if(fgPartData != null)
                    //{
                    //    RemainingRunningBalance = Convert.ToInt32(fgPartData.PartCountMethod) - TotalrunningBalance;
                    //}

                    var check = db.UnitworkccsTblfgpartnodet.Where(wf => wf.CorrectedDate == correctedDate && wf.FgPartNo == check1.fgPartNo && wf.WorkOrderNo == check1.workOrderNo && wf.OperationNo == check1.operationNo && wf.Shift == shift).Select(m => m.MachineId).Distinct().ToList();

                    if (check.Count > 0)
                    {
                        foreach (var item in check)
                        {
                            var machine = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == item && m.IsPcb == 1).FirstOrDefault();
                            var NoOfPerCycle = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == item).Select(m => m.NoOfPartsPerCycle).FirstOrDefault();

                            if (machine == null)
                            {
                                var parametermasterlistAll = db.UnitworkccsParametersMaster.Where(m => m.CorrectedDate == correctedDate1 && m.InsertedOn >= shiftDateTime && m.InsertedOn <= currentDateTime).ToList();
                                var parametermasterlist = parametermasterlistAll.Where(m => m.MachineId == item && m.CorrectedDate == correctedDate1 && m.InsertedOn >= shiftDateTime && m.InsertedOn <= currentDateTime).ToList();
                                var TopRow = parametermasterlist.OrderByDescending(m => m.ParameterId).FirstOrDefault();
                                var LastRow = parametermasterlist.OrderBy(m => m.ParameterId).FirstOrDefault();

                                if (TopRow != null && LastRow != null)
                                {
                                    ActualValue = Convert.ToInt32(TopRow.PartsTotal - LastRow.PartsTotal);
                                }

                                ActualValue = ActualValue * NoOfPerCycle;
                                TotalActualPart += ActualValue;
                            }
                            else
                            {
                                var parametermasterlistLast = db.UnitworkccsTblpartscountandcutting.Where(m => m.MachineId == item && m.CorrectedDate == correctedDate1 && m.StartTime >= shiftDateTime && m.EndTime <= currentDateTime).ToList().Sum(m => m.PartCount);

                                ActualValue = parametermasterlistLast;
                                TotalActualPart += ActualValue;
                            }
                        }
                        decimal woBalanceQ1 = Convert.ToDecimal(check1.partCountMethod);
                        int wo1 = Convert.ToInt32(woBalanceQ1);
                        OverAllRunningBalance = wo1 - TotalActualPart;

                        #region To insert new fgpart if running balance is completed

                        if (OverAllRunningBalance <= 0)
                        {
                            var dbCheck = db.UnitworkccsTblfgpartnodet.Where(wf => wf.CorrectedDate == correctedDate && wf.MachineId == machineId && wf.IsClosed == null && wf.StartDate != null).FirstOrDefault();

                            if (dbCheck != null)
                            {
                                var UnitworkccsLogintrackerdetails1 = commonFunction.GetLoginTrackerDetailsLastRow(correctedDate, machineId);

                                if (UnitworkccsLogintrackerdetails1 != null)
                                {
                                    var fgPart = db.UnitworkccsTblfgpartnodet.Where(m => m.FgPartId == UnitworkccsLogintrackerdetails1.CurrentFgpart).FirstOrDefault();

                                    if (fgPart != null)
                                    {
                                        fgPart.IsClosed = 1;
                                        fgPart.ClosedDate = DateTime.Now;
                                        db.SaveChanges();

                                        var checks = db.UnitworkccsLogintrackerdetails.Where(m => m.MachineId == fgPart.MachineId && m.CorrectedDate == fgPart.CorrectedDate && m.CurrentFgpart == fgPart.FgPartId).FirstOrDefault();
                                        if (checks != null)
                                        {
                                            checks.CurrentFgpart = null;
                                            db.SaveChanges();
                                        }
                                    }

                                    var checkWo = db.UnitworkccsTblfgpartnodet.Where(m => m.FgPartNo == check1.fgPartNo && m.OperationNo == check1.operationNo && m.CorrectedDate == correctedDate && m.MachineId == machineId).ToList();

                                    var machinename = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == machineId).Select(m => m.MachineName).FirstOrDefault();

                                    var PlanVisageWoDet = db.UnitworkccsTblplanlinkagemaster.Where(m => m.FgPartNo == check1.fgPartNo && m.Operation == check1.operationNo && m.ResourceId == machinename).ToList();

                                    var result = PlanVisageWoDet.Where(p => checkWo.All(p2 => p2.WorkOrderNo != p.ProductionOrder)).FirstOrDefault();

                                    if (result != null)
                                    {
                                        var tblFgPartDet = db.UnitworkccsTblfgpartnodet.Where(m => m.IsClosed != 1 && m.StartDate != null && m.CorrectedDate == correctedDate && m.Shift == shift && m.MachineId == machineId).OrderByDescending(m => m.FgPartId).FirstOrDefault();

                                        if (tblFgPartDet == null)
                                        {
                                            UnitworkccsTblfgpartnodet UnitworkccsTblfgpartnodet = new UnitworkccsTblfgpartnodet();
                                            UnitworkccsTblfgpartnodet.NoOfPartsPerCycle = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == machineId).Select(m => m.NoOfPartsPerCycle).FirstOrDefault().ToString();// data.noOfPartsPerCycle;
                                            UnitworkccsTblfgpartnodet.IsDeleted = 0;
                                            UnitworkccsTblfgpartnodet.CreatedOn = DateTime.Now;
                                            UnitworkccsTblfgpartnodet.MachineId = machineId;
                                            UnitworkccsTblfgpartnodet.OperatorId = UnitworkccsLogintrackerdetails1.OperatorId;
                                            UnitworkccsTblfgpartnodet.CorrectedDate = correctedDate;
                                            UnitworkccsTblfgpartnodet.StartDate = DateTime.Now;
                                            UnitworkccsTblfgpartnodet.Shift = shift;
                                            UnitworkccsTblfgpartnodet.TargetQty = 0;
                                            UnitworkccsTblfgpartnodet.ActaulValue = 0;
                                            UnitworkccsTblfgpartnodet.PlanLinkageId = result.PlanLinkageId;

                                            var planVisageData = (from wf in db.UnitworkccsTblplanlinkagemaster
                                                                  where wf.PlanLinkageId == result.PlanLinkageId
                                                                  select new
                                                                  {
                                                                      idealCycleTime = wf.IdealCycleTime,
                                                                      fgPartNo = wf.FgPartNo,
                                                                      plannedStartTime = wf.PlannedStartTime,
                                                                      plannedEndTime = wf.PlannedEndTime,
                                                                      unit = wf.Unit,
                                                                      scheduledQty = wf.ScheduledQty,
                                                                      partName = wf.PartName,
                                                                      routingId = wf.RoutingId,
                                                                      workOrderQnt = wf.WorkOrderQty,
                                                                      operation = wf.Operation,
                                                                      workOrderNo = wf.ProductionOrder,
                                                                      workOrderCompletedQty = wf.WorkOrderCompletedQty,
                                                                      remainingQty = wf.WorkOrderQty - wf.WorkOrderCompletedQty
                                                                  }).FirstOrDefault();
                                            if (planVisageData != null)
                                            {
                                                UnitworkccsTblfgpartnodet.OperationNo = planVisageData.operation;
                                                UnitworkccsTblfgpartnodet.WorkOrderNo = planVisageData.workOrderNo;

                                                UnitworkccsTblfgpartnodet.FgPartNo = planVisageData.fgPartNo;
                                                UnitworkccsTblfgpartnodet.IdealCycleTime = planVisageData.idealCycleTime;
                                                UnitworkccsTblfgpartnodet.Unit = planVisageData.unit;

                                                UnitworkccsTblfgpartnodet.PartCountMethod = Convert.ToString(planVisageData.remainingQty);
                                                UnitworkccsTblfgpartnodet.PlannedStartTime = planVisageData.plannedStartTime;
                                                UnitworkccsTblfgpartnodet.PlannedEndTime = planVisageData.plannedEndTime;
                                                UnitworkccsTblfgpartnodet.PartName = planVisageData.partName;
                                                UnitworkccsTblfgpartnodet.ScheduledQty = planVisageData.scheduledQty;
                                                UnitworkccsTblfgpartnodet.RoutingId = planVisageData.routingId;
                                                UnitworkccsTblfgpartnodet.WorkOrderCompletedQty = planVisageData.workOrderCompletedQty;
                                            }
                                            db.UnitworkccsTblfgpartnodet.Add(UnitworkccsTblfgpartnodet);
                                            db.SaveChanges();

                                            string woBalanceNewQty = db.UnitworkccsTblfgpartnodet.Where(m => m.IsDeleted == 0).Select(m => m.PartCountMethod).LastOrDefault();
                                            decimal woBalanceQ = Convert.ToDecimal(woBalanceNewQty);
                                            int wo = Convert.ToInt32(woBalanceQ);
                                            runningBalance = wo - Actual2;

                                            #region Update last row of logged in user details 

                                            var checks = db.UnitworkccsLogintrackerdetails.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate && m.LogoutDateTime == null && m.Shift == shift).FirstOrDefault();
                                            if (checks != null)
                                            {
                                                checks.CurrentFgpart = UnitworkccsTblfgpartnodet.FgPartId;
                                                db.SaveChanges();
                                            }
                                            #endregion

                                            List<MachineDetails> MachineDetailsList = new List<MachineDetails>();
                                            if (checks != null)
                                            {
                                                MachineDetails machineDetails = new MachineDetails();
                                                machineDetails.FgPartId = checks.CurrentFgpart;
                                                if (checks.CurrentFgpart != null)
                                                {
                                                    machineDetails.fgPartFlag = true;

                                                    var fgPartNew = db.UnitworkccsTblfgpartnodet.Where(m => m.FgPartId == checks.CurrentFgpart).FirstOrDefault();

                                                    if (fgPartNew != null)
                                                    {
                                                        machineDetails.partNo = db.UnitworkccsTblplanlinkagemaster.Where(m => m.PlanLinkageId == fgPartNew.PlanLinkageId).Select(m => m.FgPartNo).FirstOrDefault();
                                                        var partNo = db.UnitworkccsTblplanlinkagemaster.Where(m => m.PlanLinkageId == fgPartNew.PlanLinkageId).Select(m => m.FgPartNo).FirstOrDefault();
                                                        machineDetails.dmcCodeStatus = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.DmcCodeStatus).FirstOrDefault();
                                                        var cellId = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.CellFinalId).FirstOrDefault();
                                                        var subCellId = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.SubCellFinalId).FirstOrDefault();
                                                        machineDetails.cellName = db.UnitworkccsTblshop.Where(m => m.ShopId == cellId).Select(m => m.ShopName).FirstOrDefault();
                                                        machineDetails.subCellName = db.UnitworkccsTblcell.Where(m => m.CellId == subCellId).Select(m => m.CellName).FirstOrDefault();
                                                        try
                                                        {
                                                            machineDetails.operationNo = Convert.ToInt32(fgPart.OperationNo);
                                                        }
                                                        catch (Exception e)
                                                        {
                                                            log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                                                            obj.isStatus = false;
                                                        }
                                                        machineDetails.workOrderNo = fgPartNew.WorkOrderNo;
                                                        machineDetails.fgPartDesc = db.UnitworkccsTblplanlinkagemaster.Where(m => m.PlanLinkageId == fgPartNew.PlanLinkageId).Select(m => m.PartName).FirstOrDefault();
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    #endregion
                                }

                            }
                        }

                        //int dryRunCount = GetDryRunCount(machineId);

                        GetDryRunCount(machineId);

                        int? dryRunCount = db.UnitworkccsTbldryrun.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate && m.Shift == shift).ToList().Sum(m => m.PartCount);

                        int rejectionQty = GetRejectionDetailsShiftWise(machineId);
                        int reworkQty = GetReworkDetailsShiftWise(machineId);
                        int totalActualQty = GetOkQuantity(machineId);

                        int totalOkQuantity = totalActualQty - rejectionQty - reworkQty - Convert.ToInt32(trialCount);

                        Response response = new Response();
                        graphDetails graphDetailsList = new graphDetails();

                        var UnitworkccsLogintrackerdetails = db.UnitworkccsLogintrackerdetails.Where(m => m.CorrectedDate == correctedDate && m.MachineId == machineId && m.IsLoggedIn == 1).OrderByDescending(m => m.LoginTrackerDetailsId).FirstOrDefault();

                        if (UnitworkccsLogintrackerdetails != null)
                        {
                            graphDetails graphDetails = new graphDetails();
                            if (OEEPercentage == 0)
                            {
                                graphDetails.propOee = Convert.ToDouble(0.1);
                            }
                            else
                            {
                                graphDetails.propOee = Math.Round(OEEPercentage, 2);
                            }
                            if (AvailabilityPercentage == 0)
                            {
                                graphDetails.availblity = Convert.ToDouble(0.1);
                            }
                            else
                            {
                                graphDetails.availblity = Math.Round(AvailabilityPercentage, 2);
                            }
                            if (Quality == 0)
                            {
                                graphDetails.quality = Convert.ToDouble(0.1);
                            }
                            else
                            {
                                graphDetails.quality = Math.Round(Quality, 2);
                            }
                            if (PerformancePercentage == 0)
                            {
                                graphDetails.performance = Convert.ToDouble(0.1);
                            }
                            else
                            {
                                graphDetails.performance = Math.Round(PerformancePercentage, 2);
                            }

                            graphDetails.runningBalance = OverAllRunningBalance;
                            graphDetails.woBalance = wo1;

                            tableDetails tableDetails = new tableDetails();

                            #region Part Count Per Shift
                            tablePartsDetails tablePartsDetails1 = new tablePartsDetails();
                            tablePartsDetails1.actual = Actual2;/*- Convert.ToInt32(trialCount) - Convert.ToInt32(dryRunCount)*/
                            tablePartsDetails1.target = Target2;
                            tablePartsDetails1.rejectionQty = rejectionQty;
                            tablePartsDetails1.reworkQty = reworkQty;
                            tablePartsDetails1.okQty = totalOkQuantity - (Convert.ToInt32(dryRunCount) * Convert.ToInt32(check1.NoOfPartsPerCycle));
                            tableDetails.partCountShiftDetails = tablePartsDetails1;
                            #endregion

                            #region Part Count Per Hour 
                            tablePartsDetails tablePartsDetails2 = new tablePartsDetails();
                            tablePartsDetails2.actual = Actual;
                            tablePartsDetails2.target = Target;
                            tablePartsDetails2.okQty = Actual;
                            tableDetails.totalPartHrDetails = tablePartsDetails2;
                            #endregion

                            #region Trial Part Count
                            tablePartsDetails tablePartsDetails3 = new tablePartsDetails();
                            tablePartsDetails3.actual = Convert.ToInt32(trialCount);
                            tablePartsDetails3.target = 0;
                            tableDetails.trialPartCountDetails = tablePartsDetails3;
                            #endregion

                            #region Dry Run Count
                            tablePartsDetails tablePartsDetails4 = new tablePartsDetails();
                            tablePartsDetails4.actual = Convert.ToInt32(dryRunCount);
                            tablePartsDetails4.target = 0;
                            tableDetails.dryRunCountDetails = tablePartsDetails4;
                            #endregion


                            obj.isStatus = true;
                            response.graphDetails = graphDetails;
                            response.tableDetails = tableDetails;
                            obj.response = response;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                //obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        public void OEE(int machineId, out double AvailabilityPercentage, out double PerformancePercentage, out double OEEPercentage, out int Actual, out int Target)
        {
            CommonFunction commonFunction = new CommonFunction();
            string shift = commonFunction.GetCurrentShift();
            string correctedDate = commonFunction.GetCorrectedDate();

            //DateTime correctedDate1 = Convert.ToDateTime(correctedDate);
            decimal OperatingTime = 0;
            decimal LossTime = 0;
            decimal MinorLossTime = 0;
            decimal MntTime = 0;
            decimal SetupTime = 0;
            Actual = 0;
            Target = 0;
            //decimal SetupMinorTime = 0;
            decimal PowerOffTime = 0;
            decimal PowerONTime = 0;
            //decimal Utilization = 0;
            decimal DayOEEPercent = 0;
            //int PerformanceFactor = 0;
            //decimal Quality = 0;
            int TotlaQty = 0;
            int YieldQty = 0;
            int BottleNeckYieldQty = 0;
            //decimal IdealCycleTimeVal = 2;
            decimal plannedCycleTime = 0;
            decimal LoadingTime = 0;
            decimal UnloadingTime = 0;

            double plannedBrkDurationinMin = 0;
            decimal LoadingUnloadingWithProd = 0;
            decimal LoadingUnloadingwithProdBottleNeck = 0;
            int minorstoppage = 0;
            //decimal TotalProductoin = 0;
            decimal Availability;
            int rejQty = 0;
            int reject = 0;
            //  string plantName = row.tblplant.PlantName;
            var machineslist = new List<UnitworkccsTblmachinedetails>();
            var bottleneckmachines = new UnitworkccsTblbottelneck();
            var scrap = new UnitworkccsTblfgpartnodet();
            var scrapqty1 = new List<UnitworkccsTblrejectiondetails>();
            var cellpartDet = new UnitworkccsTblcellpart();
            var partsDet = new UnitworkccsTblparts();
            using (unitworksccsContext db = new unitworksccsContext())
            {
                scrap = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate).OrderByDescending(m => m.FgPartId).FirstOrDefault();
                if (scrap != null)
                {
                    var check = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == machineId).Select(m => m.OperationNumber).FirstOrDefault();
                    string operationNo = Convert.ToString(check);
                    partsDet = db.UnitworkccsTblparts.Where(m => m.IsDeleted == 0 && m.PartId == scrap.PartId && m.OperationNo == operationNo).FirstOrDefault();
                    //if (partsDet != null)
                    //    bottleneckmachines = db.UnitworkccsTblbottelnecks.Where(m => m.PartNo == partsDet.FGCode && m.MachineID == scrap.MachineID).FirstOrDefault();
                }
                else
                {
                    partsDet = db.UnitworkccsTblparts.Where(m => m.IsDeleted == 0).FirstOrDefault();
                    //cellpartDet = db.UnitworkccsTblcellparts.Where(m => m.CellID == CellID && m.IsDefault == 1 && m.IsDeleted == 0).FirstOrDefault();
                    //if (cellpartDet != null)
                    //var CellID = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0 && m.MachineID == machineId).Select(m => m.CellID).FirstOrDefault();
                    //cellpartDet = db.UnitworkccsTblcellparts.Where(m => m.CellID == CellID && m.IsDefault == 1 && m.IsDeleted == 0).FirstOrDefault();
                    //if (cellpartDet != null)
                    //    bottleneckmachines = db.UnitworkccsTblbottelnecks.Where(m => m.PartNo == cellpartDet.partNo && m.MachineID == machineId).FirstOrDefault();
                    //string Operationnum = bottleneckmachines.tblmachinedetail.OperationNumber.ToString();
                    //partsDet = db.UnitworkccsTblparts.Where(m => m.IsDeleted == 0 && m.FGCode == cellpartDet.partNo && m.OperationNo == Operationnum).FirstOrDefault();
                }


            }
            using (unitworksccsContext db = new unitworksccsContext())
            {
                // Get Machines               
                machineslist = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0 && m.IsNormalWc == 0 && m.MachineId == machineId /* m.MachineID == bottleneckmachines.MachineID*/).OrderBy(m => m.MachineId).ToList();
            }

            foreach (var machine in machineslist)
            {
                Machines machines = new Machines();
                int machineID = machine.MachineId;
                // Mode details
                minorstoppage = Convert.ToInt32(machine.MachineIdleMin) * 60; // in sec
                var GetModeDurations = new List<UnitworkccsTbllivemode>();
                using (unitworksccsContext db = new unitworksccsContext())
                {
                    DateTime correctedDate3 = Convert.ToDateTime(correctedDate);
                    GetModeDurations = db.UnitworkccsTbllivemode.Where(m => m.MachineId == machineID && m.CorrectedDate == correctedDate3 && m.IsCompleted == 1).ToList();
                }

                OperatingTime = Convert.ToDecimal(GetModeDurations.Where(m => m.ModeType == "PROD").ToList().Sum(m => m.DurationInSec));
                PowerOffTime = Convert.ToDecimal(GetModeDurations.Where(m => m.ModeType == "POWEROFF").ToList().Sum(m => m.DurationInSec));
                MntTime = Convert.ToDecimal(GetModeDurations.Where(m => m.ModeType == "MNT").ToList().Sum(m => m.DurationInSec));
                MinorLossTime = Convert.ToDecimal(GetModeDurations.Where(m => m.ModeType == "IDLE" && m.DurationInSec < minorstoppage).ToList().Sum(m => m.DurationInSec));
                LossTime = Convert.ToDecimal(GetModeDurations.Where(m => m.ModeType == "IDLE" && m.DurationInSec > minorstoppage).ToList().Sum(m => m.DurationInSec));
                PowerONTime = Convert.ToDecimal(GetModeDurations.Where(m => m.ModeType == "POWERON").ToList().Sum(m => m.DurationInSec));
                OperatingTime = Math.Round((OperatingTime / 60), 2);
                PowerOffTime = (PowerOffTime / 60);
                MntTime = (MntTime / 60);
                MinorLossTime = (MinorLossTime / 60);
                LossTime = (LossTime / 60);
                PowerONTime = (PowerONTime / 60);
                var plannedbrks = db.UnitworkccsTblplannedbreak.Where(m => m.IsDeleted == 0).ToList();
                foreach (var row in plannedbrks)
                {
                    plannedBrkDurationinMin += Convert.ToDateTime(correctedDate + " " + row.EndTime).Subtract(Convert.ToDateTime(correctedDate + " " + row.StartTime)).TotalMinutes;
                }
                foreach (var ModeRow in GetModeDurations)
                {
                    if (ModeRow.ModeType == "SETUP")
                    {
                        try
                        {
                            SetupTime += (decimal)Convert.ToDateTime(ModeRow.LossCodeEnteredTime).Subtract(Convert.ToDateTime(ModeRow.StartTime)).TotalMinutes;
                            //SetupMinorTime += (decimal)(db.tblSetupMaints.Where(m => m.ModeID == ModeRow.ModeID).Select(m => m.MinorLossTime).First() / 60.00);
                        }
                        catch { }
                    }
                }
                var GetModeDurationsRunning = new List<UnitworkccsTbllivemode>();
                using (unitworksccsContext db = new unitworksccsContext())
                {
                    DateTime correctedDate2 = Convert.ToDateTime(correctedDate);
                    GetModeDurationsRunning = db.UnitworkccsTbllivemode.Where(m => m.MachineId == machineID && m.CorrectedDate == correctedDate2 && m.IsCompleted == 0).ToList();
                }
                foreach (var ModeRow in GetModeDurationsRunning)
                {
                    String ColorCode = ModeRow.ColorCode;
                    DateTime StartTime = (DateTime)ModeRow.StartTime;
                    decimal Duration = (decimal)System.DateTime.Now.Subtract(StartTime).TotalMinutes;
                    if (ColorCode == "YELLOW")
                    {
                        LossTime += Duration;
                    }
                    else if (ColorCode == "GREEN")
                    {
                        OperatingTime += Duration;
                    }
                    else if (ColorCode == "RED")
                    {
                        MntTime += Duration;
                    }
                    else if (ColorCode == "BLUE")
                    {
                        PowerOffTime += Duration;
                    }
                }
                LoadingTime += (decimal)partsDet.StdLoadingTime;
                UnloadingTime += (decimal)partsDet.StdUnLoadingTime;

                //using (unitworksccsEntities1 db = new unitworksccsEntities1())
                //{
                //    scrap = db.tblworkorderentries.Where(m => m.MachineID == machine.MachineID && m.tblmachinedetail.IsLastMachine == 1).FirstOrDefault();
                //    string operationnum =Convert.ToString( machine.OperationNumber);
                //    partsDet = db.UnitworkccsTblparts.Where(m => m.IsDeleted == 0 && m.FGCode == bottleneckmachines.PartNo && m.OperationNo == operationnum).FirstOrDefault();
                //}
                if (scrap != null)
                {
                    using (unitworksccsContext db = new unitworksccsContext())
                    {
                        scrapqty1 = db.UnitworkccsTblrejectiondetails.Where(m => m.FgPartId == scrap.FgPartId && m.CorrectedDate == correctedDate).ToList();
                    }

                    foreach (var r1 in scrapqty1)
                    {
                        reject = reject + Convert.ToInt32(r1.DefectQty);
                    }

                }
                plannedCycleTime = Convert.ToDecimal(partsDet.IdealCycleTime);
            }
            //int bottleneckMachineID = bottleneckmachines.MachineID;
            int bottleneckMachineID = 0;
            DateTime correctedDate1 = Convert.ToDateTime(correctedDate);
            TotlaQty = GetQuantiy(machineId, correctedDate1, out YieldQty, out BottleNeckYieldQty, bottleneckMachineID);
            Actual = YieldQty;
            if (YieldQty == 0)
                YieldQty = 1;
            LoadingUnloadingWithProd = ((LoadingTime + UnloadingTime) * YieldQty) / 60;
            LoadingUnloadingwithProdBottleNeck = ((LoadingTime + UnloadingTime) * BottleNeckYieldQty) / 60;
            MinorLossTime = MinorLossTime - LoadingUnloadingWithProd;
            decimal OPwithMinorStoppage = (OperatingTime + LoadingUnloadingWithProd + MinorLossTime);
            decimal utilFactor = Math.Round((LoadingUnloadingWithProd + OperatingTime), 2);
            decimal IdleTime = LossTime;
            decimal BDTime = MntTime;
            int TotalTime = Convert.ToInt32(PowerONTime) + Convert.ToInt32(OperatingTime) + Convert.ToInt32(IdleTime) + Convert.ToInt32(BDTime) + Convert.ToInt32(PowerOffTime);
            //int TotalTime = 24 * 60;

            if (TotalTime == 0)
            {
                TotalTime = 1;
            }
            if (TotlaQty == 0)
                TotlaQty = 1;
            decimal plannedCycleTimeInMin = Math.Round((plannedCycleTime / 60), 2);
            var StdCycleTimeinMin = Convert.ToDecimal(plannedCycleTimeInMin);
            var LoadunloadTimeinMin = ((int)LoadingTime + (int)UnloadingTime) / 60;
            if (StdCycleTimeinMin < 1)
                StdCycleTimeinMin = 1;
            var Targetdec = ((decimal)TotalTime / (StdCycleTimeinMin + LoadunloadTimeinMin));
            Target = Convert.ToInt32(Targetdec);
            if (TotalTime > (int)plannedBrkDurationinMin)
                Availability = Math.Round((TotalTime - (decimal)plannedBrkDurationinMin), 2);
            else
                Availability = TotalTime;
            if (OPwithMinorStoppage == 0)
                OPwithMinorStoppage = 1;
            decimal TotalTimeWithPlannedBrk = Availability;
            decimal AvailabilityPercent = Math.Round((OPwithMinorStoppage / TotalTimeWithPlannedBrk), 2) * 100;  // From BottleNeckMachine

            if (AvailabilityPercent >= 100)
                AvailabilityPercent = 100;
            decimal PerformanceBottelNeck = Math.Round(((plannedCycleTimeInMin * YieldQty) / OPwithMinorStoppage), 2) * 100;
            decimal performanceFactor = (plannedCycleTime * YieldQty);
            decimal QualityLastMachine = Math.Round((decimal)((YieldQty - reject) / YieldQty), 2) * 100;            // From LastMachine
            DayOEEPercent = (decimal)Math.Round((double)(AvailabilityPercent / 100) * (double)(PerformanceBottelNeck / 100) * (double)(QualityLastMachine / 100), 2) * 100;
            //decimal availabilityDenominator = Math.Round((plannedCycleTimeInMin + LoadingUnloadingWithProd), 2);

            //TotalProductoin = Math.Round((Availability / availabilityDenominator) * 100, 2);
            //decimal performance = Math.Round((utilFactor / TotalProductoin) * 100, 2);
            //decimal performanceFactor = Math.Round((utilFactor));

            //decimal quality = Math.Round((decimal)(YieldQty / (YieldQty + rejQty)) * 100, 2);

            //Utilization = Convert.ToInt32(Convert.ToDouble(Convert.ToDouble(Convert.ToDouble(utilFactor) / Convert.ToDouble(TotalTime)) * 100));

            //DayOEEPercent = (decimal)Math.Round((double)(Utilization / 100) * (double)(performance / 100) * (double)(quality / 100), 2) * 100;
            if (AvailabilityPercent == 0)
            {
                QualityLastMachine = 0;
                PerformanceBottelNeck = 0;
                DayOEEPercent = 0;
            }
            AvailabilityPercentage = (double)AvailabilityPercent;
            //QualityPercentage = (double)QualityLastMachine;
            PerformancePercentage = (double)PerformanceBottelNeck;
            OEEPercentage = (double)DayOEEPercent;
        }

        private int GetQuantiy(int machineId, DateTime CorrectedDate, out int YieldQty, out int BottleNeckYieldQty, int bottlneckMachineID/*, out int BottleNeckTotalQty*/)
        {
            int TotalQty = 0;
            var machineDet = new List<UnitworkccsTblmachinedetails>();
            var starttime = new UnitworkccsTbldaytiming();
            var parametermasterlistAll = new List<UnitworkccsParametersMaster>();
            var parametermasterlist = new List<UnitworkccsParametersMaster>();
            using (unitworksccsContext db = new unitworksccsContext())
            {
                machineDet = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0 && m.IsNormalWc == 0 && m.MachineId == machineId).ToList();
            }
            YieldQty = 0;
            //BottleNeckTotalQty = 0;
            BottleNeckYieldQty = 0;
            string Correcteddate = CorrectedDate.ToString("yyyy-MM-dd");
            string NxtCorrecteddate = CorrectedDate.AddDays(1).ToString("yyyy-MM-dd");
            var bottleneckmachine = machineDet.Where(m => m.IsBottelNeck == 1).OrderBy(m => m.MachineId).FirstOrDefault();
            var lastmachine = machineDet.Where(m => m.IsLastMachine == 1).OrderBy(m => m.MachineId).FirstOrDefault();
            var firtstmachine = machineDet.Where(m => m.IsFirstMachine == 1).OrderBy(m => m.MachineId).FirstOrDefault();
            int firstmachineId = 0;
            int lstmachineId = 0;
            int bottleneckMachineID = 0;
            if (firtstmachine != null)
                firstmachineId = firtstmachine.MachineId;
            if (lastmachine != null)
                lstmachineId = lastmachine.MachineId;
            if (bottleneckmachine != null)
                bottleneckMachineID = bottleneckmachine.MachineId;
            using (unitworksccsContext db = new unitworksccsContext())
            {
                starttime = db.UnitworkccsTbldaytiming.Where(m => m.IsDeleted == 0).FirstOrDefault(); //.Select(m => m.StartTime)
            }

            string StartTime = Correcteddate + " 06:00:00";
            string EndTime = NxtCorrecteddate + " 06:00:00";

            DateTime St = Convert.ToDateTime(StartTime);
            DateTime Et = Convert.ToDateTime(EndTime);

            // Based on 1st Machine
            using (unitworksccsContext db = new unitworksccsContext())
            {
                parametermasterlistAll = db.UnitworkccsParametersMaster.Where(m => m.CorrectedDate == CorrectedDate.Date && m.InsertedOn >= St && m.InsertedOn <= Et).ToList();
            }
            parametermasterlist = parametermasterlistAll.Where(m => m.MachineId == firstmachineId && m.CorrectedDate == CorrectedDate.Date && m.InsertedOn >= St && m.InsertedOn <= Et).ToList();
            var TopRow = parametermasterlist.OrderByDescending(m => m.ParameterId).FirstOrDefault();
            var LastRow = parametermasterlist.OrderBy(m => m.ParameterId).FirstOrDefault();


            // Based on Last Machine
            var parametermasterlistLast = parametermasterlistAll.Where(m => m.MachineId == lstmachineId && m.CorrectedDate == CorrectedDate.Date && m.InsertedOn >= St && m.InsertedOn <= Et).ToList();
            var TopRowLast = parametermasterlistLast.OrderByDescending(m => m.ParameterId).FirstOrDefault();
            var RowLast = parametermasterlistLast.OrderBy(m => m.ParameterId).FirstOrDefault();

            // Based on Last Machine
            var parametermasterlistBottleNeck = parametermasterlistAll.Where(m => m.MachineId == bottlneckMachineID && m.CorrectedDate == CorrectedDate.Date && m.InsertedOn >= St && m.InsertedOn <= Et).ToList();
            var TopRowBottleNeck = parametermasterlistBottleNeck.OrderByDescending(m => m.ParameterId).FirstOrDefault();
            var RowLastBottleNeck = parametermasterlistBottleNeck.OrderBy(m => m.ParameterId).FirstOrDefault();


            if (TopRowLast != null && RowLast != null)
                YieldQty = Convert.ToInt32(TopRowLast.PartsTotal - RowLast.PartsTotal);

            if (TopRow != null && LastRow != null)
                TotalQty = Convert.ToInt32(TopRow.PartsTotal - LastRow.PartsTotal);

            if (TopRowBottleNeck != null && RowLastBottleNeck != null)
                BottleNeckYieldQty = Convert.ToInt32(TopRowBottleNeck.PartsTotal - RowLastBottleNeck.PartsTotal);
            //}
            return TotalQty;

        }

        public int GetTrialCount(int machineId)
        {
            CommonFunction commonFunction = new CommonFunction();
            int Actual = 0;
            int Actual1 = 0;
            string shift = commonFunction.GetCurrentShift();
            string correctedDate = commonFunction.GetCorrectedDate();

            DateTime correctedDate1 = Convert.ToDateTime(correctedDate);
            DateTime currentDateTime = DateTime.Now;

            var shiftStartTime = db.UnitworkccsTblshiftMstr.Where(m => m.ShiftName == shift).Select(m => m.StartTime).FirstOrDefault();
            var shiftStartDateTime = correctedDate + " " + shiftStartTime;
            DateTime shiftDateTime = Convert.ToDateTime(shiftStartDateTime);

            var check = (from wf in db.UnitworkccsTblraisedticket
                         where wf.MachineId == machineId && wf.TicketOpenDate != null && wf.TicketNo.Contains("Downtime-Stopped-BDS") && wf.Status == 1 && wf.TicketClosedDate == null
                         select new
                         {
                             TicketOpenDate = wf.TicketOpenDate,
                             TicketId = wf.TicketId

                         }).OrderByDescending(m => m.TicketId).FirstOrDefault();

            #region check isPCB
            if (check != null)
            {
                var machine = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == machineId && m.IsPcb == 1).FirstOrDefault();

                #endregion

                if (machine == null)
                {
                    var parametermasterlistAll = db.UnitworkccsParametersMaster.Where(m => m.InsertedOn >= shiftDateTime && m.InsertedOn <= currentDateTime).ToList();
                    var parametermasterlist = parametermasterlistAll.Where(m => m.MachineId == machineId && m.InsertedOn >= shiftDateTime && m.InsertedOn <= currentDateTime).ToList();
                    var TopRow = parametermasterlist.OrderByDescending(m => m.ParameterId).FirstOrDefault();
                    var LastRow = parametermasterlist.OrderBy(m => m.ParameterId).FirstOrDefault();

                    if (TopRow != null && LastRow != null)
                    {
                        Actual = Convert.ToInt32(TopRow.PartsTotal - LastRow.PartsTotal);
                        Actual1 += Actual;
                    }
                }
                else
                {
                    var parametermasterlistLast = db.UnitworkccsTblpartscountandcutting.Where(m => m.CorrectedDate == correctedDate1 && m.MachineId == machineId && m.StartTime >= check.TicketOpenDate && m.EndTime <= currentDateTime).ToList().Sum(m => m.PartCount);

                    Actual1 = parametermasterlistLast;
                }

                var dbCheck = db.UnitworkccsTbltrialpartcount.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate && m.Shift == shift && m.TicketId == check.TicketId).FirstOrDefault();
                if (dbCheck == null)
                {
                    UnitworkccsTbltrialpartcount UnitworkccsTbltrialpartcount = new UnitworkccsTbltrialpartcount();
                    UnitworkccsTbltrialpartcount.Shift = shift;
                    UnitworkccsTbltrialpartcount.CorrectedDate = correctedDate;
                    UnitworkccsTbltrialpartcount.MachineId = machineId;
                    UnitworkccsTbltrialpartcount.TrialPartCount = Actual1;
                    UnitworkccsTbltrialpartcount.CreatedOn = DateTime.Now;
                    UnitworkccsTbltrialpartcount.TicketOpenDate = check.TicketOpenDate;
                    UnitworkccsTbltrialpartcount.TicketId = check.TicketId;
                    UnitworkccsTbltrialpartcount.IsDeleted = 0;
                    db.UnitworkccsTbltrialpartcount.Add(UnitworkccsTbltrialpartcount);
                    db.SaveChanges();
                }
                else
                {
                    dbCheck.TrialPartCount = Actual1;
                    dbCheck.ModifiedOn = DateTime.Now;
                    db.SaveChanges();
                }
            }
            return Actual1;
        }

        public void GetPartCountPerShift(int machineId, out int Actual2, out int Target2)
        {
            CommonFunction commonFunction = new CommonFunction();
            Actual2 = 0;
            Target2 = 0;

            string correctedDate = commonFunction.GetCorrectedDate();
            DateTime correctedDate1 = Convert.ToDateTime(correctedDate);
            string shift = commonFunction.GetCurrentShift();
            DateTime currentDateTime = DateTime.Now;
            decimal? plannedCycleTime = 0;
            decimal? plannedCycleTimeInMin = 0;

            decimal hrs = 0;

            var shiftStartTime = db.UnitworkccsTblshiftMstr.Where(m => m.ShiftName == shift).Select(m => m.StartTime).FirstOrDefault();
            var shiftStartDateTime = correctedDate + " " + shiftStartTime;
            DateTime shiftDateTime = Convert.ToDateTime(shiftStartDateTime);

            var check1 = (from wf in db.UnitworkccsTblfgpartnodet
                          where wf.MachineId == machineId && wf.CorrectedDate == correctedDate && wf.StartDate != null && wf.Shift == shift && wf.IsClosed != 1
                          orderby wf.FgPartId descending
                          select new
                          {
                              FgPartId = wf.FgPartId,
                              PlanLinkageId = wf.PlanLinkageId,
                              StartDate = wf.StartDate,
                              ClosedDate = wf.ClosedDate,
                              OperationNo = wf.OperationNo,
                              NoOfPartsPerCycle = wf.NoOfPartsPerCycle,
                              targetQty = wf.TargetQty,
                              idealCycleTime = wf.IdealCycleTime,
                              unit = wf.Unit
                          }).FirstOrDefault();

            if (check1 != null)
            {

                #region check isPCB

                var machine = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == machineId && m.IsPcb == 1).FirstOrDefault();

                #endregion

                if (machine == null)
                {
                    var parametermasterlistAll = db.UnitworkccsParametersMaster.Where(m => m.CorrectedDate == correctedDate1 && m.InsertedOn >= shiftDateTime && m.InsertedOn <= currentDateTime).ToList();
                    var parametermasterlist = parametermasterlistAll.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate1 && m.InsertedOn >= shiftDateTime && m.InsertedOn <= currentDateTime).ToList();
                    var TopRow = parametermasterlist.OrderByDescending(m => m.ParameterId).FirstOrDefault();
                    var LastRow = parametermasterlist.OrderBy(m => m.ParameterId).FirstOrDefault();

                    if (TopRow != null && LastRow != null)
                    {
                        Actual2 = Convert.ToInt32(TopRow.PartsTotal - LastRow.PartsTotal);
                    }

                    var diffInSeconds = (currentDateTime - shiftDateTime).TotalMinutes;
                    decimal durationInMin = Convert.ToDecimal(diffInSeconds);


                    //var partsDet = db.UnitworkccsTblplanlinkagemaster.Where(m => m.IsDeleted == 0 && m.PlanLinkageId == check1.PlanLinkageId && m.Operation == check1.OperationNo).FirstOrDefault();
                    //if (partsDet != null)
                    //{
                    if (check1.unit == "Minutes")
                    {
                        plannedCycleTime = Convert.ToDecimal(check1.idealCycleTime);
                        plannedCycleTimeInMin = Math.Round((Convert.ToDecimal(plannedCycleTime)), 2);
                        //var StdCycleTimeinMin = Convert.ToDecimal(plannedCycleTimeInMin);
                        hrs = durationInMin;
                    }
                    else if (check1.unit == "Seconds")
                    {
                        plannedCycleTime = Convert.ToDecimal(check1.idealCycleTime);
                        plannedCycleTimeInMin = Math.Round((Convert.ToDecimal(plannedCycleTime / 60)), 2);
                        hrs = durationInMin / 60;
                    }
                    //}

                    Actual2 = Actual2 * Convert.ToInt32(check1.NoOfPartsPerCycle);
                    Target2 = Convert.ToInt32((double)durationInMin / (double)plannedCycleTimeInMin);
                    //Target2 = Convert.ToInt32(partDet.TargetPerShift);
                }
                else
                {
                    var parametermasterlistLast = db.UnitworkccsTblpartscountandcutting.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate1 && m.StartTime >= shiftDateTime && m.EndTime <= currentDateTime).ToList().Sum(m => m.PartCount);

                    Actual2 = parametermasterlistLast;

                    var diffInSeconds = (currentDateTime - shiftDateTime).TotalMinutes;
                    decimal durationInMin = Convert.ToDecimal(diffInSeconds);
                    //hrs = durationInMin / 60;

                    //var partsDet = db.UnitworkccsTblplanlinkagemaster.Where(m => m.IsDeleted == 0 && m.PlanLinkageId == check1.PlanLinkageId && m.Operation == check1.OperationNo).FirstOrDefault();
                    //if (partsDet != null)
                    //{
                    if (check1.unit == "Minutes")
                    {
                        plannedCycleTime = Convert.ToDecimal(check1.idealCycleTime);
                        plannedCycleTimeInMin = Math.Round((Convert.ToDecimal(plannedCycleTime)), 2);
                        //var StdCycleTimeinMin = Convert.ToDecimal(plannedCycleTimeInMin);
                        //hrs = durationInMin;
                    }
                    else if (check1.unit == "Seconds")
                    {
                        plannedCycleTime = Convert.ToDecimal(check1.idealCycleTime);
                        plannedCycleTimeInMin = Math.Round((Convert.ToDecimal(plannedCycleTime / 60)), 2);
                        //hrs = durationInMin / 60;
                    }
                    //}
                    Target2 = Convert.ToInt32((double)durationInMin / (double)plannedCycleTimeInMin);
                    //Target2 = Convert.ToInt32(partDet.TargetPerShift);
                }

                var dbCheck = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate && m.StartDate != null && m.IsClosed != 1).OrderByDescending(m => m.FgPartId).FirstOrDefault();
                if (dbCheck != null)
                {
                    dbCheck.ActaulValue = Actual2;
                    dbCheck.TargetQty = Target2;
                    db.SaveChanges();
                }

                #region inserting data to parts and cutting table
                var res = db.UnitworkccsTblpartscountandcutting.Where(m => m.MachineId == machineId && m.ShiftName == shift && m.CorrectedDate == correctedDate1).FirstOrDefault();
                if (res == null)
                {
                    UnitworkccsTblpartscountandcutting UnitworkccsTblpartscountandcutting = new UnitworkccsTblpartscountandcutting();
                    UnitworkccsTblpartscountandcutting.ActualQty = Actual2;
                    UnitworkccsTblpartscountandcutting.CorrectedDate = correctedDate1;
                    UnitworkccsTblpartscountandcutting.CreatedOn = DateTime.Now;
                    UnitworkccsTblpartscountandcutting.MachineId = machineId;
                    UnitworkccsTblpartscountandcutting.ShiftName = shift;
                    UnitworkccsTblpartscountandcutting.TargetQuantity = Target2;
                    db.UnitworkccsTblpartscountandcutting.Add(UnitworkccsTblpartscountandcutting);
                    db.SaveChanges();
                }
                else
                {
                    res.ActualQty = Actual2;
                    res.CorrectedDate = correctedDate1;
                    res.CreatedOn = DateTime.Now;
                    res.MachineId = machineId;
                    res.ShiftName = shift;
                    res.TargetQuantity = Target2;
                    db.SaveChanges();
                }
                #endregion
            }

            //}

        }

        //public int GetRejectionDetailsPerHour(int machineId)
        //{
        //    CommonFunction commonFunction = new CommonFunction();
        //    string correctedDate = commonFunction.GetCorrectedDate();
        //    int qty = 0;

        //    var check = (from wf in db.UnitworkccsTblfgpartnodet
        //                 where wf.MachineId == machineId && wf.CorrectedDate == correctedDate && wf.StartDate != null && wf.ClosedDate != null
        //                 orderby wf.FgPartId descending
        //                 select new
        //                 {
        //                     FgPartId = wf.FgPartId,
        //                     StartDate = wf.StartDate,
        //                     ClosedDate = wf.ClosedDate
        //                 }).FirstOrDefault();

        //    if (check != null)
        //    {
        //        var dbCheck = db.UnitworkccsTblrejectiondetails.Where(m => m.CreatedOn >= check.StartDate && m.CreatedOn <= check.ClosedDate && m.CorrectedDate == correctedDate && m.FgPartId == check.FgPartId).Select(m => m.DefectQty).Sum();
        //        qty = Convert.ToInt32(dbCheck);
        //    }
        //    return qty;
        //}

        //public int GetReworkDetailsPerHour(int machineId)
        //{
        //    CommonFunction commonFunction = new CommonFunction();
        //    string correctedDate = commonFunction.GetCorrectedDate();
        //    int qty = 0;

        //    var check = (from wf in db.UnitworkccsTblfgpartnodet
        //                 where wf.MachineId == machineId && wf.CorrectedDate == correctedDate && wf.StartDate != null && wf.ClosedDate != null
        //                 orderby wf.FgPartId descending
        //                 select new
        //                 {
        //                     FgPartId = wf.FgPartId,
        //                     StartDate = wf.StartDate,
        //                     ClosedDate = wf.ClosedDate
        //                 }).FirstOrDefault();

        //    if (check != null)
        //    {
        //        var dbCheck = db.UnitworkccsTblreworkdetails.Where(m => m.CreatedOn >= check.StartDate && m.CreatedOn <= check.ClosedDate && m.CorrectedDate == correctedDate && m.FgPartId == check.FgPartId).Select(m => m.DefectQty).Sum();
        //        qty = Convert.ToInt32(dbCheck);
        //    }
        //    return qty;
        //}

        public int GetDryRunCount(int machineId)
        {
            CommonFunction commonFunction = new CommonFunction();
            int Actual = 0;
            //var parametermasterlistAll = new List<ParametersMaster>();
            //var parametermasterlist = new List<ParametersMaster>();
            string correctedDate = commonFunction.GetCorrectedDate();
            DateTime correctedDate1 = Convert.ToDateTime(correctedDate);
            DateTime currentDateTime = DateTime.Now;
            string shift = commonFunction.GetCurrentShift();

            var check = (from wf in db.UnitworkccsTbldryrun
                         where wf.MachineId == machineId && wf.StartDate != null && wf.CorrectedDate == correctedDate && wf.EndDate == null
                         orderby wf.DryRunId descending
                         select new
                         {
                             StartDate = wf.StartDate,
                             DryRunId = wf.DryRunId
                         }).FirstOrDefault();

            if (check != null)
            {
                #region check isPCB

                var machine = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == machineId && m.IsPcb == 1).FirstOrDefault();

                #endregion

                if (machine == null)
                {
                    var parametermasterlistAll = db.UnitworkccsParametersMaster.Where(m => m.CorrectedDate == correctedDate1 && m.InsertedOn >= check.StartDate && m.InsertedOn <= currentDateTime).ToList();
                    var parametermasterlist = parametermasterlistAll.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate1 && m.InsertedOn >= check.StartDate && m.InsertedOn <= currentDateTime).ToList();
                    var TopRow = parametermasterlist.OrderByDescending(m => m.ParameterId).FirstOrDefault();
                    var LastRow = parametermasterlist.OrderBy(m => m.ParameterId).FirstOrDefault();

                    if (TopRow != null && LastRow != null)
                    {
                        Actual = Convert.ToInt32(TopRow.PartsTotal - LastRow.PartsTotal);
                    }
                }
                else
                {
                    var parametermasterlistLast = db.UnitworkccsTblpartscountandcutting.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate1 && m.StartTime >= check.StartDate && m.EndTime <= currentDateTime).ToList().Sum(m => m.PartCount);

                    Actual = parametermasterlistLast;
                }

                var dbCheck = db.UnitworkccsTbldryrun.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate && m.StartDate != null && m.EndDate == null).OrderByDescending(m => m.DryRunId).FirstOrDefault();
                if (dbCheck != null)
                {
                    dbCheck.PartCount = Actual;
                    db.SaveChanges();
                }

                #region inserting data to parts and cutting table
                var res = db.UnitworkccsTblpartscountandcutting.Where(m => m.MachineId == machineId && m.ShiftName == shift && m.CorrectedDate == correctedDate1).FirstOrDefault();
                if (res != null)
                {
                    res.DryRunQty = Actual;
                    res.ModifiedOn = DateTime.Now;
                    db.SaveChanges();
                }
                #endregion
            }
            return Actual;
        }

        public int GetOkQuantity(int machineId)
        {
            CommonFunction commonFunction = new CommonFunction();
            int Actual = 0;
            //var parametermasterlistAll = new List<ParametersMaster>();
            //var parametermasterlist = new List<ParametersMaster>();
            string correctedDate = commonFunction.GetCorrectedDate();
            DateTime correctedDate1 = Convert.ToDateTime(correctedDate);
            DateTime currentDateTime = DateTime.Now;
            string shift = commonFunction.GetCurrentShift();

            var shiftStartTime = db.UnitworkccsTblshiftMstr.Where(m => m.ShiftName == shift).Select(m => m.StartTime).FirstOrDefault();
            var shiftStartDateTime = correctedDate + " " + shiftStartTime;
            DateTime shiftDateTime = Convert.ToDateTime(shiftStartDateTime);

            var check1 = (from wf in db.UnitworkccsTblfgpartnodet
                          where wf.MachineId == machineId && wf.CorrectedDate == correctedDate && wf.StartDate != null && wf.Shift == shift && wf.IsClosed != 1
                          orderby wf.FgPartId descending
                          select new
                          {
                              FgPartId = wf.FgPartId,
                              StartDate = wf.StartDate,
                              ClosedDate = wf.ClosedDate,
                              NoOfPartsPerCycle = wf.NoOfPartsPerCycle
                          }).FirstOrDefault();

            if (check1 != null)
            {
                #region check isPCB

                var machine = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == machineId && m.IsPcb == 1).FirstOrDefault();

                #endregion

                //DateTime startTime = Convert.ToDateTime(correctedDate.ToString() + " " + check.StartTime.ToString());
                //DateTime endTime = Convert.ToDateTime(correctedDate.ToString() + " " + check.EndTime.ToString());

                if (machine == null)
                {
                    var parametermasterlistAll = db.UnitworkccsParametersMaster.Where(m => m.CorrectedDate == correctedDate1 && m.InsertedOn >= shiftDateTime && m.InsertedOn <= currentDateTime).ToList();
                    var parametermasterlist = parametermasterlistAll.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate1 && m.InsertedOn >= shiftDateTime && m.InsertedOn <= currentDateTime).ToList();
                    var TopRow = parametermasterlist.OrderByDescending(m => m.ParameterId).FirstOrDefault();
                    var LastRow = parametermasterlist.OrderBy(m => m.ParameterId).FirstOrDefault();

                    if (TopRow != null && LastRow != null)
                    {
                        Actual = Convert.ToInt32(TopRow.PartsTotal - LastRow.PartsTotal);
                    }
                    Actual = (Actual * Convert.ToInt32(check1.NoOfPartsPerCycle));
                }
                else
                {
                    var parametermasterlistLast = db.UnitworkccsTblpartscountandcutting.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate1 && m.StartTime >= shiftDateTime && m.EndTime <= currentDateTime).ToList().Sum(m => m.PartCount);

                    Actual = parametermasterlistLast;
                }

            }
            return Actual;
        }

        public int GetRejectionDetailsShiftWise(int machineId)
        {
            CommonFunction commonFunction = new CommonFunction();
            int qty = 0;
            string correctedDate = commonFunction.GetCorrectedDate();
            DateTime correctedDate1 = Convert.ToDateTime(correctedDate);
            string shift = commonFunction.GetCurrentShift();
            DateTime currentDateTime = DateTime.Now;

            //var check = (from wf in db.UnitworkccsTblshiftMstr
            //             where wf.ShiftName == shift
            //             select new
            //             {
            //                 StartTime = wf.StartTime,
            //                 EndTime = wf.EndTime
            //             }).FirstOrDefault();

            var check1 = (from wf in db.UnitworkccsTblfgpartnodet
                          where wf.MachineId == machineId && wf.CorrectedDate == correctedDate && wf.StartDate != null && wf.Shift == shift && wf.IsClosed != 1
                          orderby wf.FgPartId descending
                          select new
                          {
                              FgPartId = wf.FgPartId,
                              StartDate = wf.StartDate,
                              ClosedDate = wf.ClosedDate
                          }).FirstOrDefault();

            if (check1 != null)
            {
                //DateTime startTime = Convert.ToDateTime(correctedDate.ToString() + " " + check.StartTime.ToString());
                //DateTime endTime = Convert.ToDateTime(correctedDate.ToString() + " " + check.EndTime.ToString());

                var dbCheck = db.UnitworkccsTblrejectiondetails.Where(m => m.CreatedOn >= check1.StartDate && m.CreatedOn <= currentDateTime && m.CorrectedDate == correctedDate && m.FgPartId == check1.FgPartId && m.Shift == shift).Select(m => m.DefectQty).Sum();
                qty = Convert.ToInt32(dbCheck);
            }

            #region inserting data to parts and cutting table
            var res = db.UnitworkccsTblpartscountandcutting.Where(m => m.MachineId == machineId && m.ShiftName == shift && m.CorrectedDate == correctedDate1.Date).OrderByDescending(m => m.Pcid).FirstOrDefault();
            if (res != null)
            {
                res.RejectionQty = qty;
                res.ModifiedOn = DateTime.Now;
                db.SaveChanges();

            }
            #endregion

            return qty;
        }

        public int GetReworkDetailsShiftWise(int machineId)
        {
            CommonFunction commonFunction = new CommonFunction();
            string correctedDate = commonFunction.GetCorrectedDate();
            int qty = 0;
            DateTime correctedDate1 = Convert.ToDateTime(correctedDate);
            string shift = commonFunction.GetCurrentShift();
            DateTime currentDateTime = DateTime.Now;

            //var check = (from wf in db.UnitworkccsTblshiftMstr
            //             where wf.ShiftName == shift
            //             select new
            //             {
            //                 StartTime = wf.StartTime,
            //                 EndTime = wf.EndTime
            //             }).FirstOrDefault();

            var check1 = (from wf in db.UnitworkccsTblfgpartnodet
                          where wf.MachineId == machineId && wf.CorrectedDate == correctedDate && wf.StartDate != null && wf.Shift == shift && wf.IsClosed != 1
                          orderby wf.FgPartId descending
                          select new
                          {
                              FgPartId = wf.FgPartId,
                              StartDate = wf.StartDate,
                              ClosedDate = wf.ClosedDate
                          }).FirstOrDefault();

            if (check1 != null)
            {
                //DateTime startTime = Convert.ToDateTime(correctedDate.ToString() + " " + check.StartTime.ToString());
                //DateTime endTime = Convert.ToDateTime(correctedDate.ToString() + " " + check.EndTime.ToString());

                var dbCheck = db.UnitworkccsTblreworkdetails.Where(m => m.CreatedOn >= check1.StartDate && m.CreatedOn <= currentDateTime && m.CorrectedDate == correctedDate && m.FgPartId == check1.FgPartId && m.Shift == shift).Select(m => m.DefectQty).Sum();
                qty = Convert.ToInt32(dbCheck);
            }

            #region inserting data to parts and cutting table
            var res = db.UnitworkccsTblpartscountandcutting.Where(m => m.MachineId == machineId && m.ShiftName == shift && m.CorrectedDate == correctedDate1).FirstOrDefault();
            if (res != null)
            {

                res.ReworkQty = qty;
                res.ModifiedOn = DateTime.Now;
                db.SaveChanges();

            }
            #endregion

            return qty;
        }

        public decimal GetRunningBalance(int machineId)
        {
            CommonFunction commonFunction = new CommonFunction();
            string correctedDate = commonFunction.GetCorrectedDate();
            string shift = commonFunction.GetCurrentShift();
            decimal woQty = 0;

            var check = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate && m.Shift == shift && m.IsClosed != 1).OrderByDescending(m => m.FgPartId).FirstOrDefault();
            if (check != null)
            {
                woQty = Convert.ToDecimal(check.PartCountMethod);
            }
            return woQty;
        }

        public int GetWoBalanceQty(int machineId)
        {
            CommonFunction commonFunction = new CommonFunction();
            string correctedDate = commonFunction.GetCorrectedDate();
            int woBalanceQty = 0;

            var firstRow = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate).Select(m => m.PartCountMethod).FirstOrDefault();
            var lastRow = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate).Select(m => m.PartCountMethod).LastOrDefault();
            int firstWoQty = Convert.ToInt32(firstRow);
            int secondWoQty = Convert.ToInt32(lastRow);
            if (firstWoQty > secondWoQty)
            {
                woBalanceQty = firstWoQty - secondWoQty;
            }
            return woBalanceQty;
        }

        public OEEDashboard OEE1(int machineId)
        {
            OEEDashboard oEE = new OEEDashboard();
            double plannedBrkDurationinMin = 0;
            double TotalAvailableTime = 0;
            double TotalAvailableTime1 = 0;
            double NetAvailableTime = 0;

            decimal OperatingTime = 0;
            double AvailabilityPercentage = 0;
            double PerformancePercentage = 0;
            double OEEPercentage = 0;
            double Quality = 0;
            int Actual = 0;
            double Target = 0;
            int ActualQty1 = 0;
            int TargetQty1 = 0;
            decimal ActualQty = 0;
            decimal plannedCycleTime = 0;
            decimal ActualQtyPerShift = 0;
            decimal OkQty = 0;
            int rejQty = 0;
            int reworkQty = 0;
            int trial = 0;
            decimal DayOEEPercent = 0;
            double totalDowntime = 0;
            decimal plannedCycleTimeInMin = 0;

            CommonFunction commonFunction = new CommonFunction();
            string shift = commonFunction.GetCurrentShift();
            string correctedDate = commonFunction.GetCorrectedDate();
            DateTime correctedDate1 = Convert.ToDateTime(correctedDate);
            DateTime currentDate = DateTime.Now;

            #region check isPCB

            var machine = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == machineId && m.IsPcb == 1).FirstOrDefault();

            #endregion


            #region Fg Part star to Current Date Time 

            var check = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate && m.IsClosed != 1 && m.Shift == shift).OrderByDescending(m => m.FgPartId).FirstOrDefault();

            var shiftStartTime = db.UnitworkccsTblshiftMstr.Where(m => m.ShiftName == shift).Select(m => m.StartTime).FirstOrDefault();
            var shiftStartDateTime = correctedDate + " " + shiftStartTime;
            DateTime shiftDateTime = Convert.ToDateTime(shiftStartDateTime);

            if (machine == null)
            {
                if (check != null)
                {

                    TotalAvailableTime = (currentDate - shiftDateTime).TotalMinutes;

                    var checkTicket = db.UnitworkccsTblraisedticket.Where(m => m.MachineId == machineId && (m.Status == 1 || m.Status == 2 || m.Status == 3) && m.TicketOpenDate != null && m.TicketNo.Contains("Downtime-Stopped-BDS")).OrderByDescending(m => m.TicketId).FirstOrDefault();

                    if (checkTicket != null)
                    {
                        //DateTime ticketCloseDate = DateTime.Now;

                        DateTime ticketOpenDate = Convert.ToDateTime(checkTicket.TicketOpenDate);
                        if (shiftDateTime > ticketOpenDate)
                        {
                            totalDowntime = (shiftDateTime - ticketOpenDate).TotalMinutes;
                            if (totalDowntime < 0)
                            {
                                totalDowntime = (currentDate - shiftDateTime).TotalMinutes;
                                NetAvailableTime = TotalAvailableTime - totalDowntime;
                            }
                            else
                            {
                                totalDowntime = (shiftDateTime - ticketOpenDate).TotalMinutes;
                                NetAvailableTime = TotalAvailableTime - totalDowntime;
                            }

                            if (NetAvailableTime < 0)
                            {
                                NetAvailableTime = 0;
                            }
                        }
                        else
                        {
                            totalDowntime = (ticketOpenDate - shiftDateTime).TotalMinutes;
                            //totalDowntime = (ticketCloseDate - ticketOpenDate).TotalMinutes;
                            NetAvailableTime = TotalAvailableTime - totalDowntime;
                        }

                    }
                    else
                    {
                        var checkTicket1 = db.UnitworkccsTblraisedticket.Where(m => m.MachineId == machineId && (m.Status == 4 || m.Status == 5) && m.TicketOpenDate != null && m.TicketClosedDate != null && m.TicketNo.Contains("Downtime-Stopped-BDS")).OrderByDescending(m => m.TicketId).FirstOrDefault();
                        if (checkTicket1 != null)
                        {
                            DateTime ticketCloseDate = Convert.ToDateTime(checkTicket1.TicketClosedDate);
                            string tktClosedDate = ticketCloseDate.ToString("yyyy-MM-dd");
                            if (Convert.ToDateTime(correctedDate) <= Convert.ToDateTime(tktClosedDate))
                            {
                                DateTime ticketCloseDate1 = Convert.ToDateTime(checkTicket1.TicketClosedDate);
                                DateTime ticketOpenDate = Convert.ToDateTime(checkTicket1.TicketOpenDate);

                                //totalDowntime = (ticketCloseDate1 - ticketOpenDate).TotalMinutes;
                                totalDowntime = (ticketCloseDate1 - shiftDateTime).TotalMinutes;
                                NetAvailableTime = TotalAvailableTime - totalDowntime;
                            }
                            else
                            {
                                NetAvailableTime = TotalAvailableTime;
                            }
                        }
                        else
                        {
                            NetAvailableTime = TotalAvailableTime;
                        }
                    }

                    #region Performance

                    using (unitworksccsContext db1 = new unitworksccsContext())
                    {
                        var parametermasterlistLast = db1.UnitworkccsParametersMaster.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate1 && m.InsertedOn >= shiftDateTime && m.InsertedOn <= currentDate).ToList();

                        var TopRowLast = parametermasterlistLast.OrderByDescending(m => m.ParameterId).FirstOrDefault();
                        var RowLast = parametermasterlistLast.OrderBy(m => m.ParameterId).FirstOrDefault();

                        if (TopRowLast != null && RowLast != null)
                        {
                            ActualQty = Convert.ToInt32(TopRowLast.PartsTotal - RowLast.PartsTotal);
                        }

                    }


                    ActualQty = ActualQty * Convert.ToInt32(check.NoOfPartsPerCycle);

                    //var partsDet = db.UnitworkccsTblplanlinkagemaster.Where(m => m.IsDeleted == 0 && m.PlanLinkageId == check.PlanLinkageId && m.Operation == check.OperationNo).FirstOrDefault();
                    //if (partsDet != null)
                    //{
                    if (check.Unit == "Minutes")
                    {
                        plannedCycleTime = Convert.ToDecimal(check.IdealCycleTime);
                        plannedCycleTimeInMin = Math.Round((plannedCycleTime), 2);
                        //var StdCycleTimeinMin = Convert.ToDecimal(plannedCycleTimeInMin);
                    }
                    else if (check.Unit == "Seconds")
                    {
                        plannedCycleTime = Convert.ToDecimal(check.IdealCycleTime);
                        plannedCycleTimeInMin = Math.Round((plannedCycleTime / 60), 2);
                    }
                    //}


                    trial = GetTrialCount(machineId);

                    decimal performanceNumerator = (ActualQty - trial);

                    double performanceDenominator = (NetAvailableTime / (double)plannedCycleTimeInMin);

                    #endregion

                    #region Quality

                    rejQty = GetRejectionDetailsShiftWise(machineId);
                    reworkQty = GetReworkDetailsShiftWise(machineId);
                    //trial = GetTrialCount(machineId);

                    OkQty = ActualQty - rejQty - reworkQty - trial;

                    decimal qualityDenominator = OkQty + rejQty + reworkQty;

                    if (OkQty < 0)
                    {
                        OkQty = 0;
                    }

                    #endregion

                    #region Actual

                    DateTime fgPartStartDate2 = Convert.ToDateTime(check.StartDate);
                    DateTime startDate = DateTime.Now;
                    DateTime endDate = DateTime.Now;
                    var fgPartStartTimeInhr = fgPartStartDate2.Hour;
                    var startDateInHr = startDate.Hour;
                    var endDateInHr = endDate.Hour + 1;


                    var startTimer = DateTime.Now;
                    var endTimer = DateTime.Now;

                    string endTimerStr = DateTime.Now.ToString("yyyy-MM-dd") + " " + endDateInHr.ToString("D2") + ":00:00";
                    endTimer = Convert.ToDateTime(endTimerStr);
                    if (startDateInHr == fgPartStartTimeInhr)
                    {
                        startTimer = fgPartStartDate2;
                    }
                    else
                    {
                        string startTimerStr = DateTime.Now.ToString("yyyy-MM-dd") + " " + startDateInHr.ToString("D2") + ":00:00";
                        startTimer = Convert.ToDateTime(startTimerStr);
                    }

                    using (unitworksccsContext db1 = new unitworksccsContext())
                    {
                        var parametermasterlistLast1 = db1.UnitworkccsParametersMaster.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate1 && m.InsertedOn >= startTimer && m.InsertedOn <= endTimer).ToList();
                        var TopRowLast1 = parametermasterlistLast1.OrderByDescending(m => m.ParameterId).FirstOrDefault();
                        var RowLast1 = parametermasterlistLast1.OrderBy(m => m.ParameterId).FirstOrDefault();

                        if (TopRowLast1 != null && RowLast1 != null)
                        {
                            ActualQty1 = Convert.ToInt32(TopRowLast1.PartsTotal - RowLast1.PartsTotal);
                        }
                    }
                    ActualQty1 = ActualQty1 * Convert.ToInt32(check.NoOfPartsPerCycle);
                    #endregion

                    if (NetAvailableTime == 0)
                    {
                        AvailabilityPercentage = 0;
                    }
                    else
                    {
                        AvailabilityPercentage = Math.Round(((double)NetAvailableTime / TotalAvailableTime), 2) * 100;
                    }

                    if (AvailabilityPercentage >= 100)
                    {
                        AvailabilityPercentage = 100;
                    }

                    if (performanceNumerator <= 0)
                    {
                        PerformancePercentage = 0;
                    }
                    else
                    {

                        PerformancePercentage = Math.Round(((double)performanceNumerator / (double)performanceDenominator), 2) * 100;
                    }

                    if (qualityDenominator == 0)
                    {
                        Quality = 0;
                    }
                    else
                    {

                        Quality = Math.Round(((double)OkQty / (double)qualityDenominator), 2) * 100;
                    }

                    DayOEEPercent = (decimal)(((AvailabilityPercentage) * (PerformancePercentage) * (Quality)) / 1000000) * 100;
                    OEEPercentage = (double)DayOEEPercent;
                    Actual = ActualQty1;
                    Target = 60 / Convert.ToDouble(plannedCycleTimeInMin);
                    Target = Math.Round(Target, 0);
                    check.Availibility = AvailabilityPercentage;
                    check.Performance = PerformancePercentage;
                    check.Quality = Quality;
                    check.Oee = OEEPercentage;
                    db.SaveChanges();
                }

                #endregion
            }
            else
            {
                if (check != null)
                {

                    TotalAvailableTime = (currentDate - shiftDateTime).TotalMinutes;

                    var checkTicket = db.UnitworkccsTblraisedticket.Where(m => m.MachineId == machineId && (m.Status == 1 || m.Status == 2 || m.Status == 3) && m.TicketOpenDate != null && m.TicketNo.Contains("Downtime-Stopped-BDS")).OrderByDescending(m => m.TicketId).FirstOrDefault();

                    if (checkTicket != null)
                    {
                        DateTime ticketCloseDate = DateTime.Now;
                        DateTime ticketOpenDate = Convert.ToDateTime(checkTicket.TicketOpenDate);

                        totalDowntime = (ticketCloseDate - ticketOpenDate).TotalMinutes;
                        NetAvailableTime = TotalAvailableTime - totalDowntime;
                    }
                    else
                    {
                        var checkTicket1 = db.UnitworkccsTblraisedticket.Where(m => m.MachineId == machineId && (m.Status == 4 || m.Status == 5) && m.TicketOpenDate != null && m.TicketClosedDate != null && m.TicketNo.Contains("Downtime-Stopped-BDS")).OrderByDescending(m => m.TicketId).FirstOrDefault();
                        if (checkTicket1 != null)
                        {
                            DateTime ticketCloseDate = Convert.ToDateTime(checkTicket1.TicketClosedDate);
                            string tktClosedDate = ticketCloseDate.ToString("yyyy-MM-dd");
                            if (Convert.ToDateTime(correctedDate) <= Convert.ToDateTime(tktClosedDate))
                            {
                                DateTime ticketCloseDate1 = Convert.ToDateTime(checkTicket1.TicketClosedDate);
                                DateTime ticketOpenDate = Convert.ToDateTime(checkTicket.TicketOpenDate);

                                totalDowntime = (ticketCloseDate1 - ticketOpenDate).TotalMinutes;
                                NetAvailableTime = TotalAvailableTime - totalDowntime;
                            }
                            else
                            {
                                NetAvailableTime = TotalAvailableTime;
                            }
                        }
                        else
                        {
                            NetAvailableTime = TotalAvailableTime;
                        }
                    }

                    #region Performance

                    var parametermasterlistLast = db.UnitworkccsTblpartscountandcutting.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate1 && m.StartTime >= shiftDateTime && m.EndTime <= currentDate).ToList().Sum(m => m.PartCount);

                    ActualQty = parametermasterlistLast;

                    //var partsDet = db.UnitworkccsTblplanlinkagemaster.Where(m => m.IsDeleted == 0 && m.PlanLinkageId == check.PlanLinkageId && m.Operation == check.OperationNo).FirstOrDefault();
                    //if (partsDet != null)
                    //{
                    if (check.Unit == "Minutes")
                    {
                        plannedCycleTime = Convert.ToDecimal(check.IdealCycleTime);
                        plannedCycleTimeInMin = Math.Round((60 / plannedCycleTime), 2);
                        //var StdCycleTimeinMin = Convert.ToDecimal(plannedCycleTimeInMin);
                    }
                    else if (check.Unit == "Seconds")
                    {
                        plannedCycleTime = Convert.ToDecimal(check.IdealCycleTime);
                        //plannedCycleTimeInMin = Math.Round((3600 / plannedCycleTime), 2);
                        plannedCycleTimeInMin = Math.Round((plannedCycleTime / 60), 2);
                    }
                    //}


                    trial = GetTrialCount(machineId);

                    decimal performanceNumerator = ((ActualQty - trial) * plannedCycleTimeInMin);

                    double performanceDenominator = NetAvailableTime;

                    #endregion

                    #region Quality

                    rejQty = GetRejectionDetailsShiftWise(machineId);
                    reworkQty = GetReworkDetailsShiftWise(machineId);
                    trial = GetTrialCount(machineId);

                    OkQty = ActualQty - rejQty - reworkQty - trial;

                    decimal qualityDenominator = OkQty + rejQty + reworkQty;

                    if (OkQty < 0)
                    {
                        OkQty = 0;
                    }

                    #endregion

                    #region Actual

                    DateTime fgPartStartDate2 = Convert.ToDateTime(check.StartDate);
                    DateTime startDate = DateTime.Now;
                    DateTime endDate = DateTime.Now;
                    var fgPartStartTimeInhr = fgPartStartDate2.Hour;
                    var startDateInHr = startDate.Hour;
                    var endDateInHr = endDate.Hour + 1;


                    var startTimer = DateTime.Now;
                    var endTimer = DateTime.Now;

                    string endTimerStr = DateTime.Now.ToString("yyyy-MM-dd") + " " + endDateInHr.ToString("D2") + ":00:00";
                    endTimer = Convert.ToDateTime(endTimerStr);
                    if (startDateInHr == fgPartStartTimeInhr)
                    {
                        startTimer = fgPartStartDate2;
                    }
                    else
                    {
                        string startTimerStr = DateTime.Now.ToString("yyyy-MM-dd") + " " + startDateInHr.ToString("D2") + ":00:00";
                        startTimer = Convert.ToDateTime(startTimerStr);
                    }

                    var parametermasterlistLast1 = db.UnitworkccsTblpartscountandcutting.Where(m => m.MachineId == machineId && m.CorrectedDate == correctedDate1 && m.StartTime >= startTimer && m.EndTime <= endTimer).ToList().Sum(m => m.PartCount);

                    ActualQty1 = parametermasterlistLast1;

                    #endregion



                    if (NetAvailableTime == 0)
                    {
                        AvailabilityPercentage = 0;
                    }
                    else
                    {

                        AvailabilityPercentage = Math.Round(((double)NetAvailableTime / TotalAvailableTime), 2) * 100;
                    }

                    if (AvailabilityPercentage >= 100)
                    {
                        AvailabilityPercentage = 100;
                    }

                    if (performanceNumerator == 0)
                    {
                        PerformancePercentage = 0;
                    }
                    else
                    {

                        PerformancePercentage = Math.Round(((double)performanceNumerator / (double)performanceDenominator), 2) * 100;
                    }

                    if (qualityDenominator == 0)
                    {
                        Quality = 0;
                    }
                    else
                    {

                        Quality = Math.Round(((double)OkQty / (double)qualityDenominator), 2) * 100;
                    }

                    DayOEEPercent = (decimal)(((AvailabilityPercentage) * (PerformancePercentage) * (Quality)) / 1000000) * 100;
                    OEEPercentage = (double)DayOEEPercent;
                    Actual = ActualQty1;
                    Target = 60 / Convert.ToDouble(plannedCycleTimeInMin);

                    check.Availibility = AvailabilityPercentage;
                    check.Performance = PerformancePercentage;
                    check.Quality = Quality;
                    check.Oee = OEEPercentage;
                    db.SaveChanges();
                }
            }

            oEE.AvailabilityPercentage = AvailabilityPercentage;
            oEE.PerformancePercentage = PerformancePercentage;
            try
            {
                oEE.OEEPercentage = Math.Round(((PerformancePercentage * AvailabilityPercentage * Quality) / 1000000), 2) * 100;
            }
            catch (Exception ex)
            {
                oEE.OEEPercentage = 0.1;
            }

            oEE.Quality = Quality;
            oEE.Actual = Actual;
            oEE.Target = Target;

            return oEE;
        }

        public bool CheckMacIdleAndSendToMsg(int machineId)
        {
            //CommonResponse obj = new CommonResponse();
            bool res = false;
            CommonFunction commonFunction = new CommonFunction();
            string shift = commonFunction.GetCurrentShift();
            string correctedDate = commonFunction.GetCorrectedDate();
            DateTime correctedDate1 = Convert.ToDateTime(correctedDate);

            try
            {
                var checkMachineIdle = db.UnitworkccsTbllivemode.Where(m => m.MachineId == machineId && m.MacMode == "IDLE" && m.CorrectedDate == correctedDate1 && m.IsCompleted == 0).Select(m => m.StartTime).FirstOrDefault();

                var machineName = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == machineId).Select(m => m.MachineName).FirstOrDefault();

                if (checkMachineIdle != null)
                {
                    DateTime IdleSartDate = Convert.ToDateTime(checkMachineIdle);
                    DateTime CurrentDateTime = DateTime.Now;

                    var diffInSeconds = (CurrentDateTime - IdleSartDate).TotalSeconds;

                    if (diffInSeconds > 900)
                    {
                        #region sms integration

                        var currentFgpart = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == machineId).OrderByDescending(m => m.FgPartId).Select(m => m.PlanLinkageId).FirstOrDefault();

                        var partNo = db.UnitworkccsTblplanlinkagemaster.Where(m => m.PlanLinkageId == currentFgpart).Select(m => m.FgPartNo).FirstOrDefault();

                        var cellId = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.CellFinalId).FirstOrDefault();

                        var subCellId = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.SubCellFinalId).FirstOrDefault();

                        var operatorDetails = db.UnitworkccsTbloperatordetails.Where(m => m.Shift == shift && m.SubCellId == subCellId && (m.RoleId == 11 || m.RoleId == 15)).Select(m => m.ContactNo).ToList();

                        foreach (var item in operatorDetails)
                        {

                            string ticketOpenName = "M/C IDLE Alert!!\n" + machineName + "," + "Machine Status" + "-" + "IDLE\n" + "\n" + "I-FACILITY";

                            var check = db.UnitworkccsTblsmsdetails.Where(m => m.Shift == shift && m.ContactNo == item && m.MachineId == machineId && m.CorrectedDate == correctedDate).FirstOrDefault();

                            if (check == null)
                            {
                                string sendSms = commonFunction.SMSEscalationSendPostURLEncode("12", item, ticketOpenName, appSettings.SmsKey, appSettings.SmsDetailsPost);

                                if (sendSms != null)
                                {
                                    UnitworkccsTblsmsdetails UnitworkccsTblsmsdetails = new UnitworkccsTblsmsdetails();
                                    UnitworkccsTblsmsdetails.ContactNo = item;
                                    UnitworkccsTblsmsdetails.MachineId = machineId;
                                    UnitworkccsTblsmsdetails.IsDeleted = 0;
                                    UnitworkccsTblsmsdetails.IdleResponseId = sendSms;
                                    UnitworkccsTblsmsdetails.IdleSms = 1;
                                    UnitworkccsTblsmsdetails.Shift = shift;
                                    UnitworkccsTblsmsdetails.Message = ticketOpenName;
                                    UnitworkccsTblsmsdetails.CorrectedDate = correctedDate;
                                    UnitworkccsTblsmsdetails.CreatedOn = DateTime.Now;
                                    db.UnitworkccsTblsmsdetails.Add(UnitworkccsTblsmsdetails);
                                    db.SaveChanges();
                                    res = true;
                                }
                            }
                        }

                        var operatorDetails1 = db.UnitworkccsTbloperatordetails.Where(m => m.SubCellId == subCellId && (m.RoleId == 14 || m.RoleId == 16 || m.RoleId == 17)).Select(m => m.ContactNo).ToList();

                        foreach (var items in operatorDetails1)
                        {

                            string ticketOpenName1 = "M/C IDLE Alert!!\n" + machineName + "," + "Machine Status" + "-" + "IDLE\n" + "\n" + "I-FACILITY";

                            var check1 = db.UnitworkccsTblsmsdetails.Where(m => m.Shift == shift && m.ContactNo == items && m.MachineId == machineId && m.CorrectedDate == correctedDate).FirstOrDefault();

                            if (check1 == null)
                            {
                                string sendSms = commonFunction.SMSEscalationSendPostURLEncode("12", items, ticketOpenName1, appSettings.SmsKey, appSettings.SmsDetailsPost);

                                if (sendSms != null)
                                {
                                    UnitworkccsTblsmsdetails UnitworkccsTblsmsdetails = new UnitworkccsTblsmsdetails();
                                    UnitworkccsTblsmsdetails.ContactNo = items;
                                    UnitworkccsTblsmsdetails.MachineId = machineId;
                                    UnitworkccsTblsmsdetails.IsDeleted = 0;
                                    UnitworkccsTblsmsdetails.IdleResponseId = sendSms;
                                    UnitworkccsTblsmsdetails.IdleSms = 1;
                                    UnitworkccsTblsmsdetails.Shift = shift;
                                    UnitworkccsTblsmsdetails.Message = ticketOpenName1;
                                    UnitworkccsTblsmsdetails.CreatedOn = DateTime.Now;
                                    UnitworkccsTblsmsdetails.CorrectedDate = correctedDate;
                                    db.UnitworkccsTblsmsdetails.Add(UnitworkccsTblsmsdetails);
                                    db.SaveChanges();
                                    res = true;
                                }
                            }
                        }
                        #endregion
                    }
                }
            }
            catch (Exception)
            {

            }
            return res;
        }

        /// <summary>
        /// Tool Life Management
        /// </summary>
        /// <param name="machineId"></param>
        /// <returns></returns>
        public CommonResponse ToolLifeManagement(int machineId)
        {
            CommonResponse obj = new CommonResponse();
            CommonFunction commonFunction = new CommonFunction();
            List<SocketDetails> socketDetailsList = new List<SocketDetails>();
            List<ToolAndSocketDetails> toolAndSocketDetailsList = new List<ToolAndSocketDetails>();
            try
            {
                var check = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == machineId).Select(m => m.MachinePockets).FirstOrDefault();
                string colour = "";
                bool isToolPresent = false;

                if (check > 0)
                {
                    string socketName = appSettings.SocketName;
                    for (int i = 1; i <= check; i++)
                    {
                        SocketDetails socketDetails = new SocketDetails();
                        colour = "GREY";
                        socketDetails.SocketName = socketName + "-" + i;
                        socketDetails.machineId = machineId;

                        var dbCheck = db.UnitworkccsTbltoolandsocketdetails.Where(m => m.MachineId == machineId && m.SocketNo == socketDetails.SocketName && m.IsDeleted == 0).FirstOrDefault();
                        if (dbCheck != null)
                        {
                            ToolAndSocketDetails toolAndSocketDetails = new ToolAndSocketDetails();
                            toolAndSocketDetails.MachineId = machineId;
                            toolAndSocketDetails.SocketName = dbCheck.SocketNo;
                            toolAndSocketDetails.StandardToolLife = dbCheck.StandardToolLife;
                            toolAndSocketDetails.ActaulToolLife = dbCheck.ActaulToolLife;
                            toolAndSocketDetails.ToolNumber = dbCheck.ToolNumber;
                            toolAndSocketDetailsList.Add(toolAndSocketDetails);
                            isToolPresent = true;

                            string a = dbCheck.SocketNo;
                            string b = string.Empty;
                            int val;

                            for (int ii = 0; ii < a.Length; ii++)
                            {
                                if (Char.IsDigit(a[ii]))
                                    b += a[ii];
                            }

                            if (b.Length > 0)
                                val = int.Parse(b);

                            var actualItem = db.UnitworkccsTbltoollifeoperator.Where(m => m.ToolNo == b && m.MachineId == machineId).OrderByDescending(m => m.ToolLifeId).FirstOrDefault();
                            int actual = 0;
                            if (actualItem != null)
                            {
                                actual = actualItem.Toollifecounter;
                            }

                            colour = commonFunction.ToolColorLogic(dbCheck.StandardToolLife, actual);
                            socketDetails.colour = colour;
                            socketDetailsList.Add(socketDetails);
                        }
                        else
                        {
                            socketDetails.colour = colour;
                            socketDetailsList.Add(socketDetails);
                        }


                    }
                    obj.isStatus = true;
                    obj.response = socketDetailsList;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = Resource.ResourceResponse.NoItemsFound;
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

        //public bool SendSms(int machineId)
        //{
        //    CommonFunction commonFunction = new CommonFunction();
        //    bool flag = false;
        //    string shift = commonFunction.GetCurrentShift();
        //    string correctedDate = commonFunction.GetCorrectedDate();
        //    try
        //    {
        //        var check = (from wf in db.UnitworkccsTblraisedticket
        //                     where (wf.Status == 1 || wf.Status == 6) && wf.TicketClosedDate == null && wf.MachineId == machineId
        //                     select new
        //                     {
        //                         categoryId = wf.CategoryId,
        //                         machineId = wf.MachineId,
        //                         statusId = wf.StatusId,
        //                         ticketId = wf.TicketId,
        //                         reasonId = wf.ReasonId,
        //                         ticketOpenDate = wf.TicketOpenDate
        //                     }).ToList();

        //        if (check.Count > 0)
        //        {
        //            foreach (var item in check)
        //            {
        //                var machineInvNo = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == item.machineId).Select(m => m.MachineName).FirstOrDefault();

        //                var statusName = db.UnitworkccsTblstatusmaster.Where(m => m.StatusId == item.statusId).Select(m => m.StatusName).FirstOrDefault();

        //                var reasonName = db.UnitworkccsTblstoppage.Where(m => m.StoppagesId == item.reasonId).Select(m => m.AlramDesc).FirstOrDefault();

        //                DateTime TicketOpenDate = Convert.ToDateTime(item.ticketOpenDate);
        //                DateTime CurrentDateTime = DateTime.Now;

        //                var diffInSeconds = (CurrentDateTime - TicketOpenDate).TotalSeconds;

        //                if (diffInSeconds > 900 && diffInSeconds < 960)
        //                {
        //                    var currentFgpart = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == item.machineId).OrderByDescending(m => m.FgPartId).Select(m => m.PlanLinkageId).FirstOrDefault();

        //                    var partNo = db.UnitworkccsTblplanlinkagemaster.Where(m => m.PlanLinkageId == currentFgpart).Select(m => m.FgPartNo).FirstOrDefault();

        //                    var cellId = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.CellFinalId).FirstOrDefault();

        //                    var subCellId = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.SubCellFinalId).FirstOrDefault();

        //                    var maintainance = (from wf in db.TblEscalationMatrix
        //                                        where wf.Shift == shift && (wf.CellId == cellId || wf.CellId == 0) && (wf.SubCellId == subCellId || wf.SubCellId == 0) && wf.CategoryId == item.categoryId && wf.TimeToBeTriggered == 15 && (wf.SmsPriority == 1 || wf.SmsPriority == 2) && wf.IsDeleted == 0 && (wf.Role == "Quality head" || wf.Role == "Quality incharge" || wf.Role == "cell incharge" || wf.Role == "Line inspectors" || wf.Role == "Production incharge" || wf.Role == "Tooling incharge" || wf.Role == "HR" || wf.Role == "PPC head" || wf.Role == "Maintainance incharge" || wf.Role == "Maintainance head" || wf.Role == "Quality head" || wf.Role == "supervisor" || wf.Role == "Toolstores" || wf.Role == "Setter" || wf.Role == "Tool store incharge" || wf.Role == "PPC incharge" || wf.Role == "Maintainance")
        //                                        select new
        //                                        {
        //                                            contactNo = wf.ContactNo,
        //                                            smsPriority = wf.SmsPriority,
        //                                            cellId = wf.CellId,
        //                                            subCellId = wf.SubCellId,
        //                                            employeeName = wf.EmployeeName,
        //                                            categoryId = wf.CategoryId,
        //                                            timeToBeTriggered = wf.TimeToBeTriggered,
        //                                            opNo = wf.OpNo
        //                                        }).ToList();

        //                    foreach (var i in maintainance)
        //                    {
        //                        var dbCheck = db.UnitworkccsTblsmsdetails.Where(m => m.Shift == shift && m.CellId == i.cellId && m.SubCellId == i.subCellId && m.SmsPriority == i.smsPriority && m.OpNo == i.opNo && m.CorrectedDate == correctedDate && m.TimeToBeTriggered == i.timeToBeTriggered && m.CategoryId == i.categoryId && m.TicketId == item.ticketId).FirstOrDefault();
        //                        if (dbCheck == null)
        //                        {
        //                            DateTime tktOpDate = Convert.ToDateTime(item.ticketOpenDate);
        //                            string ticketOpenDatTime = tktOpDate.ToString("HH:mm");
        //                            string ticketOpenName = "BD Alert!!\n" + machineInvNo + "," + ticketOpenDatTime + ",\n" + "Ticket Status" + "-" + "Open\n" + "Status" + " " + "-" + statusName + "-" + "BDR\n" + "Reason" + " " + "-" + reasonName + "\n" + "I-FACILITY";
        //                            //var contactNo = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == data.operatorId).Select(m => m.ContactNo).FirstOrDefault();
        //                            string sendSms = commonFunction.SMSEscalationSendPostURLEncode("12", i.contactNo, ticketOpenName, appSettings.SmsKey, appSettings.SmsDetailsPost);

        //                            UnitworkccsTblsmsdetails UnitworkccsTblsmsdetails = new UnitworkccsTblsmsdetails();
        //                            UnitworkccsTblsmsdetails.ContactNo = i.contactNo;
        //                            UnitworkccsTblsmsdetails.MachineId = item.machineId;
        //                            UnitworkccsTblsmsdetails.TicketId = item.ticketId;
        //                            UnitworkccsTblsmsdetails.CellId = i.cellId;
        //                            UnitworkccsTblsmsdetails.SubCellId = i.subCellId;
        //                            UnitworkccsTblsmsdetails.SmsPriority = i.smsPriority;
        //                            UnitworkccsTblsmsdetails.OpNo = i.opNo;
        //                            UnitworkccsTblsmsdetails.EmployeeName = i.employeeName;
        //                            UnitworkccsTblsmsdetails.Shift = shift;
        //                            UnitworkccsTblsmsdetails.IsDeleted = 0;
        //                            UnitworkccsTblsmsdetails.ResponseId = sendSms;
        //                            UnitworkccsTblsmsdetails.CategoryId = i.categoryId;
        //                            UnitworkccsTblsmsdetails.Message = ticketOpenName;
        //                            UnitworkccsTblsmsdetails.TimeToBeTriggered = i.timeToBeTriggered;
        //                            UnitworkccsTblsmsdetails.CreatedOn = DateTime.Now;
        //                            UnitworkccsTblsmsdetails.CorrectedDate = correctedDate;
        //                            db.UnitworkccsTblsmsdetails.Add(UnitworkccsTblsmsdetails);
        //                            db.SaveChanges();
        //                            flag = true;
        //                        }
        //                    }
        //                }
        //                else if (diffInSeconds > 1800 && diffInSeconds < 1860)
        //                {
        //                    var currentFgpart = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == item.machineId).OrderByDescending(m => m.FgPartId).Select(m => m.PlanLinkageId).FirstOrDefault();

        //                    var partNo = db.UnitworkccsTblplanlinkagemaster.Where(m => m.PlanLinkageId == currentFgpart).Select(m => m.FgPartNo).FirstOrDefault();

        //                    var cellId = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.CellFinalId).FirstOrDefault();

        //                    var subCellId = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.SubCellFinalId).FirstOrDefault();

        //                    var maintainance = (from wf in db.TblEscalationMatrix
        //                                        where wf.Shift == shift && (wf.CellId == cellId || wf.CellId == 0) && (wf.SubCellId == subCellId || wf.SubCellId == 0) && wf.CategoryId == item.categoryId && (wf.TimeToBeTriggered == 30) && (wf.SmsPriority == 1 || wf.SmsPriority == 2 || wf.SmsPriority == 3) && wf.IsDeleted == 0 && (wf.Role == "Quality head" || wf.Role == "Quality incharge" || wf.Role == "cell incharge" || wf.Role == "Line inspectors" || wf.Role == "Production incharge" || wf.Role == "Tooling incharge" || wf.Role == "HR" || wf.Role == "PPC head" || wf.Role == "Maintainance incharge" || wf.Role == "Maintainance head" || wf.Role == "Quality head" || wf.Role == "supervisor" || wf.Role == "Toolstores" || wf.Role == "Setter" || wf.Role == "Tool store incharge" || wf.Role == "PPC incharge" || wf.Role == "Maintainance" || wf.Role == "Plant head" || wf.Role == "Cell head")
        //                                        select new
        //                                        {
        //                                            contactNo = wf.ContactNo,
        //                                            smsPriority = wf.SmsPriority,
        //                                            cellId = wf.CellId,
        //                                            subCellId = wf.SubCellId,
        //                                            employeeName = wf.EmployeeName,
        //                                            categoryId = wf.CategoryId,
        //                                            timeToBeTriggered = wf.TimeToBeTriggered,
        //                                            opNo = wf.OpNo
        //                                        }).ToList();

        //                    foreach (var i in maintainance)
        //                    {
        //                        var dbCheck = db.UnitworkccsTblsmsdetails.Where(m => m.Shift == shift && m.CellId == i.cellId && m.SubCellId == i.subCellId && m.SmsPriority == i.smsPriority && m.OpNo == i.opNo && m.CorrectedDate == correctedDate && m.TimeToBeTriggered == i.timeToBeTriggered && m.CategoryId == i.categoryId && m.TicketId == item.ticketId).FirstOrDefault();

        //                        if (dbCheck == null)
        //                        {
        //                            DateTime tktOpDate = Convert.ToDateTime(item.ticketOpenDate);
        //                            string ticketOpenDatTime = tktOpDate.ToString("HH:mm");
        //                            string ticketOpenName = "BD Alert!!\n" + machineInvNo + "," + ticketOpenDatTime + ",\n" + "Ticket Status" + "-" + "Open\n" + "Status" + " " + "-" + statusName + "-" + "BDR\n" + "Reason" + " " + "-" + reasonName + "\n" + "I-FACILITY";
        //                            //var contactNo = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == data.operatorId).Select(m => m.ContactNo).FirstOrDefault();
        //                            string sendSms = commonFunction.SMSEscalationSendPostURLEncode("12", i.contactNo, ticketOpenName, appSettings.SmsKey, appSettings.SmsDetailsPost);

        //                            UnitworkccsTblsmsdetails UnitworkccsTblsmsdetails = new UnitworkccsTblsmsdetails();
        //                            UnitworkccsTblsmsdetails.ContactNo = i.contactNo;
        //                            UnitworkccsTblsmsdetails.MachineId = item.machineId;
        //                            UnitworkccsTblsmsdetails.TicketId = item.ticketId;
        //                            UnitworkccsTblsmsdetails.CellId = i.cellId;
        //                            UnitworkccsTblsmsdetails.SubCellId = i.subCellId;
        //                            UnitworkccsTblsmsdetails.SmsPriority = i.smsPriority;
        //                            UnitworkccsTblsmsdetails.OpNo = i.opNo;
        //                            UnitworkccsTblsmsdetails.EmployeeName = i.employeeName;
        //                            UnitworkccsTblsmsdetails.Shift = shift;
        //                            UnitworkccsTblsmsdetails.IsDeleted = 0;
        //                            UnitworkccsTblsmsdetails.CategoryId = i.categoryId;
        //                            UnitworkccsTblsmsdetails.ResponseId = sendSms;
        //                            UnitworkccsTblsmsdetails.Message = ticketOpenName;
        //                            UnitworkccsTblsmsdetails.TimeToBeTriggered = i.timeToBeTriggered;
        //                            UnitworkccsTblsmsdetails.CreatedOn = DateTime.Now;
        //                            UnitworkccsTblsmsdetails.CorrectedDate = correctedDate;
        //                            db.UnitworkccsTblsmsdetails.Add(UnitworkccsTblsmsdetails);
        //                            db.SaveChanges();
        //                            flag = true;
        //                        }
        //                    }
        //                }
        //                else if (diffInSeconds > 3600 && diffInSeconds < 3660)
        //                {
        //                    var currentFgpart = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == item.machineId).OrderByDescending(m => m.FgPartId).Select(m => m.PlanLinkageId).FirstOrDefault();

        //                    var partNo = db.UnitworkccsTblplanlinkagemaster.Where(m => m.PlanLinkageId == currentFgpart).Select(m => m.FgPartNo).FirstOrDefault();

        //                    var cellId = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.CellFinalId).FirstOrDefault();

        //                    var subCellId = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.SubCellFinalId).FirstOrDefault();

        //                    var maintainance = (from wf in db.TblEscalationMatrix
        //                                        where wf.Shift == shift && (wf.CellId == cellId || wf.CellId == 0) && (wf.SubCellId == subCellId || wf.SubCellId == 0) && wf.CategoryId == item.categoryId && wf.TimeToBeTriggered == 60 && (wf.Role == "Quality head" || wf.Role == "Quality incharge" || wf.Role == "cell incharge" || wf.Role == "Line inspectors" || wf.Role == "Production incharge" || wf.Role == "Tooling incharge" || wf.Role == "HR" || wf.Role == "PPC head" || wf.Role == "Maintainance incharge" || wf.Role == "Maintainance head" || wf.Role == "Quality head" || wf.Role == "supervisor" || wf.Role == "Toolstores" || wf.Role == "Setter" || wf.Role == "Tool store incharge" || wf.Role == "PPC incharge" || wf.Role == "Maintainance" || wf.Role == "Plant head" || wf.Role == "Cell head" || wf.Role == "COO") && (wf.SmsPriority == 1 || wf.SmsPriority == 2 || wf.SmsPriority == 3 || wf.SmsPriority == 4)
        //                                        select new
        //                                        {
        //                                            contactNo = wf.ContactNo,
        //                                            smsPriority = wf.SmsPriority,
        //                                            cellId = wf.CellId,
        //                                            subCellId = wf.SubCellId,
        //                                            employeeName = wf.EmployeeName,
        //                                            categoryId = wf.CategoryId,
        //                                            timeToBeTriggered = wf.TimeToBeTriggered,
        //                                            opNo = wf.OpNo
        //                                        }).ToList();

        //                    foreach (var i in maintainance)
        //                    {
        //                        var dbCheck = db.UnitworkccsTblsmsdetails.Where(m => m.Shift == shift && m.CellId == i.cellId && m.SubCellId == i.subCellId && m.SmsPriority == i.smsPriority && m.OpNo == i.opNo && m.CorrectedDate == correctedDate && m.TimeToBeTriggered == i.timeToBeTriggered && m.CategoryId == i.categoryId && m.TicketId == item.ticketId).FirstOrDefault();

        //                        if (dbCheck == null)
        //                        {
        //                            DateTime tktOpDate = Convert.ToDateTime(item.ticketOpenDate);
        //                            string ticketOpenDatTime = tktOpDate.ToString("HH:mm");
        //                            string ticketOpenName = "BD Alert!!\n" + machineInvNo + "," + ticketOpenDatTime + ",\n" + "Ticket Status" + "-" + "Open\n" + "Status" + " " + "-" + statusName + "-" + "BDR\n" + "Reason" + " " + "-" + reasonName + "\n" + "I-FACILITY";
        //                            //var contactNo = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == data.operatorId).Select(m => m.ContactNo).FirstOrDefault();
        //                            string sendSms = commonFunction.SMSEscalationSendPostURLEncode("12", i.contactNo, ticketOpenName, appSettings.SmsKey, appSettings.SmsDetailsPost);

        //                            UnitworkccsTblsmsdetails UnitworkccsTblsmsdetails = new UnitworkccsTblsmsdetails();
        //                            UnitworkccsTblsmsdetails.ContactNo = i.contactNo;
        //                            UnitworkccsTblsmsdetails.MachineId = item.machineId;
        //                            UnitworkccsTblsmsdetails.TicketId = item.ticketId;
        //                            UnitworkccsTblsmsdetails.CellId = i.cellId;
        //                            UnitworkccsTblsmsdetails.SubCellId = i.subCellId;
        //                            UnitworkccsTblsmsdetails.SmsPriority = i.smsPriority;
        //                            UnitworkccsTblsmsdetails.OpNo = i.opNo;
        //                            UnitworkccsTblsmsdetails.EmployeeName = i.employeeName;
        //                            UnitworkccsTblsmsdetails.Shift = shift;
        //                            UnitworkccsTblsmsdetails.IsDeleted = 0;
        //                            UnitworkccsTblsmsdetails.CategoryId = i.categoryId;
        //                            UnitworkccsTblsmsdetails.ResponseId = sendSms;
        //                            UnitworkccsTblsmsdetails.Message = ticketOpenName;
        //                            UnitworkccsTblsmsdetails.TimeToBeTriggered = i.timeToBeTriggered;
        //                            UnitworkccsTblsmsdetails.CreatedOn = DateTime.Now;
        //                            UnitworkccsTblsmsdetails.CorrectedDate = correctedDate;
        //                            db.UnitworkccsTblsmsdetails.Add(UnitworkccsTblsmsdetails);
        //                            db.SaveChanges();
        //                            flag = true;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        commonFunction.LogFile(e.ToString());
        //    }
        //    return flag;
        //}
    }
}
