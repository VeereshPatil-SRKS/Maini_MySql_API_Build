using IFacilityMaini.DAL.Helpers;
using IFacilityMaini.DAL.Resource;
using IFacilityMaini.DBModels;
using IFacilityMaini.DBModels.ToolPulse;
using IFacilityMaini.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.ToolLifeEntity;

namespace IFacilityMaini.DAL
{
    public class ToolLifeDAL : IToolLife
    {
        unitworksccsContext db = new unitworksccsContext();
        i_facility_tsalContext db2 = new i_facility_tsalContext();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(OperatorDashboardDAL));
        public static IConfiguration configuration;
        private readonly AppSettings appSettings;

        public ToolLifeDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings, i_facility_tsalContext _db2)
        {
            db = _db;
            configuration = _configuration;
            appSettings = _appSettings.Value;
            db2 = _db2;
        }

        /// <summary>
        /// Redirect The Page
        /// </summary>
        /// <param name="HostName"></param>
        /// <param name="IpAddress"></param>
        /// <returns></returns>
        public CommonResponse AddAndEditToolAndSocketDetails(TblToolAndSocketDetailsCustom data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.TblToolAndSocketDetails.Where(m => m.MachineId == data.machineId && m.SocketNo == data.socketNo && m.IsDeleted == 0).FirstOrDefault();
                if (check == null)
                {
                    var item = db2.TblIssuedReceived.Where(m => m.BarCodeNo == data.toolNumber && m.MachineId == data.machineId).FirstOrDefault();
                    if (item != null)
                    {
                        var toolDetails = db2.TblTools.Where(m => m.ToolName.Trim().Contains(item.ToolName.Trim())).FirstOrDefault();
                        if (toolDetails != null)
                        {
                            int stdToolLife = Convert.ToInt32(toolDetails.StandardToolLife);
                            TblToolAndSocketDetails tblToolAndSocket = new TblToolAndSocketDetails();
                            tblToolAndSocket.Qrcode = data.toolNumber;
                            tblToolAndSocket.ToolNumber = item.ToolName.Trim();
                            tblToolAndSocket.SocketNo = data.socketNo;
                            tblToolAndSocket.MachineId = data.machineId;
                            tblToolAndSocket.StandardToolLife = stdToolLife;
                            tblToolAndSocket.ActaulToolLife = 0;
                            tblToolAndSocket.ToolInsertedDateTime = DateTime.Now;
                            tblToolAndSocket.CreatedOn = DateTime.Now;
                            tblToolAndSocket.CreatedBy = 1;
                            tblToolAndSocket.IsDeleted = 0;
                            db.Add(tblToolAndSocket);
                            db.SaveChanges();
                        }
                    }

                    obj.isStatus = true;
                    obj.response = Resource.ResourceResponse.AddedSuccessMessage;
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
        /// GetToolLife
        /// </summary>
        /// <param name="socketNumber"></param>
        /// <param name="machineId"></param>
        /// <returns></returns>
        public CommonResponse GetToolLife(string socketNumber, int machineId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from m in db.TblToolAndSocketDetails
                             where m.MachineId == machineId && m.SocketNo == socketNumber && m.IsDeleted == 0
                             select new
                             {
                                 socketId = m.SocketId,
                                 toolNumber = m.ToolNumber,
                                 socketNo = m.SocketNo,
                                 machineId = m.MachineId,
                                 standardToolLife = m.StandardToolLife,
                                 actaulToolLife = m.ActaulToolLife,
                                 balance = m.StandardToolLife - m.ActaulToolLife,
                                 toolInsertedDateTime = m.ToolInsertedDateTime,
                                 qrcode = m.Qrcode
                             }).FirstOrDefault();


                if (check != null)
                {
                    TblToolAndSocket tblToolAndSocket = new TblToolAndSocket();
                    tblToolAndSocket.socketId = check.socketId ;
                    tblToolAndSocket.toolNumber = check.toolNumber;
                    tblToolAndSocket.socketNo = check.socketNo ;
                    tblToolAndSocket.machineId = check.machineId ;
                    tblToolAndSocket.standardToolLife = check.standardToolLife ;
                    string a = check.socketNo;
                    string b = string.Empty;
                    int val;

                    for (int i = 0; i < a.Length; i++)
                    {
                        if (Char.IsDigit(a[i]))
                            b += a[i];
                    }

                    if (b.Length > 0)
                        val = int.Parse(b);

                    var actualItem = db.Tbltoollifeoperator.Where(m => m.ToolNo == b && m.MachineId == check.machineId).OrderByDescending(m=>m.ToolLifeId).FirstOrDefault();
                    int actual = 0;
                    if (actualItem != null)
                    {
                        actual = actualItem.Toollifecounter;
                    }
                    
                    tblToolAndSocket.actaulToolLife = actual;
                    tblToolAndSocket.balance = check.standardToolLife - actual ;
                    tblToolAndSocket.qrcode = check.qrcode ;
                    obj.isStatus = true;
                    obj.response = tblToolAndSocket;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = Resource.ResourceResponse.NoItemsFound;
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
        /// DeleteToolFromSocket
        /// </summary>
        /// <param name="socketNumber"></param>
        /// <param name="machineId"></param>
        /// <returns></returns>
        public CommonResponse DeleteToolFromSocket(string socketNumber, int machineId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from m in db.TblToolAndSocketDetails
                             where m.MachineId == machineId && m.SocketNo == socketNumber && m.IsDeleted == 0
                             select m).FirstOrDefault();
                if (check != null)
                {
                    check.IsDeleted = 1;
                    check.ToolRemovedDateTime = DateTime.Now;
                    check.ModifiedBy = 1;
                    check.ModifiedOn = DateTime.Now;
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = Resource.ResourceResponse.DeletedSuccessMessage;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = Resource.ResourceResponse.NoItemsFound;
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
        /// ScanToolData
        /// </summary>
        /// <param name="qrCode"></param>
        /// <param name="machineId"></param>
        /// <returns></returns>
        public CommonResponse ScanToolData(string qrCode, int machineId,string fgCode)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var item = db2.TblIssuedReceived.Where(m => m.BarCodeNo == qrCode && m.MachineId == machineId && m.OpAcceptanceFlag==1 && m.IsReturn == 2).FirstOrDefault();
                if (item != null)
                {
                    var toolPulseIssuedPartNo = db2.Tblparts.Where(m => m.PartId == item.ProductId).FirstOrDefault();
                    var Fgcode = db.Tblparts.Where(m => m.Fgcode == toolPulseIssuedPartNo.PartNo).Select(m => m.Fgcode).FirstOrDefault();
                    if (fgCode == Fgcode)
                    {
                        obj.isStatus = true;
                        obj.response = "Please Save the Tool";
                    }
                    else
                    {
                        obj.isStatus = false;
                        obj.response = "Tool Not Issued to use for this part: "+Fgcode;
                    }
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = "Tool Not Issued to use in this machine";
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
    }
}
