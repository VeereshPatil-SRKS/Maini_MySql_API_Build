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
                var check = (from wf in db.UnitworkccsTblcategorymaster
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
                var check = (from wf in db.UnitworkccsTblclassmaster
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
                var check = (from wf in db.UnitworkccsTblstatusmaster
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
                var check = (from wf in db.UnitworkccsTblstoppage
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
                var className = db.UnitworkccsTblclassmaster.Where(m => m.ClassId == data.classId).Select(m => m.ClassName).FirstOrDefault();
                var statusName = db.UnitworkccsTblstatusmaster.Where(m => m.StatusId == data.statusId).Select(m => m.StatusName).FirstOrDefault();
                var machineInvNo = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == data.machineId).Select(m => m.MachineName).FirstOrDefault();
                var reasonName = db.UnitworkccsTblstoppage.Where(m => m.StoppagesId == data.reasonId).Select(m => m.AlramDesc).FirstOrDefault();

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

                var roleId = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == data.operatorId).Select(m => m.RoleId).FirstOrDefault();
                var check = db.UnitworkccsTblraisedticket.Where(m => m.TicketId == data.ticketId && roleId == 6).FirstOrDefault();

                var loginTrackerDetails = commonFunction.GetLoginTrackerDetails(correctedDate, data.machineId, data.operatorId);

                if (loginTrackerDetails != null)
                {
                    #region Add and Update Ticket Raised for partcular machine
                    if (check == null)
                    {
                        UnitworkccsTblraisedticket UnitworkccsTblraisedticket = new UnitworkccsTblraisedticket();
                        UnitworkccsTblraisedticket.MachineId = data.machineId;
                        UnitworkccsTblraisedticket.OperatorId = data.operatorId;
                        UnitworkccsTblraisedticket.RoleId = roleId;
                        UnitworkccsTblraisedticket.TicketNo = ticketName;
                        UnitworkccsTblraisedticket.StatusId = data.statusId;
                        UnitworkccsTblraisedticket.TicketOpenDate = DateTime.Now;
                        UnitworkccsTblraisedticket.CreatedOn = DateTime.Now;
                        UnitworkccsTblraisedticket.ClassId = data.classId;
                        UnitworkccsTblraisedticket.CategoryId = data.categoryId;
                        UnitworkccsTblraisedticket.IsDeleted = 0;
                        UnitworkccsTblraisedticket.ReasonId = data.reasonId;
                        UnitworkccsTblraisedticket.Comments = data.comments;
                        UnitworkccsTblraisedticket.CorrectedDate = correctedDate;
                        UnitworkccsTblraisedticket.Status = 1; //Ticket Raised
                        UnitworkccsTblraisedticket.AlarmId = data.alarmId;
                        db.UnitworkccsTblraisedticket.Add(UnitworkccsTblraisedticket);
                        db.SaveChanges();
                        obj.id = UnitworkccsTblraisedticket.TicketId;
                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;

                        UnitworkccsTblticketraiseddet UnitworkccsTblticketraiseddet = new UnitworkccsTblticketraiseddet();
                        UnitworkccsTblticketraiseddet.TicketId = UnitworkccsTblraisedticket.TicketId;
                        UnitworkccsTblticketraiseddet.OperatorId = UnitworkccsTblraisedticket.OperatorId;
                        UnitworkccsTblticketraiseddet.IsDeleted = 0;
                        UnitworkccsTblticketraiseddet.IsStatus = 1;
                        UnitworkccsTblticketraiseddet.TicketNo = UnitworkccsTblraisedticket.TicketNo;
                        UnitworkccsTblticketraiseddet.CreatedOn = DateTime.Now;
                        UnitworkccsTblticketraiseddet.MachineId = UnitworkccsTblraisedticket.MachineId;
                        db.UnitworkccsTblticketraiseddet.Add(UnitworkccsTblticketraiseddet);
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;

                        //#region Update last row of logged in user details 
                        //loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId + "," + UnitworkccsTblraisedticket.TicketId + ",";
                        //loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimEnd(',');
                        //loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimStart(',');
                        //db.LoginTrackerDetails.Update(loginTrackerDetails);
                        //db.SaveChanges();

                        //#endregion

                        //#region sms integration

                        //var currentFgpart = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == data.machineId).OrderByDescending(m => m.FgPartId).Select(m => m.PlanLinkageId).FirstOrDefault();

                        //var partNo = db.UnitworkccsTblplanlinkagemaster.Where(m => m.PlanLinkageId == currentFgpart).Select(m => m.FgPartNo).FirstOrDefault();

                        //var cellId = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.CellFinalId).FirstOrDefault();

                        //var subCellId = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.SubCellFinalId).FirstOrDefault();

                        //var maintainance = (from wf in db.TblEscalationMatrix
                        //                    where wf.Shift == shift && (wf.CellId == cellId || wf.CellId == 0) && (wf.SubCellId == subCellId || wf.SubCellId == 0) && wf.CategoryId == data.categoryId && wf.TimeToBeTriggered == 0 && wf.SmsPriority == 1 && wf.IsDeleted == 0 && (wf.Role == "Line inspectors" || wf.Role == "Quality incharge" || wf.Role == "cell incharge" || wf.Role == "supervisor" || wf.Role == "Toolstores" || wf.Role == "Setter" || wf.Role == "Tool store incharge" || wf.Role == "PPC incharge" || wf.Role == "Maintainance")
                        //                    select new
                        //                    {
                        //                        contactNo = wf.ContactNo,
                        //                        smsPriority = wf.SmsPriority,
                        //                        cellId = wf.CellId,
                        //                        subCellId = wf.SubCellId,
                        //                        employeeName = wf.EmployeeName,
                        //                        categoryId = wf.CategoryId,
                        //                        timeToBeTriggered = wf.TimeToBeTriggered,
                        //                        opNo = wf.OpNo
                        //                    }).ToList();

                        //foreach (var item in maintainance)
                        //{
                        //    var dbCheck = db.TblSmsDetails.Where(m => m.Shift == shift && m.CellId == item.cellId && m.SubCellId == item.subCellId && m.SmsPriority == item.smsPriority && m.OpNo == item.opNo && m.CorrectedDate == correctedDate && m.TimeToBeTriggered == item.timeToBeTriggered && m.CategoryId == item.categoryId && m.TicketId == UnitworkccsTblraisedticket.TicketId).FirstOrDefault();

                        //    if (dbCheck == null)
                        //    {
                        //        DateTime tktOpDate = Convert.ToDateTime(UnitworkccsTblraisedticket.TicketOpenDate);
                        //        string ticketOpenDatTime = tktOpDate.ToString("HH:mm");
                        //        string ticketOpenName = "BD Alert!!\n" + machineInvNo + "," + ticketOpenDatTime + ",\n" + "Ticket Status" + "-" + "Open\n" + "Status" + " " + "-" + statusName + "-" + "BDR\n" + "Reason" + " " + "-" + reasonName + "\n" + "I-FACILITY";
                        //        //var contactNo = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == data.operatorId).Select(m => m.ContactNo).FirstOrDefault();
                        //        string sendSms = commonFunction.SMSEscalationSendPostURLEncode("12", item.contactNo, ticketOpenName, appSettings.SmsKey, appSettings.SmsDetailsPost);

                        //        TblSmsDetails tblSmsDetails = new TblSmsDetails();
                        //        tblSmsDetails.ContactNo = item.contactNo;
                        //        tblSmsDetails.MachineId = data.machineId;
                        //        tblSmsDetails.TicketId = UnitworkccsTblraisedticket.TicketId;
                        //        tblSmsDetails.CellId = item.cellId;
                        //        tblSmsDetails.SubCellId = item.subCellId;
                        //        tblSmsDetails.SmsPriority = item.smsPriority;
                        //        tblSmsDetails.OpNo = item.opNo;
                        //        tblSmsDetails.EmployeeName = item.employeeName;
                        //        tblSmsDetails.Shift = shift;
                        //        tblSmsDetails.CategoryId = item.categoryId;
                        //        tblSmsDetails.IsDeleted = 0;
                        //        tblSmsDetails.ResponseId = sendSms;
                        //        tblSmsDetails.Message = ticketOpenName;
                        //        tblSmsDetails.CreatedOn = DateTime.Now;
                        //        tblSmsDetails.TimeToBeTriggered = item.timeToBeTriggered;
                        //        tblSmsDetails.CorrectedDate = correctedDate;
                        //        db.TblSmsDetails.Add(tblSmsDetails);
                        //        db.SaveChanges();
                        //    }
                        //}

                        ////var dbCheck = db.UnitworkccsTbloperatordetails.Where(m => m.RoleId == 9 && m.CellId == 0 && (m.CategoryId == 1 || m.CategoryId == 2) && m.Shift == shift).Select(m => m.ContactNo).ToList();

                        ////foreach (var item in dbCheck)
                        ////{
                        ////    DateTime tktOpDate = Convert.ToDateTime(UnitworkccsTblraisedticket.TicketOpenDate);
                        ////    string ticketOpenDatTime = tktOpDate.ToString("HH:mm");
                        ////    string ticketOpenName = "BD Alert!!\n" + machineInvNo + "," + ticketOpenDatTime + ",\n" + "Ticket Status" + "-" + "Open\n" + "Status" + " " + "-" + statusName + "-" + "BDR\n" + "Reason" + " " + "-" + reasonName + "\n" + "I-FACILITY";
                        ////    //var contactNo = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == data.operatorId).Select(m => m.ContactNo).FirstOrDefault();
                        ////    string sendSms = commonFunction.SMSEscalationSendPostURLEncode("12", item, ticketOpenName, appSettings.SmsKey, appSettings.SmsDetailsPost);

                        ////    if (sendSms != null)
                        ////    {
                        ////        var dbCheck = db.TblSmsDetails.Where(m=>m.)
                        ////        TblSmsDetails tblSmsDetails = new TblSmsDetails();
                        ////        tblSmsDetails.ContactNo = item;
                        ////        tblSmsDetails.MachineId = data.machineId;
                        ////        tblSmsDetails.TicketId = UnitworkccsTblraisedticket.TicketId;
                        ////        tblSmsDetails.IsDeleted = 0;
                        ////        tblSmsDetails.ResponseId = sendSms;
                        ////        tblSmsDetails.Message = ticketOpenName;
                        ////        tblSmsDetails.CorrectedDate = correctedDate;
                        ////        tblSmsDetails.CreatedOn = DateTime.Now;
                        ////        db.TblSmsDetails.Add(tblSmsDetails);
                        ////        db.SaveChanges();
                        ////    }
                        ////}

                        ////var dbCheck1 = db.UnitworkccsTbloperatordetails.Where(m => m.RoleId == 18 && m.CellId == 0 && m.Shift == shift).Select(m => m.ContactNo).ToList();

                        ////foreach (var item in dbCheck1)
                        ////{
                        ////    DateTime tktOpDate = Convert.ToDateTime(UnitworkccsTblraisedticket.TicketOpenDate);
                        ////    string ticketOpenDatTime = tktOpDate.ToString("HH:mm");
                        ////    string ticketOpenName = "BD Alert!!\n" + machineInvNo + "," + ticketOpenDatTime + ",\n" + "Ticket Status" + "-" + "Open\n" + "Status" + " " + "-" + statusName + "-" + "BDR\n" + "Reason" + " " + "-" + reasonName + "\n" + "I-FACILITY";
                        ////    //var contactNo = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == data.operatorId).Select(m => m.ContactNo).FirstOrDefault();
                        ////    string sendSms = commonFunction.SMSEscalationSendPostURLEncode("12", item, ticketOpenName, appSettings.SmsKey, appSettings.SmsDetailsPost);

                        ////    if (sendSms != null)
                        ////    {
                        ////        TblSmsDetails tblSmsDetails = new TblSmsDetails();
                        ////        tblSmsDetails.ContactNo = item;
                        ////        tblSmsDetails.MachineId = data.machineId;
                        ////        tblSmsDetails.TicketId = UnitworkccsTblraisedticket.TicketId;
                        ////        tblSmsDetails.IsDeleted = 0;
                        ////        tblSmsDetails.ResponseId = sendSms;
                        ////        tblSmsDetails.Message = ticketOpenName;
                        ////        tblSmsDetails.CorrectedDate = correctedDate;
                        ////        tblSmsDetails.CreatedOn = DateTime.Now;
                        ////        db.TblSmsDetails.Add(tblSmsDetails);
                        ////        db.SaveChanges();
                        ////    }
                        ////}

                        //#endregion

                        #region End mode in livemodeDb and insert new row with mode breakDown

                        var ModeDet = db.UnitworkccsTbllivemode.Where(m => m.IsCompleted == 0 && m.MachineId == data.machineId).OrderByDescending(m => m.ModeId).FirstOrDefault();

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

                            int BreakDownID = Convert.ToInt32(db.UnitworkccsTblbreakdowntickect.Where(m => m.IsDeleted == 0 && m.MachineId == data.machineId && m.ProdFinished == null).OrderByDescending(m => m.Id).Select(m => m.ReasonId).FirstOrDefault());

                            UnitworkccsTbllivemode UnitworkccsTbllivemode = new UnitworkccsTbllivemode();
                            UnitworkccsTbllivemode.MachineId = data.machineId;
                            UnitworkccsTbllivemode.MacMode = "MNT";
                            UnitworkccsTbllivemode.InsertedOn = ET;
                            UnitworkccsTbllivemode.InsertedBy = 1;
                            UnitworkccsTbllivemode.CorrectedDate = ET.Date;
                            UnitworkccsTbllivemode.IsDeleted = 0;
                            UnitworkccsTbllivemode.StartTime = ET;
                            UnitworkccsTbllivemode.ColorCode = "RED";
                            UnitworkccsTbllivemode.BreakDownCodeId = BreakDownID;
                            UnitworkccsTbllivemode.IsCompleted = 0;
                            UnitworkccsTbllivemode.ModeType = "MNT";
                            UnitworkccsTbllivemode.ModeTypeEnd = 0;
                            UnitworkccsTbllivemode.IsShiftEnd = ShiftID;
                            db.UnitworkccsTbllivemode.Add(UnitworkccsTbllivemode);
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
                var roleId = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == supportTeamId).Select(m => m.RoleId).FirstOrDefault();
                var check = (from wf in db.UnitworkccsTblraisedticket
                             where wf.IsDeleted == 0 && roleId == 9
                             select new
                             {
                                 TicketId = wf.TicketId,
                                 ClassName = db.UnitworkccsTblclassmaster.Where(m => m.ClassId == wf.ClassId).Select(m => m.ClassName).FirstOrDefault(),
                                 ClassId = wf.ClassId,
                                 StatusName = db.UnitworkccsTblstatusmaster.Where(m => m.StatusId == wf.StatusId).Select(m => m.StatusName).FirstOrDefault(),
                                 StatusId = wf.StatusId,
                                 ReasonId = wf.ReasonId,
                                 ReasonName = db.UnitworkccsTblticketreason.Where(m => m.TktReasonId == wf.ReasonId).Select(m => m.ReasonName).FirstOrDefault(),
                                 CategoryName = db.UnitworkccsTblcategorymaster.Where(m => m.CategoryId == wf.CategoryId).Select(m => m.CategoryName).FirstOrDefault(),
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
                var roleId = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == data.supportTeamId).Select(m => m.RoleId).FirstOrDefault();
                var check = db.UnitworkccsTblticketraiseddet.Where(m => m.TicketId == data.ticketId && roleId == 9 && (m.IsStatus == 1 || m.IsStatus == 6)).FirstOrDefault();

                if (check != null)
                {
                    check.TicketId = data.ticketId;
                    check.SupportTeamId = data.supportTeamId;
                    //check.TicketNo = db.UnitworkccsTblraisedticket.Where(m => m.TicketId == data.ticketId).Sele(m=>m.TicketNo).FirstOrDefau();
                    check.IsStatus = 2;
                    check.SupportTeamAckDate = DateTime.Now;
                    check.IfSupportTeamOpen = 1;
                    check.MntAcceptReason = data.reason;
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.UpdatedSuccessMessage;

                    var dbCheck = db.UnitworkccsTblraisedticket.Where(m => m.TicketId == data.ticketId).FirstOrDefault();
                    if (dbCheck != null)
                    {
                        dbCheck.Status = 2;
                        db.SaveChanges();
                    }

                    //#region sms integration

                    //var className = db.UnitworkccsTblclassmaster.Where(m => m.ClassId == dbCheck.ClassId).Select(m => m.ClassName).FirstOrDefault();
                    //var statusName = db.UnitworkccsTblstatusmaster.Where(m => m.StatusId == dbCheck.StatusId).Select(m => m.StatusName).FirstOrDefault();
                    //var machineInvNo = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == data.machineId).Select(m => m.MachineName).FirstOrDefault();

                    //DateTime tktAcceptedDate = Convert.ToDateTime(check.SupportTeamAckDate);
                    //string ticketAcceptedDateTime = tktAcceptedDate.ToString("yyyy-MM-dd HH:mm:ss");
                    //string ticketOpenName = "BD Alert!!\n" + machineInvNo + "," + ticketAcceptedDateTime + ",\n" + "Ticket Status:" + "-" + "Accepted by Maintainance Team\n" + "Reason" + "-" + statusName + "-" + "BDR\n" + "I-FACILITY";

                    //var contactNo = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == data.supportTeamId).Select(m => m.ContactNo).FirstOrDefault();
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

                var roleId = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == data.supportTeamId).Select(m => m.RoleId).FirstOrDefault();

                var check = db.UnitworkccsTblticketraiseddet.Where(m => m.TicketId == data.ticketId && roleId == 9 && m.IsStatus == 2 && m.IfSupportTeamOpen == 1).FirstOrDefault();

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

                    var ModeDet = db.UnitworkccsTbllivemode.Where(m => m.IsCompleted == 0 && m.MachineId == data.machineId).OrderByDescending(m => m.ModeId).FirstOrDefault();

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
                            UnitworkccsTbllivemode UnitworkccsTbllivemode = new UnitworkccsTbllivemode();
                            UnitworkccsTbllivemode.MachineId = data.machineId;
                            UnitworkccsTbllivemode.MacMode = "IDLE";
                            UnitworkccsTbllivemode.InsertedOn = ET;
                            UnitworkccsTbllivemode.InsertedBy = 1;
                            UnitworkccsTbllivemode.CorrectedDate = ET.Date;
                            UnitworkccsTbllivemode.IsDeleted = 0;
                            UnitworkccsTbllivemode.StartTime = ET;
                            UnitworkccsTbllivemode.ColorCode = "YELLOW";
                            UnitworkccsTbllivemode.IsCompleted = 0;
                            UnitworkccsTbllivemode.ModeType = "IDLE";
                            UnitworkccsTbllivemode.IsShiftEnd = ShiftID;
                            db.UnitworkccsTbllivemode.Add(UnitworkccsTbllivemode);
                            db.SaveChanges();
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }

                var dbCheck = db.UnitworkccsTblraisedticket.Where(m => m.TicketId == data.ticketId).FirstOrDefault();
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
                var roleId = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == operatorId).Select(m => m.RoleId).FirstOrDefault();
                var check = (from wf in db.UnitworkccsTblraisedticket
                             where wf.Status == 3 && wf.IsDeleted == 0 && roleId == 6
                             select new
                             {
                                 TicketId = wf.TicketId,
                                 ClassName = db.UnitworkccsTblclassmaster.Where(m => m.ClassId == wf.ClassId).Select(m => m.ClassName).FirstOrDefault(),
                                 ClassId = wf.ClassId,
                                 StatusName = db.UnitworkccsTblstatusmaster.Where(m => m.StatusId == wf.StatusId).Select(m => m.StatusName).FirstOrDefault(),
                                 StatusId = wf.StatusId,
                                 ReasonId = wf.ReasonId,
                                 ReasonName = db.UnitworkccsTblticketreason.Where(m => m.TktReasonId == wf.ReasonId).Select(m => m.ReasonName).FirstOrDefault(),
                                 CategoryName = db.UnitworkccsTblcategorymaster.Where(m => m.CategoryId == wf.CategoryId).Select(m => m.CategoryName).FirstOrDefault(),
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
                var roleId = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == data.operatorId).Select(m => m.RoleId).FirstOrDefault();

                CommonFunction commonFunction = new CommonFunction();
                string shift = commonFunction.GetCurrentShift();
                string correctedDate = commonFunction.GetCorrectedDate();
                int ShiftID = commonFunction.ShiftDet();

                var check = db.UnitworkccsTblticketraiseddet.Where(m => m.TicketId == data.ticketId && roleId == 6 && m.IfSupportTeamOpen == 2).FirstOrDefault();
                if (check != null)
                {
                    int operatorId = Convert.ToInt32(check.OperatorId);
                    //var loginTrackerDetails = commonFunction.GetLoginTrackerDetails(correctedDate, data.machineId, operatorId);
                    //if (loginTrackerDetails != null)
                    //{
                    check.IfOperatorAccepts = 1;
                    check.IsStatus = 4; //operator Accepts
                    check.OperatorAcceptRejectDate = DateTime.Now;
                    check.OpAcceptReson = data.reason;
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = "Operator Accepts The Acknowledge";
                    //}

                    //string[] ticketIds = loginTrackerDetails.CurrentTicketRaisedId.Split(',');
                    //List<string> remainedIds = RemoveRejectId(ticketIds, data.ticketId);

                    //#region Update ticket ids

                    //loginTrackerDetails.CurrentTicketRaisedId = null;
                    //db.LoginTrackerDetails.Update(loginTrackerDetails);
                    //db.SaveChanges();
                    //foreach (var ids1 in remainedIds)
                    //{
                    //    loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId + "," + ids1 + ",";
                    //    loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimEnd(',');
                    //    loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimStart(',');
                    //    db.LoginTrackerDetails.Update(loginTrackerDetails);
                    //    db.SaveChanges();
                    //}
                }

                var dbCheck = db.UnitworkccsTblraisedticket.Where(m => m.TicketId == data.ticketId).FirstOrDefault();
                if (dbCheck != null)
                {
                    dbCheck.Status = 4;
                    dbCheck.TicketClosedDate = DateTime.Now;
                    db.SaveChanges();
                }

                var trial = db.UnitworkccsTbltrialpartcount.Where(m => m.MachineId == data.machineId && m.TicketId == data.ticketId).LastOrDefault();
                if(trial != null)
                {
                    trial.TicketCloseDate = dbCheck.TicketClosedDate;
                    db.SaveChanges();
                }
                //#region sms integration

                //var className = db.UnitworkccsTblclassmaster.Where(m => m.ClassId == dbCheck.ClassId).Select(m => m.ClassName).FirstOrDefault();
                //var statusName = db.UnitworkccsTblstatusmaster.Where(m => m.StatusId == dbCheck.StatusId).Select(m => m.StatusName).FirstOrDefault();
                //var machineInvNo = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == data.machineId).Select(m => m.MachineName).FirstOrDefault();

                //DateTime tktAcceptedDate = Convert.ToDateTime(check.OperatorAcceptRejectDate);
                //string ticketAcceptedDateTime = tktAcceptedDate.ToString("yyyy-MM-dd HH:mm:ss");
                //string ticketOpenName = "BD Alert!!\n" + machineInvNo + "," + ticketAcceptedDateTime + ",\n" + "Ticket Status:" + "-" + "Accepted by Operator\n" + "Reason" + "-" + statusName + "-" + "BDR\n" + "I-FACILITY";
                //var contactNo = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == data.operatorId).Select(m => m.ContactNo).FirstOrDefault();
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
                var roleId = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == data.operatorId).Select(m => m.RoleId).FirstOrDefault();

                CommonFunction commonFunction = new CommonFunction();
                string shift = commonFunction.GetCurrentShift();
                string correctedDate = commonFunction.GetCorrectedDate();
                string ticketName = "";

                var check = db.UnitworkccsTblticketraiseddet.Where(m => m.TicketId == data.ticketId && m.IfSupportTeamOpen == 2 && roleId == 6).FirstOrDefault();

                int operatorId = Convert.ToInt32(check.OperatorId);
                //var loginTrackerDetails = commonFunction.GetLoginTrackerDetails(correctedDate, data.machineId, operatorId);
                //if (loginTrackerDetails != null)
                //{
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

                var dbCheck = db.UnitworkccsTblraisedticket.Where(m => m.TicketId == data.ticketId).FirstOrDefault();
                if (dbCheck != null)
                {
                    dbCheck.Status = 5;
                    db.SaveChanges();
                }

                //string[] ticketIds = loginTrackerDetails.CurrentTicketRaisedId.Split(',');
                //List<string> remainedIds = RemoveRejectId(ticketIds, data.ticketId);

                //#region Update ticket ids

                //loginTrackerDetails.CurrentTicketRaisedId = null;
                //db.LoginTrackerDetails.Update(loginTrackerDetails);
                //db.SaveChanges();
                //foreach (var ids1 in remainedIds)
                //{
                //    loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId + "," + ids1 + ",";
                //    loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimEnd(',');
                //    loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimStart(',');
                //    db.LoginTrackerDetails.Update(loginTrackerDetails);
                //    db.SaveChanges();
                //}

                //#endregion

                UnitworkccsTblraisedticket UnitworkccsTblraisedticket = new UnitworkccsTblraisedticket();
                UnitworkccsTblraisedticket.MachineId = dbCheck.MachineId;
                UnitworkccsTblraisedticket.OperatorId = dbCheck.OperatorId;
                UnitworkccsTblraisedticket.TicketNo = dbCheck.TicketNo;
                UnitworkccsTblraisedticket.StatusId = dbCheck.StatusId;
                UnitworkccsTblraisedticket.TicketOpenDate = DateTime.Now;
                UnitworkccsTblraisedticket.CreatedOn = DateTime.Now;
                UnitworkccsTblraisedticket.ClassId = dbCheck.ClassId;
                UnitworkccsTblraisedticket.CategoryId = dbCheck.CategoryId;
                UnitworkccsTblraisedticket.MachineId = dbCheck.MachineId;
                UnitworkccsTblraisedticket.IsDeleted = 0;
                UnitworkccsTblraisedticket.ReasonId = dbCheck.ReasonId;
                UnitworkccsTblraisedticket.Comments = dbCheck.Comments;
                UnitworkccsTblraisedticket.CorrectedDate = dbCheck.CorrectedDate;
                UnitworkccsTblraisedticket.AlarmId = dbCheck.AlarmId;
                UnitworkccsTblraisedticket.RoleId = dbCheck.RoleId;
                UnitworkccsTblraisedticket.Status = 6; //Ticket Reopened
                db.UnitworkccsTblraisedticket.Add(UnitworkccsTblraisedticket);
                db.SaveChanges();
                obj.isStatus = true;
                obj.response = ResourceResponse.AddedSuccessMessage;

                UnitworkccsTblticketraiseddet UnitworkccsTblticketraiseddet = new UnitworkccsTblticketraiseddet();
                UnitworkccsTblticketraiseddet.TicketId = UnitworkccsTblraisedticket.TicketId;
                UnitworkccsTblticketraiseddet.OperatorId = UnitworkccsTblraisedticket.OperatorId;
                UnitworkccsTblticketraiseddet.IsDeleted = 0;
                UnitworkccsTblticketraiseddet.MachineId = UnitworkccsTblraisedticket.MachineId;
                UnitworkccsTblticketraiseddet.IsStatus = 6;
                UnitworkccsTblticketraiseddet.TicketNo = UnitworkccsTblraisedticket.TicketNo;
                UnitworkccsTblticketraiseddet.CreatedOn = DateTime.Now;
                db.UnitworkccsTblticketraiseddet.Add(UnitworkccsTblticketraiseddet);
                db.SaveChanges();
                obj.isStatus = true;
                obj.response = ResourceResponse.AddedSuccessMessage;

                //    #region Update last row of logged in user details 
                //    loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId + "," + UnitworkccsTblraisedticket.TicketId + ",";
                //    loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimEnd(',');
                //    loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimStart(',');
                //    db.LoginTrackerDetails.Update(loginTrackerDetails);
                //    db.SaveChanges();
                //    #endregion
                //}
                #region TicketNameFormation

                var className = db.UnitworkccsTblclassmaster.Where(m => m.ClassId == dbCheck.ClassId).Select(m => m.ClassName).FirstOrDefault();
                var statusName = db.UnitworkccsTblstatusmaster.Where(m => m.StatusId == dbCheck.StatusId).Select(m => m.StatusName).FirstOrDefault();
                var machineInvNo = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == data.machineId).Select(m => m.MachineName).FirstOrDefault();
                var reasonName = db.UnitworkccsTblstoppage.Where(m => m.StoppagesId == dbCheck.ReasonId).Select(m => m.AlramDesc).FirstOrDefault();

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

                #region sms integration

                var currentFgpart = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == data.machineId).OrderByDescending(m => m.FgPartId).Select(m => m.PlanLinkageId).FirstOrDefault();

                var partNo = db.UnitworkccsTblplanlinkagemaster.Where(m => m.PlanLinkageId == currentFgpart).Select(m => m.FgPartNo).FirstOrDefault();

                var cellId = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.CellFinalId).FirstOrDefault();

                var subCellId = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.SubCellFinalId).FirstOrDefault();

                //var maintainance = (from wf in db.TblEscalationMatrix
                //                    where wf.Shift == shift && (wf.CellId == cellId || wf.CellId == 0) && (wf.SubCellId == subCellId || wf.SubCellId == 0) && wf.CategoryId == dbCheck.CategoryId && wf.TimeToBeTriggered == 0 && wf.SmsPriority == 1 && wf.IsDeleted == 0 && (wf.Role == "Line inspectors" || wf.Role == "Quality incharge" || wf.Role == "cell incharge" || wf.Role == "supervisor" || wf.Role == "Toolstores" || wf.Role == "Setter" || wf.Role == "Tool store incharge" || wf.Role == "PPC incharge" || wf.Role == "Maintainance")
                //                    select new
                //                    {
                //                        contactNo = wf.ContactNo,
                //                        smsPriority = wf.SmsPriority,
                //                        cellId = wf.CellId,
                //                        subCellId = wf.SubCellId,
                //                        employeeName = wf.EmployeeName,
                //                        categoryId = wf.CategoryId,
                //                        timeToBeTriggered = wf.TimeToBeTriggered,
                //                        opNo = wf.OpNo
                //                    }).ToList();

                //foreach (var item in maintainance)
                //{
                //    DateTime tktOpDate = Convert.ToDateTime(UnitworkccsTblraisedticket.TicketOpenDate);
                //    string ticketOpenDatTime = tktOpDate.ToString("HH:mm");
                //    string ticketOpenName = "BD Alert!!\n" + machineInvNo + "," + ticketOpenDatTime + ",\n" + "Ticket Status" + "-" + "Open\n" + "Status" + " " + "-" + statusName + "-" + "BDR\n" + "Reason" + " " + "-" + reasonName + "\n" + "I-FACILITY";
                //    //var contactNo = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == data.operatorId).Select(m => m.ContactNo).FirstOrDefault();
                //    string sendSms = commonFunction.SMSEscalationSendPostURLEncode("12", item.contactNo, ticketOpenName, appSettings.SmsKey, appSettings.SmsDetailsPost);

                //    if (sendSms != null)
                //    {
                //        var dbCheck1 = db.TblSmsDetails.Where(m => m.Shift == shift && m.CellId == item.cellId && m.SubCellId == item.subCellId && m.SmsPriority == item.smsPriority && m.OpNo == item.opNo && m.CorrectedDate == correctedDate && m.TimeToBeTriggered == 0 && m.CategoryId == item.categoryId).FirstOrDefault();
                //        if (dbCheck1 == null)
                //        {
                //            TblSmsDetails tblSmsDetails = new TblSmsDetails();
                //            tblSmsDetails.ContactNo = item.contactNo;
                //            tblSmsDetails.MachineId = data.machineId;
                //            tblSmsDetails.TicketId = UnitworkccsTblraisedticket.TicketId;
                //            tblSmsDetails.CellId = item.cellId;
                //            tblSmsDetails.SubCellId = item.subCellId;
                //            tblSmsDetails.SmsPriority = item.smsPriority;
                //            tblSmsDetails.OpNo = item.opNo;
                //            tblSmsDetails.EmployeeName = item.employeeName;
                //            tblSmsDetails.Shift = shift;
                //            tblSmsDetails.CategoryId = item.categoryId;
                //            tblSmsDetails.IsDeleted = 0;
                //            tblSmsDetails.ResponseId = sendSms;
                //            tblSmsDetails.Message = ticketOpenName;
                //            tblSmsDetails.CreatedOn = DateTime.Now;
                //            tblSmsDetails.TimeToBeTriggered = item.timeToBeTriggered;
                //            tblSmsDetails.CorrectedDate = correctedDate;
                //            db.TblSmsDetails.Add(tblSmsDetails);
                //            db.SaveChanges();
                //        }
                //        else
                //        {
                //            TblSmsDetails tblSmsDetails = new TblSmsDetails();
                //            tblSmsDetails.ContactNo = item.contactNo;
                //            tblSmsDetails.MachineId = data.machineId;
                //            tblSmsDetails.TicketId = UnitworkccsTblraisedticket.TicketId;
                //            tblSmsDetails.CellId = item.cellId;
                //            tblSmsDetails.SubCellId = item.subCellId;
                //            tblSmsDetails.SmsPriority = item.smsPriority;
                //            tblSmsDetails.OpNo = item.opNo;
                //            tblSmsDetails.EmployeeName = item.employeeName;
                //            tblSmsDetails.Shift = shift;
                //            tblSmsDetails.CategoryId = item.categoryId;
                //            tblSmsDetails.IsDeleted = 0;
                //            tblSmsDetails.ResponseId = sendSms;
                //            tblSmsDetails.Message = ticketOpenName;
                //            tblSmsDetails.CreatedOn = DateTime.Now;
                //            tblSmsDetails.TimeToBeTriggered = item.timeToBeTriggered;
                //            tblSmsDetails.CorrectedDate = correctedDate;
                //            db.TblSmsDetails.Add(tblSmsDetails);
                //            db.SaveChanges();
                //        }
                //    }
                //}
                #endregion
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

                var check = (from wf in db.UnitworkccsTblsystemconfig
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
                    var dbCheck = (from wf in db.UnitworkccsTblraisedticket
                                   where wf.IsDeleted == 0 && wf.MachineId == machineId
                                   select new
                                   {
                                       TicketId = wf.TicketId,
                                       ClassName = db.UnitworkccsTblclassmaster.Where(m => m.ClassId == wf.ClassId).Select(m => m.ClassName).FirstOrDefault(),
                                       ClassId = wf.ClassId,
                                       StatusName = db.UnitworkccsTblstatusmaster.Where(m => m.StatusId == wf.StatusId).Select(m => m.StatusName).FirstOrDefault(),
                                       StatusId = wf.StatusId,
                                       ReasonId = wf.ReasonId,
                                       ReasonName = db.UnitworkccsTblstoppage.Where(m => m.StoppagesId == wf.ReasonId).Select(m => m.AlramDesc).FirstOrDefault(),
                                       CategoryName = db.UnitworkccsTblcategorymaster.Where(m => m.CategoryId == wf.CategoryId).Select(m => m.CategoryName).FirstOrDefault(),
                                       CategoryId = wf.CategoryId,
                                       TicketNo = wf.TicketNo,
                                       TicketOpenDate = wf.TicketOpenDate,
                                       OperatorId = wf.OperatorId,
                                       status = wf.Status,
                                       machineId = wf.MachineId,
                                       operatorReason = db.UnitworkccsTblticketraiseddet.Where(m => m.TicketId == wf.TicketId).Select(m => m.OpRejectReason).FirstOrDefault()
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
                            var supportTeam = db.UnitworkccsTblticketraiseddet.Where(m => m.TicketId == items.TicketId).FirstOrDefault();
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

                var roleId = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == operatorId).Select(m => m.RoleId).FirstOrDefault();
                var loginTrackerDetails = commonFunction.GetLoginTrackerDetails(correctedDate, machineId, operatorId);

                if (loginTrackerDetails != null)
                {
                    var check = (from wf in db.UnitworkccsTblraisedticket
                                 where roleId == 6 && wf.Status == 3 && wf.MachineId == machineId
                                 select new
                                 {
                                     TicketId = wf.TicketId,
                                     TicketNo = wf.TicketNo,
                                     TicketOpenDate = wf.TicketOpenDate,
                                     ClassName = db.UnitworkccsTblclassmaster.Where(m => m.ClassId == wf.ClassId).Select(m => m.ClassName).FirstOrDefault(),
                                     ClassId = wf.ClassId,
                                     StatusName = db.UnitworkccsTblstatusmaster.Where(m => m.StatusId == wf.StatusId).Select(m => m.StatusName).FirstOrDefault(),
                                     StatusId = wf.StatusId,
                                     ReasonId = wf.ReasonId,
                                     ReasonName = db.UnitworkccsTblstoppage.Where(m => m.StoppagesId == wf.ReasonId).Select(m => m.AlramDesc).FirstOrDefault(),
                                     CategoryName = db.UnitworkccsTblcategorymaster.Where(m => m.CategoryId == wf.CategoryId).Select(m => m.CategoryName).FirstOrDefault(),
                                     CategoryId = wf.CategoryId,
                                     OperatorId = wf.OperatorId,
                                     status = wf.Status,
                                     machineId = wf.MachineId,
                                     operatorName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == wf.OperatorId).Select(m => m.OperatorName).FirstOrDefault(),
                                     machineName = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == wf.MachineId).Select(m => m.MachineName).FirstOrDefault(),
                                     maintainanceName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == db.UnitworkccsTblticketraiseddet.Where(m1 => m1.TicketId == wf.TicketId).Select(m1 => m1.SupportTeamId).FirstOrDefault()).Select(m => m.OperatorName).FirstOrDefault(),
                                     maintainanceTeamAcceptDate = db.UnitworkccsTblticketraiseddet.Where(m => m.TicketId == wf.TicketId).Select(m => m.SupportTeamAckDate).FirstOrDefault(),
                                     maintainanceTeamCloseDate = db.UnitworkccsTblticketraiseddet.Where(m => m.TicketId == wf.TicketId).Select(m => m.SupportTeamClosureDate).FirstOrDefault(),
                                     commentsByOperator = wf.Comments,
                                     maintanceAcceptReason = db.UnitworkccsTblticketraiseddet.Where(m => m.TicketId == wf.TicketId).Select(m => m.MntAcceptReason).FirstOrDefault(),
                                     maintanceClosedReason = db.UnitworkccsTblticketraiseddet.Where(m => m.TicketId == wf.TicketId).Select(m => m.MntRejectReason).FirstOrDefault(),
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
                string ticketName = "";

                var roleId = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == data.operatorId).Select(m => m.RoleId).FirstOrDefault();

                var check = db.UnitworkccsTblticketraiseddet.Where(m => m.TicketId == data.ticketId && roleId == 6 && m.IfSupportTeamOpen == 2).FirstOrDefault();
                if (check != null)
                {
                    //var loginTrackerDetails = commonFunction.GetLoginTrackerDetails(correctedDate, data.machineId, data.operatorId);
                    //if (loginTrackerDetails != null)
                    //{
                    check.IfOperatorAccepts = 1;
                    check.IsStatus = 4; //operator Accepts
                    check.OperatorAcceptRejectDate = DateTime.Now;
                    check.OpAcceptReson = data.reason;
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = "Operator Accepts The Acknowledge";
                    //}

                    //string[] ticketIds = loginTrackerDetails.CurrentTicketRaisedId.Split(',');
                    //List<string> remainedIds = RemoveRejectId(ticketIds, data.ticketId);

                    //#region Update ticket ids

                    //loginTrackerDetails.CurrentTicketRaisedId = null;
                    //db.LoginTrackerDetails.Update(loginTrackerDetails);
                    //db.SaveChanges();
                    //foreach (var ids1 in remainedIds)
                    //{
                    //    loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId + "," + ids1 + ",";
                    //    loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimEnd(',');
                    //    loginTrackerDetails.CurrentTicketRaisedId = loginTrackerDetails.CurrentTicketRaisedId.TrimStart(',');
                    //    db.LoginTrackerDetails.Update(loginTrackerDetails);
                    //    db.SaveChanges();
                    //}

                    //#endregion

                    var dbCheck = db.UnitworkccsTblraisedticket.Where(m => m.TicketId == data.ticketId).FirstOrDefault();
                    if (dbCheck != null)
                    {
                        dbCheck.Status = 4;
                        dbCheck.TicketClosedDate = DateTime.Now;
                        db.SaveChanges();
                    }

                    var statusName = db.UnitworkccsTblstatusmaster.Where(m => m.StatusId == 1).Select(m => m.StatusName).FirstOrDefault();
                    var className = db.UnitworkccsTblclassmaster.Where(m => m.ClassId == dbCheck.ClassId).Select(m => m.ClassName).FirstOrDefault();
                    var machineInvNo = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == dbCheck.MachineId).Select(m => m.MachineName).FirstOrDefault();
                    var reasonName = db.UnitworkccsTblstoppage.Where(m => m.StoppagesId == dbCheck.ReasonId).Select(m => m.AlramDesc).FirstOrDefault();

                    var date = DateTime.Now.ToString("ddMMyyyy");

                    if (statusName == "Running with Issue" && className == "Downtime")
                    {
                        ticketName = className + "-" + statusName + "-" + "BDR" + "-" + machineInvNo + "-" + date;
                    }


                    UnitworkccsTblraisedticket UnitworkccsTblraisedticket = new UnitworkccsTblraisedticket();
                    UnitworkccsTblraisedticket.MachineId = dbCheck.MachineId;
                    UnitworkccsTblraisedticket.OperatorId = dbCheck.OperatorId;
                    UnitworkccsTblraisedticket.TicketNo = ticketName;
                    UnitworkccsTblraisedticket.StatusId = 1;
                    UnitworkccsTblraisedticket.TicketOpenDate = DateTime.Now;
                    UnitworkccsTblraisedticket.CreatedOn = DateTime.Now;
                    UnitworkccsTblraisedticket.ClassId = dbCheck.ClassId;
                    UnitworkccsTblraisedticket.CategoryId = dbCheck.CategoryId;
                    UnitworkccsTblraisedticket.MachineId = dbCheck.MachineId;
                    UnitworkccsTblraisedticket.IsDeleted = 0;
                    UnitworkccsTblraisedticket.ReasonId = dbCheck.ReasonId;
                    UnitworkccsTblraisedticket.Comments = dbCheck.Comments;
                    UnitworkccsTblraisedticket.CorrectedDate = dbCheck.CorrectedDate;
                    UnitworkccsTblraisedticket.AlarmId = dbCheck.AlarmId;
                    UnitworkccsTblraisedticket.RoleId = dbCheck.RoleId;
                    UnitworkccsTblraisedticket.Status = 1; //Ticket Opened
                    db.UnitworkccsTblraisedticket.Add(UnitworkccsTblraisedticket);
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.AddedSuccessMessage;

                    UnitworkccsTblticketraiseddet UnitworkccsTblticketraiseddet = new UnitworkccsTblticketraiseddet();
                    UnitworkccsTblticketraiseddet.TicketId = UnitworkccsTblraisedticket.TicketId;
                    UnitworkccsTblticketraiseddet.OperatorId = UnitworkccsTblraisedticket.OperatorId;
                    UnitworkccsTblticketraiseddet.IsDeleted = 0;
                    UnitworkccsTblticketraiseddet.MachineId = UnitworkccsTblraisedticket.MachineId;
                    UnitworkccsTblticketraiseddet.IsStatus = 1;
                    UnitworkccsTblticketraiseddet.TicketNo = UnitworkccsTblraisedticket.TicketNo;
                    UnitworkccsTblticketraiseddet.CreatedOn = DateTime.Now;
                    db.UnitworkccsTblticketraiseddet.Add(UnitworkccsTblticketraiseddet);
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.AddedSuccessMessage;

                    #region sms integration

                    var currentFgpart = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == data.machineId).OrderByDescending(m => m.FgPartId).Select(m => m.PlanLinkageId).FirstOrDefault();

                    var partNo = db.UnitworkccsTblplanlinkagemaster.Where(m => m.PlanLinkageId == currentFgpart).Select(m => m.FgPartNo).FirstOrDefault();

                    var cellId = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.CellFinalId).FirstOrDefault();

                    var subCellId = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == partNo).Select(m => m.SubCellFinalId).FirstOrDefault();

                    //var maintainance = (from wf in db.TblEscalationMatrix
                    //                    where wf.Shift == shift && (wf.CellId == cellId || wf.CellId == 0) && (wf.SubCellId == subCellId || wf.SubCellId == 0) && wf.CategoryId == dbCheck.CategoryId && wf.TimeToBeTriggered == 0 && wf.SmsPriority == 1 && wf.IsDeleted == 0 && (wf.Role == "Line inspectors" || wf.Role == "Quality incharge" || wf.Role == "cell incharge" || wf.Role == "supervisor" || wf.Role == "Toolstores" || wf.Role == "Setter" || wf.Role == "Tool store incharge" || wf.Role == "PPC incharge" || wf.Role == "Maintainance")
                    //                    select new
                    //                    {
                    //                        contactNo = wf.ContactNo,
                    //                        smsPriority = wf.SmsPriority,
                    //                        cellId = wf.CellId,
                    //                        subCellId = wf.SubCellId,
                    //                        employeeName = wf.EmployeeName,
                    //                        categoryId = wf.CategoryId,
                    //                        timeToBeTriggered = wf.TimeToBeTriggered,
                    //                        opNo = wf.OpNo
                    //                    }).ToList();

                    //foreach (var item in maintainance)
                    //{
                    //    DateTime tktOpDate = Convert.ToDateTime(UnitworkccsTblraisedticket.TicketOpenDate);
                    //    string ticketOpenDatTime = tktOpDate.ToString("HH:mm");
                    //    string ticketOpenName = "BD Alert!!\n" + machineInvNo + "," + ticketOpenDatTime + ",\n" + "Ticket Status" + "-" + "Open\n" + "Status" + " " + "-" + statusName + "-" + "BDR\n" + "Reason" + " " + "-" + reasonName + "\n" + "I-FACILITY";
                    //    //var contactNo = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == data.operatorId).Select(m => m.ContactNo).FirstOrDefault();
                    //    string sendSms = commonFunction.SMSEscalationSendPostURLEncode("12", item.contactNo, ticketOpenName, appSettings.SmsKey, appSettings.SmsDetailsPost);

                    //    if (sendSms != null)
                    //    {
                    //        var dbCheck1 = db.TblSmsDetails.Where(m => m.Shift == shift && m.CellId == item.cellId && m.SubCellId == item.subCellId && m.SmsPriority == item.smsPriority && m.OpNo == item.opNo && m.CorrectedDate == correctedDate && m.TimeToBeTriggered == 0 && m.CategoryId == item.categoryId).FirstOrDefault();
                    //        if (dbCheck1 == null)
                    //        {
                    //            TblSmsDetails tblSmsDetails = new TblSmsDetails();
                    //            tblSmsDetails.ContactNo = item.contactNo;
                    //            tblSmsDetails.MachineId = data.machineId;
                    //            tblSmsDetails.TicketId = UnitworkccsTblraisedticket.TicketId;
                    //            tblSmsDetails.CellId = item.cellId;
                    //            tblSmsDetails.SubCellId = item.subCellId;
                    //            tblSmsDetails.SmsPriority = item.smsPriority;
                    //            tblSmsDetails.OpNo = item.opNo;
                    //            tblSmsDetails.EmployeeName = item.employeeName;
                    //            tblSmsDetails.Shift = shift;
                    //            tblSmsDetails.CategoryId = item.categoryId;
                    //            tblSmsDetails.IsDeleted = 0;
                    //            tblSmsDetails.ResponseId = sendSms;
                    //            tblSmsDetails.Message = ticketOpenName;
                    //            tblSmsDetails.CreatedOn = DateTime.Now;
                    //            tblSmsDetails.TimeToBeTriggered = item.timeToBeTriggered;
                    //            tblSmsDetails.CorrectedDate = correctedDate;
                    //            db.TblSmsDetails.Add(tblSmsDetails);
                    //            db.SaveChanges();
                    //        }
                    //        else
                    //        {
                    //            TblSmsDetails tblSmsDetails = new TblSmsDetails();
                    //            tblSmsDetails.ContactNo = item.contactNo;
                    //            tblSmsDetails.MachineId = data.machineId;
                    //            tblSmsDetails.TicketId = UnitworkccsTblraisedticket.TicketId;
                    //            tblSmsDetails.CellId = item.cellId;
                    //            tblSmsDetails.SubCellId = item.subCellId;
                    //            tblSmsDetails.SmsPriority = item.smsPriority;
                    //            tblSmsDetails.OpNo = item.opNo;
                    //            tblSmsDetails.EmployeeName = item.employeeName;
                    //            tblSmsDetails.Shift = shift;
                    //            tblSmsDetails.CategoryId = item.categoryId;
                    //            tblSmsDetails.IsDeleted = 0;
                    //            tblSmsDetails.ResponseId = sendSms;
                    //            tblSmsDetails.Message = ticketOpenName;
                    //            tblSmsDetails.CreatedOn = DateTime.Now;
                    //            tblSmsDetails.TimeToBeTriggered = item.timeToBeTriggered;
                    //            tblSmsDetails.CorrectedDate = correctedDate;
                    //            db.TblSmsDetails.Add(tblSmsDetails);
                    //            db.SaveChanges();
                    //        }
                    //    }
                    //}
                    #endregion
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
