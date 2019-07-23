using System.Threading.Tasks;
using ICFERApp.Repository;
using jsreport.AspNetCore;
using jsreport.Types;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetBarcode;

namespace ICFERApp.Controllers
{
    public class ReportsController : Controller
    {
        
        private readonly IStudentRepository _studentRepository;
        public IJsReportMVCService JsReportMVCService { get; }
        
        public ReportsController(IStudentRepository studentRepository,IJsReportMVCService jsReportMVCService)
        {
            _studentRepository = studentRepository;
            JsReportMVCService = jsReportMVCService;
        }

        // GET
        [MiddlewareFilter(typeof(JsReportPipeline))]
        
        [Authorize]
        public async Task<IActionResult> ReportDetails(int id)
        {
            var singleStudent = _studentRepository.GetSingleStudent(id);
            var header = await JsReportMVCService.RenderViewToStringAsync(
                HttpContext, RouteData, "ReportDetails", singleStudent);
            
           
            
            HttpContext.JsReportFeature()
                .Recipe(Recipe.ChromePdf)
                .Configure((r) => r.Template.Chrome = new Chrome{ HeaderTemplate = header });
            
            
            return View(singleStudent);
        }
    }
}