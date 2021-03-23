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
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.OperatorEntity;

namespace IFacilityMaini.DAL
{
    public class OperatorDAL : IOperator
    {
        unitworksccsContext db = new unitworksccsContext();
        private readonly AppSettings appSettings;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(OperatorDAL));
        public static IConfiguration configuration;

        public OperatorDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings)
        {
            db = _db;
            configuration = _configuration;
            appSettings = _appSettings.Value;
        }

        /// <summary>
        /// View Multiple Departments
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleDepartments()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTbldepartmentdetails
                             where wf.IsDeleted == 0
                             select new
                             {
                                 departmentId = wf.DepartmentId,
                                 departmentName = wf.DepartmentName
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
        public CommonResponse ViewMultipleCategoryDetails()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblcategorydetails
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

        public CommonResponse ViewMultipleBusiness()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblbusinessdetails
                             where wf.IsDeleted == 0
                             select new
                             {
                                 businessId = wf.BusinessId,
                                 businessName = wf.BusinessName
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
        /// View Multiple Part Name
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleRoles()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblroles
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

        ///// <summary>
        ///// View Multiple category
        ///// </summary>
        ///// <returns></returns>
        //public CommonResponse ViewMultipleCategory()
        //{
        //    CommonResponse obj = new CommonResponse();
        //    try
        //    {
        //        var check = (from wf in db.TblCategoryMaster
        //                     where wf.IsDeleted == 0
        //                     select new
        //                     {
        //                         categoryid = wf.CategoryId,
        //                         categoryname = wf.CategoryName
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

        /// <summary>
        /// View Multiple Plants
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultiplePlants()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblplant
                             where wf.IsDeleted == 0
                             select new
                             {
                                 plantDisplayName = wf.PlantDisplayName,
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

        /// <summary>
        /// View Multiple Cell
        /// </summary>
        /// <param name="plantId"></param>
        /// <returns></returns>
        public CommonResponse ViewMultipleCell(int plantId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblshop
                             where wf.IsDeleted == 0 && wf.PlantId == plantId
                             select new
                             {
                                 cellid = wf.ShopId,
                                 cellname = wf.ShopName
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
        public CommonResponse ViewMultipleSubcell(int cellId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblcell
                             where wf.IsDeleted == 0 && wf.ShopId == cellId
                             select new
                             {
                                 subcellId = wf.CellId,
                                 subcellname = wf.CellName

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

        ///// <summary>
        ///// View Multiple Machine name
        ///// </summary>
        ///// <param name="cellId"></param>
        ///// <param name="subCellId"></param>
        ///// <returns></returns>
        //public CommonResponse ViewMultipleMachinename(int cellId, int subCellId)
        //{
        //    CommonResponse obj = new CommonResponse();
        //    try
        //    {
        //        var check = (from wf in db.Tblmachinedetails
        //                     where wf.IsDeleted == 0 && wf.CellId == subCellId && wf.ShopId == cellId
        //                     select new
        //                     {
        //                         machineid = wf.MachineId,
        //                         machinename = wf.MachineName,
        //                         MachineDescription = wf.MachineDescription

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

        /// <summary>
        /// Add Update operator details 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse AddUpdateOperator(AddUpdateOperator data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == data.opId).FirstOrDefault();
                if (check == null)
                {
                   UnitworkccsTbloperatordetails UnitworkccsTbloperatordetails = new UnitworkccsTbloperatordetails();
                    UnitworkccsTbloperatordetails.DepartmentId = data.departmentId;
                    UnitworkccsTbloperatordetails.CategoryId = data.categoryId;
                    UnitworkccsTbloperatordetails.BusinessId = data.businessId;
                    UnitworkccsTbloperatordetails.RoleId = data.roleId;
                    //   UnitworkccsTbloperatordetails.Shift = data.shift;
                    UnitworkccsTbloperatordetails.PlantId = data.plantId;
                    // UnitworkccsTbloperatordetails.Location = data.plantLocation;
                    UnitworkccsTbloperatordetails.ContactNo = data.conatctNo;
                    UnitworkccsTbloperatordetails.OperatorEmailId = data.emailId;
                    UnitworkccsTbloperatordetails.SubCellId = data.subCellId;
                    UnitworkccsTbloperatordetails.CellId = data.cellId;
                    // UnitworkccsTbloperatordetails.CategoryId = data.categoryId;
                    //   UnitworkccsTbloperatordetails.MachineIds = data.machineIds;

                    UnitworkccsTbloperatordetails.DirectOrIndirect = data.directOrIndirect;
                    UnitworkccsTbloperatordetails.OpNo = data.opNo;
                    UnitworkccsTbloperatordetails.OperatorName = data.employeeName;
                    UnitworkccsTbloperatordetails.UserName = Convert.ToString(data.opNo);
                    UnitworkccsTbloperatordetails.Password = Convert.ToString(data.opNo);
                    UnitworkccsTbloperatordetails.DateOfBirth = Convert.ToDateTime(data.dateOfBirth);
                    UnitworkccsTbloperatordetails.DateOfJoing = Convert.ToDateTime(data.dateOfJoining);
                    UnitworkccsTbloperatordetails.PhotoId = data.photoId;
                    UnitworkccsTbloperatordetails.IsDeleted = 0;
                    UnitworkccsTbloperatordetails.CreatedOn = DateTime.Now;
                    db.UnitworkccsTbloperatordetails.Add(UnitworkccsTbloperatordetails);
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.AddedSuccessMessage;
                }
                else
                {

                    check.DepartmentId = data.departmentId;
                    check.BusinessId = data.businessId;
                    check.CategoryId = data.categoryId;
                    check.RoleId = data.roleId;
                    //  check.Shift = data.shift;
                    check.PlantId = data.plantId;
                    // check.Location = data.plantLocation;

                    check.ContactNo = data.conatctNo;
                    check.OperatorEmailId = data.emailId;
                    check.DirectOrIndirect = data.directOrIndirect;
                    check.DateOfBirth = Convert.ToDateTime(data.dateOfBirth);
                    check.DateOfJoing = Convert.ToDateTime(data.dateOfJoining);
                    check.PhotoId = data.photoId;
                    check.SubCellId = data.subCellId;
                    check.CellId = data.cellId;

                    // check.MachineIds = data.machineIds;
                    check.OpNo = data.opNo;
                    check.OperatorName = data.employeeName;
                    check.UserName = Convert.ToString(data.opNo);
                    check.Password = Convert.ToString(data.opNo);
                    check.IsDeleted = 0;
                    check.ModifiedOn = DateTime.Now;
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
        public CommonResponse ViewMultipleOperator()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTbloperatordetails
                             where wf.IsDeleted == 0
                             select new
                             {
                                 opId = wf.OpId,
                                 departmentId = wf.DepartmentId,
                                 departmentName = db.UnitworkccsTbldepartmentdetails.Where(m => m.DepartmentId == wf.DepartmentId).Select(m => m.DepartmentName).FirstOrDefault(),

                                 businessId = wf.BusinessId,
                                 businessName = db.UnitworkccsTblbusinessdetails.Where(m => m.BusinessId == wf.BusinessId).Select(m => m.BusinessName).FirstOrDefault(),
                                 categoryName = db.UnitworkccsTblcategorydetails.Where(m => m.CategoryId == wf.CategoryId).Select(m => m.CategoryName).FirstOrDefault(),
                                 categoryId = wf.CategoryId,

                                 plantId = wf.PlantId,
                                 plantLocation = db.UnitworkccsTblplant.Where(m => m.PlantId == wf.PlantId).Select(m => m.PlantLocation).FirstOrDefault(),
                                 operatorName = wf.OperatorName,
                                 opNo = wf.OpNo,
                                 roleName = db.UnitworkccsTblroles.Where(m => m.RoleId == wf.RoleId).Select(m => m.RoleName).FirstOrDefault(),
                                 roleId = wf.RoleId,
                                 //   shiftName = wf.Shift,

                                 photoId = wf.PhotoId,
                                 //  plantLocation = wf.Location,
                                 directOrIndirect = wf.DirectOrIndirect,
                                 dateOfbirth = wf.DateOfBirth,
                                 dateOfjoing = wf.DateOfJoing,
                                 cellName = db.UnitworkccsTblshop.Where(m => m.ShopId == wf.CellId).Select(m => m.ShopName).FirstOrDefault(),
                                 cellId = wf.CellId,
                                 SubCellName = db.UnitworkccsTblcell.Where(m => m.CellId == wf.SubCellId).Select(m => m.CellName).FirstOrDefault(),
                                 subCellId = wf.SubCellId,
                                 machineId = wf.MachineIds,
                                 contactNo = wf.ContactNo,
                                 email = wf.OperatorEmailId

                             }).ToList();
                if (check.Count > 0)
                {
                    List<OperatorDetails> operatorDetailsList = new List<OperatorDetails>();


                    foreach (var item in check)
                    {


                        OperatorDetails operatorDetails = new OperatorDetails();
                        operatorDetails.opId = item.opId;
                        operatorDetails.categoryId = item.categoryId;
                        operatorDetails.categoryName = item.categoryName;
                        operatorDetails.cellId = item.cellId;
                        operatorDetails.subCellId = item.subCellId;
                        operatorDetails.cellName = item.cellName;
                        operatorDetails.subCellName = item.SubCellName;
                        // operatorDetails.shift = item.shiftName;
                        operatorDetails.roleId = item.roleId;
                        operatorDetails.roleName = item.roleName;
                        operatorDetails.contactNo = item.contactNo;
                        operatorDetails.employeeName = item.operatorName;

                        if (item.dateOfbirth == null)
                        {
                            operatorDetails.dateOfBirth = null;
                        }
                        else
                        {
                            DateTime dob = (DateTime)item.dateOfbirth;
                            operatorDetails.dateOfBirth = dob.ToString("yyyy-MM-dd");
                        }

                        if (item.dateOfjoing == null)
                        {
                            operatorDetails.dateOfJoining = null;
                        }
                        else
                        {

                            DateTime doj = (DateTime)item.dateOfjoing;
                            operatorDetails.dateOfJoining = doj.ToString("yyyy-MM-dd");
                        }

                        operatorDetails.opNo = item.opNo;
                        operatorDetails.plantId = item.plantId;
                        operatorDetails.plantName = item.plantLocation;
                        operatorDetails.departmentId = item.departmentId;
                        operatorDetails.departmentName = item.departmentName;
                      //  operatorDetails.plantName = item.plantName;
                        //  operatorDetails.location = item.plantLocation;
                        operatorDetails.businessId = item.businessId;
                        operatorDetails.businessName = item.businessName;
                        operatorDetails.directOrIndirect = item.directOrIndirect;
                        operatorDetails.emailId = item.email;
                        var pictureuploaderdet = db.UnitworkccsDocumentuploadermaster.Where(m => m.DocumnetUploaderId == item.photoId).FirstOrDefault();
                        if (pictureuploaderdet != null)
                        {
                            operatorDetails.photoId = pictureuploaderdet.DocumnetUploaderId;
                            operatorDetails.photoUrl = appSettings.ImageUrl + pictureuploaderdet.FileName;
                        }
                        //if (item.machineId != null)
                        //{
                        //    List<int> machineIds = new List<int>();
                        //    try
                        //    {
                        //        machineIds = item.machineId.Split(',').Select(x => int.Parse(x.Trim())).ToList();
                        //    }
                        //    catch (Exception ex)
                        //    { }

                        //    List<MachineDetails1> machineDetailsList = new List<MachineDetails1>();
                        //    foreach (var ids in machineIds)
                        //    {
                        //        var dbCheck = db.Tblmachinedetails.Where(m => m.MachineId == ids).FirstOrDefault();
                        //        if (dbCheck != null)
                        //        {
                        //            MachineDetails1 machineDetails = new MachineDetails1();
                        //            machineDetails.machineid = dbCheck.MachineId;
                        //            machineDetails.machinename = dbCheck.MachineName;
                        //            machineDetailsList.Add(machineDetails);
                        //        }
                        //    }
                        //    operatorDetails.machineIds = machineDetailsList;
                        //}
                        operatorDetailsList.Add(operatorDetails);
                        //}
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
        public CommonResponse ViewMultipleOperatorById(int opId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var item = (from wf in db.UnitworkccsTbloperatordetails
                            where wf.IsDeleted == 0 && wf.OpId == opId
                            select new
                            {
                                opId = wf.OpId,
                                departmentId = wf.DepartmentId,
                                departmentName = db.UnitworkccsTbldepartmentdetails.Where(m => m.DepartmentId == wf.DepartmentId).Select(m => m.DepartmentName).FirstOrDefault(),

                                businessId = wf.BusinessId,
                                businessName = db.UnitworkccsTblbusinessdetails.Where(m => m.BusinessId == wf.BusinessId).Select(m => m.BusinessName).FirstOrDefault(),
                                categoryName = db.UnitworkccsTblcategorydetails.Where(m => m.CategoryId == wf.CategoryId).Select(m => m.CategoryName).FirstOrDefault(),
                                categoryId = wf.CategoryId,

                                plantId = wf.PlantId,
                                plantLocation = db.UnitworkccsTblplant.Where(m => m.PlantId == wf.PlantId).Select(m => m.PlantLocation).FirstOrDefault(),
                                operatorName = wf.OperatorName,
                                opNo = wf.OpNo,
                                roleName = db.UnitworkccsTblroles.Where(m => m.RoleId == wf.RoleId).Select(m => m.RoleName).FirstOrDefault(),
                                roleId = wf.RoleId,
                                //  shiftName = wf.Shift,

                                photoId = wf.PhotoId,
                                //   plantLocation = wf.Location,
                                directOrIndirect = wf.DirectOrIndirect,
                                dateOfbirth = wf.DateOfBirth,
                                dateOfjoing = wf.DateOfJoing,
                                cellName = db.UnitworkccsTblshop.Where(m => m.ShopId == wf.CellId).Select(m => m.ShopName).FirstOrDefault(),
                                cellId = wf.CellId,
                                SubCellName = db.UnitworkccsTblcell.Where(m => m.CellId == wf.SubCellId).Select(m => m.CellName).FirstOrDefault(),
                                subCellId = wf.SubCellId,
                                machineId = wf.MachineIds,
                                contactNo = wf.ContactNo,
                                email = wf.OperatorEmailId


                            }).FirstOrDefault();

                if (item != null)
                {
                    //  List<OperatorDetails> operatorDetailsList = new List<OperatorDetails>();


                    OperatorDetails operatorDetails = new OperatorDetails();
                    operatorDetails.opId = item.opId;
                    operatorDetails.categoryId = item.categoryId;
                    operatorDetails.categoryName = item.categoryName;
                    operatorDetails.cellId = item.cellId;
                    operatorDetails.subCellId = item.subCellId;
                    operatorDetails.cellName = item.cellName;
                    operatorDetails.subCellName = item.SubCellName;
                    //   operatorDetails.shift = item.shiftName;
                    operatorDetails.roleId = item.roleId;
                    operatorDetails.roleName = item.roleName;
                    operatorDetails.contactNo = item.contactNo;
                    operatorDetails.emailId = item.email;
                    operatorDetails.employeeName = item.operatorName;
                    if (item.dateOfbirth == null)
                    {
                        operatorDetails.dateOfBirth = null;
                    }
                    else
                    {
                        DateTime dob = (DateTime)item.dateOfbirth;
                        operatorDetails.dateOfBirth = dob.ToString("yyyy-MM-dd");
                    }

                    if (item.dateOfjoing == null)
                    {
                        operatorDetails.dateOfJoining = null;
                    }
                    else
                    {

                        DateTime doj = (DateTime)item.dateOfjoing;
                        operatorDetails.dateOfJoining = doj.ToString("yyyy-MM-dd");
                    }
                    operatorDetails.opNo = item.opNo;
                    operatorDetails.plantId = item.plantId;
                    operatorDetails.plantName = item.plantLocation;
                    operatorDetails.departmentId = item.departmentId;
                    operatorDetails.departmentName = item.departmentName;
                  //  operatorDetails.plantName = item.plantName;
                    //  operatorDetails.location = item.plantLocation;
                    operatorDetails.businessId = item.businessId;
                    operatorDetails.businessName = item.businessName;
                    operatorDetails.directOrIndirect = item.directOrIndirect;

                    var pictureuploaderdet = db.UnitworkccsDocumentuploadermaster.Where(m => m.DocumnetUploaderId == item.photoId).FirstOrDefault();
                    if (pictureuploaderdet != null)
                    {

                        operatorDetails.photoId = pictureuploaderdet.DocumnetUploaderId;
                        operatorDetails.photoUrl = appSettings.ImageUrl + pictureuploaderdet.FileName;
                    }


                    //if (item.machineId != null)
                    //{
                    //    List<int> machineIds = new List<int>();
                    //    try
                    //    {
                    //        machineIds = item.machineId.Split(',').Select(x => int.Parse(x.Trim())).ToList();
                    //    }
                    //    catch (Exception ex)
                    //    { }

                    //    List<MachineDetails1> machineDetailsList = new List<MachineDetails1>();
                    //    foreach (var ids in machineIds)
                    //    {
                    //        var dbCheck = db.Tblmachinedetails.Where(m => m.MachineId == ids).FirstOrDefault();
                    //        if (dbCheck != null)
                    //        {
                    //            MachineDetails1 machineDetails = new MachineDetails1();
                    //            machineDetails.machineid = dbCheck.MachineId;
                    //            machineDetails.machinename = dbCheck.MachineName;
                    //            machineDetailsList.Add(machineDetails);
                    //        }
                    //    }
                    //    operatorDetails.machineIds = machineDetailsList;
                    //}
                    //  operatorDetailsList.Add(operatorDetails);


                    obj.isStatus = true;
                    obj.response = operatorDetails;
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
                var check = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == opId).FirstOrDefault();
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
        /// Upload Operators
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// 
        public CommonResponse UploadOperators(List<OperatorCustom> data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check1 = db.UnitworkccsTbloperatordetails.ToList();
                db.UnitworkccsTbloperatordetails.RemoveRange(check1);
                db.SaveChanges();
                foreach (var item in data)
                {
                    try
                    {
                        var check = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == item.opId).FirstOrDefault();
                        if (check == null)
                        {
                            UnitworkccsTbloperatordetails UnitworkccsTbloperatordetails = new UnitworkccsTbloperatordetails();

                            if (item.department != null)
                            {
                                var deptId = db.UnitworkccsTbldepartmentdetails.Where(m => m.DepartmentName == item.department).Select(m => m.DepartmentId).FirstOrDefault();
                                UnitworkccsTbloperatordetails.DepartmentId = deptId;
                            }
                            else
                            {
                                UnitworkccsTbloperatordetails.DepartmentId = 0;
                            }
                            if (item.category != null)
                            {
                                var catId = db.UnitworkccsTblcategorydetails.Where(m => m.CategoryName == item.category).Select(m => m.CategoryId).FirstOrDefault();
                                UnitworkccsTbloperatordetails.CategoryId = catId;
                            }
                            else
                            {
                                UnitworkccsTbloperatordetails.CategoryId = 0;
                            }
                            if (item.business != null)
                            {
                                var businessId = db.UnitworkccsTblbusinessdetails.Where(m => m.BusinessName == item.business).Select(m => m.BusinessId).FirstOrDefault();
                                UnitworkccsTbloperatordetails.BusinessId = businessId;
                            }
                            else
                            {
                                UnitworkccsTbloperatordetails.BusinessId = 0;
                            }
                            if (item.role != null)
                            {
                                var roleId = db.UnitworkccsTblroles.Where(m => m.RoleName == item.role).Select(m => m.RoleId).FirstOrDefault();
                                UnitworkccsTbloperatordetails.RoleId = roleId;
                            }
                            else
                            {
                                UnitworkccsTbloperatordetails.RoleId = 0;
                            }
                            if (item.subCell != null)
                            {
                                var subCellFinalId = db.UnitworkccsTblcell.Where(m => m.CellName == item.subCell).Select(m => m.CellId).FirstOrDefault();
                                UnitworkccsTbloperatordetails.SubCellId = subCellFinalId;
                            }
                            else
                            {
                                UnitworkccsTbloperatordetails.SubCellId = 0;
                            }
                            if (item.cell != null)
                            {
                                var CellFinalId = db.UnitworkccsTblshop.Where(m => m.ShopName == item.cell).Select(m => m.ShopId).FirstOrDefault();
                                UnitworkccsTbloperatordetails.CellId = CellFinalId;
                            }
                            else
                            {
                                UnitworkccsTbloperatordetails.CellId = 0;
                            }
                          
                            if (item.plant != null)
                            {
                                var plantId = db.UnitworkccsTblplant.Where(m => m.PlantCode == item.plant).Select(m => m.PlantId).FirstOrDefault();
                                UnitworkccsTbloperatordetails.PlantId = plantId;
                            }
                            else
                            {
                                UnitworkccsTbloperatordetails.PlantId = 0;
                            }
                            UnitworkccsTbloperatordetails.DirectOrIndirect = item.directOrIndirect;
                            UnitworkccsTbloperatordetails.ContactNo = item.contactNo;


                            if (!string.IsNullOrEmpty(item.dateOfBirth) )
                            {
                                UnitworkccsTbloperatordetails.DateOfBirth = Convert.ToDateTime(item.dateOfBirth);
                            }

                            else
                            {
                                UnitworkccsTbloperatordetails.DateOfBirth = null;
                            }


                            if (!string.IsNullOrEmpty(item.dateOfJoining) )
                            {
                                UnitworkccsTbloperatordetails.DateOfJoing = Convert.ToDateTime(item.dateOfJoining);
                            }
                            else 
                            {
                                UnitworkccsTbloperatordetails.DateOfJoing = null;
                            }


                            UnitworkccsTbloperatordetails.OpNo = item.employeeId;

                            UnitworkccsTbloperatordetails.OperatorName = item.employeeName;
                            UnitworkccsTbloperatordetails.UserName = Convert.ToString(item.employeeId);
                            UnitworkccsTbloperatordetails.Password = Convert.ToString(item.employeeId);
                            UnitworkccsTbloperatordetails.IsDeleted = 0;
                            UnitworkccsTbloperatordetails.CreatedOn = DateTime.Now;
                            db.UnitworkccsTbloperatordetails.Add(UnitworkccsTbloperatordetails);
                            db.SaveChanges();
                            obj.isStatus = true;
                            obj.response = ResourceResponse.AddedSuccessMessage;
                        }
                        else
                        {
                            if (item.role != null)
                            {
                                var roleId = db.UnitworkccsTblroles.Where(m => m.RoleName == item.role).Select(m => m.RoleId).FirstOrDefault();
                                check.RoleId = roleId;
                            }
                            if (item.department != null)
                            {
                                var deptId = db.UnitworkccsTbldepartmentdetails.Where(m => m.DepartmentName == item.department).Select(m => m.DepartmentId).FirstOrDefault();
                                check.DepartmentId = deptId;
                            }
                            if (item.category != null)
                            {
                                var catId = db.UnitworkccsTblcategorydetails.Where(m => m.CategoryName == item.category).Select(m => m.CategoryId).FirstOrDefault();
                                check.CategoryId = catId;
                            }
                            if (item.business != null)
                            {
                                var businessId = db.UnitworkccsTblbusinessdetails.Where(m => m.BusinessName == item.business).Select(m => m.BusinessId).FirstOrDefault();
                                check.BusinessId = businessId;
                            }
                            if (item.plant != null)
                            {
                                var plantId = db.UnitworkccsTblplant.Where(m => m.PlantCode == item.plant).Select(m => m.PlantId).FirstOrDefault();
                                check.PlantId = plantId;
                            }
                            if (item.subCell != null)
                            {
                                var subCellFinalId = db.UnitworkccsTblcell.Where(m => m.CellName == item.subCell).Select(m => m.CellId).FirstOrDefault();
                                check.SubCellId = subCellFinalId;
                            }
                            if (item.cell != null)
                            {
                                var CellFinalId = db.UnitworkccsTblshop.Where(m => m.ShopName == item.cell).Select(m => m.ShopId).FirstOrDefault();
                                check.CellId = CellFinalId;
                            }
                            check.ContactNo = item.contactNo;
                            check.DirectOrIndirect = item.directOrIndirect;


                            if (!string.IsNullOrEmpty(item.dateOfBirth))
                            {
                                check.DateOfBirth = Convert.ToDateTime(item.dateOfBirth);
                            }

                            else
                            {
                                check.DateOfBirth = null;
                            }


                            if (!string.IsNullOrEmpty(item.dateOfJoining))
                            {
                                check.DateOfJoing = Convert.ToDateTime(item.dateOfJoining);
                            }
                            else
                            {
                                check.DateOfJoing = null;
                            }


                           // check.DateOfBirth = Convert.ToDateTime(item.dateOfBirth);
                           // check.DateOfJoing = Convert.ToDateTime(item.dateOfJoining);
                            check.OpNo = item.employeeId;
                            check.OperatorName = item.employeeName;
                            check.UserName = Convert.ToString(item.employeeId);
                            check.Password = Convert.ToString(item.employeeId);
                            check.IsDeleted = 0;
                            check.ModifiedOn = DateTime.Now;
                            db.SaveChanges();
                            obj.isStatus = true;
                            obj.response = ResourceResponse.UpdatedSuccessMessage;
                        }
                    }
                    catch(Exception e)
                    {
                        log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
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

        public CommonResponse DownLoadOperatorsDetails()
        {
            CommonResponse obj = new CommonResponse();
            try
            {

                FileInfo templateFile = new FileInfo(@"C:\SRKS_ifacility\MainTemplate\Employees_Details.xlsx");

                ExcelPackage templatep = new ExcelPackage(templateFile);
                ExcelWorksheet Templatews = templatep.Workbook.Worksheets[0];
                //  ExcelWorksheet TemplateGraph = templatep.Workbook.Worksheets[1];


                //excel file save and  downloaded link



                string ImageUrlSave = configuration.GetSection("AppSettings").GetSection("ImageUrlSave").Value;
                string ImageUrl = configuration.GetSection("AppSettings").GetSection("ImageUrl").Value;

                String FileDir = ImageUrlSave + "\\" + "Employees_Details_" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
                String retrivalPath = ImageUrl + "Employees_Details_" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";



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
                // int slno = 1;
                var GetUtilList = db.UnitworkccsTbloperatordetails.Where(m => m.IsDeleted == 0).ToList();

                if (GetUtilList.Count > 0)
                {
                    foreach (var MacRow in GetUtilList)
                    {
                        // worksheet.Cells["" + StartRow].Value = slno++;
                        worksheet.Cells["A" + StartRow].Value = MacRow.OperatorName;
                        worksheet.Cells["B" + StartRow].Value = MacRow.OpNo;
                        worksheet.Cells["C" + StartRow].Value = MacRow.ContactNo;
                        worksheet.Cells["D" + StartRow].Value = db.UnitworkccsTblplant.Where(m => m.PlantId == MacRow.PlantId).Select(m => m.PlantName).FirstOrDefault();
                        worksheet.Cells["E" + StartRow].Value = db.UnitworkccsTblshop.Where(m => m.ShopId == MacRow.CellId).Select(m => m.ShopName).FirstOrDefault();
                        worksheet.Cells["F" + StartRow].Value = db.UnitworkccsTblcell.Where(m => m.CellId == MacRow.SubCellId).Select(m => m.CellName).FirstOrDefault();
                        worksheet.Cells["G" + StartRow].Value = db.UnitworkccsTblroles.Where(m => m.RoleId == MacRow.RoleId).Select(m => m.RoleName).FirstOrDefault();
                        worksheet.Cells["H" + StartRow].Value = db.UnitworkccsTblcategorydetails.Where(m => m.CategoryId == MacRow.CategoryId).Select(m => m.CategoryName).FirstOrDefault();
                        worksheet.Cells["I" + StartRow].Value = db.UnitworkccsTblbusinessdetails.Where(m => m.BusinessId == MacRow.BusinessId).Select(m => m.BusinessName).FirstOrDefault();
                        worksheet.Cells["J" + StartRow].Value = db.UnitworkccsTbldepartmentdetails.Where(m => m.DepartmentId == MacRow.DepartmentId).Select(m => m.DepartmentName).FirstOrDefault();
                        worksheet.Cells["K" + StartRow].Value = MacRow.DirectOrIndirect;
                        //  worksheet.Cells["M" + StartRow].Value = ;


                        if (MacRow.DateOfBirth == null)
                        {
                            worksheet.Cells["L" + StartRow].Value = "";
                        }
                        else
                        {
                            DateTime dtb = (DateTime)MacRow.DateOfBirth;
                            string dd = dtb.ToString("yyyy-MM-dd");
                            worksheet.Cells["L" + StartRow].Value = dd;
                        }
                        if (MacRow.DateOfJoing == null)
                        {
                            worksheet.Cells["M" + StartRow].Value = "";
                        }
                        else
                        {
                            DateTime dtb1 = (DateTime)MacRow.DateOfJoing;
                            string dd1 = dtb1.ToString("yyyy-MM-dd");
                            worksheet.Cells["M" + StartRow].Value = dd1;
                        }




                        StartRow++;
                    }
                }




                p.Save();

                //Downloding Excel
                //string path1 = System.IO.Path.Combine(FileDir, "OEE_Report" + Convert.ToDateTime(ToDate).ToString("yyyy-MM-dd") + ".xlsx");


                //  DownloadUtilReport(path1, "OEE_Report", ToDate.ToString());


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


//old code

//public CommonResponse UploadOperators(List<OperatorCustom> data)
//{
//    CommonResponse obj = new CommonResponse();
//    try
//    {
//        string connectionString1 = Path.Combine(appSettings.DefaultConnection);
//        using (SqlConnection sqlConn = new SqlConnection(connectionString1))
//        {
//            string sql = "delete from [unitworksccs].[unitworkccs].[UnitworkccsTbloperatordetails] where roleId != 20";
//            using (SqlCommand sqlCmd = new SqlCommand(sql, sqlConn))
//            {
//                sqlConn.Open();
//                sqlCmd.ExecuteNonQuery();
//            }
//        }

//        foreach (var item in data)
//        {
//            var check = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == item.opId).FirstOrDefault();
//            if (check == null)
//            {
//                UnitworkccsTbloperatordetails UnitworkccsTbloperatordetails = new UnitworkccsTbloperatordetails();

//                if (item.role != null)
//                {
//                    var roleId = db.UnitworkccsTblroles.Where(m => m.RoleName == item.role).Select(m => m.RoleId).FirstOrDefault();
//                    UnitworkccsTbloperatordetails.RoleId = roleId;
//                }
//                else
//                {
//                    UnitworkccsTbloperatordetails.RoleId = 0;
//                }
//                UnitworkccsTbloperatordetails.Shift = item.shift;
//                if (item.subCell != null)
//                {
//                    var subCellFinalId = db.UnitworkccsTblcell.Where(m => m.CellName == item.subCell).Select(m => m.CellId).FirstOrDefault();
//                    UnitworkccsTbloperatordetails.SubCellId = subCellFinalId;
//                }
//                else
//                {
//                    UnitworkccsTbloperatordetails.SubCellId = 0;
//                }

//                if (item.cell != null)
//                {
//                    var CellFinalId = db.UnitworkccsTblshop.Where(m => m.ShopName == item.cell).Select(m => m.ShopId).FirstOrDefault();
//                    UnitworkccsTbloperatordetails.CellId = CellFinalId;
//                }
//                else
//                {
//                    UnitworkccsTbloperatordetails.CellId = 0;
//                }

//                if (item.category != null)
//                {
//                    var categoryId = db.TblCategoryMaster.Where(m => m.CategoryName == item.category).Select(m => m.CategoryId).FirstOrDefault();
//                    UnitworkccsTbloperatordetails.CategoryId = categoryId;
//                }
//                else
//                {
//                    UnitworkccsTbloperatordetails.CategoryId = 0;
//                }

//                if(item.plant != null)
//                {
//                    var plantId = db.UnitworkccsTblplant.Where(m => m.PlantCode == item.plant).Select(m => m.PlantId).FirstOrDefault();
//                    UnitworkccsTbloperatordetails.PlantId = plantId;
//                }
//                else
//                {
//                    UnitworkccsTbloperatordetails.PlantId = 0;
//                }

//                if (item.machineName != null)
//                {
//                    string[] machineNames = item.machineName.Split(',');
//                    foreach (var items in machineNames)
//                    {
//                        var dbCheck = db.Tblmachinedetails.Where(m => m.MachineName == items).Select(m => m.MachineId).FirstOrDefault();
//                        #region 
//                        UnitworkccsTbloperatordetails.MachineIds = UnitworkccsTbloperatordetails.MachineIds + "," + dbCheck + ",";
//                        UnitworkccsTbloperatordetails.MachineIds = UnitworkccsTbloperatordetails.MachineIds.TrimEnd(',');
//                        UnitworkccsTbloperatordetails.MachineIds = UnitworkccsTbloperatordetails.MachineIds.TrimStart(',');
//                        #endregion
//                    }
//                }
//                else
//                {
//                    UnitworkccsTbloperatordetails.MachineIds = " ";
//                }
//                UnitworkccsTbloperatordetails.ContactNo = item.contactNo;
//                UnitworkccsTbloperatordetails.OpNo = item.opNo;
//                UnitworkccsTbloperatordetails.OperatorName = item.employeeName;
//                UnitworkccsTbloperatordetails.UserName = Convert.ToString(item.opNo);
//                UnitworkccsTbloperatordetails.Password = Convert.ToString(item.opNo);
//                UnitworkccsTbloperatordetails.IsDeleted = 0;
//                UnitworkccsTbloperatordetails.CreatedOn = DateTime.Now;
//                db.UnitworkccsTbloperatordetails.Add(UnitworkccsTbloperatordetails);
//                db.SaveChanges();
//                obj.isStatus = true;
//                obj.response = ResourceResponse.AddedSuccessMessage;
//            }
//            else
//            {
//                if (item.role != null)
//                {
//                    var roleId = db.UnitworkccsTblroles.Where(m => m.RoleName == item.role).Select(m => m.RoleId).FirstOrDefault();
//                    check.RoleId = roleId;
//                }

//                check.Shift = item.shift;
//                if (item.subCell != null)
//                {
//                    var subCellFinalId = db.UnitworkccsTblcell.Where(m => m.CellName == item.subCell).Select(m => m.CellId).FirstOrDefault();
//                    check.SubCellId = subCellFinalId;
//                }

//                if (item.cell != null)
//                {
//                    var CellFinalId = db.UnitworkccsTblshop.Where(m => m.ShopName == item.cell).Select(m => m.ShopId).FirstOrDefault();
//                    check.CellId = CellFinalId;
//                }

//                if (item.category != null)
//                {
//                    var categoryId = db.TblCategoryMaster.Where(m => m.CategoryName == item.category).Select(m => m.CategoryId).FirstOrDefault();
//                    check.CategoryId = categoryId;
//                }

//                if (item.machineName != null)
//                {
//                    string[] machineNames = item.machineName.Split(',');
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

//                check.ContactNo = item.contactNo;
//                check.OpNo = item.opNo;
//                check.OperatorName = item.employeeName;
//                check.UserName = Convert.ToString(item.opNo);
//                check.Password = Convert.ToString(item.opNo);
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
//        obj.isStatus = false;
//        obj.response = ResourceResponse.FailureMessage;
//    }
//    return obj;
//}

//

//public CommonResponse AddUpdateOperator(AddUpdateOperator data)
//{
//    CommonResponse obj = new CommonResponse();
//    try
//    {
//        var check = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == data.opId).FirstOrDefault();
//        if (check == null)
//        {
//            UnitworkccsTbloperatordetails UnitworkccsTbloperatordetails = new UnitworkccsTbloperatordetails();
//            UnitworkccsTbloperatordetails.DepartmentId = data.departmentId;
//            UnitworkccsTbloperatordetails.CategoryId = data.categoryId;
//            UnitworkccsTbloperatordetails.BusinessId = data.businessId;
//            UnitworkccsTbloperatordetails.RoleId = data.roleId;
//            //   UnitworkccsTbloperatordetails.Shift = data.shift;
//            UnitworkccsTbloperatordetails.PlantId = data.plantId;
//            // UnitworkccsTbloperatordetails.Location = data.plantLocation;
//            UnitworkccsTbloperatordetails.ContactNo = data.conatctNo;
//            UnitworkccsTbloperatordetails.OperatorEmailId = data.emailId;
//            UnitworkccsTbloperatordetails.SubCellId = data.subCellId;
//            UnitworkccsTbloperatordetails.CellId = data.cellId;
//            // UnitworkccsTbloperatordetails.CategoryId = data.categoryId;
//            //   UnitworkccsTbloperatordetails.MachineIds = data.machineIds;

//            UnitworkccsTbloperatordetails.DirectOrIndirect = data.directOrIndirect;
//            UnitworkccsTbloperatordetails.OpNo = data.opNo;
//            UnitworkccsTbloperatordetails.OperatorName = data.employeeName;

//            UnitworkccsTbloperatordetails.UserName = Convert.ToString(data.opNo);
//            UnitworkccsTbloperatordetails.Password = Convert.ToString(data.opNo);
//            UnitworkccsTbloperatordetails.DateOfBirth = Convert.ToDateTime(data.dateOfBirth);
//            UnitworkccsTbloperatordetails.DateOfJoing = Convert.ToDateTime(data.dateOfJoining);
//            UnitworkccsTbloperatordetails.PhotoId = data.photoId;
//            UnitworkccsTbloperatordetails.IsDeleted = 0;
//            UnitworkccsTbloperatordetails.CreatedOn = DateTime.Now;
//            db.UnitworkccsTbloperatordetails.Add(UnitworkccsTbloperatordetails);
//            db.SaveChanges();
//            obj.isStatus = true;
//            obj.response = ResourceResponse.AddedSuccessMessage;
//        }
//        else
//        {

//            check.DepartmentId = data.departmentId;
//            check.BusinessId = data.businessId;
//            check.CategoryId = data.categoryId;
//            check.RoleId = data.roleId;
//            //  check.Shift = data.shift;
//            check.PlantId = data.plantId;
//            // check.Location = data.plantLocation;

//            check.ContactNo = data.conatctNo;
//            check.OperatorEmailId = data.emailId;
//            check.DirectOrIndirect = data.directOrIndirect;
//            check.DateOfBirth = Convert.ToDateTime(data.dateOfBirth);
//            check.DateOfJoing = Convert.ToDateTime(data.dateOfJoining);
//            check.PhotoId = data.photoId;
//            check.SubCellId = data.subCellId;
//            check.CellId = data.cellId;

//            // check.MachineIds = data.machineIds;
//            check.OpNo = data.opNo;
//            check.OperatorName = data.employeeName;
//            check.UserName = Convert.ToString(data.opNo);
//            check.Password = Convert.ToString(data.opNo);
//            check.IsDeleted = 0;
//            check.ModifiedOn = DateTime.Now;
//            db.SaveChanges();
//            obj.isStatus = true;
//            obj.response = ResourceResponse.UpdatedSuccessMessage;
//        }
//    }
//    catch (Exception e)
//    {
//        obj.isStatus = false;
//        obj.response = ResourceResponse.FailureMessage;
//    }
//    return obj;
//}

///// <summary>
///// View Multiple operator
///// </summary>
///// <returns></returns>
//public CommonResponse ViewMultipleOperator()
//{
//    CommonResponse obj = new CommonResponse();
//    try
//    {
//        var check = (from wf in db.UnitworkccsTbloperatordetails
//                     where wf.IsDeleted == 0
//                     select new
//                     {
//                         opId = wf.OpId,
//                         departmentId = wf.DepartmentId,
//                         departmentName = db.UnitworkccsTbldepartmentdetails.Where(m => m.DepartmentId == wf.DepartmentId).Select(m => m.DepartmentName).FirstOrDefault(),

//                         businessId = wf.BusinessId,
//                         businessName = db.UnitworkccsTblbusinessdetails.Where(m => m.BusinessId == wf.BusinessId).Select(m => m.BusinessName).FirstOrDefault(),
//                         categoryName = db.UnitworkccsTblcategorydetails.Where(m => m.CategoryId == wf.CategoryId).Select(m => m.CategoryName).FirstOrDefault(),
//                         categoryId = wf.CategoryId,

//                         plantId = wf.PlantId,
//                         plantName = db.UnitworkccsTblplant.Where(m => m.PlantId == wf.PlantId).Select(m => m.PlantName).FirstOrDefault(),
//                         operatorName = wf.OperatorName,
//                         opNo = wf.OpNo,
//                         roleName = db.UnitworkccsTblroles.Where(m => m.RoleId == wf.RoleId).Select(m => m.RoleName).FirstOrDefault(),
//                         roleId = wf.RoleId,
//                         //   shiftName = wf.Shift,

//                         photoId = wf.PhotoId,
//                         //  plantLocation = wf.Location,
//                         directOrIndirect = wf.DirectOrIndirect,
//                         dateOfbirth = wf.DateOfBirth,
//                         dateOfjoing = wf.DateOfJoing,
//                         cellName = db.UnitworkccsTblshop.Where(m => m.ShopId == wf.CellId).Select(m => m.ShopName).FirstOrDefault(),
//                         cellId = wf.CellId,
//                         SubCellName = db.UnitworkccsTblcell.Where(m => m.CellId == wf.SubCellId).Select(m => m.CellName).FirstOrDefault(),
//                         subCellId = wf.SubCellId,
//                         machineId = wf.MachineIds,
//                         contactNo = wf.ContactNo,
//                         email = wf.OperatorEmailId

//                     }).ToList();
//        if (check.Count > 0)
//        {
//            List<OperatorDetails> operatorDetailsList = new List<OperatorDetails>();
//            foreach (var item in check)
//            {
//                var pictureuploaderdet = db.DocumentUploaderMaster.Where(m => m.DocumnetUploaderId == item.photoId).FirstOrDefault();
//                if (pictureuploaderdet != null)
//                {

//                    OperatorDetails operatorDetails = new OperatorDetails();
//                    operatorDetails.opId = item.opId;
//                    operatorDetails.categoryId = item.categoryId;
//                    operatorDetails.categoryName = item.categoryName;
//                    operatorDetails.cellId = item.cellId;
//                    operatorDetails.subCellId = item.subCellId;
//                    operatorDetails.cellName = item.cellName;
//                    operatorDetails.subCellName = item.SubCellName;
//                    // operatorDetails.shift = item.shiftName;
//                    operatorDetails.roleId = item.roleId;
//                    operatorDetails.roleName = item.roleName;
//                    operatorDetails.contactNo = item.contactNo;
//                    operatorDetails.employeeName = item.operatorName;
//                    DateTime dob = (DateTime)item.dateOfbirth;
//                    operatorDetails.dateOfBirth = dob.ToString("yyyy-MM-dd");
//                    DateTime doj = (DateTime)item.dateOfjoing;
//                    operatorDetails.dateOfJoining = doj.ToString("yyyy-MM-dd");
//                    operatorDetails.opNo = item.opNo;
//                    operatorDetails.plantId = item.plantId;
//                    operatorDetails.plantName = item.plantName;
//                    operatorDetails.departmentId = (int)item.departmentId;
//                    operatorDetails.departmentName = item.departmentName;
//                    operatorDetails.plantName = item.plantName;
//                    //  operatorDetails.location = item.plantLocation;
//                    operatorDetails.businessId = (int)item.businessId;
//                    operatorDetails.businessName = item.businessName;
//                    operatorDetails.directOrIndirect = item.directOrIndirect;
//                    operatorDetails.photoId = pictureuploaderdet.DocumnetUploaderId;
//                    operatorDetails.photoUrl = appSettings.ImageUrl + pictureuploaderdet.FileName;

//                    //if (item.machineId != null)
//                    //{
//                    //    List<int> machineIds = new List<int>();
//                    //    try
//                    //    {
//                    //        machineIds = item.machineId.Split(',').Select(x => int.Parse(x.Trim())).ToList();
//                    //    }
//                    //    catch (Exception ex)
//                    //    { }

//                    //    List<MachineDetails1> machineDetailsList = new List<MachineDetails1>();
//                    //    foreach (var ids in machineIds)
//                    //    {
//                    //        var dbCheck = db.Tblmachinedetails.Where(m => m.MachineId == ids).FirstOrDefault();
//                    //        if (dbCheck != null)
//                    //        {
//                    //            MachineDetails1 machineDetails = new MachineDetails1();
//                    //            machineDetails.machineid = dbCheck.MachineId;
//                    //            machineDetails.machinename = dbCheck.MachineName;
//                    //            machineDetailsList.Add(machineDetails);
//                    //        }
//                    //    }
//                    //    operatorDetails.machineIds = machineDetailsList;
//                    //}
//                    operatorDetailsList.Add(operatorDetails);
//                }
//            }
//            obj.isStatus = true;
//            obj.response = operatorDetailsList;
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

///// <summary>
///// View Multiple Operator By Id
///// </summary>
///// <param name="opId"></param>
///// <returns></returns>
//public CommonResponse ViewMultipleOperatorById(int opId)
//{
//    CommonResponse obj = new CommonResponse();
//    try
//    {
//        var item = (from wf in db.UnitworkccsTbloperatordetails
//                    where wf.IsDeleted == 0 && wf.OpId == opId
//                    select new
//                    {
//                        opId = wf.OpId,
//                        departmentId = wf.DepartmentId,
//                        departmentName = db.UnitworkccsTbldepartmentdetails.Where(m => m.DepartmentId == wf.DepartmentId).Select(m => m.DepartmentName).FirstOrDefault(),

//                        businessId = wf.BusinessId,
//                        businessName = db.UnitworkccsTblbusinessdetails.Where(m => m.BusinessId == wf.BusinessId).Select(m => m.BusinessName).FirstOrDefault(),
//                        categoryName = db.UnitworkccsTblcategorydetails.Where(m => m.CategoryId == wf.CategoryId).Select(m => m.CategoryName).FirstOrDefault(),
//                        categoryId = wf.CategoryId,

//                        plantId = wf.PlantId,
//                        plantName = db.UnitworkccsTblplant.Where(m => m.PlantId == wf.PlantId).Select(m => m.PlantName).FirstOrDefault(),
//                        operatorName = wf.OperatorName,
//                        opNo = wf.OpNo,
//                        roleName = db.UnitworkccsTblroles.Where(m => m.RoleId == wf.RoleId).Select(m => m.RoleName).FirstOrDefault(),
//                        roleId = wf.RoleId,
//                        //  shiftName = wf.Shift,

//                        photoId = wf.PhotoId,
//                        //   plantLocation = wf.Location,
//                        directOrIndirect = wf.DirectOrIndirect,
//                        dateOfbirth = wf.DateOfBirth,
//                        dateOfjoing = wf.DateOfJoing,
//                        cellName = db.UnitworkccsTblshop.Where(m => m.ShopId == wf.CellId).Select(m => m.ShopName).FirstOrDefault(),
//                        cellId = wf.CellId,
//                        SubCellName = db.UnitworkccsTblcell.Where(m => m.CellId == wf.SubCellId).Select(m => m.CellName).FirstOrDefault(),
//                        subCellId = wf.SubCellId,
//                        machineId = wf.MachineIds,
//                        contactNo = wf.ContactNo,
//                        email = wf.OperatorEmailId


//                    }).FirstOrDefault();

//        if (item != null)
//        {
//            List<OperatorDetails> operatorDetailsList = new List<OperatorDetails>();

//            var pictureuploaderdet = db.DocumentUploaderMaster.Where(m => m.DocumnetUploaderId == item.photoId).FirstOrDefault();
//            if (pictureuploaderdet != null)
//            {

//                OperatorDetails operatorDetails = new OperatorDetails();
//                operatorDetails.opId = item.opId;
//                operatorDetails.categoryId = item.categoryId;
//                operatorDetails.categoryName = item.categoryName;
//                operatorDetails.cellId = item.cellId;
//                operatorDetails.subCellId = item.subCellId;
//                operatorDetails.cellName = item.cellName;
//                operatorDetails.subCellName = item.SubCellName;
//                //   operatorDetails.shift = item.shiftName;
//                operatorDetails.roleId = item.roleId;
//                operatorDetails.roleName = item.roleName;
//                operatorDetails.contactNo = item.contactNo;
//                operatorDetails.emailId = item.email;
//                operatorDetails.employeeName = item.operatorName;
//                DateTime dob = (DateTime)item.dateOfbirth;
//                operatorDetails.dateOfBirth = dob.ToString("yyyy-MM-dd");
//                DateTime doj = (DateTime)item.dateOfjoing;
//                operatorDetails.dateOfJoining = doj.ToString("yyyy-MM-dd");
//                operatorDetails.opNo = item.opNo;
//                operatorDetails.plantId = item.plantId;
//                operatorDetails.plantName = item.plantName;
//                operatorDetails.departmentId = (int)item.departmentId;
//                operatorDetails.departmentName = item.departmentName;
//                operatorDetails.plantName = item.plantName;
//                //  operatorDetails.location = item.plantLocation;
//                operatorDetails.businessId = (int)item.businessId;
//                operatorDetails.businessName = item.businessName;
//                operatorDetails.directOrIndirect = item.directOrIndirect;
//                operatorDetails.photoId = pictureuploaderdet.DocumnetUploaderId;
//                operatorDetails.photoUrl = appSettings.ImageUrl + pictureuploaderdet.FileName;

//                //if (item.machineId != null)
//                //{
//                //    List<int> machineIds = new List<int>();
//                //    try
//                //    {
//                //        machineIds = item.machineId.Split(',').Select(x => int.Parse(x.Trim())).ToList();
//                //    }
//                //    catch (Exception ex)
//                //    { }

//                //    List<MachineDetails1> machineDetailsList = new List<MachineDetails1>();
//                //    foreach (var ids in machineIds)
//                //    {
//                //        var dbCheck = db.Tblmachinedetails.Where(m => m.MachineId == ids).FirstOrDefault();
//                //        if (dbCheck != null)
//                //        {
//                //            MachineDetails1 machineDetails = new MachineDetails1();
//                //            machineDetails.machineid = dbCheck.MachineId;
//                //            machineDetails.machinename = dbCheck.MachineName;
//                //            machineDetailsList.Add(machineDetails);
//                //        }
//                //    }
//                //    operatorDetails.machineIds = machineDetailsList;
//                //}
//                operatorDetailsList.Add(operatorDetails);
//            }

//            obj.isStatus = true;
//            obj.response = operatorDetailsList;
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