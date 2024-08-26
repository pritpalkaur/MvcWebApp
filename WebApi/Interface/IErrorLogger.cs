namespace MVC.Interface
{
    public interface IErrorLogger
    {
        void LogMessage(Exception ex);
    }
}
