using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Domain;

namespace MVC.Data.Interface
{
    public interface IReportDatabase
    {
        Task<List<Report>> GetReportsAsync();
    }
}
