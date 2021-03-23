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
                var dbCheck = db.UnitworkccsTblfgpartnodet.Where(m => m.FgPartId == fgPartId && m.MachineId == machineId).Select(m => m.FgPartNo).FirstOrDefault();

                //var partNo = db.TblPlanLinkageMaster.Where(m => m.PlanLinkageId == dbCheck).Select(m => m.FgPartNo).FirstOrDefault();
                if (dbCheck == null)
                {
                    var check = (from wf in db.UnitworkccsTblgeneraldefectcodes
                                 where wf.IsDeleted == 0
                                 select new
                                 {
                                     DefectCodeId = wf.GeneralDefectCodeId,
                                     DefectCodeName = wf.DefectCodeName + " - " + wf.DefectCodeDesc
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
                else
                {
                    var check = (from wf in db.UnitworkccsTblproductwisedefectcodes
                                 where wf.IsDeleted == 0 && wf.PartNo == dbCheck
                                 select new
                                 {
                                     DefectCodeId = wf.DefectCodeId,
                                     DefectCodeName = db.UnitworkccsTbldefectcodemaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeName).FirstOrDefault() + " - " + db.UnitworkccsTbldefectcodemaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeDesc).FirstOrDefault()
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
                addedResopnse addresopnce = new addedResopnse();


                string correctedDate = commonFunction.GetCorrectedDate();

                if (data.dmcCodeStatus == "Enable")
                {
                    if (data.actual > 1)
                    {
                        var check = db.UnitworkccsTblrejectiondetails.Where(m => m.QrCodeNo == data.qrCodeNo).FirstOrDefault();
                        if (check == null)
                        {
                            var dbCheck = db.UnitworkccsTblreworkdetails.Where(m => m.QrCodeNo == data.qrCodeNo).FirstOrDefault();
                            if (dbCheck == null)
                            {
                                UnitworkccsTblrejectiondetails UnitworkccsTblrejectiondetails = new UnitworkccsTblrejectiondetails();
                                UnitworkccsTblrejectiondetails.DefectCodeId = data.defectCodeId;
                                UnitworkccsTblrejectiondetails.DefectQty = 1;
                                UnitworkccsTblrejectiondetails.MachineId = data.machineId;
                                UnitworkccsTblrejectiondetails.OperatorId = data.operatorId;
                                UnitworkccsTblrejectiondetails.IsDeleted = 0;
                                UnitworkccsTblrejectiondetails.Shift = shift;
                                UnitworkccsTblrejectiondetails.FgPartId = data.fgPartId;
                                UnitworkccsTblrejectiondetails.CorrectedDate = correctedDate;
                                UnitworkccsTblrejectiondetails.CreatedOn = DateTime.Now;
                                UnitworkccsTblrejectiondetails.QrCodeNo = data.qrCodeNo;
                                UnitworkccsTblrejectiondetails.DmcCodeStatus = data.dmcCodeStatus;
                                UnitworkccsTblrejectiondetails.ReasonForRejection = data.reasonForRejection;
                                db.UnitworkccsTblrejectiondetails.Add(UnitworkccsTblrejectiondetails);
                                db.SaveChanges();
                                obj.isStatus = true;
                                // obj.response = ResourceResponse.AddedSuccessMessage;

                                var reLast = db.UnitworkccsTblrejectiondetails.Where(m => m.IsDeleted == 0).LastOrDefault();

                                var fgpartdet = db.UnitworkccsTblfgpartnodet.Where(m => m.FgPartId == data.fgPartId).FirstOrDefault();
                                var cellid = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == fgpartdet.FgPartNo).FirstOrDefault();

                                var cellname = db.UnitworkccsTblshop.Where(m => m.ShopId == cellid.CellFinalId).Select(m => m.ShopName).FirstOrDefault();
                                var subcellname = db.UnitworkccsTblcell.Where(m => m.CellId == cellid.SubCellFinalId).Select(m => m.CellName).FirstOrDefault();

                                var defectcode = db.UnitworkccsTbldefectcodemaster.Where(m => m.DefectCodeId == data.defectCodeId).FirstOrDefault();


                                var empno = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == fgpartdet.OperatorId).Select(m => m.OpNo).FirstOrDefault();


                                int? machineid = db.UnitworkccsTblfgpartnodet.Where(m => m.FgPartId == fgpartdet.FgPartId).Select(m => m.MachineId).FirstOrDefault();

                                var machinedet = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == (int)machineid).FirstOrDefault();

                                var plantcode = db.UnitworkccsTblplant.Where(m => m.PlantId == machinedet.PlantId).Select(m => m.PlantCode).FirstOrDefault();

                                var operatorname = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == fgpartdet.OperatorId).Select(m => m.OperatorName).FirstOrDefault();

                                addresopnce.cellId = (int)cellid.CellFinalId;
                                addresopnce.cellName = cellname;

                                addresopnce.subCellId = (int)cellid.SubCellFinalId;
                                addresopnce.subCellName = subcellname;

                                // addresopnce.date = Convert.ToString(fgpartdet.StartDate);

                                DateTime date1 = Convert.ToDateTime(fgpartdet.StartDate);
                                addresopnce.date = date1.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");

                                //  DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK")

                                addresopnce.defectCodeId = data.defectCodeId;

                                addresopnce.defectCode = defectcode.DefectCodeName;
                                addresopnce.defectDescription = defectcode.DefectCodeDesc;
                                addresopnce.employeeNo = (int)empno;
                                addresopnce.fgPartId = fgpartdet.FgPartId;
                                addresopnce.isRejectionOrRework = "Rejection";
                                addresopnce.machineId = (int)machineid;
                                string[] machinename = machinedet.MachineName.Split('_');
                                addresopnce.machineName = machinename[1];
                                addresopnce.operatorId = (int)fgpartdet.OperatorId;
                                addresopnce.operatorName = operatorname;
                                addresopnce.partDescription = fgpartdet.PartName;
                                addresopnce.partId = null;
                                addresopnce.partNumber = fgpartdet.FgPartNo;
                                addresopnce.partQrCode = data.qrCodeNo;
                                addresopnce.plantId = (int)machinedet.PlantId;
                                addresopnce.plantName = plantcode;
                                addresopnce.quantity = (int)reLast.DefectQty;
                                addresopnce.rejectionId = reLast.RejectionId;
                                addresopnce.reworkId = 0;
                                addresopnce.shift = fgpartdet.Shift;
                                addresopnce.updatedRejectionOrRework = null;
                                addresopnce.workorderNumber = fgpartdet.WorkOrderNo;
                                addresopnce.reasonForRejection = reLast.ReasonForRejection;
                                obj.response = addresopnce;
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
                        UnitworkccsTblrejectiondetails UnitworkccsTblrejectiondetails = new UnitworkccsTblrejectiondetails();
                        UnitworkccsTblrejectiondetails.DefectCodeId = data.defectCodeId;
                        UnitworkccsTblrejectiondetails.DefectQty = data.defectQty;
                        UnitworkccsTblrejectiondetails.MachineId = data.machineId;
                        UnitworkccsTblrejectiondetails.OperatorId = data.operatorId;
                        UnitworkccsTblrejectiondetails.IsDeleted = 0;
                        UnitworkccsTblrejectiondetails.Shift = shift;
                        UnitworkccsTblrejectiondetails.FgPartId = data.fgPartId;
                        UnitworkccsTblrejectiondetails.CorrectedDate = correctedDate;
                        UnitworkccsTblrejectiondetails.CreatedOn = DateTime.Now;
                        UnitworkccsTblrejectiondetails.DmcCodeStatus = data.dmcCodeStatus;
                        UnitworkccsTblrejectiondetails.ReasonForRejection = data.reasonForRejection;
                        db.UnitworkccsTblrejectiondetails.Add(UnitworkccsTblrejectiondetails);
                        db.SaveChanges();
                        obj.isStatus = true;
                        //   obj.response = ResourceResponse.AddedSuccessMessage;

                        var reLast = db.UnitworkccsTblrejectiondetails.Where(m => m.IsDeleted == 0).LastOrDefault();

                        var fgpartdet = db.UnitworkccsTblfgpartnodet.Where(m => m.FgPartId == data.fgPartId).FirstOrDefault();
                        var cellid = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == fgpartdet.FgPartNo).FirstOrDefault();

                        var cellname = db.UnitworkccsTblshop.Where(m => m.ShopId == cellid.CellFinalId).Select(m => m.ShopName).FirstOrDefault();
                        var subcellname = db.UnitworkccsTblcell.Where(m => m.CellId == cellid.SubCellFinalId).Select(m => m.CellName).FirstOrDefault();

                        var defectcode = db.UnitworkccsTbldefectcodemaster.Where(m => m.DefectCodeId == data.defectCodeId).FirstOrDefault();


                        var empno = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == fgpartdet.OperatorId).Select(m => m.OpNo).FirstOrDefault();


                        int? machineid = db.UnitworkccsTblfgpartnodet.Where(m => m.FgPartId == fgpartdet.FgPartId).Select(m => m.MachineId).FirstOrDefault();

                        var machinedet = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == (int)machineid).FirstOrDefault();

                        var plantcode = db.UnitworkccsTblplant.Where(m => m.PlantId == machinedet.PlantId).Select(m => m.PlantCode).FirstOrDefault();

                        var operatorname = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == fgpartdet.OperatorId).Select(m => m.OperatorName).FirstOrDefault();




                        addresopnce.cellId = (int)cellid.CellFinalId;
                        addresopnce.cellName = cellname;

                        addresopnce.subCellId = (int)cellid.SubCellFinalId;
                        addresopnce.subCellName = subcellname;
                        // addresopnce.date = Convert.ToString(fgpartdet.StartDate);

                        DateTime date1 = Convert.ToDateTime(fgpartdet.StartDate);
                        addresopnce.date = date1.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");

                        addresopnce.defectCodeId = data.defectCodeId;
                        addresopnce.defectCode = defectcode.DefectCodeName;
                        addresopnce.defectDescription = defectcode.DefectCodeDesc;
                        addresopnce.employeeNo = (int)empno;
                        addresopnce.fgPartId = fgpartdet.FgPartId;
                        addresopnce.isRejectionOrRework = "Rejection";
                        addresopnce.machineId = (int)machineid;
                        string[] machinename = machinedet.MachineName.Split('_');
                        addresopnce.machineName = machinename[1];
                        addresopnce.operatorId = (int)fgpartdet.OperatorId;

                        addresopnce.operatorName = operatorname;

                        addresopnce.partDescription = fgpartdet.PartName;

                        addresopnce.partId = null;
                        addresopnce.partNumber = fgpartdet.FgPartNo;

                        addresopnce.partQrCode = data.qrCodeNo;

                        addresopnce.plantId = (int)machinedet.PlantId;

                        addresopnce.plantName = plantcode;
                        addresopnce.quantity = (int)reLast.DefectQty;
                        addresopnce.rejectionId = reLast.RejectionId;
                        addresopnce.reworkId = 0;
                        addresopnce.shift = fgpartdet.Shift;
                        addresopnce.updatedRejectionOrRework = null;
                        addresopnce.workorderNumber = fgpartdet.WorkOrderNo;
                        addresopnce.reasonForRejection = reLast.ReasonForRejection;
                        obj.response = addresopnce;
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
                var check = db.UnitworkccsTblrejectiondetails.Where(m => m.RejectionId == rejectionId).FirstOrDefault();
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
                var check = (from wf in db.UnitworkccsTblrejectiondetails
                             where wf.MachineId == machineId && wf.FgPartId == fgPartId
                             select new
                             {
                                 RejectionId = wf.RejectionId,
                                 DefectCodeId = wf.DefectCodeId,
                                 //DefectCodeName = db.UnitworkccsTbldefectcodemaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeName).FirstOrDefault(),
                                 DefectQty = wf.DefectQty,
                                 //DefectDesc = db.UnitworkccsTbldefectcodemaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeDesc).FirstOrDefault(),
                                 DefectCode = db.UnitworkccsTbldefectcodemaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeName).FirstOrDefault() + " - " + db.UnitworkccsTbldefectcodemaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeDesc).FirstOrDefault(),
                                 QrCodeNo = wf.QrCodeNo,
                                 reasonForRejection = wf.ReasonForRejection
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

                addedResopnse addresopnce = new addedResopnse();

                if (data.dmcCodeStatus == "Enable")
                {
                    if (data.actual > 1)
                    {
                        var check = db.UnitworkccsTblreworkdetails.Where(m => m.QrCodeNo == data.qrCodeNo).FirstOrDefault();
                        if (check == null)
                        {
                            var dbCheck = db.UnitworkccsTblrejectiondetails.Where(m => m.QrCodeNo == data.qrCodeNo).FirstOrDefault();
                            if (dbCheck == null)
                            {
                                UnitworkccsTblreworkdetails UnitworkccsTblreworkdetails = new UnitworkccsTblreworkdetails();
                                UnitworkccsTblreworkdetails.DefectCodeId = data.defectCodeId;
                                UnitworkccsTblreworkdetails.DefectQty = 1;
                                UnitworkccsTblreworkdetails.MachineId = data.machineId;
                                UnitworkccsTblreworkdetails.OperatorId = data.operatorId;
                                UnitworkccsTblreworkdetails.IsDeleted = 0;
                                UnitworkccsTblreworkdetails.Shift = shift;
                                UnitworkccsTblreworkdetails.FgPartId = data.fgPartId;
                                UnitworkccsTblreworkdetails.CreatedOn = DateTime.Now;
                                UnitworkccsTblreworkdetails.CorrectedDate = correctedDate;
                                UnitworkccsTblreworkdetails.QrCodeNo = data.qrCodeNo;
                                UnitworkccsTblreworkdetails.DmcCodeStatus = data.dmcCodeStatus;
                                UnitworkccsTblreworkdetails.ReasonForRework = data.reasonForRework;
                                db.UnitworkccsTblreworkdetails.Add(UnitworkccsTblreworkdetails);
                                db.SaveChanges();
                                obj.isStatus = true;
                                //  obj.response = ResourceResponse.AddedSuccessMessage;


                                var reLast = db.UnitworkccsTblreworkdetails.Where(m => m.IsDeleted == 0).LastOrDefault();

                                var fgpartdet = db.UnitworkccsTblfgpartnodet.Where(m => m.FgPartId == data.fgPartId).FirstOrDefault();
                                var cellid = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == fgpartdet.FgPartNo).FirstOrDefault();

                                var cellname = db.UnitworkccsTblshop.Where(m => m.ShopId == cellid.CellFinalId).Select(m => m.ShopName).FirstOrDefault();
                                var subcellname = db.UnitworkccsTblcell.Where(m => m.CellId == cellid.SubCellFinalId).Select(m => m.CellName).FirstOrDefault();

                                var defectcode = db.UnitworkccsTbldefectcodemaster.Where(m => m.DefectCodeId == data.defectCodeId).FirstOrDefault();


                                var empno = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == fgpartdet.OperatorId).Select(m => m.OpNo).FirstOrDefault();


                                int? machineid = db.UnitworkccsTblfgpartnodet.Where(m => m.FgPartId == fgpartdet.FgPartId).Select(m => m.MachineId).FirstOrDefault();

                                var machinedet = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == (int)machineid).FirstOrDefault();

                                var plantcode = db.UnitworkccsTblplant.Where(m => m.PlantId == machinedet.PlantId).Select(m => m.PlantCode).FirstOrDefault();

                                var operatorname = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == fgpartdet.OperatorId).Select(m => m.OperatorName).FirstOrDefault();

                                addresopnce.cellId = (int)cellid.CellFinalId;
                                addresopnce.cellName = cellname;

                                addresopnce.subCellId = (int)cellid.SubCellFinalId;
                                addresopnce.subCellName = subcellname;
                                // addresopnce.date = Convert.ToString(fgpartdet.StartDate);
                                DateTime date1 = Convert.ToDateTime(fgpartdet.StartDate);
                                addresopnce.date = date1.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");


                                addresopnce.defectCodeId = data.defectCodeId;
                                addresopnce.defectCode = defectcode.DefectCodeName;
                                addresopnce.defectDescription = defectcode.DefectCodeDesc;
                                addresopnce.employeeNo = (int)empno;
                                addresopnce.fgPartId = fgpartdet.FgPartId;
                                addresopnce.isRejectionOrRework = "Rework";
                                addresopnce.machineId = (int)machineid;
                                string[] machinename = machinedet.MachineName.Split('_');
                                addresopnce.machineName = machinename[1];
                                addresopnce.operatorId = (int)fgpartdet.OperatorId;
                                addresopnce.operatorName = operatorname;
                                addresopnce.partDescription = fgpartdet.PartName;
                                addresopnce.partId = null;
                                addresopnce.partNumber = fgpartdet.FgPartNo;
                                addresopnce.partQrCode = data.qrCodeNo;
                                addresopnce.plantId = (int)machinedet.PlantId;
                                addresopnce.plantName = plantcode;
                                addresopnce.quantity = (int)reLast.DefectQty;
                                addresopnce.rejectionId = 0;
                                addresopnce.reworkId = reLast.ReworkId;
                                addresopnce.shift = fgpartdet.Shift;
                                addresopnce.updatedRejectionOrRework = null;
                                addresopnce.workorderNumber = fgpartdet.WorkOrderNo;
                                addresopnce.reasonForRework = reLast.ReasonForRework;
                                obj.response = addresopnce;

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
                        UnitworkccsTblreworkdetails UnitworkccsTblreworkdetails = new UnitworkccsTblreworkdetails();
                        UnitworkccsTblreworkdetails.DefectCodeId = data.defectCodeId;
                        UnitworkccsTblreworkdetails.DefectQty = data.defectQty;
                        UnitworkccsTblreworkdetails.MachineId = data.machineId;
                        UnitworkccsTblreworkdetails.OperatorId = data.operatorId;
                        UnitworkccsTblreworkdetails.IsDeleted = 0;
                        UnitworkccsTblreworkdetails.Shift = shift;
                        UnitworkccsTblreworkdetails.FgPartId = data.fgPartId;
                        UnitworkccsTblreworkdetails.CreatedOn = DateTime.Now;
                        UnitworkccsTblreworkdetails.CorrectedDate = correctedDate;
                        UnitworkccsTblreworkdetails.DmcCodeStatus = data.dmcCodeStatus;
                        UnitworkccsTblreworkdetails.ReasonForRework = data.reasonForRework;
                        db.UnitworkccsTblreworkdetails.Add(UnitworkccsTblreworkdetails);
                        db.SaveChanges();
                        obj.isStatus = true;
                        // obj.response = ResourceResponse.AddedSuccessMessage;

                        var reLast = db.UnitworkccsTblreworkdetails.Where(m => m.IsDeleted == 0).LastOrDefault();



                        var fgpartdet = db.UnitworkccsTblfgpartnodet.Where(m => m.FgPartId == data.fgPartId).FirstOrDefault();
                        var cellid = db.UnitworkccsTblfgandcellallocation.Where(m => m.PartNo == fgpartdet.FgPartNo).FirstOrDefault();

                        var cellname = db.UnitworkccsTblshop.Where(m => m.ShopId == cellid.CellFinalId).Select(m => m.ShopName).FirstOrDefault();
                        var subcellname = db.UnitworkccsTblcell.Where(m => m.CellId == cellid.SubCellFinalId).Select(m => m.CellName).FirstOrDefault();

                        var defectcode = db.UnitworkccsTbldefectcodemaster.Where(m => m.DefectCodeId == data.defectCodeId).FirstOrDefault();


                        var empno = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == fgpartdet.OperatorId).Select(m => m.OpNo).FirstOrDefault();


                        int? machineid = db.UnitworkccsTblfgpartnodet.Where(m => m.FgPartId == fgpartdet.FgPartId).Select(m => m.MachineId).FirstOrDefault();

                        var machinedet = db.UnitworkccsTblmachinedetails.Where(m => m.MachineId == (int)machineid).FirstOrDefault();

                        var plantcode = db.UnitworkccsTblplant.Where(m => m.PlantId == machinedet.PlantId).Select(m => m.PlantCode).FirstOrDefault();

                        var operatorname = db.UnitworkccsTbloperatordetails.Where(m => m.OpId == fgpartdet.OperatorId).Select(m => m.OperatorName).FirstOrDefault();

                        addresopnce.cellId = (int)cellid.CellFinalId;
                        addresopnce.cellName = cellname;
                        addresopnce.subCellId = (int)cellid.SubCellFinalId;
                        addresopnce.subCellName = subcellname;
                        //  addresopnce.date = Convert.ToString(fgpartdet.StartDate);

                        DateTime date1 = Convert.ToDateTime(fgpartdet.StartDate);
                        addresopnce.date = date1.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");

                        addresopnce.defectCodeId = data.defectCodeId;
                        addresopnce.defectCode = defectcode.DefectCodeName;
                        addresopnce.defectDescription = defectcode.DefectCodeDesc;
                        addresopnce.employeeNo = (int)empno;
                        addresopnce.fgPartId = fgpartdet.FgPartId;
                        addresopnce.isRejectionOrRework = "Rework";
                        addresopnce.machineId = (int)machineid;
                        string[] machinename = machinedet.MachineName.Split('_');
                        addresopnce.machineName = machinename[1];
                        addresopnce.operatorId = (int)fgpartdet.OperatorId;
                        addresopnce.operatorName = operatorname;
                        addresopnce.partDescription = fgpartdet.PartName;
                        addresopnce.partId = null;
                        addresopnce.partNumber = fgpartdet.FgPartNo;
                        addresopnce.partQrCode = data.qrCodeNo;
                        addresopnce.plantId = (int)machinedet.PlantId;
                        addresopnce.plantName = plantcode;
                        addresopnce.quantity = (int)reLast.DefectQty;
                        addresopnce.rejectionId = 0;
                        addresopnce.reworkId = reLast.ReworkId;
                        addresopnce.shift = fgpartdet.Shift;
                        addresopnce.updatedRejectionOrRework = null;
                        addresopnce.workorderNumber = fgpartdet.WorkOrderNo;
                        addresopnce.reasonForRework = reLast.ReasonForRework;
                        obj.response = addresopnce;
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
                var check = db.UnitworkccsTblreworkdetails.Where(m => m.ReworkId == reworkId).FirstOrDefault();
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
                var check = (from wf in db.UnitworkccsTblreworkdetails
                             where wf.MachineId == machineId && wf.FgPartId == fgPartId
                             select new
                             {
                                 ReworkId = wf.ReworkId,
                                 DefectCodeId = wf.DefectCodeId,
                                 DefectQty = wf.DefectQty,
                                 DefectCode = db.UnitworkccsTbldefectcodemaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeName).FirstOrDefault() + " - " + db.UnitworkccsTbldefectcodemaster.Where(m => m.DefectCodeId == wf.DefectCodeId).Select(m => m.DefectCodeDesc).FirstOrDefault(),
                                 QrCodeNo = wf.QrCodeNo,
                                 reasonForRework = wf.ReasonForRework
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
