using IFacilityMaini.DAL.Helpers;
using IFacilityMaini.DAL.Resource;
using IFacilityMaini.DBModels;
using IFacilityMaini.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.EmployeeShiftDetailsEntity;
using System.IO;
using System.Data.SqlClient;
using IFacilityMaini.DAL.App_Start;
using OfficeOpenXml;

namespace IFacilityMaini.DAL
{
    public class EmployeeShiftDetailsDAL : IEmployeeShiftDetails
    {

        unitworksccsContext db = new unitworksccsContext();
        private readonly AppSettings appSettings;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(EmployeeShiftDetailsDAL));
        public static IConfiguration configuration;
        //  public static IEmployeeShiftDetails empin;
        public EmployeeShiftDetailsDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings)
        {
            db = _db;
            configuration = _configuration;
            appSettings = _appSettings.Value;
            //  empin = _empin;
        }

        public CommonResponse ViewMultipleOperator()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTbloperatordetails
                             where wf.IsDeleted == 0
                             select new
                             {
                                 operatorNo = wf.OpId,
                                 operatorName = wf.OperatorName
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

        public CommonResponse ViewShifts()
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

        public CommonResponse ViewMultipleMachines()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblmachinedetails
                             where wf.IsDeleted == 0
                             select new
                             {
                                 machineId = wf.MachineId,
                                 machineName = wf.MachineName
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

        public CommonResponse AddUpdateEmployeeShift(AddUpdateOperatorShift data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                DateTime fdate = Convert.ToDateTime(data.fromDate).Date;
                DateTime tdate = Convert.ToDateTime(data.toDate).Date;
                var check = db.UnitworkccsTblemployeeshiftdetails.Where(m => m.Id == data.id && m.EmployeeId == data.employeeId && (m.FromDate.Date <= fdate && m.ToDate.Date >= tdate)).FirstOrDefault();
                if (check == null)
                {
                    UnitworkccsTblemployeeshiftdetails tblOperatorDetailsShift = new UnitworkccsTblemployeeshiftdetails();
                    tblOperatorDetailsShift.EmployeeId = Convert.ToInt32(db.UnitworkccsTbloperatordetails.Where(m=>m.OpId == data.employeeId).Select(m=>m.OpNo).FirstOrDefault());
                    tblOperatorDetailsShift.Shift = data.shift;
                    tblOperatorDetailsShift.MachineIds = data.machineIds;
                    tblOperatorDetailsShift.FromDate = fdate;
                    tblOperatorDetailsShift.ToDate = tdate;
                    tblOperatorDetailsShift.IsDeleted = 0;
                    tblOperatorDetailsShift.CreatedOn = DateTime.Now;
                    tblOperatorDetailsShift.CreatedBy = 1;
                    db.UnitworkccsTblemployeeshiftdetails.Add(tblOperatorDetailsShift);
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.AddedSuccessMessage;
                }
                else
                {

                    check.Shift = data.shift;
                    check.MachineIds = data.machineIds;
                    //  check.FromDate = fdate;
                    //  check.ToDate = tdate;
                    check.IsDeleted = 0;
                    check.ModifiedOn = DateTime.Now;
                    check.ModifiedBy = 2;
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.UpdatedSuccessMessage;
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
        /// View Multiple operator
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleOperatorShift()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var opshift = db.UnitworkccsTblemployeeshiftdetails.Where(m => m.IsDeleted == 0).ToList();
                if (opshift.Count > 0)
                {
                    List<OperatorDetailsShift> operatorDetailsList = new List<OperatorDetailsShift>();
                    foreach (var item in opshift)
                    {
                        var employeeId = db.UnitworkccsTbloperatordetails.Where(m => m.OpNo == item.EmployeeId).Select(m => m.OpId).FirstOrDefault();
                        var opDet = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == employeeId).FirstOrDefault();
                        if (opDet != null)
                        {
                            OperatorDetailsShift operatorDetails = new OperatorDetailsShift();
                            operatorDetails.id = item.Id;
                            operatorDetails.employeeId = item.EmployeeId;
                            operatorDetails.employeeName = opDet.OperatorName;
                            operatorDetails.Cell = db.UnitworkccsTblshop.Where(m => m.ShopId == opDet.CellId).Select(m => m.ShopName).FirstOrDefault();
                            operatorDetails.subCell = db.UnitworkccsTblcell.Where(m => m.CellId == opDet.SubCellId).Select(m => m.CellName).FirstOrDefault();
                            operatorDetails.designation = db.UnitworkccsTblroles.Where(m => m.RoleId == opDet.RoleId).Select(m => m.RoleName).FirstOrDefault();
                            operatorDetails.department = db.UnitworkccsTbldepartmentdetails.Where(m => m.DepartmentId == opDet.DepartmentId).Select(m => m.DepartmentName).FirstOrDefault();
                            // operatorDetails.shift = item.shiftName;
                            operatorDetails.shift = db.UnitworkccsTblshiftMstr.Where(m => m.ShiftId == Convert.ToInt32(item.Shift)).Select(m => m.ShiftName).FirstOrDefault();
                            operatorDetails.shiftId = item.Shift;
                            operatorDetails.opId = opDet.OpId;
                            string fdate = item.FromDate.ToString("yyyy-MM-dd");
                            operatorDetails.fromDate = fdate;

                            string tdate = item.ToDate.ToString("yyyy-MM-dd");
                            operatorDetails.toDate = tdate;

                            if (item.MachineIds != null)
                            {
                                List<int> machineIds = new List<int>();
                                try
                                {
                                    machineIds = item.MachineIds.Split(',').Select(x => int.Parse(x.Trim())).ToList();
                                }
                                catch (Exception ex)
                                { }

                                List<MachineDetails1> machineDetailsList = new List<MachineDetails1>();
                                foreach (var ids in machineIds)
                                {
                                    var dbCheck = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == ids).FirstOrDefault();
                                    if (dbCheck != null)
                                    {
                                        MachineDetails1 machineDetails = new MachineDetails1();
                                        machineDetails.machineId = dbCheck.MachineId;
                                        machineDetails.machineName = dbCheck.MachineName;
                                        machineDetailsList.Add(machineDetails);
                                    }
                                }
                                operatorDetails.machinesList = machineDetailsList;
                            }
                            operatorDetailsList.Add(operatorDetails);
                        }
                    }
                    obj.isStatus = true;
                    obj.response = operatorDetailsList;
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
        /// View Multiple Operator By Id
        /// </summary>
        /// <param name="opId"></param>
        /// <returns></returns>
        public CommonResponse ViewMultipleOperatorShiftById(int Id)
        {
            CommonResponse obj = new CommonResponse();
            try
            {

                var item = db.UnitworkccsTblemployeeshiftdetails.Where(m => m.IsDeleted == 0 && m.Id == Id).FirstOrDefault();

                if (item != null)
                {
                    //  List<OperatorDetails> operatorDetailsList = new List<OperatorDetails>();
                    var opDet = db.UnitworkccsTbloperatordetails.Where(m => m.OpNo == item.EmployeeId).FirstOrDefault();

                    if (opDet != null)
                    {
                        OperatorDetailsShift operatorDetails = new OperatorDetailsShift();
                        operatorDetails.id = item.Id;
                        operatorDetails.employeeId = item.EmployeeId;
                        operatorDetails.employeeName = opDet.OperatorName;
                        operatorDetails.Cell = db.UnitworkccsTblshop.Where(m => m.ShopId == opDet.CellId).Select(m => m.ShopName).FirstOrDefault();
                        operatorDetails.subCell = db.UnitworkccsTblcell.Where(m => m.CellId == opDet.SubCellId).Select(m => m.CellName).FirstOrDefault();
                        operatorDetails.designation = db.UnitworkccsTblroles.Where(m => m.RoleId == opDet.RoleId).Select(m => m.RoleName).FirstOrDefault();
                        operatorDetails.department = db.UnitworkccsTbldepartmentdetails.Where(m => m.DepartmentId == opDet.DepartmentId).Select(m => m.DepartmentName).FirstOrDefault();
                        // operatorDetails.shift = item.shiftName;
                        operatorDetails.shift = db.UnitworkccsTblshiftMstr.Where(m=>m.ShiftId == Convert.ToInt32(item.Shift)).Select(m=>m.ShiftName).FirstOrDefault();

                        string fdate = item.FromDate.ToString("yyyy-MM-dd");
                        operatorDetails.fromDate = fdate;

                        string tdate = item.ToDate.ToString("yyyy-MM-dd");
                        operatorDetails.toDate = tdate;

                        if (item.MachineIds != null)
                        {
                            List<int> machineIds = new List<int>();
                            try
                            {
                                machineIds = item.MachineIds.Split(',').Select(x => int.Parse(x.Trim())).ToList();
                            }
                            catch (Exception ex)
                            { }

                            List<MachineDetails1> machineDetailsList = new List<MachineDetails1>();
                            foreach (var ids in machineIds)
                            {
                                var dbCheck = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == ids).FirstOrDefault();
                                if (dbCheck != null)
                                {
                                    MachineDetails1 machineDetails = new MachineDetails1();
                                    machineDetails.machineId = dbCheck.MachineId;
                                    machineDetails.machineName = dbCheck.MachineName;
                                    machineDetailsList.Add(machineDetails);
                                }
                            }
                            operatorDetails.machinesList = machineDetailsList;
                        }
                        obj.isStatus = true;
                        obj.response = operatorDetails;

                    }
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
        /// Delete operator
        /// </summary>
        /// <param name="Delete Operator"></param>
        /// <returns></returns>
        public CommonResponse DeleteOperatorShift(int Id)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTblemployeeshiftdetails.Where(m => m.Id == Id).FirstOrDefault();
                if (check != null)
                {
                    check.IsDeleted = 1;
                    check.ModifiedOn = DateTime.Now;
                    check.ModifiedBy = 3;
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
        /// Upload Operators
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// 
        //public CommonResponse UploadOperatorsShift(List<AddUpdateOperatorShiftExcel> data)
        //{
        //    CommonResponse obj = new CommonResponse();
        //    try
        //    {
        //        string connectionString1 = Path.Combine(appSettings.DefaultConnection);
        //        using (SqlConnection sqlConn = new SqlConnection(connectionString1))
        //        {
        //            string sql = "delete from [unitworksccs].[unitworkccs].[tblEmployeeShiftDetails]";
        //            using (SqlCommand sqlCmd = new SqlCommand(sql, sqlConn))
        //            {
        //                sqlConn.Open();
        //                sqlCmd.ExecuteNonQuery();
        //            }
        //        }

        //        foreach (var item in data)
        //        {

        //            DateTime fdate = Convert.ToDateTime(item.fromDate).Date;
        //            DateTime tdate = Convert.ToDateTime(item.toDate).Date;
        //            var check = db.TblEmployeeShiftDetails.Where(m => m.EmployeeId == item.employeeId && m.FromDate <= fdate.Date && m.ToDate >= tdate.Date).FirstOrDefault();
        //            if (check == null)
        //            {
        //                TblEmployeeShiftDetails tblOperatorDetailsShift = new TblEmployeeShiftDetails();


        //                tblOperatorDetailsShift.Shift = item.shift;
        //                tblOperatorDetailsShift.EmployeeId = item.employeeId;

        //                tblOperatorDetailsShift.FromDate = fdate;
        //                tblOperatorDetailsShift.ToDate = tdate;


        //                if (item.machines != null)
        //                {
        //                    string[] machineNames = item.machines.Split(',');
        //                    foreach (var items in machineNames)
        //                    {
        //                        var dbCheck = db.Tblmachinedetails.Where(m => m.MachineName == items).Select(m => m.MachineId).FirstOrDefault();
        //                        #region 
        //                        if (dbCheck != null)
        //                        {


        //                            tblOperatorDetailsShift.MachineIds = tblOperatorDetailsShift.MachineIds + "," + dbCheck + ",";
        //                            tblOperatorDetailsShift.MachineIds = tblOperatorDetailsShift.MachineIds.TrimEnd(',');
        //                            tblOperatorDetailsShift.MachineIds = tblOperatorDetailsShift.MachineIds.TrimStart(',');
        //                        }
        //                        #endregion
        //                    }
        //                }
        //                else
        //                {
        //                    tblOperatorDetailsShift.MachineIds = " ";
        //                }

        //                tblOperatorDetailsShift.IsDeleted = 0;
        //                tblOperatorDetailsShift.CreatedOn = DateTime.Now;
        //                tblOperatorDetailsShift.CreatedBy = 1;
        //                db.TblEmployeeShiftDetails.Add(tblOperatorDetailsShift);
        //                db.SaveChanges();
        //                obj.isStatus = true;
        //                obj.response = ResourceResponse.AddedSuccessMessage;
        //            }
        //            else
        //            {

        //                check.Shift = item.shift;

        //              //  check.FromDate = fdate;
        //               // check.ToDate = tdate;

        //                if (item.machines != null)
        //                {
        //                    string[] machineNames = item.machines.Split(',');
        //                    foreach (var items in machineNames)
        //                    {
        //                        var dbCheck = db.Tblmachinedetails.Where(m => m.MachineName == items).Select(m => m.MachineId).FirstOrDefault();
        //                        #region 
        //                        check.MachineIds = check.MachineIds + "," + dbCheck + ",";
        //                        check.MachineIds = check.MachineIds.TrimEnd(',');
        //                        check.MachineIds = check.MachineIds.TrimStart(',');
        //                        #endregion
        //                    }
        //                }


        //                check.IsDeleted = 0;
        //                check.ModifiedOn = DateTime.Now;
        //                check.ModifiedBy = 2;
        //                db.SaveChanges();
        //                obj.isStatus = true;
        //                obj.response = ResourceResponse.UpdatedSuccessMessage;
        //            }
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        obj.isStatus = false;
        //        obj.response = ResourceResponse.FailureMessage;
        //    }
        //    return obj;
        //}
        public CommonResponse UploadOperatorsShift(AddUpdateOperatorShiftExcel data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var dbCheckDelete = db.UnitworkccsTblemployeeshiftdetails.Where(m => m.IsDeleted == 0).ToList();
                db.UnitworkccsTblemployeeshiftdetails.RemoveRange(dbCheckDelete);
                db.SaveChanges();

                DateTime fdate = Convert.ToDateTime(data.fromDate).Date;
                DateTime tdate = Convert.ToDateTime(data.toDate).Date;

                foreach (var list in data.employeeList)
                {
                    var check = db.UnitworkccsTblemployeeshiftdetails.Where(m => m.EmployeeId == list.employeeId && m.FromDate <= fdate.Date && m.ToDate >= tdate.Date).FirstOrDefault();
                    if (check == null)
                    {
                        UnitworkccsTblemployeeshiftdetails tblOperatorDetailsShift = new UnitworkccsTblemployeeshiftdetails();
                        tblOperatorDetailsShift.Shift = list.shift;
                        tblOperatorDetailsShift.EmployeeId = list.employeeId;
                        tblOperatorDetailsShift.FromDate = fdate;
                        tblOperatorDetailsShift.ToDate = tdate;
                        if (list.machines != null)
                        {
                            string[] machineNames = list.machines.Split(',');
                            foreach (var items in machineNames)
                            {
                                var dbCheck = db.UnitworkccsTblmachinedetails.Where(m => m.MachineName == items).Select(m => m.MachineId).FirstOrDefault();
                                #region 
                                if (dbCheck != 0)
                                {
                                    tblOperatorDetailsShift.MachineIds = tblOperatorDetailsShift.MachineIds + "," + dbCheck + ",";
                                    tblOperatorDetailsShift.MachineIds = tblOperatorDetailsShift.MachineIds.TrimEnd(',');
                                    tblOperatorDetailsShift.MachineIds = tblOperatorDetailsShift.MachineIds.TrimStart(',');
                                }
                                #endregion
                            }
                        }
                        else
                        {
                            tblOperatorDetailsShift.MachineIds = "";
                        }

                        tblOperatorDetailsShift.IsDeleted = 0;
                        tblOperatorDetailsShift.CreatedOn = DateTime.Now;
                        tblOperatorDetailsShift.CreatedBy = 1;
                        db.UnitworkccsTblemployeeshiftdetails.Add(tblOperatorDetailsShift);
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;
                    }
                    else
                    {
                        check.Shift = list.shift;

                        //  check.FromDate = fdate;
                        // check.ToDate = tdate;

                        if (list.machines != null)
                        {
                            string[] machineNames = list.machines.Split(',');
                            foreach (var items in machineNames)
                            {
                                var dbCheck = db.UnitworkccsTblmachinedetails.Where(m => m.MachineName == items).Select(m => m.MachineId).FirstOrDefault();
                                #region 
                                check.MachineIds = check.MachineIds + "," + dbCheck + ",";
                                check.MachineIds = check.MachineIds.TrimEnd(',');
                                check.MachineIds = check.MachineIds.TrimStart(',');
                                #endregion
                            }
                        }
                        check.IsDeleted = 0;
                        check.ModifiedOn = DateTime.Now;
                        check.ModifiedBy = 2;
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

        public CommonResponse DownLoadOperatorsShiftDetails()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                FileInfo templateFile = new FileInfo(@"C:\SRKS_ifacility\MainTemplate\EmployeeShift_Download.xlsx");
                ExcelPackage templatep = new ExcelPackage(templateFile);
                ExcelWorksheet Templatews = templatep.Workbook.Worksheets[0];
                //  ExcelWorksheet TemplateGraph = templatep.Workbook.Worksheets[1];

                //excel file save and  downloaded link
                string ImageUrlSave = configuration.GetSection("AppSettings").GetSection("ImageUrlSave").Value;
                string ImageUrl = configuration.GetSection("AppSettings").GetSection("ImageUrl").Value;
                String FileDir = ImageUrlSave + "\\" + "EmployeeShift_Details_" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
                String retrivalPath = ImageUrl + "EmployeeShift_Details_" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
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
                //  int slno = 1;
                var GetUtilList = db.UnitworkccsTblemployeeshiftdetails.Where(m => m.IsDeleted == 0).ToList();
                if (GetUtilList.Count > 0)
                {
                    foreach (var MacRow in GetUtilList)
                    {

                        worksheet.Cells["A" + StartRow].Value = MacRow.EmployeeId;
                        worksheet.Cells["B" + StartRow].Value = MacRow.Shift;
                        if (string.IsNullOrEmpty(MacRow.MachineIds))
                        {
                            worksheet.Cells["C" + StartRow].Value = "";
                        }
                        else
                        {
                            string[] tblmachineIds = MacRow.MachineIds.Split(',');
                            List<string> tblmachine = tblmachineIds.ToList();
                            string machineNames = "";
                            foreach (var macid in tblmachine)
                            {
                                int macId = Convert.ToInt32(macid);
                                string machineN = "";
                                machineN = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == macId).Select(m => m.MachineName).FirstOrDefault();
                                machineNames += machineN + ",";

                            }
                            machineNames = machineNames.TrimEnd(',');
                            worksheet.Cells["C" + StartRow].Value = machineNames;
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
