using IFacilityMaini.DAL.Resource;
using IFacilityMaini.DBModels;
using IFacilityMaini.Interface;
using Microsoft.Extensions.Configuration;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
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
                    var check = db.UnitworkccsTblstoppage.Where(m => m.StoppagesId == item.stoppageId && m.AlramNo == item.alarmNo).FirstOrDefault();
                    if (check == null)
                    {
                        UnitworkccsTblstoppage tblStoppage = new UnitworkccsTblstoppage();
                        tblStoppage.CategoryId = item.categoryId;

                        tblStoppage.AlramNo = item.alarmNo;
                        tblStoppage.AlramDesc = item.alarmDesc;
                        tblStoppage.SourceId = item.sourceId;
                        tblStoppage.IsDeleted = 0;
                        tblStoppage.CreatedOn = DateTime.Now;
                        db.UnitworkccsTblstoppage.Add(tblStoppage);
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
                var check = (from wf in db.UnitworkccsTblstoppage
                             where wf.IsDeleted == 0
                             select new
                             {
                                 stoppagesId = wf.StoppagesId,
                                 sourseName = db.UnitworkccsTblsourcemaster.Where(m => m.SourceId == wf.SourceId).Select(m => m.SourceName).FirstOrDefault(),
                                 sourceId = wf.SourceId,
                                 alramNo = wf.AlramNo,
                                 alramDesc = wf.AlramDesc,
                                 categoryName = db.UnitworkccsTblcategorymaster.Where(m => m.CategoryId == wf.CategoryId).Select(m => m.CategoryName).FirstOrDefault(),
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
                var check = db.UnitworkccsTblstoppage.Where(m => m.StoppagesId == stoppagesId).FirstOrDefault();
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
                var check = (from wf in db.UnitworkccsTblsourcemaster
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
            catch (Exception e)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        public CommonResponse DownloadListOfStoppageDetails()
        {
            CommonResponse obj = new CommonResponse();
            try
            {

                FileInfo templateFile = new FileInfo(@"C:\SRKS_ifacility\MainTemplate\ListOfStoppage_Details.xlsx");

                ExcelPackage templatep = new ExcelPackage(templateFile);
                ExcelWorksheet Templatews = templatep.Workbook.Worksheets[0];
                //  ExcelWorksheet TemplateGraph = templatep.Workbook.Worksheets[1];


                //excel file save and  downloaded link



                string ImageUrlSave = configuration.GetSection("AppSettings").GetSection("ImageUrlSave").Value;
                string ImageUrl = configuration.GetSection("AppSettings").GetSection("ImageUrl").Value;

                String FileDir = ImageUrlSave + "\\" + "ListOfStoppage_Details" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
                String retrivalPath = ImageUrl + "ListOfStoppage_Details" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";



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
                // int slno = 1;
                var GetUtilList = db.UnitworkccsTblstoppage.Where(m => m.IsDeleted == 0).ToList();

                if (GetUtilList.Count > 0)
                {
                    foreach (var MacRow in GetUtilList)
                    {
                        // trim	plantCode	partNo	partName	defectCode	defectDescription
                        // worksheet.Cells["" + StartRow].Value = slno++;
                        //worksheet.Cells["A" + StartRow].Value = MacRow.StoppagesId;
                        // worksheet.Cells["B" + StartRow].Value = MacRow.CategoryId;
                        worksheet.Cells["A" + StartRow].Value = db.UnitworkccsTblcategorymaster.Where(m => m.CategoryId == MacRow.CategoryId).Select(m => m.CategoryName).FirstOrDefault();
                        worksheet.Cells["B" + StartRow].Value = MacRow.AlramNo;
                        worksheet.Cells["C" + StartRow].Value = MacRow.AlramDesc;
                        //worksheet.Cells["F" + StartRow].Value = MacRow.SourceId;
                        worksheet.Cells["D" + StartRow].Value = db.UnitworkccsTblsourcemaster.Where(m => m.SourceId == MacRow.SourceId).Select(m => m.SourceName).FirstOrDefault();

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

        public CommonResponse UploadListOfStoppage(List<UploadStoppage> data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTblstoppage.Where(m => m.IsDeleted == 0).ToList();
                db.RemoveRange(check);
                db.SaveChanges();

                foreach (var item in data)
                {

                    UnitworkccsTblstoppage tblStoppage = new UnitworkccsTblstoppage();
                    if (item.categoryName != null)
                    {
                        var categoryId = db.UnitworkccsTblcategorymaster.Where(m => m.CategoryName == item.categoryName).Select(m => m.CategoryId).FirstOrDefault();
                        tblStoppage.CategoryId = categoryId;
                    }

                    tblStoppage.AlramNo = item.alarmNo;
                    tblStoppage.AlramDesc = item.alarmDesc;
                    if (item.sourceName != null)
                    {
                        var sourceId = db.UnitworkccsTblsourcemaster.Where(m => m.SourceName == item.sourceName).Select(m => m.SourceId).FirstOrDefault();
                        tblStoppage.SourceId = sourceId;
                    }

                    tblStoppage.IsDeleted = 0;
                    tblStoppage.CreatedOn = DateTime.Now;
                    db.UnitworkccsTblstoppage.Add(tblStoppage);
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.AddedSuccessMessage;
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
