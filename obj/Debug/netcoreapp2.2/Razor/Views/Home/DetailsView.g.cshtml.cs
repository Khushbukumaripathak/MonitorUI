#pragma checksum "C:\Users\z0049mne\Source\Repos\ms_test\SCM_TF\MonitoringWebApp\Views\Home\DetailsView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ec4619bda3e04914adda80621b28e1903e6d26d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DetailsView), @"mvc.1.0.view", @"/Views/Home/DetailsView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DetailsView.cshtml", typeof(AspNetCore.Views_Home_DetailsView))]
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
#line 7 "C:\Users\z0049mne\Source\Repos\ms_test\SCM_TF\MonitoringWebApp\Views\Home\DetailsView.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ec4619bda3e04914adda80621b28e1903e6d26d", @"/Views/Home/DetailsView.cshtml")]
    public class Views_Home_DetailsView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\z0049mne\Source\Repos\ms_test\SCM_TF\MonitoringWebApp\Views\Home\DetailsView.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 19, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n");
            EndContext();
            BeginContext(133, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(141, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ec4619bda3e04914adda80621b28e1903e6d26d3472", async() => {
                BeginContext(147, 93, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>DetailsView</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(247, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(249, 1222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ec4619bda3e04914adda80621b28e1903e6d26d4754", async() => {
                BeginContext(255, 154, true);
                WriteLiteral("\r\n    <h1>Configuration for Rule</h1>\r\n    <hr />\r\n    <form method=\"post\" enctype=\"multipart/form-data\" asp-controller=\"Home\" asp-action=\"DetailsView\">\r\n");
                EndContext();
#line 18 "C:\Users\z0049mne\Source\Repos\ms_test\SCM_TF\MonitoringWebApp\Views\Home\DetailsView.cshtml"
         if (!string.IsNullOrEmpty(HttpContextAccessor.HttpContext.Session.GetString("testName")))
        {

#line default
#line hidden
                BeginContext(520, 218, true);
                WriteLiteral("            <table border=\"0\">\r\n                <tr>\r\n                    <th>TestCase Name</th>\r\n                    <th>Insert Cycle count</th>\r\n                    <th>Insert Loop count</th>\r\n                </tr>\r\n");
                EndContext();
#line 26 "C:\Users\z0049mne\Source\Repos\ms_test\SCM_TF\MonitoringWebApp\Views\Home\DetailsView.cshtml"
                 foreach (var test in @HttpContextAccessor.HttpContext.Session.GetString("testName").Split(',').ToList())
                {

#line default
#line hidden
                BeginContext(880, 54, true);
                WriteLiteral("                    <tr>\r\n                        <td>");
                EndContext();
                BeginContext(935, 4, false);
#line 29 "C:\Users\z0049mne\Source\Repos\ms_test\SCM_TF\MonitoringWebApp\Views\Home\DetailsView.cshtml"
                       Write(test);

#line default
#line hidden
                EndContext();
                BeginContext(939, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(975, 25, false);
#line 30 "C:\Users\z0049mne\Source\Repos\ms_test\SCM_TF\MonitoringWebApp\Views\Home\DetailsView.cshtml"
                       Write(Html.TextBox("cycleTime"));

#line default
#line hidden
                EndContext();
                BeginContext(1000, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1036, 25, false);
#line 31 "C:\Users\z0049mne\Source\Repos\ms_test\SCM_TF\MonitoringWebApp\Views\Home\DetailsView.cshtml"
                       Write(Html.TextBox("loopCount"));

#line default
#line hidden
                EndContext();
                BeginContext(1061, 34, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n");
                EndContext();
#line 33 "C:\Users\z0049mne\Source\Repos\ms_test\SCM_TF\MonitoringWebApp\Views\Home\DetailsView.cshtml"
                }

#line default
#line hidden
                BeginContext(1114, 226, true);
                WriteLiteral("                <tr>\r\n                    <td><input name=\"reset\" type=\"reset\" value=\"Reset\" /></td>\r\n                    <td><input name=\"save\" type=\"submit\" value=\"Save\" /></td>\r\n                </tr>\r\n            </table>\r\n");
                EndContext();
#line 39 "C:\Users\z0049mne\Source\Repos\ms_test\SCM_TF\MonitoringWebApp\Views\Home\DetailsView.cshtml"
        }

#line default
#line hidden
                BeginContext(1351, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 40 "C:\Users\z0049mne\Source\Repos\ms_test\SCM_TF\MonitoringWebApp\Views\Home\DetailsView.cshtml"
         if (ViewBag.Message != null)
        {

#line default
#line hidden
                BeginContext(1401, 16, true);
                WriteLiteral("            <h4>");
                EndContext();
                BeginContext(1418, 15, false);
#line 42 "C:\Users\z0049mne\Source\Repos\ms_test\SCM_TF\MonitoringWebApp\Views\Home\DetailsView.cshtml"
           Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(1433, 7, true);
                WriteLiteral("</h4>\r\n");
                EndContext();
#line 43 "C:\Users\z0049mne\Source\Repos\ms_test\SCM_TF\MonitoringWebApp\Views\Home\DetailsView.cshtml"
        }

#line default
#line hidden
                BeginContext(1451, 13, true);
                WriteLiteral("    </form>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1471, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
