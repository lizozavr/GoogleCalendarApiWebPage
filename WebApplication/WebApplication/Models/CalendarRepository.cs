using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Text;
using System.Threading;

namespace WebApplication.Models
{
    public class CalendarRepository
    {
        static List<string> dates = new List<string>();
        static List<string> even = new List<string>();

        static string[] Scopes = { CalendarService.Scope.Calendar };
        UserCredential credential;
        Events events;
        Event newEvent;


        public CalendarRepository()
        {
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                //Авторизация только при первом запуске программы
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }
        }

        public CalendarParam GetEvents(CalendarParam calendar)
        {
            CalendarService service = new CalendarService(new BaseClientService.Initializer()//new Service
            {
                HttpClientInitializer = credential
            });

            EventsResource.ListRequest request = service.Events.List(calendar.calendar_id);
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 10;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            even.Clear();
            dates.Clear();

            events = request.Execute();
            if (events.Items != null && events.Items.Count > 0)
            {
                foreach (var eventItem in events.Items)
                {
                    string when = eventItem.Start.DateTime.ToString();
                    if (String.IsNullOrEmpty(when))
                    {
                        when = eventItem.Start.Date;
                        even.Add(eventItem.Summary);
                        dates.Add(when);
                    }
                }
            }
            calendar.events = even;
            calendar.date = dates;
            return calendar;
        }

        public CalendarEventParam InsertEvent(CalendarEventParam calendar)
        {
            CalendarService service = new CalendarService(new BaseClientService.Initializer()//new Service
            {
                HttpClientInitializer = credential
            });

            newEvent = new Event()
            {
                Summary = calendar.summary,//Title of the event.
                Location = calendar.location,
                Description = calendar.description,
                Start = new EventDateTime()
                {
                    DateTime = DateTime.Parse(calendar.start_date_time),
                },
                End = new EventDateTime()
                {
                    DateTime = DateTime.Parse(calendar.end_date_time),
                }
            };
            EventsResource.InsertRequest request = service.Events.Insert(newEvent, calendar.calendar_id);

            Event createdEvent = request.Execute();
            return calendar;
        }

        public CalendarEventParam GetEvent(CalendarEventParam calendar)
        {
            CalendarService service = new CalendarService(new BaseClientService.Initializer()//new Service
            {
                HttpClientInitializer = credential
            });

            Event event1 = service.Events.Get(calendar.calendar_id, calendar.event_id).Execute();

            calendar.summary = event1.Summary;
            calendar.start_date_time = event1.Start.DateTimeRaw;
            calendar.end_date_time = event1.End.DateTimeRaw;
            calendar.description = event1.Description;
            calendar.location = event1.Location;
            return calendar;
        }

        public CalendarEventParam DeleteEvent(CalendarEventParam calendar)
        {
            CalendarService service = new CalendarService(new BaseClientService.Initializer()//new Service
            {
                HttpClientInitializer = credential
            });

            service.Events.Delete(calendar.calendar_id, calendar.event_id).Execute();
            return calendar;
        }

        public CalendarEventParam QuickAddEvent(CalendarEventParam calendar)
        {
            CalendarService service = new CalendarService(new BaseClientService.Initializer()//new Service
            {
                HttpClientInitializer = credential
            });

            service.Events.QuickAdd(calendar.calendar_id, calendar.summary).Execute();
            return calendar;
        }
    }
}
