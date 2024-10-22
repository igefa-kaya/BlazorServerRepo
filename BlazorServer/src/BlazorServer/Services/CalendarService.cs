using System;
using System.Threading.Tasks;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using Radzen.Blazor.Rendering;

namespace ITS.WWS.WebApp.Services
{
    public class CalendarService
    {
        private GraphServiceClient GraphServiceClient { get; set; }


        private readonly GraphService _graphService;


        public CalendarService(GraphService graphService)
        {
            _graphService = graphService;
            GraphServiceClient = _graphService.GraphServiceClient;
        }

        /// <summary>
        /// Sends an Api Request to the Microsoft Graph Api to get the calendar of the user.
        /// </summary>
        /// <param name="userId">Requires the parameter userId to get the calendar of the user.</param>
        /// <returns>All Outlook calendar appointments of the month.</returns>
        public async Task<EventCollectionResponse?> GetCalendarByMonthAsync(string userId)
        {
            if (userId != string.Empty)
            {
                GraphServiceClient = _graphService.GraphServiceClient;

                DateTime currentDate = DateTime.Now;
                DateTime startOfDay = new(currentDate.Year, currentDate.Month, 1, 0, 0, 0, DateTimeKind.Local);
                DateTime endOfDay = startOfDay.AddMonths(1).AddTicks(-1);

                string startDateTime = startOfDay.ToString("yyyy-MM-ddTHH:mm:ss");
                string endDateTime = endOfDay.ToString("yyyy-MM-ddTHH:mm:ss");

                return await GraphServiceClient.Users[userId].CalendarView.GetAsync((requestConfiguration) =>
                {
                    requestConfiguration.QueryParameters.StartDateTime = startDateTime;
                    requestConfiguration.QueryParameters.EndDateTime = endDateTime;
                    requestConfiguration.Headers.Add("Prefer", "outlook.timezone=\"Europe/Berlin\"");

                });
            }
            return null;
        }

        /// <summary>
        /// Sends an Api Request to the Microsoft Graph Api to get the calendar of the user.
        /// </summary>
        /// <param name="userId">Requires the parameter userId to get the calendar of the user.</param>
        /// <returns>All Outlook calendar appointments of the week.</returns>
        public async Task<EventCollectionResponse?> GetCalendarByWeekAsync(string userId)
        {
            if (userId != string.Empty)
            {
                DateTime currentDate = DateTime.Now;
                var test = currentDate.StartOfWeek();
                var test2 = currentDate.EndOfWeek();
                DateTime startOfDay = new(currentDate.Year, currentDate.Month, 1, 0, 0, 0, DateTimeKind.Local);
                DateTime endOfDay = startOfDay.AddDays(1).AddTicks(-1);

                string startDateTime = startOfDay.ToString("yyyy-MM-ddTHH:mm:ss");
                string endDateTime = endOfDay.ToString("yyyy-MM-ddTHH:mm:ss");

                return await GraphServiceClient.Users[userId].CalendarView.GetAsync((requestConfiguration) =>
                {
                    requestConfiguration.QueryParameters.StartDateTime = startDateTime;
                    requestConfiguration.QueryParameters.EndDateTime = endDateTime;
                    requestConfiguration.Headers.Add("Prefer", "outlook.timezone=\"Europe/Berlin\"");

                });
            }
            return null;
        }

        public async Task PostAppointmentAsync(string userEmail)
        {
            DateTime startOfDay = DateTime.Now;
            DateTime endOfDay = startOfDay.AddHours(1);

            // TODO: Implementieren
            var requestBody = new Event
            {
                Subject = "Feierabend",
                Body = new ItemBody
                {
                    ContentType = BodyType.Html,
                    Content = "Haste Bock?",
                },
                Start = new DateTimeTimeZone
                {
                    DateTime = startOfDay.ToString("yyyy-MM-ddTHH:mm:ss"),
                    TimeZone = "Europe/Berlin",
                },
                End = new DateTimeTimeZone
                {
                    DateTime = endOfDay.ToString("yyyy-MM-ddTHH:mm:ss"),
                    TimeZone = "Europe/Berlin",
                },
                Location = new Location
                {
                    DisplayName = "Bei Danny Zuhause",
                },
                Attendees = new List<Attendee>
                {
                    new Attendee
                    {
                        EmailAddress = new EmailAddress
                        {
                            Address = "kadir.kaya@igefa.de",
                            Name = "Kadir Kaya",
                        },
                        Type = AttendeeType.Required,
                    },
                    new Attendee
                    {
                        EmailAddress = new EmailAddress
                        {
                            Address = "daniel.lochner@igefa.de",
                            Name = "Daniel Lochner",
                        },
                        Type = AttendeeType.Required,
                    },
                },
                AllowNewTimeProposals = false,
                TransactionId = "7E163156-7762-4BEB-A1C6-729EA81755A8",
            };

            // To initialize your graphClient, see https://learn.microsoft.com/en-us/graph/sdks/create-client?from=snippets&tabs=csharp
            var result = await GraphServiceClient.Users[userEmail].Events.PostAsync(requestBody, (requestConfiguration) =>
            {
                requestConfiguration.Headers.Add("Prefer", "outlook.timezone=\"Pacific Standard Time\"");
            });
        }
    }
}
