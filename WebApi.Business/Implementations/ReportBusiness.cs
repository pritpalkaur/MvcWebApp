using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Business;
using MVC.Business.Interface;
using MVC.Domain;
using MVC.Data;
using MVC.Data.Interface;

namespace MVC.Business.Implementations
{
    public class ReportBusiness : IReportBusiness
    {
        private readonly IReportDatabase _IReportDatabase;
        public ReportBusiness(IReportDatabase IReportDatabase)
        {
            _IReportDatabase = IReportDatabase;
        }
        public async Task<List<Report>> GetReportsAsync()
        {
            return await _IReportDatabase.GetReportsAsync();
        }
    }
}
