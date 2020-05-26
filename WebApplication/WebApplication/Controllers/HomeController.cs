using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using WebApplication.Models;
using WebApplication.Controllers;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Calendar(string CalendarId)
        {
            var calenRep = new CalendarRepository();
            CalendarParam calendar = new CalendarParam();
            calendar.calendar_id = CalendarId;
            return View(calenRep.GetEvents(calendar));
        }

        public async Task<ActionResult> Event(string CalendarId, string EventId)
        {
            var calenRep = new CalendarRepository();
            CalendarEventParam calendar = new CalendarEventParam();
            calendar.calendar_id = CalendarId;
            calendar.event_id = EventId;
            return View(calenRep.GetEvent(calendar));
        }

        public async Task<ActionResult> AddEvent(string CalendarId, string Summary, string Location, string Description, string StartDateTime, string EndDateTime) 
        {
            var calenRep = new CalendarRepository();
            CalendarEventParam calendar = new CalendarEventParam();
            calendar.calendar_id = CalendarId;
            calendar.summary = Summary;
            calendar.location = Location;
            calendar.description = Description;
            calendar.start_date_time = StartDateTime;
            calendar.end_date_time = EndDateTime;
            return View(calenRep.InsertEvent(calendar));
        }

        public async Task<ActionResult> QuickAdd(string CalendarId, string Summary)
        {
            var calenRep = new CalendarRepository();
            CalendarEventParam calendar = new CalendarEventParam();
            calendar.calendar_id = CalendarId;
            calendar.summary = Summary;
            return View(calenRep.QuickAddEvent(calendar));
        }

        public async Task<ActionResult> DelEvent(string CalendarId, string EventId)
        {
            var calenRep = new CalendarRepository();
            CalendarEventParam calendar = new CalendarEventParam();
            calendar.calendar_id = CalendarId;
            calendar.event_id = EventId;
            return View(calenRep.DeleteEvent(calendar));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}