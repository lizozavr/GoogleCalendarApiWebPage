#pragma checksum "D:\Programming\WebApplication\WebApplication\Views\Home\Event.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2541d437c0183d34b0d969f63d998b53fd8adca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Event), @"mvc.1.0.view", @"/Views/Home/Event.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Programming\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2541d437c0183d34b0d969f63d998b53fd8adca", @"/Views/Home/Event.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Event : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.Models.CalendarEventParam>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Programming\WebApplication\WebApplication\Views\Home\Event.cshtml"
  
    ViewData["Title"] = "Event";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row  py-3\">\r\n        <div class=\"col-md-8\">\r\n            <div class=\"align-content-md-start\">\r\n                <h2 class=\"align-content-md-center\">Calendar ID: ");
#nullable restore
#line 9 "D:\Programming\WebApplication\WebApplication\Views\Home\Event.cshtml"
                                                            Write(Model.calendar_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            </div>\r\n            \r\n            <h6>Event ID: ");
#nullable restore
#line 12 "D:\Programming\WebApplication\WebApplication\Views\Home\Event.cshtml"
                     Write(Model.event_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <h6>Summary: ");
#nullable restore
#line 13 "D:\Programming\WebApplication\WebApplication\Views\Home\Event.cshtml"
                    Write(Model.summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <h6>Description: ");
#nullable restore
#line 14 "D:\Programming\WebApplication\WebApplication\Views\Home\Event.cshtml"
                        Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <h6>Start time: ");
#nullable restore
#line 15 "D:\Programming\WebApplication\WebApplication\Views\Home\Event.cshtml"
                       Write(Model.start_date_time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <h6>End time: ");
#nullable restore
#line 16 "D:\Programming\WebApplication\WebApplication\Views\Home\Event.cshtml"
                     Write(Model.end_date_time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <h6>Location: ");
#nullable restore
#line 17 "D:\Programming\WebApplication\WebApplication\Views\Home\Event.cshtml"
                     Write(Model.location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            \r\n        </div>\r\n        </div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.Models.CalendarEventParam> Html { get; private set; }
    }
}
#pragma warning restore 1591
