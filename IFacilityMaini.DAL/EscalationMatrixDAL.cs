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
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.EscationMatrixEntity;

namespace IFacilityMaini.DAL
{
    public class EscalationMatrixDAL : IEscationMatrix
    {
        unitworksccsContext db = new unitworksccsContext();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(EscalationMatrixDAL));
        public static IConfiguration configuration;
        private readonly AppSettings appSettings;

        public EscalationMatrixDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings)
        {
            db = _db;
            configuration = _configuration;
            appSettings = _appSettings.Value;
        }

        /// <summary>
        /// Upload Escalation Matrix Details
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse UploadEscalationMatrixDetails(List<EscalationMatrixDetails> data)
        {
            CommonResponse obj = new CommonResponse();
            CommonFunction commonFunction = new CommonFunction();
            try
            {
                var dbCheck = db.UnitworkccsTblescalationmatrix.Where(m => m.IsDeleted == 0).ToList();
                db.RemoveRange(dbCheck);
                db.SaveChanges();

                foreach (var item in data)
                {

                    var check = db.UnitworkccsTblescalationmatrix.Where(m => m.OpNo == item.employeeId).FirstOrDefault();

                    if (check == null)
                    {

                        UnitworkccsTblescalationmatrix tblEscalationMatrix = new UnitworkccsTblescalationmatrix();
                        tblEscalationMatrix.Category = item.category;


                        string idsss = "";
                        if (string.IsNullOrEmpty(item.category))
                        {
                            tblEscalationMatrix.CategoryId = idsss;
                        }

                        else
                        {
                            string[] catSlipt = item.category.Split(',');
                            List<string> catlist = catSlipt.ToList();

                            foreach (var val in catlist)
                            {
                                var catid = db.UnitworkccsTblcategorymaster.Where(m => m.CategoryName == val).Select(m => m.CategoryId).FirstOrDefault();
                                string ids = catid + ",";
                                idsss = idsss + ids;


                            }
                            idsss = idsss.TrimStart(',');
                            idsss = idsss.TrimEnd(',');
                            tblEscalationMatrix.CategoryId = idsss;

                        }

                        tblEscalationMatrix.Cell = item.cell;
                        string cellids = "";
                        if (string.IsNullOrEmpty(item.cell))
                        {
                            tblEscalationMatrix.CellId = cellids;
                        }

                        else
                        {



                            string[] cellSplit = item.cell.Split(',');
                            List<string> cell = cellSplit.ToList();

                            foreach (var val in cell)
                            {
                                var celid = db.UnitworkccsTblshop.Where(m => m.ShopName == val).Select(m => m.ShopId).FirstOrDefault();
                                string ids = celid + ",";
                                cellids = cellids + ids;
                            }
                            cellids = cellids.TrimStart(',');
                            cellids = cellids.TrimEnd(',');
                            tblEscalationMatrix.CellId = cellids;

                        }
                        //    tblEscalationMatrix.ContactNo = item.contactNo;
                        tblEscalationMatrix.EmployeeId = db.UnitworkccsTbloperatordetails.Where(m => m.OperatorName == item.employeeName).Select(m => m.OpId).FirstOrDefault();
                        tblEscalationMatrix.EmployeeName = item.employeeName;
                        //   tblEscalationMatrix.MachineId = db.Tblmachinedetails.Where(m => m.MachineName == item.machineName).Select(m => m.MachineId).FirstOrDefault();
                        //  tblEscalationMatrix.MachineName = item.machineName;
                        tblEscalationMatrix.OpNo = item.employeeId;
                        //   tblEscalationMatrix.Role = item.role;
                        //  tblEscalationMatrix.RoleId = db.Tblroles.Where(m => m.RoleName == item.role).Select(m => m.RoleId).FirstOrDefault();
                        tblEscalationMatrix.Shift = item.shift;
                        // tblEscalationMatrix.ShiftId = db.TblshiftMstr.Where(m => m.ShiftName == item.shift).Select(m => m.ShiftId).FirstOrDefault();
                        tblEscalationMatrix.SmsPriority = item.smsPriority;
                        tblEscalationMatrix.SubCell = item.subCell;
                        string subcellids = "";

                        if (string.IsNullOrEmpty(item.subCell))
                        {
                            tblEscalationMatrix.SubCellId = subcellids;
                        }
                        else
                        {



                            string[] subcellSplit = item.subCell.Split(',');
                            List<string> subcell = subcellSplit.ToList();

                            foreach (var val in subcell)
                            {
                                var subcelid = db.UnitworkccsTblcell.Where(m => m.CellName == val).Select(m => m.CellId).FirstOrDefault();
                                string ids = subcelid + ",";
                                subcellids = subcellids + ids;
                            }
                            subcellids = subcellids.TrimStart(',');
                            subcellids = subcellids.TrimEnd(',');

                            tblEscalationMatrix.SubCellId = subcellids;
                        }


                        //  tblEscalationMatrix.TimeToBeTriggered = timeToBeTriggered;
                        tblEscalationMatrix.IsDeleted = 0;
                        tblEscalationMatrix.CreatedOn = DateTime.Now;
                        db.UnitworkccsTblescalationmatrix.Add(tblEscalationMatrix);
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;
                        // }
                    }

                    else

                    {
                        check.Category = item.category;

                        string idsss = "";
                        if (string.IsNullOrEmpty(item.category))
                        {
                            check.CategoryId = idsss;
                        }


                        else
                        {



                            string[] catSlipt = item.category.Split(',');
                            List<string> catlist = catSlipt.ToList();

                            foreach (var val in catlist)
                            {
                                var catid = db.UnitworkccsTblcategorymaster.Where(m => m.CategoryName == val).Select(m => m.CategoryId).FirstOrDefault();
                                string ids = catid + ",";
                                idsss = idsss + ids;
                            }
                            idsss = idsss.TrimStart(',');
                            idsss = idsss.TrimEnd(',');
                            check.CategoryId = idsss;

                        }

                        //  check.PlantId = data.plantId;
                        //  check.PlantCode = db.Tblplant.Where(m => m.PlantId == data.plantId).Select(m => m.PlantCode).FirstOrDefault();
                        check.Cell = item.cell;
                        string cellids = "";
                        if (string.IsNullOrEmpty(item.cell))
                        {
                            check.CellId = cellids;
                        }

                        else
                        {



                            string[] cellSplit = item.cell.Split(',');
                            List<string> cell = cellSplit.ToList();

                            foreach (var val in cell)
                            {
                                var celid = db.UnitworkccsTblshop.Where(m => m.ShopName == val).Select(m => m.ShopId).FirstOrDefault();
                                string ids = celid + ",";
                                cellids = cellids + ids;
                            }
                            cellids = cellids.TrimStart(',');
                            cellids = cellids.TrimEnd(',');

                            check.CellId = cellids;
                        }

                        //    check.ContactNo = data.contactNo;
                        check.EmployeeId = db.UnitworkccsTbloperatordetails.Where(m => m.OperatorName == item.employeeName).Select(m => m.OpId).FirstOrDefault();
                        check.EmployeeName = item.employeeName;
                        check.OpNo = item.employeeId;

                        check.Shift = item.shift;
                        //check.ShiftId = db.TblshiftMstr.Where(m => m.ShiftName == item.shift).Select(m => m.ShiftId).FirstOrDefault();
                        check.SmsPriority = item.smsPriority;

                        check.SubCell = item.subCell;
                        string subcellids = "";
                        if (string.IsNullOrEmpty(item.cell))
                        {
                            check.SubCellId = subcellids;
                        }
                        else
                        {



                            string[] subcellSplit = item.subCell.Split(',');
                            List<string> subcell = subcellSplit.ToList();

                            foreach (var val in subcell)
                            {
                                var subcelid = db.UnitworkccsTblcell.Where(m => m.CellName == val).Select(m => m.CellId).FirstOrDefault();
                                string ids = subcelid + ",";
                                subcellids = subcellids + ids;
                            }


                            subcellids = subcellids.TrimStart(',');
                            subcellids = subcellids.TrimEnd(',');
                            check.SubCellId = subcellids;

                        }
                        //    check.TimeToBeTriggered = timeToBeTriggered;
                        check.IsDeleted = 0;
                        check.ModifiedOn = DateTime.Now;
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.UpdatedSuccessMessage;
                        //}

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

        /// <summary>
        /// Add And Edit Escalation Matrix
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse AddAndEditEscalationMatrix(EscalationMatrixCustom data)
        {
            CommonResponse obj = new CommonResponse();
            CommonFunction commonFunction = new CommonFunction();
            try
            {
                var check = db.UnitworkccsTblescalationmatrix.Where(m => m.OpNo == data.employeeId && m.EscalationId == data.escalationId && m.IsDeleted == 0).FirstOrDefault();
                if (check == null)
                {

                    UnitworkccsTblescalationmatrix tblEscalationMatrix = new UnitworkccsTblescalationmatrix();
                    // tblEscalationMatrix.Category = db.TblCategoryMaster.Where(m => m.CategoryId == data.categoryId).Select(m => m.CategoryName).FirstOrDefault();
                    tblEscalationMatrix.CategoryId = data.categoryId;
                    //  tblEscalationMatrix.PlantId = data.plantId;
                    // tblEscalationMatrix.PlantCode = db.Tblplant.Where(m => m.PlantId == data.plantId).Select(m => m.PlantCode).FirstOrDefault();
                    //  tblEscalationMatrix.Cell = db.Tblshop.Where(m => m.ShopId == data.cellId).Select(m => m.ShopName).FirstOrDefault();
                    tblEscalationMatrix.CellId = data.cellId;
                    // tblEscalationMatrix.ContactNo = data.contactNo;
                    tblEscalationMatrix.EmployeeId = db.UnitworkccsTbloperatordetails.Where(m => m.OperatorName == data.emaployeeName).Select(m => m.OpId).FirstOrDefault();
                    tblEscalationMatrix.EmployeeName = data.emaployeeName;
                    //  tblEscalationMatrix.MachineId = data.machineId;
                    //  tblEscalationMatrix.MachineName = db.Tblmachinedetails.Where(m => m.MachineId == data.machineId).Select(m => m.MachineName).FirstOrDefault();
                    tblEscalationMatrix.OpNo = data.employeeId;
                    //  tblEscalationMatrix.Role = db.Tblroles.Where(m => m.RoleId == data.roleId).Select(m => m.RoleName).FirstOrDefault();
                    //  tblEscalationMatrix.RoleId = data.roleId;
                    tblEscalationMatrix.Shift = data.shift;
                    // tblEscalationMatrix.ShiftId = db.TblshiftMstr.Where(m => m.ShiftName == shift).Select(m => m.ShiftId).FirstOrDefault();
                    tblEscalationMatrix.SmsPriority = data.smsPriority;
                    //  tblEscalationMatrix.SubCell = db.Tblcell.Where(m => m.CellId == data.subCellId).Select(m => m.CellName).FirstOrDefault();
                    tblEscalationMatrix.SubCellId = data.subCellId;
                    //  tblEscalationMatrix.TimeToBeTriggered = timeToBeTriggered;
                    tblEscalationMatrix.IsDeleted = 0;
                    tblEscalationMatrix.CreatedOn = DateTime.Now;
                    db.UnitworkccsTblescalationmatrix.Add(tblEscalationMatrix);
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.AddedSuccessMessage;


                }
                else
                {

                    //  check.Category = db.TblCategoryMaster.Where(m => m.CategoryId == data.categoryId).Select(m => m.CategoryName).FirstOrDefault();
                    check.CategoryId = data.categoryId;



                    //  check.PlantId = data.plantId;
                    //  check.PlantCode = db.Tblplant.Where(m => m.PlantId == data.plantId).Select(m => m.PlantCode).FirstOrDefault();
                    // check.Cell = db.Tblshop.Where(m => m.ShopId == data.cellId).Select(m => m.ShopName).FirstOrDefault();
                    check.CellId = data.cellId;
                    //    check.ContactNo = data.contactNo;
                    check.EmployeeId = db.UnitworkccsTbloperatordetails.Where(m => m.OperatorName == data.emaployeeName).Select(m => m.OpId).FirstOrDefault();
                    check.EmployeeName = data.emaployeeName;
                    //  check.MachineId = data.machineId;
                    //  check.MachineName = db.Tblmachinedetails.Where(m => m.MachineId == data.machineId).Select(m => m.MachineName).FirstOrDefault();
                    //  check.Role = db.Tblroles.Where(m => m.RoleId == data.roleId).Select(m => m.RoleName).FirstOrDefault();
                    //  check.RoleId = data.roleId;
                    check.Shift = data.shift;
                    // check.ShiftId = db.TblshiftMstr.Where(m => m.ShiftName == data.shift).Select(m => m.ShiftId).FirstOrDefault();
                    check.SmsPriority = data.smsPriority;
                    //  check.SubCell = db.Tblcell.Where(m => m.CellId == data.subCellId).Select(m => m.CellName).FirstOrDefault();
                    check.SubCellId = data.subCellId;
                    //    check.TimeToBeTriggered = timeToBeTriggered;
                    check.IsDeleted = 0;
                    check.ModifiedOn = DateTime.Now;
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.UpdatedSuccessMessage;
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

        /// <summary>
        /// View Multiple Escalation Matrix
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleEscalationMatrix()
        {

            List<EscalationMatrixCustomView> escalationMatrixViewList = new List<EscalationMatrixCustomView>();
            CommonResponse obj = new CommonResponse();
            try
            {

                var escalationList = db.UnitworkccsTblescalationmatrix.Where(m => m.IsDeleted == 0).ToList();

                foreach (var items in escalationList)
                {
                    EscalationMatrixCustomView escalationView = new EscalationMatrixCustomView();


                    escalationView.escalationId = items.EscalationId;

                    escalationView.opId = (int)items.EmployeeId;
                    escalationView.employeeId = (int)items.OpNo;
                    escalationView.emaployeeName = items.EmployeeName;


                    List<cellDet> cellList = new List<cellDet>();

                    if (string.IsNullOrEmpty(items.CellId))
                    {
                        escalationView.cellDet = cellList;
                    }
                    else
                    {
                        string[] tblcell = items.CellId.Split(',');
                        List<string> tblcellList = tblcell.ToList();

                        foreach (var cellid in tblcellList)
                        {

                            int cellId = Convert.ToInt32(cellid);
                            cellDet cell = new cellDet();
                            cell.cellId = cellId;
                            cell.cellName = db.UnitworkccsTblshop.Where(m => m.ShopId == cellId).Select(m => m.ShopName).FirstOrDefault();

                            cellList.Add(cell);
                        }
                        escalationView.cellDet = cellList;

                    }





                    List<subcellDet1> subcelllist = new List<subcellDet1>();

                    if (string.IsNullOrEmpty(items.SubCellId))
                    {
                        escalationView.subCellDet = subcelllist;
                    }

                    else
                    {
                        string[] tblsubcell = items.SubCellId.Split(',');

                        List<string> tblsublist = tblsubcell.ToList();

                        foreach (var subcell in tblsublist)
                        {

                            int subCellId = Convert.ToInt32(subcell);
                            subcellDet1 subcellval = new subcellDet1();
                            subcellval.subCellId = subCellId;
                            subcellval.subCellName = db.UnitworkccsTblcell.Where(m => m.CellId == subCellId).Select(m => m.CellName).FirstOrDefault();

                            subcelllist.Add(subcellval);
                        }
                        escalationView.subCellDet = subcelllist;
                    }

                    List<categoryDet> categorylist = new List<categoryDet>();
                    if (string.IsNullOrEmpty(items.CategoryId))
                    {
                        escalationView.categoryDet = categorylist;
                    }

                    else
                    {

                        string[] tblcategoryids = items.CategoryId.Split(',');
                        List<string> tblcatlst = tblcategoryids.ToList();

                        foreach (var category in tblcatlst)
                        {

                            int categoryID = Convert.ToInt32(category);
                            categoryDet cat = new categoryDet();
                            cat.categoryId = categoryID;
                            cat.categoryName = db.UnitworkccsTblcategorymaster.Where(m => m.CategoryId == categoryID).Select(m => m.CategoryName).FirstOrDefault(); ;

                            categorylist.Add(cat);
                        }
                        escalationView.categoryDet = categorylist;
                    }



                    List<smsPriorityDet> smslist = new List<smsPriorityDet>();
                    if (string.IsNullOrEmpty(items.SmsPriority))
                    {
                        escalationView.smsPriorityDet = smslist;
                    }
                    else
                    {


                        string[] tblsmsPr = items.SmsPriority.Split(',');
                        List<string> tblsmsPrList = tblsmsPr.ToList();

                        foreach (var smsId in tblsmsPrList)
                        {
                            smsPriorityDet smspr = new smsPriorityDet();
                            int smsprId = Convert.ToInt32(smsId);
                            smspr.priorityId = smsprId;
                            if (smsprId == 1)
                                smspr.priorityName = "firstPriority";
                            else if (smsprId == 2)
                                smspr.priorityName = "secondPriority";
                            else if (smsprId == 3)
                                smspr.priorityName = "thirdPriority";
                            else if (smsprId == 4)
                                smspr.priorityName = "fourthPriority";


                            smslist.Add(smspr);
                        }
                        escalationView.smsPriorityDet = smslist;


                    }


                    List<shiftDet> shiftList = new List<shiftDet>();

                    if (string.IsNullOrEmpty(items.Shift))
                    {
                        escalationView.shiftDets = shiftList;
                    }
                    else
                    {

                        string[] tblshift = items.Shift.Split(',');
                        List<string> tbleslist = tblshift.ToList();

                        foreach (var sList in tbleslist)
                        {
                            shiftDet sfList = new shiftDet();
                            sfList.shiftId = db.UnitworkccsTblshiftMstr.Where(m => m.ShiftName == sList).Select(m => m.ShiftId).FirstOrDefault();
                            sfList.shiftName = sList;

                            shiftList.Add(sfList);
                        }
                        escalationView.shiftDets = shiftList;

                    }

                    escalationMatrixViewList.Add(escalationView);
                }

                if (escalationMatrixViewList.Count > 0)
                {


                    obj.isStatus = true;
                    obj.response = escalationMatrixViewList;
                }



                else
                {
                    obj.isStatus = true;
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

        public CommonResponse ViewEscalationMatrixById(long escalationId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {

                var items = db.UnitworkccsTblescalationmatrix.Where(m => m.IsDeleted == 0 && m.EscalationId == escalationId).FirstOrDefault();
                EscalationMatrixCustomView escalationView = new EscalationMatrixCustomView();


                escalationView.escalationId = items.EscalationId;


                escalationView.opId = (int)items.EmployeeId;
                escalationView.employeeId = (int)items.OpNo;
                escalationView.emaployeeName = items.EmployeeName;



                List<cellDet> cellList = new List<cellDet>();

                if (string.IsNullOrEmpty(items.CellId))
                {
                    escalationView.cellDet = cellList;
                }
                else
                {
                    string[] tblcell = items.CellId.Split(',');
                    List<string> tblcellList = tblcell.ToList();

                    foreach (var cellid in tblcellList)
                    {

                        int cellId = Convert.ToInt32(cellid);
                        cellDet cell = new cellDet();
                        cell.cellId = cellId;
                        cell.cellName = db.UnitworkccsTblshop.Where(m => m.ShopId == cellId).Select(m => m.ShopName).FirstOrDefault();

                        cellList.Add(cell);
                    }
                    escalationView.cellDet = cellList;

                }


                List<subcellDet1> subcelllist = new List<subcellDet1>();

                if (string.IsNullOrEmpty(items.SubCellId))
                {
                    escalationView.subCellDet = subcelllist;
                }

                else
                {
                    string[] tblsubcell = items.SubCellId.Split(',');

                    List<string> tblsublist = tblsubcell.ToList();

                    foreach (var subcell in tblsublist)
                    {

                        int subCellId = Convert.ToInt32(subcell);
                        subcellDet1 subcellval = new subcellDet1();
                        subcellval.subCellId = subCellId;
                        subcellval.subCellName = db.UnitworkccsTblcell.Where(m => m.CellId == subCellId).Select(m => m.CellName).FirstOrDefault();

                        subcelllist.Add(subcellval);
                    }
                    escalationView.subCellDet = subcelllist;
                }

                List<categoryDet> categorylist = new List<categoryDet>();
                if (string.IsNullOrEmpty(items.CategoryId))
                {
                    escalationView.categoryDet = categorylist;
                }

                else
                {

                    string[] tblcategoryids = items.CategoryId.Split(',');
                    List<string> tblcatlst = tblcategoryids.ToList();

                    foreach (var category in tblcatlst)
                    {

                        int categoryID = Convert.ToInt32(category);
                        categoryDet cat = new categoryDet();
                        cat.categoryId = categoryID;
                        cat.categoryName = db.UnitworkccsTblcategorymaster.Where(m => m.CategoryId == categoryID).Select(m => m.CategoryName).FirstOrDefault(); ;

                        categorylist.Add(cat);
                    }
                    escalationView.categoryDet = categorylist;
                }



                List<smsPriorityDet> smslist = new List<smsPriorityDet>();
                if (string.IsNullOrEmpty(items.SmsPriority))
                {
                    escalationView.smsPriorityDet = smslist;
                }
                else
                {


                    string[] tblsmsPr = items.SmsPriority.Split(',');
                    List<string> tblsmsPrList = tblsmsPr.ToList();

                    foreach (var smsId in tblsmsPrList)
                    {
                        smsPriorityDet smspr = new smsPriorityDet();
                        int smsprId = Convert.ToInt32(smsId);
                        smspr.priorityId = smsprId;
                        if (smsprId == 1)
                            smspr.priorityName = "firstPriority";
                        else if (smsprId == 2)
                            smspr.priorityName = "secondPriority";
                        else if (smsprId == 3)
                            smspr.priorityName = "thirdPriority";
                        else if (smsprId == 4)
                            smspr.priorityName = "fourthPriority";


                        smslist.Add(smspr);
                    }
                    escalationView.smsPriorityDet = smslist;


                }


                List<shiftDet> shiftList = new List<shiftDet>();

                if (string.IsNullOrEmpty(items.Shift))
                {
                    escalationView.shiftDets = shiftList;
                }
                else
                {

                    string[] tblshift = items.Shift.Split(',');
                    List<string> tbleslist = tblshift.ToList();

                    foreach (var sList in tbleslist)
                    {
                        shiftDet sfList = new shiftDet();
                        sfList.shiftId = db.UnitworkccsTblshiftMstr.Where(m => m.ShiftName == sList).Select(m => m.ShiftId).FirstOrDefault();
                        sfList.shiftName = sList;

                        shiftList.Add(sfList);
                    }
                    escalationView.shiftDets = shiftList;

                }




                if (escalationView != null)
                {


                    obj.isStatus = true;
                    obj.response = escalationView;
                }

                else
                {
                    obj.isStatus = true;
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

        /// <summary>
        /// Delete Escalation Matrix
        /// </summary>
        /// <param name="escalationId"></param>
        /// <returns></returns>
        public CommonResponse DeleteEscalationMatrix(long escalationId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTblescalationmatrix.Where(m => m.EscalationId == escalationId).FirstOrDefault();
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
        /// View Multiple Part Name
        /// </summary>
        /// <returns></returns>
        //public CommonResponse ViewMultipleRoles()
        //{
        //    CommonResponse obj = new CommonResponse();
        //    try
        //    {
        //        var check = (from wf in db.Tblroles
        //                     where wf.IsDeleted == 0
        //                     select new
        //                     {
        //                         RoleId = wf.RoleId,
        //                         RoleName = wf.RoleName,
        //                         RoleDesc = wf.RoleDesc
        //                     }).ToList();

        //        if (check.Count > 0)
        //        {
        //            obj.isStatus = true;
        //            obj.response = check;
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

        public CommonResponse ViewMultipleOperatorDetails()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTbloperatordetails
                             where wf.IsDeleted == 0
                             select new
                             {
                                 employeeId = wf.OpNo.ToString(),
                                 employeeName = wf.OperatorName
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

        /// <summary>
        /// View Multiple category
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
                                 categoryId = wf.CategoryId,
                                 categoryName = wf.CategoryName
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
        /// View Multiple Plants
        /// </summary>
        /// <returns></returns>
        //public CommonResponse ViewMultiplePlants()
        //{
        //    CommonResponse obj = new CommonResponse();
        //    try
        //    {
        //        var check = (from wf in db.Tblplant
        //                     where wf.IsDeleted == 0
        //                     select new
        //                     {
        //                         plantDisplayName = wf.PlantDisplayName,
        //                         plantId = wf.PlantId,
        //                         plantCode = wf.PlantCode,
        //                         plantName = wf.PlantName
        //                     }).ToList();

        //        if(check.Count > 0)
        //        {
        //            obj.isStatus = true;
        //            obj.response = check;
        //        }
        //        else
        //        {
        //            obj.isStatus = false;
        //            obj.response = ResourceResponse.NoItemsFound;
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

        /// <summary>
        /// View Multiple Cell
        /// </summary>
        /// <param name="plantId"></param>
        /// <returns></returns>
        public CommonResponse ViewMultipleCell()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblshop
                             where wf.IsDeleted == 0
                             select new
                             {
                                 cellId = wf.ShopId,
                                 cellName = wf.ShopName
                                 //  partName = wf.PartName
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
        /// View Multiple Sub cell
        /// </summary>
        /// <param name="cellId"></param>
        /// <returns></returns>
        public CommonResponse ViewMultipleSubcell(string cellId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                string[] cellids = cellId.Split(',');
                List<subCellDet> subcelllist = new List<subCellDet>();
                foreach (var cell in cellids)
                {
                    var check1 = db.UnitworkccsTblcell.Where(m => m.ShopId == Convert.ToInt32(cell) && m.IsDeleted == 0).ToList();
                    if (check1.Count > 0)
                    {
                        for (int i = 0; i < check1.Count(); i++)
                        {
                            //int mid = Convert.ToInt32(check1[i]);
                            subCellDet Subcell = new subCellDet();
                            Subcell.subCellId = check1[i].CellId;
                            Subcell.subCellName = check1[i].CellName;
                            subcelllist.Add(Subcell);
                        }
                    }

                }

                if (subcelllist.Count > 0)
                {
                    obj.isStatus = true;
                    obj.response = subcelllist;
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
        public CommonResponse ViewMultipleShift()
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

        public CommonResponse DownloadEscalationMatrixDetails()
        {
            CommonResponse obj = new CommonResponse();
            try
            {

                FileInfo templateFile = new FileInfo(@"C:\SRKS_ifacility\MainTemplate\EscalationMatrix_detials.xlsx");

                ExcelPackage templatep = new ExcelPackage(templateFile);
                ExcelWorksheet Templatews = templatep.Workbook.Worksheets[0];
                //  ExcelWorksheet TemplateGraph = templatep.Workbook.Worksheets[1];


                //excel file save and  downloaded link

                string ImageUrlSave = configuration.GetSection("AppSettings").GetSection("ImageUrlSave").Value;
                string ImageUrl = configuration.GetSection("AppSettings").GetSection("ImageUrl").Value;

                String FileDir = ImageUrlSave + "\\" + "EscalationMatrix_detials_" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
                String retrivalPath = ImageUrl + "EscalationMatrix_detials_" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";



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
                int slno = 1;
                var GetUtilList = db.UnitworkccsTblescalationmatrix.Where(m => m.IsDeleted == 0).ToList();
                // slNo employeeId  employeeName cell    subCell category    shift smsPriority

                if (GetUtilList.Count > 0)
                {
                    foreach (var MacRow in GetUtilList)
                    {
                        // worksheet.Cells["A" + StartRow].Value = slno++;
                        worksheet.Cells["A" + StartRow].Value = MacRow.OpNo;
                        worksheet.Cells["B" + StartRow].Value = MacRow.EmployeeName;

                        if (string.IsNullOrEmpty(MacRow.CellId))
                        {
                            worksheet.Cells["C" + StartRow].Value = "";
                        }
                        else
                        {
                            string[] tblcell = MacRow.CellId.Split(',');
                            List<string> tblcellList = tblcell.ToList();

                            string CellNames = "";

                            foreach (var cellid in tblcellList)
                            {

                                int cellId = Convert.ToInt32(cellid);

                                string cellS = "";
                                cellS = db.UnitworkccsTblshop.Where(m => m.ShopId == cellId).Select(m => m.ShopName).FirstOrDefault();
                                CellNames += cellS + ",";


                            }
                            CellNames = CellNames.TrimEnd(',');
                            worksheet.Cells["C" + StartRow].Value = CellNames;

                        }

                        if (string.IsNullOrEmpty(MacRow.SubCellId))
                        {
                            worksheet.Cells["D" + StartRow].Value = "";
                        }
                        else
                        {
                            string[] tblsubcell = MacRow.SubCellId.Split(',');
                            List<string> tblsubcellList = tblsubcell.ToList();

                            string subCellNames = "";

                            foreach (var subcellid in tblsubcellList)
                            {

                                int subcellId = Convert.ToInt32(subcellid);

                                string cellS = "";
                                cellS = db.UnitworkccsTblcell.Where(m => m.CellId == subcellId).Select(m => m.CellName).FirstOrDefault();
                                subCellNames += cellS + ",";


                            }
                            subCellNames = subCellNames.TrimEnd(',');
                            worksheet.Cells["D" + StartRow].Value = subCellNames;

                        }


                        if (string.IsNullOrEmpty(MacRow.CategoryId))
                        {
                            worksheet.Cells["E" + StartRow].Value = "";
                        }
                        else
                        {
                            string[] tblcat = MacRow.CategoryId.Split(',');
                            List<string> tblcategory = tblcat.ToList();

                            string categoryNames = "";

                            foreach (var catid in tblcategory)
                            {

                                int catId = Convert.ToInt32(catid);

                                string cellS = "";
                                cellS = db.UnitworkccsTblcategorymaster.Where(m => m.CategoryId == catId).Select(m => m.CategoryName).FirstOrDefault();
                                categoryNames += cellS + ",";


                            }
                            categoryNames = categoryNames.TrimEnd(',');
                            worksheet.Cells["E" + StartRow].Value = categoryNames;

                        }

                        worksheet.Cells["F" + StartRow].Value = MacRow.Shift;
                        worksheet.Cells["G" + StartRow].Value = MacRow.SmsPriority;

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
