namespace BlazorServer.Entities
{
    public class DailyReport
    {
        public Guid ID { get;}

        public Guid CompanyGroupId { get; set; }

        public Guid CompanyId { get; set; }

        public Guid RepID { get; set; }

        public DateTime ReportDate { get; set; }

        public DateTime? DailyReportStart { get; set; }

        public DateTime? DailyReportEndTime { get; set; }

        public int? StartKM { get; set; }

        public int? EndKM { get; set; }

        public int? PrivateKm { get; set; }

        public int? Expenses { get; set; }

        public bool? Approved { get; set; }

        public int? Catering { get; set; }

        public int? Hotel { get; set; }

        public int? Transport { get; set; }

        public int? MiscExpenses { get; set; }

        public int? Lumpsum { get; set; }

        public bool? EmployeeApproval { get; set; }

        public bool? SickStart { get; set; }

        public bool? SickEnd { get; set; }

        public bool? Training { get; set; }

        public bool? VacationStart { get; set; }

        public int? Fueled { get; set; }

        public DateTime? CreationDate { get; set; }
    }
}
