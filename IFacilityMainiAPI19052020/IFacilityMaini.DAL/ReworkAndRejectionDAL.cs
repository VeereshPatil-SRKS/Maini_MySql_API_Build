using IFacilityMaini.DAL.Resource;
using IFacilityMaini.DBModels;
using IFacilityMaini.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.ReworkAndRejectionEntity;
using IFacilityMaini.DAL.App_Start;

namespace IFacilityMaini.DAL
{
    public class ReworkAndRejectionDAL : IReworkAndRejection
    {
        unitworksccsContext db = new unitworksccsContext();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ReworkAndRejectionDAL));
        public static IConfiguration configuration;

        public ReworkAndRejectionDAL(unitworksccsContext _db, IConfiguration _configuration)
        {
            db = _db;
            configuration = _configuration;
        }

        /// <summary>
        /// View Multiple Defect Code
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleDefectCode(int fgPartId, int machineId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var dbCheck = db.TblFgPartNoDet.Where(m => m.FgPartId == fgPartId && m.MachineId == machineId).Select(m => m.PlanLinkageId).FirstOrDefault();

                var partNo = db.TblPlanLinkageMaster.Where(m => m.PlanLinkageId == dbCheck).Select(m => m.FgPartNo).FirstOrDefault();

                var check = (from wf in db.TblProductWiseDefectCode
                             where wf.IsDeleted == 0 && wf.PartNo == partNo
                             select new
                             {
                                 DefectCodeId = wf.DefectCodeId,
                                 DefectCodeName = db.TblDefectCodeMaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeName).FirstOrDefault() + " - " + db.TblDefectCodeMaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeDesc).FirstOrDefault()
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
            catch (Exception ex)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Add Rejection Details
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse AddRejectionDetails(AddRejection data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                CommonFunction commonFunction = new CommonFunction();
                string shift = commonFunction.GetCurrentShift();
                string correctedDate = commonFunction.GetCorrectedDate();

                if (data.dmcCodeStatus == "Enable")
                {
                    if (data.actual > 1)
                    {
                        var check = db.TblRejectionDetails.Where(m => m.QrCodeNo == data.qrCodeNo).FirstOrDefault();
                        if (check == null)
                        {
                            var dbCheck = db.TblReworkDetails.Where(m => m.QrCodeNo == data.qrCodeNo).FirstOrDefault();
                            if (dbCheck == null)
                            {
                                TblRejectionDetails tblRejectionDetails = new TblRejectionDetails();
                                tblRejectionDetails.DefectCodeId = data.defectCodeId;
                                tblRejectionDetails.DefectQty = 1;
                                tblRejectionDetails.MachineId = data.machineId;
                                tblRejectionDetails.OperatorId = data.operatorId;
                                tblRejectionDetails.IsDeleted = 0;
                                tblRejectionDetails.Shift = shift;
                                tblRejectionDetails.FgPartId = data.fgPartId;
                                tblRejectionDetails.CorrectedDate = correctedDate;
                                tblRejectionDetails.CreatedOn = DateTime.Now;
                                tblRejectionDetails.QrCodeNo = data.qrCodeNo;
                                tblRejectionDetails.DmcCodeStatus = data.dmcCodeStatus;
                                db.TblRejectionDetails.Add(tblRejectionDetails);
                                db.SaveChanges();
                                obj.isStatus = true;
                                obj.response = ResourceResponse.AddedSuccessMessage;
                            }
                            else
                            {
                                obj.isStatus = false;
                                obj.response = "Qr Code already Added";
                            }
                        }
                        else
                        {
                            obj.isStatus = false;
                            obj.response = "Qr Code already Added";
                        }
                    }
                    else
                    {
                        obj.isStatus = false;
                        obj.response = "Please enter Defect Qty less than Actal value" + data.actual;
                    }
                }
                else
                {
                    if (data.actual > 1)
                    {
                        TblRejectionDetails tblRejectionDetails = new TblRejectionDetails();
                        tblRejectionDetails.DefectCodeId = data.defectCodeId;
                        tblRejectionDetails.DefectQty = data.defectQty;
                        tblRejectionDetails.MachineId = data.machineId;
                        tblRejectionDetails.OperatorId = data.operatorId;
                        tblRejectionDetails.IsDeleted = 0;
                        tblRejectionDetails.Shift = shift;
                        tblRejectionDetails.FgPartId = data.fgPartId;
                        tblRejectionDetails.CorrectedDate = correctedDate;
                        tblRejectionDetails.CreatedOn = DateTime.Now;
                        tblRejectionDetails.DmcCodeStatus = data.dmcCodeStatus;
                        db.TblRejectionDetails.Add(tblRejectionDetails);
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;
                    }
                    else
                    {
                        obj.isStatus = false;
                        obj.response = "Please enter Defect Qty less than Actal value" + data.actual;
                    }
                }
            }
            catch (Exception ex)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Delete Rejection Details
        /// </summary>
        /// <param name="rejectionId"></param>
        /// <returns></returns>
        public CommonResponse DeleteRejectionDetails(int rejectionId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.TblRejectionDetails.Where(m => m.RejectionId == rejectionId).FirstOrDefault();
                if (check != null)
                {
                    db.Remove(check);
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.DeletedSuccessMessage;
                }
            }
            catch (Exception ex)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// View Rejection Details
        /// </summary>
        /// <param name="machineId"></param>
        /// <param name="fgPartId"></param>
        /// <returns></returns>
        public CommonResponse ViewRejectionDetails(int machineId, int fgPartId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblRejectionDetails
                             where wf.MachineId == machineId && wf.FgPartId == fgPartId
                             select new
                             {
                                 RejectionId = wf.RejectionId,
                                 DefectCodeId = wf.DefectCodeId,
                                 //DefectCodeName = db.TblDefectCodeMaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeName).FirstOrDefault(),
                                 DefectQty = wf.DefectQty,
                                 //DefectDesc = db.TblDefectCodeMaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeDesc).FirstOrDefault(),
                                 DefectCode = db.TblDefectCodeMaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeName).FirstOrDefault() + " - " + db.TblDefectCodeMaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeDesc).FirstOrDefault(),
                                 QrCodeNo = wf.QrCodeNo
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
            catch (Exception ex)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Add Rework Details
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse AddReworkDetails(AddRework data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                CommonFunction commonFunction = new CommonFunction();
                string shift = commonFunction.GetCurrentShift();
                string correctedDate = commonFunction.GetCorrectedDate();

                if (data.dmcCodeStatus == "Enable")
                {
                    if (data.actual > 1)
                    {
                        var check = db.TblReworkDetails.Where(m => m.QrCodeNo == data.qrCodeNo).FirstOrDefault();
                        if (check == null)
                        {
                            var dbCheck = db.TblRejectionDetails.Where(m => m.QrCodeNo == data.qrCodeNo).FirstOrDefault();
                            if (dbCheck == null)
                            {
                                TblReworkDetails tblReworkDetails = new TblReworkDetails();
                                tblReworkDetails.DefectCodeId = data.defectCodeId;
                                tblReworkDetails.DefectQty = 1;
                                tblReworkDetails.MachineId = data.machineId;
                                tblReworkDetails.OperatorId = data.operatorId;
                                tblReworkDetails.IsDeleted = 0;
                                tblReworkDetails.Shift = shift;
                                tblReworkDetails.FgPartId = data.fgPartId;
                                tblReworkDetails.CreatedOn = DateTime.Now;
                                tblReworkDetails.CorrectedDate = correctedDate;
                                tblReworkDetails.QrCodeNo = data.qrCodeNo;
                                tblReworkDetails.DmcCodeStatus = data.dmcCodeStatus;
                                db.TblReworkDetails.Add(tblReworkDetails);
                                db.SaveChanges();
                                obj.isStatus = true;
                                obj.response = ResourceResponse.AddedSuccessMessage;
                            }
                            else
                            {
                                obj.isStatus = false;
                                obj.response = "Qr Code already Added";
                            }
                        }
                        else
                        {
                            obj.isStatus = false;
                            obj.response = "Qr Code already Added";
                        }
                    }
                    else
                    {
                        obj.isStatus = false;
                        obj.response = "Please enter Defect Qty less than Actal value" + data.actual;
                    }
                }
                else
                {
                    if (data.actual > 1)
                    {
                        TblReworkDetails tblReworkDetails = new TblReworkDetails();
                        tblReworkDetails.DefectCodeId = data.defectCodeId;
                        tblReworkDetails.DefectQty = data.defectQty;
                        tblReworkDetails.MachineId = data.machineId;
                        tblReworkDetails.OperatorId = data.operatorId;
                        tblReworkDetails.IsDeleted = 0;
                        tblReworkDetails.Shift = shift;
                        tblReworkDetails.FgPartId = data.fgPartId;
                        tblReworkDetails.CreatedOn = DateTime.Now;
                        tblReworkDetails.CorrectedDate = correctedDate;
                        tblReworkDetails.DmcCodeStatus = data.dmcCodeStatus;
                        db.TblReworkDetails.Add(tblReworkDetails);
                        db.SaveChanges();
                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;
                    }
                    else
                    {
                        obj.isStatus = false;
                        obj.response = "Please enter Defect Qty less than Actal value" + data.actual;
                    }
                }
            }
            catch (Exception ex)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// Delete Rework Details
        /// </summary>
        /// <param name="reworkId"></param>
        /// <returns></returns>
        public CommonResponse DeleteReworkDetails(int reworkId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.TblReworkDetails.Where(m => m.ReworkId == reworkId).FirstOrDefault();
                if (check != null)
                {
                    db.Remove(check);
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.DeletedSuccessMessage;
                }
            }
            catch (Exception ex)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// View Rework Details
        /// </summary>
        /// <param name="machineId"></param>
        /// <param name="fgPartId"></param>
        /// <returns></returns>
        public CommonResponse ViewReworkDetails(int machineId, int fgPartId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.TblReworkDetails
                             where wf.MachineId == machineId && wf.FgPartId == fgPartId
                             select new
                             {
                                 ReworkId = wf.ReworkId,
                                 DefectCodeId = wf.DefectCodeId,
                                 DefectQty = wf.DefectQty,
                                 DefectCode = db.TblDefectCodeMaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeName).FirstOrDefault() + " - " + db.TblDefectCodeMaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeDesc).FirstOrDefault(),
                                 QrCodeNo = wf.QrCodeNo,
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
            catch (Exception ex)
            {
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }
    }
}
