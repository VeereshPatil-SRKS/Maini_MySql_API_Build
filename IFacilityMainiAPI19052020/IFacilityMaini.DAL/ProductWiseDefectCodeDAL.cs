using IFacilityMaini.DAL.Resource;
using IFacilityMaini.DBModels;
using IFacilityMaini.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.ProductWiseDefectCodeEntity;

namespace IFacilityMaini.DAL
{
    public class ProductWiseDefectCodeDAL : IProductWiseDefectCode
    {
        unitworksccsContext db = new unitworksccsContext();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ProductWiseDefectCodeDAL));
        public static IConfiguration configuration;

        public ProductWiseDefectCodeDAL(unitworksccsContext _db, IConfiguration _configuration)
        {
            db = _db;
            configuration = _configuration;
        }

        /// <summary>
        /// Add Update Product Wise Defect Code
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse AddUpdateProductWiseDefectCode(List<AddEditProuctWiseDefectCodes> data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                foreach (var item in data)
                {
                    var check = db.TblProductWiseDefectCode.Where(m => m.ProductWiseDefectCodeId == item.productWiseDefectCodeId && m.Trim == item.trim).FirstOrDefault();
                    if (check == null)
                    {
                        TblProductWiseDefectCode tblProductWiseDefectCode = new TblProductWiseDefectCode();
                        if (item.plantCode != null)
                        {
                            var plantId = db.Tblplant.Where(m => m.PlantCode == item.plantCode).Select(m => m.PlantId).FirstOrDefault();
                            tblProductWiseDefectCode.PlantId = plantId;
                        }
                        else
                        {
                            tblProductWiseDefectCode.PlantId = item.plantId;
                        }
                        tblProductWiseDefectCode.PartNo = item.partNo;
                        tblProductWiseDefectCode.PartName = item.partName;
                        tblProductWiseDefectCode.Trim = item.trim;

                        if (item.defectCode != null)
                        {
                            var defectIdCode = db.TblDefectCodeMaster.Where(m => m.DefectCodeName == item.defectCode).Select(m => m.DefectCodeId).FirstOrDefault();
                            tblProductWiseDefectCode.DefectCodeId = defectIdCode;
                        }
                        else
                        {
                            tblProductWiseDefectCode.DefectCodeId = item.defectCodeId;
                        }

                        tblProductWiseDefectCode.IsDeleted = 0;
                        tblProductWiseDefectCode.CreatedOn = DateTime.Now;
                        db.TblProductWiseDefectCode.Add(tblProductWiseDefectCode);
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

                        check.PartNo = item.partNo;
                        check.PartName = item.partName;
                        check.Trim = item.trim;
                        if (item.defectCode != null)
                        {
                            var defectIdCode = db.TblDefectCodeMaster.Where(m => m.DefectCodeName == item.defectCode).Select(m => m.DefectCodeId).FirstOrDefault();
                            check.DefectCodeId = defectIdCode;
                        }
                        else
                        {
                            check.DefectCodeId = item.defectCodeId;
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
        /// ViewMultipleProductWiseDefectCode
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleProductWiseDefectCode()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblProductWiseDefectCode
                             where wf.IsDeleted == 0
                             select new
                             {
                                 trim = wf.Trim,
                                 productWiseDefectCodeId = wf.ProductWiseDefectCodeId,
                                 plantName = db.Tblplant.Where(m => m.PlantId == wf.PlantId).Select(m => m.PlantCode).FirstOrDefault(),
                                 plantId = wf.PlantId,
                                 partNo = wf.PartNo,
                                 partName = wf.PartName,
                                 defectCode = db.TblDefectCodeMaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeName).FirstOrDefault(),
                                 defectCodeId = wf.DefectCodeId,
                                 defectDesc = db.TblDefectCodeMaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeDesc).FirstOrDefault()
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
        /// Delete Product Wise Defect Code
        /// </summary>
        /// <param name="productWiseDefectCodeId"></param>
        /// <returns></returns>
        public CommonResponse DeleteProductWiseDefectCode(int productWiseDefectCodeId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.TblProductWiseDefectCode.Where(m => m.ProductWiseDefectCodeId == productWiseDefectCodeId).FirstOrDefault();
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
                                 plantCode = wf.PlantCode
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
                                 partNo = wf.PartNo,
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
        /// ViewMultipleDefectCode
        /// </summary>
        /// <param name="partId"></param>
        /// <returns></returns>
        public CommonResponse ViewMultipleDefectCode()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblDefectCodeMaster
                             where wf.IsDeleted == 0
                             select new
                             {
                                 defectCodeId = wf.DefectCodeId,
                                 defectCode = wf.DefectCodeName,
                                 defectCodeDesc = wf.DefectCodeDesc
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
        /// Add Defect Code
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse AddDefectCode(List<AddDefectCodes> data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                foreach (var item in data)
                {
                    var check = db.TblDefectCodeMaster.Where(m => m.DefectCodeName == item.defectCodeName).FirstOrDefault();
                    if (check == null)
                    {
                        TblDefectCodeMaster tblDefectCodeMaster = new TblDefectCodeMaster();
                        tblDefectCodeMaster.DefectCodeName = item.defectCodeName;
                        tblDefectCodeMaster.DefectCodeDesc = item.defectCodeDesc;
                        tblDefectCodeMaster.IsDeleted = 0;
                        tblDefectCodeMaster.CreatedOn = DateTime.Now;
                        db.TblDefectCodeMaster.Add(tblDefectCodeMaster);
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;
                    }
                    else
                    {
                        check.DefectCodeName = item.defectCodeName;
                        check.DefectCodeDesc = item.defectCodeDesc;
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
    }
}
