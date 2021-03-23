using IFacilityMaini.DAL.Resource;
using IFacilityMaini.DBModels;
using IFacilityMaini.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.FGAndCellAllocationEntity;
using System.Globalization;
using IFacilityMaini.DAL.Helpers;
using Microsoft.Extensions.Options;
using ChoETL;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using IFacilityMaini.DAL.App_Start;

namespace IFacilityMaini.DAL
{
    public class FGAndCellAllocationDAL : IFGAndCellAllocation
    {
        unitworksccsContext db = new unitworksccsContext();
        private readonly AppSettings appSettings;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(FGAndCellAllocationDAL));
        public static IConfiguration configuration;

        public FGAndCellAllocationDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings)
        {
            db = _db;
            configuration = _configuration;
            appSettings = _appSettings.Value;
        }

        /// <summary>
        /// View Multiple Plant Codes
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultiplePlantCodes()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.Tblplant
                             where wf.IsDeleted == 0
                             select new
                             {
                                 plantId = wf.PlantId,
                                 plantCode = wf.PlantName
                             }).Distinct().ToList();
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
        /// ViewMultiplePartName
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultiplePartName()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.Tblparts
                             where wf.IsDeleted == 0
                             select new
                             {
                                 partId = wf.PartId,
                                 partNo = wf.Fgcode,
                                 partName = wf.PartName
                             }).Distinct().ToList();

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
        /// View Multiple Cell Final
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleCellFinal()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblCellFinalMaster
                             where wf.IsDeleted == 0
                             select new
                             {
                                 CellFinalId = wf.CellFinalId,
                                 CellFinalName = wf.CellFinalName,
                                 CellFinalDesc = wf.CellFinalDesc
                             }).Distinct().ToList();

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
        /// View Multiple Sub Cell Final
        /// </summary>
        /// <param name="cellFinalId"></param>
        /// <returns></returns>
        public CommonResponse ViewMultipleSubCellFinal(int cellFinalId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblSubCellFinalMaster
                             where wf.IsDeleted == 0 && wf.CellFinalId == cellFinalId
                             select new
                             {
                                 SubCellFinalId = wf.SubCellFinalId,
                                 SubCellFinalName = wf.SubCellFinalName,
                                 SubCellFinalDesc = wf.SubCellFinalDesc
                             }).Distinct().ToList();

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
        /// Add Update Fg And Cell Allocation
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse AddUpdateFgAndCellAllocation(List<AddUpdateFgCellAllocation> data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                foreach (var item in data)
                {
                    var check = db.TblFgAndCellAllocation.Where(m => m.FgAndCellAllocationId == item.fgAndCellAllocationId).FirstOrDefault();
                    if (check == null)
                    {
                        TblFgAndCellAllocation tblFgAndCellAllocation = new TblFgAndCellAllocation();
                        if (item.plantCode != null)
                        {
                            var plantId = db.Tblplant.Where(m => m.PlantCode == item.plantCode).Select(m => m.PlantId).FirstOrDefault();
                            tblFgAndCellAllocation.PlantId = plantId;
                        }
                        else
                        {
                            tblFgAndCellAllocation.PlantId = item.plantId;
                        }
                        tblFgAndCellAllocation.PartNo = item.partNo;
                        tblFgAndCellAllocation.PartName = item.partDesc;
                        tblFgAndCellAllocation.DmcCodeStatus = item.dmcCodeStatus;

                        //if (item.partNo != null)
                        //{
                        //    var partId = db.Tblparts.Where(m => m.Fgcode == item.partNo).Select(m => m.PartId).FirstOrDefault();
                        //    tblFgAndCellAllocation.PartId = partId;
                        //}
                        //else
                        //{
                        //    tblFgAndCellAllocation.PartId = item.partId;
                        //}
                        if (item.cellFinalName != null)
                        {
                            var cellFinalID = db.TblCellFinalMaster.Where(m => m.CellFinalName == item.cellFinalName).Select(m => m.CellFinalId).FirstOrDefault();
                            tblFgAndCellAllocation.CellFinalId = cellFinalID;
                        }
                        else
                        {
                            tblFgAndCellAllocation.CellFinalId = item.cellFinalId;
                        }
                        if (item.subFinalName != null)
                        {
                            var subCellFinalId = db.TblSubCellFinalMaster.Where(m => m.SubCellFinalName == item.subFinalName).Select(m => m.SubCellFinalId).FirstOrDefault();
                            tblFgAndCellAllocation.SubCellFinalId = subCellFinalId;
                        }
                        else
                        {
                            tblFgAndCellAllocation.SubCellFinalId = item.subFinalId;
                        }
                        tblFgAndCellAllocation.IsDeleted = 0;
                        tblFgAndCellAllocation.CreatedOn = DateTime.Now;
                        db.TblFgAndCellAllocation.Add(tblFgAndCellAllocation);
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;
                    }
                    else
                    {
                        if (item.plantCode != null)
                        {
                            var plantId = db.Tblplant.Where(m => m.PlantCode == item.plantCode).Select(m => m.PlantId).FirstOrDefault();
                            check.PlantId = plantId;
                        }
                        else
                        {
                            check.PlantId = item.plantId;
                        }
                        //if (item.partNo != null)
                        //{
                        //    var partId = db.Tblparts.Where(m => m.Fgcode == item.partNo).Select(m => m.PartId).FirstOrDefault();
                        //    check.PartId = partId;
                        //}
                        //else
                        //{
                        //    check.PartId = item.partId;
                        //}
                        check.PartNo = item.partNo;
                        check.PartName = item.partDesc;
                        check.DmcCodeStatus = item.dmcCodeStatus;
                        if (item.cellFinalName != null)
                        {
                            var cellFinalID = db.TblCellFinalMaster.Where(m => m.CellFinalName == item.cellFinalName).Select(m => m.CellFinalId).FirstOrDefault();
                            check.CellFinalId = cellFinalID;
                        }
                        else
                        {
                            check.CellFinalId = item.cellFinalId;
                        }
                        if (item.subFinalName != null)
                        {
                            var subCellFinalId = db.TblSubCellFinalMaster.Where(m => m.SubCellFinalName == item.subFinalName).Select(m => m.SubCellFinalId).FirstOrDefault();
                            check.SubCellFinalId = subCellFinalId;
                        }
                        else
                        {
                            check.SubCellFinalId = item.subFinalId;
                        }
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
        /// View Multiple Fg And Cell Allocation
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleFgAndCellAllocation()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblFgAndCellAllocation
                             where wf.IsDeleted == 0
                             select new
                             {
                                 fgAndCellAllocationId = wf.FgAndCellAllocationId,
                                 plantCode = db.Tblplant.Where(m => m.PlantId == wf.PlantId).Select(m => m.PlantName).FirstOrDefault(),
                                 plantId = wf.PlantId,
                                 //partNo = db.Tblparts.Where(m => m.PartId == wf.PartId).Select(m => m.Fgcode).FirstOrDefault(),
                                 //partId = wf.PartId,
                                 //partDesc = db.Tblparts.Where(m => m.PartId == wf.PartId).Select(m => m.PartName).FirstOrDefault(),
                                 partNo = wf.PartNo,
                                 partDesc = wf.PartName,
                                 cellFinalId = wf.CellFinalId,
                                 cellFinalName = db.TblCellFinalMaster.Where(m => m.CellFinalId == wf.CellFinalId).Select(m => m.CellFinalName).FirstOrDefault(),
                                 subCellFinalId = wf.SubCellFinalId,
                                 subCellFinalName = db.TblSubCellFinalMaster.Where(m => m.SubCellFinalId == wf.SubCellFinalId).Select(m => m.SubCellFinalName).FirstOrDefault(),
                                 dmcCodeStatus = wf.DmcCodeStatus
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
        /// View Multiple Fg And Cell Allocation
        /// </summary>
        /// <param name="fgAndCellAllocationId"></param>
        /// <returns></returns>
        public CommonResponse ViewMultipleFgAndCellAllocation(int fgAndCellAllocationId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblFgAndCellAllocation
                             where wf.IsDeleted == 0 && wf.FgAndCellAllocationId == fgAndCellAllocationId
                             select new
                             {
                                 fgAndCellAllocationId = wf.FgAndCellAllocationId,
                                 plantCode = db.Tblplant.Where(m => m.PlantId == wf.PlantId).Select(m => m.PlantName).FirstOrDefault(),
                                 plantId = wf.PlantId,
                                 //partNo = db.Tblparts.Where(m => m.PartId == wf.PartId).Select(m => m.Fgcode).FirstOrDefault(),
                                 //partId = wf.PartId,
                                 //partDesc = db.Tblparts.Where(m => m.PartId == wf.PartId).Select(m => m.PartName).FirstOrDefault(),
                                 partNo = wf.PartNo,
                                 partDesc = wf.PartName,
                                 cellFinalId = wf.CellFinalId,
                                 cellFinalName = db.TblCellFinalMaster.Where(m => m.CellFinalId == wf.CellFinalId).Select(m => m.CellFinalName).FirstOrDefault(),
                                 subCellFinalId = wf.SubCellFinalId,
                                 subCellFinalName = db.TblSubCellFinalMaster.Where(m => m.SubCellFinalId == wf.SubCellFinalId).Select(m => m.SubCellFinalName).FirstOrDefault(),
                                 dmcCodeStatus = wf.DmcCodeStatus
                             }).FirstOrDefault();
                if (check != null)
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
        /// Delete Fg And Cell Allocation
        /// </summary>
        /// <param name="fgAndCellAllocationId"></param>
        /// <returns></returns>
        public CommonResponse DeleteFgAndCellAllocation(int fgAndCellAllocationId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.TblFgAndCellAllocation.Where(m => m.FgAndCellAllocationId == fgAndCellAllocationId).FirstOrDefault();
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
        /// Upload Plan Linkage Master
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public CommonResponse UploadPlanLinkageMaster(List<ReadPlanLinkage> data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                foreach (var item in data)
                {
                    //var check = db.TblPlanLinkageMaster.Where(m => m.PlanLinkageId == item.planLinkageId).FirstOrDefault();
                    //if (check == null)
                    //{
                    TblPlanLinkageMaster tblPlanLinkageMaster = new TblPlanLinkageMaster();
                    tblPlanLinkageMaster.PlantId = db.Tblplant.Where(m => m.PlantCode == item.plantId).Select(m => m.PlantId).FirstOrDefault();
                    tblPlanLinkageMaster.ScheduleId = item.scheduleId;
                    string dt = item.scheduleDate;
                    string[] dr = dt.Split(' ');
                    string source = dr[0];
                    DateTime d1 = DateTime.ParseExact(source, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    tblPlanLinkageMaster.ScheduleDate = Convert.ToDateTime(d1.ToString("yyyy-MM-dd") + " " + dr[1]);
                    tblPlanLinkageMaster.ShiftId = item.shiftId;
                    tblPlanLinkageMaster.ProductionOrder = item.productionOrder;
                    tblPlanLinkageMaster.RoutingId = item.routingId;
                    tblPlanLinkageMaster.Operation = item.operation;
                    tblPlanLinkageMaster.WorkOrderQty = item.workOrderQty;
                    tblPlanLinkageMaster.WorkOrderCompletedQty = item.workOrderCompletedQty;
                    tblPlanLinkageMaster.ResourceId = item.resourceId;
                    tblPlanLinkageMaster.ScheduledQty = item.scheduledQty;
                    string dt1 = item.plannedStartTime;
                    string[] dr1 = dt1.Split(' ');
                    string source1 = dr1[0];
                    DateTime d2 = DateTime.ParseExact(source1, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    tblPlanLinkageMaster.PlannedStartTime = Convert.ToDateTime(d2.ToString("yyyy-MM-dd") + " " + dr1[1]);
                    string dt2 = item.plannedEndTime;
                    string[] dr2 = dt2.Split(' ');
                    string source2 = dr2[0];
                    DateTime d3 = DateTime.ParseExact(source2, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    tblPlanLinkageMaster.PlannedEndTime = Convert.ToDateTime(d2.ToString("yyyy-MM-dd") + " " + dr2[1]);
                    tblPlanLinkageMaster.SetUpTime = item.setUpTime;
                    string dt3 = item.plannedEndTime;
                    string[] dr3 = dt3.Split(' ');
                    string source3 = dr3[0];
                    DateTime d4 = DateTime.ParseExact(source3, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    tblPlanLinkageMaster.SapDateTimeStamp = Convert.ToDateTime(d4.ToString("yyyy-MM-dd") + " " + dr3[1]);
                    tblPlanLinkageMaster.FgPartNo = item.fgPartNo;
                    string dt4 = item.plannedEndTime;
                    string[] dr4 = dt2.Split(' ');
                    string source4 = dr4[0];
                    DateTime d5 = DateTime.ParseExact(source4, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    tblPlanLinkageMaster.LastUpdate = Convert.ToDateTime(d2.ToString("yyyy-MM-dd") + " " + dr4[1]);
                    tblPlanLinkageMaster.NumUpdates = item.numUpdates;
                    tblPlanLinkageMaster.LastUpdatedUse = item.lastUpdatedUse;
                    tblPlanLinkageMaster.IsDeleted = 0;
                    tblPlanLinkageMaster.CreatedOn = DateTime.Now;
                    db.TblPlanLinkageMaster.Add(tblPlanLinkageMaster);
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.AddedSuccessMessage;
                    //}
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
        /// Read Plan Visage Master
        /// </summary>
        /// <returns></returns>
        public CommonResponse ReadPlanVisageMaster()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                //string csvInFilePath = appSettings.PlanVisageMaster;
                //string csvOutFilePath = appSettings.PlanVisageMasterBackup;
                //List<ReadPlanLinkage> readPlanLinkagesList = new List<ReadPlanLinkage>();

                //using (var reader = new ChoCSVReader<ReadPlanLinkage>(csvInFilePath).WithFirstLineHeader())
                //{


                //    UploadPlanLinkageMaster(readPlanLinkagesList);
                //    using (var w = new ChoCSVWriter<ReadPlanLinkage>(csvOutFilePath).WithFirstLineHeader())
                //        w.Write(readPlanLinkagesList);
                //        //w.Write(reader.Select(r1 => new { Test1 = r1.plantId, Test2 = r1.scheduleId }));
                //}
                string path = Path.Combine(appSettings.PlanVisageMaster);
                var list = new List<string>();
                DateTime getTime = DateTime.Now;
                string[] time = getTime.ToString().Split(' ');
                string newDate = getTime.ToShortDateString().ToString();
                newDate = newDate.Replace("-", string.Empty);
                newDate = newDate.Replace("/", string.Empty);

                string cpyfileName = "planVisalageMaster_cpy_" + newDate + DateTime.Now.Millisecond + ".csv";

                if (File.Exists(path))
                {
                    try
                    {
                        string[] liness;

                        var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                        {
                            string line;
                            while ((line = streamReader.ReadLine()) != null)
                            {
                                list.Add(line);
                            }
                        }
                        liness = list.ToArray();
                    }
                    catch (Exception ex)
                    {
                        obj.isStatus = false;
                        obj.response = "Exception while reading file";
                    }

                    var copyFilePath = appSettings.PlanVisageMasterBackup + cpyfileName;
                    if (File.Exists(path))
                    {
                        if (!File.Exists(copyFilePath))
                        {
                            File.Copy(path, copyFilePath, true);
                        }
                    }

                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }

                    #region add or update in DB

                    string[] lines;
                    lines = list.ToArray();
                    List<string> list1 = new List<string>(lines);
                    list1.RemoveAt(0);
                    list1.ToList();

                    //var check = db.TblPlanLinkageMaster.Where(m => m.CreatedOn != null).OrderBy(m => m.PlanLinkageId).ToList();
                    //if(check.Count > 0)
                    //{
                    //    db.TblPlanLinkageMaster.RemoveRange(check);
                    //    db.SaveChanges();
                    //}
                    string connectionString1 = Path.Combine(appSettings.DefaultConnection);
                    using (SqlConnection sqlConn = new SqlConnection(connectionString1))
                    {
                        string sql = "Truncate Table [unitworksccs].[unitworkccs].[tblPlanLinkageMaster]";
                        using (SqlCommand sqlCmd = new SqlCommand(sql, sqlConn))
                        {
                            sqlConn.Open();
                            sqlCmd.ExecuteNonQuery();
                        }
                    }

                    //var t = list1.Skip(329).Take(4000).ToList();

                    foreach (var item in list1)
                    {
                        string[] splitAry = item.Split(',');

                        TblPlanLinkageMaster tblPlanLinkageMaster = new TblPlanLinkageMaster();
                        tblPlanLinkageMaster.PlantId = db.Tblplant.Where(m => m.PlantCode == splitAry[0]).Select(m => m.PlantId).FirstOrDefault();
                        tblPlanLinkageMaster.ScheduleId = Convert.ToInt32(splitAry[1]);
                        string dt = splitAry[2];
                        if (dt.Length > 11)
                        {
                            string[] dr = dt.Split(' ');
                            string source = dr[0];
                            //if (source.Contains('/'))
                            //{
                            //    if(source.Length == 8)
                            //    {
                            //        string[] date = source.Split('/');
                            //        if (date[0].Length == 1)
                            //        {
                            //            DateTime d13 = DateTime.ParseExact(source, "M/d/yyyy", CultureInfo.InvariantCulture);
                            //            tblPlanLinkageMaster.ScheduleDate = Convert.ToDateTime(d13.ToString("yyyy-MM-dd") + " " + dr[1]);
                            //        }
                            //        else
                            //        {
                            //            DateTime d16 = DateTime.ParseExact(source, "MM/d/yyyy", CultureInfo.InvariantCulture);
                            //            tblPlanLinkageMaster.ScheduleDate = Convert.ToDateTime(d16.ToString("yyyy-MM-dd") + " " + dr[1]);
                            //        }
                            //    }
                            //    else if(source.Length == 9)
                            //    {
                            //        string[] date = source.Split('/');
                            //        if (date[0].Length == 1)
                            //        {
                            //            DateTime d14 = DateTime.ParseExact(source, "M/dd/yyyy", CultureInfo.InvariantCulture);
                            //            tblPlanLinkageMaster.ScheduleDate = Convert.ToDateTime(d14.ToString("yyyy-MM-dd") + " " + dr[1]);
                            //        }
                            //        else
                            //        {
                            //            DateTime d17 = DateTime.ParseExact(source, "MM/d/yyyy", CultureInfo.InvariantCulture);
                            //            tblPlanLinkageMaster.ScheduleDate = Convert.ToDateTime(d17.ToString("yyyy-MM-dd") + " " + dr[1]);
                            //        }
                            //    }
                            //    else
                            //    {
                            //        DateTime d1 = DateTime.ParseExact(source, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                            //        tblPlanLinkageMaster.ScheduleDate = Convert.ToDateTime(d1.ToString("yyyy-MM-dd") + " " + dr[1]);
                            //    }
                            //}
                            //else
                            //{
                            DateTime d1 = DateTime.ParseExact(source, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                            tblPlanLinkageMaster.ScheduleDate = Convert.ToDateTime(d1.ToString("yyyy-MM-dd") + " " + dr[1]);
                            //}
                        }
                        //else
                        //{
                        //    DateTime d12 = DateTime.ParseExact(dt, "M/d/yyyy", CultureInfo.InvariantCulture);
                        //    tblPlanLinkageMaster.ScheduleDate = Convert.ToDateTime(d12.ToString("yyyy-MM-dd") + " " + "00:00");
                        //}

                        //tblPlanLinkageMaster.ShiftId = Convert.ToInt32(splitAry[3]);
                        //tblPlanLinkageMaster.ProductionOrder = splitAry[4];
                        //tblPlanLinkageMaster.RoutingId = splitAry[5];
                        //tblPlanLinkageMaster.Operation = Convert.ToInt32(splitAry[6]);
                        //tblPlanLinkageMaster.WorkOrderQty = Convert.ToInt32(splitAry[7]);
                        //tblPlanLinkageMaster.WorkOrderCompletedQty = Convert.ToInt32(splitAry[8]);
                        //tblPlanLinkageMaster.ResourceId = splitAry[9];
                        //tblPlanLinkageMaster.ScheduledQty = Convert.ToInt32(splitAry[10]);

                        string dt1 = splitAry[11];
                        //string dt1 = "25-12-2019 18:30:00";

                        if (dt1.Length > 11)
                        {
                            string[] dr1 = dt1.Split(' ');
                            string source1 = dr1[0];
                            //if(source1.Contains('/'))
                            //{
                            //    if (source1.Length == 8)
                            //    {
                            //        string[] date = source1.Split('/');
                            //        if (date[0].Length == 1)
                            //        {
                            //            DateTime d23 = DateTime.ParseExact(source1, "M/d/yyyy", CultureInfo.InvariantCulture);
                            //            tblPlanLinkageMaster.PlannedStartTime = Convert.ToDateTime(d23.ToString("yyyy-MM-dd") + " " + dr1[1]);
                            //        }
                            //        else
                            //        {
                            //            DateTime d26 = DateTime.ParseExact(source1, "MM/d/yyyy", CultureInfo.InvariantCulture);
                            //            tblPlanLinkageMaster.PlannedStartTime = Convert.ToDateTime(d26.ToString("yyyy-MM-dd") + " " + dr1[1]);
                            //        }    
                            //    }
                            //    else if(source1.Length == 9)
                            //    {
                            //        string[] date = source1.Split('/');
                            //        if (date[0].Length == 1)
                            //        {
                            //            DateTime d24 = DateTime.ParseExact(source1, "M/dd/yyyy", CultureInfo.InvariantCulture);
                            //            tblPlanLinkageMaster.PlannedStartTime = Convert.ToDateTime(d24.ToString("yyyy-MM-dd") + " " + dr1[1]);
                            //        }
                            //        else
                            //        {
                            //            DateTime d27 = DateTime.ParseExact(source1, "MM/d/yyyy", CultureInfo.InvariantCulture);
                            //            tblPlanLinkageMaster.PlannedStartTime = Convert.ToDateTime(d27.ToString("yyyy-MM-dd") + " " + dr1[1]);
                            //        }    
                            //    }
                            //    else
                            //    {
                            //        DateTime d2 = DateTime.ParseExact(source1, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                            //        tblPlanLinkageMaster.PlannedStartTime = Convert.ToDateTime(d2.ToString("yyyy-MM-dd") + " " + dr1[1]);
                            //    } 
                            //}
                            //else
                            //{
                            DateTime d2 = DateTime.ParseExact(source1, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                            tblPlanLinkageMaster.PlannedStartTime = Convert.ToDateTime(d2.ToString("yyyy-MM-dd") + " " + dr1[1]);
                        }
                        //}
                        //else
                        //{
                        //    DateTime d25 = DateTime.ParseExact(dt1, "M/d/yyyy", CultureInfo.InvariantCulture);
                        //    tblPlanLinkageMaster.PlannedStartTime = Convert.ToDateTime(d25.ToString("yyyy-MM-dd") +" " + "00:00");
                        //}

                        string dt2 = splitAry[12];
                        //string dt2 = "26-12-2019";

                        if (dt2.Length > 11)
                        {
                            string[] dr2 = dt2.Split(' ');
                            string source2 = dr2[0];
                            //if(source2.Contains('/'))
                            //{
                            //    if(source2.Length == 8)
                            //    {
                            //        string[] date = source2.Split('/');
                            //        if (date[0].Length == 1)
                            //        {
                            //            DateTime d3 = DateTime.ParseExact(source2, "M/d/yyyy", CultureInfo.InvariantCulture);
                            //            tblPlanLinkageMaster.PlannedEndTime = Convert.ToDateTime(d3.ToString("yyyy-MM-dd") + " " + dr2[1]);
                            //        }

                            //    }
                            //    else if(source2.Length == 9)
                            //    {
                            //        DateTime d34 = DateTime.ParseExact(source2, "M/dd/yyyy", CultureInfo.InvariantCulture);
                            //        tblPlanLinkageMaster.PlannedEndTime = Convert.ToDateTime(d34.ToString("yyyy-MM-dd") + " " + dr2[1]);
                            //    }
                            //    else
                            //    {
                            //        DateTime d33 = DateTime.ParseExact(source2, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                            //        tblPlanLinkageMaster.PlannedEndTime = Convert.ToDateTime(d33.ToString("yyyy-MM-dd") + " " + dr2[1]);
                            //    }
                            //}
                            //else
                            //{
                            DateTime d3 = DateTime.ParseExact(source2, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                            tblPlanLinkageMaster.PlannedEndTime = Convert.ToDateTime(d3.ToString("yyyy-MM-dd") + " " + dr2[1]);
                        }
                        //}
                        //else
                        //{
                        //    DateTime d32 = DateTime.ParseExact(dt2, "M/d/yyyy", CultureInfo.InvariantCulture);
                        //    tblPlanLinkageMaster.PlannedEndTime = Convert.ToDateTime(d32.ToString("yyyy-MM-dd") + " " + "00:00");
                        //}

                        //tblPlanLinkageMaster.SetUpTime = Convert.ToDecimal(splitAry[13]);
                        string dt3 = splitAry[14];
                        if (dt3.Length > 11)
                        {
                            string[] dr3 = dt3.Split(' ');
                            string source3 = dr3[0];
                            //if(source3.Contains('/'))
                            //{
                            //    if(source3.Length == 8)
                            //    {
                            //        DateTime d43 = DateTime.ParseExact(source3, "M/d/yyyy", CultureInfo.InvariantCulture);
                            //        tblPlanLinkageMaster.SapDateTimeStamp = Convert.ToDateTime(d43.ToString("yyyy-MM-dd") + " " + dr3[1]);
                            //    }
                            //    else if (source3.Length == 9)
                            //    {
                            //        DateTime d44 = DateTime.ParseExact(source3, "M/dd/yyyy", CultureInfo.InvariantCulture);
                            //        tblPlanLinkageMaster.SapDateTimeStamp = Convert.ToDateTime(d44.ToString("yyyy-MM-dd") + " " + dr3[1]);
                            //    }
                            //    else
                            //    {
                            //        DateTime d4 = DateTime.ParseExact(source3, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                            //        tblPlanLinkageMaster.SapDateTimeStamp = Convert.ToDateTime(d4.ToString("yyyy-MM-dd") + " " + dr3[1]);
                            //    }
                            //}
                            //else
                            //{
                            DateTime d4 = DateTime.ParseExact(source3, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                            tblPlanLinkageMaster.SapDateTimeStamp = Convert.ToDateTime(d4.ToString("yyyy-MM-dd") + " " + dr3[1]);
                        }
                        //}
                        //else
                        //{
                        //    DateTime d42 = DateTime.ParseExact(dt3, "M/d/yyyy", CultureInfo.InvariantCulture);
                        //    tblPlanLinkageMaster.SapDateTimeStamp = Convert.ToDateTime(d42.ToString("yyyy-MM-dd") + " " + "00:00");
                        //}
                        //tblPlanLinkageMaster.FgPartNo = splitAry[15];
                        string dt4 = splitAry[16];
                        if (dt4.Length > 11)
                        {
                            string[] dr4 = dt4.Split(' ');
                            string source4 = dr4[0];
                            //if(source4.Contains('/'))
                            //{
                            //    if(source4.Length == 8)
                            //    {
                            //        DateTime d53 = DateTime.ParseExact(source4, "M/d/yyyy", CultureInfo.InvariantCulture);
                            //        tblPlanLinkageMaster.LastUpdate = Convert.ToDateTime(d53.ToString("yyyy-MM-dd") + " " + dr4[1]);
                            //    }
                            //    else if (source4.Length == 9)
                            //    {
                            //        DateTime d54 = DateTime.ParseExact(source4, "M/dd/yyyy", CultureInfo.InvariantCulture);
                            //        tblPlanLinkageMaster.LastUpdate = Convert.ToDateTime(d54.ToString("yyyy-MM-dd") + " " + dr4[1]);
                            //    }
                            //    else
                            //    {
                            //        DateTime d5 = DateTime.ParseExact(source4, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                            //        tblPlanLinkageMaster.LastUpdate = Convert.ToDateTime(d5.ToString("yyyy-MM-dd") + " " + dr4[1]);
                            //    }
                            //}
                            //else
                            //{
                            DateTime d5 = DateTime.ParseExact(source4, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                            tblPlanLinkageMaster.LastUpdate = Convert.ToDateTime(d5.ToString("yyyy-MM-dd") + " " + dr4[1]);
                        }
                        //}
                        //else
                        //{
                        //    DateTime d52 = DateTime.ParseExact(dt4, "M/d/yyyy", CultureInfo.InvariantCulture);
                        //    tblPlanLinkageMaster.LastUpdate = Convert.ToDateTime(d52.ToString("yyyy-MM-dd") + " " + "00:00");
                        //}

                        //tblPlanLinkageMaster.NumUpdates = Convert.ToInt32(splitAry[18]);
                        //tblPlanLinkageMaster.LastUpdatedUse = splitAry[17];
                        //tblPlanLinkageMaster.IsDeleted = 0;
                        //tblPlanLinkageMaster.CreatedOn = DateTime.Now;
                        //db.TblPlanLinkageMaster.Add(tblPlanLinkageMaster);
                        //db.SaveChanges();

                        #region Stored procedure 

                        string connectionString = Path.Combine(appSettings.DefaultConnection);
                        using (SqlConnection sqlConn = new SqlConnection(connectionString))
                        {
                            string sql = "InsertPlanVisage";
                            using (SqlCommand sqlCmd = new SqlCommand(sql, sqlConn))
                            {
                                sqlCmd.CommandType = CommandType.StoredProcedure;
                                sqlCmd.Parameters.AddWithValue("@plantId", tblPlanLinkageMaster.PlantId);
                                sqlCmd.Parameters.AddWithValue("@scheduleId", Convert.ToInt32(splitAry[1]));
                                sqlCmd.Parameters.AddWithValue("@scheduleDate", tblPlanLinkageMaster.ScheduleDate);
                                sqlCmd.Parameters.AddWithValue("@shiftId", Convert.ToInt32(splitAry[3]));
                                sqlCmd.Parameters.AddWithValue("@productionOrder", splitAry[4]);
                                sqlCmd.Parameters.AddWithValue("@routingId", splitAry[5]);
                                sqlCmd.Parameters.AddWithValue("@operation", Convert.ToInt32(splitAry[6]));
                                sqlCmd.Parameters.AddWithValue("@workOrderQty", Convert.ToDecimal(splitAry[7]));
                                sqlCmd.Parameters.AddWithValue("@workOrderCompletedQty", Convert.ToInt32(splitAry[8]));
                                sqlCmd.Parameters.AddWithValue("@resourceId", splitAry[9]);
                                sqlCmd.Parameters.AddWithValue("@scheduledQty", Convert.ToInt32(splitAry[10]));
                                sqlCmd.Parameters.AddWithValue("@plannedStartTime", tblPlanLinkageMaster.PlannedStartTime);
                                sqlCmd.Parameters.AddWithValue("@plannedEndTime", tblPlanLinkageMaster.PlannedEndTime);
                                sqlCmd.Parameters.AddWithValue("@setUpTime", Convert.ToDecimal(splitAry[13]));
                                sqlCmd.Parameters.AddWithValue("@sapDateTimeStamp", tblPlanLinkageMaster.SapDateTimeStamp);
                                sqlCmd.Parameters.AddWithValue("@fgPartNo", splitAry[15]);
                                sqlCmd.Parameters.AddWithValue("@lastUpdate", tblPlanLinkageMaster.LastUpdate);
                                sqlCmd.Parameters.AddWithValue("@LastUpdatedUse", splitAry[17]);
                                sqlCmd.Parameters.AddWithValue("@numUpdates", Convert.ToInt32(splitAry[18]));
                                if (splitAry[19] == "")
                                {
                                    sqlCmd.Parameters.AddWithValue("@cycleTime", Convert.ToDecimal(0.0));
                                }
                                else if (splitAry[19] == "1.00E-06")
                                {
                                    sqlCmd.Parameters.AddWithValue("@cycleTime", Convert.ToDecimal(0.000001));
                                }
                                else
                                {
                                    sqlCmd.Parameters.AddWithValue("@cycleTime", Convert.ToDecimal(splitAry[19]));
                                }
                                sqlCmd.Parameters.AddWithValue("@unit", splitAry[20]);
                                sqlCmd.Parameters.AddWithValue("@partName", splitAry[21]);
                                sqlCmd.Parameters.AddWithValue("@isDeleted", 0);
                                sqlCmd.Parameters.AddWithValue("@createdOn", DateTime.Now);
                                sqlConn.Open();
                                sqlCmd.ExecuteNonQuery();
                            }
                        }
                        #endregion
                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;
                    }
                    #endregion
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

        //public CommonResponse GeneratePlanVisageFile()
        //{
        //    CommonResponse obj = new CommonResponse();
        //    CommonFunction commonFunction = new CommonFunction();
        //    try
        //    {
        //        string correctedDate = commonFunction.GetCorrectedDate();
        //        var fgPartDetails = db.TblFgPartNoDet.Where(m => m.CorrectedDate == correctedDate && m.IsClosed == 1).ToList();

        //        //var actualValue = fgPartDetails.GroupBy(m => m.MachineId).Select
        //        //(m=> new { totalActualValue = m.Sum(n => n.ActaulValue) }).ToList();

        //        var actualValue = fgPartDetails
        //                   .GroupBy(a => a.MachineId)
        //                   .Select(a => new { totalActaulValue = a.Sum(b => b.ActaulValue), machineId = a.Key }).ToList();

        //        DateTime getTime = DateTime.Now;
        //        string[] time = getTime.ToString().Split(' ');
        //        string newPathTime = time[1].Replace(":", string.Empty).ToString();
        //        newPathTime = newPathTime.Remove(newPathTime.Length - 2, 2);
        //        string newDate = getTime.ToShortDateString().ToString();
        //        newDate = newDate.Replace("-", string.Empty);
        //        newDate = newDate.Replace("/", string.Empty);

        //        // YYYYmmdd-hr format for file name

        //        int hour = DateTime.Now.Hour;
        //        string dateFormat = DateTime.Now.ToString("yyyy/MM/dd");
        //        dateFormat = dateFormat.Replace("/", string.Empty);

        //        string fileName = "PlanVisage_Sap" + dateFormat + "-" + hour.ToString("D2") + ".txt";
        //        //commonFunction.InsertToSAPFileGeneratedDate(sapDetails.Count, fileName, hour);
        //        string path = Path.Combine(appSettings.SAPRefFilePath, fileName);
        //        var retrivalPath = Path.Combine(appSettings.ImageUrl, fileName);
        //    }
        //    catch (Exception e)
        //    {
        //        obj.isStatus = false;
        //        obj.response = ResourceResponse.FailureMessage;
        //    }
        //    return obj;
        //}
    }
}
