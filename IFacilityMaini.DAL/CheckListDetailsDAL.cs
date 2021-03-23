using IFacilityMaini.DAL.App_Start;
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
using System.Text;
using static IFacilityMaini.EntityModels.CheckListDetailsEntity;
using static IFacilityMaini.EntityModels.CommonEntity;


namespace IFacilityMaini.DAL
{
    public class CheckListDetailsDAL : ICheckListDetails
    {
        unitworksccsContext db = new unitworksccsContext();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(CheckListDetailsDAL));
        public static IConfiguration configuration;
        private readonly AppSettings appSettings;

        public CheckListDetailsDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings)
        {
            db = _db;
            configuration = _configuration;
            appSettings = _appSettings.Value;
        }

        public CommonResponse AddAndEditCheckListDetails(addCheckList data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                if (data.flag == 0)
                {
                    var check = db.UnitworkccsTblchecklistDetails.Where(m => m.CheckListId == data.CheckListId && m.HeaderId == data.HeaderId && m.IsDeleted == 0).FirstOrDefault();
                    if (check == null)
                    {
                        UnitworkccsTblchecklistDetails tblCheckList = new UnitworkccsTblchecklistDetails();
                        tblCheckList.HeaderId = data.HeaderId;
                        tblCheckList.WhatToCheck = data.WhatToCheck;
                        tblCheckList.How = data.How;
                        tblCheckList.Frequency = data.Frequency;
                        tblCheckList.RunningHrs = data.RunningHrs;
                        tblCheckList.PartsCount = data.PartsCount;
                        tblCheckList.PeriodFrequency = data.PeriodFrequency;
                        tblCheckList.IsNumeric = Convert.ToByte(data.isNumeric);
                        tblCheckList.IsText = Convert.ToByte(data.isText);
                        tblCheckList.RoleId = data.roleId;
                        tblCheckList.IsEdited = 0;
                        tblCheckList.IsPrepared = 0;
                        tblCheckList.IsApproved = 0;

                        if (data.Date != "")
                        {
                            string[] datesplite = data.Date.Split(',');
                            string savedate = "";
                            foreach (var dt in datesplite)
                            {
                                DateTime ddtt = Convert.ToDateTime(dt);
                                string dt1 = ddtt.ToString("yyyy-MM-dd");

                                savedate += dt1 + ",";

                            }
                            savedate = savedate.TrimEnd(',');
                            tblCheckList.Date = savedate;
                        }
                        else
                        {
                            tblCheckList.Date = data.Date;
                        }

                        tblCheckList.IsDeleted = 0;
                        tblCheckList.CreatedOn = DateTime.Now;
                        db.UnitworkccsTblchecklistDetails.Add(tblCheckList);
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;
                    }
                    else
                    {
                        check.HeaderId = data.HeaderId;
                        check.WhatToCheck = data.WhatToCheck;
                        check.How = data.How;
                        check.Frequency = data.Frequency;
                        check.RunningHrs = data.RunningHrs;
                        check.PartsCount = data.PartsCount;
                        check.PeriodFrequency = data.PeriodFrequency;
                        check.IsNumeric = Convert.ToByte(data.isNumeric);
                        check.IsText = Convert.ToByte(data.isText);
                        check.RoleId = data.roleId;
                        if (check.IsOk == "NOTOK")
                        {
                            check.IsEdited = 1;
                        }
                        else
                        {
                            check.IsEdited = 0;
                        }
                        check.IsPrepared = 0;

                        if (data.Date != "")
                        {
                            string[] datesplite = data.Date.Split(',');
                            string savedate = "";
                            foreach (var dt in datesplite)
                            {
                                DateTime ddtt = Convert.ToDateTime(dt);
                                string dt1 = ddtt.ToString("yyyy-MM-dd");
                                savedate += dt1 + ",";
                            }
                            savedate = savedate.TrimEnd(',');
                            check.Date = savedate;
                        }
                        check.Date = data.Date;
                        //  check.Date =data.Date;

                        check.IsDeleted = 0;
                        check.ModifiedOn = DateTime.Now;
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.UpdatedSuccessMessage;
                    }
                }
                else
                {
                    var checkList = db.Tblchecklistdetailsnew.Where(m => m.CheckListId == data.CheckListId).FirstOrDefault();
                    if (checkList == null)
                    {
                        Tblchecklistdetailsnew tblCheckListDetailsNew = new Tblchecklistdetailsnew();
                        tblCheckListDetailsNew.CheckListId = data.CheckListId;
                        tblCheckListDetailsNew.WhatToCheck = data.WhatToCheck;
                        tblCheckListDetailsNew.How = data.How;
                        tblCheckListDetailsNew.Frequency = data.Frequency;
                        tblCheckListDetailsNew.RunningHrs = data.RunningHrs;
                        tblCheckListDetailsNew.PartsCount = data.PartsCount;
                        tblCheckListDetailsNew.PeriodFrequency = data.PeriodFrequency;
                        tblCheckListDetailsNew.IsNumeric = Convert.ToByte(data.isNumeric);
                        tblCheckListDetailsNew.IsText = Convert.ToByte(data.isText);
                        tblCheckListDetailsNew.RoleId = data.roleId;
                        tblCheckListDetailsNew.CreatedOn = DateTime.Now;
                        tblCheckListDetailsNew.AddEdit = data.addEdit;
                        if (data.Date != "")
                        {
                            string[] datesplite = data.Date.Split(',');
                            string savedate = "";
                            foreach (var dt in datesplite)
                            {
                                DateTime ddtt = Convert.ToDateTime(dt);
                                string dt1 = ddtt.ToString("yyyy-MM-dd");

                                savedate += dt1 + ",";
                            }
                            savedate = savedate.TrimEnd(',');
                            tblCheckListDetailsNew.Date = savedate;
                        }
                        tblCheckListDetailsNew.Date = data.Date;
                        tblCheckListDetailsNew.IsDeleted = 0;
                        tblCheckListDetailsNew.ModifiedOn = DateTime.Now;
                        tblCheckListDetailsNew.Flag = data.flag;
                        db.Tblchecklistdetailsnew.Add(tblCheckListDetailsNew);
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.UpdatedSuccessMessage;
                    }
                    else
                    {
                        checkList.CheckListId = data.CheckListId;
                        checkList.WhatToCheck = data.WhatToCheck;
                        checkList.How = data.How;
                        checkList.Frequency = data.Frequency;
                        checkList.RunningHrs = data.RunningHrs;
                        checkList.PartsCount = data.PartsCount;
                        checkList.PeriodFrequency = data.PeriodFrequency;
                        checkList.IsNumeric = Convert.ToByte(data.isNumeric);
                        checkList.IsText = Convert.ToByte(data.isText);
                        checkList.RoleId = data.roleId;
                        checkList.AddEdit = data.addEdit;
                        if (data.Date != "")
                        {
                            string[] datesplite = data.Date.Split(',');
                            string savedate = "";
                            foreach (var dt in datesplite)
                            {
                                DateTime ddtt = Convert.ToDateTime(dt);
                                string dt1 = ddtt.ToString("yyyy-MM-dd");

                                savedate += dt1 + ",";

                            }
                            savedate = savedate.TrimEnd(',');
                            checkList.Date = savedate;
                        }
                        checkList.Date = data.Date;
                        //  check.Date =data.Date;

                        checkList.IsDeleted = 0;
                        checkList.ModifiedOn = DateTime.Now;
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

        public CommonResponse ViewMultipleCheckListDetails()
        {

            CommonResponse obj = new CommonResponse();
            try
            {
                List<ViewCheckList> ViewCheckedListDet = new List<ViewCheckList>();

                var tblDet = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0).ToList();

                foreach (var items in tblDet)
                {

                    ViewCheckList ViewChecklist = new ViewCheckList();
                    ViewChecklist.checkListId = items.CheckListId;
                    ViewChecklist.headerId = (int)items.HeaderId;
                    ViewChecklist.whatToCheck = items.WhatToCheck;
                    ViewChecklist.isNumeric = Convert.ToBoolean(items.IsNumeric);
                    ViewChecklist.isText = Convert.ToBoolean(items.IsText);
                    ViewChecklist.roleId = items.RoleId;
                    ViewChecklist.roleName = db.UnitworkccsTblroles.Where(m => m.RoleId == items.RoleId).Select(m => m.RoleName).FirstOrDefault();

                    string[] howSplite = items.How.Split(',');

                    ViewChecklist.how = howSplite;

                    // ViewChecklist.how = items.How;
                    ViewChecklist.frequency = items.Frequency;
                    ViewChecklist.runningHrs = items.RunningHrs;
                    ViewChecklist.partsCount = (int)items.PartsCount;
                    ViewChecklist.periodFrequency = items.PeriodFrequency;

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
                    // ddd.dateArray = items.Date;

                    // List<date> dddlist = new List<date>();

                    string[] datesplite = items.Date.Split(',');
                    ViewChecklist.dateList = datesplite;

                    // string[] datesplite = data.Date.Split(',');
                    //  string showdate = "";
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


                    // date[] ddd = datesplite;

                    //foreach (var dd in datesplite)
                    //{
                    //    date ddd = new date();
                    //    ddd.dateArray = dd;
                    //    string[] dddlist = ddd;
                    //   // dddlist.Add(ddd);
                    //}

                    //if (items.Date == null)
                    //{
                    //    ViewChecklist.date =null;
                    //}
                    //else
                    //{
                    //    DateTime dt = (DateTime)items.Date;
                    //    string date1 = dt.ToString("yyyy-MM-dd");
                    //    ViewChecklist.date = date1;

                    //}

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
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        public CommonResponseWithStatus ViewMultipleCheckListDetailsByHeaderId(int headerId)
        {
            CommonResponseWithStatus obj = new CommonResponseWithStatus();
            try
            {
                List<ViewCheckList> ViewCheckedListDet = new List<ViewCheckList>();
                obj.ovarallStatus = true;
                var tblDet = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == headerId).ToList();
                if (tblDet.Count > 0)
                {
                    var okList = db.UnitworkccsTblchecklistDetails.Where(m => m.HeaderId == headerId && m.IsOk == "OK").ToList();
                    int okCount = okList.Count();

                    var notOkList = db.UnitworkccsTblchecklistDetails.Where(m => m.HeaderId == headerId && m.IsOk == "NOTOK").ToList();
                    int notOkCount = notOkList.Count();

                    if (notOkCount > 0)
                    {
                        obj.ovarallStatus = false;
                    }

                    foreach (var items in tblDet)
                    {
                        ViewCheckList ViewChecklist = new ViewCheckList();
                        ViewChecklist.checkListId = items.CheckListId;
                        ViewChecklist.headerId = (int)items.HeaderId;
                        ViewChecklist.whatToCheck = items.WhatToCheck;

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
                        ViewChecklist.isNumeric = Convert.ToBoolean(items.IsNumeric);
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
                            }

                            showdate = datelist.ToArray();
                            ViewChecklist.showDateList = showdate;
                        }
                        else
                        {
                            ViewChecklist.showDateList = new string[] { };
                        }

                        ViewCheckedListDet.Add(ViewChecklist);
                    }
                }
                else
                {

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
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }



        public CommonResponseWithStatus ForREVIconViewMultipleCheckListDetailsByHeaderId(int headerId)
        {
            CommonResponseWithStatus obj = new CommonResponseWithStatus();
            try
            {
                REVIconViewCheckList AllResult = new REVIconViewCheckList();
                //List<REVIconViewCheckList> ViewCheckedListDet = new List<REVIconViewCheckList>();
                obj.ovarallStatus = true;

                var currnHdrCK = db.Tblchecklistdetailsnew.Where(m => m.HeaderId == headerId && m.IsDeleted==0).FirstOrDefault();
                if (currnHdrCK != null)
                {

                    if (currnHdrCK.CheckListId != 0)
                    {
                        var prev = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.CheckListId == currnHdrCK.CheckListId).FirstOrDefault();
                        if (prev != null)
                        {
                            REVIconViewCheckListCur ViewChecklistCurt = new REVIconViewCheckListCur();

                            REVIconViewCheckListPre ViewChecklistPrev = new REVIconViewCheckListPre();
                           
                            ViewChecklistCurt.headerId = (int)currnHdrCK.HeaderId;
                            ViewChecklistPrev.headerId = (int)prev.HeaderId;

                            ViewChecklistCurt.checkListId = (int)currnHdrCK.CheckListNewId;
                            ViewChecklistPrev.checkListId = (int)prev.CheckListId;


                            if (currnHdrCK.WhatToCheck != prev.WhatToCheck)
                            {
                                ViewChecklistCurt.whatToCheck = currnHdrCK.WhatToCheck;
                                ViewChecklistPrev.whatToCheck = prev.WhatToCheck;
                            }
                            else
                            {

                            }

                            if (currnHdrCK.How != prev.How)
                            {


                                if (currnHdrCK.How != null)
                                {
                                    string[] howSpliteCur = currnHdrCK.How.Split(',');
                                    ViewChecklistCurt.how = howSpliteCur;
                                }
                                else
                                {
                                    ViewChecklistCurt.how = new string[] { };
                                }
                                if (prev.How != null)
                                {
                                    string[] howSplitePre = prev.How.Split(',');
                                    ViewChecklistPrev.how = howSplitePre;
                                }
                                else
                                {
                                    ViewChecklistPrev.how = new string[] { };
                                }

                            }
                            else
                            {

                            }




                            if (currnHdrCK.RoleId != prev.RoleId)
                            {
                                ViewChecklistCurt.roleId = currnHdrCK.RoleId;
                                ViewChecklistCurt.roleName = db.UnitworkccsTblroles.Where(m => m.RoleId == currnHdrCK.RoleId).Select(m => m.RoleName).FirstOrDefault();

                                ViewChecklistPrev.roleId = prev.RoleId;
                                ViewChecklistPrev.roleName = db.UnitworkccsTblroles.Where(m => m.RoleId == prev.RoleId).Select(m => m.RoleName).FirstOrDefault();

                            }
                            else
                            {

                            }

                            if (currnHdrCK.Frequency != prev.Frequency)
                            {
                                ViewChecklistCurt.frequency = currnHdrCK.Frequency;
                                ViewChecklistPrev.frequency = prev.Frequency;
                            }
                            else
                            {

                            }

                            if (currnHdrCK.RunningHrs != prev.RunningHrs)
                            {
                                ViewChecklistCurt.runningHrs = currnHdrCK.RunningHrs;
                                ViewChecklistPrev.runningHrs = prev.RunningHrs;
                            }
                            else
                            {

                            }

                            if (currnHdrCK.PartsCount != prev.PartsCount)
                            {
                                ViewChecklistCurt.partsCount = (int)currnHdrCK.PartsCount;
                                ViewChecklistPrev.partsCount = (int)prev.PartsCount;
                            }
                            else
                            {

                            }

                            if (currnHdrCK.PeriodFrequency != prev.PeriodFrequency)
                            {
                                ViewChecklistCurt.periodFrequency = currnHdrCK.PeriodFrequency;
                                ViewChecklistPrev.periodFrequency = prev.PeriodFrequency;
                            }
                            else
                            {

                            }

                            if (currnHdrCK.IsNumeric != prev.IsNumeric)
                            {
                                ViewChecklistCurt.isNumeric = Convert.ToBoolean(currnHdrCK.IsNumeric);
                                ViewChecklistPrev.isNumeric = Convert.ToBoolean(prev.IsNumeric);
                            }
                            else
                            {

                            }


                            if (currnHdrCK.IsText != prev.IsText)
                            {
                                ViewChecklistCurt.isText = Convert.ToBoolean(currnHdrCK.IsText);
                                ViewChecklistPrev.isText = Convert.ToBoolean(prev.IsText);
                            }
                            else
                            {

                            }


                            if (currnHdrCK.Date != prev.Date)
                            {
                                if (!string.IsNullOrEmpty(currnHdrCK.Date))
                                {
                                    string[] datespliteCur = currnHdrCK.Date.Split(',');
                                    ViewChecklistCurt.dateList = datespliteCur;
                                    string[] showdate;

                                    List<string> datelist = new List<string>();
                                    foreach (var dt in datespliteCur)
                                    {
                                        DateTime ddtt = Convert.ToDateTime(dt);
                                        string dt1 = ddtt.ToString("dd-MM-yyyy");

                                        datelist.Add(dt1);
                                    }

                                    showdate = datelist.ToArray();
                                    ViewChecklistCurt.showDateList = showdate;
                                }
                                else
                                {
                                    ViewChecklistCurt.dateList = new string[] { };
                                    ViewChecklistCurt.showDateList = new string[] { };
                                }

                                if (!string.IsNullOrEmpty(prev.Date))
                                {
                                    string[] datesplitepre = prev.Date.Split(',');
                                    ViewChecklistPrev.dateList = datesplitepre;
                                    string[] showdate;

                                    List<string> datelist = new List<string>();
                                    foreach (var dt in datesplitepre)
                                    {
                                        DateTime ddtt = Convert.ToDateTime(dt);
                                        string dt1 = ddtt.ToString("dd-MM-yyyy");

                                        datelist.Add(dt1);
                                    }

                                    showdate = datelist.ToArray();
                                    ViewChecklistPrev.showDateList = showdate;
                                }
                                else
                                {
                                    ViewChecklistPrev.dateList = new string[] { };
                                    ViewChecklistPrev.showDateList = new string[] { };
                                }



                            }
                            else
                            {

                            }

                            AllResult.currentList = ViewChecklistCurt;
                            AllResult.previousList = ViewChecklistPrev;




                        }
                        else
                        {

                        }
                    }

                    else
                    {

                    }

                }
                else
                { 
                
                }

                if (AllResult!=null )
                {
                    obj.isStatus = true;
                    obj.response = AllResult;
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


        public CommonResponse ViewCheckListById(int id)
        {

            CommonResponse obj = new CommonResponse();
            try
            {

                var items = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.CheckListId == id).FirstOrDefault();

                ViewCheckList ViewChecklist = new ViewCheckList();
                ViewChecklist.checkListId = items.CheckListId;
                ViewChecklist.headerId = (int)items.HeaderId;
                ViewChecklist.whatToCheck = items.WhatToCheck;
                // ViewChecklist.how = items.How;

                string[] howSplite = items.How.Split(',');

                ViewChecklist.how = howSplite;

                ViewChecklist.frequency = items.Frequency;
                ViewChecklist.runningHrs = items.RunningHrs;
                ViewChecklist.partsCount = (int)items.PartsCount;
                ViewChecklist.periodFrequency = items.PeriodFrequency;
                ViewChecklist.isNumeric = Convert.ToBoolean(items.IsNumeric);
                ViewChecklist.isText = Convert.ToBoolean(items.IsText);
                ViewChecklist.roleId = items.RoleId;
                ViewChecklist.roleName = db.UnitworkccsTblroles.Where(m => m.RoleId == items.RoleId).Select(m => m.RoleName).FirstOrDefault();

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
                // string[] datesplite = items.Date.Split(',');
                // ViewChecklist.dateList = datesplite;



                string[] datesplite = items.Date.Split(',');
                ViewChecklist.dateList = datesplite;

                // string[] datesplite = data.Date.Split(',');
                //  string showdate = "";
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


                //string[] datesplite = items.Date.Split(',');

                //foreach (var dd in datesplite)
                //{
                //    date ddd = new date();
                //    ddd.dateArray = dd;
                //    dddlist.Add(ddd);
                //}
                //ViewChecklist.dateList = dddlist;

                // ViewChecklist.dateList.dateArray = items.Date;

                //if (items.Date == null)
                //{
                //    ViewChecklist.date = null;
                //}
                //else
                //{
                //    DateTime dt = (DateTime)items.Date;
                //    string date1 = dt.ToString("yyyy-mm-dd");
                //    ViewChecklist.date = date1;

                //}

                if (ViewChecklist != null)
                {
                    obj.isStatus = true;
                    obj.response = ViewChecklist;
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

        public CommonResponse DeleteCheckListDetails(int id)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTblchecklistDetails.Where(m => m.CheckListId == id && m.IsDeleted == 0).FirstOrDefault();
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

        //public CommonResponse ApprovedCheckList(approveDet data)
        //{
        //    CommonResponse obj = new CommonResponse();
        //    CommonFunction commonFunction = new CommonFunction();
        //    try
        //    {

        //        var check = db.TblCheckListHeader.Where(m => m.HeaderId == data.HeaderId && m.IsDeleted == 0).FirstOrDefault();
        //        if (check != null)
        //        {

        //            string[] checklist = data.checkListIds.Split(',');
        //            int count1 = checklist.Count();

        //            string[] okIdSplite = data.okIds.Split(',');
        //            int count2 = okIdSplite.Count();


        //            string[] notOkIdSplite = data.notOkIds.Split(',');

        //            if (!string.IsNullOrEmpty(data.okIds))
        //            {
        //                foreach (var ok in okIdSplite)
        //                {
        //                    int okid = Convert.ToInt32(ok);
        //                    var checkDet = db.TblCheckListDetails.Where(m => m.CheckListId == okid).FirstOrDefault();
        //                    checkDet.IsOk = "ok";
        //                    db.SaveChanges();

        //                }
        //                if (count1 == count2)
        //                {
        //                    check.IsApproved = 1;


        //                }

        //            }

        //            if (!string.IsNullOrEmpty(data.notOkIds))
        //            {
        //                foreach (var notok in notOkIdSplite)
        //                {
        //                    int notokid = Convert.ToInt32(notok);
        //                    var checkDet = db.TblCheckListDetails.Where(m => m.CheckListId == notokid).FirstOrDefault();
        //                    checkDet.IsOk = "not ok";
        //                    db.SaveChanges();

        //                }

        //            }



        //             check.ApprovedBy = data.approverId;

        //            check.CreationDate = DateTime.Now;
        //            check.LastRevDate = DateTime.Now;
        //            check.ApprovedByDate = DateTime.Now;
        //           // check.ApprovedByDate =Convert.ToDateTime(data.approvedDate);
        //            db.SaveChanges();
        //            obj.isStatus = true;
        //            obj.response = ResourceResponse.AddedSuccessMessage;


        //        }
        //        else
        //        {
        //            obj.isStatus = false;
        //            obj.response = "Header Id not found";

        //        }



        //    }
        //    catch (Exception e)
        //    {
        //        log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
        //        obj.isStatus = false;
        //        obj.response = ResourceResponse.FailureMessage;
        //    }
        //    return obj;
        //}

        public CommonResponse ApprovedCheckList(approveDet data)
        {
            CommonResponse obj = new CommonResponse();
            CommonFunction commonFunction = new CommonFunction();
            try
            {
                var check = db.UnitworkccsTblchecklistHeader.Where(m => m.HeaderId == data.headerId && m.IsDeleted == 0).FirstOrDefault();
                if (check != null)
                {
                    var checkDet = db.UnitworkccsTblchecklistDetails.Where(m => m.CheckListId == data.checkListId && m.IsDeleted == 0 && m.HeaderId == data.headerId).FirstOrDefault();
                    if (checkDet != null)
                    {
                        if (data.isOk == "OK")
                        {
                            checkDet.IsApproved = 1;
                        }
                        else
                        {
                            checkDet.IsApproved = 0;
                            checkDet.IsPrepared = 0;
                        }

                        checkDet.IsOk = data.isOk;
                        checkDet.Comment = data.comment;
                        db.SaveChanges();

                        var count1 = db.UnitworkccsTblchecklistDetails.Where(m => m.HeaderId == check.HeaderId && m.IsDeleted == 0).ToList();
                        var count2 = db.UnitworkccsTblchecklistDetails.Where(m => m.HeaderId == check.HeaderId && m.IsOk == "OK" && m.IsDeleted == 0).ToList();


                        int l1 = count1.Count();
                        int l2 = count2.Count();

                        if (l1 == l2)
                        {
                            check.IsApproved = 1;

                        }
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



        public CommonResponse UploadCheckListDetails(uploadCK data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                //  var checkAproved = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.HeaderId == data.headerId).Select(m=>m.IsPrepared==0).FirstOrDefault();


                var detCK = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.HeaderId == data.headerId).Select(m => m.IsPrepared).FirstOrDefault();
                var ckbol =Convert.ToInt32(detCK);
                if (ckbol == 0)
                
                { 

                 var dbCheckDelete = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == data.headerId).ToList();
                 db.UnitworkccsTblchecklistDetails.RemoveRange(dbCheckDelete);
                 db.SaveChanges();


                //foreach (var ii in dbCheckDelete)
                //{

                //    var CKDelete = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.CheckListId == ii.CheckListId).FirstOrDefault();
                //    CKDelete.IsDeleted = 1;
                //    db.SaveChanges();

                //}






                  foreach (var list in data.checkListDetails)
                {
                    UnitworkccsTblchecklistDetails tblCheckList = new UnitworkccsTblchecklistDetails();
                    tblCheckList.HeaderId = data.headerId;
                    tblCheckList.WhatToCheck = list.whatToCheck;
                    tblCheckList.How = list.how;
                    //tblCheckList.Frequency = list.PeriodFrequency;
                    tblCheckList.RunningHrs = list.numberOfRunningHours;
                    tblCheckList.PartsCount = list.numberOfPartCount;
                    tblCheckList.PeriodFrequency = list.periodFrequency;

                    if (list.outputForm.Contains(','))
                    {
                        var spliteeNT = list.outputForm.Split(',');
                        if (spliteeNT[0] == "Numeric" && spliteeNT[1] == "Text")
                        {
                            tblCheckList.IsNumeric = 1;
                            tblCheckList.IsText = 1;
                        }
                        else
                        {
                            tblCheckList.IsNumeric = 0;
                            tblCheckList.IsText = 0;

                        }

                    }
                    else
                    {

                        if (list.outputForm == "Numeric")
                        {
                            tblCheckList.IsNumeric = 1;
                            tblCheckList.IsText = 0;
                        }
                        else if (list.outputForm == "Text")
                        {
                            tblCheckList.IsText = 1;
                            tblCheckList.IsNumeric = 0;
                        }
                        else
                        {
                            tblCheckList.IsNumeric = 0;
                            tblCheckList.IsText = 0;

                        }


                    }


                    //tblCheckList.IsNumeric = Convert.ToByte(data.isNumeric);
                    //tblCheckList.IsText = Convert.ToByte(data.isText);


                    tblCheckList.RoleId = db.UnitworkccsTblroles.Where(m => m.RoleName == list.whoWillDo).Select(m => m.RoleId).FirstOrDefault();
                    tblCheckList.IsEdited = 0;
                    tblCheckList.IsPrepared = 0;
                    tblCheckList.IsApproved = 0;

                    if (!string.IsNullOrEmpty(list.calenderDate))
                    {
                        string[] datesplite = list.calenderDate.Split(',');
                        string savedate = "";
                        foreach (var dt in datesplite)
                        {
                            DateTime ddtt = Convert.ToDateTime(dt);
                            string dt1 = ddtt.ToString("yyyy-MM-dd");

                            savedate += dt1 + ",";

                        }
                        savedate = savedate.TrimEnd(',');
                        tblCheckList.Date = savedate;
                    }
                    else
                    {
                        tblCheckList.Date = list.calenderDate;
                    }

                    tblCheckList.IsDeleted = 0;
                    tblCheckList.CreatedOn = DateTime.Now;
                    db.UnitworkccsTblchecklistDetails.Add(tblCheckList);
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.AddedSuccessMessage;

                }
                }
                else
                {
                    obj.isStatus = true;
                    obj.response = "This HeaderId CheckList details Already sent to Approver";
                }

               



            }
            catch (Exception e)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        public CommonResponse DownLoadCheckListDetails(int headerId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                FileInfo templateFile = new FileInfo(@"C:\SRKS_ifacility\MainTemplate\DownLoad_CheckList_Details_By_HeaderId.xlsx");
                ExcelPackage templatep = new ExcelPackage(templateFile);
                ExcelWorksheet Templatews = templatep.Workbook.Worksheets[0];
                //  ExcelWorksheet TemplateGraph = templatep.Workbook.Worksheets[1];

                //excel file save and  downloaded link
                string ImageUrlSave = configuration.GetSection("AppSettings").GetSection("ImageUrlSave").Value;
                string ImageUrl = configuration.GetSection("AppSettings").GetSection("ImageUrl").Value;
                String FileDir = ImageUrlSave + "\\" + "CheckList_Details_" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
                String retrivalPath = ImageUrl + "CheckList_Details_" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
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
                        //ErrorLog.SendErrorToDB(ex);
                        obj.response = ResourceResponse.ExceptionMessage; ;
                    }
                }

                //Using the File for generation and populating it
                ExcelPackage p = null;
                p = new ExcelPackage(newFile);
                ExcelWorksheet worksheet = null;
                //  ExcelWorksheet worksheetGraph = null;
                //Creating the WorkSheet for populating
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
                
                var GetUtilList = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId==headerId).ToList();
                if (GetUtilList.Count > 0)
                {
                    foreach (var MacRow in GetUtilList)
                    {
                          

                        worksheet.Cells["A" + StartRow].Value = MacRow.WhatToCheck;
                        worksheet.Cells["B" + StartRow].Value = MacRow.How;
                        worksheet.Cells["C" + StartRow].Value = db.UnitworkccsTblroles.Where(m=>m.RoleId==MacRow.RoleId).Select(m=>m.RoleName).FirstOrDefault();


                        if (MacRow.IsNumeric == 1 && MacRow.IsText == 1)
                        {

                            worksheet.Cells["D" + StartRow].Value = "Numeric,Text";

                        }
                        else if (MacRow.IsNumeric == 1)
                        {
                            worksheet.Cells["D" + StartRow].Value = "Numeric";

                        }
                        else
                        {
                            worksheet.Cells["D" + StartRow].Value = "Text";

                        }

                        worksheet.Cells["E" + StartRow].Value = MacRow.RunningHrs;
                        worksheet.Cells["F" + StartRow].Value = MacRow.PartsCount;
                        worksheet.Cells["G" + StartRow].Value = MacRow.PeriodFrequency;

                        if (string.IsNullOrEmpty(MacRow.Date))
                        {
                            worksheet.Cells["H" + StartRow].Value = "";
                        }
                        else
                        {
                            worksheet.Cells["H" + StartRow].Value = MacRow.Date;
                        }
                        StartRow++;
                    }
                }
                p.Save();
                obj.isStatus = true;
                obj.response = retrivalPath;

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










//namespace IFacilityMaini.DAL
//{
//    public class CheckListDetailsDAL : ICheckListDetails
//    {
//        unitworksccsContext db = new unitworksccsContext();
//        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(CheckListDetailsDAL));
//        public static IConfiguration configuration;
//        private readonly AppSettings appSettings;

//        public CheckListDetailsDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings)
//        {
//            db = _db;
//            configuration = _configuration;
//            appSettings = _appSettings.Value;
//        }

//        public CommonResponse AddAndEditCheckListDetails(addCheckList data)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                if (data.flag == 0)
//                {
//                    var check = db.UnitworkccsTblchecklistDetails.Where(m => m.CheckListId == data.CheckListId && m.HeaderId == data.HeaderId && m.IsDeleted == 0).FirstOrDefault();
//                    if (check == null)
//                    {
//                        UnitworkccsTblchecklistDetails tblCheckList = new UnitworkccsTblchecklistDetails();
//                        tblCheckList.HeaderId = data.HeaderId;
//                        tblCheckList.WhatToCheck = data.WhatToCheck;
//                        tblCheckList.How = data.How;
//                        tblCheckList.Frequency = data.Frequency;
//                        tblCheckList.RunningHrs = data.RunningHrs;
//                        tblCheckList.PartsCount = data.PartsCount;
//                        tblCheckList.PeriodFrequency = data.PeriodFrequency;
//                        tblCheckList.IsNumeric = Convert.ToByte(data.isNumeric);
//                        tblCheckList.IsText = Convert.ToByte(data.isText);
//                        tblCheckList.RoleId = data.roleId;
//                        tblCheckList.IsEdited = 0;
//                        tblCheckList.IsPrepared = 0;
//                        tblCheckList.IsApproved = 0;

//                        if (data.Date != "")
//                        {
//                            string[] datesplite = data.Date.Split(',');
//                            string savedate = "";
//                            foreach (var dt in datesplite)
//                            {
//                                DateTime ddtt = Convert.ToDateTime(dt);
//                                string dt1 = ddtt.ToString("yyyy-MM-dd");

//                                savedate += dt1 + ",";

//                            }
//                            savedate = savedate.TrimEnd(',');
//                            tblCheckList.Date = savedate;
//                        }
//                        else
//                        {
//                            tblCheckList.Date = data.Date;
//                        }

//                        tblCheckList.IsDeleted = 0;
//                        tblCheckList.CreatedOn = DateTime.Now;
//                        db.UnitworkccsTblchecklistDetails.Add(tblCheckList);
//                        db.SaveChanges();
//                        obj.isStatus = true;
//                        obj.response = ResourceResponse.AddedSuccessMessage;
//                    }
//                    else
//                    {
//                        check.HeaderId = data.HeaderId;
//                        check.WhatToCheck = data.WhatToCheck;
//                        check.How = data.How;
//                        check.Frequency = data.Frequency;
//                        check.RunningHrs = data.RunningHrs;
//                        check.PartsCount = data.PartsCount;
//                        check.PeriodFrequency = data.PeriodFrequency;
//                        check.IsNumeric = Convert.ToByte(data.isNumeric);
//                        check.IsText = Convert.ToByte(data.isText);
//                        check.RoleId = data.roleId;
//                        if (check.IsOk == "NOTOK")
//                        {
//                            check.IsEdited = 1;
//                        }
//                        else
//                        {
//                            check.IsEdited = 0;
//                        }
//                        check.IsPrepared = 0;

//                        if (data.Date != "")
//                        {
//                            string[] datesplite = data.Date.Split(',');
//                            string savedate = "";
//                            foreach (var dt in datesplite)
//                            {
//                                DateTime ddtt = Convert.ToDateTime(dt);
//                                string dt1 = ddtt.ToString("yyyy-MM-dd");
//                                savedate += dt1 + ",";
//                            }
//                            savedate = savedate.TrimEnd(',');
//                            check.Date = savedate;
//                        }
//                        check.Date = data.Date;
//                        //  check.Date =data.Date;

//                        check.IsDeleted = 0;
//                        check.ModifiedOn = DateTime.Now;
//                        db.SaveChanges();
//                        obj.isStatus = true;
//                        obj.response = ResourceResponse.UpdatedSuccessMessage;
//                    }
//                }
//                else
//                {
//                    var checkList = db.Tblchecklistdetailsnew.Where(m => m.CheckListId == data.CheckListId).FirstOrDefault();
//                    if (checkList == null)
//                    {
//                        Tblchecklistdetailsnew tblCheckListDetailsNew = new Tblchecklistdetailsnew();
//                        tblCheckListDetailsNew.CheckListId = data.CheckListId;
//                        tblCheckListDetailsNew.WhatToCheck = data.WhatToCheck;
//                        tblCheckListDetailsNew.How = data.How;
//                        tblCheckListDetailsNew.Frequency = data.Frequency;
//                        tblCheckListDetailsNew.RunningHrs = data.RunningHrs;
//                        tblCheckListDetailsNew.PartsCount = data.PartsCount;
//                        tblCheckListDetailsNew.PeriodFrequency = data.PeriodFrequency;
//                        tblCheckListDetailsNew.IsNumeric = Convert.ToByte(data.isNumeric);
//                        tblCheckListDetailsNew.IsText = Convert.ToByte(data.isText);
//                        tblCheckListDetailsNew.RoleId = data.roleId;
//                        tblCheckListDetailsNew.CreatedOn = DateTime.Now;
//                        tblCheckListDetailsNew.AddEdit = data.addEdit;
//                        if (data.Date != "")
//                        {
//                            string[] datesplite = data.Date.Split(',');
//                            string savedate = "";
//                            foreach (var dt in datesplite)
//                            {
//                                DateTime ddtt = Convert.ToDateTime(dt);
//                                string dt1 = ddtt.ToString("yyyy-MM-dd");

//                                savedate += dt1 + ",";
//                            }
//                            savedate = savedate.TrimEnd(',');
//                            tblCheckListDetailsNew.Date = savedate;
//                        }
//                        tblCheckListDetailsNew.Date = data.Date;
//                        tblCheckListDetailsNew.IsDeleted = 0;
//                        tblCheckListDetailsNew.ModifiedOn = DateTime.Now;
//                        tblCheckListDetailsNew.Flag = data.flag;
//                        db.Tblchecklistdetailsnew.Add(tblCheckListDetailsNew);
//                        db.SaveChanges();
//                        obj.isStatus = true;
//                        obj.response = ResourceResponse.UpdatedSuccessMessage;
//                    }
//                    else
//                    {
//                        checkList.CheckListId = data.CheckListId;
//                        checkList.WhatToCheck = data.WhatToCheck;
//                        checkList.How = data.How;
//                        checkList.Frequency = data.Frequency;
//                        checkList.RunningHrs = data.RunningHrs;
//                        checkList.PartsCount = data.PartsCount;
//                        checkList.PeriodFrequency = data.PeriodFrequency;
//                        checkList.IsNumeric = Convert.ToByte(data.isNumeric);
//                        checkList.IsText = Convert.ToByte(data.isText);
//                        checkList.RoleId = data.roleId;
//                        checkList.AddEdit = data.addEdit;
//                        if (data.Date != "")
//                        {
//                            string[] datesplite = data.Date.Split(',');
//                            string savedate = "";
//                            foreach (var dt in datesplite)
//                            {
//                                DateTime ddtt = Convert.ToDateTime(dt);
//                                string dt1 = ddtt.ToString("yyyy-MM-dd");

//                                savedate += dt1 + ",";

//                            }
//                            savedate = savedate.TrimEnd(',');
//                            checkList.Date = savedate;
//                        }
//                        checkList.Date = data.Date;
//                        //  check.Date =data.Date;

//                        checkList.IsDeleted = 0;
//                        checkList.ModifiedOn = DateTime.Now;
//                        db.SaveChanges();
//                        obj.isStatus = true;
//                        obj.response = ResourceResponse.UpdatedSuccessMessage;
//                    }
//                }
//            }
//            catch (Exception e)
//            {
//                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        public CommonResponse ViewMultipleCheckListDetails()
//        {

//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                List<ViewCheckList> ViewCheckedListDet = new List<ViewCheckList>();

//                var tblDet = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0).ToList();

//                foreach (var items in tblDet)
//                {

//                    ViewCheckList ViewChecklist = new ViewCheckList();
//                    ViewChecklist.checkListId = items.CheckListId;
//                    ViewChecklist.headerId = (int)items.HeaderId;
//                    ViewChecklist.whatToCheck = items.WhatToCheck;
//                    ViewChecklist.isNumeric = Convert.ToBoolean(items.IsNumeric);
//                    ViewChecklist.isText = Convert.ToBoolean(items.IsText);
//                    ViewChecklist.roleId = items.RoleId;
//                    ViewChecklist.roleName = db.UnitworkccsTblroles.Where(m => m.RoleId == items.RoleId).Select(m => m.RoleName).FirstOrDefault();

//                    string[] howSplite = items.How.Split(',');

//                    ViewChecklist.how = howSplite;

//                    // ViewChecklist.how = items.How;
//                    ViewChecklist.frequency = items.Frequency;
//                    ViewChecklist.runningHrs = items.RunningHrs;
//                    ViewChecklist.partsCount = (int)items.PartsCount;
//                    ViewChecklist.periodFrequency = items.PeriodFrequency;

//                    if (items.IsOk == "OK")
//                    {
//                        ViewChecklist.ok = "1";
//                    }
//                    else if (items.IsOk == "NOTOK")
//                    {
//                        ViewChecklist.ok = "0";
//                        ViewChecklist.comment = items.Comment;
//                    }
//                    else
//                    {
//                        ViewChecklist.ok = null;
//                    }
//                    // ddd.dateArray = items.Date;

//                    // List<date> dddlist = new List<date>();

//                    string[] datesplite = items.Date.Split(',');
//                    ViewChecklist.dateList = datesplite;

//                    // string[] datesplite = data.Date.Split(',');
//                    //  string showdate = "";
//                    string[] showdate;

//                    List<string> datelist = new List<string>();
//                    foreach (var dt in datesplite)
//                    {
//                        DateTime ddtt = Convert.ToDateTime(dt);
//                        string dt1 = ddtt.ToString("dd-MM-yyyy");

//                        datelist.Add(dt1);
//                        //savedate += dt1 + ",";

//                    }

//                    showdate = datelist.ToArray();

//                    ViewChecklist.showDateList = showdate;


//                    // date[] ddd = datesplite;

//                    //foreach (var dd in datesplite)
//                    //{
//                    //    date ddd = new date();
//                    //    ddd.dateArray = dd;
//                    //    string[] dddlist = ddd;
//                    //   // dddlist.Add(ddd);
//                    //}

//                    //if (items.Date == null)
//                    //{
//                    //    ViewChecklist.date =null;
//                    //}
//                    //else
//                    //{
//                    //    DateTime dt = (DateTime)items.Date;
//                    //    string date1 = dt.ToString("yyyy-MM-dd");
//                    //    ViewChecklist.date = date1;

//                    //}

//                    ViewCheckedListDet.Add(ViewChecklist);

//                }

//                if (ViewCheckedListDet.Count > 0)
//                {
//                    obj.isStatus = true;
//                    obj.response = ViewCheckedListDet;
//                }
//                else
//                {
//                    obj.isStatus = false;
//                    obj.response = ResourceResponse.NoItemsFound;
//                }


//            }
//            catch (Exception e)
//            {
//                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        public CommonResponseWithStatus ViewMultipleCheckListDetailsByHeaderId(int headerId)
//        {
//            CommonResponseWithStatus obj = new CommonResponseWithStatus();
//            try
//            {
//                List<ViewCheckList> ViewCheckedListDet = new List<ViewCheckList>();
//                obj.ovarallStatus = true;
//                var tblDet = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == headerId).ToList();
//                if (tblDet.Count > 0)
//                {
//                    var okList = db.UnitworkccsTblchecklistDetails.Where(m => m.HeaderId == headerId && m.IsOk == "OK").ToList();
//                    int okCount = okList.Count();

//                    var notOkList = db.UnitworkccsTblchecklistDetails.Where(m => m.HeaderId == headerId && m.IsOk == "NOTOK").ToList();
//                    int notOkCount = notOkList.Count();

//                    if (notOkCount > 0)
//                    {
//                        obj.ovarallStatus = false;
//                    }

//                    foreach (var items in tblDet)
//                    {
//                        ViewCheckList ViewChecklist = new ViewCheckList();
//                        ViewChecklist.checkListId = items.CheckListId;
//                        ViewChecklist.headerId = (int)items.HeaderId;
//                        ViewChecklist.whatToCheck = items.WhatToCheck;

//                        if (items.How != null)
//                        {
//                            string[] howSplite = items.How.Split(',');
//                            ViewChecklist.how = howSplite;
//                        }
//                        else
//                        {
//                            ViewChecklist.how = new string[] { };
//                        }

//                        ViewChecklist.frequency = items.Frequency;
//                        ViewChecklist.runningHrs = items.RunningHrs;
//                        ViewChecklist.partsCount = (int)items.PartsCount;
//                        ViewChecklist.periodFrequency = items.PeriodFrequency;
//                        ViewChecklist.isNumeric = Convert.ToBoolean(items.IsNumeric);
//                        ViewChecklist.isText = Convert.ToBoolean(items.IsText);
//                        ViewChecklist.roleId = items.RoleId;
//                        ViewChecklist.roleName = db.UnitworkccsTblroles.Where(m => m.RoleId == items.RoleId).Select(m => m.RoleName).FirstOrDefault();
//                        // ViewChecklist.ok = items.IsOk;
//                        if (items.IsOk == "OK")
//                        {
//                            ViewChecklist.ok = "1";
//                        }
//                        else if (items.IsOk == "NOTOK")
//                        {
//                            ViewChecklist.ok = "0";
//                            ViewChecklist.comment = items.Comment;
//                        }
//                        else
//                        {
//                            ViewChecklist.ok = null;
//                        }

//                        if (items.Date != "")
//                        {
//                            string[] datesplite = items.Date.Split(',');
//                            ViewChecklist.dateList = datesplite;
//                            string[] showdate;

//                            List<string> datelist = new List<string>();
//                            foreach (var dt in datesplite)
//                            {
//                                DateTime ddtt = Convert.ToDateTime(dt);
//                                string dt1 = ddtt.ToString("dd-MM-yyyy");

//                                datelist.Add(dt1);
//                            }

//                            showdate = datelist.ToArray();
//                            ViewChecklist.showDateList = showdate;
//                        }
//                        else
//                        {
//                            ViewChecklist.showDateList = new string[] { };
//                        }

//                        ViewCheckedListDet.Add(ViewChecklist);
//                    }
//                }
//                else
//                {

//                }

//                if (ViewCheckedListDet.Count > 0)
//                {
//                    obj.isStatus = true;
//                    obj.response = ViewCheckedListDet;
//                }
//                else
//                {
//                    obj.isStatus = false;
//                    obj.response = ResourceResponse.NoItemsFound;
//                }


//            }
//            catch (Exception e)
//            {
//                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        public CommonResponse ViewCheckListById(int id)
//        {

//            CommonResponse obj = new CommonResponse();
//            try
//            {

//                var items = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.CheckListId == id).FirstOrDefault();

//                ViewCheckList ViewChecklist = new ViewCheckList();
//                ViewChecklist.checkListId = items.CheckListId;
//                ViewChecklist.headerId = (int)items.HeaderId;
//                ViewChecklist.whatToCheck = items.WhatToCheck;
//                // ViewChecklist.how = items.How;

//                string[] howSplite = items.How.Split(',');

//                ViewChecklist.how = howSplite;

//                ViewChecklist.frequency = items.Frequency;
//                ViewChecklist.runningHrs = items.RunningHrs;
//                ViewChecklist.partsCount = (int)items.PartsCount;
//                ViewChecklist.periodFrequency = items.PeriodFrequency;
//                ViewChecklist.isNumeric = Convert.ToBoolean(items.IsNumeric);
//                ViewChecklist.isText = Convert.ToBoolean(items.IsText);
//                ViewChecklist.roleId = items.RoleId;
//                ViewChecklist.roleName = db.UnitworkccsTblroles.Where(m => m.RoleId == items.RoleId).Select(m => m.RoleName).FirstOrDefault();

//                if (items.IsOk == "OK")
//                {
//                    ViewChecklist.ok = "1";
//                }
//                else if (items.IsOk == "NOTOK")
//                {
//                    ViewChecklist.ok = "0";
//                    ViewChecklist.comment = items.Comment;
//                }
//                else
//                {
//                    ViewChecklist.ok = null;
//                }
//                // string[] datesplite = items.Date.Split(',');
//                // ViewChecklist.dateList = datesplite;



//                string[] datesplite = items.Date.Split(',');
//                ViewChecklist.dateList = datesplite;

//                // string[] datesplite = data.Date.Split(',');
//                //  string showdate = "";
//                string[] showdate;

//                List<string> datelist = new List<string>();
//                foreach (var dt in datesplite)
//                {
//                    DateTime ddtt = Convert.ToDateTime(dt);
//                    string dt1 = ddtt.ToString("dd-MM-yyyy");

//                    datelist.Add(dt1);
//                    //savedate += dt1 + ",";

//                }

//                showdate = datelist.ToArray();

//                ViewChecklist.showDateList = showdate;


//                //string[] datesplite = items.Date.Split(',');

//                //foreach (var dd in datesplite)
//                //{
//                //    date ddd = new date();
//                //    ddd.dateArray = dd;
//                //    dddlist.Add(ddd);
//                //}
//                //ViewChecklist.dateList = dddlist;

//                // ViewChecklist.dateList.dateArray = items.Date;

//                //if (items.Date == null)
//                //{
//                //    ViewChecklist.date = null;
//                //}
//                //else
//                //{
//                //    DateTime dt = (DateTime)items.Date;
//                //    string date1 = dt.ToString("yyyy-mm-dd");
//                //    ViewChecklist.date = date1;

//                //}

//                if (ViewChecklist != null)
//                {
//                    obj.isStatus = true;
//                    obj.response = ViewChecklist;
//                }
//                else
//                {
//                    obj.isStatus = false;
//                    obj.response = ResourceResponse.NoItemsFound;
//                }


//            }
//            catch (Exception e)
//            {
//                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        public CommonResponse DeleteCheckListDetails(int id)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = db.UnitworkccsTblchecklistDetails.Where(m => m.CheckListId == id && m.IsDeleted == 0).FirstOrDefault();
//                if (check != null)
//                {
//                    check.IsDeleted = 1;
//                    check.ModifiedOn = DateTime.Now;
//                    db.SaveChanges();
//                    obj.isStatus = true;
//                    obj.response = ResourceResponse.DeletedSuccessMessage;
//                }
//            }
//            catch (Exception e)
//            {
//                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        //public CommonResponse ApprovedCheckList(approveDet data)
//        //{
//        //    CommonResponse obj = new CommonResponse();
//        //    CommonFunction commonFunction = new CommonFunction();
//        //    try
//        //    {

//        //        var check = db.TblCheckListHeader.Where(m => m.HeaderId == data.HeaderId && m.IsDeleted == 0).FirstOrDefault();
//        //        if (check != null)
//        //        {

//        //            string[] checklist = data.checkListIds.Split(',');
//        //            int count1 = checklist.Count();

//        //            string[] okIdSplite = data.okIds.Split(',');
//        //            int count2 = okIdSplite.Count();


//        //            string[] notOkIdSplite = data.notOkIds.Split(',');

//        //            if (!string.IsNullOrEmpty(data.okIds))
//        //            {
//        //                foreach (var ok in okIdSplite)
//        //                {
//        //                    int okid = Convert.ToInt32(ok);
//        //                    var checkDet = db.TblCheckListDetails.Where(m => m.CheckListId == okid).FirstOrDefault();
//        //                    checkDet.IsOk = "ok";
//        //                    db.SaveChanges();

//        //                }
//        //                if (count1 == count2)
//        //                {
//        //                    check.IsApproved = 1;


//        //                }

//        //            }

//        //            if (!string.IsNullOrEmpty(data.notOkIds))
//        //            {
//        //                foreach (var notok in notOkIdSplite)
//        //                {
//        //                    int notokid = Convert.ToInt32(notok);
//        //                    var checkDet = db.TblCheckListDetails.Where(m => m.CheckListId == notokid).FirstOrDefault();
//        //                    checkDet.IsOk = "not ok";
//        //                    db.SaveChanges();

//        //                }

//        //            }



//        //             check.ApprovedBy = data.approverId;

//        //            check.CreationDate = DateTime.Now;
//        //            check.LastRevDate = DateTime.Now;
//        //            check.ApprovedByDate = DateTime.Now;
//        //           // check.ApprovedByDate =Convert.ToDateTime(data.approvedDate);
//        //            db.SaveChanges();
//        //            obj.isStatus = true;
//        //            obj.response = ResourceResponse.AddedSuccessMessage;


//        //        }
//        //        else
//        //        {
//        //            obj.isStatus = false;
//        //            obj.response = "Header Id not found";

//        //        }



//        //    }
//        //    catch (Exception e)
//        //    {
//        //        log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
//        //        obj.isStatus = false;
//        //        obj.response = ResourceResponse.FailureMessage;
//        //    }
//        //    return obj;
//        //}

//        public CommonResponse ApprovedCheckList(approveDet data)
//        {
//            CommonResponse obj = new CommonResponse();
//            CommonFunction commonFunction = new CommonFunction();
//            try
//            {
//                var check = db.UnitworkccsTblchecklistHeader.Where(m => m.HeaderId == data.headerId && m.IsDeleted == 0).FirstOrDefault();
//                if (check != null)
//                {
//                    var checkDet = db.UnitworkccsTblchecklistDetails.Where(m => m.CheckListId == data.checkListId && m.IsDeleted == 0 && m.HeaderId == data.headerId).FirstOrDefault();
//                    if (checkDet != null)
//                    {
//                        if (data.isOk == "OK")
//                        {
//                            checkDet.IsApproved = 1;
//                        }
//                        else
//                        {
//                            checkDet.IsApproved = 0;
//                            checkDet.IsPrepared = 0;
//                        }

//                        checkDet.IsOk = data.isOk;
//                        checkDet.Comment = data.comment;
//                        db.SaveChanges();

//                        var count1 = db.UnitworkccsTblchecklistDetails.Where(m => m.HeaderId == check.HeaderId && m.IsDeleted == 0).ToList();
//                        var count2 = db.UnitworkccsTblchecklistDetails.Where(m => m.HeaderId == check.HeaderId && m.IsOk == "OK" && m.IsDeleted == 0).ToList();


//                        int l1 = count1.Count();
//                        int l2 = count2.Count();

//                        if (l1 == l2)
//                        {
//                            check.IsApproved = 1;

//                        }
//                        check.ApprovedBy = data.approverId;
//                        check.CreationDate = DateTime.Now;
//                        check.LastRevDate = DateTime.Now;
//                        check.ApprovedByDate = DateTime.Now;
//                        db.SaveChanges();
//                        obj.isStatus = true;
//                        obj.response = ResourceResponse.AddedSuccessMessage;
//                    }
//                    else
//                    {
//                        obj.isStatus = false;
//                        obj.response = "checkList Id not found";
//                    }
//                }
//                else
//                {
//                    obj.isStatus = false;
//                    obj.response = "Header Id not found";

//                }
//            }
//            catch (Exception e)
//            {
//                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }
//    }
//}
