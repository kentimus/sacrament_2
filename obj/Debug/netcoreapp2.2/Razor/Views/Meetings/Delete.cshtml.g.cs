#pragma checksum "C:\Users\kent\source\repos\SacramentPlanner\Views\Meetings\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "212ffd74c8d2ea05af1fd572c9235db53d51da78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Meetings_Delete), @"mvc.1.0.view", @"/Views/Meetings/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Meetings/Delete.cshtml", typeof(AspNetCore.Views_Meetings_Delete))]
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
#line 1 "C:\Users\kent\source\repos\SacramentPlanner\Views\_ViewImports.cshtml"
using SacramentPlanner;

#line default
#line hidden
#line 2 "C:\Users\kent\source\repos\SacramentPlanner\Views\_ViewImports.cshtml"
using SacramentPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"212ffd74c8d2ea05af1fd572c9235db53d51da78", @"/Views/Meetings/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b7b2e7c0c23763ecadada24630103390c557703", @"/Views/_ViewImports.cshtml")]
    public class Views_Meetings_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SacramentPlanner.Models.Meeting>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\kent\source\repos\SacramentPlanner\Views\Meetings\Delete.cshtml"
  
    ViewData["Title"] = "Delete Meeting";

#line default
#line hidden
            BeginContext(92, 195, true);
            WriteLiteral("\r\n<h1>Delete Meeting</h1>\r\n\r\n<h3 class=\"alert alert-danger\">Are you sure you want to delete this?</h3>\r\n<div>\r\n   \r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(288, 47, false);
#line 15 "C:\Users\kent\source\repos\SacramentPlanner\Views\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MeetingDate));

#line default
#line hidden
            EndContext();
            BeginContext(335, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(399, 43, false);
#line 18 "C:\Users\kent\source\repos\SacramentPlanner\Views\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MeetingDate));

#line default
#line hidden
            EndContext();
            BeginContext(442, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(505, 52, false);
#line 21 "C:\Users\kent\source\repos\SacramentPlanner\Views\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ConductingLeader));

#line default
#line hidden
            EndContext();
            BeginContext(557, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(621, 48, false);
#line 24 "C:\Users\kent\source\repos\SacramentPlanner\Views\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ConductingLeader));

#line default
#line hidden
            EndContext();
            BeginContext(669, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(732, 47, false);
#line 27 "C:\Users\kent\source\repos\SacramentPlanner\Views\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OpeningSong));

#line default
#line hidden
            EndContext();
            BeginContext(779, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(843, 43, false);
#line 30 "C:\Users\kent\source\repos\SacramentPlanner\Views\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OpeningSong));

#line default
#line hidden
            EndContext();
            BeginContext(886, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(949, 49, false);
#line 33 "C:\Users\kent\source\repos\SacramentPlanner\Views\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SacramentSong));

#line default
#line hidden
            EndContext();
            BeginContext(998, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1062, 45, false);
#line 36 "C:\Users\kent\source\repos\SacramentPlanner\Views\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SacramentSong));

#line default
#line hidden
            EndContext();
            BeginContext(1107, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1170, 52, false);
#line 39 "C:\Users\kent\source\repos\SacramentPlanner\Views\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IntermediateSong));

#line default
#line hidden
            EndContext();
            BeginContext(1222, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1286, 48, false);
#line 42 "C:\Users\kent\source\repos\SacramentPlanner\Views\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IntermediateSong));

#line default
#line hidden
            EndContext();
            BeginContext(1334, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1397, 47, false);
#line 45 "C:\Users\kent\source\repos\SacramentPlanner\Views\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ClosingSong));

#line default
#line hidden
            EndContext();
            BeginContext(1444, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1508, 43, false);
#line 48 "C:\Users\kent\source\repos\SacramentPlanner\Views\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ClosingSong));

#line default
#line hidden
            EndContext();
            BeginContext(1551, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1614, 49, false);
#line 51 "C:\Users\kent\source\repos\SacramentPlanner\Views\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OpeningPrayer));

#line default
#line hidden
            EndContext();
            BeginContext(1663, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1727, 45, false);
#line 54 "C:\Users\kent\source\repos\SacramentPlanner\Views\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OpeningPrayer));

#line default
#line hidden
            EndContext();
            BeginContext(1772, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1835, 49, false);
#line 57 "C:\Users\kent\source\repos\SacramentPlanner\Views\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ClosingPrayer));

#line default
#line hidden
            EndContext();
            BeginContext(1884, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1948, 45, false);
#line 60 "C:\Users\kent\source\repos\SacramentPlanner\Views\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ClosingPrayer));

#line default
#line hidden
            EndContext();
            BeginContext(1993, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2031, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "212ffd74c8d2ea05af1fd572c9235db53d51da7811721", async() => {
                BeginContext(2057, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2067, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "212ffd74c8d2ea05af1fd572c9235db53d51da7812114", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 65 "C:\Users\kent\source\repos\SacramentPlanner\Views\Meetings\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MeetingID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2110, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2193, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "212ffd74c8d2ea05af1fd572c9235db53d51da7814020", async() => {
                    BeginContext(2215, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2231, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2244, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SacramentPlanner.Models.Meeting> Html { get; private set; }
    }
}
#pragma warning restore 1591
