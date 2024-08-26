using MVC.Exceptions.Service;
using MVC.Exceptions.Data;

namespace MVC.Exceptions.Service
{
    public interface ILoggingService
    {
        public void LogInformation(Exception ex);
        Task LogExceptionAsync(Exception exception);
    }
}
