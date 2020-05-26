using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class CalendarEventParam
    {
        public string calendar_id { get; set; }
        public string event_id { get; set; }
        public string summary { get; set; } //Title of the event.
        public string location { get; set; }
        public string description { get; set; }
        public string start_date_time { get; set; }
        public string end_date_time { get; set; }

    }
}
