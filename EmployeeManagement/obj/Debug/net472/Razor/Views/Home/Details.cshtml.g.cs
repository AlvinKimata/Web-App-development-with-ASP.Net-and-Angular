#pragma checksum "C:\Users\debonair\OneDrive\Documents\web_app_dev\Web-App-development-with-ASP.Net-and-Angular\EmployeeManagement\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a5c0b18ae44f65b7b1d38e0e59b9c4beb31e71a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a5c0b18ae44f65b7b1d38e0e59b9c4beb31e71a", @"/Views/Home/Details.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeManagement.ViewModels.HomeDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 6, true);
            WriteLiteral("\r\n<h3>");
            EndContext();
            BeginContext(66, 15, false);
#line 3 "C:\Users\debonair\OneDrive\Documents\web_app_dev\Web-App-development-with-ASP.Net-and-Angular\EmployeeManagement\Views\Home\Details.cshtml"
Write(Model.PageTitle);

#line default
#line hidden
            EndContext();
            BeginContext(81, 26, true);
            WriteLiteral("</h3>\r\n\r\n<div>\r\n    Name: ");
            EndContext();
            BeginContext(108, 19, false);
#line 6 "C:\Users\debonair\OneDrive\Documents\web_app_dev\Web-App-development-with-ASP.Net-and-Angular\EmployeeManagement\Views\Home\Details.cshtml"
     Write(Model.Employee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(127, 30, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    Email: ");
            EndContext();
            BeginContext(158, 20, false);
#line 10 "C:\Users\debonair\OneDrive\Documents\web_app_dev\Web-App-development-with-ASP.Net-and-Angular\EmployeeManagement\Views\Home\Details.cshtml"
      Write(Model.Employee.Email);

#line default
#line hidden
            EndContext();
            BeginContext(178, 35, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    Department: ");
            EndContext();
            BeginContext(214, 24, false);
#line 14 "C:\Users\debonair\OneDrive\Documents\web_app_dev\Web-App-development-with-ASP.Net-and-Angular\EmployeeManagement\Views\Home\Details.cshtml"
           Write(Model.Employee.Deprtment);

#line default
#line hidden
            EndContext();
            BeginContext(238, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeManagement.ViewModels.HomeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
