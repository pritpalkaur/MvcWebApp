using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Domain;

namespace MVC.Business.Interface
{
    public interface IReportBusiness
    {
        Task<List<Report>> GetReportsAsync();
    }
}
