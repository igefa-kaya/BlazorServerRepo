namespace BlazorServer.Entities
{
    public class DailyReport
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public double DrivenKm {get;set;}

        public string Notes { get; set; } = string.Empty;
    }
}
