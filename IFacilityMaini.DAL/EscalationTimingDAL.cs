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
using static IFacilityMaini.EntityModels.EscalationTimingEntity;

namespace IFacilityMaini.DAL
{
    public class EscalationTimingDAL : IEscalationTiming
    {
        unitworksccsContext db = new unitworksccsContext();
        private readonly AppSettings appSettings;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(EscalationTimingDAL));
        public static IConfiguration configuration;

        public EscalationTimingDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings)
        {
            db = _db;
            configuration = _configuration;
            appSettings = _appSettings.Value;
        }


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



        public CommonResponse AddAndUpdateEscalationTiming(AddUpdateEscalationTm data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTblescalationtiming.Where(m => m.IsDeleted == 0 && (m.CategoryId == data.categoryId || m.Id == data.id)).FirstOrDefault();
                if (check == null)
                {
                    try
                    {
                        UnitworkccsTblescalationtiming tblEscDet = new UnitworkccsTblescalationtiming();
                        tblEscDet.CategoryId = data.categoryId;
                        tblEscDet.CategoryName = db.UnitworkccsTblcategorymaster.Where(m => m.CategoryId == data.categoryId).Select(m => m.CategoryName).FirstOrDefault();

                        if (data.firstEsc == "Immediate")
                        {
                            tblEscDet.FirstEscalation = "0";

                        }


                        if (data.secondEsc != null)
                        {
                            string[] val2 = data.secondEsc.Split(' ');

                            tblEscDet.SecondEscalation = val2[0];

                        }
                        if (data.thirdEsc != null)
                        {

                            string[] val3 = data.thirdEsc.Split(' ');
                            tblEscDet.ThirdEscalation = val3[0];

                        }
                        if (data.fourthEsc != null)
                        {
                            string[] val4 = data.fourthEsc.Split(' ');
                            tblEscDet.FourthEscalation = val4[0];

                        }

                        tblEscDet.CreatedOn = DateTime.Now;
                        tblEscDet.CreatedBy = 1;
                        tblEscDet.IsDeleted = 0;

                        db.UnitworkccsTblescalationtiming.Add(tblEscDet);
                        db.SaveChanges();

                        obj.isStatus = true;
                        obj.response = ResourceResponse.AddedSuccessMessage;
                    }
                    catch (Exception e)
                    {
                        log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                        obj.isStatus = false;
                        obj.response = ResourceResponse.FailureMessage;
                    }
                }
                else
                {
                    // check.CategoryId = data.categoryId;
                    // check.CategoryName = db.TblCategoryMaster.Where(m => m.CategoryId == data.categoryId).Select(m => m.CategoryName).FirstOrDefault();

                    if (data.firstEsc == "Immediate")
                    {
                        check.FirstEscalation = "0";

                    }
                    if (data.secondEsc != null)
                    {
                        string[] val2 = data.secondEsc.Split(' ');

                        check.SecondEscalation = val2[0];

                    }
                    if (data.thirdEsc != null)
                    {

                        string[] val3 = data.thirdEsc.Split(' ');
                        check.ThirdEscalation = val3[0];

                    }
                    if (data.fourthEsc != null)
                    {
                        string[] val4 = data.fourthEsc.Split(' ');
                        check.FourthEscalation = val4[0];

                    }


                    check.ModifiedOn = DateTime.Now;
                    check.ModifiedBy = 2;
                    check.IsDeleted = 0;
                    db.SaveChanges();

                    obj.isStatus = true;
                    obj.response = ResourceResponse.UpdatedSuccessMessage;
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


        public CommonResponse ViewEscalationTiming()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblescalationtiming
                             where wf.IsDeleted == 0
                             select new
                             {
                                 id = wf.Id,
                                 categoryId = wf.CategoryId,
                                 categoryName = wf.CategoryName,

                                 firstEsc = wf.FirstEscalation != null ? "Immediate" : null,

                                 secondEsc = wf.SecondEscalation != null ? wf.SecondEscalation + " min" : null,
                                 thirdEsc = wf.ThirdEscalation != null ? wf.ThirdEscalation + " min" : null,
                                 fourthEsc = wf.FourthEscalation != null ? wf.FourthEscalation + " min" : null

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


        public CommonResponse ViewEscalationTimingById(int id)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblescalationtiming
                             where wf.IsDeleted == 0 && wf.Id == id
                             select new
                             {
                                 id = wf.Id,
                                 categoryId = wf.CategoryId,
                                 categoryName = wf.CategoryName,

                                 firstEsc = wf.FirstEscalation != null ? "Immediate" : null,

                                 secondEsc = wf.SecondEscalation != null ? wf.SecondEscalation + " min" : null,
                                 thirdEsc = wf.ThirdEscalation != null ? wf.ThirdEscalation + " min" : null,
                                 fourthEsc = wf.FourthEscalation != null ? wf.FourthEscalation + " min" : null

                                 //firstEsc = wf.FirstEscalation,
                                 //secEsc = wf.SecondEscalation,
                                 //thirdEsc = wf.ThirdEscalation,
                                 //fourthEsc = wf.FourthEscalation
                             }).FirstOrDefault();

                if (check != null)
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


        public CommonResponse DeleteEscalationTiming(int id)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTblescalationtiming.Where(m => m.Id == id).FirstOrDefault();
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
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }
    }
}
