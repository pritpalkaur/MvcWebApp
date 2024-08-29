using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVC.Business.Implementations;
using MVC.Business.Interface;
using MVC.Exceptions.Service;
using MVCWeb.Models.Reports;

namespace MVCWeb.Controllers
{
    public class ReportController : Controller
    {

        private readonly IReportBusiness _reportBusiness;
        private readonly ILoggingService _ILoggingService;
        private readonly IMapper _mapper; // Inject IMapper
        public ReportController(IReportBusiness reportBusiness, ILoggingService iLoggingService, IMapper mapper)
        {
            _reportBusiness = reportBusiness;
            _ILoggingService = iLoggingService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                // Fetch reports asynchronously
                var reports = await _reportBusiness.GetReportsAsync();

                // Map the reports to a view model (assuming you have a ReportViewModel)
                var reportViewModels = _mapper.Map<List<ReportsViewModel>>(reports);

                // Pass the view models to the view
                return View(reportViewModels);
            }
            catch (Exception ex)
            {
                // Log the exception
                _ILoggingService.LogInformation(ex);

                // Handle the error (you might want to show an error page or return an appropriate response)
                return View("Error"); // Assuming you have an Error view
            }
            return View();
        }
    }
}
