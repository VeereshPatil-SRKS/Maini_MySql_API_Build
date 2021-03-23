using IFacilityMaini.DAL.Resource;
using IFacilityMaini.DBModels;
using IFacilityMaini.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.ListOfStoppageEntity;

namespace IFacilityMaini.DAL
{
    public class ListOfStoppageDAL : IListOfStoppage
    {
        unitworksccsContext db = new unitworksccsContext();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ListOfStoppageDAL));
        public static IConfiguration configuration;

        public ListOfStoppageDAL(unitworksccsContext _db, IConfiguration _configuration)
        {
            db = _db;
            configuration = _configuration;
        }

        /// <summary>
        /// Add Update List Of Stoppage
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse AddUpdateListOfStoppage(List<AddAndEditStoppage> data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                foreach (var item in data)
                {
                    var check = db.TblStoppage.Where(m => m.StoppagesId == item.stoppageId && m.AlramNo == item.alarmNo).FirstOrDefault();
                    if (check == null)
                    {
                        TblStoppage tblStoppage = new TblStoppage();
                        if (item.categoryName != null)
                        {
                            var categoryId = db.TblCategoryMaster.Where(m => m.CategoryName == item.categoryName).Select(m => m.CategoryId).FirstOrDefault();
                            tblStoppage.CategoryId = categoryId;
                        }
                        else
                        {
                            tblStoppage.CategoryId = item.categoryId;
                        }

                        tblStoppage.AlramNo = item.alarmNo;
                        tblStoppage.AlramDesc = item.alarmDesc;
                        if (item.sourceName != null)
                        {
                            var sourceId = db.TblSourceMaster.Where(m => m.SourceName == item.sourceName).Select(m => m.SourceId).FirstOrDefault();
                            tblStoppage.SourceId = sourceId;
                        }
                        else
                        {
                            tblStoppage.SourceId = item.sourceId;
                        }

                        tblStoppage.IsDeleted = 0;
                        tblStoppage.CreatedOn = DateTime.Now;
                        db.TblStoppage.Add(tblStoppage);
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;
                    }
                    else
                    {
                        check.CategoryId = item.categoryId;
                        check.AlramNo = item.alarmNo;
                        check.AlramDesc = item.alarmDesc;
                        check.SourceId = item.sourceId;
                        check.IsDeleted = 0;
                        check.ModifiedOn = DateTime.Now;
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.UpdatedSuccessMessage;
                    }
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
        /// View Multiple List Of Stoppage
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleListOfStoppage()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblStoppage
                             where wf.IsDeleted == 0
                             select new
                             {
                                 stoppagesId = wf.StoppagesId,
                                 sourseName = db.TblSourceMaster.Where(m => m.SourceId == wf.SourceId).Select(m => m.SourceName).FirstOrDefault(),
                                 sourceId = wf.SourceId,
                                 alramNo = wf.AlramNo,
                                 alramDesc = wf.AlramDesc,
                                 categoryName = db.TblCategoryMaster.Where(m => m.CategoryId == wf.CategoryId).Select(m => m.CategoryName).FirstOrDefault(),
                                 categoryId = wf.CategoryId
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

        /// <summary>
        /// Delete List OfS toppage
        /// </summary>
        /// <param name="stoppagesId"></param>
        /// <returns></returns>
        public CommonResponse DeleteListOfStoppage(int stoppagesId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.TblStoppage.Where(m => m.StoppagesId == stoppagesId).FirstOrDefault();
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
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// View Multiple Sources
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleSources()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblSourceMaster
                             where wf.IsDeleted == 0
                             select new
                             {
                                 SourceId = wf.SourceId,
                                 SourceName = wf.SourceName,
                                 SourceDescription = wf.SourceDescription
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
            catch (Exception e)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

    }
}
