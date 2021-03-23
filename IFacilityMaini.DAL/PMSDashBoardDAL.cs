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
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.PMSDashBoardEntity;

namespace IFacilityMaini.DAL
{
    public class PMSDashBoardDAL : IPMSDashBoard
    {
        unitworksccsContext db = new unitworksccsContext();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(PMSDashBoardDAL));
        public static IConfiguration configuration;
        private readonly AppSettings appSettings;

        public PMSDashBoardDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings)
        {
            db = _db;
            configuration = _configuration;
            appSettings = _appSettings.Value;
        }
        public CommonResponse ApproveCheckList(approveDetPM data)
        {
            CommonResponse obj = new CommonResponse();
            CommonFunction commonFunction = new CommonFunction();
            try
            {

                var check = db.UnitworkccsTblchecklistHeader.Where(m => m.HeaderId == data.headerId && m.IsDeleted == 0).FirstOrDefault();
                if (check != null)
                {
                    var checkDet = db.UnitworkccsTblchecklistDetails.Where(m => m.CheckListId == data.checkListId && m.IsDeleted == 0 && m.HeaderId == data.headerId && m.RoleId == data.roleId).FirstOrDefault();
                    if (checkDet != null)
                    {
                        // checkDet.IsOk = data.isOk;

                        if (data.isOk == "1")
                        {
                            checkDet.IsDashBoardEntry = 1;

                        }
                        else if (data.isOk == "0")
                        {
                            checkDet.IsDashBoardEntry = 0;
                        }
                        else
                        {
                            checkDet.IsDashBoardEntry = null;
                        }
                        checkDet.Comment = data.comment;
                        checkDet.IsApproved = 1;

                        checkDet.NumericValue = data.numericValue;
                        checkDet.TextValue = data.textValue;
                        // checkDet.IsDashBoardEntry = 1;

                        db.SaveChanges();
                        check.ApprovedBy = data.approverId;

                        check.CreationDate = DateTime.Now;
                        check.LastRevDate = DateTime.Now;
                        check.ApprovedByDate = DateTime.Now;

                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;
                    }
                    else
                    {
                        obj.isStatus = false;
                        obj.response = "checkList Id not found";
                    }
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = "Header Id not found";

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
        public CommonResponse ViewMultipleCheckListHeaderPMS()
        {
            CommonResponse obj = new CommonResponse();
            CommonFunction commonFunction = new CommonFunction();
            try
            {

                List<viewHeadersPM> ViewHeaderList = new List<viewHeadersPM>();


                var CKmachines = db.UnitworkccsTblChecklistmachines.Where(m => m.IsDeleted == 0).ToList();


                if (CKmachines.Count > 0)
                {

                    foreach (var item in CKmachines)
                    {

                        var items = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.HeaderId == item.CheckListHeaderId && m.IsPrepared == 1).FirstOrDefault();
                        if (items != null)
                        {



                            viewHeadersPM ViewHeader1 = new viewHeadersPM();

                            ViewHeader1.headerId = items.HeaderId;
                            //ViewHeader1.plantId = (int)items.PlantId;
                            //ViewHeader1.plantName = items.PlantName;
                            //ViewHeader1.plantCode = db.Tblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();
                            ViewHeader1.id = items.HeaderId;
                            ViewHeader1.categoryId = (int)items.CategoryId;
                            ViewHeader1.categoryName = items.CategoryName;
                            ViewHeader1.makeId = (int)items.MakeId;
                            ViewHeader1.makeName = items.MakeName;

                            if (items.CreationDate == null)
                            {
                                ViewHeader1.creationDate = null;
                            }

                            else
                            {
                                DateTime cdate = (DateTime)items.CreationDate;

                                ViewHeader1.showCreationDate = cdate.ToString("dd-MM-yyyy");
                                ViewHeader1.creationDate = cdate.ToString("yyyy-MM-dd");
                            }

                            ViewHeader1.revNo = items.RevNo;



                            if (items.LastRevDate == null)
                            {
                                ViewHeader1.lastRevDate = null;
                            }

                            else
                            {
                                DateTime rvdate = (DateTime)items.LastRevDate;
                                ViewHeader1.showLastRevDate = rvdate.ToString("dd-MM-yyyy");

                                ViewHeader1.lastRevDate = rvdate.ToString("yyyy-MM-dd");

                            }


                            //  ViewHeader1.checkListNo = items.CheckListNo + items.HeaderId;
                            ViewHeader1.checkListNo = items.CheckListNo;
                            ViewHeader1.preparedBy = (int)items.PreparedBy;
                            ViewHeader1.preparedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
                            if (items.PreparedByDate == null)
                            {
                                ViewHeader1.preparedByDate = null;
                            }

                            else
                            {
                                DateTime pdate = (DateTime)items.PreparedByDate;
                                ViewHeader1.showPreparedByDate = pdate.ToString("dd-MM-yyyy");
                                ViewHeader1.preparedByDate = pdate.ToString("yyyy-MM-dd");


                            }


                            ViewHeader1.approvedBy = items.ApprovedBy;
                            ViewHeader1.approvedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

                            if (items.ApprovedByDate == null)
                            {
                                ViewHeader1.approvedByDate = null;
                            }

                            else
                            {
                                DateTime adate = (DateTime)items.ApprovedByDate;
                                ViewHeader1.showApprovedByDate = adate.ToString("dd-MM-yyyy");
                                ViewHeader1.approvedByDate = adate.ToString("yyyy-MM-dd");

                            }

                            // ViewHeader1.isApproved = items.IsApproved;
                            ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
                            ViewHeader1.preparedLogin = 0;
                            ViewHeader1.approvedLogin = 1;


                            ViewHeaderList.Add(ViewHeader1);




                        }


                    }

                    if (ViewHeaderList.Count > 0)
                    {
                        obj.isStatus = true;
                        obj.response = ViewHeaderList;
                    }
                    else
                    {
                        obj.isStatus = false;
                        obj.response = ResourceResponse.NoItemsFound;
                    }

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
        public CommonResponse ViewMultipleCheckListDetailsPMS(int headerId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                List<ViewCheckListPM> ViewCheckedListDet = new List<ViewCheckListPM>();
                var tblDet = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == headerId).ToList();
                if (tblDet.Count > 0)
                {
                    foreach (var items in tblDet)
                    {
                        ViewCheckListPM ViewChecklist = new ViewCheckListPM();
                        ViewChecklist.checkListId = items.CheckListId;
                        ViewChecklist.headerId = (int)items.HeaderId;
                        ViewChecklist.whatToCheck = items.WhatToCheck;
                        ViewChecklist.whoWillDo = db.UnitworkccsTblroles.Where(m => m.RoleId == items.RoleId).Select(m => m.RoleName).FirstOrDefault();
                        //   ViewChecklist.how = items.How;

                        if (items.How != null)
                        {
                            string[] howSplite = items.How.Split(',');

                            ViewChecklist.how = howSplite;

                        }
                        else
                        {
                            ViewChecklist.how = new string[] { };
                        }

                        ViewChecklist.frequency = items.Frequency;
                        ViewChecklist.runningHrs = items.RunningHrs;
                        ViewChecklist.partsCount = (int)items.PartsCount;
                        ViewChecklist.periodFrequency = items.PeriodFrequency;
                        ViewChecklist.isNumeric =Convert.ToBoolean( items.IsNumeric);
                        ViewChecklist.isText = Convert.ToBoolean(items.IsText);
                        ViewChecklist.roleId = items.RoleId;
                        ViewChecklist.roleName = db.UnitworkccsTblroles.Where(m => m.RoleId == items.RoleId).Select(m => m.RoleName).FirstOrDefault();
                        // ViewChecklist.ok = items.IsOk;
                        if (items.IsOk == "OK")
                        {
                            ViewChecklist.ok = "1";
                        }
                        else if (items.IsOk == "NOTOK")
                        {
                            ViewChecklist.ok = "0";
                            ViewChecklist.comment = items.Comment;
                        }
                        else
                        {
                            ViewChecklist.ok = null;
                        }

                        if (items.Date != "")
                        {
                            string[] datesplite = items.Date.Split(',');
                            ViewChecklist.dateList = datesplite;
                            string[] showdate;

                            List<string> datelist = new List<string>();
                            foreach (var dt in datesplite)
                            {
                                DateTime ddtt = Convert.ToDateTime(dt);
                                string dt1 = ddtt.ToString("dd-MM-yyyy");

                                datelist.Add(dt1);
                                //savedate += dt1 + ",";

                            }
                            showdate = datelist.ToArray();
                            ViewChecklist.showDateList = showdate;
                        }
                        else
                        {
                            ViewChecklist.showDateList = new string[] { };
                        }

                        ViewChecklist.isDashBoardOk = items.IsDashBoardEntry;
                        ViewChecklist.numericVlaue = items.NumericValue;
                        ViewChecklist.textValue = items.TextValue;
                        ViewCheckedListDet.Add(ViewChecklist);
                    }

                    if (ViewCheckedListDet.Count > 0)
                    {
                        obj.isStatus = true;
                        obj.response = ViewCheckedListDet;
                    }
                    else
                    {
                        obj.isStatus = false;
                        obj.response = ResourceResponse.NoItemsFound;
                    }

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
    }
}
