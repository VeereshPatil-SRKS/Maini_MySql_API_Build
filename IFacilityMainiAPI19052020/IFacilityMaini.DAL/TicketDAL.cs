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
using static IFacilityMaini.EntityModels.TicketEntity;

namespace IFacilityMaini.DAL
{
    public class TicketDAL : ITicket
    {
        unitworksccsContext db = new unitworksccsContext();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(TicketDAL));
        public static IConfiguration configuration;
        private readonly AppSettings appSettings;

        public TicketDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings)
        {
            db = _db;
            configuration = _configuration;
            appSettings = _appSettings.Value;
        }

        /// <summary>
        /// View Multiple Category
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleCategory()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblCategoryMaster
                             where wf.IsDeleted == 0
                             select new
                             {
                                 CategoryId = wf.CategoryId,
                                 CategoryName = wf.CategoryName,
                                 CategoryDesc = wf.CategoryDesc
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
            catch (Exception ex)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// View Multiple Class
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleClass()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblClassMaster
                             where wf.IsDeleted == 0
                             select new
                             {
                                 ClassId = wf.ClassId,
                                 ClassName = wf.ClassName,
                                 ClassDesc = wf.ClassDesc
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
            catch (Exception ex)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// View Multiple Status
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleStatus()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblStatusMaster
                             where wf.IsDeleted == 0
                             select new
                             {
                                 StatusId = wf.StatusId,
                                 StatusName = wf.StatusName,
                                 StatusDesc = wf.StatusDesc
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
            catch (Exception ex)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// View Multiple Reasons
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleReasons(int CategoryId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblStoppage
                             where wf.IsDeleted == 0 && wf.CategoryId == CategoryId
                             select new
                             {
                                 TktReasonId = wf.StoppagesId,
                                 ReasonName = wf.AlramDesc,
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
            catch (Exception ex)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Add Update Ticket
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponseWithIds AddUpdateTicket(AddUpdateTicket data)
        {
            CommonResponseWithIds obj = new CommonResponseWithIds();
            CommonFunction commonFunction = new CommonFunction();
            try
            {
                string ticketName = "";
                string shift = commonFunction.GetCurrentShift();
                int ShiftID = commonFunction.ShiftDet();
                string correctedDate = commonFunction.GetCorrectedDate();

                #region TicketNameFormation
                var className = db.TblClassMaster.Where(m => m.ClassId == data.classId).Select(m => m.ClassName).FirstOrDefault();
                var statusName = db.TblStatusMaster.Where(m => m.StatusId == data.statusId).Select(m => m.StatusName).FirstOrDefault();
                var machineInvNo = db.Tblmachinedetails.Where(m => m.MachineId == data.machineId).Select(m => m.MachineName).FirstOrDefault();
                var reasonName = db.TblStoppage.Where(m => m.StoppagesId == data.reasonId).Select(m => m.AlramDesc).FirstOrDefault();

                var date = DateTime.Now.ToString("ddMMyyyy");

                if (statusName == "Running with Issue" && className == "Downtime")
                {
                    ticketName = className + "-" + statusName + "-" + "BDR" + "-" + machineInvNo + "-" + date;
                }
                else if (statusName == "Stopped" && className == "Downtime")
                {
                    ticketName = className + "-" + statusName + "-" + "BDS" + "-" + machineInvNo + "-" + date;
                }
                else if (className == "Improvement")
                {
                    ticketName = className + "-" + "IMP" + "-" + machineInvNo + "-" + date;
                }
                #endregion

                var roleId = db.TblOperatorDetails.Where(m => m.OpId == data.operatorId).Select(m => m.RoleId).FirstOrDefault();
                var check = db.TblRaisedTicket.Where(m => m.TicketId == data.ticketId && roleId == 6).FirstOrDefault();

                var loginTrackerDetails = commonFunction.GetLoginTrackerDetails(correctedDate, data.machineId, data.operatorId);

                if (loginTrackerDetails != null)
                {
                    #region Add and Update Ticket Raised for partcular machine
                    if (check == null)
                    {
                        TblRaisedTicket tblRaisedTicket = new TblRaisedTicket();
                        tblRaisedTicket.MachineId = data.machineId;
                        tblRaisedTicket.OperatorId = data.operatorId;
                        tblRaisedTicket.RoleId = roleId;
                        tblRaisedTicket.TicketNo = ticketName;
                        tblRaisedTicket.StatusId = data.statusId;
                        tblRaisedTicket.TicketOpenDate = DateTime.Now;
                        tblRaisedTicket.CreatedOn = DateTime.Now;
                        tblRaisedTicket.ClassId = data.classId;
                        tblRaisedTicket.CategoryId = data.categoryId;
                        tblRaisedTicket.IsDeleted = 0;
                        tblRaisedTicket.ReasonId = data.reasonId;
                        tblRaisedTicket.Comments = data.comments;
                        tblRaisedTicket.CorrectedDate = correctedDate;
                        tblRaisedTicket.Status = 1; //Ticket Raised
                        tblRaisedTicket.AlarmId = data.alarmId;
                        db.TblRaisedTicket.Add(tblRaisedTicket);
                        db.SaveChanges();
                        obj.id = tblRaisedTicket.TicketId;
                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;

                        TblTicketRaisedDet tblTicketRaisedDet = new TblTicketRaisedDet();
                        tblTicketRaisedDet.TicketId = tblRaisedTicket.TicketId;
                        tblTicketRaisedDet.OperatorId = tblRaisedTicket.OperatorId;
                        tblTicketRaisedDet.IsDeleted = 0;
                        tblTicketRaisedDet.IsStatus = 1;
                        tblTicketRaisedDet.TicketNo = tblRaisedTicket.TicketNo;
                        tblTicketRaisedDet.CreatedOn = DateTime.Now;
                        db.TblTicketRaisedDet.Add(tblTicketRaisedDet);
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;

                        #region Update last row of logged in user details 
                        loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId + "," + tblRaisedTicket.TicketId + ",";
                        loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimEnd(',');
                        loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimStart(',');
                        db.LoginTrackerDetails.Update(loginTrackerDetails);
                        db.SaveChanges();

                        #endregion

                        #region sms integration

                        var currentFgpart = db.TblFgPartNoDet.Where(m => m.MachineId == data.machineId).OrderByDescending(m => m.FgPartId).Select(m => m.PlanLinkageId).FirstOrDefault();

                        var partNo = db.TblPlanLinkageMaster.Where(m => m.PlanLinkageId == currentFgpart).Select(m => m.FgPartNo).FirstOrDefault();

                        var cellId = db.TblFgAndCellAllocation.Where(m => m.PartNo == partNo).Select(m => m.CellFinalId).FirstOrDefault();

                        var subCellId = db.TblFgAndCellAllocation.Where(m => m.PartNo == partNo).Select(m => m.SubCellFinalId).FirstOrDefault();

                        var maintainance = db.TblOperatorDetails.Where(m => m.Shift == shift && m.CellId == cellId && (m.CategoryId == 1 || m.CategoryId == 2) && m.RoleId == 9).Select(m => m.ContactNo).ToList();

                        foreach (var item in maintainance)
                        {
                            DateTime tktOpDate = Convert.ToDateTime(tblRaisedTicket.TicketOpenDate);
                            string ticketOpenDatTime = tktOpDate.ToString("HH:mm");
                            string ticketOpenName = "BD Alert!!\n" + machineInvNo + "," + ticketOpenDatTime + ",\n" + "Ticket Status" + "-" + "Open\n" + "Status" + " " + "-" + statusName + "-" + "BDR\n" + "Reason" + " " + "-" + reasonName + "\n" + "I-FACILITY";
                            //var contactNo = db.TblOperatorDetails.Where(m => m.OpId == data.operatorId).Select(m => m.ContactNo).FirstOrDefault();
                            string sendSms = commonFunction.SMSEscalationSendPostURLEncode("12", item, ticketOpenName, appSettings.SmsKey, appSettings.SmsDetailsPost);

                            if (sendSms != null)
                            {
                                TblSmsDetails tblSmsDetails = new TblSmsDetails();
                                tblSmsDetails.ContactNo = item;
                                tblSmsDetails.MachineId = data.machineId;
                                tblSmsDetails.TicketId = tblRaisedTicket.TicketId;
                                tblSmsDetails.IsDeleted = 0;
                                tblSmsDetails.ResponseId = sendSms;
                                tblSmsDetails.Message = ticketOpenName;
                                tblSmsDetails.CreatedOn = DateTime.Now;
                                tblSmsDetails.CorrectedDate = correctedDate;
                                db.TblSmsDetails.Add(tblSmsDetails);
                                db.SaveChanges();
                            }
                        }

                        var dbCheck = db.TblOperatorDetails.Where(m => m.RoleId == 9 && m.CellId == 0 && (m.CategoryId == 1 || m.CategoryId == 2) && m.Shift == shift).Select(m => m.ContactNo).ToList();

                        foreach (var item in dbCheck)
                        {
                            DateTime tktOpDate = Convert.ToDateTime(tblRaisedTicket.TicketOpenDate);
                            string ticketOpenDatTime = tktOpDate.ToString("HH:mm");
                            string ticketOpenName = "BD Alert!!\n" + machineInvNo + "," + ticketOpenDatTime + ",\n" + "Ticket Status" + "-" + "Open\n" + "Status" + " " + "-" + statusName + "-" + "BDR\n" + "Reason" + " " + "-" + reasonName + "\n" + "I-FACILITY";
                            //var contactNo = db.TblOperatorDetails.Where(m => m.OpId == data.operatorId).Select(m => m.ContactNo).FirstOrDefault();
                            string sendSms = commonFunction.SMSEscalationSendPostURLEncode("12", item, ticketOpenName, appSettings.SmsKey, appSettings.SmsDetailsPost);

                            if (sendSms != null)
                            {
                                TblSmsDetails tblSmsDetails = new TblSmsDetails();
                                tblSmsDetails.ContactNo = item;
                                tblSmsDetails.MachineId = data.machineId;
                                tblSmsDetails.TicketId = tblRaisedTicket.TicketId;
                                tblSmsDetails.IsDeleted = 0;
                                tblSmsDetails.ResponseId = sendSms;
                                tblSmsDetails.Message = ticketOpenName;
                                tblSmsDetails.CorrectedDate = correctedDate;
                                tblSmsDetails.CreatedOn = DateTime.Now;
                                db.TblSmsDetails.Add(tblSmsDetails);
                                db.SaveChanges();
                            }
                        }

                        var dbCheck1 = db.TblOperatorDetails.Where(m => m.RoleId == 18 && m.CellId == 0 && m.Shift == shift).Select(m => m.ContactNo).ToList();

                        foreach (var item in dbCheck1)
                        {
                            DateTime tktOpDate = Convert.ToDateTime(tblRaisedTicket.TicketOpenDate);
                            string ticketOpenDatTime = tktOpDate.ToString("HH:mm");
                            string ticketOpenName = "BD Alert!!\n" + machineInvNo + "," + ticketOpenDatTime + ",\n" + "Ticket Status" + "-" + "Open\n" + "Status" + " " + "-" + statusName + "-" + "BDR\n" + "Reason" + " " + "-" + reasonName + "\n" + "I-FACILITY";
                            //var contactNo = db.TblOperatorDetails.Where(m => m.OpId == data.operatorId).Select(m => m.ContactNo).FirstOrDefault();
                            string sendSms = commonFunction.SMSEscalationSendPostURLEncode("12", item, ticketOpenName, appSettings.SmsKey, appSettings.SmsDetailsPost);

                            if (sendSms != null)
                            {
                                TblSmsDetails tblSmsDetails = new TblSmsDetails();
                                tblSmsDetails.ContactNo = item;
                                tblSmsDetails.MachineId = data.machineId;
                                tblSmsDetails.TicketId = tblRaisedTicket.TicketId;
                                tblSmsDetails.IsDeleted = 0;
                                tblSmsDetails.ResponseId = sendSms;
                                tblSmsDetails.Message = ticketOpenName;
                                tblSmsDetails.CorrectedDate = correctedDate;
                                tblSmsDetails.CreatedOn = DateTime.Now;
                                db.TblSmsDetails.Add(tblSmsDetails);
                                db.SaveChanges();
                            }
                        }

                        #endregion

                        #region End mode in livemodeDb and insert new row with mode breakDown

                        var ModeDet = db.Tbllivemode.Where(m => m.IsCompleted == 0 && m.MachineId == data.machineId).OrderByDescending(m => m.ModeId).FirstOrDefault();

                        if (ModeDet != null)
                        {
                            DateTime ET = DateTime.Now;
                            DateTime St = Convert.ToDateTime(ModeDet.StartTime);
                            double Duration = ET.Subtract(St).TotalSeconds;
                            ModeDet.IsCompleted = 1;
                            ModeDet.EndTime = ET;
                            ModeDet.ModeTypeEnd = 1;
                            ModeDet.DurationInSec = Convert.ToInt32(Duration);
                            db.SaveChanges();

                            int BreakDownID = Convert.ToInt32(db.TblBreakDownTickect.Where(m => m.IsDeleted == 0 && m.MachineId == data.machineId && m.ProdFinished == null).OrderByDescending(m => m.Id).Select(m => m.ReasonId).FirstOrDefault());

                            Tbllivemode tbllivemode = new Tbllivemode();
                            tbllivemode.MachineId = data.machineId;
                            tbllivemode.MacMode = "MNT";
                            tbllivemode.InsertedOn = ET;
                            tbllivemode.InsertedBy = 1;
                            tbllivemode.CorrectedDate = ET.Date;
                            tbllivemode.IsDeleted = 0;
                            tbllivemode.StartTime = ET;
                            tbllivemode.ColorCode = "RED";
                            tbllivemode.BreakDownCodeId = BreakDownID;
                            tbllivemode.IsCompleted = 0;
                            tbllivemode.ModeType = "MNT";
                            tbllivemode.ModeTypeEnd = 0;
                            tbllivemode.IsShiftEnd = ShiftID;
                            db.Tbllivemode.Add(tbllivemode);
                            db.SaveChanges();
                        }

                        #endregion
                    }
                    else
                    {
                        check.MachineId = data.machineId;
                        check.OperatorId = data.operatorId;
                        check.StatusId = data.statusId;
                        check.CorrectedDate = correctedDate;
                        check.TicketOpenDate = DateTime.Now;
                        check.CreatedOn = DateTime.Now;
                        check.ClassId = data.classId;
                        check.CategoryId = data.categoryId;
                        check.IsDeleted = 0;
                        check.ReasonId = data.reasonId;
                        check.Comments = data.comments;
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.UpdatedSuccessMessage;

                        //#region Update last row of logged in user details 
                        //loginTrackerDetails.CurrentTicketRaisedId = check.TicketId;
                        //db.LoginTrackerDetails.Update(loginTrackerDetails);
                        //db.SaveChanges();
                        //#endregion
                    }
                    #endregion


                }
                else
                {
                    obj.isStatus = false;
                    obj.response = ResourceResponse.LoginAgain;
                }

            }
            catch (Exception ex)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            commonFunction.LogFile(obj.response);
            return obj;
        }

        /// <summary>
        /// View Issued Tickets
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewIssuedTickets(int supportTeamId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var roleId = db.TblOperatorDetails.Where(m => m.OpId == supportTeamId).Select(m => m.RoleId).FirstOrDefault();
                var check = (from wf in db.TblRaisedTicket
                             where wf.IsDeleted == 0 && roleId == 9
                             select new
                             {
                                 TicketId = wf.TicketId,
                                 ClassName = db.TblClassMaster.Where(m => m.ClassId == wf.ClassId).Select(m => m.ClassName).FirstOrDefault(),
                                 ClassId = wf.ClassId,
                                 StatusName = db.TblStatusMaster.Where(m => m.StatusId == wf.StatusId).Select(m => m.StatusName).FirstOrDefault(),
                                 StatusId = wf.StatusId,
                                 ReasonId = wf.ReasonId,
                                 ReasonName = db.TblTicketReason.Where(m => m.TktReasonId == wf.ReasonId).Select(m => m.ReasonName).FirstOrDefault(),
                                 CategoryName = db.TblCategoryMaster.Where(m => m.CategoryId == wf.CategoryId).Select(m => m.CategoryName).FirstOrDefault(),
                                 CategoryId = wf.CategoryId,
                                 TicketNo = wf.TicketNo,
                                 TicketOpenDate = wf.TicketOpenDate,
                                 OperatorId = wf.OperatorId,
                                 status = wf.Status,
                                 machineId = wf.MachineId
                             }).ToList();

                if (check.Count > 0)
                {
                    List<StatusOfTicket> statusOfTicketsList = new List<StatusOfTicket>();
                    foreach (var item in check)
                    {
                        StatusOfTicket statusOfTicket = new StatusOfTicket();
                        statusOfTicket.categoryId = Convert.ToInt32(item.CategoryId);
                        statusOfTicket.categoryName = item.CategoryName;
                        statusOfTicket.classId = Convert.ToInt32(item.ClassId);
                        statusOfTicket.className = item.ClassName;
                        statusOfTicket.statusId = Convert.ToInt32(item.StatusId);
                        statusOfTicket.statusName = item.StatusName;
                        statusOfTicket.reasonId = Convert.ToInt32(item.ReasonId);
                        statusOfTicket.reasonName = item.ReasonName;
                        statusOfTicket.categoryId = Convert.ToInt32(item.CategoryId);
                        statusOfTicket.categoryName = item.CategoryName;
                        statusOfTicket.ticketNo = item.TicketNo;
                        statusOfTicket.machineId = Convert.ToInt32(item.machineId);
                        DateTime tktOpenDate = Convert.ToDateTime(item.TicketOpenDate);
                        statusOfTicket.ticketOpenDate = tktOpenDate.ToString("dd-MM-yyyy");
                        if (item.status == 1)
                        {
                            statusOfTicket.ticketStatus = "Open";
                        }
                        else if (item.status == 2)
                        {
                            statusOfTicket.ticketStatus = "In Process";
                        }
                        else if (item.status == 3)
                        {
                            statusOfTicket.ticketStatus = "Close";
                        }
                        else if (item.status == 4)
                        {
                            statusOfTicket.ticketStatus = "Operator Accept";
                        }
                        else if (item.status == 5)
                        {
                            statusOfTicket.ticketStatus = "Reopen";
                        }
                        statusOfTicketsList.Add(statusOfTicket);
                    }
                    obj.isStatus = true;
                    obj.response = statusOfTicketsList;
                }
            }
            catch (Exception ex)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Support Team Accept Acknowledge
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse SupportTeamAcceptAck(ApproveOrRejectBySupportTeam data)
        {
            CommonResponse obj = new CommonResponse();
            CommonFunction commonFunction = new CommonFunction();
            try
            {
                var roleId = db.TblOperatorDetails.Where(m => m.OpId == data.supportTeamId).Select(m => m.RoleId).FirstOrDefault();
                var check = db.TblTicketRaisedDet.Where(m => m.TicketId == data.ticketId && roleId == 9 && (m.IsStatus == 1 || m.IsStatus == 6)).FirstOrDefault();

                if (check != null)
                {
                    check.TicketId = data.ticketId;
                    check.SupportTeamId = data.supportTeamId;
                    //check.TicketNo = db.TblRaisedTicket.Where(m => m.TicketId == data.ticketId).Sele(m=>m.TicketNo).FirstOrDefau();
                    check.IsStatus = 2;
                    check.SupportTeamAckDate = DateTime.Now;
                    check.IfSupportTeamOpen = 1;
                    check.MntAcceptReason = data.reason;
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.UpdatedSuccessMessage;

                    var dbCheck = db.TblRaisedTicket.Where(m => m.TicketId == data.ticketId).FirstOrDefault();
                    if (dbCheck != null)
                    {
                        dbCheck.Status = 2;
                        db.SaveChanges();
                    }

                    //#region sms integration

                    //var className = db.TblClassMaster.Where(m => m.ClassId == dbCheck.ClassId).Select(m => m.ClassName).FirstOrDefault();
                    //var statusName = db.TblStatusMaster.Where(m => m.StatusId == dbCheck.StatusId).Select(m => m.StatusName).FirstOrDefault();
                    //var machineInvNo = db.Tblmachinedetails.Where(m => m.MachineId == data.machineId).Select(m => m.MachineName).FirstOrDefault();

                    //DateTime tktAcceptedDate = Convert.ToDateTime(check.SupportTeamAckDate);
                    //string ticketAcceptedDateTime = tktAcceptedDate.ToString("yyyy-MM-dd HH:mm:ss");
                    //string ticketOpenName = "BD Alert!!\n" + machineInvNo + "," + ticketAcceptedDateTime + ",\n" + "Ticket Status:" + "-" + "Accepted by Maintainance Team\n" + "Reason" + "-" + statusName + "-" + "BDR\n" + "I-FACILITY";

                    //var contactNo = db.TblOperatorDetails.Where(m => m.OpId == data.supportTeamId).Select(m => m.ContactNo).FirstOrDefault();
                    //string sendSms = commonFunction.SMSEscalationSendPostURLEncode("12", contactNo, ticketOpenName, appSettings.SmsKey, appSettings.SmsDetailsPost);

                    //#endregion
                }
            }
            catch (Exception)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Support Team Reject Acknowledge
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse SupportTeamCloseAck(ApproveOrRejectBySupportTeam data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                CommonFunction commonFunction = new CommonFunction();
                string shift = commonFunction.GetCurrentShift();
                string correctedDate = commonFunction.GetCorrectedDate();
                int ShiftID = commonFunction.ShiftDet();

                var roleId = db.TblOperatorDetails.Where(m => m.OpId == data.supportTeamId).Select(m => m.RoleId).FirstOrDefault();

                var check = db.TblTicketRaisedDet.Where(m => m.TicketId == data.ticketId && roleId == 9 && m.IsStatus == 2 && m.IfSupportTeamOpen == 1).FirstOrDefault();

                if (check != null)
                {
                    check.MntRejectReason = data.reason;
                    check.SupportTeamId = data.supportTeamId;
                    check.SupportTeamClosureDate = DateTime.Now;
                    check.IsStatus = 3;
                    check.IfSupportTeamOpen = 2;
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.UpdatedSuccessMessage;

                    var ModeDet = db.Tbllivemode.Where(m => m.IsCompleted == 0 && m.MachineId == data.machineId).OrderByDescending(m => m.ModeId).FirstOrDefault();

                    if (ModeDet != null)
                    {
                        DateTime ET = DateTime.Now;
                        DateTime St = Convert.ToDateTime(ModeDet.StartTime);
                        double Duration = ET.Subtract(St).TotalSeconds;
                        ModeDet.IsCompleted = 1;
                        ModeDet.EndTime = ET;
                        ModeDet.ModeTypeEnd = 1;
                        ModeDet.DurationInSec = Convert.ToInt32(Duration);
                        db.SaveChanges();

                        try
                        {
                            Tbllivemode tbllivemode = new Tbllivemode();
                            tbllivemode.MachineId = data.machineId;
                            tbllivemode.MacMode = "IDLE";
                            tbllivemode.InsertedOn = ET;
                            tbllivemode.InsertedBy = 1;
                            tbllivemode.CorrectedDate = ET.Date;
                            tbllivemode.IsDeleted = 0;
                            tbllivemode.StartTime = ET;
                            tbllivemode.ColorCode = "YELLOW";
                            tbllivemode.IsCompleted = 0;
                            tbllivemode.ModeType = "IDLE";
                            tbllivemode.IsShiftEnd = ShiftID;
                            db.Tbllivemode.Add(tbllivemode);
                            db.SaveChanges();
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }

                var dbCheck = db.TblRaisedTicket.Where(m => m.TicketId == data.ticketId).FirstOrDefault();
                if (dbCheck != null)
                {
                    dbCheck.Status = 3;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// View Tickets To Operator
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewTicketsToOperator(int operatorId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var roleId = db.TblOperatorDetails.Where(m => m.OpId == operatorId).Select(m => m.RoleId).FirstOrDefault();
                var check = (from wf in db.TblRaisedTicket
                             where wf.Status == 3 && wf.IsDeleted == 0 && roleId == 6
                             select new
                             {
                                 TicketId = wf.TicketId,
                                 ClassName = db.TblClassMaster.Where(m => m.ClassId == wf.ClassId).Select(m => m.ClassName).FirstOrDefault(),
                                 ClassId = wf.ClassId,
                                 StatusName = db.TblStatusMaster.Where(m => m.StatusId == wf.StatusId).Select(m => m.StatusName).FirstOrDefault(),
                                 StatusId = wf.StatusId,
                                 ReasonId = wf.ReasonId,
                                 ReasonName = db.TblTicketReason.Where(m => m.TktReasonId == wf.ReasonId).Select(m => m.ReasonName).FirstOrDefault(),
                                 CategoryName = db.TblCategoryMaster.Where(m => m.CategoryId == wf.CategoryId).Select(m => m.CategoryName).FirstOrDefault(),
                                 CategoryId = wf.CategoryId,
                                 TicketNo = wf.TicketNo,
                                 wf.TicketOpenDate,
                                 OperatorId = wf.OperatorId,
                                 machineId = wf.MachineId
                             }).ToList();
                if (check.Count > 0)
                {
                    List<StatusOfTicket> statusOfTicketsList = new List<StatusOfTicket>();
                    foreach (var item in check)
                    {
                        StatusOfTicket statusOfTicket = new StatusOfTicket();
                        statusOfTicket.ticketId = item.TicketId;
                        statusOfTicket.categoryId = Convert.ToInt32(item.CategoryId);
                        statusOfTicket.categoryName = item.CategoryName;
                        statusOfTicket.classId = Convert.ToInt32(item.ClassId);
                        statusOfTicket.className = item.ClassName;
                        statusOfTicket.reasonId = Convert.ToInt32(item.ReasonId);
                        statusOfTicket.reasonName = item.ReasonName;
                        statusOfTicket.statusId = Convert.ToInt32(item.StatusId);
                        statusOfTicket.statusName = item.StatusName;
                        statusOfTicket.categoryId = Convert.ToInt32(item.CategoryId);
                        statusOfTicket.categoryName = item.CategoryName;
                        statusOfTicket.operatorId = Convert.ToInt32(item.OperatorId);
                        statusOfTicket.ticketNo = item.TicketNo;
                        statusOfTicket.machineId = Convert.ToInt32(item.machineId);
                        DateTime tktOpenDate = Convert.ToDateTime(item.TicketOpenDate);
                        statusOfTicket.ticketOpenDate = tktOpenDate.ToString("dd-MM-yyyy");
                        statusOfTicketsList.Add(statusOfTicket);
                    }
                    obj.isStatus = true;
                    obj.response = statusOfTicketsList;
                }
                else
                {
                    obj.isStatus = true;
                    obj.response = ResourceResponse.NoItemsFound;
                }
            }
            catch (Exception)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Operator Accepts Acknowledge
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse OperatorAcceptsAck(OperatorAccept data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var roleId = db.TblOperatorDetails.Where(m => m.OpId == data.operatorId).Select(m => m.RoleId).FirstOrDefault();

                CommonFunction commonFunction = new CommonFunction();
                string shift = commonFunction.GetCurrentShift();
                string correctedDate = commonFunction.GetCorrectedDate();
                int ShiftID = commonFunction.ShiftDet();

                var check = db.TblTicketRaisedDet.Where(m => m.TicketId == data.ticketId && roleId == 6 && m.IfSupportTeamOpen == 2).FirstOrDefault();
                if (check != null)
                {
                    int operatorId = Convert.ToInt32(check.OperatorId);
                    var loginTrackerDetails = commonFunction.GetLoginTrackerDetails(correctedDate, data.machineId, operatorId);
                    if (loginTrackerDetails != null)
                    {
                        check.IfOperatorAccepts = 1;
                        check.IsStatus = 4; //operator Accepts
                        check.OperatorAcceptRejectDate = DateTime.Now;
                        check.OpAcceptReson = data.reason;
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = "Operator Accepts The Acknowledge";
                    }

                    string[] ticketIds = loginTrackerDetails.CurrentTicketRaisedId.Split(',');
                    List<string> remainedIds = RemoveRejectId(ticketIds, data.ticketId);

                    #region Update ticket ids

                    loginTrackerDetails.CurrentTicketRaisedId = null;
                    db.LoginTrackerDetails.Update(loginTrackerDetails);
                    db.SaveChanges();
                    foreach (var ids1 in remainedIds)
                    {
                        loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId + "," + ids1 + ",";
                        loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimEnd(',');
                        loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimStart(',');
                        db.LoginTrackerDetails.Update(loginTrackerDetails);
                        db.SaveChanges();
                    }

                    #endregion
                }

                var dbCheck = db.TblRaisedTicket.Where(m => m.TicketId == data.ticketId).FirstOrDefault();
                if (dbCheck != null)
                {
                    dbCheck.Status = 4;
                    dbCheck.TicketClosedDate = DateTime.Now;
                    db.SaveChanges();
                }

                //#region sms integration

                //var className = db.TblClassMaster.Where(m => m.ClassId == dbCheck.ClassId).Select(m => m.ClassName).FirstOrDefault();
                //var statusName = db.TblStatusMaster.Where(m => m.StatusId == dbCheck.StatusId).Select(m => m.StatusName).FirstOrDefault();
                //var machineInvNo = db.Tblmachinedetails.Where(m => m.MachineId == data.machineId).Select(m => m.MachineName).FirstOrDefault();

                //DateTime tktAcceptedDate = Convert.ToDateTime(check.OperatorAcceptRejectDate);
                //string ticketAcceptedDateTime = tktAcceptedDate.ToString("yyyy-MM-dd HH:mm:ss");
                //string ticketOpenName = "BD Alert!!\n" + machineInvNo + "," + ticketAcceptedDateTime + ",\n" + "Ticket Status:" + "-" + "Accepted by Operator\n" + "Reason" + "-" + statusName + "-" + "BDR\n" + "I-FACILITY";
                //var contactNo = db.TblOperatorDetails.Where(m => m.OpId == data.operatorId).Select(m => m.ContactNo).FirstOrDefault();
                //string sendSms = commonFunction.SMSEscalationSendPostURLEncode("12", contactNo, ticketOpenName, appSettings.SmsKey, appSettings.SmsDetailsPost);

                //#endregion
            }
            catch (Exception)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Operator Reject Acknowledge & Reopen the Ticket
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse OperatorRejectAck(OperatorReject data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var roleId = db.TblOperatorDetails.Where(m => m.OpId == data.operatorId).Select(m => m.RoleId).FirstOrDefault();

                CommonFunction commonFunction = new CommonFunction();
                string shift = commonFunction.GetCurrentShift();
                string correctedDate = commonFunction.GetCorrectedDate();


                var check = db.TblTicketRaisedDet.Where(m => m.TicketId == data.ticketId && m.IfSupportTeamOpen == 2 && roleId == 6).FirstOrDefault();

                int operatorId = Convert.ToInt32(check.OperatorId);
                var loginTrackerDetails = commonFunction.GetLoginTrackerDetails(correctedDate, data.machineId, operatorId);
                if (loginTrackerDetails != null)
                {
                    if (check != null)
                    {
                        check.IfOperatorAccepts = 2;
                        check.IsStatus = 5; //operator Reject
                        check.OperatorAcceptRejectDate = DateTime.Now;
                        check.OpRejectReason = data.reason;
                        check.CommentsByOperator = data.commentsByOperator;
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = "Operator Rejects The Acknowledge";
                    }

                    var dbCheck = db.TblRaisedTicket.Where(m => m.TicketId == data.ticketId).FirstOrDefault();
                    if (dbCheck != null)
                    {
                        dbCheck.Status = 5;
                        db.SaveChanges();
                    }

                    string[] ticketIds = loginTrackerDetails.CurrentTicketRaisedId.Split(',');
                    List<string> remainedIds = RemoveRejectId(ticketIds, data.ticketId);

                    #region Update ticket ids

                    loginTrackerDetails.CurrentTicketRaisedId = null;
                    db.LoginTrackerDetails.Update(loginTrackerDetails);
                    db.SaveChanges();
                    foreach (var ids1 in remainedIds)
                    {
                        loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId + "," + ids1 + ",";
                        loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimEnd(',');
                        loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimStart(',');
                        db.LoginTrackerDetails.Update(loginTrackerDetails);
                        db.SaveChanges();
                    }

                    #endregion

                    TblRaisedTicket tblRaisedTicket = new TblRaisedTicket();
                    tblRaisedTicket.MachineId = dbCheck.MachineId;
                    tblRaisedTicket.OperatorId = dbCheck.OperatorId;
                    tblRaisedTicket.TicketNo = dbCheck.TicketNo;
                    tblRaisedTicket.StatusId = dbCheck.StatusId;
                    tblRaisedTicket.TicketOpenDate = DateTime.Now;
                    tblRaisedTicket.CreatedOn = DateTime.Now;
                    tblRaisedTicket.ClassId = dbCheck.ClassId;
                    tblRaisedTicket.CategoryId = dbCheck.CategoryId;
                    tblRaisedTicket.IsDeleted = 0;
                    tblRaisedTicket.ReasonId = dbCheck.ReasonId;
                    tblRaisedTicket.Comments = dbCheck.Comments;
                    tblRaisedTicket.CorrectedDate = dbCheck.CorrectedDate;
                    tblRaisedTicket.AlarmId = dbCheck.AlarmId;
                    tblRaisedTicket.RoleId = dbCheck.RoleId;
                    tblRaisedTicket.Status = 6; //Ticket Reopened
                    db.TblRaisedTicket.Add(tblRaisedTicket);
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.AddedSuccessMessage;

                    TblTicketRaisedDet tblTicketRaisedDet = new TblTicketRaisedDet();
                    tblTicketRaisedDet.TicketId = tblRaisedTicket.TicketId;
                    tblTicketRaisedDet.OperatorId = tblRaisedTicket.OperatorId;
                    tblTicketRaisedDet.IsDeleted = 0;
                    tblTicketRaisedDet.IsStatus = 6;
                    tblTicketRaisedDet.TicketNo = tblRaisedTicket.TicketNo;
                    tblTicketRaisedDet.CreatedOn = DateTime.Now;
                    db.TblTicketRaisedDet.Add(tblTicketRaisedDet);
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.AddedSuccessMessage;

                    #region Update last row of logged in user details 
                    loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId + "," + tblRaisedTicket.TicketId + ",";
                    loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimEnd(',');
                    loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimStart(',');
                    db.LoginTrackerDetails.Update(loginTrackerDetails);
                    db.SaveChanges();
                    #endregion
                }
            }
            catch (Exception ex)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// View Tickets To Maintainance Team
        /// </summary>
        /// <param name="HostName"></param>
        /// <param name="IpAddress"></param>
        /// <returns></returns>
        public CommonResponse ViewTicketsToMaintainanceTeam(string HostName, string IpAddress)
        {
            CommonResponse obj = new CommonResponse();
            List<StatusOfTicket> statusOfTicketsList = new List<StatusOfTicket>();
            try
            {
                CommonFunction commonFunction = new CommonFunction();
                string shift = commonFunction.GetCurrentShift();
                string correctedDate = commonFunction.GetCorrectedDate();

                var check = (from wf in db.TblSystemConfig
                             where wf.PcHostName == HostName && wf.PcIpAddress == IpAddress && wf.IsDeleted == 0
                             select new
                             {
                                 wf.MachineId,
                                 wf.SystemConfigId
                             }).FirstOrDefault();

                string[] ids = check.MachineId.Split(',');

                foreach (var item in ids)
                {
                    int machineId = Convert.ToInt32(item);
                    var dbCheck = (from wf in db.TblRaisedTicket
                                   where wf.IsDeleted == 0 && wf.MachineId == machineId
                                   select new
                                   {
                                       TicketId = wf.TicketId,
                                       ClassName = db.TblClassMaster.Where(m => m.ClassId == wf.ClassId).Select(m => m.ClassName).FirstOrDefault(),
                                       ClassId = wf.ClassId,
                                       StatusName = db.TblStatusMaster.Where(m => m.StatusId == wf.StatusId).Select(m => m.StatusName).FirstOrDefault(),
                                       StatusId = wf.StatusId,
                                       ReasonId = wf.ReasonId,
                                       ReasonName = db.TblStoppage.Where(m => m.StoppagesId == wf.ReasonId).Select(m => m.AlramDesc).FirstOrDefault(),
                                       CategoryName = db.TblCategoryMaster.Where(m => m.CategoryId == wf.CategoryId).Select(m => m.CategoryName).FirstOrDefault(),
                                       CategoryId = wf.CategoryId,
                                       TicketNo = wf.TicketNo,
                                       TicketOpenDate = wf.TicketOpenDate,
                                       OperatorId = wf.OperatorId,
                                       status = wf.Status,
                                       machineId = wf.MachineId,
                                       operatorReason = db.TblTicketRaisedDet.Where(m => m.TicketId == wf.TicketId).Select(m => m.OpRejectReason).FirstOrDefault()
                                   }).ToList();

                    if (dbCheck.Count > 0)
                    {
                        foreach (var items in dbCheck)
                        {
                            StatusOfTicket statusOfTickets = new StatusOfTicket();

                            statusOfTickets.ticketId = items.TicketId;
                            statusOfTickets.categoryId = Convert.ToInt32(items.CategoryId);
                            statusOfTickets.categoryName = items.CategoryName;
                            statusOfTickets.classId = Convert.ToInt32(items.ClassId);
                            statusOfTickets.className = items.ClassName;
                            statusOfTickets.statusId = Convert.ToInt32(items.StatusId);
                            statusOfTickets.statusName = items.StatusName;
                            statusOfTickets.reasonId = Convert.ToInt32(items.ReasonId);
                            statusOfTickets.reasonName = items.ReasonName;
                            statusOfTickets.categoryId = Convert.ToInt32(items.CategoryId);
                            statusOfTickets.categoryName = items.CategoryName;
                            statusOfTickets.ticketNo = items.TicketNo;
                            statusOfTickets.machineId = Convert.ToInt32(items.machineId);
                            DateTime tktOpenDate = Convert.ToDateTime(items.TicketOpenDate);
                            statusOfTickets.ticketOpenDate = tktOpenDate.ToString("dd-MM-yyyy HH:mm:ss");
                            statusOfTickets.operatorReason = items.operatorReason;
                            if (items.status == 1)
                            {
                                statusOfTickets.ticketStatus = "Open";
                            }
                            else if (items.status == 2)
                            {
                                statusOfTickets.ticketStatus = "Maintainance Team Accept";
                            }
                            else if (items.status == 3)
                            {
                                statusOfTickets.ticketStatus = "Maintainance Team Close";
                            }
                            else if (items.status == 4)
                            {
                                statusOfTickets.ticketStatus = "Operator Accept";
                            }
                            else if (items.status == 5)
                            {
                                statusOfTickets.ticketStatus = "Rejected";
                            }
                            else if (items.status == 6)
                            {
                                statusOfTickets.ticketStatus = "Reopen";
                            }
                            var supportTeam = db.TblTicketRaisedDet.Where(m => m.TicketId == items.TicketId).FirstOrDefault();
                            if (supportTeam != null)
                            {
                                statusOfTickets.maintainanceTeamAccept = Convert.ToInt32(supportTeam.IfSupportTeamOpen);
                            }
                            statusOfTicketsList.Add(statusOfTickets);
                        }
                    }
                }
                obj.isStatus = true;
                obj.response = statusOfTicketsList.OrderByDescending(m => m.ticketId).ThenByDescending(m => m.statusName);
            }
            catch (Exception)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        public List<string> RemoveRejectId(string[] ticketIds, int RejectTicketId)
        {
            List<string> temp = new List<string>();
            for (int i = 0; i < ticketIds.Length; i++)
            {
                int ticket = Convert.ToInt32(ticketIds[i]);
                if (RejectTicketId != ticket)
                {
                    temp.Add(ticketIds[i]);
                }
            }
            return temp;
        }

        /// <summary>
        /// View Tickets For Operator
        /// </summary>
        /// <param name="machineId"></param>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        public CommonResponse ViewTicketsForOperator(int machineId, int operatorId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                CommonFunction commonFunction = new CommonFunction();
                string shift = commonFunction.GetCurrentShift();
                string correctedDate = commonFunction.GetCorrectedDate();
                List<ViewDetailsToOperator> viewDetailsToOperatorsList = new List<ViewDetailsToOperator>();

                var roleId = db.TblOperatorDetails.Where(m => m.OpId == operatorId).Select(m => m.RoleId).FirstOrDefault();
                var loginTrackerDetails = commonFunction.GetLoginTrackerDetails(correctedDate, machineId, operatorId);

                if (loginTrackerDetails != null)
                {
                    var check = (from wf in db.TblRaisedTicket
                                 where roleId == 6 && wf.Status == 3 && wf.CorrectedDate == correctedDate && wf.MachineId == machineId
                                 select new
                                 {
                                     TicketId = wf.TicketId,
                                     TicketNo = wf.TicketNo,
                                     TicketOpenDate = wf.TicketOpenDate,
                                     ClassName = db.TblClassMaster.Where(m => m.ClassId == wf.ClassId).Select(m => m.ClassName).FirstOrDefault(),
                                     ClassId = wf.ClassId,
                                     StatusName = db.TblStatusMaster.Where(m => m.StatusId == wf.StatusId).Select(m => m.StatusName).FirstOrDefault(),
                                     StatusId = wf.StatusId,
                                     ReasonId = wf.ReasonId,
                                     ReasonName = db.TblStoppage.Where(m => m.StoppagesId == wf.ReasonId).Select(m => m.AlramDesc).FirstOrDefault(),
                                     CategoryName = db.TblCategoryMaster.Where(m => m.CategoryId == wf.CategoryId).Select(m => m.CategoryName).FirstOrDefault(),
                                     CategoryId = wf.CategoryId,
                                     OperatorId = wf.OperatorId,
                                     status = wf.Status,
                                     machineId = wf.MachineId,
                                     operatorName = db.TblOperatorDetails.Where(m => m.OpId == wf.OperatorId).Select(m => m.OperatorName).FirstOrDefault(),
                                     machineName = db.Tblmachinedetails.Where(m => m.MachineId == wf.MachineId).Select(m => m.MachineName).FirstOrDefault(),
                                     maintainanceName = db.TblOperatorDetails.Where(m => m.OpId == db.TblTicketRaisedDet.Where(m1 => m1.TicketId == wf.TicketId).Select(m1 => m1.SupportTeamId).FirstOrDefault()).Select(m => m.OperatorName).FirstOrDefault(),
                                     maintainanceTeamAcceptDate = db.TblTicketRaisedDet.Where(m => m.TicketId == wf.TicketId).Select(m => m.SupportTeamAckDate).FirstOrDefault(),
                                     maintainanceTeamCloseDate = db.TblTicketRaisedDet.Where(m => m.TicketId == wf.TicketId).Select(m => m.SupportTeamClosureDate).FirstOrDefault(),
                                     commentsByOperator = wf.Comments,
                                     maintanceAcceptReason = db.TblTicketRaisedDet.Where(m => m.TicketId == wf.TicketId).Select(m => m.MntAcceptReason).FirstOrDefault(),
                                     maintanceClosedReason = db.TblTicketRaisedDet.Where(m => m.TicketId == wf.TicketId).Select(m => m.MntRejectReason).FirstOrDefault(),
                                 }).ToList();

                    foreach (var item in check)
                    {
                        ViewDetailsToOperator viewDetailsToOperator = new ViewDetailsToOperator();
                        viewDetailsToOperator.ticketId = item.TicketId;
                        viewDetailsToOperator.ticketNo = item.TicketNo;
                        DateTime tkOpDate = Convert.ToDateTime(item.TicketOpenDate);
                        viewDetailsToOperator.ticketOpenDate = tkOpDate.ToString("yyyy-MM-dd HH:mm:ss");
                        viewDetailsToOperator.classId = Convert.ToInt32(item.ClassId);
                        viewDetailsToOperator.className = item.ClassName;
                        viewDetailsToOperator.statusId = Convert.ToInt32(item.StatusId);
                        viewDetailsToOperator.statusName = item.StatusName;
                        viewDetailsToOperator.categoryId = Convert.ToInt32(item.CategoryId);
                        viewDetailsToOperator.categoryName = item.CategoryName;
                        viewDetailsToOperator.reasonId = Convert.ToInt32(item.ReasonId);
                        viewDetailsToOperator.reasonName = item.ReasonName;
                        viewDetailsToOperator.operatorId = Convert.ToInt32(item.OperatorId);
                        viewDetailsToOperator.status = Convert.ToInt32(item.status);
                        viewDetailsToOperator.machineId = Convert.ToInt32(item.machineId);
                        viewDetailsToOperator.machineName = item.machineName;
                        viewDetailsToOperator.maintainanceName = item.maintainanceName;
                        viewDetailsToOperator.operatorName = item.operatorName;
                        DateTime mntTeamAcceptDate = Convert.ToDateTime(item.maintainanceTeamAcceptDate);
                        viewDetailsToOperator.maintainanceTeamAcceptDate = mntTeamAcceptDate.ToString("yyyy-MM-dd HH:mm:ss");
                        DateTime mntTeamCloseDate = Convert.ToDateTime(item.maintainanceTeamCloseDate);
                        viewDetailsToOperator.maintainanceTeamCloseDate = mntTeamCloseDate.ToString("yyyy-MM-dd HH:mm:ss");
                        viewDetailsToOperator.maintanceAcceptReason = item.maintanceAcceptReason;
                        viewDetailsToOperator.maintanceClosedReason = item.maintanceClosedReason;
                        viewDetailsToOperator.commentsByOperator = item.commentsByOperator;
                        viewDetailsToOperatorsList.Add(viewDetailsToOperator);
                    }


                    if (check.Count > 0)
                    {
                        obj.isStatus = true;
                        obj.response = viewDetailsToOperatorsList;
                    }
                    else
                    {
                        obj.isStatus = false;
                        obj.response = ResourceResponse.NoItemsFound;
                    }
                }

            }
            catch (Exception)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Close Ticket (Accept With Deviation)
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse CloseTicket(AcceptWithDeviation data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                CommonFunction commonFunction = new CommonFunction();
                string shift = commonFunction.GetCurrentShift();
                string correctedDate = commonFunction.GetCorrectedDate();

                var roleId = db.TblOperatorDetails.Where(m => m.OpId == data.operatorId).Select(m => m.RoleId).FirstOrDefault();

                var check = db.TblTicketRaisedDet.Where(m => m.TicketId == data.ticketId && roleId == 6 && m.IfSupportTeamOpen == 2).FirstOrDefault();
                if (check != null)
                {
                    var loginTrackerDetails = commonFunction.GetLoginTrackerDetails(correctedDate, data.machineId, data.operatorId);
                    if (loginTrackerDetails != null)
                    {
                        check.IfOperatorAccepts = 1;
                        check.IsStatus = 4; //operator Accepts
                        check.OperatorAcceptRejectDate = DateTime.Now;
                        check.OpAcceptReson = data.reason;
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = "Operator Accepts The Acknowledge";
                    }

                    string[] ticketIds = loginTrackerDetails.CurrentTicketRaisedId.Split(',');
                    List<string> remainedIds = RemoveRejectId(ticketIds, data.ticketId);

                    #region Update ticket ids

                    loginTrackerDetails.CurrentTicketRaisedId = null;
                    db.LoginTrackerDetails.Update(loginTrackerDetails);
                    db.SaveChanges();
                    foreach (var ids1 in remainedIds)
                    {
                        loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId + "," + ids1 + ",";
                        loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimEnd(',');
                        loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimStart(',');
                        db.LoginTrackerDetails.Update(loginTrackerDetails);
                        db.SaveChanges();
                    }

                    #endregion

                    var dbCheck = db.TblRaisedTicket.Where(m => m.TicketId == data.ticketId).FirstOrDefault();
                    if (dbCheck != null)
                    {
                        dbCheck.Status = 4;
                        dbCheck.TicketClosedDate = DateTime.Now;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

    }
}
