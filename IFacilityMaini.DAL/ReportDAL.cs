using IFacilityMaini.DAL.Helpers;
using IFacilityMaini.DAL.Resource;
using IFacilityMaini.DBModels;
using IFacilityMaini.Interface;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.ReportEntity;
using System.IO;
using OfficeOpenXml;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace IFacilityMaini.DAL
{
    public class ReportDAL : IReport
    {
        unitworksccsContext db = new unitworksccsContext();
      //  private readonly AppSettings appSettings;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ReportDAL));
        public static IConfiguration configuration;

        public ReportDAL(unitworksccsContext _db,IOptions<AppSettings> _appSettings, IConfiguration _configuration)
        {
            db = _db;
            configuration = _configuration;
           // appSettings = _appSettings.Value;
        }

        /// <summary>
        /// View Multiple Plant 
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultiplePlant()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblplant
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
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }
        public CommonResponse ViewMultiShift()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblshiftMstr
                             where wf.IsDeleted == 0
                             select new
                             {
                                 shiftId = wf.ShiftId,
                                 shiftName = wf.ShiftName
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
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }
        public CommonResponse ViewMultipleMachines(int plantId, string category)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                List<machinedet> machinesList = new List<machinedet>();
                if (category == "all machines")
                {

                    var check1 = db.UnitworkccsTblmachinedetails.Where(m => m.PlantId == plantId && m.IsDeleted == 0).ToList();
                    foreach (var mach in check1)
                    {
                        machinedet machines = new machinedet();
                        machines.machineId = mach.MachineId;
                        machines.machineName = mach.MachineName;
                        machinesList.Add(machines);
                    }

                }
                else
                {
                    var check1 = db.UnitworkccsTblmachinedetails.Where(m => m.PlantId == plantId && m.IsDeleted == 0 && m.Category == category).ToList();
                    foreach (var mach in check1)
                    {
                        machinedet machines = new machinedet();
                        machines.machineId = mach.MachineId;
                        machines.machineName = mach.MachineName;
                        machinesList.Add(machines);
                    }

                }



                if (machinesList.Count > 0)
                {
                    obj.isStatus = true;
                    obj.response = machinesList;
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
        public CommonResponse OEEReport1(OEEdetails data)
        {
            CommonResponse obj = new CommonResponse();

            try
            {
                string[] machinelistids;


                DateTime FromDate = DateTime.Now;
                try
                {
                    string[] dt = data.fromDate.Split('/');
                    string frDate = dt[2] + '-' + dt[1] + '-' + dt[0];
                    FromDate = Convert.ToDateTime(frDate);
                }
                catch
                {
                    FromDate = Convert.ToDateTime(data.fromDate);
                }
                DateTime ToDate = DateTime.Now;
                try
                {
                    string[] dt = data.toDate.Split('/');
                    string torDate = dt[2] + '-' + dt[1] + '-' + dt[0];
                    ToDate = Convert.ToDateTime(torDate);
                }
                catch
                {
                    ToDate = Convert.ToDateTime(data.toDate).AddHours(24);
                }



                int dateDifference = Convert.ToDateTime(ToDate).Subtract(Convert.ToDateTime(FromDate)).Days;


                var getMachineList = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0).ToList();



                if (data.machineIds != null)
                {

                    machinelistids = data.machineIds.Split(',');

                }
                else
                {
                    if (data.plantId != 0 && data.category == "all machines")
                    {
                        getMachineList = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0 && m.PlantId == data.plantId).ToList();
                    }


                    else if (data.category != null)
                    {
                        getMachineList = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0 && m.PlantId == data.plantId && m.Category == data.category).ToList();
                    }



                    var machineidss = getMachineList.Select(m => m.MachineId).ToList();
                    int[] machineidsss = machineidss.ToArray();
                    machinelistids = Array.ConvertAll(machineidsss, ele => ele.ToString());



                }



                //string ids= string.Join(",", strArray);

                // int[] intarray = machineidsss;
                //   string[] result = intarray.Select(x => x.ToString()).ToArray();






                OEEReportCalculations OEC = new OEEReportCalculations();
                double AvailabilityPercentage = 0;
                double PerformancePercentage = 0;
                double QualityPercentage = 0;
                double OEEPercentage = 0;
                // OEC.GETCYCLETIMEAnalysis(MachineID, FromDate);




                FileInfo templateFile = new FileInfo(@"C:\SRKS_ifacility\MainTemplate\OEE_Report.xlsx");

                ExcelPackage templatep = new ExcelPackage(templateFile);
                ExcelWorksheet Templatews = templatep.Workbook.Worksheets[0];
                ExcelWorksheet TemplateGraph = templatep.Workbook.Worksheets[1];


                //excel file save and  downloaded link

            

                string ImageUrlSave = configuration.GetSection("AppSettings").GetSection("ImageUrlSave").Value;
                string ImageUrl = configuration.GetSection("AppSettings").GetSection("ImageUrl").Value;

                String FileDir = ImageUrlSave + "\\" + "OEE_Report_" + Convert.ToDateTime(ToDate).ToString("yyyy-MM-dd") + ".xlsx";
                String retrivalPath = ImageUrl + "OEE_Report_" + Convert.ToDateTime(ToDate).ToString("yyyy-MM-dd") + ".xlsx";

                //bool exists = System.IO.Directory.Exists(FileDir);
                //if (!exists)
                //    System.IO.Directory.CreateDirectory(FileDir);

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



                //


                //String FileDir = @"C:\SRKS_ifacility\ReportsList\" + Convert.ToDateTime(ToDate).ToString("yyyy-MM-dd");
                //bool exists = System.IO.Directory.Exists(FileDir);
                //if (!exists)
                //    System.IO.Directory.CreateDirectory(FileDir);

                //FileInfo newFile = new FileInfo(System.IO.Path.Combine(FileDir, "OEE_Report" + Convert.ToDateTime(ToDate).ToString("yyyy-MM-dd") + ".xlsx")); //+ " to " + toda.ToString("yyyy-MM-dd") 
                //if (newFile.Exists)
                //{
                //    try
                //    {
                //        newFile.Delete();  // ensures we create a new workbook
                //        newFile = new FileInfo(System.IO.Path.Combine(FileDir, "OEE_Report" + Convert.ToDateTime(ToDate).ToString("yyyy-MM-dd") + ".xlsx"));
                //    }
                //    catch
                //    {
                //        obj.response = "Excel with same date is already open, please close it and try to generate!!!!";
                //        //return View();
                //    }
                //}




                //Using the File for generation and populating it
                ExcelPackage p = null;
                p = new ExcelPackage(newFile);
                ExcelWorksheet worksheet = null;
                ExcelWorksheet worksheetGraph = null;

                //Creating the WorkSheet for populating
                try
                {
                    worksheet = p.Workbook.Worksheets.Add(Convert.ToDateTime(ToDate).ToString("dd-MM-yyyy"), Templatews);
                    worksheetGraph = p.Workbook.Worksheets.Add("Graphs", TemplateGraph);
                }
                catch { }

                if (worksheet == null)
                {
                    worksheet = p.Workbook.Worksheets.Add(Convert.ToDateTime(ToDate).ToString("dd-MM-yyyy") + "1", Templatews);
                    worksheetGraph = p.Workbook.Worksheets.Add(System.DateTime.Now.ToString("dd-MM-yyyy") + "Graph", TemplateGraph);
                }
                else if (worksheetGraph == null)
                {
                    worksheetGraph = p.Workbook.Worksheets.Add(System.DateTime.Now.ToString("dd-MM-yyyy") + "Graph", TemplateGraph);
                }
                int sheetcount = p.Workbook.Worksheets.Count;
                p.Workbook.Worksheets.MoveToStart(sheetcount - 1);
                worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Cells.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                int StartRow = 2;
                //int SlNo = 1;

                // int MachineCount = getMachineList.Count;

                //  string[] machines1 = data.machineIds.Split(',');

                int MachineCount = machinelistids.Count();

                int Startcolumn = 11;
                String ColNam = ExcelColumnFromNumber(Startcolumn);
                var GetMainLossList = db.UnitworkccsTbllossescodes.Where(m => m.LossCodesLevel == 1 && m.IsDeleted == 0 && m.MessageType != "SETUP").OrderBy(m => m.LossCodeId).ToList();

                foreach (var LossRow in GetMainLossList)
                {
                    ColNam = ExcelColumnFromNumber(Startcolumn);
                    worksheet.Cells[ColNam + "1"].Value = LossRow.LossCodeDesc;
                    Startcolumn++;
                }

                //Tabular sheet Data Population
                for (int i = 0; i <= dateDifference; i++)
                {
                    //string[] machines = data.machineIds.Split(',');

                    string[] machines = machinelistids;
                    DateTime QueryDate = Convert.ToDateTime(FromDate).AddDays(i);
                    string CorrectedDate = QueryDate.ToString("yyyy-MM-dd");
                    //  for (i = 0; i < getMachineList.Count(); i++)

                    for (int j = 0; j < machines.Count(); j++)
                    {



                        int machineid = Convert.ToInt32(machines[j]);

                        //insert the oee data 

                       OEC.OEE(machineid, CorrectedDate);

                        int MacStartcolumn = 11;

                        var GetUtilList = db.UnitworkccsTblOeedetails.Where(m => m.MachineId == machineid && m.CorrectedDate == CorrectedDate).ToList();

                        if (GetUtilList.Count > 0)
                        {



                            foreach (var MacRow in GetUtilList)
                            {
                                var machineName = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == machineid).FirstOrDefault();
                                //var partdet = db.tblparts.Where(m => m.MachineID == MacRow.MachineID).FirstOrDefault();


                                var plantcode = db.UnitworkccsTblplant.Where(m => m.PlantId == machineName.PlantId).Select(m => m.PlantCode).FirstOrDefault();
                                worksheet.Cells["A" + StartRow].Value = plantcode;

                                var spliteMachine = machineName.MachineName.Split('_');
                                if ((machineName.MachineName).Contains('_'))
                                {
                                    worksheet.Cells["B" + StartRow].Value = spliteMachine[1];
                                }
                                else
                                {
                                    worksheet.Cells["B" + StartRow].Value = machineName.MachineName;
                                }


                                //worksheet.Cells["A" + StartRow].Value = machineName.MachineName;

                                worksheet.Cells["C" + StartRow].Value = MacRow.OpNo;
                                worksheet.Cells["D" + StartRow].Value = MacRow.FgPartNo;
                                worksheet.Cells["E" + StartRow].Value = CorrectedDate;
                                worksheet.Cells["F" + StartRow].Value = MacRow.OperatingTimeinMin;
                                worksheet.Cells["G" + StartRow].Value = MacRow.OkQty;
                                worksheet.Cells["H" + StartRow].Value = MacRow.RejectionQty;
                                worksheet.Cells["I" + StartRow].Value = MacRow.OkQty + MacRow.RejectionQty + MacRow.ReworkQty + MacRow.DryRunQty + MacRow.TrialPartCount;
                                worksheet.Cells["J" + StartRow].Value = MacRow.DryRunQty;
                                worksheet.Cells["K" + StartRow].Value = MacRow.ReworkQty;
                                worksheet.Cells["L" + StartRow].Value = MacRow.TrialPartCount;
                                worksheet.Cells["M" + StartRow].Value = MacRow.TotalIdletimeinMin;
                                worksheet.Cells["N" + StartRow].Value = MacRow.BdTime;
                                worksheet.Cells["O" + StartRow].Value = MacRow.PowerOffTimeInMinutes;
                                worksheet.Cells["P" + StartRow].Value = 0;
                                worksheet.Cells["Q" + StartRow].Value = MacRow.MinorLossTime;
                                worksheet.Cells["R" + StartRow].Value = MacRow.TotalTimeInMinutes;
                                worksheet.Cells["S" + StartRow].Value = MacRow.Availability;
                                worksheet.Cells["T" + StartRow].Value = MacRow.Quality;
                                worksheet.Cells["U" + StartRow].Value = MacRow.Performance;
                                worksheet.Cells["V" + StartRow].Value = MacRow.Oee;

                                StartRow++;
                            }
                        }


                    }
                }

                DataTable LossTbl = new DataTable();
                LossTbl.Columns.Add("LossID", typeof(int));
                LossTbl.Columns.Add("LossDuration", typeof(int));
                LossTbl.Columns.Add("LossTarget", typeof(string));
                LossTbl.Columns.Add("LossName", typeof(string));
                LossTbl.Columns.Add("LossActual", typeof(string));

                //Graph Sheet Population
                //Start Date and End Date
                worksheetGraph.Cells["C6"].Value = Convert.ToDateTime(FromDate).ToString("dd-MM-yyyy");
                worksheetGraph.Cells["E6"].Value = Convert.ToDateTime(ToDate).ToString("dd-MM-yyyy");
                int GetHolidays = getsundays(Convert.ToDateTime(ToDate), Convert.ToDateTime(FromDate));
                int WorkingDays = (dateDifference - GetHolidays) + 1;
                //Working Days
                worksheetGraph.Cells["E5"].Value = WorkingDays;
                //Planned Production Time
                worksheetGraph.Cells["E10"].Value = WorkingDays * 24;
                double TotalOperatingTime = 0;
                double DayDownTime = 0;
                double TotalDownTime = 0;
                double TotalAcceptedQty = 0;
                double TotalRejectedQty = 0;
                double TotalPerformanceFactor = 0;


                double AvsumNu = 0;
                double AvsumDe = 0;
                double PfsumNu = 0;
                double PfsumDe = 0;
                double QntsumNu = 0;
                double QntsumDe = 0;



                double totalActualqnt = 0;
                double totalTrialqnt = 0;
                
                

                double TotalAvailability = 0;
                double TotalPerformance = 0;
                double TotalQuality = 0;
                double TotalOee = 0;


                double TotalAvailability1 = 0;
                double TotalPerformance1 = 0;
                double TotalQuality1 = 0;
                double TotalOee1 = 0;
                double TrandChatOee = 0;



                int count2 = 0;


                int StartGrpah1 = 48;



                if (data.machineIds == null)
                {
                    worksheetGraph.Cells["C4"].Value = data.category;
                    worksheetGraph.Cells["C5"].Value = machinelistids.Count().ToString();
                }
                else
                {
                    worksheetGraph.Cells["C4"].Value = data.category;
                    worksheetGraph.Cells["C5"].Value = machinelistids.Count().ToString();
                }




                for (int i = 0; i <= dateDifference; i++)
                {
                    double DayOperatingTime = 0;
                   // double DayDownTime = 0;
                    double DayAcceptedQty = 0;
                    double DayRejectedQty = 0;
                    double DayPerformanceFactor = 0;
                    DateTime QueryDate = Convert.ToDateTime(FromDate).AddDays(i);
                    string CorrectedDate = QueryDate.ToString("yyyy-MM-dd");
                    var plantName = db.UnitworkccsTblplant.Where(m => m.PlantId == data.plantId).Select(m => m.PlantName).FirstOrDefault();
                    worksheetGraph.Cells["C3"].Value = plantName;

                    string[] machines = machinelistids;

                    // for (i = 0; i < getMachineList.Count(); i++)
                    for (int j = 0; j < machines.Count(); j++)
                    {

                        var machineid = Convert.ToInt32(machines[j]);

                        var GetUtilList = db.UnitworkccsTblOeedetails.Where(m => m.MachineId == machineid && m.CorrectedDate == CorrectedDate).ToList();
                        int count1 = GetUtilList.Count();

                        if (GetUtilList.Count > 0)
                        {

                            TrandChatOee = 0;

                            foreach (var ProdRow in GetUtilList)
                            {
                                //Total Values
                                TotalOperatingTime += (double)ProdRow.OperatingTimeinMin;
                                TotalDownTime += (double)ProdRow.TotalIdletimeinMin;
                                TotalAcceptedQty += Convert.ToInt32(ProdRow.OkQty);

                                totalActualqnt += Convert.ToInt32(ProdRow.ActualQty);
                                totalTrialqnt += Convert.ToInt32(ProdRow.TrialPartCount);

                                TotalRejectedQty += Convert.ToInt32(ProdRow.RejectionQty);
                                // TotalRejectedQty += ProdRow.tblworkorderentry.ScrapQty;
                                TotalPerformanceFactor += (double)ProdRow.PerformanceFactor;
                                //Day Values
                                DayOperatingTime += (double)ProdRow.OperatingTimeinMin;
                                DayDownTime += (double)ProdRow.BdTime;
                                DayAcceptedQty += Convert.ToInt32(ProdRow.OkQty);
                                // DayRejectedQty += ProdRow.tblworkorderentry.ScrapQty;
                                DayRejectedQty += (double)ProdRow.RejectionQty;
                                DayPerformanceFactor += (double)ProdRow.PerformanceFactor;

                                AvsumNu += (double)ProdRow.AvSumNumerator ;
                                AvsumDe+= (double)ProdRow.AvsumDenominator;
                                PfsumNu+= (double)ProdRow.PerSumNumerator;
                                PfsumDe += (double)ProdRow.PerSumDenominator;
                                QntsumNu += (double)ProdRow.QntSumNumerator;
                                QntsumDe+= (double)ProdRow.QntSumDenominator;


                                TotalAvailability += (double)ProdRow.Availability;
                                TotalPerformance += (double)ProdRow.Performance;
                                TotalQuality += (double)ProdRow.Quality;
                                TotalOee += (double)ProdRow.Oee;

                                // TrandChatOee += (double)ProdRow.Oee;

                                worksheetGraph.Cells["B" + StartGrpah1].Value = QueryDate.ToString("dd-MM-yyyy");
                                worksheetGraph.Cells["C" + StartGrpah1].Value = 0.85;
                                worksheetGraph.Cells["D" + StartGrpah1].Value = (double)ProdRow.Oee / 100;


                                StartGrpah1++;

                            }

                            count2 += count1;


                        }



                    }
                    int TotQty = (int)(DayAcceptedQty + DayRejectedQty);
                    if (TotQty == 0)
                        TotQty = 1;

                    double DayOpTime = DayOperatingTime;
                    if (DayOpTime == 0)
                        DayOpTime = 1;




                    decimal DayAvailPercent = (decimal)Math.Round(DayOperatingTime / (24 * WorkingDays), 2);
                    decimal DayPerformancePercent = (decimal)Math.Round(DayPerformanceFactor / DayOpTime, 2);
                    decimal DayQualityPercent = (decimal)Math.Round((DayAcceptedQty / (TotQty)), 2);
                    decimal DayOEEPercent = (decimal)Math.Round((double)(DayAvailPercent) * (double)(DayPerformancePercent) * (double)(DayQualityPercent), 2);




                    //worksheetGraph.Cells["B" + StartGrpah1].Value = QueryDate.ToString("dd-MM-yyyy");
                    //worksheetGraph.Cells["C" + StartGrpah1].Value = 0.85;
                    //worksheetGraph.Cells["D" + StartGrpah1].Value = TrandChatOee / 100 ;

                   // StartGrpah1++;
                }




                //worksheetGraph.Cells["E11"].Value = (double)Math.Round(TotalOperatingTime / 60, 2);
                //worksheetGraph.Cells["E12"].Value = (double)Math.Round(TotalDownTime / 60, 2);
                //worksheetGraph.Cells["E13"].Value = TotalAcceptedQty;
                //worksheetGraph.Cells["E14"].Value = TotalRejectedQty;

                //if (TotalOperatingTime == 0)
                //    TotalOperatingTime = 1;
                //if (TotalAcceptedQty == 0)
                //    TotalAcceptedQty = 1;
                //decimal TotalAvailPercent = (decimal)Math.Round(TotalOperatingTime / (WorkingDays * 24 * 60 * MachineCount), 2);
                //decimal TotalPerformancePercent = (decimal)Math.Round(TotalPerformanceFactor / TotalOperatingTime, 2);
                //decimal TotalQualityPercent = (decimal)Math.Round((TotalAcceptedQty / (TotalAcceptedQty + TotalRejectedQty)), 2);
                //decimal TotalOEEPercent = (decimal)Math.Round((double)(TotalAvailPercent) * (double)(TotalPerformancePercent) * (double)(TotalQualityPercent), 2);












                worksheetGraph.Cells["E11"].Value = (double)Math.Round(TotalOperatingTime / 60, 2);
                worksheetGraph.Cells["E12"].Value = (double)Math.Round(DayDownTime / 60, 2);
                worksheetGraph.Cells["E13"].Value = TotalAcceptedQty;
                worksheetGraph.Cells["E14"].Value = TotalRejectedQty;


                // int count = machinelistids.Count();

               // var totalcount=db.UnitworkccsTblOeedetails.Where(m=>m.CorrectedDate.Contains(data.fromDate) && m.corr )
             //  double finalAvailability= (double)Math.Round(TotalOperatingTime / (WorkingDays * 24 * 60), 2);
              //  TotalAvailability1 = (double)Math.Round((finalAvailability), 2)*100;

                //TotalAvailability1 = (double)Math.Round((TotalAvailability/ count2), 2);

                double finalAvailability = (double)Math.Round(AvsumNu / AvsumDe, 2);
                TotalAvailability1 = (double)Math.Round((finalAvailability), 2) * 100;


                // double finalperformance = (totalActualqnt - totalTrialqnt);
              // double finalperformance= (double)Math.Round(TotalPerformanceFactor / TotalOperatingTime, 2);
               // TotalPerformance1 = (double)Math.Round((finalperformance), 2)*100;
                //TotalPerformance1 = (double)Math.Round((TotalPerformance/count2), 2);

                double finalperformance = (double)Math.Round(PfsumNu / PfsumDe, 2);
                TotalPerformance1 = (double)Math.Round((finalperformance), 2) * 100;

               // double finalqnt = TotalAcceptedQty / totalActualqnt;
              // TotalQuality1 = (double)Math.Round(finalqnt, 2)*100;

                //  TotalQuality1 = (double)Math.Round((TotalQuality/count2), 2);

                double finalqnt = QntsumNu / QntsumDe;
                TotalQuality1 = (double)Math.Round(finalqnt, 2) * 100;




                double finalOee = (TotalAvailability1 * TotalPerformance1 * TotalQuality1)/1000000;
                TotalOee1 = (double)Math.Round((finalOee), 2)*100;

                // TotalOee1 = (double)Math.Round((TotalOee/count2), 2);


                if (TotalAvailability1 > 100)
                {
                    TotalAvailability1 = 100;
                }
                  

                if (TotalPerformance1 > 100)
                {
                    TotalPerformance1 = 100;
                }
                if (TotalQuality1 > 100)
                {
                    TotalQuality1 = 100;
                }

                if (TotalOee1 > 100)
                {
                    TotalOee1 = 100;
                }
                   


                //worksheetGraph.Cells["E20"].Value = (double)Math.Round((TotalAvailability1), 2);
                //worksheetGraph.Cells["E21"].Value = (double)Math.Round((TotalPerformance1), 2);
                //worksheetGraph.Cells["E22"].Value = (double)Math.Round((TotalQuality1), 2);
                //worksheetGraph.Cells["E23"].Value = (double)Math.Round((TotalOee1), 2);
                //worksheetGraph.Cells["G5"].Value = (double)Math.Round((TotalOee1), 2);


                worksheetGraph.Cells["E20"].Value = (double)Math.Round((TotalAvailability1 / 100), 2);
                worksheetGraph.Cells["E21"].Value = (double)Math.Round((TotalPerformance1 / 100), 2);
                worksheetGraph.Cells["E22"].Value = (double)Math.Round((TotalQuality1 / 100), 2);
                worksheetGraph.Cells["E23"].Value = (double)Math.Round((TotalOee1 / 100), 2);
                worksheetGraph.Cells["G5"].Value = (double)Math.Round((TotalOee1 / 100), 2);



                //if (TotalOperatingTime == 0)
                //    TotalOperatingTime = 1;
                //if (TotalAcceptedQty == 0)
                //    TotalAcceptedQty = 1;
                //decimal TotalAvailPercent = (decimal)Math.Round(TotalOperatingTime / (WorkingDays * 24 * 60 * MachineCount), 2);
                //decimal TotalPerformancePercent = (decimal)Math.Round(TotalPerformanceFactor / TotalOperatingTime, 2);
                //decimal TotalQualityPercent = (decimal)Math.Round((TotalAcceptedQty / (TotalAcceptedQty + TotalRejectedQty)), 2);
                //decimal TotalOEEPercent = (decimal)Math.Round((double)(TotalAvailPercent) * (double)(TotalPerformancePercent) * (double)(TotalQualityPercent), 2);

                //if (TotalPerformancePercent > 100)
                //    TotalPerformancePercent = 100;

                //worksheetGraph.View.ShowGridLines = false;

                //DateTime fromDate = Convert.ToDateTime(FromDate);
                //DateTime toDate = Convert.ToDateTime(ToDate);
                //var top3ContrubutingFactors = (from dbItem in db.TblProdOrderLosses
                //                               where dbItem.CorrectedDate >= fromDate.Date && dbItem.CorrectedDate <= toDate.Date
                //                               group dbItem by dbItem.LossId into x
                //                               select new
                //                               {
                //                                   LossId = x.Key,
                //                                   LossDuration = db.TblProdOrderLosses.Where(m => m.LossId == x.Key).Select(m => m.LossDuration).Sum()
                //                               }).ToList();
                //var item = top3ContrubutingFactors.OrderByDescending(m => m.LossDuration).Take(3).ToList();
                //int lossXccelNo = 29;
                //decimal lossPercentage = 0;
                //foreach (var GetRow in item)
                //{
                //    string lossCode = db.UnitworkccsTbllossescodes.Where(m => m.LossCodeId == GetRow.LossId).Select(m => m.LossCodeDesc).FirstOrDefault();
                //    if (TotalDownTime != 0)
                //        lossPercentage = (decimal)Math.Round(((GetRow.LossDuration) / TotalDownTime), 2);
                //    decimal lossDurationInHours = (decimal)Math.Round((GetRow.LossDuration / 60.00), 2);
                //    worksheetGraph.Cells["L" + lossXccelNo].Value = lossCode;
                //    worksheetGraph.Cells["N" + lossXccelNo].Value = lossPercentage;
                //    worksheetGraph.Cells["O" + lossXccelNo].Value = lossDurationInHours;
                //    lossXccelNo++;
                //}

                //int grphData = 5;
                //decimal CumulativePercentage = 0;
                //foreach (var data1 in top3ContrubutingFactors)
                //{
                //    var dbLoss = db.UnitworkccsTbllossescodes.Where(m => m.LossCodeId == data1.LossId).FirstOrDefault();
                //    string lossCode = dbLoss.LossCodeDesc;
                //    decimal Target = dbLoss.TargetPercent;
                //    decimal actualPercentage = (decimal)Math.Round(((data1.LossDuration) / TotalDownTime), 2);
                //    CumulativePercentage = CumulativePercentage + actualPercentage;
                //    worksheetGraph.Cells["K" + grphData].Value = lossCode;
                //    worksheetGraph.Cells["L" + grphData].Value = Target;
                //    worksheetGraph.Cells["M" + grphData].Value = actualPercentage;
                //    worksheetGraph.Cells["N" + grphData].Value = CumulativePercentage;
                //    grphData++;

                //}


                p.Save();

                //Downloding Excel
                string path1 = System.IO.Path.Combine(FileDir, "OEE_Report" + Convert.ToDateTime(ToDate).ToString("yyyy-MM-dd") + ".xlsx");


                //  DownloadUtilReport(path1, "OEE_Report", ToDate.ToString());


                obj.isStatus = true;
                obj.response = retrivalPath;
                // obj.response = path1;



            }
            catch (Exception ex)
            {
                log.Error(ex); if (ex.InnerException != null) { log.Error(ex.InnerException.ToString()); }
                obj.response = ResourceResponse.ExceptionMessage;
                obj.isStatus = false;
            }

            return obj;
        }
        public CommonResponse OEEReportShiftwise(OEEdetailsShiftwise data)
        {
            CommonResponse obj = new CommonResponse();

            try
            {
                string[] machinelistids;


                DateTime FromDate = DateTime.Now;
                try
                {
                    string[] dt = data.fromDate.Split('/');
                    string frDate = dt[2] + '-' + dt[1] + '-' + dt[0];
                    FromDate = Convert.ToDateTime(frDate);
                }
                catch
                {
                    FromDate = Convert.ToDateTime(data.fromDate);
                }
                DateTime ToDate = DateTime.Now;
                try
                {
                    string[] dt = data.toDate.Split('/');
                    string torDate = dt[2] + '-' + dt[1] + '-' + dt[0];
                    ToDate = Convert.ToDateTime(torDate);
                }
                catch
                {
                    ToDate = Convert.ToDateTime(data.toDate).AddHours(24);
                }


                // var shiftdet = db.UnitworkccsTblshiftMstr.Where(m => m.ShiftName == data.shift).FirstOrDefault();

                //string startime = Convert.ToString(shiftdet.StartTime);
                //string endtime = Convert.ToString(shiftdet.EndTime);


                int dateDifference = Convert.ToDateTime(ToDate).Subtract(Convert.ToDateTime(FromDate)).Days;


                var getMachineList = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0).ToList();



                //if (data.machineIds != null)
                //{

                //    machinelistids = data.machineIds.Split(',');

                //}



                if (!string.IsNullOrEmpty(data.machineIds))
                {

                    machinelistids = data.machineIds.Split(',');

                }
                else
                {
                    if (data.plantId != 0 && data.category == "all machines")
                    {
                        getMachineList = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0 && m.PlantId == data.plantId).ToList();
                    }


                    else if (data.category != null)
                    {
                        getMachineList = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0 && m.PlantId == data.plantId && m.Category == data.category).ToList();
                    }



                    var machineidss = getMachineList.Select(m => m.MachineId).ToList();
                    int[] machineidsss = machineidss.ToArray();
                    machinelistids = Array.ConvertAll(machineidsss, ele => ele.ToString());



                }



                //string ids= string.Join(",", strArray);

                // int[] intarray = machineidsss;
                //   string[] result = intarray.Select(x => x.ToString()).ToArray();






                OEEReportCalculations OEC = new OEEReportCalculations();
                double AvailabilityPercentage = 0;
                double PerformancePercentage = 0;
                double QualityPercentage = 0;
                double OEEPercentage = 0;
                // OEC.GETCYCLETIMEAnalysis(MachineID, FromDate);




                FileInfo templateFile = new FileInfo(@"C:\SRKS_ifacility\MainTemplate\OEE_ShiftWiseReport.xlsx");

                ExcelPackage templatep = new ExcelPackage(templateFile);
                ExcelWorksheet Templatews = templatep.Workbook.Worksheets[0];
                //  ExcelWorksheet TemplateGraph = templatep.Workbook.Worksheets[1];


                //excel file save and  downloaded link



                string ImageUrlSave = configuration.GetSection("AppSettings").GetSection("ImageUrlSave").Value;
                string ImageUrl = configuration.GetSection("AppSettings").GetSection("ImageUrl").Value;

                String FileDir = ImageUrlSave + "\\" + "OEE_shift_Report_" + Convert.ToDateTime(ToDate).ToString("yyyy-MM-dd") + ".xlsx";
                String retrivalPath = ImageUrl + "OEE_shift_Report_" + Convert.ToDateTime(ToDate).ToString("yyyy-MM-dd") + ".xlsx";

                //bool exists = System.IO.Directory.Exists(FileDir);
                //if (!exists)
                //    System.IO.Directory.CreateDirectory(FileDir);

                FileInfo newFile = new FileInfo(FileDir);

                if (newFile.Exists)
                {
                    try
                    {
                        newFile.Delete();  // ensures we create a new workbook
                        newFile = new FileInfo(FileDir);
                    }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
                    catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
                    {
                        //ErrorLog.SendErrorToDB(ex);
                        obj.response = ResourceResponse.ExceptionMessage; ;
                    }
                }



                //




                //String FileDir = @"C:\SRKS_ifacility\OeeShiftReportsList\" + Convert.ToDateTime(ToDate).ToString("yyyy-MM-dd");
                //bool exists = System.IO.Directory.Exists(FileDir);
                //if (!exists)
                //    System.IO.Directory.CreateDirectory(FileDir);

                //FileInfo newFile = new FileInfo(System.IO.Path.Combine(FileDir, "OEE_ShiftReport" + Convert.ToDateTime(ToDate).ToString("yyyy-MM-dd") + ".xlsx")); //+ " to " + toda.ToString("yyyy-MM-dd") 
                //if (newFile.Exists)
                //{
                //    try
                //    {
                //        newFile.Delete();  // ensures we create a new workbook
                //        newFile = new FileInfo(System.IO.Path.Combine(FileDir, "OEE_ShiftReport" + Convert.ToDateTime(ToDate).ToString("yyyy-MM-dd") + ".xlsx"));
                //    }
                //    catch
                //    {
                //        obj.response = "Excel with same date is already open, please close it and try to generate!!!!";
                //        //return View();
                //    }
                //}

                //Using the File for generation and populating it
                ExcelPackage p = null;
                p = new ExcelPackage(newFile);
                ExcelWorksheet worksheet = null;
                //  ExcelWorksheet worksheetGraph = null;

                //Creating the WorkSheet for populating
                try
                {
                    worksheet = p.Workbook.Worksheets.Add(Convert.ToDateTime(ToDate).ToString("dd-MM-yyyy"), Templatews);
                    //  worksheetGraph = p.Workbook.Worksheets.Add("Graphs", TemplateGraph);
                }
                catch { }

                if (worksheet == null)
                {
                    worksheet = p.Workbook.Worksheets.Add(Convert.ToDateTime(ToDate).ToString("dd-MM-yyyy") + "1", Templatews);
                    //  worksheetGraph = p.Workbook.Worksheets.Add(System.DateTime.Now.ToString("dd-MM-yyyy") + "Graph", TemplateGraph);
                }

                //else if (worksheetGraph == null)
                //{
                //    worksheetGraph = p.Workbook.Worksheets.Add(System.DateTime.Now.ToString("dd-MM-yyyy") + "Graph", TemplateGraph);
                //}

                int sheetcount = p.Workbook.Worksheets.Count;
                p.Workbook.Worksheets.MoveToStart(sheetcount - 1);
                worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Cells.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                int StartRow = 2;
                //int SlNo = 1;

                // int MachineCount = getMachineList.Count;

                //  string[] machines1 = data.machineIds.Split(',');

                int MachineCount = machinelistids.Count();

                int Startcolumn = 11;
                String ColNam = ExcelColumnFromNumber(Startcolumn);
                var GetMainLossList = db.UnitworkccsTbllossescodes.Where(m => m.LossCodesLevel == 1 && m.IsDeleted == 0 && m.MessageType != "SETUP").OrderBy(m => m.LossCodeId).ToList();

                foreach (var LossRow in GetMainLossList)
                {
                    ColNam = ExcelColumnFromNumber(Startcolumn);
                    worksheet.Cells[ColNam + "1"].Value = LossRow.LossCodeDesc;
                    Startcolumn++;
                }

                //Tabular sheet Data Population
                for (int i = 0; i <= dateDifference; i++)
                {
                    //string[] machines = data.machineIds.Split(',');

                    string[] machines = machinelistids;
                    DateTime QueryDate = Convert.ToDateTime(FromDate).AddDays(i);
                    string CorrectedDate = QueryDate.ToString("yyyy-MM-dd");
                    //  for (i = 0; i < getMachineList.Count(); i++)


                    string[] shiftsplite = data.shift.Split(',');
                    List<string> slist = new List<string>();
                    slist = shiftsplite.ToList();
                    foreach (var sh in slist)
                    {

                        for (int j = 0; j < machines.Count(); j++)
                        {

                            int machineid = Convert.ToInt32(machines[j]);


                            //insert the oee data in shift wise

                            OEC.OEEshift(machineid, CorrectedDate, sh);


                            var GetUtilList = db.UnitworkccsTblOeeshiftdetails.Where(m => m.MachineId == machineid && m.CorrectedDate == CorrectedDate && m.Shift == sh).ToList();

                            if (GetUtilList.Count > 0)
                            {
                                foreach (var MacRow in GetUtilList)
                                {
                                    var machineName = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == machineid).Select(m => m.MachineName).FirstOrDefault();
                                    //var partdet = db.tblparts.Where(m => m.MachineID == MacRow.MachineID).FirstOrDefault();
                                    worksheet.Cells["A" + StartRow].Value = machineName;
                                    worksheet.Cells["B" + StartRow].Value = MacRow.OpNo;
                                    worksheet.Cells["C" + StartRow].Value = MacRow.FgPartNo;
                                    worksheet.Cells["D" + StartRow].Value = sh;
                                    worksheet.Cells["E" + StartRow].Value = CorrectedDate;
                                    worksheet.Cells["F" + StartRow].Value = MacRow.OperatingTimeinMin;
                                    worksheet.Cells["G" + StartRow].Value = MacRow.OkQty;
                                    worksheet.Cells["H" + StartRow].Value = MacRow.RejectionQty;
                                    worksheet.Cells["I" + StartRow].Value = MacRow.OkQty + MacRow.RejectionQty + MacRow.ReworkQty + MacRow.DryRunQty + MacRow.TrialPartCount;
                                    worksheet.Cells["J" + StartRow].Value = MacRow.DryRunQty;
                                    worksheet.Cells["K" + StartRow].Value = MacRow.ReworkQty;
                                    worksheet.Cells["L" + StartRow].Value = MacRow.TrialPartCount;
                                    worksheet.Cells["M" + StartRow].Value = MacRow.TotalIdletimeinMin;
                                    worksheet.Cells["N" + StartRow].Value = MacRow.BdTime;
                                    worksheet.Cells["O" + StartRow].Value = MacRow.PowerOffTimeInMinutes;
                                    worksheet.Cells["P" + StartRow].Value = 0;
                                    worksheet.Cells["Q" + StartRow].Value = MacRow.MinorLossTime;
                                    worksheet.Cells["R" + StartRow].Value = MacRow.TotalTimeInMinutes;
                                    worksheet.Cells["S" + StartRow].Value = MacRow.Availability;
                                    worksheet.Cells["T" + StartRow].Value = MacRow.Quality;
                                    worksheet.Cells["U" + StartRow].Value = MacRow.Performance;
                                    worksheet.Cells["V" + StartRow].Value = MacRow.Oee;

                                    StartRow++;
                                }
                            }


                        }

                    }


                    //for (int j = 0; j < machines.Count(); j++)
                    //{



                    //    int machineid = Convert.ToInt32(machines[j]);




                    //    //insert the oee data in shift wise




                    //   OEC.OEEshift(machineid, CorrectedDate, data.shift);

                    //    int MacStartcolumn = 11;




                    //    var GetUtilList = db.UnitworkccsTblOeeshiftdetails.Where(m => m.MachineId == machineid && m.CorrectedDate == CorrectedDate && m.Shift == data.shift).ToList();

                    //    if (GetUtilList.Count > 0)
                    //    {
                    //        foreach (var MacRow in GetUtilList)
                    //        {
                    //            var machineName = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == machineid).Select(m => m.MachineName).FirstOrDefault();
                    //            //var partdet = db.tblparts.Where(m => m.MachineID == MacRow.MachineID).FirstOrDefault();
                    //            worksheet.Cells["A" + StartRow].Value = machineName;
                    //            worksheet.Cells["B" + StartRow].Value = MacRow.OpNo;
                    //            worksheet.Cells["C" + StartRow].Value = MacRow.FgPartNo;
                    //            worksheet.Cells["D" + StartRow].Value = data.shift;
                    //            worksheet.Cells["E" + StartRow].Value = CorrectedDate;
                    //            worksheet.Cells["F" + StartRow].Value = MacRow.OperatingTimeinMin;
                    //            worksheet.Cells["G" + StartRow].Value = MacRow.OkQty;
                    //            worksheet.Cells["H" + StartRow].Value = MacRow.RejectionQty;
                    //            worksheet.Cells["I" + StartRow].Value = MacRow.OkQty + MacRow.RejectionQty + MacRow.ReworkQty + MacRow.DryRunQty + MacRow.TrialPartCount;
                    //            worksheet.Cells["J" + StartRow].Value = MacRow.DryRunQty;
                    //            worksheet.Cells["K" + StartRow].Value = MacRow.ReworkQty;
                    //            worksheet.Cells["L" + StartRow].Value = MacRow.TrialPartCount;
                    //            worksheet.Cells["M" + StartRow].Value = MacRow.TotalIdletimeinMin;
                    //            worksheet.Cells["N" + StartRow].Value = MacRow.BdTime;
                    //            worksheet.Cells["O" + StartRow].Value = MacRow.PowerOffTimeInMinutes;
                    //            worksheet.Cells["P" + StartRow].Value = 0;
                    //            worksheet.Cells["Q" + StartRow].Value = MacRow.MinorLossTime;
                    //            worksheet.Cells["R" + StartRow].Value = MacRow.TotalTimeInMinutes;
                    //            worksheet.Cells["S" + StartRow].Value = MacRow.Availability;
                    //            worksheet.Cells["T" + StartRow].Value = MacRow.Quality;
                    //            worksheet.Cells["U" + StartRow].Value = MacRow.Performance;
                    //            worksheet.Cells["V" + StartRow].Value = MacRow.Oee;

                    //            StartRow++;
                    //        }
                    //    }


                    //}
                }

                //   DataTable LossTbl = new DataTable();
                //   LossTbl.Columns.Add("LossID", typeof(int));
                //   LossTbl.Columns.Add("LossDuration", typeof(int));
                //   LossTbl.Columns.Add("LossTarget", typeof(string));
                //   LossTbl.Columns.Add("LossName", typeof(string));
                //   LossTbl.Columns.Add("LossActual", typeof(string));

                //   //Graph Sheet Population
                //   //Start Date and End Date
                ////   worksheetGraph.Cells["C6"].Value = Convert.ToDateTime(FromDate).ToString("dd-MM-yyyy");
                // //  worksheetGraph.Cells["E6"].Value = Convert.ToDateTime(ToDate).ToString("dd-MM-yyyy");
                //   int GetHolidays = getsundays(Convert.ToDateTime(ToDate), Convert.ToDateTime(FromDate));
                //   int WorkingDays = (dateDifference - GetHolidays) + 1;
                //   //Working Days
                // //  worksheetGraph.Cells["E5"].Value = WorkingDays;
                //   //Planned Production Time
                // //  worksheetGraph.Cells["E10"].Value = WorkingDays * 24;
                //   double TotalOperatingTime = 0;
                //   double TotalDownTime = 0;
                //   double TotalAcceptedQty = 0;
                //   double TotalRejectedQty = 0;
                //   double TotalPerformanceFactor = 0;

                //   double TotalAvailability = 0;
                //   double TotalPerformance = 0;
                //   double TotalQuality = 0;
                //   double TotalOee = 0;



                //   int StartGrpah1 = 48;



                //   if (data.machineIds == null)
                //   {
                //       worksheetGraph.Cells["C4"].Value = data.category;
                //       worksheetGraph.Cells["C5"].Value = machinelistids.Count().ToString();
                //   }
                //   else
                //   {
                //       worksheetGraph.Cells["C4"].Value = data.category;
                //       worksheetGraph.Cells["C5"].Value = machinelistids.Count().ToString();
                //   }




                //   for (int i = 0; i <= dateDifference; i++)
                //   {
                //       double DayOperatingTime = 0;
                //       double DayDownTime = 0;
                //       double DayAcceptedQty = 0;
                //       double DayRejectedQty = 0;
                //       double DayPerformanceFactor = 0;
                //       DateTime QueryDate = Convert.ToDateTime(FromDate).AddDays(i);
                //       string CorrectedDate = QueryDate.ToString("yyyy-MM-dd");
                //       var plantName = db.UnitworkccsTblplant.Where(m => m.PlantId == data.plantId).Select(m => m.PlantName).FirstOrDefault();
                //       worksheetGraph.Cells["C3"].Value = plantName;

                //       string[] machines = machinelistids;

                //       // for (i = 0; i < getMachineList.Count(); i++)
                //       for (int j = 0; j < machines.Count(); j++)
                //       {

                //           var machineid = Convert.ToInt32(machines[j]);

                //           var GetUtilList = db.UnitworkccsTblOeedetails.Where(m => m.MachineId == machineid && m.CorrectedDate == CorrectedDate).ToList();

                //           if (GetUtilList.Count > 0)
                //           {



                //               foreach (var ProdRow in GetUtilList)
                //               {
                //                   //Total Values
                //                   TotalOperatingTime += (double)ProdRow.OperatingTimeinMin;
                //                   TotalDownTime += (double)ProdRow.TotalIdletimeinMin;
                //                   TotalAcceptedQty += Convert.ToInt32(ProdRow.OkQty);
                //                   TotalRejectedQty += Convert.ToInt32(ProdRow.RejectionQty);
                //                   // TotalRejectedQty += ProdRow.tblworkorderentry.ScrapQty;
                //                   TotalPerformanceFactor += (double)ProdRow.PerformanceFactor;
                //                   //Day Values
                //                   DayOperatingTime += (double)ProdRow.OperatingTimeinMin;
                //                   DayDownTime += (double)ProdRow.BdTime;
                //                   DayAcceptedQty += Convert.ToInt32(ProdRow.OkQty);
                //                   // DayRejectedQty += ProdRow.tblworkorderentry.ScrapQty;
                //                   DayRejectedQty += (double)ProdRow.RejectionQty;
                //                   DayPerformanceFactor += (double)ProdRow.PerformanceFactor;


                //                   TotalAvailability += (double)ProdRow.Availability;
                //                   TotalPerformance += (double)ProdRow.Performance;
                //                   TotalQuality += (double)ProdRow.Quality;
                //                   TotalOee += (double)ProdRow.Oee;


                //               }

                //           }


                //       }
                //       int TotQty = (int)(DayAcceptedQty + DayRejectedQty);
                //       if (TotQty == 0)
                //           TotQty = 1;

                //       double DayOpTime = DayOperatingTime;
                //       if (DayOpTime == 0)
                //           DayOpTime = 1;

                //       decimal DayAvailPercent = (decimal)Math.Round(DayOperatingTime / (24 * WorkingDays), 2);
                //       decimal DayPerformancePercent = (decimal)Math.Round(DayPerformanceFactor / DayOpTime, 2);
                //       decimal DayQualityPercent = (decimal)Math.Round((DayAcceptedQty / (TotQty)), 2);
                //       decimal DayOEEPercent = (decimal)Math.Round((double)(DayAvailPercent) * (double)(DayPerformancePercent) * (double)(DayQualityPercent), 2);

                //       worksheetGraph.Cells["B" + StartGrpah1].Value = QueryDate.ToString("dd-MM-yyyy");
                //       worksheetGraph.Cells["C" + StartGrpah1].Value = 0.85;
                //       worksheetGraph.Cells["D" + StartGrpah1].Value = DayOEEPercent;

                //       StartGrpah1++;
                //   }


                //   worksheetGraph.Cells["E11"].Value = (double)Math.Round(TotalOperatingTime / 60, 2);
                //   worksheetGraph.Cells["E12"].Value = (double)Math.Round(TotalDownTime / 60, 2);
                //   worksheetGraph.Cells["E13"].Value = TotalAcceptedQty;
                //   worksheetGraph.Cells["E14"].Value = TotalRejectedQty;


                //   int count = machinelistids.Count();

                //   worksheetGraph.Cells["E20"].Value = (double)Math.Round((TotalAvailability / count) / 100, 2);
                //   worksheetGraph.Cells["E21"].Value = (double)Math.Round((TotalPerformance / count) / 100, 2);
                //   worksheetGraph.Cells["E22"].Value = (double)Math.Round((TotalQuality / count) / 100, 2);
                //   worksheetGraph.Cells["E23"].Value = (double)Math.Round((TotalOee / count) / 100, 2);
                //   worksheetGraph.Cells["G5"].Value = (double)Math.Round((TotalOee / count) / 100, 2);



                //if (TotalOperatingTime == 0)
                //    TotalOperatingTime = 1;
                //if (TotalAcceptedQty == 0)
                //    TotalAcceptedQty = 1;
                //decimal TotalAvailPercent = (decimal)Math.Round(TotalOperatingTime / (WorkingDays * 24 * 60 * MachineCount), 2);
                //decimal TotalPerformancePercent = (decimal)Math.Round(TotalPerformanceFactor / TotalOperatingTime, 2);
                //decimal TotalQualityPercent = (decimal)Math.Round((TotalAcceptedQty / (TotalAcceptedQty + TotalRejectedQty)), 2);
                //decimal TotalOEEPercent = (decimal)Math.Round((double)(TotalAvailPercent) * (double)(TotalPerformancePercent) * (double)(TotalQualityPercent), 2);

                //if (TotalPerformancePercent > 100)
                //    TotalPerformancePercent = 100;

                //worksheetGraph.View.ShowGridLines = false;

                //DateTime fromDate = Convert.ToDateTime(FromDate);
                //DateTime toDate = Convert.ToDateTime(ToDate);
                //var top3ContrubutingFactors = (from dbItem in db.TblProdOrderLosses
                //                               where dbItem.CorrectedDate >= fromDate.Date && dbItem.CorrectedDate <= toDate.Date
                //                               group dbItem by dbItem.LossId into x
                //                               select new
                //                               {
                //                                   LossId = x.Key,
                //                                   LossDuration = db.TblProdOrderLosses.Where(m => m.LossId == x.Key).Select(m => m.LossDuration).Sum()
                //                               }).ToList();
                //var item = top3ContrubutingFactors.OrderByDescending(m => m.LossDuration).Take(3).ToList();
                //int lossXccelNo = 29;
                //decimal lossPercentage = 0;
                //foreach (var GetRow in item)
                //{
                //    string lossCode = db.UnitworkccsTbllossescodes.Where(m => m.LossCodeId == GetRow.LossId).Select(m => m.LossCodeDesc).FirstOrDefault();
                //    if (TotalDownTime != 0)
                //        lossPercentage = (decimal)Math.Round(((GetRow.LossDuration) / TotalDownTime), 2);
                //    decimal lossDurationInHours = (decimal)Math.Round((GetRow.LossDuration / 60.00), 2);
                //    worksheetGraph.Cells["L" + lossXccelNo].Value = lossCode;
                //    worksheetGraph.Cells["N" + lossXccelNo].Value = lossPercentage;
                //    worksheetGraph.Cells["O" + lossXccelNo].Value = lossDurationInHours;
                //    lossXccelNo++;
                //}

                //int grphData = 5;
                //decimal CumulativePercentage = 0;
                //foreach (var data1 in top3ContrubutingFactors)
                //{
                //    var dbLoss = db.UnitworkccsTbllossescodes.Where(m => m.LossCodeId == data1.LossId).FirstOrDefault();
                //    string lossCode = dbLoss.LossCodeDesc;
                //    decimal Target = dbLoss.TargetPercent;
                //    decimal actualPercentage = (decimal)Math.Round(((data1.LossDuration) / TotalDownTime), 2);
                //    CumulativePercentage = CumulativePercentage + actualPercentage;
                //    worksheetGraph.Cells["K" + grphData].Value = lossCode;
                //    worksheetGraph.Cells["L" + grphData].Value = Target;
                //    worksheetGraph.Cells["M" + grphData].Value = actualPercentage;
                //    worksheetGraph.Cells["N" + grphData].Value = CumulativePercentage;
                //    grphData++;

                //}


                p.Save();

                //Downloding Excel
                string path1 = System.IO.Path.Combine(FileDir, "OEE_Report" + Convert.ToDateTime(ToDate).ToString("yyyy-MM-dd") + ".xlsx");


                //  DownloadUtilReport(path1, "OEE_Report", ToDate.ToString());


                obj.isStatus = true;
                //obj.response = path1;
                obj.response = retrivalPath;


            }
            catch (Exception ex)
            {
                log.Error(ex); if (ex.InnerException != null) { log.Error(ex.InnerException.ToString()); }
                obj.response = ResourceResponse.ExceptionMessage;
                obj.isStatus = false;
            }

            return obj;
        }
        public CommonResponse ViewMultiEmployees()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTbloperatordetails
                             where wf.IsDeleted == 0
                             select new
                             {
                                 operatorId = wf.OpId,
                                 ooperatorName = wf.OperatorName + "-" + wf.OpNo
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
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }
        // CommonResponse ViewMultiEmployeesMachines(int empId);
        public CommonResponse ViewMultiEmployeesMachines(string empId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                string[] empids = empId.Split(',');
                List<machinelist> machinelist1 = new List<machinelist>();
                foreach (var emp in empids)

                {



                    // var check = db.UnitworkccsTbloperatordetails.Where(m => m.OpId ==Convert.ToInt32( emp)).FirstOrDefault();

                    var check = db.UnitworkccsTblfgpartnodet.Where(m => m.OperatorId == Convert.ToInt32(emp)).Select(m=>m.MachineId).Distinct().ToList();
                  
                    //  if (check.MachineIds!=null)
                  


                    if (check.Count>0 )
                            
                    {

                      //  string[] machineIds = check.MachineIds.Split(',');

                        for (int i = 0; i < check.Count(); i++)
                        {
                            int mid = Convert.ToInt32(check[i]);
                            machinelist machines = new machinelist();
                            var machine1 = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == mid).FirstOrDefault();
                            machines.machineId = machine1.MachineId;
                            machines.machineName = machine1.MachineName;
                            machinelist1.Add(machines);
                        }



                    }





                }
                


                if (machinelist1.Count>0)
                {
                    obj.isStatus = true;
                    obj.response = machinelist1;
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
        public CommonResponse OEEReportOperator(OEEdetailsOperator data)
        {
            CommonResponse obj = new CommonResponse();

            try
            {
                string[] machinelistids;


                DateTime FromDate = DateTime.Now;
                try
                {
                    string[] dt = data.fromDate.Split('/');
                    string frDate = dt[2] + '-' + dt[1] + '-' + dt[0];
                    FromDate = Convert.ToDateTime(frDate);
                }
                catch
                {
                    FromDate = Convert.ToDateTime(data.fromDate);
                }
                DateTime ToDate = DateTime.Now;
                try
                {
                    string[] dt = data.toDate.Split('/');
                    string torDate = dt[2] + '-' + dt[1] + '-' + dt[0];
                    ToDate = Convert.ToDateTime(torDate);
                }
                catch
                {
                    ToDate = Convert.ToDateTime(data.toDate).AddHours(24);
                }


                string[] opids = data.operatorId.Split(',');

                //  var operatorDet = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == data.operatorId).FirstOrDefault();


                int dateDifference = Convert.ToDateTime(ToDate).Subtract(Convert.ToDateTime(FromDate)).Days;


                var getMachineList = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0).ToList();



                //if (data.machineIds != null)
                //{

                //    machinelistids = data.machineIds.Split(',');

                //}

                if (!string.IsNullOrEmpty(data.machineIds))
                {

                    machinelistids = data.machineIds.Split(',');

                }
                else
                {

                    string[] empids = data.operatorId.Split(',');
                    List<int> machinelist1 = new List<int>();
                    foreach (var emp in empids)

                    {



                        // var check = db.UnitworkccsTbloperatordetails.Where(m => m.OpId ==Convert.ToInt32( emp)).FirstOrDefault();

                        var check = db.UnitworkccsTblfgpartnodet.Where(m => m.OperatorId == Convert.ToInt32(emp)).Select(m => m.MachineId).Distinct().ToList();

                        //  if (check.MachineIds!=null)



                        if (check.Count > 0)

                        {

                            //  string[] machineIds = check.MachineIds.Split(',');

                            for (int i = 0; i < check.Count(); i++)
                            {
                                int mid = Convert.ToInt32(check[i]);
                                int machines = 0;
                                var machine1 = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == mid).FirstOrDefault();
                                machines = machine1.MachineId;

                                machinelist1.Add(machines);
                            }



                        }





                    }

                    string[] machinelistemp;


                    int[] machineidsss1 = machinelist1.Distinct().ToArray();
                    machinelistemp = Array.ConvertAll(machineidsss1, ele => ele.ToString());
                    machinelistids = machinelistemp;

                    // getMachineList = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0 && m.PlantId == data.plantId).ToList();


                    //  var machineidss = getMachineList.Select(m => m.MachineId).ToList();
                    // int[] machineidsss = machineidss.ToArray();
                    // machinelistids = Array.ConvertAll(machineidsss, ele => ele.ToString());

                }


                //  machinelistids = machinelistids.Distinct();
                // var machinelistss= machinelistids.ToList().Distinct();
                //  string[] listofidsMac=
                OEEReportCalculations OEC = new OEEReportCalculations();
                double AvailabilityPercentage = 0;
                double PerformancePercentage = 0;
                double QualityPercentage = 0;
                double OEEPercentage = 0;
                // OEC.GETCYCLETIMEAnalysis(MachineID, FromDate);




                FileInfo templateFile = new FileInfo(@"C:\SRKS_ifacility\MainTemplate\OEE_OperatorReport.xlsx");

                ExcelPackage templatep = new ExcelPackage(templateFile);
                ExcelWorksheet Templatews = templatep.Workbook.Worksheets[0];
                //  ExcelWorksheet TemplateGraph = templatep.Workbook.Worksheets[1];


                //excel file save and  downloaded link



                string ImageUrlSave = configuration.GetSection("AppSettings").GetSection("ImageUrlSave").Value;
                string ImageUrl = configuration.GetSection("AppSettings").GetSection("ImageUrl").Value;

                String FileDir = ImageUrlSave + "\\" + "OEE_Operator_Report_" + Convert.ToDateTime(ToDate).ToString("yyyy-MM-dd") + ".xlsx";
                String retrivalPath = ImageUrl + "OEE_Operator_Report_" + Convert.ToDateTime(ToDate).ToString("yyyy-MM-dd") + ".xlsx";

                //bool exists = System.IO.Directory.Exists(FileDir);
                //if (!exists)
                //    System.IO.Directory.CreateDirectory(FileDir);

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



                //




                ExcelPackage p = null;
                p = new ExcelPackage(newFile);
                ExcelWorksheet worksheet = null;
                //  ExcelWorksheet worksheetGraph = null;

                //Creating the WorkSheet for populating
                try
                {
                    worksheet = p.Workbook.Worksheets.Add(Convert.ToDateTime(ToDate).ToString("dd-MM-yyyy"), Templatews);
                    //  worksheetGraph = p.Workbook.Worksheets.Add("Graphs", TemplateGraph);
                }
                catch { }

                if (worksheet == null)
                {
                    worksheet = p.Workbook.Worksheets.Add(Convert.ToDateTime(ToDate).ToString("dd-MM-yyyy") + "1", Templatews);
                    //  worksheetGraph = p.Workbook.Worksheets.Add(System.DateTime.Now.ToString("dd-MM-yyyy") + "Graph", TemplateGraph);
                }

                //else if (worksheetGraph == null)
                //{
                //    worksheetGraph = p.Workbook.Worksheets.Add(System.DateTime.Now.ToString("dd-MM-yyyy") + "Graph", TemplateGraph);
                //}

                int sheetcount = p.Workbook.Worksheets.Count;
                p.Workbook.Worksheets.MoveToStart(sheetcount - 1);
                worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Cells.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                int StartRow = 2;
                //int SlNo = 1;

                // int MachineCount = getMachineList.Count;

                //  string[] machines1 = data.machineIds.Split(',');

                int MachineCount = machinelistids.Count();

                int Startcolumn = 11;
                String ColNam = ExcelColumnFromNumber(Startcolumn);
                var GetMainLossList = db.UnitworkccsTbllossescodes.Where(m => m.LossCodesLevel == 1 && m.IsDeleted == 0 && m.MessageType != "SETUP").OrderBy(m => m.LossCodeId).ToList();

                foreach (var LossRow in GetMainLossList)
                {
                    ColNam = ExcelColumnFromNumber(Startcolumn);
                    worksheet.Cells[ColNam + "1"].Value = LossRow.LossCodeDesc;
                    Startcolumn++;
                }

                //Tabular sheet Data Population
                for (int i = 0; i <= dateDifference; i++)
                {
                    //string[] machines = data.machineIds.Split(',');


                    DateTime QueryDate = Convert.ToDateTime(FromDate).AddDays(i);
                    string CorrectedDate = QueryDate.ToString("yyyy-MM-dd");
                    //  for (i = 0; i < getMachineList.Count(); i++)




                    for (int k = 0; k < opids.Count(); k++)

                    {


                        //  if (opids.Count() != 0)
                        // {
                        string[] machines = machinelistids;

                        //   var check = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == Convert.ToInt32(opids[k])).FirstOrDefault();


                        //  string[] machines = check.MachineIds.Split(',');




                        for (int j = 0; j < machines.Count(); j++)
                        {


                            int machineid = Convert.ToInt32(machines[j]);

                            int opid = Convert.ToInt32(opids[k]);

                            //insert the oee data in shift wise

                            var opcontain = db.UnitworkccsTblfgpartnodet.Where(m => m.OperatorId == opid).Select(m => m.MachineId).Distinct().ToList();
                            if (opcontain.Contains(machineid))
                            {
                                var opcontainShift = db.UnitworkccsTblfgpartnodet.Where(m => m.OperatorId == opid && m.CorrectedDate == CorrectedDate && m.MachineId == machineid).Select(m => m.Shift).Distinct().ToList();

                                foreach (var item1shift in opcontainShift)
                                {
                                    // var GetUtilList1 = db.UnitworkccsTblOeeoperatordetails.Where(m => m.MachineId == machineid && m.CorrectedDate == CorrectedDate && m.OperatorId == Convert.ToString(opid) && m.Shift == item1shift).Distinct().ToList();

                                    OEC.OEEoperator(machineid, CorrectedDate, opid, item1shift);


                                    var GetUtilList = db.UnitworkccsTblOeeoperatordetails.Where(m => m.MachineId == machineid && m.CorrectedDate == CorrectedDate && m.OperatorId == Convert.ToString(opid) && m.Shift == item1shift).Distinct().ToList();

                                    // if (GetUtilList.Count > 0)
                                    if (GetUtilList.Count > 0)
                                    {
                                        foreach (var MacRow in GetUtilList)
                                        {

                                            var machineName = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == machineid).Select(m => m.MachineName).FirstOrDefault();


                                            var operatorName = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == opid).Select(m => m.OperatorName).FirstOrDefault();



                                            int OperId = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == opid).Select(m => m.OpId).FirstOrDefault();
                                            string name = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == opid).Select(m => m.OperatorName).FirstOrDefault();
                                            // var opDet = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == opid).Select(m => new {m.OpNo,m.OperatorName }).FirstOrDefault();

                                            string namee;

                                            if (name == null)
                                            {
                                                namee = Convert.ToString(opid);
                                            }
                                            else
                                            {
                                                namee = name + "_" + OperId;
                                            }

                                            double duration = 0;
                                            var loginDuration = db.UnitworkccsLogintrackerdetails.Where(m => m.IsLoggedIn == 0 && m.MachineId == machineid && m.CorrectedDate == CorrectedDate && m.Shift == item1shift && m.OperatorId == opid).FirstOrDefault();
                                            if (loginDuration != null)
                                            {
                                                DateTime loginTime = Convert.ToDateTime(loginDuration.LoginDateTime);
                                                DateTime logoutTime = Convert.ToDateTime(loginDuration.LogoutDateTime);

                                                duration = (logoutTime - loginTime).TotalMinutes;
                                            }

                                            duration = Math.Round(duration, 2);


                                            double stdHours = 0;
                                            var cycletime = db.UnitworkccsTblfgpartnodet.Where(m => m.MachineId == machineid && m.CorrectedDate == CorrectedDate && m.OperatorId == opid && m.Shift == item1shift).Select(m => new { m.Unit, m.IdealCycleTime }).Distinct().FirstOrDefault();
                                            var cycleMin = cycletime.Unit == "Seconds" ? Math.Round((Convert.ToDecimal(cycletime.IdealCycleTime / 60)), 2) : Math.Round((Convert.ToDecimal(cycletime.IdealCycleTime)), 2);

                                            stdHours = (Convert.ToDouble(MacRow.OkQty + MacRow.RejectionQty + MacRow.ReworkQty)) * (Convert.ToDouble(cycleMin));

                                            worksheet.Cells["A" + StartRow].Value = machineName;
                                            worksheet.Cells["B" + StartRow].Value = MacRow.OpNo;
                                            worksheet.Cells["C" + StartRow].Value = MacRow.FgPartNo;
                                            worksheet.Cells["D" + StartRow].Value = operatorName;//opid 
                                            worksheet.Cells["E" + StartRow].Value = CorrectedDate;

                                            worksheet.Cells["F" + StartRow].Value = MacRow.Shift;

                                            worksheet.Cells["G" + StartRow].Value = MacRow.OperatingTimeinMin;
                                            worksheet.Cells["H" + StartRow].Value = MacRow.OkQty;
                                            worksheet.Cells["I" + StartRow].Value = MacRow.RejectionQty;
                                            worksheet.Cells["J" + StartRow].Value = MacRow.OkQty + MacRow.RejectionQty + MacRow.ReworkQty + MacRow.DryRunQty + MacRow.TrialPartCount;
                                            worksheet.Cells["K" + StartRow].Value = MacRow.DryRunQty;
                                            worksheet.Cells["L" + StartRow].Value = MacRow.ReworkQty;
                                            worksheet.Cells["M" + StartRow].Value = MacRow.TrialPartCount;
                                            worksheet.Cells["N" + StartRow].Value = MacRow.TotalIdletimeinMin;
                                            worksheet.Cells["O" + StartRow].Value = MacRow.BdTime;
                                            worksheet.Cells["P" + StartRow].Value = MacRow.PowerOffTimeInMinutes;
                                            worksheet.Cells["Q" + StartRow].Value = 0;
                                            worksheet.Cells["R" + StartRow].Value = MacRow.MinorLossTime;
                                            worksheet.Cells["S" + StartRow].Value = MacRow.TotalTimeInMinutes;
                                            worksheet.Cells["T" + StartRow].Value = MacRow.Availability;
                                            worksheet.Cells["U" + StartRow].Value = MacRow.Quality;
                                            worksheet.Cells["V" + StartRow].Value = MacRow.Performance;
                                            worksheet.Cells["W" + StartRow].Value = MacRow.Oee;

                                            worksheet.Cells["x" + StartRow].Value = duration;
                                            worksheet.Cells["Y" + StartRow].Value = stdHours;
                                            //  worksheet.Cells["X" + StartRow].Value = MacRow.Shift;
                                            StartRow++;
                                        }
                                    }





                                    //  OEC.OEEoperator(machineid, CorrectedDate, opid, opcontainShift);


                                }


                            }

                            // OEC.OEEoperator(machineid, CorrectedDate, opid);



                            //int MacStartcolumn = 11;



                        }



                        // }







                    }





                }


                p.Save();

                //Downloding Excel
                string path1 = System.IO.Path.Combine(FileDir, "OEE_Report" + Convert.ToDateTime(ToDate).ToString("yyyy-MM-dd") + ".xlsx");


                //  DownloadUtilReport(path1, "OEE_Report", ToDate.ToString());


                obj.isStatus = true;
                //obj.response = path1;
                obj.response = retrivalPath;


            }
            catch (Exception ex)
            {
                log.Error(ex); if (ex.InnerException != null) { log.Error(ex.InnerException.ToString()); }
                obj.response = ResourceResponse.ExceptionMessage;
                obj.isStatus = false;
            }

            return obj;
        }
        public static string ExcelColumnFromNumber(int column)
        {
            string columnString = "";
            decimal columnNumber = column;
            while (columnNumber > 0)
            {
                decimal currentLetterNumber = (columnNumber - 1) % 26;
                char currentLetter = (char)(currentLetterNumber + 65);
                columnString = currentLetter + columnString;
                columnNumber = (columnNumber - (currentLetterNumber + 1)) / 26;
            }
            return columnString;
        }
        public int getsundays(DateTime fdate, DateTime sdate)
        {
            //TimeSpan ts = fdate - sdate;
            //var sundays = ((ts.TotalDays / 7) + (sdate.DayOfWeek == DayOfWeek.Sunday || fdate.DayOfWeek == DayOfWeek.Sunday || fdate.DayOfWeek > sdate.DayOfWeek ? 1 : 0));

            //sundays = Math.Round(sundays - .5, MidpointRounding.AwayFromZero);

            //return (int)sundays;
            int sundayCount = 0;

            for (DateTime dt = sdate; dt < fdate; dt = dt.AddDays(1.0))
            {
                if (dt.DayOfWeek == DayOfWeek.Sunday)
                {
                    sundayCount++;
                }
            }

            return sundayCount;
        }
        public CommonResponse BreakdownReport(breakdownReportDet data)
        {
            CommonResponse obj = new CommonResponse();

            try
            {
                string[] machinelistids;


                DateTime FromDate = DateTime.Now;
                try
                {
                    string[] dt = data.fromDate.Split('/');
                    string frDate = dt[2] + '-' + dt[1] + '-' + dt[0];
                    FromDate = Convert.ToDateTime(frDate);
                }
                catch
                {
                    FromDate = Convert.ToDateTime(data.fromDate);
                }
                DateTime ToDate = DateTime.Now;
                try
                {
                    string[] dt = data.toDate.Split('/');
                    string torDate = dt[2] + '-' + dt[1] + '-' + dt[0];
                    ToDate = Convert.ToDateTime(torDate);
                }
                catch
                {
                    ToDate = Convert.ToDateTime(data.toDate).AddHours(24);
                }



                int dateDifference = Convert.ToDateTime(ToDate).Subtract(Convert.ToDateTime(FromDate)).Days;


                var getMachineList = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0).ToList();



                //if (data.machineIds != null)
                //{

                //    machinelistids = data.machineIds.Split(',');

                //}


                if (!string.IsNullOrEmpty(data.machineIds))
                {

                    machinelistids = data.machineIds.Split(',');

                }
                else
                {
                    if (data.plantId != 0 && data.category == "all machines")
                    {
                        getMachineList = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0 && m.PlantId == data.plantId).ToList();
                    }


                    else if (data.category != null)
                    {
                        getMachineList = db.UnitworkccsTblmachinedetails.Where(m => m.IsDeleted == 0 && m.PlantId == data.plantId && m.Category == data.category).ToList();
                    }



                    var machineidss = getMachineList.Select(m => m.MachineId).ToList();
                    int[] machineidsss = machineidss.ToArray();
                    machinelistids = Array.ConvertAll(machineidsss, ele => ele.ToString());



                }

                OEEReportCalculations OEC = new OEEReportCalculations();

                FileInfo templateFile = new FileInfo(@"C:\SRKS_ifacility\MainTemplate\Breakdown_Report.xlsx");

                ExcelPackage templatep = new ExcelPackage(templateFile);
                ExcelWorksheet Templatews = templatep.Workbook.Worksheets[0];
                ExcelWorksheet TemplateGraph = templatep.Workbook.Worksheets[1];


                //excel file save and  downloaded link



                string ImageUrlSave = configuration.GetSection("AppSettings").GetSection("ImageUrlSave").Value;
                string ImageUrl = configuration.GetSection("AppSettings").GetSection("ImageUrl").Value;

                String FileDir = ImageUrlSave + "\\" + "Breakdown_Report_" + Convert.ToDateTime(ToDate).ToString("yyyy-MM-dd") + ".xlsx";
                String retrivalPath = ImageUrl + "Breakdown_Report_" + Convert.ToDateTime(ToDate).ToString("yyyy-MM-dd") + ".xlsx";


                FileInfo newFile = new FileInfo(FileDir);

                if (newFile.Exists)
                {
                    try
                    {
                        newFile.Delete();
                        newFile = new FileInfo(FileDir);
                    }

                    catch (Exception ex)

                    {
                        obj.response = ResourceResponse.ExceptionMessage; ;
                    }
                }


                //Using the File for generation and populating it
                ExcelPackage p = null;
                p = new ExcelPackage(newFile);
                ExcelWorksheet worksheet = null;
                ExcelWorksheet worksheetGraph = null;


                try
                {
                    worksheet = p.Workbook.Worksheets.Add(Convert.ToDateTime(ToDate).ToString("dd-MM-yyyy"), Templatews);
                    worksheetGraph = p.Workbook.Worksheets.Add("Break down analyis", TemplateGraph);
                }
                catch { }

                if (worksheet == null)
                {
                    worksheet = p.Workbook.Worksheets.Add(Convert.ToDateTime(ToDate).ToString("dd-MM-yyyy") + "1", Templatews);
                    worksheetGraph = p.Workbook.Worksheets.Add(System.DateTime.Now.ToString("dd-MM-yyyy") + "Break down analyis", TemplateGraph);
                }
                else if (worksheetGraph == null)
                {
                    worksheetGraph = p.Workbook.Worksheets.Add(System.DateTime.Now.ToString("dd-MM-yyyy") + "Break down analyis", TemplateGraph);
                }
                int sheetcount = p.Workbook.Worksheets.Count;
                p.Workbook.Worksheets.MoveToStart(sheetcount - 1);
                worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Cells.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;

                int StartRow = 4;

                int MachineCount = machinelistids.Count();

                int Startcolumn = 11;
                String ColNam = ExcelColumnFromNumber(Startcolumn);




                int slNo = 1;

                for (int i = 0; i <= dateDifference; i++)
                {

                    string[] machines = machinelistids;
                    DateTime QueryDate = Convert.ToDateTime(FromDate).AddDays(i);
                    string CorrectedDate = QueryDate.ToString("yyyy-MM-dd");


                    for (int j = 0; j < machines.Count(); j++)
                    {

                        int machineid = Convert.ToInt32(machines[j]);

                        OEC.BreakdownReport(machineid, CorrectedDate);



                        var GetUtilList = db.UnitworkccsTblbreakdownReportdetails.Where(m => m.MachineId == machineid && m.CorrectedDate == CorrectedDate).ToList();

                        if (GetUtilList.Count > 0)
                        {



                            foreach (var MacRow in GetUtilList)
                            {
                                var machineName = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == machineid).Select(m => m.MachineName).FirstOrDefault();
                                var plant = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == machineid).Select(m => m.PlantId).FirstOrDefault();
                                var cell = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == machineid).Select(m => m.ShopId).FirstOrDefault();
                                var subcell = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == machineid).Select(m => m.CellId).FirstOrDefault();

                                var plantName = db.UnitworkccsTblplant.Where(m => m.PlantId == plant).Select(m => m.PlantName).FirstOrDefault();
                                var cellName = db.UnitworkccsTblshop.Where(m => m.ShopId == cell).Select(m => m.ShopName).FirstOrDefault();
                                var subcellName = db.UnitworkccsTblcell.Where(m => m.CellId == subcell).Select(m => m.CellName).FirstOrDefault();



                                worksheet.Cells["A" + StartRow].Value = slNo++;
                                worksheet.Cells["B" + StartRow].Value = CorrectedDate;
                                worksheet.Cells["C" + StartRow].Value = plantName;
                                worksheet.Cells["D" + StartRow].Value = cellName;
                                worksheet.Cells["E" + StartRow].Value = subcellName;
                                worksheet.Cells["F" + StartRow].Value = machineName;
                                worksheet.Cells["G" + StartRow].Value = MacRow.TotalTime;
                                worksheet.Cells["H" + StartRow].Value = MacRow.OperatingTime;
                                worksheet.Cells["I" + StartRow].Value = MacRow.DryRunTime;
                                worksheet.Cells["J" + StartRow].Value = MacRow.SetUpTime;
                                worksheet.Cells["K" + StartRow].Value = MacRow.LoadUnloadTime;
                                worksheet.Cells["L" + StartRow].Value = MacRow.LossOrIdleTime;
                                worksheet.Cells["M" + StartRow].Value = MacRow.BreakdownTime;
                                worksheet.Cells["N" + StartRow].Value = MacRow.PowerOffOrDataLossTime;
                                worksheet.Cells["O" + StartRow].Value = MacRow.Utilization;
                                worksheet.Cells["P" + StartRow].Value = MacRow.ElectricalMaintenance;
                                worksheet.Cells["Q" + StartRow].Value = MacRow.MechanicalMaintenance;
                                worksheet.Cells["R" + StartRow].Value = MacRow.Production;
                                worksheet.Cells["S" + StartRow].Value = MacRow.HumanResource;
                                worksheet.Cells["T" + StartRow].Value = MacRow.Quality;
                                worksheet.Cells["U" + StartRow].Value = MacRow.ToolingStoppage;
                                worksheet.Cells["V" + StartRow].Value = MacRow.Planning;

                                worksheet.Cells["W" + StartRow].Value = MacRow.ElectricalMaintenance1;
                                worksheet.Cells["X" + StartRow].Value = MacRow.MechanicalMaintenance1;
                                worksheet.Cells["Y" + StartRow].Value = MacRow.Production1;
                                worksheet.Cells["Z" + StartRow].Value = MacRow.HumanResource1;
                                worksheet.Cells["AA" + StartRow].Value = MacRow.Quality1;
                                worksheet.Cells["AB" + StartRow].Value = MacRow.ToolingStoppage1;
                                worksheet.Cells["AC" + StartRow].Value = MacRow.Planning1;

                                StartRow++;
                            }
                        }


                    }
                }

                int srow = 80;
                //for (int i = 0; i <= dateDifference; i++)
                //{

                //    string[] machines = machinelistids;
                //    DateTime QueryDate = Convert.ToDateTime(FromDate).AddDays(i);
                //    string CorrectedDate = QueryDate.ToString("yyyy-MM-dd");


                //    for (int j = 0; j < machines.Count(); j++)
                //    {

                //        int machineid = Convert.ToInt32(machines[j]);

                //        var GetUtilList = db.UnitworkccsTblbreakdownReportdetails.Where(m => m.MachineId == machineid && m.CorrectedDate == CorrectedDate).ToList();

                //        if (GetUtilList.Count > 0)
                //        {

                //            foreach (var MacRow in GetUtilList)
                //            {


                //                srow++;
                //            }
                //        }


                //    }
                //}


                worksheetGraph.Cells["C2"].Value = 40;
                worksheetGraph.Cells["C3"].Value = 40;
                worksheetGraph.Cells["A80"].Value = "optime";
                worksheetGraph.Cells["B80"].Value = 10;
                worksheetGraph.Cells["A81"].Value = "dry";
                worksheetGraph.Cells["B81"].Value = 20;



                worksheetGraph.Cells["A82"].Value = "optime1";
                worksheetGraph.Cells["B82"].Value = 10;
                worksheetGraph.Cells["A83"].Value = "dry1";
                worksheetGraph.Cells["B83"].Value = 20;


                p.Save();

                //Downloding Excel
                //  string path1 = System.IO.Path.Combine(FileDir, "OEE_Report" + Convert.ToDateTime(ToDate).ToString("yyyy-MM-dd") + ".xlsx");




                obj.isStatus = true;
                obj.response = retrivalPath;




            }
            catch (Exception ex)
            {
                log.Error(ex); if (ex.InnerException != null) { log.Error(ex.InnerException.ToString()); }
                obj.response = ResourceResponse.ExceptionMessage;
                obj.isStatus = false;
            }

            return obj;
        }

    }
}
