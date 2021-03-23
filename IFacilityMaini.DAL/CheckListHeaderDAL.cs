
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
using static IFacilityMaini.EntityModels.CheckListDetailsEntity;
using static IFacilityMaini.EntityModels.CheckListHeaderEntity;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.DAL
{
    public class CheckListHeaderDAL : ICheckListHeader
    {
        unitworksccsContext db = new unitworksccsContext();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(CheckListHeaderDAL));
        public static IConfiguration configuration;
        private readonly AppSettings appSettings;

        public CheckListHeaderDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings)
        {
            db = _db;
            configuration = _configuration;
            appSettings = _appSettings.Value;
        }

        public CommonResponse ViewMultiplePlants()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblplant
                             where wf.IsDeleted == 0
                             select new
                             {

                                 plantId = wf.PlantId,
                                 plantCode = wf.PlantCode,
                                 plantName = wf.PlantName
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

        public CommonResponse ViewMultipleCategory()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblmachinecategorynames
                             where wf.IsDeleted == 0
                             select new
                             {
                                 categoryId = wf.MachineCategoryId,
                                 categoryName = wf.MachineCategoryName
                             }).ToList();

                if (check.Count > 0)
                {

                    obj.isStatus = true;
                    obj.response = check.Distinct();
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

        public CommonResponse ViewMultipleMake(int categoryId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblMachinemakedetails
                             where wf.IsDeleted == 0 && wf.MachineCategoryId == categoryId
                             select new
                             {
                                 machineId = wf.MakeId,
                                 machineMake = wf.MakeName
                             }).ToList();

                if (check.Count > 0)
                {

                    obj.isStatus = true;
                    obj.response = check.Distinct();
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

        public CommonResponse GenerateCheckListNo(genNo data)
        {

            CommonResponse obj = new CommonResponse();
            try
            {
                string GenNumber = data.category + " (" + data.make + ") -";

                obj.isStatus = true;
                obj.response = GenNumber;
            }

            catch (Exception e)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }

            return obj;


        }

        //public CommonResponse AddAndEditCheckListHeader(addHeader data)
        //{
        //    CommonResponse obj = new CommonResponse();
        //    CommonFunction commonFunction = new CommonFunction();
        //    try
        //    {

        //        var check = db.UnitworkccsTblchecklistHeader.Where(m => m.HeaderId == data.HeaderId && m.IsDeleted == 0).FirstOrDefault();
        //        if (check == null)
        //        {

        //            UnitworkccsTblchecklistHeader tblHeader = new UnitworkccsTblchecklistHeader();
        //            tblHeader.PlantId = data.plantId;
        //            tblHeader.PlantName = db.UnitworkccsTblplant.Where(m => m.PlantId == data.plantId).Select(m => m.PlantName).FirstOrDefault();
        //            tblHeader.CategoryId = data.categoryId;
        //            tblHeader.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
        //            tblHeader.MakeId = data.makeId;
        //            tblHeader.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
        //            tblHeader.PreparedBy = data.LoginId;
        //            // tblHeader.PreparedBy = data.LoginId;
        //            tblHeader.PreparedByDate = DateTime.Now;
        //            tblHeader.CheckListNo = data.checkListNo;
        //            tblHeader.RevNo = 1;
        //            tblHeader.IsDeleted = 0;
        //            tblHeader.CreatedOn = DateTime.Now;
        //            db.UnitworkccsTblchecklistHeader.Add(tblHeader);
        //            db.SaveChanges();
        //            //   tblHeader.RevNo = tblHeader.HeaderId;
        //            //  db.SaveChanges();
        //            obj.isStatus = true;
        //            obj.response = ResourceResponse.AddedSuccessMessage;
        //        }
        //        else
        //        {

        //            if (check.IsApproved == 1)
        //            {
        //                UnitworkccsTblchecklistHeader tblHeader = new UnitworkccsTblchecklistHeader();
        //                tblHeader.PlantId = data.plantId;
        //                tblHeader.PlantName = db.UnitworkccsTblplant.Where(m => m.PlantId == data.plantId).Select(m => m.PlantName).FirstOrDefault();
        //                tblHeader.CategoryId = data.categoryId;
        //                tblHeader.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
        //                tblHeader.MakeId = data.makeId;
        //                tblHeader.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
        //                tblHeader.PreparedBy = data.LoginId;
        //                tblHeader.PreparedByDate = DateTime.Now;
        //                tblHeader.CheckListNo = data.checkListNo;
        //                tblHeader.CreationDate = check.CreationDate;
        //                tblHeader.IsDeleted = 0;
        //                tblHeader.CreatedOn = DateTime.Now;
        //                tblHeader.RevNo = 2;
        //                db.UnitworkccsTblchecklistHeader.Add(tblHeader);
        //                db.SaveChanges();
        //                // tblHeader.RevNo = tblHeader.HeaderId;
        //                // db.SaveChanges();
        //                obj.isStatus = true;
        //                obj.response = ResourceResponse.AddedSuccessMessage;
        //            }

        //            else
        //            {
        //                check.PlantId = data.plantId;
        //                check.PlantName = db.UnitworkccsTblplant.Where(m => m.PlantId == data.plantId).Select(m => m.PlantName).FirstOrDefault();
        //                check.CategoryId = data.categoryId;
        //                check.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
        //                check.MakeId = data.makeId;
        //                check.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
        //                check.PreparedBy = data.LoginId;
        //                check.CheckListNo = data.checkListNo;
        //                check.IsDeleted = 0;
        //                check.ModifiedOn = DateTime.Now;
        //                db.SaveChanges();
        //                obj.isStatus = true;
        //                obj.response = ResourceResponse.UpdatedSuccessMessage;


        //            }




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

        public CommonResponse AddAndEditCheckListHeader(addHeader data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                if (data.flag == 0)
                {
                    var check = db.UnitworkccsTblchecklistHeader.Where(m => m.CategoryId == data.categoryId && m.MakeId == data.makeId && m.IsDeleted == 0).FirstOrDefault();
                    if (check == null)
                    {
                        UnitworkccsTblchecklistHeader tblHeader = new UnitworkccsTblchecklistHeader();
                        tblHeader.CategoryId = data.categoryId;
                        tblHeader.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
                        tblHeader.MakeId = data.makeId;
                        tblHeader.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
                        tblHeader.PreparedBy = data.LoginId;
                        var dbCheck = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0).LastOrDefault();
                        int count = 0;
                        if (dbCheck != null)
                        {
                            string[] arr = dbCheck.CheckListNo.Split('-');
                            count = Convert.ToInt32(arr[1]) + 1;
                        }
                        else
                        {
                            count = 1;
                        }
                        tblHeader.CheckListNo = data.checkListNo + count;
                        tblHeader.PreparedByDate = DateTime.Now;
                        tblHeader.RevNo = 1;
                        tblHeader.IsDeleted = 0;
                        tblHeader.CreatedOn = DateTime.Now;
                        db.UnitworkccsTblchecklistHeader.Add(tblHeader);
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;
                    }
                    else
                    {
                        obj.isStatus = false;
                        obj.response = "CheckList No already Present";
                    }
                }
                else
                {
                    string prevCheckListNo = db.UnitworkccsTblchecklistHeader.Where(m => m.HeaderId == data.HeaderId).Select(m => m.CheckListNo).FirstOrDefault();
                    string[] checkCheckListNo = prevCheckListNo.Split('-');
                    string[] checkListNo = data.checkListNo.Split('-');

                    if (checkListNo[0] == checkCheckListNo[0])
                    {
                        UnitworkccsTblchecklistHeader tblHeader = new UnitworkccsTblchecklistHeader();
                        tblHeader.CategoryId = data.categoryId;
                        tblHeader.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
                        tblHeader.MakeId = data.makeId;
                        tblHeader.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
                        tblHeader.PreparedBy = data.LoginId;
                        tblHeader.CheckListNo = data.checkListNo;
                        tblHeader.PreparedByDate = DateTime.Now;
                        tblHeader.CreationDate = DateTime.Now;
                        tblHeader.IsDeleted = 0;
                        tblHeader.CreatedOn = DateTime.Now;
                        tblHeader.PreviousChecklistHeaderId = data.flag;
                        db.UnitworkccsTblchecklistHeader.Add(tblHeader);
                        db.SaveChanges();

                        var checklistCount = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0).Select(m => m.CheckListNo).ToList();
                        string[] arr = new string[] { };
                        int count = 0;
                        foreach (var item in checklistCount)
                        {
                            arr = item.Split('-');
                            if (arr[1] == checkListNo[1])
                            {
                                count++;
                            }
                        }

                        //var matchingvalues = arr.Where(stringToCheck => stringToCheck == checkListNo[0]).Count();

                        //int count = /*checklistCount.Count();*/matchingvalues;
                        tblHeader.RevNo = count + 1 - 1;
                        db.SaveChanges();


                        var checkListDetails = db.Tblchecklistdetailsnew.Where(m => m.IsDeleted == 0 && m.Flag == data.flag).ToList();

                        if (checkListDetails.Count > 0)
                        {
                            foreach (var items in checkListDetails)
                            {
                                if (items.IsAssigned != 1)
                                {
                                    if (items.AddEdit == 1 && items.CheckListId != 0)
                                    {
                                        UnitworkccsTblchecklistDetails tblCheckList = new UnitworkccsTblchecklistDetails();
                                        tblCheckList.HeaderId = tblHeader.HeaderId;
                                        tblCheckList.WhatToCheck = items.WhatToCheck;
                                        tblCheckList.How = items.How;
                                        tblCheckList.Frequency = items.Frequency;
                                        tblCheckList.RunningHrs = items.RunningHrs;
                                        tblCheckList.PartsCount = items.PartsCount;
                                        tblCheckList.PeriodFrequency = items.PeriodFrequency;
                                        tblCheckList.IsNumeric = items.IsNumeric;
                                        tblCheckList.IsText = items.IsText;
                                        tblCheckList.RoleId = items.RoleId;
                                        tblCheckList.Date = items.Date;
                                        tblCheckList.IsOk = items.IsOk;
                                        tblCheckList.IsDeleted = items.IsDeleted;
                                        tblCheckList.CreatedOn = items.CreatedOn;
                                        tblCheckList.CreatedBy = items.CreatedBy;
                                        tblCheckList.ModifiedBy = items.ModifiedBy;
                                        tblCheckList.ModifiedOn = items.ModifiedOn;
                                        tblCheckList.IsPrepared = items.IsPrepared;
                                        tblCheckList.IsApproved = items.IsApproved;
                                        tblCheckList.Comment = items.Comment;
                                        tblCheckList.NumericValue = items.NumericValue;
                                        tblCheckList.TextValue = items.TextValue;
                                        tblCheckList.IsDashBoardEntry = items.IsDashBoardEntry;
                                        tblCheckList.PreviousChecklistId = items.CheckListId;
                                        db.UnitworkccsTblchecklistDetails.Add(tblCheckList);
                                        db.SaveChanges();

                                        if (checkListNo[0] == checkCheckListNo[0])
                                        {
                                            var dbCheck = db.Tblchecklistdetailsnew.Where(m => m.CheckListNewId == items.CheckListNewId).FirstOrDefault();
                                            if (dbCheck != null)
                                            {
                                                dbCheck.HeaderId = tblHeader.HeaderId;
                                                dbCheck.IsAssigned = 1;
                                                db.SaveChanges();
                                            }
                                        }

                                        var checkListDet = db.UnitworkccsTblchecklistDetails.Where(m => m.HeaderId == data.HeaderId && m.CheckListId != items.CheckListId && m.IsDeleted == 0).ToList();
                                        foreach (var item in checkListDet)
                                        {
                                            UnitworkccsTblchecklistDetails tblCheckList1 = new UnitworkccsTblchecklistDetails();
                                            tblCheckList1.HeaderId = tblHeader.HeaderId;
                                            tblCheckList1.WhatToCheck = item.WhatToCheck;
                                            tblCheckList1.How = item.How;
                                            tblCheckList1.Frequency = item.Frequency;
                                            tblCheckList1.RunningHrs = item.RunningHrs;
                                            tblCheckList1.PartsCount = item.PartsCount;
                                            tblCheckList1.PeriodFrequency = item.PeriodFrequency;
                                            tblCheckList1.IsNumeric = item.IsNumeric;
                                            tblCheckList1.IsText = item.IsText;
                                            tblCheckList1.RoleId = item.RoleId;
                                            tblCheckList1.Date = item.Date;
                                            tblCheckList1.IsOk = item.IsOk;
                                            tblCheckList1.IsDeleted = item.IsDeleted;
                                            tblCheckList1.CreatedOn = item.CreatedOn;
                                            tblCheckList1.CreatedBy = item.CreatedBy;
                                            tblCheckList1.ModifiedBy = item.ModifiedBy;
                                            tblCheckList1.ModifiedOn = item.ModifiedOn;
                                            tblCheckList1.IsPrepared = item.IsPrepared;
                                            tblCheckList1.IsApproved = item.IsApproved;
                                            tblCheckList1.Comment = item.Comment;
                                            tblCheckList1.NumericValue = item.NumericValue;
                                            tblCheckList1.TextValue = item.TextValue;
                                            tblCheckList1.IsDashBoardEntry = item.IsDashBoardEntry;
                                            tblCheckList1.PreviousChecklistId = item.CheckListId;
                                            db.UnitworkccsTblchecklistDetails.Add(tblCheckList1);
                                            db.SaveChanges();
                                        }
                                    }
                                    else
                                    {
                                        if (items.AddEdit == 0 && items.CheckListId == 0 && items.IsDeleted == 0)
                                        {
                                            UnitworkccsTblchecklistDetails tblCheckList = new UnitworkccsTblchecklistDetails();
                                            tblCheckList.HeaderId = tblHeader.HeaderId;
                                            tblCheckList.WhatToCheck = items.WhatToCheck;
                                            tblCheckList.How = items.How;
                                            tblCheckList.Frequency = items.Frequency;
                                            tblCheckList.RunningHrs = items.RunningHrs;
                                            tblCheckList.PartsCount = items.PartsCount;
                                            tblCheckList.PeriodFrequency = items.PeriodFrequency;
                                            tblCheckList.IsNumeric = items.IsNumeric;
                                            tblCheckList.IsText = items.IsText;
                                            tblCheckList.RoleId = items.RoleId;
                                            tblCheckList.Date = items.Date;
                                            tblCheckList.IsOk = items.IsOk;
                                            tblCheckList.IsDeleted = items.IsDeleted;
                                            tblCheckList.CreatedOn = items.CreatedOn;
                                            tblCheckList.CreatedBy = items.CreatedBy;
                                            tblCheckList.ModifiedBy = items.ModifiedBy;
                                            tblCheckList.ModifiedOn = items.ModifiedOn;
                                            tblCheckList.IsPrepared = items.IsPrepared;
                                            tblCheckList.IsApproved = items.IsApproved;
                                            tblCheckList.Comment = items.Comment;
                                            tblCheckList.NumericValue = items.NumericValue;
                                            tblCheckList.TextValue = items.TextValue;
                                            tblCheckList.IsDashBoardEntry = items.IsDashBoardEntry;
                                            tblCheckList.PreviousChecklistId = items.CheckListId;
                                            db.UnitworkccsTblchecklistDetails.Add(tblCheckList);
                                            db.SaveChanges();

                                            if (checkListNo[0] == checkCheckListNo[0])
                                            {
                                                var dbCheck = db.Tblchecklistdetailsnew.Where(m => m.CheckListNewId == items.CheckListNewId).FirstOrDefault();
                                                if (dbCheck != null)
                                                {
                                                    dbCheck.HeaderId = tblHeader.HeaderId;
                                                    dbCheck.IsAssigned = 1;
                                                    db.SaveChanges();
                                                }
                                            }

                                            var checkListDet = db.UnitworkccsTblchecklistDetails.Where(m => m.HeaderId == data.HeaderId && m.IsDeleted == 0).ToList();
                                            foreach (var item in checkListDet)
                                            {
                                                UnitworkccsTblchecklistDetails tblCheckList1 = new UnitworkccsTblchecklistDetails();
                                                tblCheckList1.HeaderId = tblHeader.HeaderId;
                                                tblCheckList1.WhatToCheck = item.WhatToCheck;
                                                tblCheckList1.How = item.How;
                                                tblCheckList1.Frequency = item.Frequency;
                                                tblCheckList1.RunningHrs = item.RunningHrs;
                                                tblCheckList1.PartsCount = item.PartsCount;
                                                tblCheckList1.PeriodFrequency = item.PeriodFrequency;
                                                tblCheckList1.IsNumeric = item.IsNumeric;
                                                tblCheckList1.IsText = item.IsText;
                                                tblCheckList1.RoleId = item.RoleId;
                                                tblCheckList1.Date = item.Date;
                                                tblCheckList1.IsOk = item.IsOk;
                                                tblCheckList1.IsDeleted = item.IsDeleted;
                                                tblCheckList1.CreatedOn = item.CreatedOn;
                                                tblCheckList1.CreatedBy = item.CreatedBy;
                                                tblCheckList1.ModifiedBy = item.ModifiedBy;
                                                tblCheckList1.ModifiedOn = item.ModifiedOn;
                                                tblCheckList1.IsPrepared = item.IsPrepared;
                                                tblCheckList1.IsApproved = item.IsApproved;
                                                tblCheckList1.Comment = item.Comment;
                                                tblCheckList1.NumericValue = item.NumericValue;
                                                tblCheckList1.TextValue = item.TextValue;
                                                tblCheckList1.IsDashBoardEntry = item.IsDashBoardEntry;
                                                tblCheckList1.PreviousChecklistId = item.CheckListId;
                                                db.UnitworkccsTblchecklistDetails.Add(tblCheckList1);
                                                db.SaveChanges();
                                            }
                                        }
                                    }
                                }
                            }
                            obj.isStatus = true;
                            obj.response = ResourceResponse.AddedSuccessMessage;
                        }

                    }
                    else
                    {
                        var checks = db.UnitworkccsTblchecklistHeader.Where(m => m.CheckListNo.Contains(data.checkListNo) && m.IsDeleted == 0).FirstOrDefault();
                        if (checks == null)
                        {
                            UnitworkccsTblchecklistHeader tblHeader1 = new UnitworkccsTblchecklistHeader();
                            tblHeader1.CategoryId = data.categoryId;
                            tblHeader1.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
                            tblHeader1.MakeId = data.makeId;
                            tblHeader1.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
                            tblHeader1.PreparedBy = data.LoginId;
                            tblHeader1.PreparedByDate = DateTime.Now;
                            // tblHeader.CheckListNo = data.checkListNo;
                            tblHeader1.CreationDate = DateTime.Now;
                            tblHeader1.IsDeleted = 0;
                            tblHeader1.CreatedOn = DateTime.Now;
                            tblHeader1.PreviousChecklistHeaderId = data.flag;
                            //int revInc = check.RevNo;
                            tblHeader1.RevNo = 1;
                            db.UnitworkccsTblchecklistHeader.Add(tblHeader1);
                            db.SaveChanges();

                            tblHeader1.CheckListNo = checkListNo[0] + "-" + tblHeader1.HeaderId;
                            db.SaveChanges();

                            var checkListDet = db.UnitworkccsTblchecklistDetails.Where(m => m.HeaderId == data.HeaderId && m.IsDeleted == 0).ToList();
                            foreach (var item in checkListDet)
                            {
                                UnitworkccsTblchecklistDetails tblCheckList1 = new UnitworkccsTblchecklistDetails();
                                tblCheckList1.HeaderId = tblHeader1.HeaderId;
                                tblCheckList1.WhatToCheck = item.WhatToCheck;
                                tblCheckList1.How = item.How;
                                tblCheckList1.Frequency = item.Frequency;
                                tblCheckList1.RunningHrs = item.RunningHrs;
                                tblCheckList1.PartsCount = item.PartsCount;
                                tblCheckList1.PeriodFrequency = item.PeriodFrequency;
                                tblCheckList1.IsNumeric = item.IsNumeric;
                                tblCheckList1.IsText = item.IsText;
                                tblCheckList1.RoleId = item.RoleId;
                                tblCheckList1.Date = item.Date;
                                tblCheckList1.IsOk = item.IsOk;
                                tblCheckList1.IsDeleted = item.IsDeleted;
                                tblCheckList1.CreatedOn = item.CreatedOn;
                                tblCheckList1.CreatedBy = item.CreatedBy;
                                tblCheckList1.ModifiedBy = item.ModifiedBy;
                                tblCheckList1.ModifiedOn = item.ModifiedOn;
                                tblCheckList1.IsPrepared = item.IsPrepared;
                                tblCheckList1.IsApproved = item.IsApproved;
                                tblCheckList1.Comment = item.Comment;
                                tblCheckList1.NumericValue = item.NumericValue;
                                tblCheckList1.TextValue = item.TextValue;
                                tblCheckList1.IsDashBoardEntry = item.IsDashBoardEntry;
                                tblCheckList1.PreviousChecklistId = item.CheckListId;
                                db.UnitworkccsTblchecklistDetails.Add(tblCheckList1);
                                db.SaveChanges();
                            }
                        }
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

        public CommonResponse ViewMultipleCheckListHeader()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

                var tblDet = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0).ToList();

                foreach (var items in tblDet)
                {
                    viewHeaders ViewHeader1 = new viewHeaders();

                    ViewHeader1.headerId = items.HeaderId;
                    //ViewHeader1.plantId = (int)items.PlantId;
                    //ViewHeader1.plantName = items.PlantName;

                    //ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();
                    // ViewHeader1.id = items.HeaderId;
                    //  ViewHeader1.plantCode = items.PlantName;
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
                    // ViewHeader1.checkListNo = items.CheckListNo + items.HeaderId;
                    ViewHeader1.checkListNo = items.CheckListNo;
                    ViewHeader1.id = items.HeaderId;
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

                    // ViewHeader1.isApproved =items.IsApproved;
                    ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
                    var checklistIntbl = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).ToList();

                    if (checklistIntbl.Count == 0)
                    {
                        ViewHeader1.pendingCheckList = "check list details not created for this HeaderId";
                    }
                    else
                    {
                        int countl = 0;
                        foreach (var ll in checklistIntbl)
                        {
                            if (ll.IsOk != "OK")
                            {
                                countl += 1;
                            }
                        }

                        if (countl != 0)
                        {

                            ViewHeader1.pendingCheckList = "pending check list = " + countl + "";
                            ViewHeader1.postToApprover = 1;
                        }
                        else
                        {
                            ViewHeader1.pendingCheckList = "all check list OK";
                            ViewHeader1.postToApprover = 0;
                        }
                    }
                    var PTAbutton = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).ToList();

                    var ispre = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).FirstOrDefault();

                    if (PTAbutton.Count == 0)
                    {
                        ViewHeader1.postToApprover = 0;
                    }
                    else
                    {
                        if (ispre.IsPrepared == null && ispre != null)
                        {
                            ViewHeader1.postToApprover = 1;
                        }
                    }

                    if (ispre.IsPrepared == 1)
                    {
                        int notokthere = 0;
                        int notOkEdited = 0;

                        foreach (var isnotok in PTAbutton)
                        {
                            if (isnotok.IsOk == "NOTOK" && isnotok.IsEdited == 0 && isnotok.IsPrepared == 0 && isnotok.IsApproved == 0)
                            {
                                notokthere++;
                            }
                            else if (isnotok.IsOk == "NOTOK" && isnotok.IsEdited == 1 && isnotok.IsPrepared == 0 && isnotok.IsApproved == 0)
                            {
                                notOkEdited++;
                            }
                        }

                        if (notokthere > 0)
                        {
                            ViewHeader1.postToApprover = 0;
                        }
                        else if (notOkEdited > 0)
                        {
                            ViewHeader1.postToApprover = 1;
                        }
                        else
                        {
                            ViewHeader1.postToApprover = 0;
                        }
                    }

                    //if (ispre.IsPrepared == 1)
                    //{
                    //    int notokthere = 0;

                    //    foreach (var isnotok in PTAbutton)
                    //    {
                    //        if (isnotok.IsOk == "NOTOK" && isnotok.ModifiedOn == null)
                    //        {
                    //            notokthere++;
                    //        }
                    //    }

                    //    if (notokthere > 0)
                    //    {
                    //        ViewHeader1.postToApprover = 0;
                    //    }
                    //    else
                    //    {
                    //        ViewHeader1.postToApprover = 1;
                    //    }
                    //}

                    if (ispre.IsPrepared == 1 && ispre.ApprovedBy == null)
                    {
                        ViewHeader1.postToApprover = 0;
                    }


                    var checklistIntbl2 = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).ToList();

                    int len = checklistIntbl2.Count;
                    int len2 = 0;
                    if (len > 0)
                    {
                        foreach (var ee in checklistIntbl2)
                        {
                            if (ee.IsOk == "OK")
                            {
                                len2++;
                            }
                        }

                        if (len2 == len)
                        {
                            ViewHeader1.pendingCheckList = "all check list OK";
                            ViewHeader1.postToApprover = 0;
                        }

                    }


                    // ViewHeader1.preparedLogin = items.PreparedBy == null ? 0 : 1;
                    //  ViewHeader1.approvedLogin = items.ApprovedBy == null ? 0 : 1;

                    ViewHeaderList.Add(ViewHeader1);

                }


                //var check = (from wf in db.UnitworkccsTblchecklistHeader
                //       where wf.IsDeleted == 0
                //       select new
                //       {

                //           headerId = wf.HeaderId,
                //           plantId = wf.PlantId,
                //           plantName = wf.PlantName,
                //           categoryId = wf.CategoryId,
                //           categoryName = wf.CategoryName,
                //           makeId = wf.MakeId,
                //           makeName = wf.MakeName,
                //           creationDate  = wf.CreationDate,
                //           revNo = wf.RevNo,
                //           lastRevDate = wf.LastRevDate,
                //           checkListNo = wf.CheckListNo + wf.RevNo,
                //           preparedBy = wf.PreparedBy,
                //           preparedByDate = wf.PreparedByDate,
                //           approvedBy = wf.ApprovedBy,
                //           approvedByDate = wf.ApprovedByDate
                //       }).ToList();

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
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        public CommonResponse FulldetailsForRevButton(int headerId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                //  List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

                var items = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.HeaderId == headerId).FirstOrDefault();


                viewHeadersAndDet ViewHeader1 = new viewHeadersAndDet();

                ViewHeader1.headerId = items.HeaderId;
                ViewHeader1.plantId = (int)items.PlantId;
                ViewHeader1.plantName = items.PlantName;
                ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault(); ;
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
                // ViewHeader1.checkListNo = items.CheckListNo + items.HeaderId;
                ViewHeader1.checkListNo = items.CheckListNo;
                ViewHeader1.id = items.HeaderId;
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

                // ViewHeader1.isApproved =items.IsApproved;
                ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;



                //var checklistIntbl = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).ToList();

                //if (checklistIntbl.Count == 0)
                //{
                //    ViewHeader1.pendingCheckList = "check list details not created for this HeaderId";

                //}

                //else
                //{
                //    int countl = 0;
                //    foreach (var ll in checklistIntbl)
                //    {
                //        if (ll.IsOk != "OK")
                //        {
                //            countl += 1;
                //        }

                //    }

                //    if (countl != 0)
                //    {

                //        ViewHeader1.pendingCheckList = "pending check list = " + countl + "";
                //        ViewHeader1.postToApprover = 1;
                //    }
                //    else
                //    {
                //        ViewHeader1.pendingCheckList = "all check list OK";
                //        ViewHeader1.postToApprover = 0;
                //    }
                //}
                //var PTAbutton = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).ToList();

                //var ispre = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).FirstOrDefault();

                //if (PTAbutton.Count == 0)
                //{
                //    ViewHeader1.postToApprover = 0;

                //}

                //else
                //{

                //    if (ispre.IsPrepared == null && ispre != null)

                //    {
                //        ViewHeader1.postToApprover = 1;

                //    }


                //}


                //if (ispre.IsPrepared == 1)
                //{

                //    int notokthere = 0;
                //    foreach (var isnotok in PTAbutton)
                //    {
                //        if (isnotok.IsOk == "NOTOK" && isnotok.ModifiedOn == null)
                //        {
                //            notokthere++;
                //        }

                //    }

                //    if (notokthere > 0)
                //    {
                //        ViewHeader1.postToApprover = 0;
                //    }
                //    else
                //    {
                //        ViewHeader1.postToApprover = 1;

                //    }

                //}





                //if (ispre.IsPrepared == 1 && ispre.ApprovedBy == null)
                //{
                //    ViewHeader1.postToApprover = 0;

                //}


                //var checklistIntbl2 = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).ToList();

                //int len = checklistIntbl2.Count;
                //int len2 = 0;
                //if (len > 0)
                //{
                //    foreach (var ee in checklistIntbl2)
                //    {
                //        if (ee.IsOk == "OK")
                //        {
                //            len2++;
                //        }


                //    }

                //    if (len2 == len)
                //    {
                //        ViewHeader1.pendingCheckList = "all check list OK";
                //        ViewHeader1.postToApprover = 0;
                //    }

                //}


                // ViewHeader1.preparedLogin = items.PreparedBy == null ? 0 : 1;
                //  ViewHeader1.approvedLogin = items.ApprovedBy == null ? 0 : 1;

                // ViewHeaderList.Add(ViewHeader1);


                List<ViewCheckList> ViewCheckedListDet = new List<ViewCheckList>();

                var tblDet1 = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == headerId).ToList();

                foreach (var items1 in tblDet1)
                {
                    ViewCheckList ViewChecklist = new ViewCheckList();
                    ViewChecklist.checkListId = items1.CheckListId;
                    ViewChecklist.headerId = (int)items1.HeaderId;
                    ViewChecklist.whatToCheck = items1.WhatToCheck;
                    //   ViewChecklist.how = items.How;
                    string[] howSplite = items1.How.Split(',');

                    ViewChecklist.how = howSplite;
                    ViewChecklist.frequency = items1.Frequency;
                    ViewChecklist.runningHrs = items1.RunningHrs;
                    ViewChecklist.partsCount = (int)items1.PartsCount;
                    ViewChecklist.periodFrequency = items1.PeriodFrequency;
                    ViewChecklist.isNumeric = Convert.ToBoolean(items1.IsNumeric);
                    ViewChecklist.isText = Convert.ToBoolean(items1.IsText);
                    ViewChecklist.roleId = items1.RoleId;
                    ViewChecklist.roleName = db.UnitworkccsTblroles.Where(m => m.RoleId == items1.RoleId).Select(m => m.RoleName).FirstOrDefault();
                    // ViewChecklist.ok = items.IsOk;
                    if (items1.IsOk == "OK")
                    {
                        ViewChecklist.ok = "1";
                    }
                    else if (items1.IsOk == "NOTOK")
                    {
                        ViewChecklist.ok = "0";
                        ViewChecklist.comment = items1.Comment;
                    }
                    else
                    {
                        ViewChecklist.ok = null;
                    }

                    //  string[] datesplite = items.Date.Split(',');


                    // ViewChecklist.dateList = datesplite;


                    if (items1.Date != "")
                    {
                        string[] datesplite = items1.Date.Split(',');
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

                    // string[] datesplite = data.Date.Split(',');
                    //  string showdate = "";




                    //List<date> dddlist = new List<date>();

                    //string[] datesplite = items.Date.Split();

                    //foreach (var dd in datesplite)
                    //{
                    //    date ddd = new date();
                    //    ddd.dateArray = dd;
                    //    dddlist.Add(ddd);
                    //}
                    //ViewChecklist.dateList = dddlist;
                    //  ViewChecklist.dateList.dateArray = items.Date;
                    //if (items.Date == null)
                    //{
                    //    ViewChecklist.date = null;
                    //}
                    //else
                    //{
                    //    DateTime dt = (DateTime)items.Date;
                    //    string date1 = dt.ToString("yyyy-MM-dd");
                    //    ViewChecklist.date = date1;

                    //}

                    ViewCheckedListDet.Add(ViewChecklist);

                }



                ViewHeader1.checkListDetails = ViewCheckedListDet;



                if (ViewHeader1 != null)
                {
                    obj.isStatus = true;
                    obj.response = ViewHeader1;
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

        public CommonResponse ViewMultipleCheckListHeaderByOperatorId(int operatorId)
        {


            CommonResponse obj = new CommonResponse();
            try
            {

                List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

                var tblDet = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.PreparedBy == operatorId).ToList();
                if (tblDet.Count > 0)

                {

                    foreach (var items in tblDet)
                    {
                        viewHeaders ViewHeader1 = new viewHeaders();

                        ViewHeader1.headerId = items.HeaderId;
                        //ViewHeader1.plantId = (int)items.PlantId;
                        //ViewHeader1.plantName = items.PlantName;
                        //ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();
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


                        // ViewHeader1.checkListNo = items.CheckListNo + items.HeaderId;
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
                        ViewHeader1.preparedLogin = 1;
                        ViewHeader1.approvedLogin = 0;


                        ViewHeaderList.Add(ViewHeader1);

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
                    //int roleid =(int) db.UnitworkccsTbloperatordetails.Where(m => m.OpId == operatorId).Select(m => m.RoleId).FirstOrDefault();

                    //if (roleid ==22)
                    //{
                    var tblDet1 = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.IsPrepared == 1).ToList();
                    if (tblDet1.Count > 0)

                    {

                        foreach (var items in tblDet1)
                        {
                            viewHeaders ViewHeader1 = new viewHeaders();

                            ViewHeader1.headerId = items.HeaderId;
                            //ViewHeader1.plantId = (int)items.PlantId;
                            //ViewHeader1.plantName = items.PlantName;
                            //ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();
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


                            //ViewHeader1.checkListNo = items.CheckListNo + items.HeaderId;
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

                    // }
                    //else
                    //{

                    //    obj.isStatus = false;
                    //    obj.response ="operator id is not a Approver id";


                    //}

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

        public CommonResponse ViewCheckListPlantId(int plantId)
        {

            /*, int operatorId*/
            CommonResponse obj = new CommonResponse();
            try
            {

                // List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

                // var tblDet = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.PlantId==plantId).ToList();

                List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

                var tblDet = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.PlantId == plantId).ToList();
                if (tblDet.Count > 0)

                {

                    foreach (var items in tblDet)
                    {
                        viewHeaders ViewHeader1 = new viewHeaders();

                        ViewHeader1.headerId = items.HeaderId;
                        ViewHeader1.plantId = (int)items.PlantId;
                        ViewHeader1.plantName = items.PlantName;


                        ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();
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


                        // ViewHeader1.checkListNo = items.CheckListNo + items.RevNo;
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
                        ViewHeader1.preparedLogin = 1;
                        ViewHeader1.approvedLogin = 0;


                        ViewHeaderList.Add(ViewHeader1);

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
                //else
                //{
                //    var tblDet1 = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.IsPrepared == 1 && m.PlantId==plantId).ToList();
                //    if (tblDet1.Count > 0)

                //    {

                //        foreach (var items in tblDet1)
                //        {
                //            viewHeaders ViewHeader1 = new viewHeaders();

                //            ViewHeader1.headerId = items.HeaderId;
                //            ViewHeader1.plantId = (int)items.PlantId;
                //            ViewHeader1.plantName = items.PlantName;
                //            ViewHeader1.categoryId = (int)items.CategoryId;
                //            ViewHeader1.categoryName = items.CategoryName;
                //            ViewHeader1.makeId = (int)items.MakeId;
                //            ViewHeader1.makeName = items.MakeName;

                //            if (items.CreationDate == null)
                //            {
                //                ViewHeader1.creationDate = null;
                //            }

                //            else
                //            {
                //                DateTime cdate = (DateTime)items.CreationDate;

                //                ViewHeader1.creationDate = cdate.ToString("dd-MM-yyyy");

                //            }

                //            ViewHeader1.revNo = items.RevNo;



                //            if (items.LastRevDate == null)
                //            {
                //                ViewHeader1.lastRevDate = null;
                //            }

                //            else
                //            {
                //                DateTime rvdate = (DateTime)items.LastRevDate;
                //                ViewHeader1.lastRevDate = rvdate.ToString("dd-MM-yyyy");

                //            }


                //            ViewHeader1.checkListNo = items.CheckListNo + items.RevNo;
                //            ViewHeader1.preparedBy = (int)items.PreparedBy;
                //            ViewHeader1.preparedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
                //            if (items.PreparedByDate == null)
                //            {
                //                ViewHeader1.preparedByDate = null;
                //            }

                //            else
                //            {
                //                DateTime pdate = (DateTime)items.PreparedByDate;
                //                ViewHeader1.preparedByDate = pdate.ToString("dd-MM-yyyy");
                //            }


                //            ViewHeader1.approvedBy = items.ApprovedBy;
                //            ViewHeader1.approvedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

                //            if (items.ApprovedByDate == null)
                //            {
                //                ViewHeader1.approvedByDate = null;
                //            }

                //            else
                //            {
                //                DateTime adate = (DateTime)items.ApprovedByDate;
                //                ViewHeader1.approvedByDate = adate.ToString("yyyy-MM-dd");

                //            }

                //            // ViewHeader1.isApproved = items.IsApproved;
                //            ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
                //            ViewHeader1.preparedLogin = 0;
                //            ViewHeader1.approvedLogin = 1;


                //            ViewHeaderList.Add(ViewHeader1);

                //        }

                //        if (ViewHeaderList.Count > 0)
                //        {
                //            obj.isStatus = true;
                //            obj.response = ViewHeaderList;
                //        }
                //        else
                //        {
                //            obj.isStatus = false;
                //            obj.response = ResourceResponse.NoItemsFound;
                //        }

                //    }

                //}


            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }
        public CommonResponse ViewCheckListPlantCategoryId(int cateroryId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {

                List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

                var tblDet = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.CategoryId == cateroryId).ToList();
                if (tblDet.Count > 0)

                {

                    foreach (var items in tblDet)
                    {
                        viewHeaders ViewHeader1 = new viewHeaders();

                        ViewHeader1.headerId = items.HeaderId;
                        ViewHeader1.plantId = (int)items.PlantId;
                        ViewHeader1.plantName = items.PlantName;

                        ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();
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


                        // ViewHeader1.checkListNo = items.CheckListNo + items.RevNo;
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
                        ViewHeader1.preparedLogin = 1;
                        ViewHeader1.approvedLogin = 0;


                        ViewHeaderList.Add(ViewHeader1);

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
                //else
                //{
                //    var tblDet1 = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.IsPrepared == 1 && m.PlantId == plantId && m.CategoryId==cateroryId).ToList();
                //    if (tblDet1.Count > 0)

                //    {

                //        foreach (var items in tblDet1)
                //        {
                //            viewHeaders ViewHeader1 = new viewHeaders();

                //            ViewHeader1.headerId = items.HeaderId;
                //            ViewHeader1.plantId = (int)items.PlantId;
                //            ViewHeader1.plantName = items.PlantName;
                //            ViewHeader1.categoryId = (int)items.CategoryId;
                //            ViewHeader1.categoryName = items.CategoryName;
                //            ViewHeader1.makeId = (int)items.MakeId;
                //            ViewHeader1.makeName = items.MakeName;

                //            if (items.CreationDate == null)
                //            {
                //                ViewHeader1.creationDate = null;
                //            }

                //            else
                //            {
                //                DateTime cdate = (DateTime)items.CreationDate;

                //                ViewHeader1.creationDate = cdate.ToString("dd-MM-yyyy");

                //            }

                //            ViewHeader1.revNo = items.RevNo;



                //            if (items.LastRevDate == null)
                //            {
                //                ViewHeader1.lastRevDate = null;
                //            }

                //            else
                //            {
                //                DateTime rvdate = (DateTime)items.LastRevDate;
                //                ViewHeader1.lastRevDate = rvdate.ToString("dd-MM-yyyy");

                //            }


                //            ViewHeader1.checkListNo = items.CheckListNo + items.RevNo;
                //            ViewHeader1.preparedBy = (int)items.PreparedBy;
                //            ViewHeader1.preparedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
                //            if (items.PreparedByDate == null)
                //            {
                //                ViewHeader1.preparedByDate = null;
                //            }

                //            else
                //            {
                //                DateTime pdate = (DateTime)items.PreparedByDate;
                //                ViewHeader1.preparedByDate = pdate.ToString("dd-MM-yyyy");
                //            }


                //            ViewHeader1.approvedBy = items.ApprovedBy;
                //            ViewHeader1.approvedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

                //            if (items.ApprovedByDate == null)
                //            {
                //                ViewHeader1.approvedByDate = null;
                //            }

                //            else
                //            {
                //                DateTime adate = (DateTime)items.ApprovedByDate;
                //                ViewHeader1.approvedByDate = adate.ToString("dd-MM-yyyy");

                //            }

                //            // ViewHeader1.isApproved = items.IsApproved;
                //            ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
                //            ViewHeader1.preparedLogin = 0;
                //            ViewHeader1.approvedLogin = 1;


                //            ViewHeaderList.Add(ViewHeader1);

                //        }

                //        if (ViewHeaderList.Count > 0)
                //        {
                //            obj.isStatus = true;
                //            obj.response = ViewHeaderList;
                //        }
                //        else
                //        {
                //            obj.isStatus = false;
                //            obj.response = ResourceResponse.NoItemsFound;
                //        }

                //    }

                //}

            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        public CommonResponse ViewCheckListHeaderId(int HeaderId)
        {


            CommonResponse obj = new CommonResponse();
            try
            {

                List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

                var tblDet = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.HeaderId == HeaderId).ToList();
                if (tblDet.Count > 0)

                {

                    foreach (var items in tblDet)
                    {
                        viewHeaders ViewHeader1 = new viewHeaders();

                        ViewHeader1.headerId = items.HeaderId;
                        //ViewHeader1.plantId = (int)items.PlantId;
                        //ViewHeader1.plantName = items.PlantName;

                        //ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();

                        //  ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();
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
                        ViewHeader1.preparedLogin = 1;
                        ViewHeader1.approvedLogin = 0;


                        ViewHeaderList.Add(ViewHeader1);

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
                //else
                //{
                //    var tblDet1 = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.IsPrepared == 1 && m.HeaderId == HeaderId).ToList();
                //    if (tblDet1.Count > 0)

                //    {

                //        foreach (var items in tblDet1)
                //        {
                //            viewHeaders ViewHeader1 = new viewHeaders();

                //            ViewHeader1.headerId = items.HeaderId;
                //            ViewHeader1.plantId = (int)items.PlantId;
                //            ViewHeader1.plantName = items.PlantName;
                //            ViewHeader1.categoryId = (int)items.CategoryId;
                //            ViewHeader1.categoryName = items.CategoryName;
                //            ViewHeader1.makeId = (int)items.MakeId;
                //            ViewHeader1.makeName = items.MakeName;

                //            if (items.CreationDate == null)
                //            {
                //                ViewHeader1.creationDate = null;
                //            }

                //            else
                //            {
                //                DateTime cdate = (DateTime)items.CreationDate;

                //                ViewHeader1.creationDate = cdate.ToString("dd-MM-yyyy");

                //            }

                //            ViewHeader1.revNo = items.RevNo;



                //            if (items.LastRevDate == null)
                //            {
                //                ViewHeader1.lastRevDate = null;
                //            }

                //            else
                //            {
                //                DateTime rvdate = (DateTime)items.LastRevDate;
                //                ViewHeader1.lastRevDate = rvdate.ToString("dd-MM-yyyy");

                //            }


                //            ViewHeader1.checkListNo = items.CheckListNo + items.RevNo;
                //            ViewHeader1.preparedBy = (int)items.PreparedBy;
                //            ViewHeader1.preparedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
                //            if (items.PreparedByDate == null)
                //            {
                //                ViewHeader1.preparedByDate = null;
                //            }

                //            else
                //            {
                //                DateTime pdate = (DateTime)items.PreparedByDate;
                //                ViewHeader1.preparedByDate = pdate.ToString("dd-MM-yyyy");
                //            }


                //            ViewHeader1.approvedBy = items.ApprovedBy;
                //            ViewHeader1.approvedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

                //            if (items.ApprovedByDate == null)
                //            {
                //                ViewHeader1.approvedByDate = null;
                //            }

                //            else
                //            {
                //                DateTime adate = (DateTime)items.ApprovedByDate;
                //                ViewHeader1.approvedByDate = adate.ToString("dd-MM-yyyy");

                //            }

                //            // ViewHeader1.isApproved = items.IsApproved;
                //            ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
                //            ViewHeader1.preparedLogin = 0;
                //            ViewHeader1.approvedLogin = 1;


                //            ViewHeaderList.Add(ViewHeader1);

                //        }

                //        if (ViewHeaderList.Count > 0)
                //        {
                //            obj.isStatus = true;
                //            obj.response = ViewHeaderList;
                //        }
                //        else
                //        {
                //            obj.isStatus = false;
                //            obj.response = ResourceResponse.NoItemsFound;
                //        }

                //    }

                //}


            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        public CommonResponse SendCheckListToApprover(int HeaderId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var items = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.HeaderId == HeaderId).FirstOrDefault();

                if (items != null)
                {
                    items.IsPrepared = 1;
                    db.SaveChanges();

                    var check = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == HeaderId).ToList();
                    foreach (var i in check)
                    {
                        i.IsPrepared = 1;
                        db.SaveChanges();
                    }

                    obj.isStatus = true;
                    obj.response = "sent to Approver";
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

        public CommonResponse DeleteCheckListHeader(int HeaderId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTblchecklistHeader.Where(m => m.HeaderId == HeaderId && m.IsDeleted == 0).FirstOrDefault();
                if (check != null)
                {
                    check.IsDeleted = 1;
                    check.ModifiedOn = DateTime.Now;
                    db.SaveChanges();

                    var tblCheckListDet = db.UnitworkccsTblchecklistDetails.Where(m => m.HeaderId == HeaderId && m.IsDeleted == 0).ToList();
                    foreach (var del in tblCheckListDet)
                    {
                        del.IsDeleted = 1;
                        del.ModifiedOn = DateTime.Now;
                        db.SaveChanges();

                    }


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

        //adding multiple machines  to header Id
        public CommonResponse ViewMultipleHeaderIds(int makeId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblchecklistHeader
                             where wf.IsDeleted == 0 && wf.IsApproved == 1 && wf.MakeId == makeId
                             select new
                             {
                                 id = wf.HeaderId,
                                 checkListName = wf.CheckListNo
                                 // checkListName = wf.CheckListNo + "" + wf.HeaderId
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

        public CommonResponse ViewMultiplePlantNames()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblplant
                             where wf.IsDeleted == 0
                             select new
                             {

                                 plantId = wf.PlantId,
                                 plantCode = wf.PlantCode,
                                 plantName = wf.PlantName
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

        public CommonResponse ViewMultipleCategoryNames(int PlantId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblmachinecategorynames
                             where wf.IsDeleted == 0 && wf.PlantId == PlantId
                             select new
                             {
                                 categoryId = wf.MachineCategoryId,
                                 categoryName = wf.MachineCategoryName
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

        public CommonResponse ViewMultipleMakeNames(int categoryId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblMachinemakedetails
                             where wf.IsDeleted == 0 && wf.MachineCategoryId == categoryId
                             select new
                             {
                                 makeId = wf.MakeId,
                                 machineMake = wf.MakeName
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

        public CommonResponse ViewMultipleMachineList(int makeId, int categoryId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblmachinedetails
                             where wf.IsDeleted == 0 && wf.MachineMake == Convert.ToString(makeId) && wf.MachineCategoryId == categoryId
                             select new
                             {
                                 machineId = wf.MachineId,
                                 machineName = wf.MachineName,

                             }).ToList();

                if (check.Count > 0)
                {

                    obj.isStatus = true;
                    obj.response = check.Distinct();
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

        //public CommonResponse ViewMultipleMachineListByMakeId(int makeId)
        //{
        //    CommonResponse obj = new CommonResponse();
        //    try
        //    {
        //        var check = (from wf in db.UnitworkccsTblchecklistHeader
        //                     where wf.IsDeleted == 0 && wf.MakeId == makeId && wf.IsApproved==1
        //                     select new
        //                     {
        //                         checkListNo = wf.CheckListNo


        //                     }).ToList();

        //        if (check.Count > 0)
        //        {

        //            obj.isStatus = true;
        //            obj.response = check.Distinct();
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

        public CommonResponse AddAndEditHeaderMachines(addMachines data)
        {
            CommonResponse obj = new CommonResponse();
            CommonFunction commonFunction = new CommonFunction();
            try
            {
                var check = db.UnitworkccsTblChecklistmachines.Where(m => m.CheckListHeaderId == data.headerId && m.IsDeleted == 0).FirstOrDefault();
                if (check == null)
                {
                    UnitworkccsTblChecklistmachines tblHMachines = new UnitworkccsTblChecklistmachines();
                    tblHMachines.CheckListHeaderId = data.headerId;
                    tblHMachines.PlantId = data.plantId;
                    tblHMachines.CategoryId = data.categoryId;
                    tblHMachines.MakeId = data.makeId;
                    tblHMachines.MachineIds = data.MachineIds;
                    tblHMachines.IsDeleted = 0;
                    tblHMachines.CreatedOn = DateTime.Now;
                    db.UnitworkccsTblChecklistmachines.Add(tblHMachines);
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.AddedSuccessMessage;
                }
                else
                {
                    check.PlantId = data.plantId;
                    check.CategoryId = data.categoryId;
                    check.MakeId = data.makeId;
                    check.MachineIds = data.MachineIds;
                    check.IsDeleted = 0;
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

        public CommonResponse ViewMultipleHeaderMachines()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                List<viewHeaderMachines> ViewHeaderListMachines = new List<viewHeaderMachines>();

                var tblDet = db.UnitworkccsTblChecklistmachines.Where(m => m.IsDeleted == 0).ToList();
                if (tblDet.Count > 0)
                {
                    foreach (var hId in tblDet)
                    {

                        viewHeaderMachines ViewHeaderListMachinesOne = new viewHeaderMachines();
                        ViewHeaderListMachinesOne.HeaderId = hId.CheckListHeaderId;
                        ViewHeaderListMachinesOne.CheckListName = db.UnitworkccsTblchecklistHeader.Where(m => m.HeaderId == hId.CheckListHeaderId).Select(m => m.CheckListNo).FirstOrDefault();

                        string[] mids = hId.MachineIds.Split(',');
                        List<string> mIdList = new List<string>();
                        mIdList = mids.ToList();
                        List<MachineDet> mIdNamesList = new List<MachineDet>();

                        foreach (var mDet in mIdList)
                        {
                            var mId = Convert.ToInt32(mDet);
                            MachineDet mIdNames = new MachineDet();
                            mIdNames.machineId = mId;
                            mIdNames.machineName = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == mId).Select(m => m.MachineName).FirstOrDefault();
                            mIdNamesList.Add(mIdNames);
                        }

                        var plantname = db.UnitworkccsTblplant.Where(m => m.PlantId == hId.PlantId).Select(m => m.PlantName).FirstOrDefault();
                        var categoryname = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == hId.CategoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
                        var makename = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == hId.MakeId).Select(m => m.MakeName).FirstOrDefault();
                        ViewHeaderListMachinesOne.plantId = hId.PlantId;
                        ViewHeaderListMachinesOne.plantName = plantname;
                        ViewHeaderListMachinesOne.categoryId = hId.CategoryId;
                        ViewHeaderListMachinesOne.categoryName = categoryname;
                        ViewHeaderListMachinesOne.MakeId = hId.MakeId;
                        ViewHeaderListMachinesOne.makeName = makename;
                        ViewHeaderListMachinesOne.MachinesDet = mIdNamesList;
                        ViewHeaderListMachines.Add(ViewHeaderListMachinesOne);
                    }
                }

                if (ViewHeaderListMachines.Count > 0)
                {
                    obj.isStatus = true;
                    obj.response = ViewHeaderListMachines;
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

        public CommonResponse DeleteHeaderMachine(int HeaderId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTblChecklistmachines.Where(m => m.CheckListHeaderId == HeaderId && m.IsDeleted == 0).FirstOrDefault();
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
        /// Update Check List Header
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse UpdateCheckListHeader(addHeader data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                if (data.flag == 0)
                {
                    var check = db.UnitworkccsTblchecklistHeader.Where(m => m.HeaderId == data.HeaderId && m.IsDeleted == 0).FirstOrDefault();
                    if (check == null)
                    {
                        check.CategoryId = data.categoryId;
                        check.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
                        check.MakeId = data.makeId;
                        check.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
                        check.PreparedBy = data.LoginId;
                        check.CheckListNo = data.checkListNo;
                        check.IsDeleted = 0;
                        check.ModifiedOn = DateTime.Now;
                        db.SaveChanges();
                        string[] checkListNo = data.checkListNo.Split('#');
                        check.CheckListNo = checkListNo[0] + "#" + check.HeaderId;
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






    }
}










//namespace IFacilityMaini.DAL
//{
//    public class CheckListHeaderDAL : ICheckListHeader
//    {
//        unitworksccsContext db = new unitworksccsContext();
//        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(CheckListHeaderDAL));
//        public static IConfiguration configuration;
//        private readonly AppSettings appSettings;

//        public CheckListHeaderDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings)
//        {
//            db = _db;
//            configuration = _configuration;
//            appSettings = _appSettings.Value;
//        }

//        public CommonResponse ViewMultiplePlants()
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = (from wf in db.UnitworkccsTblplant
//                             where wf.IsDeleted == 0
//                             select new
//                             {

//                                 plantId = wf.PlantId,
//                                 plantCode = wf.PlantCode,
//                                 plantName = wf.PlantName
//                             }).ToList();

//                if (check.Count > 0)
//                {
//                    obj.isStatus = true;
//                    obj.response = check;
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

//        public CommonResponse ViewMultipleCategory()
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = (from wf in db.UnitworkccsTblmachinecategorynames
//                             where wf.IsDeleted == 0
//                             select new
//                             {
//                                 categoryId = wf.MachineCategoryId,
//                                 categoryName = wf.MachineCategoryName
//                             }).ToList();

//                if (check.Count > 0)
//                {

//                    obj.isStatus = true;
//                    obj.response = check.Distinct();
//                }
//                else
//                {
//                    obj.isStatus = false;
//                    obj.response = "No Items Found";
//                }
//            }
//            catch (Exception e)
//            {
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        public CommonResponse ViewMultipleMake(int categoryId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = (from wf in db.UnitworkccsTblMachinemakedetails
//                             where wf.IsDeleted == 0 && wf.MachineCategoryId == categoryId
//                             select new
//                             {
//                                 machineId = wf.MakeId,
//                                 machineMake = wf.MakeName
//                             }).ToList();

//                if (check.Count > 0)
//                {

//                    obj.isStatus = true;
//                    obj.response = check.Distinct();
//                }
//                else
//                {
//                    obj.isStatus = false;
//                    obj.response = "No Items Found";
//                }
//            }
//            catch (Exception e)
//            {
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        public CommonResponse GenerateCheckListNo(genNo data)
//        {

//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                string GenNumber = data.category + " (" + data.make + ") -";

//                obj.isStatus = true;
//                obj.response = GenNumber;
//            }

//            catch (Exception e)
//            {
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }

//            return obj;


//        }

//        //public CommonResponse AddAndEditCheckListHeader(addHeader data)
//        //{
//        //    CommonResponse obj = new CommonResponse();
//        //    CommonFunction commonFunction = new CommonFunction();
//        //    try
//        //    {

//        //        var check = db.UnitworkccsTblchecklistHeader.Where(m => m.HeaderId == data.HeaderId && m.IsDeleted == 0).FirstOrDefault();
//        //        if (check == null)
//        //        {

//        //            UnitworkccsTblchecklistHeader tblHeader = new UnitworkccsTblchecklistHeader();
//        //            tblHeader.PlantId = data.plantId;
//        //            tblHeader.PlantName = db.UnitworkccsTblplant.Where(m => m.PlantId == data.plantId).Select(m => m.PlantName).FirstOrDefault();
//        //            tblHeader.CategoryId = data.categoryId;
//        //            tblHeader.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
//        //            tblHeader.MakeId = data.makeId;
//        //            tblHeader.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
//        //            tblHeader.PreparedBy = data.LoginId;
//        //            // tblHeader.PreparedBy = data.LoginId;
//        //            tblHeader.PreparedByDate = DateTime.Now;
//        //            tblHeader.CheckListNo = data.checkListNo;
//        //            tblHeader.RevNo = 1;
//        //            tblHeader.IsDeleted = 0;
//        //            tblHeader.CreatedOn = DateTime.Now;
//        //            db.UnitworkccsTblchecklistHeader.Add(tblHeader);
//        //            db.SaveChanges();
//        //            //   tblHeader.RevNo = tblHeader.HeaderId;
//        //            //  db.SaveChanges();
//        //            obj.isStatus = true;
//        //            obj.response = ResourceResponse.AddedSuccessMessage;
//        //        }
//        //        else
//        //        {

//        //            if (check.IsApproved == 1)
//        //            {
//        //                UnitworkccsTblchecklistHeader tblHeader = new UnitworkccsTblchecklistHeader();
//        //                tblHeader.PlantId = data.plantId;
//        //                tblHeader.PlantName = db.UnitworkccsTblplant.Where(m => m.PlantId == data.plantId).Select(m => m.PlantName).FirstOrDefault();
//        //                tblHeader.CategoryId = data.categoryId;
//        //                tblHeader.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
//        //                tblHeader.MakeId = data.makeId;
//        //                tblHeader.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
//        //                tblHeader.PreparedBy = data.LoginId;
//        //                tblHeader.PreparedByDate = DateTime.Now;
//        //                tblHeader.CheckListNo = data.checkListNo;
//        //                tblHeader.CreationDate = check.CreationDate;
//        //                tblHeader.IsDeleted = 0;
//        //                tblHeader.CreatedOn = DateTime.Now;
//        //                tblHeader.RevNo = 2;
//        //                db.UnitworkccsTblchecklistHeader.Add(tblHeader);
//        //                db.SaveChanges();
//        //                // tblHeader.RevNo = tblHeader.HeaderId;
//        //                // db.SaveChanges();
//        //                obj.isStatus = true;
//        //                obj.response = ResourceResponse.AddedSuccessMessage;
//        //            }

//        //            else
//        //            {
//        //                check.PlantId = data.plantId;
//        //                check.PlantName = db.UnitworkccsTblplant.Where(m => m.PlantId == data.plantId).Select(m => m.PlantName).FirstOrDefault();
//        //                check.CategoryId = data.categoryId;
//        //                check.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
//        //                check.MakeId = data.makeId;
//        //                check.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
//        //                check.PreparedBy = data.LoginId;
//        //                check.CheckListNo = data.checkListNo;
//        //                check.IsDeleted = 0;
//        //                check.ModifiedOn = DateTime.Now;
//        //                db.SaveChanges();
//        //                obj.isStatus = true;
//        //                obj.response = ResourceResponse.UpdatedSuccessMessage;


//        //            }




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

//        public CommonResponse AddAndEditCheckListHeader(addHeader data)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                if (data.flag == 0)
//                {
//                    var check = db.UnitworkccsTblchecklistHeader.Where(m => m.CategoryId == data.categoryId && m.MakeId == data.makeId && m.IsDeleted == 0).FirstOrDefault();
//                    if (check == null)
//                    {
//                        UnitworkccsTblchecklistHeader tblHeader = new UnitworkccsTblchecklistHeader();
//                        tblHeader.CategoryId = data.categoryId;
//                        tblHeader.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
//                        tblHeader.MakeId = data.makeId;
//                        tblHeader.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
//                        tblHeader.PreparedBy = data.LoginId;
//                        var dbCheck = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0).LastOrDefault();
//                        int count = 0;
//                        if (dbCheck != null)
//                        {
//                            string[] arr = dbCheck.CheckListNo.Split('-');
//                            count = Convert.ToInt32(arr[1]) + 1;
//                        }
//                        else
//                        {
//                            count = 1;
//                        }
//                        tblHeader.CheckListNo = data.checkListNo + count;
//                        tblHeader.PreparedByDate = DateTime.Now;
//                        tblHeader.RevNo = 1;
//                        tblHeader.IsDeleted = 0;
//                        tblHeader.CreatedOn = DateTime.Now;
//                        db.UnitworkccsTblchecklistHeader.Add(tblHeader);
//                        db.SaveChanges();
//                        obj.isStatus = true;
//                        obj.response = ResourceResponse.AddedSuccessMessage;
//                    }
//                    else
//                    {
//                        obj.isStatus = false;
//                        obj.response = "CheckList No already Present";
//                    }
//                }
//                else
//                {
//                    string prevCheckListNo = db.UnitworkccsTblchecklistHeader.Where(m => m.HeaderId == data.HeaderId).Select(m => m.CheckListNo).FirstOrDefault();
//                    string[] checkCheckListNo = prevCheckListNo.Split('-');
//                    string[] checkListNo = data.checkListNo.Split('-');

//                    if (checkListNo[0] == checkCheckListNo[0])
//                    {
//                        UnitworkccsTblchecklistHeader tblHeader = new UnitworkccsTblchecklistHeader();
//                        tblHeader.CategoryId = data.categoryId;
//                        tblHeader.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
//                        tblHeader.MakeId = data.makeId;
//                        tblHeader.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
//                        tblHeader.PreparedBy = data.LoginId;
//                        tblHeader.CheckListNo = data.checkListNo;
//                        tblHeader.PreparedByDate = DateTime.Now;
//                        tblHeader.CreationDate = DateTime.Now;
//                        tblHeader.IsDeleted = 0;
//                        tblHeader.CreatedOn = DateTime.Now;
//                        tblHeader.PreviousChecklistHeaderId = data.flag;
//                        db.UnitworkccsTblchecklistHeader.Add(tblHeader);
//                        db.SaveChanges();

//                        var checklistCount = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0).Select(m => m.CheckListNo).ToList();
//                        string[] arr = new string[] { };
//                        int count = 0;
//                        foreach (var item in checklistCount)
//                        {
//                            arr = item.Split('-');
//                            if (arr[1] == checkListNo[1])
//                            {
//                                count++;
//                            }
//                        }

//                        //var matchingvalues = arr.Where(stringToCheck => stringToCheck == checkListNo[0]).Count();

//                        //int count = /*checklistCount.Count();*/matchingvalues;
//                        tblHeader.RevNo = count + 1 - 1;
//                        db.SaveChanges();


//                        var checkListDetails = db.Tblchecklistdetailsnew.Where(m => m.IsDeleted == 0 && m.Flag == data.flag).ToList();

//                        if (checkListDetails.Count > 0)
//                        {
//                            foreach (var items in checkListDetails)
//                            {
//                                if (items.IsAssigned != 1)
//                                {
//                                    if (items.AddEdit == 1 && items.CheckListId != 0)
//                                    {
//                                        UnitworkccsTblchecklistDetails tblCheckList = new UnitworkccsTblchecklistDetails();
//                                        tblCheckList.HeaderId = tblHeader.HeaderId;
//                                        tblCheckList.WhatToCheck = items.WhatToCheck;
//                                        tblCheckList.How = items.How;
//                                        tblCheckList.Frequency = items.Frequency;
//                                        tblCheckList.RunningHrs = items.RunningHrs;
//                                        tblCheckList.PartsCount = items.PartsCount;
//                                        tblCheckList.PeriodFrequency = items.PeriodFrequency;
//                                        tblCheckList.IsNumeric = items.IsNumeric;
//                                        tblCheckList.IsText = items.IsText;
//                                        tblCheckList.RoleId = items.RoleId;
//                                        tblCheckList.Date = items.Date;
//                                        tblCheckList.IsOk = items.IsOk;
//                                        tblCheckList.IsDeleted = items.IsDeleted;
//                                        tblCheckList.CreatedOn = items.CreatedOn;
//                                        tblCheckList.CreatedBy = items.CreatedBy;
//                                        tblCheckList.ModifiedBy = items.ModifiedBy;
//                                        tblCheckList.ModifiedOn = items.ModifiedOn;
//                                        tblCheckList.IsPrepared = items.IsPrepared;
//                                        tblCheckList.IsApproved = items.IsApproved;
//                                        tblCheckList.Comment = items.Comment;
//                                        tblCheckList.NumericValue = items.NumericValue;
//                                        tblCheckList.TextValue = items.TextValue;
//                                        tblCheckList.IsDashBoardEntry = items.IsDashBoardEntry;
//                                        tblCheckList.PreviousChecklistId = items.CheckListId;
//                                        db.UnitworkccsTblchecklistDetails.Add(tblCheckList);
//                                        db.SaveChanges();

//                                        if (checkListNo[0] == checkCheckListNo[0])
//                                        {
//                                            var dbCheck = db.Tblchecklistdetailsnew.Where(m => m.CheckListNewId == items.CheckListNewId).FirstOrDefault();
//                                            if (dbCheck != null)
//                                            {
//                                                dbCheck.HeaderId = tblHeader.HeaderId;
//                                                dbCheck.IsAssigned = 1;
//                                                db.SaveChanges();
//                                            }
//                                        }

//                                        var checkListDet = db.UnitworkccsTblchecklistDetails.Where(m => m.HeaderId == data.HeaderId && m.CheckListId != items.CheckListId && m.IsDeleted == 0).ToList();
//                                        foreach (var item in checkListDet)
//                                        {
//                                            UnitworkccsTblchecklistDetails tblCheckList1 = new UnitworkccsTblchecklistDetails();
//                                            tblCheckList1.HeaderId = tblHeader.HeaderId;
//                                            tblCheckList1.WhatToCheck = item.WhatToCheck;
//                                            tblCheckList1.How = item.How;
//                                            tblCheckList1.Frequency = item.Frequency;
//                                            tblCheckList1.RunningHrs = item.RunningHrs;
//                                            tblCheckList1.PartsCount = item.PartsCount;
//                                            tblCheckList1.PeriodFrequency = item.PeriodFrequency;
//                                            tblCheckList1.IsNumeric = item.IsNumeric;
//                                            tblCheckList1.IsText = item.IsText;
//                                            tblCheckList1.RoleId = item.RoleId;
//                                            tblCheckList1.Date = item.Date;
//                                            tblCheckList1.IsOk = item.IsOk;
//                                            tblCheckList1.IsDeleted = item.IsDeleted;
//                                            tblCheckList1.CreatedOn = item.CreatedOn;
//                                            tblCheckList1.CreatedBy = item.CreatedBy;
//                                            tblCheckList1.ModifiedBy = item.ModifiedBy;
//                                            tblCheckList1.ModifiedOn = item.ModifiedOn;
//                                            tblCheckList1.IsPrepared = item.IsPrepared;
//                                            tblCheckList1.IsApproved = item.IsApproved;
//                                            tblCheckList1.Comment = item.Comment;
//                                            tblCheckList1.NumericValue = item.NumericValue;
//                                            tblCheckList1.TextValue = item.TextValue;
//                                            tblCheckList1.IsDashBoardEntry = item.IsDashBoardEntry;
//                                            tblCheckList1.PreviousChecklistId = item.CheckListId;
//                                            db.UnitworkccsTblchecklistDetails.Add(tblCheckList1);
//                                            db.SaveChanges();
//                                        }
//                                    }
//                                    else
//                                    {
//                                        if (items.AddEdit == 0 && items.CheckListId == 0 && items.IsDeleted == 0)
//                                        {
//                                            UnitworkccsTblchecklistDetails tblCheckList = new UnitworkccsTblchecklistDetails();
//                                            tblCheckList.HeaderId = tblHeader.HeaderId;
//                                            tblCheckList.WhatToCheck = items.WhatToCheck;
//                                            tblCheckList.How = items.How;
//                                            tblCheckList.Frequency = items.Frequency;
//                                            tblCheckList.RunningHrs = items.RunningHrs;
//                                            tblCheckList.PartsCount = items.PartsCount;
//                                            tblCheckList.PeriodFrequency = items.PeriodFrequency;
//                                            tblCheckList.IsNumeric = items.IsNumeric;
//                                            tblCheckList.IsText = items.IsText;
//                                            tblCheckList.RoleId = items.RoleId;
//                                            tblCheckList.Date = items.Date;
//                                            tblCheckList.IsOk = items.IsOk;
//                                            tblCheckList.IsDeleted = items.IsDeleted;
//                                            tblCheckList.CreatedOn = items.CreatedOn;
//                                            tblCheckList.CreatedBy = items.CreatedBy;
//                                            tblCheckList.ModifiedBy = items.ModifiedBy;
//                                            tblCheckList.ModifiedOn = items.ModifiedOn;
//                                            tblCheckList.IsPrepared = items.IsPrepared;
//                                            tblCheckList.IsApproved = items.IsApproved;
//                                            tblCheckList.Comment = items.Comment;
//                                            tblCheckList.NumericValue = items.NumericValue;
//                                            tblCheckList.TextValue = items.TextValue;
//                                            tblCheckList.IsDashBoardEntry = items.IsDashBoardEntry;
//                                            tblCheckList.PreviousChecklistId = items.CheckListId;
//                                            db.UnitworkccsTblchecklistDetails.Add(tblCheckList);
//                                            db.SaveChanges();

//                                            if (checkListNo[0] == checkCheckListNo[0])
//                                            {
//                                                var dbCheck = db.Tblchecklistdetailsnew.Where(m => m.CheckListNewId == items.CheckListNewId).FirstOrDefault();
//                                                if (dbCheck != null)
//                                                {
//                                                    dbCheck.HeaderId = tblHeader.HeaderId;
//                                                    dbCheck.IsAssigned = 1;
//                                                    db.SaveChanges();
//                                                }
//                                            }

//                                            var checkListDet = db.UnitworkccsTblchecklistDetails.Where(m => m.HeaderId == data.HeaderId && m.IsDeleted == 0).ToList();
//                                            foreach (var item in checkListDet)
//                                            {
//                                                UnitworkccsTblchecklistDetails tblCheckList1 = new UnitworkccsTblchecklistDetails();
//                                                tblCheckList1.HeaderId = tblHeader.HeaderId;
//                                                tblCheckList1.WhatToCheck = item.WhatToCheck;
//                                                tblCheckList1.How = item.How;
//                                                tblCheckList1.Frequency = item.Frequency;
//                                                tblCheckList1.RunningHrs = item.RunningHrs;
//                                                tblCheckList1.PartsCount = item.PartsCount;
//                                                tblCheckList1.PeriodFrequency = item.PeriodFrequency;
//                                                tblCheckList1.IsNumeric = item.IsNumeric;
//                                                tblCheckList1.IsText = item.IsText;
//                                                tblCheckList1.RoleId = item.RoleId;
//                                                tblCheckList1.Date = item.Date;
//                                                tblCheckList1.IsOk = item.IsOk;
//                                                tblCheckList1.IsDeleted = item.IsDeleted;
//                                                tblCheckList1.CreatedOn = item.CreatedOn;
//                                                tblCheckList1.CreatedBy = item.CreatedBy;
//                                                tblCheckList1.ModifiedBy = item.ModifiedBy;
//                                                tblCheckList1.ModifiedOn = item.ModifiedOn;
//                                                tblCheckList1.IsPrepared = item.IsPrepared;
//                                                tblCheckList1.IsApproved = item.IsApproved;
//                                                tblCheckList1.Comment = item.Comment;
//                                                tblCheckList1.NumericValue = item.NumericValue;
//                                                tblCheckList1.TextValue = item.TextValue;
//                                                tblCheckList1.IsDashBoardEntry = item.IsDashBoardEntry;
//                                                tblCheckList1.PreviousChecklistId = item.CheckListId;
//                                                db.UnitworkccsTblchecklistDetails.Add(tblCheckList1);
//                                                db.SaveChanges();
//                                            }
//                                        }
//                                    }
//                                }
//                            }
//                            obj.isStatus = true;
//                            obj.response = ResourceResponse.AddedSuccessMessage;
//                        }

//                    }
//                    else
//                    {
//                        var checks = db.UnitworkccsTblchecklistHeader.Where(m => m.CheckListNo.Contains(data.checkListNo) && m.IsDeleted == 0).FirstOrDefault();
//                        if (checks == null)
//                        {
//                            UnitworkccsTblchecklistHeader tblHeader1 = new UnitworkccsTblchecklistHeader();
//                            tblHeader1.CategoryId = data.categoryId;
//                            tblHeader1.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
//                            tblHeader1.MakeId = data.makeId;
//                            tblHeader1.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
//                            tblHeader1.PreparedBy = data.LoginId;
//                            tblHeader1.PreparedByDate = DateTime.Now;
//                            // tblHeader.CheckListNo = data.checkListNo;
//                            tblHeader1.CreationDate = DateTime.Now;
//                            tblHeader1.IsDeleted = 0;
//                            tblHeader1.CreatedOn = DateTime.Now;
//                            tblHeader1.PreviousChecklistHeaderId = data.flag;
//                            //int revInc = check.RevNo;
//                            tblHeader1.RevNo = 1;
//                            db.UnitworkccsTblchecklistHeader.Add(tblHeader1);
//                            db.SaveChanges();

//                            tblHeader1.CheckListNo = checkListNo[0] + "-" + tblHeader1.HeaderId;
//                            db.SaveChanges();

//                            var checkListDet = db.UnitworkccsTblchecklistDetails.Where(m => m.HeaderId == data.HeaderId && m.IsDeleted == 0).ToList();
//                            foreach (var item in checkListDet)
//                            {
//                                UnitworkccsTblchecklistDetails tblCheckList1 = new UnitworkccsTblchecklistDetails();
//                                tblCheckList1.HeaderId = tblHeader1.HeaderId;
//                                tblCheckList1.WhatToCheck = item.WhatToCheck;
//                                tblCheckList1.How = item.How;
//                                tblCheckList1.Frequency = item.Frequency;
//                                tblCheckList1.RunningHrs = item.RunningHrs;
//                                tblCheckList1.PartsCount = item.PartsCount;
//                                tblCheckList1.PeriodFrequency = item.PeriodFrequency;
//                                tblCheckList1.IsNumeric = item.IsNumeric;
//                                tblCheckList1.IsText = item.IsText;
//                                tblCheckList1.RoleId = item.RoleId;
//                                tblCheckList1.Date = item.Date;
//                                tblCheckList1.IsOk = item.IsOk;
//                                tblCheckList1.IsDeleted = item.IsDeleted;
//                                tblCheckList1.CreatedOn = item.CreatedOn;
//                                tblCheckList1.CreatedBy = item.CreatedBy;
//                                tblCheckList1.ModifiedBy = item.ModifiedBy;
//                                tblCheckList1.ModifiedOn = item.ModifiedOn;
//                                tblCheckList1.IsPrepared = item.IsPrepared;
//                                tblCheckList1.IsApproved = item.IsApproved;
//                                tblCheckList1.Comment = item.Comment;
//                                tblCheckList1.NumericValue = item.NumericValue;
//                                tblCheckList1.TextValue = item.TextValue;
//                                tblCheckList1.IsDashBoardEntry = item.IsDashBoardEntry;
//                                tblCheckList1.PreviousChecklistId = item.CheckListId;
//                                db.UnitworkccsTblchecklistDetails.Add(tblCheckList1);
//                                db.SaveChanges();
//                            }
//                        }
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

//        public CommonResponse ViewMultipleCheckListHeader()
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

//                var tblDet = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0).ToList();

//                foreach (var items in tblDet)
//                {
//                    viewHeaders ViewHeader1 = new viewHeaders();

//                    ViewHeader1.headerId = items.HeaderId;
//                    //ViewHeader1.plantId = (int)items.PlantId;
//                    //ViewHeader1.plantName = items.PlantName;

//                    //ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();
//                    // ViewHeader1.id = items.HeaderId;
//                    //  ViewHeader1.plantCode = items.PlantName;
//                    ViewHeader1.categoryId = (int)items.CategoryId;
//                    ViewHeader1.categoryName = items.CategoryName;
//                    ViewHeader1.makeId = (int)items.MakeId;
//                    ViewHeader1.makeName = items.MakeName;

//                    if (items.CreationDate == null)
//                    {
//                        ViewHeader1.creationDate = null;
//                    }
//                    else
//                    {
//                        DateTime cdate = (DateTime)items.CreationDate;
//                        ViewHeader1.showCreationDate = cdate.ToString("dd-MM-yyyy");
//                        ViewHeader1.creationDate = cdate.ToString("yyyy-MM-dd");
//                    }

//                    ViewHeader1.revNo = items.RevNo;
//                    if (items.LastRevDate == null)
//                    {
//                        ViewHeader1.lastRevDate = null;
//                    }

//                    else
//                    {
//                        DateTime rvdate = (DateTime)items.LastRevDate;
//                        ViewHeader1.showLastRevDate = rvdate.ToString("dd-MM-yyyy");
//                        ViewHeader1.lastRevDate = rvdate.ToString("yyyy-MM-dd");

//                    }
//                    // ViewHeader1.checkListNo = items.CheckListNo + items.HeaderId;
//                    ViewHeader1.checkListNo = items.CheckListNo;
//                    ViewHeader1.id = items.HeaderId;
//                    ViewHeader1.preparedBy = (int)items.PreparedBy;
//                    ViewHeader1.preparedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                    if (items.PreparedByDate == null)
//                    {
//                        ViewHeader1.preparedByDate = null;
//                    }

//                    else
//                    {
//                        DateTime pdate = (DateTime)items.PreparedByDate;
//                        ViewHeader1.showPreparedByDate = pdate.ToString("dd-MM-yyyy");
//                        ViewHeader1.preparedByDate = pdate.ToString("yyyy-MM-dd");

//                    }
//                    ViewHeader1.approvedBy = items.ApprovedBy;
//                    ViewHeader1.approvedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                    if (items.ApprovedByDate == null)
//                    {
//                        ViewHeader1.approvedByDate = null;
//                    }

//                    else
//                    {
//                        DateTime adate = (DateTime)items.ApprovedByDate;
//                        ViewHeader1.showApprovedByDate = adate.ToString("dd-MM-yyyy");
//                        ViewHeader1.approvedByDate = adate.ToString("yyyy-MM-dd");
//                    }

//                    // ViewHeader1.isApproved =items.IsApproved;
//                    ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
//                    var checklistIntbl = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).ToList();

//                    if (checklistIntbl.Count == 0)
//                    {
//                        ViewHeader1.pendingCheckList = "check list details not created for this HeaderId";
//                    }
//                    else
//                    {
//                        int countl = 0;
//                        foreach (var ll in checklistIntbl)
//                        {
//                            if (ll.IsOk != "OK")
//                            {
//                                countl += 1;
//                            }
//                        }

//                        if (countl != 0)
//                        {

//                            ViewHeader1.pendingCheckList = "pending check list = " + countl + "";
//                            ViewHeader1.postToApprover = 1;
//                        }
//                        else
//                        {
//                            ViewHeader1.pendingCheckList = "all check list OK";
//                            ViewHeader1.postToApprover = 0;
//                        }
//                    }
//                    var PTAbutton = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).ToList();

//                    var ispre = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).FirstOrDefault();

//                    if (PTAbutton.Count == 0)
//                    {
//                        ViewHeader1.postToApprover = 0;
//                    }
//                    else
//                    {
//                        if (ispre.IsPrepared == null && ispre != null)
//                        {
//                            ViewHeader1.postToApprover = 1;
//                        }
//                    }

//                    if (ispre.IsPrepared == 1)
//                    {
//                        int notokthere = 0;
//                        int notOkEdited = 0;

//                        foreach (var isnotok in PTAbutton)
//                        {
//                            if (isnotok.IsOk == "NOTOK" && isnotok.IsEdited == 0 && isnotok.IsPrepared == 0 && isnotok.IsApproved == 0)
//                            {
//                                notokthere++;
//                            }
//                            else if (isnotok.IsOk == "NOTOK" && isnotok.IsEdited == 1 && isnotok.IsPrepared == 0 && isnotok.IsApproved == 0)
//                            {
//                                notOkEdited++;
//                            }
//                        }

//                        if (notokthere > 0)
//                        {
//                            ViewHeader1.postToApprover = 0;
//                        }
//                        else if (notOkEdited > 0)
//                        {
//                            ViewHeader1.postToApprover = 1;
//                        }
//                        else
//                        {
//                            ViewHeader1.postToApprover = 0;
//                        }
//                    }

//                    //if (ispre.IsPrepared == 1)
//                    //{
//                    //    int notokthere = 0;

//                    //    foreach (var isnotok in PTAbutton)
//                    //    {
//                    //        if (isnotok.IsOk == "NOTOK" && isnotok.ModifiedOn == null)
//                    //        {
//                    //            notokthere++;
//                    //        }
//                    //    }

//                    //    if (notokthere > 0)
//                    //    {
//                    //        ViewHeader1.postToApprover = 0;
//                    //    }
//                    //    else
//                    //    {
//                    //        ViewHeader1.postToApprover = 1;
//                    //    }
//                    //}

//                    if (ispre.IsPrepared == 1 && ispre.ApprovedBy == null)
//                    {
//                        ViewHeader1.postToApprover = 0;
//                    }


//                    var checklistIntbl2 = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).ToList();

//                    int len = checklistIntbl2.Count;
//                    int len2 = 0;
//                    if (len > 0)
//                    {
//                        foreach (var ee in checklistIntbl2)
//                        {
//                            if (ee.IsOk == "OK")
//                            {
//                                len2++;
//                            }
//                        }

//                        if (len2 == len)
//                        {
//                            ViewHeader1.pendingCheckList = "all check list OK";
//                            ViewHeader1.postToApprover = 0;
//                        }

//                    }


//                    // ViewHeader1.preparedLogin = items.PreparedBy == null ? 0 : 1;
//                    //  ViewHeader1.approvedLogin = items.ApprovedBy == null ? 0 : 1;

//                    ViewHeaderList.Add(ViewHeader1);

//                }


//                //var check = (from wf in db.UnitworkccsTblchecklistHeader
//                //       where wf.IsDeleted == 0
//                //       select new
//                //       {

//                //           headerId = wf.HeaderId,
//                //           plantId = wf.PlantId,
//                //           plantName = wf.PlantName,
//                //           categoryId = wf.CategoryId,
//                //           categoryName = wf.CategoryName,
//                //           makeId = wf.MakeId,
//                //           makeName = wf.MakeName,
//                //           creationDate  = wf.CreationDate,
//                //           revNo = wf.RevNo,
//                //           lastRevDate = wf.LastRevDate,
//                //           checkListNo = wf.CheckListNo + wf.RevNo,
//                //           preparedBy = wf.PreparedBy,
//                //           preparedByDate = wf.PreparedByDate,
//                //           approvedBy = wf.ApprovedBy,
//                //           approvedByDate = wf.ApprovedByDate
//                //       }).ToList();

//                if (ViewHeaderList.Count > 0)
//                {
//                    obj.isStatus = true;
//                    obj.response = ViewHeaderList;
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

//        public CommonResponse FulldetailsForRevButton(int headerId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                //  List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

//                var items = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.HeaderId == headerId).FirstOrDefault();


//                viewHeadersAndDet ViewHeader1 = new viewHeadersAndDet();

//                ViewHeader1.headerId = items.HeaderId;
//                ViewHeader1.plantId = (int)items.PlantId;
//                ViewHeader1.plantName = items.PlantName;
//                ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault(); ;
//                ViewHeader1.categoryId = (int)items.CategoryId;
//                ViewHeader1.categoryName = items.CategoryName;
//                ViewHeader1.makeId = (int)items.MakeId;
//                ViewHeader1.makeName = items.MakeName;

//                if (items.CreationDate == null)
//                {
//                    ViewHeader1.creationDate = null;
//                }
//                else
//                {
//                    DateTime cdate = (DateTime)items.CreationDate;
//                    ViewHeader1.showCreationDate = cdate.ToString("dd-MM-yyyy");
//                    ViewHeader1.creationDate = cdate.ToString("yyyy-MM-dd");
//                }

//                ViewHeader1.revNo = items.RevNo;



//                if (items.LastRevDate == null)
//                {
//                    ViewHeader1.lastRevDate = null;
//                }

//                else
//                {
//                    DateTime rvdate = (DateTime)items.LastRevDate;
//                    ViewHeader1.showLastRevDate = rvdate.ToString("dd-MM-yyyy");
//                    ViewHeader1.lastRevDate = rvdate.ToString("yyyy-MM-dd");

//                }
//                // ViewHeader1.checkListNo = items.CheckListNo + items.HeaderId;
//                ViewHeader1.checkListNo = items.CheckListNo;
//                ViewHeader1.id = items.HeaderId;
//                ViewHeader1.preparedBy = (int)items.PreparedBy;
//                ViewHeader1.preparedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                if (items.PreparedByDate == null)
//                {
//                    ViewHeader1.preparedByDate = null;
//                }

//                else
//                {
//                    DateTime pdate = (DateTime)items.PreparedByDate;
//                    ViewHeader1.showPreparedByDate = pdate.ToString("dd-MM-yyyy");
//                    ViewHeader1.preparedByDate = pdate.ToString("yyyy-MM-dd");

//                }
//                ViewHeader1.approvedBy = items.ApprovedBy;
//                ViewHeader1.approvedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                if (items.ApprovedByDate == null)
//                {
//                    ViewHeader1.approvedByDate = null;
//                }

//                else
//                {
//                    DateTime adate = (DateTime)items.ApprovedByDate;
//                    ViewHeader1.showApprovedByDate = adate.ToString("dd-MM-yyyy");
//                    ViewHeader1.approvedByDate = adate.ToString("yyyy-MM-dd");
//                }

//                // ViewHeader1.isApproved =items.IsApproved;
//                ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;



//                //var checklistIntbl = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).ToList();

//                //if (checklistIntbl.Count == 0)
//                //{
//                //    ViewHeader1.pendingCheckList = "check list details not created for this HeaderId";

//                //}

//                //else
//                //{
//                //    int countl = 0;
//                //    foreach (var ll in checklistIntbl)
//                //    {
//                //        if (ll.IsOk != "OK")
//                //        {
//                //            countl += 1;
//                //        }

//                //    }

//                //    if (countl != 0)
//                //    {

//                //        ViewHeader1.pendingCheckList = "pending check list = " + countl + "";
//                //        ViewHeader1.postToApprover = 1;
//                //    }
//                //    else
//                //    {
//                //        ViewHeader1.pendingCheckList = "all check list OK";
//                //        ViewHeader1.postToApprover = 0;
//                //    }
//                //}
//                //var PTAbutton = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).ToList();

//                //var ispre = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).FirstOrDefault();

//                //if (PTAbutton.Count == 0)
//                //{
//                //    ViewHeader1.postToApprover = 0;

//                //}

//                //else
//                //{

//                //    if (ispre.IsPrepared == null && ispre != null)

//                //    {
//                //        ViewHeader1.postToApprover = 1;

//                //    }


//                //}


//                //if (ispre.IsPrepared == 1)
//                //{

//                //    int notokthere = 0;
//                //    foreach (var isnotok in PTAbutton)
//                //    {
//                //        if (isnotok.IsOk == "NOTOK" && isnotok.ModifiedOn == null)
//                //        {
//                //            notokthere++;
//                //        }

//                //    }

//                //    if (notokthere > 0)
//                //    {
//                //        ViewHeader1.postToApprover = 0;
//                //    }
//                //    else
//                //    {
//                //        ViewHeader1.postToApprover = 1;

//                //    }

//                //}





//                //if (ispre.IsPrepared == 1 && ispre.ApprovedBy == null)
//                //{
//                //    ViewHeader1.postToApprover = 0;

//                //}


//                //var checklistIntbl2 = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).ToList();

//                //int len = checklistIntbl2.Count;
//                //int len2 = 0;
//                //if (len > 0)
//                //{
//                //    foreach (var ee in checklistIntbl2)
//                //    {
//                //        if (ee.IsOk == "OK")
//                //        {
//                //            len2++;
//                //        }


//                //    }

//                //    if (len2 == len)
//                //    {
//                //        ViewHeader1.pendingCheckList = "all check list OK";
//                //        ViewHeader1.postToApprover = 0;
//                //    }

//                //}


//                // ViewHeader1.preparedLogin = items.PreparedBy == null ? 0 : 1;
//                //  ViewHeader1.approvedLogin = items.ApprovedBy == null ? 0 : 1;

//                // ViewHeaderList.Add(ViewHeader1);


//                List<ViewCheckList> ViewCheckedListDet = new List<ViewCheckList>();

//                var tblDet1 = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == headerId).ToList();

//                foreach (var items1 in tblDet1)
//                {
//                    ViewCheckList ViewChecklist = new ViewCheckList();
//                    ViewChecklist.checkListId = items1.CheckListId;
//                    ViewChecklist.headerId = (int)items1.HeaderId;
//                    ViewChecklist.whatToCheck = items1.WhatToCheck;
//                    //   ViewChecklist.how = items.How;
//                    string[] howSplite = items1.How.Split(',');

//                    ViewChecklist.how = howSplite;
//                    ViewChecklist.frequency = items1.Frequency;
//                    ViewChecklist.runningHrs = items1.RunningHrs;
//                    ViewChecklist.partsCount = (int)items1.PartsCount;
//                    ViewChecklist.periodFrequency = items1.PeriodFrequency;
//                    ViewChecklist.isNumeric = Convert.ToBoolean(items1.IsNumeric);
//                    ViewChecklist.isText = Convert.ToBoolean(items1.IsText);
//                    ViewChecklist.roleId = items1.RoleId;
//                    ViewChecklist.roleName = db.UnitworkccsTblroles.Where(m => m.RoleId == items1.RoleId).Select(m => m.RoleName).FirstOrDefault();
//                    // ViewChecklist.ok = items.IsOk;
//                    if (items1.IsOk == "OK")
//                    {
//                        ViewChecklist.ok = "1";
//                    }
//                    else if (items1.IsOk == "NOTOK")
//                    {
//                        ViewChecklist.ok = "0";
//                        ViewChecklist.comment = items1.Comment;
//                    }
//                    else
//                    {
//                        ViewChecklist.ok = null;
//                    }

//                    //  string[] datesplite = items.Date.Split(',');


//                    // ViewChecklist.dateList = datesplite;


//                    if (items1.Date != "")
//                    {
//                        string[] datesplite = items1.Date.Split(',');
//                        ViewChecklist.dateList = datesplite;
//                        string[] showdate;

//                        List<string> datelist = new List<string>();
//                        foreach (var dt in datesplite)
//                        {
//                            DateTime ddtt = Convert.ToDateTime(dt);
//                            string dt1 = ddtt.ToString("dd-MM-yyyy");

//                            datelist.Add(dt1);
//                            //savedate += dt1 + ",";

//                        }

//                        showdate = datelist.ToArray();

//                        ViewChecklist.showDateList = showdate;
//                    }
//                    else
//                    {
//                        ViewChecklist.showDateList = new string[] { };
//                    }

//                    // string[] datesplite = data.Date.Split(',');
//                    //  string showdate = "";




//                    //List<date> dddlist = new List<date>();

//                    //string[] datesplite = items.Date.Split();

//                    //foreach (var dd in datesplite)
//                    //{
//                    //    date ddd = new date();
//                    //    ddd.dateArray = dd;
//                    //    dddlist.Add(ddd);
//                    //}
//                    //ViewChecklist.dateList = dddlist;
//                    //  ViewChecklist.dateList.dateArray = items.Date;
//                    //if (items.Date == null)
//                    //{
//                    //    ViewChecklist.date = null;
//                    //}
//                    //else
//                    //{
//                    //    DateTime dt = (DateTime)items.Date;
//                    //    string date1 = dt.ToString("yyyy-MM-dd");
//                    //    ViewChecklist.date = date1;

//                    //}

//                    ViewCheckedListDet.Add(ViewChecklist);

//                }



//                ViewHeader1.checkListDetails = ViewCheckedListDet;



//                if (ViewHeader1 != null)
//                {
//                    obj.isStatus = true;
//                    obj.response = ViewHeader1;
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

//        public CommonResponse ViewMultipleCheckListHeaderByOperatorId(int operatorId)
//        {


//            CommonResponse obj = new CommonResponse();
//            try
//            {

//                List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

//                var tblDet = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.PreparedBy == operatorId).ToList();
//                if (tblDet.Count > 0)

//                {

//                    foreach (var items in tblDet)
//                    {
//                        viewHeaders ViewHeader1 = new viewHeaders();

//                        ViewHeader1.headerId = items.HeaderId;
//                        //ViewHeader1.plantId = (int)items.PlantId;
//                        //ViewHeader1.plantName = items.PlantName;
//                        //ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();
//                        ViewHeader1.id = items.HeaderId;
//                        ViewHeader1.categoryId = (int)items.CategoryId;
//                        ViewHeader1.categoryName = items.CategoryName;
//                        ViewHeader1.makeId = (int)items.MakeId;
//                        ViewHeader1.makeName = items.MakeName;

//                        if (items.CreationDate == null)
//                        {
//                            ViewHeader1.creationDate = null;
//                        }

//                        else
//                        {
//                            DateTime cdate = (DateTime)items.CreationDate;

//                            ViewHeader1.showCreationDate = cdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.creationDate = cdate.ToString("yyyy-MM-dd");

//                        }

//                        ViewHeader1.revNo = items.RevNo;



//                        if (items.LastRevDate == null)
//                        {
//                            ViewHeader1.lastRevDate = null;
//                        }

//                        else
//                        {
//                            DateTime rvdate = (DateTime)items.LastRevDate;
//                            ViewHeader1.showLastRevDate = rvdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.lastRevDate = rvdate.ToString("yyyy-MM-dd");

//                        }


//                        // ViewHeader1.checkListNo = items.CheckListNo + items.HeaderId;
//                        ViewHeader1.checkListNo = items.CheckListNo;
//                        ViewHeader1.preparedBy = (int)items.PreparedBy;
//                        ViewHeader1.preparedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                        if (items.PreparedByDate == null)
//                        {
//                            ViewHeader1.preparedByDate = null;
//                        }

//                        else
//                        {
//                            DateTime pdate = (DateTime)items.PreparedByDate;
//                            ViewHeader1.showPreparedByDate = pdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.preparedByDate = pdate.ToString("yyyy-MM-dd");
//                        }


//                        ViewHeader1.approvedBy = items.ApprovedBy;
//                        ViewHeader1.approvedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                        if (items.ApprovedByDate == null)
//                        {
//                            ViewHeader1.approvedByDate = null;
//                        }

//                        else
//                        {
//                            DateTime adate = (DateTime)items.ApprovedByDate;
//                            ViewHeader1.showApprovedByDate = adate.ToString("dd-MM-yyyy");
//                            ViewHeader1.approvedByDate = adate.ToString("yyyy-MM-dd");

//                        }

//                        // ViewHeader1.isApproved = items.IsApproved;
//                        ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
//                        ViewHeader1.preparedLogin = 1;
//                        ViewHeader1.approvedLogin = 0;


//                        ViewHeaderList.Add(ViewHeader1);

//                    }

//                    if (ViewHeaderList.Count > 0)
//                    {
//                        obj.isStatus = true;
//                        obj.response = ViewHeaderList;
//                    }
//                    else
//                    {
//                        obj.isStatus = false;
//                        obj.response = ResourceResponse.NoItemsFound;
//                    }

//                }
//                else
//                {
//                    //int roleid =(int) db.UnitworkccsTbloperatordetails.Where(m => m.OpId == operatorId).Select(m => m.RoleId).FirstOrDefault();

//                    //if (roleid ==22)
//                    //{
//                    var tblDet1 = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.IsPrepared == 1).ToList();
//                    if (tblDet1.Count > 0)

//                    {

//                        foreach (var items in tblDet1)
//                        {
//                            viewHeaders ViewHeader1 = new viewHeaders();

//                            ViewHeader1.headerId = items.HeaderId;
//                            //ViewHeader1.plantId = (int)items.PlantId;
//                            //ViewHeader1.plantName = items.PlantName;
//                            //ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();
//                            ViewHeader1.id = items.HeaderId;
//                            ViewHeader1.categoryId = (int)items.CategoryId;
//                            ViewHeader1.categoryName = items.CategoryName;
//                            ViewHeader1.makeId = (int)items.MakeId;
//                            ViewHeader1.makeName = items.MakeName;

//                            if (items.CreationDate == null)
//                            {
//                                ViewHeader1.creationDate = null;
//                            }

//                            else
//                            {
//                                DateTime cdate = (DateTime)items.CreationDate;

//                                ViewHeader1.showCreationDate = cdate.ToString("dd-MM-yyyy");
//                                ViewHeader1.creationDate = cdate.ToString("yyyy-MM-dd");
//                            }

//                            ViewHeader1.revNo = items.RevNo;



//                            if (items.LastRevDate == null)
//                            {
//                                ViewHeader1.lastRevDate = null;
//                            }

//                            else
//                            {
//                                DateTime rvdate = (DateTime)items.LastRevDate;
//                                ViewHeader1.showLastRevDate = rvdate.ToString("dd-MM-yyyy");

//                                ViewHeader1.lastRevDate = rvdate.ToString("yyyy-MM-dd");

//                            }


//                            //ViewHeader1.checkListNo = items.CheckListNo + items.HeaderId;
//                            ViewHeader1.checkListNo = items.CheckListNo;
//                            ViewHeader1.preparedBy = (int)items.PreparedBy;
//                            ViewHeader1.preparedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                            if (items.PreparedByDate == null)
//                            {
//                                ViewHeader1.preparedByDate = null;
//                            }

//                            else
//                            {
//                                DateTime pdate = (DateTime)items.PreparedByDate;
//                                ViewHeader1.showPreparedByDate = pdate.ToString("dd-MM-yyyy");
//                                ViewHeader1.preparedByDate = pdate.ToString("yyyy-MM-dd");


//                            }


//                            ViewHeader1.approvedBy = items.ApprovedBy;
//                            ViewHeader1.approvedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                            if (items.ApprovedByDate == null)
//                            {
//                                ViewHeader1.approvedByDate = null;
//                            }

//                            else
//                            {
//                                DateTime adate = (DateTime)items.ApprovedByDate;
//                                ViewHeader1.showApprovedByDate = adate.ToString("dd-MM-yyyy");
//                                ViewHeader1.approvedByDate = adate.ToString("yyyy-MM-dd");

//                            }

//                            // ViewHeader1.isApproved = items.IsApproved;
//                            ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
//                            ViewHeader1.preparedLogin = 0;
//                            ViewHeader1.approvedLogin = 1;


//                            ViewHeaderList.Add(ViewHeader1);

//                        }

//                        if (ViewHeaderList.Count > 0)
//                        {
//                            obj.isStatus = true;
//                            obj.response = ViewHeaderList;
//                        }
//                        else
//                        {
//                            obj.isStatus = false;
//                            obj.response = ResourceResponse.NoItemsFound;
//                        }

//                    }

//                    // }
//                    //else
//                    //{

//                    //    obj.isStatus = false;
//                    //    obj.response ="operator id is not a Approver id";


//                    //}

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

//        public CommonResponse ViewCheckListPlantId(int plantId)
//        {

//            /*, int operatorId*/
//            CommonResponse obj = new CommonResponse();
//            try
//            {

//                // List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

//                // var tblDet = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.PlantId==plantId).ToList();

//                List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

//                var tblDet = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.PlantId == plantId).ToList();
//                if (tblDet.Count > 0)

//                {

//                    foreach (var items in tblDet)
//                    {
//                        viewHeaders ViewHeader1 = new viewHeaders();

//                        ViewHeader1.headerId = items.HeaderId;
//                        ViewHeader1.plantId = (int)items.PlantId;
//                        ViewHeader1.plantName = items.PlantName;


//                        ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();
//                        ViewHeader1.id = items.HeaderId;
//                        ViewHeader1.categoryId = (int)items.CategoryId;
//                        ViewHeader1.categoryName = items.CategoryName;
//                        ViewHeader1.makeId = (int)items.MakeId;
//                        ViewHeader1.makeName = items.MakeName;

//                        if (items.CreationDate == null)
//                        {
//                            ViewHeader1.creationDate = null;
//                        }

//                        else
//                        {
//                            DateTime cdate = (DateTime)items.CreationDate;

//                            ViewHeader1.showCreationDate = cdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.creationDate = cdate.ToString("yyyy-MM-dd");

//                        }

//                        ViewHeader1.revNo = items.RevNo;



//                        if (items.LastRevDate == null)
//                        {
//                            ViewHeader1.lastRevDate = null;
//                        }

//                        else
//                        {
//                            DateTime rvdate = (DateTime)items.LastRevDate;
//                            ViewHeader1.showLastRevDate = rvdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.lastRevDate = rvdate.ToString("yyyy-MM-dd");

//                        }


//                        // ViewHeader1.checkListNo = items.CheckListNo + items.RevNo;
//                        ViewHeader1.checkListNo = items.CheckListNo;
//                        ViewHeader1.preparedBy = (int)items.PreparedBy;
//                        ViewHeader1.preparedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                        if (items.PreparedByDate == null)
//                        {
//                            ViewHeader1.preparedByDate = null;
//                        }

//                        else
//                        {
//                            DateTime pdate = (DateTime)items.PreparedByDate;
//                            ViewHeader1.showPreparedByDate = pdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.preparedByDate = pdate.ToString("yyyy-MM-dd");
//                        }


//                        ViewHeader1.approvedBy = items.ApprovedBy;
//                        ViewHeader1.approvedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                        if (items.ApprovedByDate == null)
//                        {
//                            ViewHeader1.approvedByDate = null;
//                        }

//                        else
//                        {
//                            DateTime adate = (DateTime)items.ApprovedByDate;
//                            ViewHeader1.showApprovedByDate = adate.ToString("dd-MM-yyyy");
//                            ViewHeader1.approvedByDate = adate.ToString("yyyy-MM-dd");

//                        }

//                        // ViewHeader1.isApproved = items.IsApproved;
//                        ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
//                        ViewHeader1.preparedLogin = 1;
//                        ViewHeader1.approvedLogin = 0;


//                        ViewHeaderList.Add(ViewHeader1);

//                    }

//                    if (ViewHeaderList.Count > 0)
//                    {
//                        obj.isStatus = true;
//                        obj.response = ViewHeaderList;
//                    }
//                    else
//                    {
//                        obj.isStatus = false;
//                        obj.response = ResourceResponse.NoItemsFound;
//                    }

//                }
//                //else
//                //{
//                //    var tblDet1 = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.IsPrepared == 1 && m.PlantId==plantId).ToList();
//                //    if (tblDet1.Count > 0)

//                //    {

//                //        foreach (var items in tblDet1)
//                //        {
//                //            viewHeaders ViewHeader1 = new viewHeaders();

//                //            ViewHeader1.headerId = items.HeaderId;
//                //            ViewHeader1.plantId = (int)items.PlantId;
//                //            ViewHeader1.plantName = items.PlantName;
//                //            ViewHeader1.categoryId = (int)items.CategoryId;
//                //            ViewHeader1.categoryName = items.CategoryName;
//                //            ViewHeader1.makeId = (int)items.MakeId;
//                //            ViewHeader1.makeName = items.MakeName;

//                //            if (items.CreationDate == null)
//                //            {
//                //                ViewHeader1.creationDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime cdate = (DateTime)items.CreationDate;

//                //                ViewHeader1.creationDate = cdate.ToString("dd-MM-yyyy");

//                //            }

//                //            ViewHeader1.revNo = items.RevNo;



//                //            if (items.LastRevDate == null)
//                //            {
//                //                ViewHeader1.lastRevDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime rvdate = (DateTime)items.LastRevDate;
//                //                ViewHeader1.lastRevDate = rvdate.ToString("dd-MM-yyyy");

//                //            }


//                //            ViewHeader1.checkListNo = items.CheckListNo + items.RevNo;
//                //            ViewHeader1.preparedBy = (int)items.PreparedBy;
//                //            ViewHeader1.preparedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                //            if (items.PreparedByDate == null)
//                //            {
//                //                ViewHeader1.preparedByDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime pdate = (DateTime)items.PreparedByDate;
//                //                ViewHeader1.preparedByDate = pdate.ToString("dd-MM-yyyy");
//                //            }


//                //            ViewHeader1.approvedBy = items.ApprovedBy;
//                //            ViewHeader1.approvedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                //            if (items.ApprovedByDate == null)
//                //            {
//                //                ViewHeader1.approvedByDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime adate = (DateTime)items.ApprovedByDate;
//                //                ViewHeader1.approvedByDate = adate.ToString("yyyy-MM-dd");

//                //            }

//                //            // ViewHeader1.isApproved = items.IsApproved;
//                //            ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
//                //            ViewHeader1.preparedLogin = 0;
//                //            ViewHeader1.approvedLogin = 1;


//                //            ViewHeaderList.Add(ViewHeader1);

//                //        }

//                //        if (ViewHeaderList.Count > 0)
//                //        {
//                //            obj.isStatus = true;
//                //            obj.response = ViewHeaderList;
//                //        }
//                //        else
//                //        {
//                //            obj.isStatus = false;
//                //            obj.response = ResourceResponse.NoItemsFound;
//                //        }

//                //    }

//                //}


//            }
//            catch (Exception e)
//            {
//                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }
//        public CommonResponse ViewCheckListPlantCategoryId(int cateroryId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {

//                List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

//                var tblDet = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.CategoryId == cateroryId).ToList();
//                if (tblDet.Count > 0)

//                {

//                    foreach (var items in tblDet)
//                    {
//                        viewHeaders ViewHeader1 = new viewHeaders();

//                        ViewHeader1.headerId = items.HeaderId;
//                        ViewHeader1.plantId = (int)items.PlantId;
//                        ViewHeader1.plantName = items.PlantName;

//                        ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();
//                        ViewHeader1.id = items.HeaderId;

//                        ViewHeader1.categoryId = (int)items.CategoryId;
//                        ViewHeader1.categoryName = items.CategoryName;
//                        ViewHeader1.makeId = (int)items.MakeId;
//                        ViewHeader1.makeName = items.MakeName;

//                        if (items.CreationDate == null)
//                        {
//                            ViewHeader1.creationDate = null;
//                        }

//                        else
//                        {
//                            DateTime cdate = (DateTime)items.CreationDate;

//                            ViewHeader1.showCreationDate = cdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.creationDate = cdate.ToString("yyyy-MM-dd");

//                        }

//                        ViewHeader1.revNo = items.RevNo;



//                        if (items.LastRevDate == null)
//                        {
//                            ViewHeader1.lastRevDate = null;
//                        }

//                        else
//                        {
//                            DateTime rvdate = (DateTime)items.LastRevDate;
//                            ViewHeader1.showLastRevDate = rvdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.lastRevDate = rvdate.ToString("yyyy-MM-dd");

//                        }


//                        // ViewHeader1.checkListNo = items.CheckListNo + items.RevNo;
//                        ViewHeader1.checkListNo = items.CheckListNo;
//                        ViewHeader1.preparedBy = (int)items.PreparedBy;
//                        ViewHeader1.preparedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                        if (items.PreparedByDate == null)
//                        {
//                            ViewHeader1.preparedByDate = null;
//                        }

//                        else
//                        {
//                            DateTime pdate = (DateTime)items.PreparedByDate;
//                            ViewHeader1.showPreparedByDate = pdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.preparedByDate = pdate.ToString("yyyy-MM-dd");
//                        }


//                        ViewHeader1.approvedBy = items.ApprovedBy;
//                        ViewHeader1.approvedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                        if (items.ApprovedByDate == null)
//                        {
//                            ViewHeader1.approvedByDate = null;
//                        }

//                        else
//                        {
//                            DateTime adate = (DateTime)items.ApprovedByDate;
//                            ViewHeader1.showApprovedByDate = adate.ToString("dd-MM-yyyy");
//                            ViewHeader1.approvedByDate = adate.ToString("yyyy-MM-dd");

//                        }

//                        // ViewHeader1.isApproved = items.IsApproved;
//                        ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
//                        ViewHeader1.preparedLogin = 1;
//                        ViewHeader1.approvedLogin = 0;


//                        ViewHeaderList.Add(ViewHeader1);

//                    }

//                    if (ViewHeaderList.Count > 0)
//                    {
//                        obj.isStatus = true;
//                        obj.response = ViewHeaderList;
//                    }
//                    else
//                    {
//                        obj.isStatus = false;
//                        obj.response = ResourceResponse.NoItemsFound;
//                    }

//                }
//                //else
//                //{
//                //    var tblDet1 = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.IsPrepared == 1 && m.PlantId == plantId && m.CategoryId==cateroryId).ToList();
//                //    if (tblDet1.Count > 0)

//                //    {

//                //        foreach (var items in tblDet1)
//                //        {
//                //            viewHeaders ViewHeader1 = new viewHeaders();

//                //            ViewHeader1.headerId = items.HeaderId;
//                //            ViewHeader1.plantId = (int)items.PlantId;
//                //            ViewHeader1.plantName = items.PlantName;
//                //            ViewHeader1.categoryId = (int)items.CategoryId;
//                //            ViewHeader1.categoryName = items.CategoryName;
//                //            ViewHeader1.makeId = (int)items.MakeId;
//                //            ViewHeader1.makeName = items.MakeName;

//                //            if (items.CreationDate == null)
//                //            {
//                //                ViewHeader1.creationDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime cdate = (DateTime)items.CreationDate;

//                //                ViewHeader1.creationDate = cdate.ToString("dd-MM-yyyy");

//                //            }

//                //            ViewHeader1.revNo = items.RevNo;



//                //            if (items.LastRevDate == null)
//                //            {
//                //                ViewHeader1.lastRevDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime rvdate = (DateTime)items.LastRevDate;
//                //                ViewHeader1.lastRevDate = rvdate.ToString("dd-MM-yyyy");

//                //            }


//                //            ViewHeader1.checkListNo = items.CheckListNo + items.RevNo;
//                //            ViewHeader1.preparedBy = (int)items.PreparedBy;
//                //            ViewHeader1.preparedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                //            if (items.PreparedByDate == null)
//                //            {
//                //                ViewHeader1.preparedByDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime pdate = (DateTime)items.PreparedByDate;
//                //                ViewHeader1.preparedByDate = pdate.ToString("dd-MM-yyyy");
//                //            }


//                //            ViewHeader1.approvedBy = items.ApprovedBy;
//                //            ViewHeader1.approvedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                //            if (items.ApprovedByDate == null)
//                //            {
//                //                ViewHeader1.approvedByDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime adate = (DateTime)items.ApprovedByDate;
//                //                ViewHeader1.approvedByDate = adate.ToString("dd-MM-yyyy");

//                //            }

//                //            // ViewHeader1.isApproved = items.IsApproved;
//                //            ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
//                //            ViewHeader1.preparedLogin = 0;
//                //            ViewHeader1.approvedLogin = 1;


//                //            ViewHeaderList.Add(ViewHeader1);

//                //        }

//                //        if (ViewHeaderList.Count > 0)
//                //        {
//                //            obj.isStatus = true;
//                //            obj.response = ViewHeaderList;
//                //        }
//                //        else
//                //        {
//                //            obj.isStatus = false;
//                //            obj.response = ResourceResponse.NoItemsFound;
//                //        }

//                //    }

//                //}

//            }
//            catch (Exception e)
//            {
//                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        public CommonResponse ViewCheckListHeaderId(int HeaderId)
//        {


//            CommonResponse obj = new CommonResponse();
//            try
//            {

//                List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

//                var tblDet = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.HeaderId == HeaderId).ToList();
//                if (tblDet.Count > 0)

//                {

//                    foreach (var items in tblDet)
//                    {
//                        viewHeaders ViewHeader1 = new viewHeaders();

//                        ViewHeader1.headerId = items.HeaderId;
//                        //ViewHeader1.plantId = (int)items.PlantId;
//                        //ViewHeader1.plantName = items.PlantName;

//                        //ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();

//                        //  ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();
//                        ViewHeader1.id = items.HeaderId;

//                        ViewHeader1.categoryId = (int)items.CategoryId;
//                        ViewHeader1.categoryName = items.CategoryName;
//                        ViewHeader1.makeId = (int)items.MakeId;
//                        ViewHeader1.makeName = items.MakeName;

//                        if (items.CreationDate == null)
//                        {
//                            ViewHeader1.creationDate = null;
//                        }

//                        else
//                        {
//                            DateTime cdate = (DateTime)items.CreationDate;

//                            ViewHeader1.showCreationDate = cdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.creationDate = cdate.ToString("yyyy-MM-dd");

//                        }

//                        ViewHeader1.revNo = items.RevNo;



//                        if (items.LastRevDate == null)
//                        {
//                            ViewHeader1.lastRevDate = null;
//                        }

//                        else
//                        {
//                            DateTime rvdate = (DateTime)items.LastRevDate;
//                            ViewHeader1.showLastRevDate = rvdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.lastRevDate = rvdate.ToString("yyyy-MM-dd");

//                        }


//                        //  ViewHeader1.checkListNo = items.CheckListNo + items.HeaderId;
//                        ViewHeader1.checkListNo = items.CheckListNo;
//                        ViewHeader1.preparedBy = (int)items.PreparedBy;
//                        ViewHeader1.preparedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                        if (items.PreparedByDate == null)
//                        {
//                            ViewHeader1.preparedByDate = null;
//                        }

//                        else
//                        {
//                            DateTime pdate = (DateTime)items.PreparedByDate;
//                            ViewHeader1.showPreparedByDate = pdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.preparedByDate = pdate.ToString("yyyy-MM-dd");
//                        }


//                        ViewHeader1.approvedBy = items.ApprovedBy;
//                        ViewHeader1.approvedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                        if (items.ApprovedByDate == null)
//                        {
//                            ViewHeader1.approvedByDate = null;
//                        }

//                        else
//                        {
//                            DateTime adate = (DateTime)items.ApprovedByDate;
//                            ViewHeader1.showApprovedByDate = adate.ToString("dd-MM-yyyy");
//                            ViewHeader1.approvedByDate = adate.ToString("yyyy-MM-dd");

//                        }

//                        // ViewHeader1.isApproved = items.IsApproved;
//                        ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
//                        ViewHeader1.preparedLogin = 1;
//                        ViewHeader1.approvedLogin = 0;


//                        ViewHeaderList.Add(ViewHeader1);

//                    }

//                    if (ViewHeaderList.Count > 0)
//                    {
//                        obj.isStatus = true;
//                        obj.response = ViewHeaderList;
//                    }
//                    else
//                    {
//                        obj.isStatus = false;
//                        obj.response = ResourceResponse.NoItemsFound;
//                    }

//                }
//                //else
//                //{
//                //    var tblDet1 = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.IsPrepared == 1 && m.HeaderId == HeaderId).ToList();
//                //    if (tblDet1.Count > 0)

//                //    {

//                //        foreach (var items in tblDet1)
//                //        {
//                //            viewHeaders ViewHeader1 = new viewHeaders();

//                //            ViewHeader1.headerId = items.HeaderId;
//                //            ViewHeader1.plantId = (int)items.PlantId;
//                //            ViewHeader1.plantName = items.PlantName;
//                //            ViewHeader1.categoryId = (int)items.CategoryId;
//                //            ViewHeader1.categoryName = items.CategoryName;
//                //            ViewHeader1.makeId = (int)items.MakeId;
//                //            ViewHeader1.makeName = items.MakeName;

//                //            if (items.CreationDate == null)
//                //            {
//                //                ViewHeader1.creationDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime cdate = (DateTime)items.CreationDate;

//                //                ViewHeader1.creationDate = cdate.ToString("dd-MM-yyyy");

//                //            }

//                //            ViewHeader1.revNo = items.RevNo;



//                //            if (items.LastRevDate == null)
//                //            {
//                //                ViewHeader1.lastRevDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime rvdate = (DateTime)items.LastRevDate;
//                //                ViewHeader1.lastRevDate = rvdate.ToString("dd-MM-yyyy");

//                //            }


//                //            ViewHeader1.checkListNo = items.CheckListNo + items.RevNo;
//                //            ViewHeader1.preparedBy = (int)items.PreparedBy;
//                //            ViewHeader1.preparedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                //            if (items.PreparedByDate == null)
//                //            {
//                //                ViewHeader1.preparedByDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime pdate = (DateTime)items.PreparedByDate;
//                //                ViewHeader1.preparedByDate = pdate.ToString("dd-MM-yyyy");
//                //            }


//                //            ViewHeader1.approvedBy = items.ApprovedBy;
//                //            ViewHeader1.approvedName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                //            if (items.ApprovedByDate == null)
//                //            {
//                //                ViewHeader1.approvedByDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime adate = (DateTime)items.ApprovedByDate;
//                //                ViewHeader1.approvedByDate = adate.ToString("dd-MM-yyyy");

//                //            }

//                //            // ViewHeader1.isApproved = items.IsApproved;
//                //            ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
//                //            ViewHeader1.preparedLogin = 0;
//                //            ViewHeader1.approvedLogin = 1;


//                //            ViewHeaderList.Add(ViewHeader1);

//                //        }

//                //        if (ViewHeaderList.Count > 0)
//                //        {
//                //            obj.isStatus = true;
//                //            obj.response = ViewHeaderList;
//                //        }
//                //        else
//                //        {
//                //            obj.isStatus = false;
//                //            obj.response = ResourceResponse.NoItemsFound;
//                //        }

//                //    }

//                //}


//            }
//            catch (Exception e)
//            {
//                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        public CommonResponse SendCheckListToApprover(int HeaderId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var items = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.HeaderId == HeaderId).FirstOrDefault();

//                if (items != null)
//                {
//                    items.IsPrepared = 1;
//                    db.SaveChanges();

//                    var check = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == HeaderId).ToList();
//                    foreach (var i in check)
//                    {
//                        i.IsPrepared = 1;
//                        db.SaveChanges();
//                    }

//                    obj.isStatus = true;
//                    obj.response = "sent to Approver";
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

//        public CommonResponse DeleteCheckListHeader(int HeaderId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = db.UnitworkccsTblchecklistHeader.Where(m => m.HeaderId == HeaderId && m.IsDeleted == 0).FirstOrDefault();
//                if (check != null)
//                {
//                    check.IsDeleted = 1;
//                    check.ModifiedOn = DateTime.Now;
//                    db.SaveChanges();

//                    var tblCheckListDet = db.UnitworkccsTblchecklistDetails.Where(m => m.HeaderId == HeaderId && m.IsDeleted == 0).ToList();
//                    foreach (var del in tblCheckListDet)
//                    {
//                        del.IsDeleted = 1;
//                        del.ModifiedOn = DateTime.Now;
//                        db.SaveChanges();

//                    }


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

//        //adding multiple machines  to header Id
//        public CommonResponse ViewMultipleHeaderIds(int makeId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = (from wf in db.UnitworkccsTblchecklistHeader
//                             where wf.IsDeleted == 0 && wf.IsApproved == 1 && wf.MakeId == makeId
//                             select new
//                             {
//                                 id = wf.HeaderId,
//                                 checkListName = wf.CheckListNo
//                                 // checkListName = wf.CheckListNo + "" + wf.HeaderId
//                             }).ToList();
//                if (check.Count > 0)
//                {
//                    obj.isStatus = true;
//                    obj.response = check;
//                }
//                else
//                {
//                    obj.isStatus = false;
//                    obj.response = "No Items Found";
//                }
//            }
//            catch (Exception e)
//            {
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        public CommonResponse ViewMultiplePlantNames()
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = (from wf in db.UnitworkccsTblplant
//                             where wf.IsDeleted == 0
//                             select new
//                             {

//                                 plantId = wf.PlantId,
//                                 plantCode = wf.PlantCode,
//                                 plantName = wf.PlantName
//                             }).ToList();

//                if (check.Count > 0)
//                {
//                    obj.isStatus = true;
//                    obj.response = check;
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

//        public CommonResponse ViewMultipleCategoryNames(int PlantId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = (from wf in db.UnitworkccsTblmachinecategorynames
//                             where wf.IsDeleted == 0 && wf.PlantId == PlantId
//                             select new
//                             {
//                                 categoryId = wf.MachineCategoryId,
//                                 categoryName = wf.MachineCategoryName
//                             }).ToList();

//                if (check.Count > 0)
//                {

//                    obj.isStatus = true;
//                    obj.response = check;
//                }
//                else
//                {
//                    obj.isStatus = false;
//                    obj.response = "No Items Found";
//                }
//            }
//            catch (Exception e)
//            {
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        public CommonResponse ViewMultipleMakeNames(int categoryId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = (from wf in db.UnitworkccsTblMachinemakedetails
//                             where wf.IsDeleted == 0 && wf.MachineCategoryId == categoryId
//                             select new
//                             {
//                                 makeId = wf.MakeId,
//                                 machineMake = wf.MakeName
//                             }).ToList();

//                if (check.Count > 0)
//                {

//                    obj.isStatus = true;
//                    obj.response = check;
//                }
//                else
//                {
//                    obj.isStatus = false;
//                    obj.response = "No Items Found";
//                }
//            }
//            catch (Exception e)
//            {
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        public CommonResponse ViewMultipleMachineList(int makeId, int categoryId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = (from wf in db.UnitworkccsTblmachinedetails
//                             where wf.IsDeleted == 0 && wf.MachineMake == Convert.ToString(makeId) && wf.MachineCategoryId == categoryId
//                             select new
//                             {
//                                 machineId = wf.MachineId,
//                                 machineName = wf.MachineName,

//                             }).ToList();

//                if (check.Count > 0)
//                {

//                    obj.isStatus = true;
//                    obj.response = check.Distinct();
//                }
//                else
//                {
//                    obj.isStatus = false;
//                    obj.response = "No Items Found";
//                }
//            }
//            catch (Exception e)
//            {
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        //public CommonResponse ViewMultipleMachineListByMakeId(int makeId)
//        //{
//        //    CommonResponse obj = new CommonResponse();
//        //    try
//        //    {
//        //        var check = (from wf in db.UnitworkccsTblchecklistHeader
//        //                     where wf.IsDeleted == 0 && wf.MakeId == makeId && wf.IsApproved==1
//        //                     select new
//        //                     {
//        //                         checkListNo = wf.CheckListNo


//        //                     }).ToList();

//        //        if (check.Count > 0)
//        //        {

//        //            obj.isStatus = true;
//        //            obj.response = check.Distinct();
//        //        }
//        //        else
//        //        {
//        //            obj.isStatus = false;
//        //            obj.response = "No Items Found";
//        //        }
//        //    }
//        //    catch (Exception e)
//        //    {
//        //        obj.isStatus = false;
//        //        obj.response = ResourceResponse.FailureMessage;
//        //    }
//        //    return obj;
//        //}

//        public CommonResponse AddAndEditHeaderMachines(addMachines data)
//        {
//            CommonResponse obj = new CommonResponse();
//            CommonFunction commonFunction = new CommonFunction();
//            try
//            {
//                var check = db.UnitworkccsTblChecklistmachines.Where(m => m.CheckListHeaderId == data.headerId && m.IsDeleted == 0).FirstOrDefault();
//                if (check == null)
//                {
//                    UnitworkccsTblChecklistmachines tblHMachines = new UnitworkccsTblChecklistmachines();
//                    tblHMachines.CheckListHeaderId = data.headerId;
//                    tblHMachines.PlantId = data.plantId;
//                    tblHMachines.CategoryId = data.categoryId;
//                    tblHMachines.MakeId = data.makeId;
//                    tblHMachines.MachineIds = data.MachineIds;
//                    tblHMachines.IsDeleted = 0;
//                    tblHMachines.CreatedOn = DateTime.Now;
//                    db.UnitworkccsTblChecklistmachines.Add(tblHMachines);
//                    db.SaveChanges();
//                    obj.isStatus = true;
//                    obj.response = ResourceResponse.AddedSuccessMessage;
//                }
//                else
//                {
//                    check.PlantId = data.plantId;
//                    check.CategoryId = data.categoryId;
//                    check.MakeId = data.makeId;
//                    check.MachineIds = data.MachineIds;
//                    check.IsDeleted = 0;
//                    check.ModifiedOn = DateTime.Now;
//                    db.SaveChanges();
//                    obj.isStatus = true;
//                    obj.response = ResourceResponse.UpdatedSuccessMessage;
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

//        public CommonResponse ViewMultipleHeaderMachines()
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                List<viewHeaderMachines> ViewHeaderListMachines = new List<viewHeaderMachines>();

//                var tblDet = db.UnitworkccsTblChecklistmachines.Where(m => m.IsDeleted == 0).ToList();
//                if (tblDet.Count > 0)
//                {
//                    foreach (var hId in tblDet)
//                    {

//                        viewHeaderMachines ViewHeaderListMachinesOne = new viewHeaderMachines();
//                        ViewHeaderListMachinesOne.HeaderId = hId.CheckListHeaderId;
//                        ViewHeaderListMachinesOne.CheckListName = db.UnitworkccsTblchecklistHeader.Where(m => m.HeaderId == hId.CheckListHeaderId).Select(m => m.CheckListNo).FirstOrDefault();

//                        string[] mids = hId.MachineIds.Split(',');
//                        List<string> mIdList = new List<string>();
//                        mIdList = mids.ToList();
//                        List<MachineDet> mIdNamesList = new List<MachineDet>();

//                        foreach (var mDet in mIdList)
//                        {
//                            var mId = Convert.ToInt32(mDet);
//                            MachineDet mIdNames = new MachineDet();
//                            mIdNames.machineId = mId;
//                            mIdNames.machineName = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == mId).Select(m => m.MachineName).FirstOrDefault();
//                            mIdNamesList.Add(mIdNames);
//                        }

//                        var plantname = db.UnitworkccsTblplant.Where(m => m.PlantId == hId.PlantId).Select(m => m.PlantName).FirstOrDefault();
//                        var categoryname = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == hId.CategoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
//                        var makename = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == hId.MakeId).Select(m => m.MakeName).FirstOrDefault();
//                        ViewHeaderListMachinesOne.plantId = hId.PlantId;
//                        ViewHeaderListMachinesOne.plantName = plantname;
//                        ViewHeaderListMachinesOne.categoryId = hId.CategoryId;
//                        ViewHeaderListMachinesOne.categoryName = categoryname;
//                        ViewHeaderListMachinesOne.MakeId = hId.MakeId;
//                        ViewHeaderListMachinesOne.makeName = makename;
//                        ViewHeaderListMachinesOne.MachinesDet = mIdNamesList;
//                        ViewHeaderListMachines.Add(ViewHeaderListMachinesOne);
//                    }
//                }

//                if (ViewHeaderListMachines.Count > 0)
//                {
//                    obj.isStatus = true;
//                    obj.response = ViewHeaderListMachines;
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

//        public CommonResponse DeleteHeaderMachine(int HeaderId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = db.UnitworkccsTblChecklistmachines.Where(m => m.CheckListHeaderId == HeaderId && m.IsDeleted == 0).FirstOrDefault();
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

//        /// <summary>
//        /// Update Check List Header
//        /// </summary>
//        /// <param name="data"></param>
//        /// <returns></returns>
//        public CommonResponse UpdateCheckListHeader(addHeader data)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                if (data.flag == 0)
//                {
//                    var check = db.UnitworkccsTblchecklistHeader.Where(m => m.HeaderId == data.HeaderId && m.IsDeleted == 0).FirstOrDefault();
//                    if (check == null)
//                    {
//                        check.CategoryId = data.categoryId;
//                        check.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
//                        check.MakeId = data.makeId;
//                        check.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
//                        check.PreparedBy = data.LoginId;
//                        check.CheckListNo = data.checkListNo;
//                        check.IsDeleted = 0;
//                        check.ModifiedOn = DateTime.Now;
//                        db.SaveChanges();
//                        string[] checkListNo = data.checkListNo.Split('#');
//                        check.CheckListNo = checkListNo[0] + "#" + check.HeaderId;
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
//    }
//}






#region old code
///////////////////////////////////////old code/////////

//using IFacilityMaini.DAL.App_Start;
//using IFacilityMaini.DAL.Helpers;
//using IFacilityMaini.DAL.Resource;
//using IFacilityMaini.DBModels;
//using IFacilityMaini.Interface;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Options;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using static IFacilityMaini.EntityModels.CheckListDetailsEntity;
//using static IFacilityMaini.EntityModels.CheckListHeaderEntity;
//using static IFacilityMaini.EntityModels.CommonEntity;

//namespace IFacilityMaini.DAL
//{
//    public class CheckListHeaderDAL : ICheckListHeader
//    {
//        unitworksccsContext db = new unitworksccsContext();
//        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(CheckListHeaderDAL));
//        public static IConfiguration configuration;
//        private readonly AppSettings appSettings;

//        public CheckListHeaderDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings)
//        {
//            db = _db;
//            configuration = _configuration;
//            appSettings = _appSettings.Value;
//        }

//        public CommonResponse ViewMultiplePlants()
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = (from wf in db.UnitworkccsTblplant
//                             where wf.IsDeleted == 0
//                             select new
//                             {

//                                 plantId = wf.PlantId,
//                                 plantCode = wf.PlantCode,
//                                 plantName = wf.PlantName
//                             }).ToList();

//                if (check.Count > 0)
//                {
//                    obj.isStatus = true;
//                    obj.response = check;
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

//        public CommonResponse ViewMultipleCategory()
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = (from wf in db.UnitworkccsTblmachinecategorynames
//                             where wf.IsDeleted == 0
//                             select new
//                             {
//                                 categoryId = wf.MachineCategoryId,
//                                 categoryName = wf.MachineCategoryName
//                             }).ToList();

//                if (check.Count > 0)
//                {

//                    obj.isStatus = true;
//                    obj.response = check.Distinct();
//                }
//                else
//                {
//                    obj.isStatus = false;
//                    obj.response = "No Items Found";
//                }
//            }
//            catch (Exception e)
//            {
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        public CommonResponse ViewMultipleMake(int categoryId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = (from wf in db.UnitworkccsTblMachinemakedetails
//                             where wf.IsDeleted == 0 && wf.MachineCategoryId == categoryId
//                             select new
//                             {
//                                 machineId = wf.MakeId,
//                                 machineMake = wf.MakeName
//                             }).ToList();

//                if (check.Count > 0)
//                {

//                    obj.isStatus = true;
//                    obj.response = check.Distinct();
//                }
//                else
//                {
//                    obj.isStatus = false;
//                    obj.response = "No Items Found";
//                }
//            }
//            catch (Exception e)
//            {
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        public CommonResponse GenerateCheckListNo(genNo data)
//        {

//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                string GenNumber = data.category + " (" + data.make + ") -";

//                obj.isStatus = true;
//                obj.response = GenNumber;
//            }

//            catch (Exception e)
//            {
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }

//            return obj;


//        }

//        //public CommonResponse AddAndEditCheckListHeader(addHeader data)
//        //{
//        //    CommonResponse obj = new CommonResponse();
//        //    CommonFunction commonFunction = new CommonFunction();
//        //    try
//        //    {

//        //        var check = db.UnitworkccsTblchecklistHeader.Where(m => m.HeaderId == data.HeaderId && m.IsDeleted == 0).FirstOrDefault();
//        //        if (check == null)
//        //        {

//        //            UnitworkccsTblchecklistHeader tblHeader = new UnitworkccsTblchecklistHeader();
//        //            tblHeader.PlantId = data.plantId;
//        //            tblHeader.PlantName = db.UnitworkccsTblplant.Where(m => m.PlantId == data.plantId).Select(m => m.PlantName).FirstOrDefault();
//        //            tblHeader.CategoryId = data.categoryId;
//        //            tblHeader.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
//        //            tblHeader.MakeId = data.makeId;
//        //            tblHeader.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
//        //            tblHeader.PreparedBy = data.LoginId;
//        //            // tblHeader.PreparedBy = data.LoginId;
//        //            tblHeader.PreparedByDate = DateTime.Now;
//        //            tblHeader.CheckListNo = data.checkListNo;
//        //            tblHeader.RevNo = 1;
//        //            tblHeader.IsDeleted = 0;
//        //            tblHeader.CreatedOn = DateTime.Now;
//        //            db.UnitworkccsTblchecklistHeader.Add(tblHeader);
//        //            db.SaveChanges();
//        //            //   tblHeader.RevNo = tblHeader.HeaderId;
//        //            //  db.SaveChanges();
//        //            obj.isStatus = true;
//        //            obj.response = ResourceResponse.AddedSuccessMessage;
//        //        }
//        //        else
//        //        {

//        //            if (check.IsApproved == 1)
//        //            {
//        //                UnitworkccsTblchecklistHeader tblHeader = new UnitworkccsTblchecklistHeader();
//        //                tblHeader.PlantId = data.plantId;
//        //                tblHeader.PlantName = db.UnitworkccsTblplant.Where(m => m.PlantId == data.plantId).Select(m => m.PlantName).FirstOrDefault();
//        //                tblHeader.CategoryId = data.categoryId;
//        //                tblHeader.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
//        //                tblHeader.MakeId = data.makeId;
//        //                tblHeader.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
//        //                tblHeader.PreparedBy = data.LoginId;
//        //                tblHeader.PreparedByDate = DateTime.Now;
//        //                tblHeader.CheckListNo = data.checkListNo;
//        //                tblHeader.CreationDate = check.CreationDate;
//        //                tblHeader.IsDeleted = 0;
//        //                tblHeader.CreatedOn = DateTime.Now;
//        //                tblHeader.RevNo = 2;
//        //                db.UnitworkccsTblchecklistHeader.Add(tblHeader);
//        //                db.SaveChanges();
//        //                // tblHeader.RevNo = tblHeader.HeaderId;
//        //                // db.SaveChanges();
//        //                obj.isStatus = true;
//        //                obj.response = ResourceResponse.AddedSuccessMessage;
//        //            }

//        //            else
//        //            {
//        //                check.PlantId = data.plantId;
//        //                check.PlantName = db.UnitworkccsTblplant.Where(m => m.PlantId == data.plantId).Select(m => m.PlantName).FirstOrDefault();
//        //                check.CategoryId = data.categoryId;
//        //                check.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
//        //                check.MakeId = data.makeId;
//        //                check.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
//        //                check.PreparedBy = data.LoginId;
//        //                check.CheckListNo = data.checkListNo;
//        //                check.IsDeleted = 0;
//        //                check.ModifiedOn = DateTime.Now;
//        //                db.SaveChanges();
//        //                obj.isStatus = true;
//        //                obj.response = ResourceResponse.UpdatedSuccessMessage;


//        //            }




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

//        public CommonResponse AddAndEditCheckListHeader(addHeader data)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                if (data.flag == 0)
//                {
//                    var check = db.UnitworkccsTblchecklistHeader.Where(m => m.CategoryId == data.categoryId && m.MakeId == data.makeId && m.IsDeleted == 0).FirstOrDefault();
//                    if (check == null)
//                    {
//                        UnitworkccsTblchecklistHeader tblHeader = new UnitworkccsTblchecklistHeader();
//                        tblHeader.CategoryId = data.categoryId;
//                        tblHeader.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
//                        tblHeader.MakeId = data.makeId;
//                        tblHeader.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
//                        tblHeader.PreparedBy = data.LoginId;
//                        var dbCheck = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0).LastOrDefault();
//                        int count = 0;
//                        if (dbCheck != null)
//                        {
//                            string[] arr = dbCheck.CheckListNo.Split('-');
//                            count = Convert.ToInt32(arr[1]) + 1;
//                        }
//                        else
//                        {
//                            count = 1;
//                        }
//                        tblHeader.CheckListNo = data.checkListNo + count;
//                        tblHeader.PreparedByDate = DateTime.Now;
//                        tblHeader.RevNo = 1;
//                        tblHeader.IsDeleted = 0;
//                        tblHeader.CreatedOn = DateTime.Now;
//                        db.UnitworkccsTblchecklistHeader.Add(tblHeader);
//                        db.SaveChanges();
//                        obj.isStatus = true;
//                        obj.response = ResourceResponse.AddedSuccessMessage;
//                    }
//                    else
//                    {
//                        obj.isStatus = false;
//                        obj.response = "CheckList No already Present";
//                    }
//                }
//                else
//                {
//                    string prevCheckListNo = db.UnitworkccsTblchecklistHeader.Where(m => m.HeaderId == data.HeaderId).Select(m => m.CheckListNo).FirstOrDefault();
//                    string[] checkCheckListNo = prevCheckListNo.Split('-');
//                    string[] checkListNo = data.checkListNo.Split('-');

//                    if (checkListNo[0] == checkCheckListNo[0])
//                    {
//                        UnitworkccsTblchecklistHeader tblHeader = new UnitworkccsTblchecklistHeader();
//                        tblHeader.CategoryId = data.categoryId;
//                        tblHeader.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
//                        tblHeader.MakeId = data.makeId;
//                        tblHeader.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
//                        tblHeader.PreparedBy = data.LoginId;
//                        tblHeader.CheckListNo = data.checkListNo;
//                        tblHeader.PreparedByDate = DateTime.Now;
//                        tblHeader.CreationDate = DateTime.Now;
//                        tblHeader.IsDeleted = 0;
//                        tblHeader.CreatedOn = DateTime.Now;
//                        // tblHeader.PreviousChecklistHeaderId = data.flag;
//                        db.UnitworkccsTblchecklistHeader.Add(tblHeader);
//                        db.SaveChanges();

//                        var checklistCount = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0).Select(m => m.CheckListNo).ToList();
//                        string[] arr = new string[] { };
//                        int count = 0;
//                        foreach (var item in checklistCount)
//                        {
//                            arr = item.Split('-');
//                            if (arr[1] == checkListNo[1])
//                            {
//                                count++;
//                            }
//                        }

//                        //var matchingvalues = arr.Where(stringToCheck => stringToCheck == checkListNo[0]).Count();

//                        //int count = /*checklistCount.Count();*/matchingvalues;
//                        tblHeader.RevNo = count + 1 - 1;
//                        db.SaveChanges();


//                        var checkListDetails = db.UnitworkccsTblchecklistDetails.Where(m => m.IsDeleted == 0).ToList();

//                        if (checkListDetails.Count > 0)
//                        {
//                            foreach (var items in checkListDetails)
//                            {
//                                if (items.IsAssigned != 1)
//                                {
//                                    if (items.AddEdit == 1 && items.CheckListId != 0)
//                                    {
//                                        TblCheckListDetails tblCheckList = new TblCheckListDetails();
//                                        tblCheckList.HeaderId = tblHeader.HeaderId;
//                                        tblCheckList.WhatToCheck = items.WhatToCheck;
//                                        tblCheckList.How = items.How;
//                                        tblCheckList.Frequency = items.Frequency;
//                                        tblCheckList.RunningHrs = items.RunningHrs;
//                                        tblCheckList.PartsCount = items.PartsCount;
//                                        tblCheckList.PeriodFrequency = items.PeriodFrequency;
//                                        tblCheckList.IsNumeric = items.IsNumeric;
//                                        tblCheckList.IsText = items.IsText;
//                                        tblCheckList.RoleId = items.RoleId;
//                                        tblCheckList.Date = items.Date;
//                                        tblCheckList.IsOk = items.IsOk;
//                                        tblCheckList.IsDeleted = items.IsDeleted;
//                                        tblCheckList.CreatedOn = items.CreatedOn;
//                                        tblCheckList.CreatedBy = items.CreatedBy;
//                                        tblCheckList.ModifiedBy = items.ModifiedBy;
//                                        tblCheckList.ModifiedOn = items.ModifiedOn;
//                                        tblCheckList.IsPrepared = items.IsPrepared;
//                                        tblCheckList.IsApproved = items.IsApproved;
//                                        tblCheckList.Comment = items.Comment;
//                                        tblCheckList.NumericValue = items.NumericValue;
//                                        tblCheckList.TextValue = items.TextValue;
//                                        tblCheckList.IsDashBoardEntry = items.IsDashBoardEntry;
//                                        tblCheckList.PreviousChecklistId = items.CheckListId;
//                                        db.TblCheckListDetails.Add(tblCheckList);
//                                        db.SaveChanges();

//                                        if (checkListNo[0] == checkCheckListNo[0])
//                                        {
//                                            var dbCheck = db.TblCheckListDetailsNew.Where(m => m.CheckListNewId == items.CheckListNewId).FirstOrDefault();
//                                            if (dbCheck != null)
//                                            {
//                                                dbCheck.HeaderId = tblHeader.HeaderId;
//                                                dbCheck.IsAssigned = 1;
//                                                db.SaveChanges();
//                                            }
//                                        }

//                                        var checkListDet = db.TblCheckListDetails.Where(m => m.HeaderId == data.HeaderId && m.CheckListId != items.CheckListId && m.IsDeleted == 0).ToList();
//                                        foreach (var item in checkListDet)
//                                        {
//                                            TblCheckListDetails tblCheckList1 = new TblCheckListDetails();
//                                            tblCheckList1.HeaderId = tblHeader.HeaderId;
//                                            tblCheckList1.WhatToCheck = item.WhatToCheck;
//                                            tblCheckList1.How = item.How;
//                                            tblCheckList1.Frequency = item.Frequency;
//                                            tblCheckList1.RunningHrs = item.RunningHrs;
//                                            tblCheckList1.PartsCount = item.PartsCount;
//                                            tblCheckList1.PeriodFrequency = item.PeriodFrequency;
//                                            tblCheckList1.IsNumeric = item.IsNumeric;
//                                            tblCheckList1.IsText = item.IsText;
//                                            tblCheckList1.RoleId = item.RoleId;
//                                            tblCheckList1.Date = item.Date;
//                                            tblCheckList1.IsOk = item.IsOk;
//                                            tblCheckList1.IsDeleted = item.IsDeleted;
//                                            tblCheckList1.CreatedOn = item.CreatedOn;
//                                            tblCheckList1.CreatedBy = item.CreatedBy;
//                                            tblCheckList1.ModifiedBy = item.ModifiedBy;
//                                            tblCheckList1.ModifiedOn = item.ModifiedOn;
//                                            tblCheckList1.IsPrepared = item.IsPrepared;
//                                            tblCheckList1.IsApproved = item.IsApproved;
//                                            tblCheckList1.Comment = item.Comment;
//                                            tblCheckList1.NumericValue = item.NumericValue;
//                                            tblCheckList1.TextValue = item.TextValue;
//                                            tblCheckList1.IsDashBoardEntry = item.IsDashBoardEntry;
//                                            tblCheckList1.PreviousChecklistId = item.CheckListId;
//                                            db.TblCheckListDetails.Add(tblCheckList1);
//                                            db.SaveChanges();
//                                        }
//                                    }
//                                    else
//                                    {
//                                        if (items.AddEdit == 0 && items.CheckListId == 0 && items.IsDeleted == 0)
//                                        {
//                                            TblCheckListDetails tblCheckList = new TblCheckListDetails();
//                                            tblCheckList.HeaderId = tblHeader.HeaderId;
//                                            tblCheckList.WhatToCheck = items.WhatToCheck;
//                                            tblCheckList.How = items.How;
//                                            tblCheckList.Frequency = items.Frequency;
//                                            tblCheckList.RunningHrs = items.RunningHrs;
//                                            tblCheckList.PartsCount = items.PartsCount;
//                                            tblCheckList.PeriodFrequency = items.PeriodFrequency;
//                                            tblCheckList.IsNumeric = items.IsNumeric;
//                                            tblCheckList.IsText = items.IsText;
//                                            tblCheckList.RoleId = items.RoleId;
//                                            tblCheckList.Date = items.Date;
//                                            tblCheckList.IsOk = items.IsOk;
//                                            tblCheckList.IsDeleted = items.IsDeleted;
//                                            tblCheckList.CreatedOn = items.CreatedOn;
//                                            tblCheckList.CreatedBy = items.CreatedBy;
//                                            tblCheckList.ModifiedBy = items.ModifiedBy;
//                                            tblCheckList.ModifiedOn = items.ModifiedOn;
//                                            tblCheckList.IsPrepared = items.IsPrepared;
//                                            tblCheckList.IsApproved = items.IsApproved;
//                                            tblCheckList.Comment = items.Comment;
//                                            tblCheckList.NumericValue = items.NumericValue;
//                                            tblCheckList.TextValue = items.TextValue;
//                                            tblCheckList.IsDashBoardEntry = items.IsDashBoardEntry;
//                                            tblCheckList.PreviousChecklistId = items.CheckListId;
//                                            db.TblCheckListDetails.Add(tblCheckList);
//                                            db.SaveChanges();

//                                            if (checkListNo[0] == checkCheckListNo[0])
//                                            {
//                                                var dbCheck = db.TblCheckListDetailsNew.Where(m => m.CheckListNewId == items.CheckListNewId).FirstOrDefault();
//                                                if (dbCheck != null)
//                                                {
//                                                    dbCheck.HeaderId = tblHeader.HeaderId;
//                                                    dbCheck.IsAssigned = 1;
//                                                    db.SaveChanges();
//                                                }
//                                            }

//                                            var checkListDet = db.TblCheckListDetails.Where(m => m.HeaderId == data.HeaderId && m.IsDeleted == 0).ToList();
//                                            foreach (var item in checkListDet)
//                                            {
//                                                TblCheckListDetails tblCheckList1 = new TblCheckListDetails();
//                                                tblCheckList1.HeaderId = tblHeader.HeaderId;
//                                                tblCheckList1.WhatToCheck = item.WhatToCheck;
//                                                tblCheckList1.How = item.How;
//                                                tblCheckList1.Frequency = item.Frequency;
//                                                tblCheckList1.RunningHrs = item.RunningHrs;
//                                                tblCheckList1.PartsCount = item.PartsCount;
//                                                tblCheckList1.PeriodFrequency = item.PeriodFrequency;
//                                                tblCheckList1.IsNumeric = item.IsNumeric;
//                                                tblCheckList1.IsText = item.IsText;
//                                                tblCheckList1.RoleId = item.RoleId;
//                                                tblCheckList1.Date = item.Date;
//                                                tblCheckList1.IsOk = item.IsOk;
//                                                tblCheckList1.IsDeleted = item.IsDeleted;
//                                                tblCheckList1.CreatedOn = item.CreatedOn;
//                                                tblCheckList1.CreatedBy = item.CreatedBy;
//                                                tblCheckList1.ModifiedBy = item.ModifiedBy;
//                                                tblCheckList1.ModifiedOn = item.ModifiedOn;
//                                                tblCheckList1.IsPrepared = item.IsPrepared;
//                                                tblCheckList1.IsApproved = item.IsApproved;
//                                                tblCheckList1.Comment = item.Comment;
//                                                tblCheckList1.NumericValue = item.NumericValue;
//                                                tblCheckList1.TextValue = item.TextValue;
//                                                tblCheckList1.IsDashBoardEntry = item.IsDashBoardEntry;
//                                                tblCheckList1.PreviousChecklistId = item.CheckListId;
//                                                db.TblCheckListDetails.Add(tblCheckList1);
//                                                db.SaveChanges();
//                                            }
//                                        }
//                                    }
//                                }
//                            }
//                            obj.isStatus = true;
//                            obj.response = ResourceResponse.AddedSuccessMessage;
//                        }

//                    }
//                    else
//                    {
//                        var checks = db.UnitworkccsTblchecklistHeader.Where(m => m.CheckListNo.Contains(data.checkListNo) && m.IsDeleted == 0).FirstOrDefault();
//                        if (checks == null)
//                        {
//                            UnitworkccsTblchecklistHeader tblHeader1 = new UnitworkccsTblchecklistHeader();
//                            tblHeader1.CategoryId = data.categoryId;
//                            tblHeader1.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
//                            tblHeader1.MakeId = data.makeId;
//                            tblHeader1.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
//                            tblHeader1.PreparedBy = data.LoginId;
//                            tblHeader1.PreparedByDate = DateTime.Now;
//                            // tblHeader.CheckListNo = data.checkListNo;
//                            tblHeader1.CreationDate = DateTime.Now;
//                            tblHeader1.IsDeleted = 0;
//                            tblHeader1.CreatedOn = DateTime.Now;
//                            tblHeader1.PreviousChecklistHeaderId = data.flag;
//                            //int revInc = check.RevNo;
//                            tblHeader1.RevNo = 1;
//                            db.UnitworkccsTblchecklistHeader.Add(tblHeader1);
//                            db.SaveChanges();

//                            tblHeader1.CheckListNo = checkListNo[0] + "-" + tblHeader1.HeaderId;
//                            db.SaveChanges();

//                            var checkListDet = db.TblCheckListDetails.Where(m => m.HeaderId == data.HeaderId && m.IsDeleted == 0).ToList();
//                            foreach (var item in checkListDet)
//                            {
//                                TblCheckListDetails tblCheckList1 = new TblCheckListDetails();
//                                tblCheckList1.HeaderId = tblHeader1.HeaderId;
//                                tblCheckList1.WhatToCheck = item.WhatToCheck;
//                                tblCheckList1.How = item.How;
//                                tblCheckList1.Frequency = item.Frequency;
//                                tblCheckList1.RunningHrs = item.RunningHrs;
//                                tblCheckList1.PartsCount = item.PartsCount;
//                                tblCheckList1.PeriodFrequency = item.PeriodFrequency;
//                                tblCheckList1.IsNumeric = item.IsNumeric;
//                                tblCheckList1.IsText = item.IsText;
//                                tblCheckList1.RoleId = item.RoleId;
//                                tblCheckList1.Date = item.Date;
//                                tblCheckList1.IsOk = item.IsOk;
//                                tblCheckList1.IsDeleted = item.IsDeleted;
//                                tblCheckList1.CreatedOn = item.CreatedOn;
//                                tblCheckList1.CreatedBy = item.CreatedBy;
//                                tblCheckList1.ModifiedBy = item.ModifiedBy;
//                                tblCheckList1.ModifiedOn = item.ModifiedOn;
//                                tblCheckList1.IsPrepared = item.IsPrepared;
//                                tblCheckList1.IsApproved = item.IsApproved;
//                                tblCheckList1.Comment = item.Comment;
//                                tblCheckList1.NumericValue = item.NumericValue;
//                                tblCheckList1.TextValue = item.TextValue;
//                                tblCheckList1.IsDashBoardEntry = item.IsDashBoardEntry;
//                                tblCheckList1.PreviousChecklistId = item.CheckListId;
//                                db.TblCheckListDetails.Add(tblCheckList1);
//                                db.SaveChanges();
//                            }
//                        }
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

//        public CommonResponse ViewMultipleCheckListHeader()
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

//                var tblDet = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0).ToList();

//                foreach (var items in tblDet)
//                {
//                    viewHeaders ViewHeader1 = new viewHeaders();

//                    ViewHeader1.headerId = items.HeaderId;
//                    //ViewHeader1.plantId = (int)items.PlantId;
//                    //ViewHeader1.plantName = items.PlantName;

//                    //ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();
//                    // ViewHeader1.id = items.HeaderId;
//                    //  ViewHeader1.plantCode = items.PlantName;
//                    ViewHeader1.categoryId = (int)items.CategoryId;
//                    ViewHeader1.categoryName = items.CategoryName;
//                    ViewHeader1.makeId = (int)items.MakeId;
//                    ViewHeader1.makeName = items.MakeName;

//                    if (items.CreationDate == null)
//                    {
//                        ViewHeader1.creationDate = null;
//                    }
//                    else
//                    {
//                        DateTime cdate = (DateTime)items.CreationDate;
//                        ViewHeader1.showCreationDate = cdate.ToString("dd-MM-yyyy");
//                        ViewHeader1.creationDate = cdate.ToString("yyyy-MM-dd");
//                    }

//                    ViewHeader1.revNo = items.RevNo;
//                    if (items.LastRevDate == null)
//                    {
//                        ViewHeader1.lastRevDate = null;
//                    }

//                    else
//                    {
//                        DateTime rvdate = (DateTime)items.LastRevDate;
//                        ViewHeader1.showLastRevDate = rvdate.ToString("dd-MM-yyyy");
//                        ViewHeader1.lastRevDate = rvdate.ToString("yyyy-MM-dd");

//                    }
//                    // ViewHeader1.checkListNo = items.CheckListNo + items.HeaderId;
//                    ViewHeader1.checkListNo = items.CheckListNo;
//                    ViewHeader1.id = items.HeaderId;
//                    ViewHeader1.preparedBy = (int)items.PreparedBy;
//                    ViewHeader1.preparedName = db.TblOperatorDetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                    if (items.PreparedByDate == null)
//                    {
//                        ViewHeader1.preparedByDate = null;
//                    }

//                    else
//                    {
//                        DateTime pdate = (DateTime)items.PreparedByDate;
//                        ViewHeader1.showPreparedByDate = pdate.ToString("dd-MM-yyyy");
//                        ViewHeader1.preparedByDate = pdate.ToString("yyyy-MM-dd");

//                    }
//                    ViewHeader1.approvedBy = items.ApprovedBy;
//                    ViewHeader1.approvedName = db.TblOperatorDetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                    if (items.ApprovedByDate == null)
//                    {
//                        ViewHeader1.approvedByDate = null;
//                    }

//                    else
//                    {
//                        DateTime adate = (DateTime)items.ApprovedByDate;
//                        ViewHeader1.showApprovedByDate = adate.ToString("dd-MM-yyyy");
//                        ViewHeader1.approvedByDate = adate.ToString("yyyy-MM-dd");
//                    }

//                    // ViewHeader1.isApproved =items.IsApproved;
//                    ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
//                    var checklistIntbl = db.TblCheckListDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).ToList();

//                    if (checklistIntbl.Count == 0)
//                    {
//                        ViewHeader1.pendingCheckList = "check list details not created for this HeaderId";
//                    }
//                    else
//                    {
//                        int countl = 0;
//                        foreach (var ll in checklistIntbl)
//                        {
//                            if (ll.IsOk != "OK")
//                            {
//                                countl += 1;
//                            }
//                        }

//                        if (countl != 0)
//                        {

//                            ViewHeader1.pendingCheckList = "pending check list = " + countl + "";
//                            ViewHeader1.postToApprover = 1;
//                        }
//                        else
//                        {
//                            ViewHeader1.pendingCheckList = "all check list OK";
//                            ViewHeader1.postToApprover = 0;
//                        }
//                    }
//                    var PTAbutton = db.TblCheckListDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).ToList();

//                    var ispre = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).FirstOrDefault();

//                    if (PTAbutton.Count == 0)
//                    {
//                        ViewHeader1.postToApprover = 0;
//                    }
//                    else
//                    {
//                        if (ispre.IsPrepared == null && ispre != null)
//                        {
//                            ViewHeader1.postToApprover = 1;
//                        }
//                    }

//                    if (ispre.IsPrepared == 1)
//                    {
//                        int notokthere = 0;
//                        int notOkEdited = 0;

//                        foreach (var isnotok in PTAbutton)
//                        {
//                            if (isnotok.IsOk == "NOTOK" && isnotok.IsEdited == 0 && isnotok.IsPrepared == 0 && isnotok.IsApproved == 0)
//                            {
//                                notokthere++;
//                            }
//                            else if (isnotok.IsOk == "NOTOK" && isnotok.IsEdited == 1 && isnotok.IsPrepared == 0 && isnotok.IsApproved == 0)
//                            {
//                                notOkEdited++;
//                            }
//                        }

//                        if (notokthere > 0)
//                        {
//                            ViewHeader1.postToApprover = 0;
//                        }
//                        else if (notOkEdited > 0)
//                        {
//                            ViewHeader1.postToApprover = 1;
//                        }
//                        else
//                        {
//                            ViewHeader1.postToApprover = 0;
//                        }
//                    }

//                    //if (ispre.IsPrepared == 1)
//                    //{
//                    //    int notokthere = 0;

//                    //    foreach (var isnotok in PTAbutton)
//                    //    {
//                    //        if (isnotok.IsOk == "NOTOK" && isnotok.ModifiedOn == null)
//                    //        {
//                    //            notokthere++;
//                    //        }
//                    //    }

//                    //    if (notokthere > 0)
//                    //    {
//                    //        ViewHeader1.postToApprover = 0;
//                    //    }
//                    //    else
//                    //    {
//                    //        ViewHeader1.postToApprover = 1;
//                    //    }
//                    //}

//                    if (ispre.IsPrepared == 1 && ispre.ApprovedBy == null)
//                    {
//                        ViewHeader1.postToApprover = 0;
//                    }


//                    var checklistIntbl2 = db.TblCheckListDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).ToList();

//                    int len = checklistIntbl2.Count;
//                    int len2 = 0;
//                    if (len > 0)
//                    {
//                        foreach (var ee in checklistIntbl2)
//                        {
//                            if (ee.IsOk == "OK")
//                            {
//                                len2++;
//                            }
//                        }

//                        if (len2 == len)
//                        {
//                            ViewHeader1.pendingCheckList = "all check list OK";
//                            ViewHeader1.postToApprover = 0;
//                        }

//                    }


//                    // ViewHeader1.preparedLogin = items.PreparedBy == null ? 0 : 1;
//                    //  ViewHeader1.approvedLogin = items.ApprovedBy == null ? 0 : 1;

//                    ViewHeaderList.Add(ViewHeader1);

//                }


//                //var check = (from wf in db.UnitworkccsTblchecklistHeader
//                //       where wf.IsDeleted == 0
//                //       select new
//                //       {

//                //           headerId = wf.HeaderId,
//                //           plantId = wf.PlantId,
//                //           plantName = wf.PlantName,
//                //           categoryId = wf.CategoryId,
//                //           categoryName = wf.CategoryName,
//                //           makeId = wf.MakeId,
//                //           makeName = wf.MakeName,
//                //           creationDate  = wf.CreationDate,
//                //           revNo = wf.RevNo,
//                //           lastRevDate = wf.LastRevDate,
//                //           checkListNo = wf.CheckListNo + wf.RevNo,
//                //           preparedBy = wf.PreparedBy,
//                //           preparedByDate = wf.PreparedByDate,
//                //           approvedBy = wf.ApprovedBy,
//                //           approvedByDate = wf.ApprovedByDate
//                //       }).ToList();

//                if (ViewHeaderList.Count > 0)
//                {
//                    obj.isStatus = true;
//                    obj.response = ViewHeaderList;
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

//        public CommonResponse FulldetailsForRevButton(int headerId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                //  List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

//                var items = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.HeaderId == headerId).FirstOrDefault();


//                viewHeadersAndDet ViewHeader1 = new viewHeadersAndDet();

//                ViewHeader1.headerId = items.HeaderId;
//                ViewHeader1.plantId = (int)items.PlantId;
//                ViewHeader1.plantName = items.PlantName;
//                ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault(); ;
//                ViewHeader1.categoryId = (int)items.CategoryId;
//                ViewHeader1.categoryName = items.CategoryName;
//                ViewHeader1.makeId = (int)items.MakeId;
//                ViewHeader1.makeName = items.MakeName;

//                if (items.CreationDate == null)
//                {
//                    ViewHeader1.creationDate = null;
//                }
//                else
//                {
//                    DateTime cdate = (DateTime)items.CreationDate;
//                    ViewHeader1.showCreationDate = cdate.ToString("dd-MM-yyyy");
//                    ViewHeader1.creationDate = cdate.ToString("yyyy-MM-dd");
//                }

//                ViewHeader1.revNo = items.RevNo;



//                if (items.LastRevDate == null)
//                {
//                    ViewHeader1.lastRevDate = null;
//                }

//                else
//                {
//                    DateTime rvdate = (DateTime)items.LastRevDate;
//                    ViewHeader1.showLastRevDate = rvdate.ToString("dd-MM-yyyy");
//                    ViewHeader1.lastRevDate = rvdate.ToString("yyyy-MM-dd");

//                }
//                // ViewHeader1.checkListNo = items.CheckListNo + items.HeaderId;
//                ViewHeader1.checkListNo = items.CheckListNo;
//                ViewHeader1.id = items.HeaderId;
//                ViewHeader1.preparedBy = (int)items.PreparedBy;
//                ViewHeader1.preparedName = db.TblOperatorDetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                if (items.PreparedByDate == null)
//                {
//                    ViewHeader1.preparedByDate = null;
//                }

//                else
//                {
//                    DateTime pdate = (DateTime)items.PreparedByDate;
//                    ViewHeader1.showPreparedByDate = pdate.ToString("dd-MM-yyyy");
//                    ViewHeader1.preparedByDate = pdate.ToString("yyyy-MM-dd");

//                }
//                ViewHeader1.approvedBy = items.ApprovedBy;
//                ViewHeader1.approvedName = db.TblOperatorDetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                if (items.ApprovedByDate == null)
//                {
//                    ViewHeader1.approvedByDate = null;
//                }

//                else
//                {
//                    DateTime adate = (DateTime)items.ApprovedByDate;
//                    ViewHeader1.showApprovedByDate = adate.ToString("dd-MM-yyyy");
//                    ViewHeader1.approvedByDate = adate.ToString("yyyy-MM-dd");
//                }

//                // ViewHeader1.isApproved =items.IsApproved;
//                ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;



//                //var checklistIntbl = db.TblCheckListDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).ToList();

//                //if (checklistIntbl.Count == 0)
//                //{
//                //    ViewHeader1.pendingCheckList = "check list details not created for this HeaderId";

//                //}

//                //else
//                //{
//                //    int countl = 0;
//                //    foreach (var ll in checklistIntbl)
//                //    {
//                //        if (ll.IsOk != "OK")
//                //        {
//                //            countl += 1;
//                //        }

//                //    }

//                //    if (countl != 0)
//                //    {

//                //        ViewHeader1.pendingCheckList = "pending check list = " + countl + "";
//                //        ViewHeader1.postToApprover = 1;
//                //    }
//                //    else
//                //    {
//                //        ViewHeader1.pendingCheckList = "all check list OK";
//                //        ViewHeader1.postToApprover = 0;
//                //    }
//                //}
//                //var PTAbutton = db.TblCheckListDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).ToList();

//                //var ispre = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).FirstOrDefault();

//                //if (PTAbutton.Count == 0)
//                //{
//                //    ViewHeader1.postToApprover = 0;

//                //}

//                //else
//                //{

//                //    if (ispre.IsPrepared == null && ispre != null)

//                //    {
//                //        ViewHeader1.postToApprover = 1;

//                //    }


//                //}


//                //if (ispre.IsPrepared == 1)
//                //{

//                //    int notokthere = 0;
//                //    foreach (var isnotok in PTAbutton)
//                //    {
//                //        if (isnotok.IsOk == "NOTOK" && isnotok.ModifiedOn == null)
//                //        {
//                //            notokthere++;
//                //        }

//                //    }

//                //    if (notokthere > 0)
//                //    {
//                //        ViewHeader1.postToApprover = 0;
//                //    }
//                //    else
//                //    {
//                //        ViewHeader1.postToApprover = 1;

//                //    }

//                //}





//                //if (ispre.IsPrepared == 1 && ispre.ApprovedBy == null)
//                //{
//                //    ViewHeader1.postToApprover = 0;

//                //}


//                //var checklistIntbl2 = db.TblCheckListDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == items.HeaderId).ToList();

//                //int len = checklistIntbl2.Count;
//                //int len2 = 0;
//                //if (len > 0)
//                //{
//                //    foreach (var ee in checklistIntbl2)
//                //    {
//                //        if (ee.IsOk == "OK")
//                //        {
//                //            len2++;
//                //        }


//                //    }

//                //    if (len2 == len)
//                //    {
//                //        ViewHeader1.pendingCheckList = "all check list OK";
//                //        ViewHeader1.postToApprover = 0;
//                //    }

//                //}


//                // ViewHeader1.preparedLogin = items.PreparedBy == null ? 0 : 1;
//                //  ViewHeader1.approvedLogin = items.ApprovedBy == null ? 0 : 1;

//                // ViewHeaderList.Add(ViewHeader1);


//                List<ViewCheckList> ViewCheckedListDet = new List<ViewCheckList>();

//                var tblDet1 = db.TblCheckListDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == headerId).ToList();

//                foreach (var items1 in tblDet1)
//                {
//                    ViewCheckList ViewChecklist = new ViewCheckList();
//                    ViewChecklist.checkListId = items1.CheckListId;
//                    ViewChecklist.headerId = (int)items1.HeaderId;
//                    ViewChecklist.whatToCheck = items1.WhatToCheck;
//                    //   ViewChecklist.how = items.How;
//                    string[] howSplite = items1.How.Split(',');

//                    ViewChecklist.how = howSplite;
//                    ViewChecklist.frequency = items1.Frequency;
//                    ViewChecklist.runningHrs = items1.RunningHrs;
//                    ViewChecklist.partsCount = (int)items1.PartsCount;
//                    ViewChecklist.periodFrequency = items1.PeriodFrequency;
//                    ViewChecklist.isNumeric = items1.IsNumeric;
//                    ViewChecklist.isText = items1.IsText;
//                    ViewChecklist.roleId = items1.RoleId;
//                    ViewChecklist.roleName = db.Tblroles.Where(m => m.RoleId == items1.RoleId).Select(m => m.RoleName).FirstOrDefault();
//                    // ViewChecklist.ok = items.IsOk;
//                    if (items1.IsOk == "OK")
//                    {
//                        ViewChecklist.ok = "1";
//                    }
//                    else if (items1.IsOk == "NOTOK")
//                    {
//                        ViewChecklist.ok = "0";
//                        ViewChecklist.comment = items1.Comment;
//                    }
//                    else
//                    {
//                        ViewChecklist.ok = null;
//                    }

//                    //  string[] datesplite = items.Date.Split(',');


//                    // ViewChecklist.dateList = datesplite;


//                    if (items1.Date != "")
//                    {
//                        string[] datesplite = items1.Date.Split(',');
//                        ViewChecklist.dateList = datesplite;
//                        string[] showdate;

//                        List<string> datelist = new List<string>();
//                        foreach (var dt in datesplite)
//                        {
//                            DateTime ddtt = Convert.ToDateTime(dt);
//                            string dt1 = ddtt.ToString("dd-MM-yyyy");

//                            datelist.Add(dt1);
//                            //savedate += dt1 + ",";

//                        }

//                        showdate = datelist.ToArray();

//                        ViewChecklist.showDateList = showdate;
//                    }
//                    else
//                    {
//                        ViewChecklist.showDateList = new string[] { };
//                    }

//                    // string[] datesplite = data.Date.Split(',');
//                    //  string showdate = "";




//                    //List<date> dddlist = new List<date>();

//                    //string[] datesplite = items.Date.Split();

//                    //foreach (var dd in datesplite)
//                    //{
//                    //    date ddd = new date();
//                    //    ddd.dateArray = dd;
//                    //    dddlist.Add(ddd);
//                    //}
//                    //ViewChecklist.dateList = dddlist;
//                    //  ViewChecklist.dateList.dateArray = items.Date;
//                    //if (items.Date == null)
//                    //{
//                    //    ViewChecklist.date = null;
//                    //}
//                    //else
//                    //{
//                    //    DateTime dt = (DateTime)items.Date;
//                    //    string date1 = dt.ToString("yyyy-MM-dd");
//                    //    ViewChecklist.date = date1;

//                    //}

//                    ViewCheckedListDet.Add(ViewChecklist);

//                }



//                ViewHeader1.checkListDetails = ViewCheckedListDet;



//                if (ViewHeader1 != null)
//                {
//                    obj.isStatus = true;
//                    obj.response = ViewHeader1;
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

//        public CommonResponse ViewMultipleCheckListHeaderByOperatorId(int operatorId)
//        {


//            CommonResponse obj = new CommonResponse();
//            try
//            {

//                List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

//                var tblDet = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.PreparedBy == operatorId).ToList();
//                if (tblDet.Count > 0)

//                {

//                    foreach (var items in tblDet)
//                    {
//                        viewHeaders ViewHeader1 = new viewHeaders();

//                        ViewHeader1.headerId = items.HeaderId;
//                        //ViewHeader1.plantId = (int)items.PlantId;
//                        //ViewHeader1.plantName = items.PlantName;
//                        //ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();
//                        ViewHeader1.id = items.HeaderId;
//                        ViewHeader1.categoryId = (int)items.CategoryId;
//                        ViewHeader1.categoryName = items.CategoryName;
//                        ViewHeader1.makeId = (int)items.MakeId;
//                        ViewHeader1.makeName = items.MakeName;

//                        if (items.CreationDate == null)
//                        {
//                            ViewHeader1.creationDate = null;
//                        }

//                        else
//                        {
//                            DateTime cdate = (DateTime)items.CreationDate;

//                            ViewHeader1.showCreationDate = cdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.creationDate = cdate.ToString("yyyy-MM-dd");

//                        }

//                        ViewHeader1.revNo = items.RevNo;



//                        if (items.LastRevDate == null)
//                        {
//                            ViewHeader1.lastRevDate = null;
//                        }

//                        else
//                        {
//                            DateTime rvdate = (DateTime)items.LastRevDate;
//                            ViewHeader1.showLastRevDate = rvdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.lastRevDate = rvdate.ToString("yyyy-MM-dd");

//                        }


//                        // ViewHeader1.checkListNo = items.CheckListNo + items.HeaderId;
//                        ViewHeader1.checkListNo = items.CheckListNo;
//                        ViewHeader1.preparedBy = (int)items.PreparedBy;
//                        ViewHeader1.preparedName = db.TblOperatorDetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                        if (items.PreparedByDate == null)
//                        {
//                            ViewHeader1.preparedByDate = null;
//                        }

//                        else
//                        {
//                            DateTime pdate = (DateTime)items.PreparedByDate;
//                            ViewHeader1.showPreparedByDate = pdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.preparedByDate = pdate.ToString("yyyy-MM-dd");
//                        }


//                        ViewHeader1.approvedBy = items.ApprovedBy;
//                        ViewHeader1.approvedName = db.TblOperatorDetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                        if (items.ApprovedByDate == null)
//                        {
//                            ViewHeader1.approvedByDate = null;
//                        }

//                        else
//                        {
//                            DateTime adate = (DateTime)items.ApprovedByDate;
//                            ViewHeader1.showApprovedByDate = adate.ToString("dd-MM-yyyy");
//                            ViewHeader1.approvedByDate = adate.ToString("yyyy-MM-dd");

//                        }

//                        // ViewHeader1.isApproved = items.IsApproved;
//                        ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
//                        ViewHeader1.preparedLogin = 1;
//                        ViewHeader1.approvedLogin = 0;


//                        ViewHeaderList.Add(ViewHeader1);

//                    }

//                    if (ViewHeaderList.Count > 0)
//                    {
//                        obj.isStatus = true;
//                        obj.response = ViewHeaderList;
//                    }
//                    else
//                    {
//                        obj.isStatus = false;
//                        obj.response = ResourceResponse.NoItemsFound;
//                    }

//                }
//                else
//                {
//                    //int roleid =(int) db.TblOperatorDetails.Where(m => m.OpId == operatorId).Select(m => m.RoleId).FirstOrDefault();

//                    //if (roleid ==22)
//                    //{
//                    var tblDet1 = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.IsPrepared == 1).ToList();
//                    if (tblDet1.Count > 0)

//                    {

//                        foreach (var items in tblDet1)
//                        {
//                            viewHeaders ViewHeader1 = new viewHeaders();

//                            ViewHeader1.headerId = items.HeaderId;
//                            //ViewHeader1.plantId = (int)items.PlantId;
//                            //ViewHeader1.plantName = items.PlantName;
//                            //ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();
//                            ViewHeader1.id = items.HeaderId;
//                            ViewHeader1.categoryId = (int)items.CategoryId;
//                            ViewHeader1.categoryName = items.CategoryName;
//                            ViewHeader1.makeId = (int)items.MakeId;
//                            ViewHeader1.makeName = items.MakeName;

//                            if (items.CreationDate == null)
//                            {
//                                ViewHeader1.creationDate = null;
//                            }

//                            else
//                            {
//                                DateTime cdate = (DateTime)items.CreationDate;

//                                ViewHeader1.showCreationDate = cdate.ToString("dd-MM-yyyy");
//                                ViewHeader1.creationDate = cdate.ToString("yyyy-MM-dd");
//                            }

//                            ViewHeader1.revNo = items.RevNo;



//                            if (items.LastRevDate == null)
//                            {
//                                ViewHeader1.lastRevDate = null;
//                            }

//                            else
//                            {
//                                DateTime rvdate = (DateTime)items.LastRevDate;
//                                ViewHeader1.showLastRevDate = rvdate.ToString("dd-MM-yyyy");

//                                ViewHeader1.lastRevDate = rvdate.ToString("yyyy-MM-dd");

//                            }


//                            //ViewHeader1.checkListNo = items.CheckListNo + items.HeaderId;
//                            ViewHeader1.checkListNo = items.CheckListNo;
//                            ViewHeader1.preparedBy = (int)items.PreparedBy;
//                            ViewHeader1.preparedName = db.TblOperatorDetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                            if (items.PreparedByDate == null)
//                            {
//                                ViewHeader1.preparedByDate = null;
//                            }

//                            else
//                            {
//                                DateTime pdate = (DateTime)items.PreparedByDate;
//                                ViewHeader1.showPreparedByDate = pdate.ToString("dd-MM-yyyy");
//                                ViewHeader1.preparedByDate = pdate.ToString("yyyy-MM-dd");


//                            }


//                            ViewHeader1.approvedBy = items.ApprovedBy;
//                            ViewHeader1.approvedName = db.TblOperatorDetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                            if (items.ApprovedByDate == null)
//                            {
//                                ViewHeader1.approvedByDate = null;
//                            }

//                            else
//                            {
//                                DateTime adate = (DateTime)items.ApprovedByDate;
//                                ViewHeader1.showApprovedByDate = adate.ToString("dd-MM-yyyy");
//                                ViewHeader1.approvedByDate = adate.ToString("yyyy-MM-dd");

//                            }

//                            // ViewHeader1.isApproved = items.IsApproved;
//                            ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
//                            ViewHeader1.preparedLogin = 0;
//                            ViewHeader1.approvedLogin = 1;


//                            ViewHeaderList.Add(ViewHeader1);

//                        }

//                        if (ViewHeaderList.Count > 0)
//                        {
//                            obj.isStatus = true;
//                            obj.response = ViewHeaderList;
//                        }
//                        else
//                        {
//                            obj.isStatus = false;
//                            obj.response = ResourceResponse.NoItemsFound;
//                        }

//                    }

//                    // }
//                    //else
//                    //{

//                    //    obj.isStatus = false;
//                    //    obj.response ="operator id is not a Approver id";


//                    //}

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

//        public CommonResponse ViewCheckListPlantId(int plantId)
//        {

//            /*, int operatorId*/
//            CommonResponse obj = new CommonResponse();
//            try
//            {

//                // List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

//                // var tblDet = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.PlantId==plantId).ToList();

//                List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

//                var tblDet = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.PlantId == plantId).ToList();
//                if (tblDet.Count > 0)

//                {

//                    foreach (var items in tblDet)
//                    {
//                        viewHeaders ViewHeader1 = new viewHeaders();

//                        ViewHeader1.headerId = items.HeaderId;
//                        ViewHeader1.plantId = (int)items.PlantId;
//                        ViewHeader1.plantName = items.PlantName;


//                        ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();
//                        ViewHeader1.id = items.HeaderId;
//                        ViewHeader1.categoryId = (int)items.CategoryId;
//                        ViewHeader1.categoryName = items.CategoryName;
//                        ViewHeader1.makeId = (int)items.MakeId;
//                        ViewHeader1.makeName = items.MakeName;

//                        if (items.CreationDate == null)
//                        {
//                            ViewHeader1.creationDate = null;
//                        }

//                        else
//                        {
//                            DateTime cdate = (DateTime)items.CreationDate;

//                            ViewHeader1.showCreationDate = cdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.creationDate = cdate.ToString("yyyy-MM-dd");

//                        }

//                        ViewHeader1.revNo = items.RevNo;



//                        if (items.LastRevDate == null)
//                        {
//                            ViewHeader1.lastRevDate = null;
//                        }

//                        else
//                        {
//                            DateTime rvdate = (DateTime)items.LastRevDate;
//                            ViewHeader1.showLastRevDate = rvdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.lastRevDate = rvdate.ToString("yyyy-MM-dd");

//                        }


//                        // ViewHeader1.checkListNo = items.CheckListNo + items.RevNo;
//                        ViewHeader1.checkListNo = items.CheckListNo;
//                        ViewHeader1.preparedBy = (int)items.PreparedBy;
//                        ViewHeader1.preparedName = db.TblOperatorDetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                        if (items.PreparedByDate == null)
//                        {
//                            ViewHeader1.preparedByDate = null;
//                        }

//                        else
//                        {
//                            DateTime pdate = (DateTime)items.PreparedByDate;
//                            ViewHeader1.showPreparedByDate = pdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.preparedByDate = pdate.ToString("yyyy-MM-dd");
//                        }


//                        ViewHeader1.approvedBy = items.ApprovedBy;
//                        ViewHeader1.approvedName = db.TblOperatorDetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                        if (items.ApprovedByDate == null)
//                        {
//                            ViewHeader1.approvedByDate = null;
//                        }

//                        else
//                        {
//                            DateTime adate = (DateTime)items.ApprovedByDate;
//                            ViewHeader1.showApprovedByDate = adate.ToString("dd-MM-yyyy");
//                            ViewHeader1.approvedByDate = adate.ToString("yyyy-MM-dd");

//                        }

//                        // ViewHeader1.isApproved = items.IsApproved;
//                        ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
//                        ViewHeader1.preparedLogin = 1;
//                        ViewHeader1.approvedLogin = 0;


//                        ViewHeaderList.Add(ViewHeader1);

//                    }

//                    if (ViewHeaderList.Count > 0)
//                    {
//                        obj.isStatus = true;
//                        obj.response = ViewHeaderList;
//                    }
//                    else
//                    {
//                        obj.isStatus = false;
//                        obj.response = ResourceResponse.NoItemsFound;
//                    }

//                }
//                //else
//                //{
//                //    var tblDet1 = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.IsPrepared == 1 && m.PlantId==plantId).ToList();
//                //    if (tblDet1.Count > 0)

//                //    {

//                //        foreach (var items in tblDet1)
//                //        {
//                //            viewHeaders ViewHeader1 = new viewHeaders();

//                //            ViewHeader1.headerId = items.HeaderId;
//                //            ViewHeader1.plantId = (int)items.PlantId;
//                //            ViewHeader1.plantName = items.PlantName;
//                //            ViewHeader1.categoryId = (int)items.CategoryId;
//                //            ViewHeader1.categoryName = items.CategoryName;
//                //            ViewHeader1.makeId = (int)items.MakeId;
//                //            ViewHeader1.makeName = items.MakeName;

//                //            if (items.CreationDate == null)
//                //            {
//                //                ViewHeader1.creationDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime cdate = (DateTime)items.CreationDate;

//                //                ViewHeader1.creationDate = cdate.ToString("dd-MM-yyyy");

//                //            }

//                //            ViewHeader1.revNo = items.RevNo;



//                //            if (items.LastRevDate == null)
//                //            {
//                //                ViewHeader1.lastRevDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime rvdate = (DateTime)items.LastRevDate;
//                //                ViewHeader1.lastRevDate = rvdate.ToString("dd-MM-yyyy");

//                //            }


//                //            ViewHeader1.checkListNo = items.CheckListNo + items.RevNo;
//                //            ViewHeader1.preparedBy = (int)items.PreparedBy;
//                //            ViewHeader1.preparedName = db.TblOperatorDetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                //            if (items.PreparedByDate == null)
//                //            {
//                //                ViewHeader1.preparedByDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime pdate = (DateTime)items.PreparedByDate;
//                //                ViewHeader1.preparedByDate = pdate.ToString("dd-MM-yyyy");
//                //            }


//                //            ViewHeader1.approvedBy = items.ApprovedBy;
//                //            ViewHeader1.approvedName = db.TblOperatorDetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                //            if (items.ApprovedByDate == null)
//                //            {
//                //                ViewHeader1.approvedByDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime adate = (DateTime)items.ApprovedByDate;
//                //                ViewHeader1.approvedByDate = adate.ToString("yyyy-MM-dd");

//                //            }

//                //            // ViewHeader1.isApproved = items.IsApproved;
//                //            ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
//                //            ViewHeader1.preparedLogin = 0;
//                //            ViewHeader1.approvedLogin = 1;


//                //            ViewHeaderList.Add(ViewHeader1);

//                //        }

//                //        if (ViewHeaderList.Count > 0)
//                //        {
//                //            obj.isStatus = true;
//                //            obj.response = ViewHeaderList;
//                //        }
//                //        else
//                //        {
//                //            obj.isStatus = false;
//                //            obj.response = ResourceResponse.NoItemsFound;
//                //        }

//                //    }

//                //}


//            }
//            catch (Exception e)
//            {
//                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }
//        public CommonResponse ViewCheckListPlantCategoryId(int cateroryId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {

//                List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

//                var tblDet = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.CategoryId == cateroryId).ToList();
//                if (tblDet.Count > 0)

//                {

//                    foreach (var items in tblDet)
//                    {
//                        viewHeaders ViewHeader1 = new viewHeaders();

//                        ViewHeader1.headerId = items.HeaderId;
//                        ViewHeader1.plantId = (int)items.PlantId;
//                        ViewHeader1.plantName = items.PlantName;

//                        ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();
//                        ViewHeader1.id = items.HeaderId;

//                        ViewHeader1.categoryId = (int)items.CategoryId;
//                        ViewHeader1.categoryName = items.CategoryName;
//                        ViewHeader1.makeId = (int)items.MakeId;
//                        ViewHeader1.makeName = items.MakeName;

//                        if (items.CreationDate == null)
//                        {
//                            ViewHeader1.creationDate = null;
//                        }

//                        else
//                        {
//                            DateTime cdate = (DateTime)items.CreationDate;

//                            ViewHeader1.showCreationDate = cdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.creationDate = cdate.ToString("yyyy-MM-dd");

//                        }

//                        ViewHeader1.revNo = items.RevNo;



//                        if (items.LastRevDate == null)
//                        {
//                            ViewHeader1.lastRevDate = null;
//                        }

//                        else
//                        {
//                            DateTime rvdate = (DateTime)items.LastRevDate;
//                            ViewHeader1.showLastRevDate = rvdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.lastRevDate = rvdate.ToString("yyyy-MM-dd");

//                        }


//                        // ViewHeader1.checkListNo = items.CheckListNo + items.RevNo;
//                        ViewHeader1.checkListNo = items.CheckListNo;
//                        ViewHeader1.preparedBy = (int)items.PreparedBy;
//                        ViewHeader1.preparedName = db.TblOperatorDetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                        if (items.PreparedByDate == null)
//                        {
//                            ViewHeader1.preparedByDate = null;
//                        }

//                        else
//                        {
//                            DateTime pdate = (DateTime)items.PreparedByDate;
//                            ViewHeader1.showPreparedByDate = pdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.preparedByDate = pdate.ToString("yyyy-MM-dd");
//                        }


//                        ViewHeader1.approvedBy = items.ApprovedBy;
//                        ViewHeader1.approvedName = db.TblOperatorDetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                        if (items.ApprovedByDate == null)
//                        {
//                            ViewHeader1.approvedByDate = null;
//                        }

//                        else
//                        {
//                            DateTime adate = (DateTime)items.ApprovedByDate;
//                            ViewHeader1.showApprovedByDate = adate.ToString("dd-MM-yyyy");
//                            ViewHeader1.approvedByDate = adate.ToString("yyyy-MM-dd");

//                        }

//                        // ViewHeader1.isApproved = items.IsApproved;
//                        ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
//                        ViewHeader1.preparedLogin = 1;
//                        ViewHeader1.approvedLogin = 0;


//                        ViewHeaderList.Add(ViewHeader1);

//                    }

//                    if (ViewHeaderList.Count > 0)
//                    {
//                        obj.isStatus = true;
//                        obj.response = ViewHeaderList;
//                    }
//                    else
//                    {
//                        obj.isStatus = false;
//                        obj.response = ResourceResponse.NoItemsFound;
//                    }

//                }
//                //else
//                //{
//                //    var tblDet1 = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.IsPrepared == 1 && m.PlantId == plantId && m.CategoryId==cateroryId).ToList();
//                //    if (tblDet1.Count > 0)

//                //    {

//                //        foreach (var items in tblDet1)
//                //        {
//                //            viewHeaders ViewHeader1 = new viewHeaders();

//                //            ViewHeader1.headerId = items.HeaderId;
//                //            ViewHeader1.plantId = (int)items.PlantId;
//                //            ViewHeader1.plantName = items.PlantName;
//                //            ViewHeader1.categoryId = (int)items.CategoryId;
//                //            ViewHeader1.categoryName = items.CategoryName;
//                //            ViewHeader1.makeId = (int)items.MakeId;
//                //            ViewHeader1.makeName = items.MakeName;

//                //            if (items.CreationDate == null)
//                //            {
//                //                ViewHeader1.creationDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime cdate = (DateTime)items.CreationDate;

//                //                ViewHeader1.creationDate = cdate.ToString("dd-MM-yyyy");

//                //            }

//                //            ViewHeader1.revNo = items.RevNo;



//                //            if (items.LastRevDate == null)
//                //            {
//                //                ViewHeader1.lastRevDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime rvdate = (DateTime)items.LastRevDate;
//                //                ViewHeader1.lastRevDate = rvdate.ToString("dd-MM-yyyy");

//                //            }


//                //            ViewHeader1.checkListNo = items.CheckListNo + items.RevNo;
//                //            ViewHeader1.preparedBy = (int)items.PreparedBy;
//                //            ViewHeader1.preparedName = db.TblOperatorDetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                //            if (items.PreparedByDate == null)
//                //            {
//                //                ViewHeader1.preparedByDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime pdate = (DateTime)items.PreparedByDate;
//                //                ViewHeader1.preparedByDate = pdate.ToString("dd-MM-yyyy");
//                //            }


//                //            ViewHeader1.approvedBy = items.ApprovedBy;
//                //            ViewHeader1.approvedName = db.TblOperatorDetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                //            if (items.ApprovedByDate == null)
//                //            {
//                //                ViewHeader1.approvedByDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime adate = (DateTime)items.ApprovedByDate;
//                //                ViewHeader1.approvedByDate = adate.ToString("dd-MM-yyyy");

//                //            }

//                //            // ViewHeader1.isApproved = items.IsApproved;
//                //            ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
//                //            ViewHeader1.preparedLogin = 0;
//                //            ViewHeader1.approvedLogin = 1;


//                //            ViewHeaderList.Add(ViewHeader1);

//                //        }

//                //        if (ViewHeaderList.Count > 0)
//                //        {
//                //            obj.isStatus = true;
//                //            obj.response = ViewHeaderList;
//                //        }
//                //        else
//                //        {
//                //            obj.isStatus = false;
//                //            obj.response = ResourceResponse.NoItemsFound;
//                //        }

//                //    }

//                //}

//            }
//            catch (Exception e)
//            {
//                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        public CommonResponse ViewCheckListHeaderId(int HeaderId)
//        {


//            CommonResponse obj = new CommonResponse();
//            try
//            {

//                List<viewHeaders> ViewHeaderList = new List<viewHeaders>();

//                var tblDet = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.HeaderId == HeaderId).ToList();
//                if (tblDet.Count > 0)

//                {

//                    foreach (var items in tblDet)
//                    {
//                        viewHeaders ViewHeader1 = new viewHeaders();

//                        ViewHeader1.headerId = items.HeaderId;
//                        //ViewHeader1.plantId = (int)items.PlantId;
//                        //ViewHeader1.plantName = items.PlantName;

//                        //ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();

//                        //  ViewHeader1.plantCode = db.UnitworkccsTblplant.Where(m => m.PlantId == items.PlantId).Select(m => m.PlantCode).FirstOrDefault();
//                        ViewHeader1.id = items.HeaderId;

//                        ViewHeader1.categoryId = (int)items.CategoryId;
//                        ViewHeader1.categoryName = items.CategoryName;
//                        ViewHeader1.makeId = (int)items.MakeId;
//                        ViewHeader1.makeName = items.MakeName;

//                        if (items.CreationDate == null)
//                        {
//                            ViewHeader1.creationDate = null;
//                        }

//                        else
//                        {
//                            DateTime cdate = (DateTime)items.CreationDate;

//                            ViewHeader1.showCreationDate = cdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.creationDate = cdate.ToString("yyyy-MM-dd");

//                        }

//                        ViewHeader1.revNo = items.RevNo;



//                        if (items.LastRevDate == null)
//                        {
//                            ViewHeader1.lastRevDate = null;
//                        }

//                        else
//                        {
//                            DateTime rvdate = (DateTime)items.LastRevDate;
//                            ViewHeader1.showLastRevDate = rvdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.lastRevDate = rvdate.ToString("yyyy-MM-dd");

//                        }


//                        //  ViewHeader1.checkListNo = items.CheckListNo + items.HeaderId;
//                        ViewHeader1.checkListNo = items.CheckListNo;
//                        ViewHeader1.preparedBy = (int)items.PreparedBy;
//                        ViewHeader1.preparedName = db.TblOperatorDetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                        if (items.PreparedByDate == null)
//                        {
//                            ViewHeader1.preparedByDate = null;
//                        }

//                        else
//                        {
//                            DateTime pdate = (DateTime)items.PreparedByDate;
//                            ViewHeader1.showPreparedByDate = pdate.ToString("dd-MM-yyyy");
//                            ViewHeader1.preparedByDate = pdate.ToString("yyyy-MM-dd");
//                        }


//                        ViewHeader1.approvedBy = items.ApprovedBy;
//                        ViewHeader1.approvedName = db.TblOperatorDetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                        if (items.ApprovedByDate == null)
//                        {
//                            ViewHeader1.approvedByDate = null;
//                        }

//                        else
//                        {
//                            DateTime adate = (DateTime)items.ApprovedByDate;
//                            ViewHeader1.showApprovedByDate = adate.ToString("dd-MM-yyyy");
//                            ViewHeader1.approvedByDate = adate.ToString("yyyy-MM-dd");

//                        }

//                        // ViewHeader1.isApproved = items.IsApproved;
//                        ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
//                        ViewHeader1.preparedLogin = 1;
//                        ViewHeader1.approvedLogin = 0;


//                        ViewHeaderList.Add(ViewHeader1);

//                    }

//                    if (ViewHeaderList.Count > 0)
//                    {
//                        obj.isStatus = true;
//                        obj.response = ViewHeaderList;
//                    }
//                    else
//                    {
//                        obj.isStatus = false;
//                        obj.response = ResourceResponse.NoItemsFound;
//                    }

//                }
//                //else
//                //{
//                //    var tblDet1 = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.IsPrepared == 1 && m.HeaderId == HeaderId).ToList();
//                //    if (tblDet1.Count > 0)

//                //    {

//                //        foreach (var items in tblDet1)
//                //        {
//                //            viewHeaders ViewHeader1 = new viewHeaders();

//                //            ViewHeader1.headerId = items.HeaderId;
//                //            ViewHeader1.plantId = (int)items.PlantId;
//                //            ViewHeader1.plantName = items.PlantName;
//                //            ViewHeader1.categoryId = (int)items.CategoryId;
//                //            ViewHeader1.categoryName = items.CategoryName;
//                //            ViewHeader1.makeId = (int)items.MakeId;
//                //            ViewHeader1.makeName = items.MakeName;

//                //            if (items.CreationDate == null)
//                //            {
//                //                ViewHeader1.creationDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime cdate = (DateTime)items.CreationDate;

//                //                ViewHeader1.creationDate = cdate.ToString("dd-MM-yyyy");

//                //            }

//                //            ViewHeader1.revNo = items.RevNo;



//                //            if (items.LastRevDate == null)
//                //            {
//                //                ViewHeader1.lastRevDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime rvdate = (DateTime)items.LastRevDate;
//                //                ViewHeader1.lastRevDate = rvdate.ToString("dd-MM-yyyy");

//                //            }


//                //            ViewHeader1.checkListNo = items.CheckListNo + items.RevNo;
//                //            ViewHeader1.preparedBy = (int)items.PreparedBy;
//                //            ViewHeader1.preparedName = db.TblOperatorDetails.Where(m => m.OpId == items.PreparedBy).Select(m => m.OperatorName).FirstOrDefault();
//                //            if (items.PreparedByDate == null)
//                //            {
//                //                ViewHeader1.preparedByDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime pdate = (DateTime)items.PreparedByDate;
//                //                ViewHeader1.preparedByDate = pdate.ToString("dd-MM-yyyy");
//                //            }


//                //            ViewHeader1.approvedBy = items.ApprovedBy;
//                //            ViewHeader1.approvedName = db.TblOperatorDetails.Where(m => m.OpId == items.ApprovedBy).Select(m => m.OperatorName).FirstOrDefault();

//                //            if (items.ApprovedByDate == null)
//                //            {
//                //                ViewHeader1.approvedByDate = null;
//                //            }

//                //            else
//                //            {
//                //                DateTime adate = (DateTime)items.ApprovedByDate;
//                //                ViewHeader1.approvedByDate = adate.ToString("dd-MM-yyyy");

//                //            }

//                //            // ViewHeader1.isApproved = items.IsApproved;
//                //            ViewHeader1.isApproved = items.IsApproved == null ? 0 : items.IsApproved;
//                //            ViewHeader1.preparedLogin = 0;
//                //            ViewHeader1.approvedLogin = 1;


//                //            ViewHeaderList.Add(ViewHeader1);

//                //        }

//                //        if (ViewHeaderList.Count > 0)
//                //        {
//                //            obj.isStatus = true;
//                //            obj.response = ViewHeaderList;
//                //        }
//                //        else
//                //        {
//                //            obj.isStatus = false;
//                //            obj.response = ResourceResponse.NoItemsFound;
//                //        }

//                //    }

//                //}


//            }
//            catch (Exception e)
//            {
//                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        public CommonResponse SendCheckListToApprover(int HeaderId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var items = db.UnitworkccsTblchecklistHeader.Where(m => m.IsDeleted == 0 && m.HeaderId == HeaderId).FirstOrDefault();

//                if (items != null)
//                {
//                    items.IsPrepared = 1;
//                    db.SaveChanges();

//                    var check = db.TblCheckListDetails.Where(m => m.IsDeleted == 0 && m.HeaderId == HeaderId).ToList();
//                    foreach (var i in check)
//                    {
//                        i.IsPrepared = 1;
//                        db.SaveChanges();
//                    }

//                    obj.isStatus = true;
//                    obj.response = "sent to Approver";
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

//        public CommonResponse DeleteCheckListHeader(int HeaderId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = db.UnitworkccsTblchecklistHeader.Where(m => m.HeaderId == HeaderId && m.IsDeleted == 0).FirstOrDefault();
//                if (check != null)
//                {
//                    check.IsDeleted = 1;
//                    check.ModifiedOn = DateTime.Now;
//                    db.SaveChanges();

//                    var tblCheckListDet = db.TblCheckListDetails.Where(m => m.HeaderId == HeaderId && m.IsDeleted == 0).ToList();
//                    foreach (var del in tblCheckListDet)
//                    {
//                        del.IsDeleted = 1;
//                        del.ModifiedOn = DateTime.Now;
//                        db.SaveChanges();

//                    }


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

//        //adding multiple machines  to header Id
//        public CommonResponse ViewMultipleHeaderIds(int makeId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = (from wf in db.UnitworkccsTblchecklistHeader
//                             where wf.IsDeleted == 0 && wf.IsApproved == 1 && wf.MakeId == makeId
//                             select new
//                             {
//                                 id = wf.HeaderId,
//                                 checkListName = wf.CheckListNo
//                                 // checkListName = wf.CheckListNo + "" + wf.HeaderId
//                             }).ToList();
//                if (check.Count > 0)
//                {
//                    obj.isStatus = true;
//                    obj.response = check;
//                }
//                else
//                {
//                    obj.isStatus = false;
//                    obj.response = "No Items Found";
//                }
//            }
//            catch (Exception e)
//            {
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        public CommonResponse ViewMultiplePlantNames()
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = (from wf in db.UnitworkccsTblplant
//                             where wf.IsDeleted == 0
//                             select new
//                             {

//                                 plantId = wf.PlantId,
//                                 plantCode = wf.PlantCode,
//                                 plantName = wf.PlantName
//                             }).ToList();

//                if (check.Count > 0)
//                {
//                    obj.isStatus = true;
//                    obj.response = check;
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

//        public CommonResponse ViewMultipleCategoryNames(int PlantId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = (from wf in db.UnitworkccsTblmachinecategorynames
//                             where wf.IsDeleted == 0 && wf.PlantId == PlantId
//                             select new
//                             {
//                                 categoryId = wf.MachineCategoryId,
//                                 categoryName = wf.MachineCategoryName
//                             }).ToList();

//                if (check.Count > 0)
//                {

//                    obj.isStatus = true;
//                    obj.response = check;
//                }
//                else
//                {
//                    obj.isStatus = false;
//                    obj.response = "No Items Found";
//                }
//            }
//            catch (Exception e)
//            {
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        public CommonResponse ViewMultipleMakeNames(int categoryId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = (from wf in db.UnitworkccsTblMachinemakedetails
//                             where wf.IsDeleted == 0 && wf.MachineCategoryId == categoryId
//                             select new
//                             {
//                                 makeId = wf.MakeId,
//                                 machineMake = wf.MakeName
//                             }).ToList();

//                if (check.Count > 0)
//                {

//                    obj.isStatus = true;
//                    obj.response = check;
//                }
//                else
//                {
//                    obj.isStatus = false;
//                    obj.response = "No Items Found";
//                }
//            }
//            catch (Exception e)
//            {
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        public CommonResponse ViewMultipleMachineList(int makeId, int categoryId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = (from wf in db.Tblmachinedetails
//                             where wf.IsDeleted == 0 && wf.MachineMake == Convert.ToString(makeId) && wf.MachineCategoryId == categoryId
//                             select new
//                             {
//                                 machineId = wf.MachineId,
//                                 machineName = wf.MachineName,

//                             }).ToList();

//                if (check.Count > 0)
//                {

//                    obj.isStatus = true;
//                    obj.response = check.Distinct();
//                }
//                else
//                {
//                    obj.isStatus = false;
//                    obj.response = "No Items Found";
//                }
//            }
//            catch (Exception e)
//            {
//                obj.isStatus = false;
//                obj.response = ResourceResponse.FailureMessage;
//            }
//            return obj;
//        }

//        //public CommonResponse ViewMultipleMachineListByMakeId(int makeId)
//        //{
//        //    CommonResponse obj = new CommonResponse();
//        //    try
//        //    {
//        //        var check = (from wf in db.UnitworkccsTblchecklistHeader
//        //                     where wf.IsDeleted == 0 && wf.MakeId == makeId && wf.IsApproved==1
//        //                     select new
//        //                     {
//        //                         checkListNo = wf.CheckListNo


//        //                     }).ToList();

//        //        if (check.Count > 0)
//        //        {

//        //            obj.isStatus = true;
//        //            obj.response = check.Distinct();
//        //        }
//        //        else
//        //        {
//        //            obj.isStatus = false;
//        //            obj.response = "No Items Found";
//        //        }
//        //    }
//        //    catch (Exception e)
//        //    {
//        //        obj.isStatus = false;
//        //        obj.response = ResourceResponse.FailureMessage;
//        //    }
//        //    return obj;
//        //}

//        public CommonResponse AddAndEditHeaderMachines(addMachines data)
//        {
//            CommonResponse obj = new CommonResponse();
//            CommonFunction commonFunction = new CommonFunction();
//            try
//            {
//                var check = db.TblCheckListMachines.Where(m => m.CheckListHeaderId == data.headerId && m.IsDeleted == 0).FirstOrDefault();
//                if (check == null)
//                {
//                    TblCheckListMachines tblHMachines = new TblCheckListMachines();
//                    tblHMachines.CheckListHeaderId = data.headerId;
//                    tblHMachines.PlantId = data.plantId;
//                    tblHMachines.CategoryId = data.categoryId;
//                    tblHMachines.MakeId = data.makeId;
//                    tblHMachines.MachineIds = data.MachineIds;
//                    tblHMachines.IsDeleted = 0;
//                    tblHMachines.CreatedOn = DateTime.Now;
//                    db.TblCheckListMachines.Add(tblHMachines);
//                    db.SaveChanges();
//                    obj.isStatus = true;
//                    obj.response = ResourceResponse.AddedSuccessMessage;
//                }
//                else
//                {
//                    check.PlantId = data.plantId;
//                    check.CategoryId = data.categoryId;
//                    check.MakeId = data.makeId;
//                    check.MachineIds = data.MachineIds;
//                    check.IsDeleted = 0;
//                    check.ModifiedOn = DateTime.Now;
//                    db.SaveChanges();
//                    obj.isStatus = true;
//                    obj.response = ResourceResponse.UpdatedSuccessMessage;
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

//        public CommonResponse ViewMultipleHeaderMachines()
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                List<viewHeaderMachines> ViewHeaderListMachines = new List<viewHeaderMachines>();

//                var tblDet = db.TblCheckListMachines.Where(m => m.IsDeleted == 0).ToList();
//                if (tblDet.Count > 0)
//                {
//                    foreach (var hId in tblDet)
//                    {

//                        viewHeaderMachines ViewHeaderListMachinesOne = new viewHeaderMachines();
//                        ViewHeaderListMachinesOne.HeaderId = hId.CheckListHeaderId;
//                        ViewHeaderListMachinesOne.CheckListName = db.UnitworkccsTblchecklistHeader.Where(m => m.HeaderId == hId.CheckListHeaderId).Select(m => m.CheckListNo).FirstOrDefault();

//                        string[] mids = hId.MachineIds.Split(',');
//                        List<string> mIdList = new List<string>();
//                        mIdList = mids.ToList();
//                        List<MachineDet> mIdNamesList = new List<MachineDet>();

//                        foreach (var mDet in mIdList)
//                        {
//                            var mId = Convert.ToInt32(mDet);
//                            MachineDet mIdNames = new MachineDet();
//                            mIdNames.machineId = mId;
//                            mIdNames.machineName = db.Tblmachinedetails.Where(m => m.MachineId == mId).Select(m => m.MachineName).FirstOrDefault();
//                            mIdNamesList.Add(mIdNames);
//                        }

//                        var plantname = db.UnitworkccsTblplant.Where(m => m.PlantId == hId.PlantId).Select(m => m.PlantName).FirstOrDefault();
//                        var categoryname = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == hId.CategoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
//                        var makename = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == hId.MakeId).Select(m => m.MakeName).FirstOrDefault();
//                        ViewHeaderListMachinesOne.plantId = hId.PlantId;
//                        ViewHeaderListMachinesOne.plantName = plantname;
//                        ViewHeaderListMachinesOne.categoryId = hId.CategoryId;
//                        ViewHeaderListMachinesOne.categoryName = categoryname;
//                        ViewHeaderListMachinesOne.MakeId = hId.MakeId;
//                        ViewHeaderListMachinesOne.makeName = makename;
//                        ViewHeaderListMachinesOne.MachinesDet = mIdNamesList;
//                        ViewHeaderListMachines.Add(ViewHeaderListMachinesOne);
//                    }
//                }

//                if (ViewHeaderListMachines.Count > 0)
//                {
//                    obj.isStatus = true;
//                    obj.response = ViewHeaderListMachines;
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

//        public CommonResponse DeleteHeaderMachine(int HeaderId)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                var check = db.TblCheckListMachines.Where(m => m.CheckListHeaderId == HeaderId && m.IsDeleted == 0).FirstOrDefault();
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

//        /// <summary>
//        /// Update Check List Header
//        /// </summary>
//        /// <param name="data"></param>
//        /// <returns></returns>
//        public CommonResponse UpdateCheckListHeader(addHeader data)
//        {
//            CommonResponse obj = new CommonResponse();
//            try
//            {
//                if (data.flag == 0)
//                {
//                    var check = db.UnitworkccsTblchecklistHeader.Where(m => m.HeaderId == data.HeaderId && m.IsDeleted == 0).FirstOrDefault();
//                    if (check == null)
//                    {
//                        check.CategoryId = data.categoryId;
//                        check.CategoryName = db.UnitworkccsTblmachinecategorynames.Where(m => m.MachineCategoryId == data.categoryId).Select(m => m.MachineCategoryName).FirstOrDefault();
//                        check.MakeId = data.makeId;
//                        check.MakeName = db.UnitworkccsTblMachinemakedetails.Where(m => m.MakeId == data.makeId).Select(m => m.MakeName).FirstOrDefault();
//                        check.PreparedBy = data.LoginId;
//                        check.CheckListNo = data.checkListNo;
//                        check.IsDeleted = 0;
//                        check.ModifiedOn = DateTime.Now;
//                        db.SaveChanges();
//                        string[] checkListNo = data.checkListNo.Split('#');
//                        check.CheckListNo = checkListNo[0] + "#" + check.HeaderId;
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
//    }
//}
#endregion old code
