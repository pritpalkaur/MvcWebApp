namespace MVCWeb.Models.Reports
{
    public class ReportsViewModel
    {
        public long ReportId { get; set; }
        public string ReportName { get; set; }
        public string ReportDescription { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
