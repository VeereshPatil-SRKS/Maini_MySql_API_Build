using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;
using IFacilityMaini.DAL;
using IFacilityMaini.DAL.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.EmployeeShiftDetailsEntity;

namespace IFacilityMaini.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GeneratePdfController : ControllerBase
    {
        private readonly IConverter converter;
        private readonly AppSettings appSettings;
        public GeneratePdfController(IConverter _converter, IOptions<AppSettings> _appSettings)
        {
            converter = _converter;
            appSettings = _appSettings.Value;
        }

        [HttpPost]
        public IActionResult CreatePDF([FromBody]DownloadPdf data)
        {
            CommonResponse commonResponse = new CommonResponse();
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "PDF Report",
                Out = @"D:\DMS\Employee_Report.pdf"
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = TemplateGenerator.GetHTMLString(data),
                WebSettings = { DefaultEncoding = "utf -8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "Styles.css") },
                HeaderSettings = { FontName = "Georgia", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontName = "Georgia", FontSize = 9, Line = true, Center = "Shiftwise Employee Details" }
            };

            var pdf = new HtmlToPdfDocument
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            converter.Convert(pdf);
            commonResponse.isStatus = true;
            commonResponse.response = appSettings.ImageUrl + "Employee_Report.pdf";
            //var file = converter.Convert(pdf);
            //return File(file, "application/pdf","Employee.pdf");
            return Ok(commonResponse);
        }
    }
}
