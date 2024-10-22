using BlazorServer.CustomComponents.Enum;

namespace BlazorServer.Entities
{
    public class Appointment 
    {
        public DateTime AppointmentDate { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime CreationDate { get; set; }

        public string GoalText { get; set; } = string.Empty;

        public string Comment { get; set; } = string.Empty;

        public string CustomerSatisfaction { get; set; } = string.Empty;

        public string CustomerSatisfactionDescription { get; set; } = string.Empty;

        public string Cause { get; set; } = string.Empty;

        public string Goal { get; set; } = string.Empty;

        public AppointmentState Status { get; set; } = AppointmentState.NotStarted;

    }
}
