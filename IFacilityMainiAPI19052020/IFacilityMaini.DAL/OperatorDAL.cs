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
using static IFacilityMaini.EntityModels.OperatorEntity;
using System.IO;
using System.Data.SqlClient;

namespace IFacilityMaini.DAL
{
    public class OperatorDAL : IOperator
    {
        unitworksccsContext db = new unitworksccsContext();
        private readonly AppSettings appSettings;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(FGAndCellAllocationDAL));
        public static IConfiguration configuration;

        public OperatorDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings)
        {
            db = _db;
            configuration = _configuration;
            appSettings = _appSettings.Value;
        }

        /// <summary>
        /// View Multiple Part Name
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleRoles()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.Tblroles
                             where wf.IsDeleted == 0
                             select new
                             {
                                 RoleId = wf.RoleId,
                                 RoleName = wf.RoleName,
                                 RoleDesc = wf.RoleDesc
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
        /// View Multiple category
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
                                 categoryid = wf.CategoryId,
                                 categoryname = wf.CategoryName
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
        /// View Multiple shift
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleShift()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblshiftMstr
                             where wf.IsDeleted == 0
                             select new
                             {
                                 shiftid = wf.ShiftId,
                                 shiftname = wf.ShiftName
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
        /// View Multiple Cell
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleCell()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblCellFinalMaster
                             where wf.IsDeleted == 0
                             select new
                             {
                                 cellid = wf.CellFinalId,
                                 cellname = wf.CellFinalName
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
        /// View Multiple subcell
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleSubcell()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblSubCellFinalMaster
                             where wf.IsDeleted == 0
                             select new
                             {
                                 subcellid = wf.SubCellFinalId,
                                 subcellname = wf.SubCellFinalName

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
        /// View Multiple Machine name
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleMachinename()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.Tblmachinedetails
                             where wf.IsDeleted == 0
                             select new
                             {
                                 machineid = wf.MachineId,
                                 machinename = wf.MachineName,
                                 MachineDescription = wf.MachineDescription

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
        /// Add Update operator details 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse AddUpdateOperator(List<AddUpdateOperator> data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                //string connectionString1 = Path.Combine(appSettings.DefaultConnection);
                //using (SqlConnection sqlConn = new SqlConnection(connectionString1))
                //{
                //    string sql = "Truncate Table [unitworksccs].[unitworkccs].[tblOperatorDetails]";
                //    using (SqlCommand sqlCmd = new SqlCommand(sql, sqlConn))
                //    {
                //        sqlConn.Open();
                //        sqlCmd.ExecuteNonQuery();
                //    }
                //}

                foreach (var item in data)
                {
                    var check = db.TblOperatorDetails.Where(m => m.OpId == item.opId).FirstOrDefault();
                    if (check == null)
                    {
                        TblOperatorDetails tblOperatorDetails = new TblOperatorDetails();

                        if (item.role != null)
                        {
                            var roleId = db.Tblroles.Where(m => m.RoleName == item.role).Select(m => m.RoleId).FirstOrDefault();
                            tblOperatorDetails.RoleId = roleId;
                        }
                        else
                        {
                            tblOperatorDetails.RoleId = item.roleId;
                        }


                        //if (item.shift != null)
                        //{
                        //    var shiftId = db.TblshiftMstr.Where(m => m.ShiftName == item.shift).Select(m => m.ShiftId).FirstOrDefault();
                        //    tblOperatorDetails.ShiftId = shiftId;
                        //}
                        //else
                        //{
                        //    tblOperatorDetails.ShiftId = item.shiftId;
                        //}
                        tblOperatorDetails.Shift = item.shift;
                        if (item.subCell != null)
                        {
                            var subCellFinalId = db.TblSubCellFinalMaster.Where(m => m.SubCellFinalName == item.subCell).Select(m => m.SubCellFinalId).FirstOrDefault();
                            tblOperatorDetails.SubCellId = subCellFinalId;
                        }
                        else
                        {
                            tblOperatorDetails.SubCellId = item.subCellFinalId;
                        }

                        if (item.cell != null)
                        {
                            var CellFinalId = db.TblCellFinalMaster.Where(m => m.CellFinalName == item.cell).Select(m => m.CellFinalId).FirstOrDefault();
                            tblOperatorDetails.CellId = CellFinalId;
                        }
                        else
                        {
                            tblOperatorDetails.CellId = item.cellFinalId;
                        }

                        if (item.category != null)
                        {
                            var categoryId = db.TblCategoryMaster.Where(m => m.CategoryName == item.category).Select(m => m.CategoryId).FirstOrDefault();
                            tblOperatorDetails.CategoryId = categoryId;
                        }
                        else
                        {
                            tblOperatorDetails.CategoryId = item.categoryId;
                        }

                        if (item.machineName != null)
                        {
                            var machineId = db.Tblmachinedetails.Where(m => m.MachineName == item.machineName).Select(m => m.MachineId).FirstOrDefault();
                            tblOperatorDetails.MachineId = machineId;
                        }
                        else
                        {
                            tblOperatorDetails.MachineId = item.machineId;
                        }

                        tblOperatorDetails.ContactNo = item.conatctNo;
                        tblOperatorDetails.OpNo = item.opNo;
                        tblOperatorDetails.OperatorName = item.employeeName;
                        tblOperatorDetails.UserName = Convert.ToString(item.opNo);
                        tblOperatorDetails.Password = Convert.ToString(item.opNo);
                        tblOperatorDetails.IsDeleted = 0;
                        tblOperatorDetails.CreatedOn = DateTime.Now;
                        db.TblOperatorDetails.Add(tblOperatorDetails);
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;
                    }
                    else
                    {
                        if (item.role != null)
                        {
                            var roleId = db.Tblroles.Where(m => m.RoleName == item.role).Select(m => m.RoleId).FirstOrDefault();
                            check.RoleId = roleId;
                        }
                        else
                        {
                            check.RoleId = item.roleId;
                        }


                        //if (item.shift != null)
                        //{
                        //    var shiftId = db.TblshiftMstr.Where(m => m.ShiftName == item.shift).Select(m => m.ShiftId).FirstOrDefault();
                        //    check.ShiftId = shiftId;
                        //}
                        //else
                        //{
                        //    check.ShiftId = item.shiftId;
                        //}
                        check.Shift = item.shift;
                        if (item.subCell != null)
                        {
                            var subCellFinalId = db.TblSubCellFinalMaster.Where(m => m.SubCellFinalName == item.subCell).Select(m => m.SubCellFinalId).FirstOrDefault();
                            check.SubCellId = subCellFinalId;
                        }
                        else
                        {
                            check.SubCellId = item.subCellFinalId;
                        }

                        if (item.cell != null)
                        {
                            var CellFinalId = db.TblCellFinalMaster.Where(m => m.CellFinalName == item.cell).Select(m => m.CellFinalId).FirstOrDefault();
                            check.CellId = CellFinalId;
                        }
                        else
                        {
                            check.CellId = item.cellFinalId;
                        }

                        if (item.category != null)
                        {
                            var categoryId = db.TblCategoryMaster.Where(m => m.CategoryName == item.category).Select(m => m.CategoryId).FirstOrDefault();
                            check.CategoryId = categoryId;
                        }
                        else
                        {
                            check.CategoryId = item.categoryId;
                        }

                        if (item.machineName != null)
                        {
                            var machineId = db.Tblmachinedetails.Where(m => m.MachineName == item.machineName).Select(m => m.MachineId).FirstOrDefault();
                            check.MachineId = machineId;
                        }
                        else
                        {
                            check.MachineId = item.machineId;
                        }

                        check.OpNo = item.opNo;
                        check.OperatorName = item.employeeName;
                        check.UserName = Convert.ToString(item.opNo);
                        check.Password = Convert.ToString(item.opNo);
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
        /// View Multiple operator
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleOperator()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblOperatorDetails
                             where wf.IsDeleted == 0
                             select new
                             {
                                 OperatorName = wf.OperatorName,
                                 OpNo = wf.OpNo,
                                 RoleName = db.Tblroles.Where(m => m.RoleId == wf.RoleId).Select(m => m.RoleName).FirstOrDefault(),
                                 RoleId = wf.RoleId,
                                 ShiftName = wf.Shift,
                                 CategoryName = db.TblCategoryMaster.Where(m => m.CategoryId == wf.CategoryId).Select(m => m.CategoryName).FirstOrDefault(),
                                 CategoryId = wf.CategoryId,
                                 CellFinalName = db.TblCellFinalMaster.Where(m => m.CellFinalId == wf.CellId).Select(m => m.CellFinalName).FirstOrDefault(),
                                 CellFinalId = wf.CellId,
                                 SubCellFinalName = db.TblSubCellFinalMaster.Where(m => m.SubCellFinalId == wf.SubCellId).Select(m => m.SubCellFinalName).FirstOrDefault(),
                                 SubCellFinalId = wf.SubCellId,
                                 MachineName = db.Tblmachinedetails.Where(m => m.MachineId == wf.MachineId).Select(m => m.MachineName).FirstOrDefault(),
                                 MachineId = wf.MachineId,
                                 ContactNo = wf.ContactNo,
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
        /// View Multiple Operator By Id
        /// </summary>
        /// <param name="opId"></param>
        /// <returns></returns>
        public CommonResponse ViewMultipleOperatorById(int opId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblOperatorDetails
                             where wf.IsDeleted == 0 && wf.OpId == opId
                             select new
                             {
                                 OperatorName = wf.OperatorName,
                                 OpNo = wf.OpNo,
                                 RoleName = db.Tblroles.Where(m => m.RoleId == wf.RoleId).Select(m => m.RoleName).FirstOrDefault(),
                                 RoleId = wf.Shift,
                                 CategoryName = db.TblCategoryMaster.Where(m => m.CategoryId == wf.CategoryId).Select(m => m.CategoryName).FirstOrDefault(),
                                 CategoryId = wf.CategoryId,
                                 CellFinalName = db.TblCellFinalMaster.Where(m => m.CellFinalId == wf.CellId).Select(m => m.CellFinalName).FirstOrDefault(),
                                 CellFinalId = wf.CellId,
                                 SubCellFinalName = db.TblSubCellFinalMaster.Where(m => m.SubCellFinalId == wf.SubCellId).Select(m => m.SubCellFinalName).FirstOrDefault(),
                                 SubCellFinalId = wf.SubCellId,
                                 MachineName = db.Tblmachinedetails.Where(m => m.MachineId == wf.MachineId).Select(m => m.MachineName).FirstOrDefault(),
                                 MachineId = wf.MachineId,
                                 ContactNo = wf.ContactNo,
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
        /// Delete operator
        /// </summary>
        /// <param name="Delete Operator"></param>
        /// <returns></returns>
        public CommonResponse DeleteOperator(int opId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.TblOperatorDetails.Where(m => m.OpId == opId).FirstOrDefault();
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
    }
}
