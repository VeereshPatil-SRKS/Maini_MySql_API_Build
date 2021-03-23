using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.DAL.Helpers;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using static IFacilityMaini.EntityModels.DocumentUploaderEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class DocumentUploaderController : ControllerBase
    {
        private readonly AppSettings _appSettings;
        private readonly IDocumentUploader documentUploader;

        public DocumentUploaderController(IOptions<AppSettings> appSettings, IDocumentUploader _documentUploader)
        {
            _appSettings = appSettings.Value;
            documentUploader = _documentUploader;
        }

        /// <summary>
        /// Add and Edit Document Uploader
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DocumentUploader/AddAndEditDocumentUploader")]
        public async Task<IActionResult> AddAndEditDocumentUploader([FromForm] DocumentUplodedMasterCustom documentDetails)
        {

            CommonResponseWithIdsDoc response = new CommonResponseWithIdsDoc();
            response = documentUploader.AddAndEditDocumentUploader(documentDetails);
            return Ok(response);


            //#region Authorization code
            //var identity = HttpContext.User.Identity as ClaimsIdentity;
            //string id = "";
            //string role = "";
            //if (identity != null)
            //{
            //    IEnumerable<Claim> claims = identity.Claims;
            //    // or
            //    id = identity.Claims.Where(m => m.Type == ClaimTypes.Sid).Select(m => m.Value).FirstOrDefault();
            //    role = identity.Claims.Where(m => m.Type == ClaimTypes.Role).Select(m => m.Value).FirstOrDefault();
            //}
            //long userId = Convert.ToInt32(id);
            //#endregion

            //calling DocumentUploaderDAL busines layer
            // CommonResponseWithIdsDoc response = new CommonResponseWithIdsDoc();
            //response = documentUploader.AddAndEditDocumentUploader(documentDetails);

            //    response = documentUploader.AddAndEditDocumentUploader(documentDetails, userId);

            // return Ok(response);
        }



        /// <summary>
        /// Add And Edit Document Uploader Base64
        /// </summary>
        /// <param name="documentDetails"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DocumentUploader/AddAndEditDocumentUploaderBase64")]
        public async Task<IActionResult> AddAndEditDocumentUploaderBase64(DocumentUplodedMasterCustomBase64 documentDetails)
        {
            //#region Authorization code
            //var identity = HttpContext.User.Identity as ClaimsIdentity;
            //string id = "";
            //string role = "";
            //if (identity != null)
            //{
            //    IEnumerable<Claim> claims = identity.Claims;
            //    // or
            //    id = identity.Claims.Where(m => m.Type == ClaimTypes.Sid).Select(m => m.Value).FirstOrDefault();
            //    role = identity.Claims.Where(m => m.Type == ClaimTypes.Role).Select(m => m.Value).FirstOrDefault();
            //}
            //long userId = Convert.ToInt32(id);
            //#endregion
            //calling DocumentUploaderDAL busines layer
            CommonResponseWithIdsDoc response = new CommonResponseWithIdsDoc();
            response = documentUploader.AddAndEditDocumentUploaderBase64(documentDetails);

            return Ok(response);
        }









        /// <summary>
        /// Add And Edit Document Uploader Base64
        /// </summary>
        /// <param name="documentDetails"></param>
        /// <returns></returns>
        //[HttpPost]
        //[Route("DocumentUploader/AddAndEditDocumentUploaderBase64")]
        //public async Task<IActionResult> AddAndEditDocumentUploaderBase64(DocumentUplodedMasterCustomBase64 documentDetails)
        //{
        //    #region Authorization code
        //    var identity = HttpContext.User.Identity as ClaimsIdentity;
        //    string id = "";
        //    string role = "";
        //    if (identity != null)
        //    {
        //        IEnumerable<Claim> claims = identity.Claims;
        //        // or
        //        id = identity.Claims.Where(m => m.Type == ClaimTypes.Sid).Select(m => m.Value).FirstOrDefault();
        //        role = identity.Claims.Where(m => m.Type == ClaimTypes.Role).Select(m => m.Value).FirstOrDefault();
        //    }
        //    long userId = Convert.ToInt32(id);
        //    #endregion
        //    //calling DocumentUploaderDAL busines layer
        //    CommonResponseWithIdsDoc response = new CommonResponseWithIdsDoc();
        //    response = documentUploader.AddAndEditDocumentUploaderBase64(documentDetails, userId);

        //    return Ok(response);
        //}
    }
}