using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using System.Web;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaledarController : Controller
    {
        // CalendarRepository calen = new CalendarRepository();

        [HttpGet]
        [Route("all")]//Все события календаря
        public CalendarParam GetCalendar([FromBody] CalendarParam calendar)
        {
            CalendarRepository calen = new CalendarRepository();
            return calen.GetEvents(calendar);
        }

        [HttpGet]//Получить событие
        [Route("get_ev")]
        public CalendarEventParam GetEvent([FromBody] CalendarEventParam calendar)
        {
            CalendarRepository calen = new CalendarRepository();
            return calen.GetEvent(calendar);
        }


        [HttpPost]
        [Route("add_ev")]//Добавление события
        public CalendarEventParam AddEvent([FromBody] CalendarEventParam calendar)
        {
            CalendarRepository calen = new CalendarRepository();
            return calen.InsertEvent(calendar);
        }

        [HttpPost]
        [Route("quickadd_ev")]//Добавление события в текущий день и время
        public CalendarEventParam QuickAddEvent([FromBody] CalendarEventParam calendar)
        {
            CalendarRepository calen = new CalendarRepository();
            return calen.QuickAddEvent(calendar);
        }

        [HttpDelete]//Удалить событие
        [Route("del_ev")]
        public CalendarEventParam DelEvent([FromBody] CalendarEventParam calendar)
        {
            CalendarRepository calen = new CalendarRepository();
            return calen.DeleteEvent(calendar);
        }
    }


}
