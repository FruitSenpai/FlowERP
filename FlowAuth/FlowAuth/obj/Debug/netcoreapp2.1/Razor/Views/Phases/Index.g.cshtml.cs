#pragma checksum "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Phases\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bca9cf470c8e04c33a5832130feb0219621da31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Phases_Index), @"mvc.1.0.view", @"/Views/Phases/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Phases/Index.cshtml", typeof(AspNetCore.Views_Phases_Index))]
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
#line 1 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\_ViewImports.cshtml"
using FlowAuth;

#line default
#line hidden
#line 2 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\_ViewImports.cshtml"
using FlowAuth.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bca9cf470c8e04c33a5832130feb0219621da31", @"/Views/Phases/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89129962b79090d0f1ae5f5d5048e447eef01cf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Phases_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FlowAuth.Models.Phase>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Phases\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(86, 3728, true);
            WriteLiteral(@"
<h2>Phases</h2>

<style>

    body {
        background-color: #3e94ec;
        font-family: ""Roboto"", helvetica, arial, sans-serif;
        font-size: 14px;
        font-weight: 400;
        text-rendering: optimizeLegibility;
    }

    div.table-title {
        display: block;
        margin: auto;
        max-width: 600px;
        padding: 5px;
        width: 100%;
    }

    .table-title h3 {
        color: #fafafa;
        font-size: 18px;
        font-weight: 200;
        font-style: normal;
        font-family: ""Roboto"", helvetica, arial, sans-serif;
        text-shadow: -1px -1px 1px rgba(0, 0, 0, 0.1);
        text-transform: uppercase;
    }


    /*** Table Styles **/

    .table-fill {
        background: white;
        border-radius: 3px;
        border-collapse: collapse;
        height: 320px;
        margin: auto;
        max-width: 600px;
        padding: 5px;
        width: 100%;
        box-shadow: 0 5px 10px rgba(0, 0, 0, 0.1);
        animatio");
            WriteLiteral(@"n: float 5s infinite;
    }

    th {
        color: #D5DDE5;
        background: #1b1e24;
        border-bottom: 4px solid #9ea7af;
        border-right: 1px solid #343a45;
        font-size: 18px;
        font-weight: 100;
        padding: 24px;
        text-align: left;
        text-shadow: 0 1px 1px rgba(0, 0, 0, 0.1);
        vertical-align: middle;
    }

        th:first-child {
            border-top-left-radius: 3px;
        }

        th:last-child {
            border-top-right-radius: 3px;
            border-right: none;
        }

    tr {
        border-top: 1px solid #C1C3D1;
        background-color: midnightblue;
        color: black;
        font-size: 14px;
        font-weight: normal;
        text-shadow: 0 1px 1px rgba(256, 256, 256, 0.1);
    }

        tr:hover td {
            background: black;
            color: #FFFFFF;
            border-top: 1px solid #22262e;
        }

        tr:first-child {
            border-top: none;
        }

 ");
            WriteLiteral(@"       tr:last-child {
            border-bottom: none;
        }

        tr:nth-child(odd) td {
            background: #4E5066;
        }

        tr:nth-child(odd):hover td {
            background: black;
        }

        tr:last-child td:first-child {
            border-bottom-left-radius: 3px;
        }

        tr:last-child td:last-child {
            border-bottom-right-radius: 3px;
        }

    td {
        background: rgba(0, 0, 0, 0.57);
        padding: 20px;
        text-align: left;
        vertical-align: middle;
        font-weight: 300;
        font-size: 12px;
        color: white;
        text-shadow: -1px -1px 1px rgba(0, 0, 0, 0.1);
        border-right: 1px solid #C1C3D1;
    }

        td:last-child {
            border-right: 0px;
        }

    th.text-left {
        text-align: left;
    }

    th.text-center {
        text-align: center;
    }

    th.text-right {
        text-align: right;
    }

    td.text-left {
        text");
            WriteLiteral(@"-align: left;
    }

    td.text-center {
        text-align: center;
    }

    td.text-right {
        text-align: right;
    }

    button {
        background-color: white;
        color: midnightblue;
        padding: 12px 20px;
        border: none;
        border-radius: 4px;
        cursor: pointer;
    }


        button:hover {
            background-color: hotpink;
        }

    input[type=text] {
        padding: 6px;
        border: none;
        margin-top: 8px;
        margin-right: 16px;
        font-size: 17px;
        text-decoration-color: black;
        color: black;
    }
</style>

<p>
    ");
            EndContext();
            BeginContext(3814, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51f543a929884386bcedf8ecdd72ce5b", async() => {
                BeginContext(3837, 33, true);
                WriteLiteral("<button>New Project Plan</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3874, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3967, 51, false);
#line 186 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Phases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Phase_startDate));

#line default
#line hidden
            EndContext();
            BeginContext(4018, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(4074, 49, false);
#line 189 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Phases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Phase_endDate));

#line default
#line hidden
            EndContext();
            BeginContext(4123, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(4179, 48, false);
#line 192 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Phases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Phase_budget));

#line default
#line hidden
            EndContext();
            BeginContext(4227, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(4283, 45, false);
#line 195 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Phases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhaseName));

#line default
#line hidden
            EndContext();
            BeginContext(4328, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(4384, 43, false);
#line 198 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Phases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Project));

#line default
#line hidden
            EndContext();
            BeginContext(4427, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 204 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Phases\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(4545, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4594, 50, false);
#line 207 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Phases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phase_startDate));

#line default
#line hidden
            EndContext();
            BeginContext(4644, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4700, 48, false);
#line 210 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Phases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phase_endDate));

#line default
#line hidden
            EndContext();
            BeginContext(4748, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4804, 47, false);
#line 213 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Phases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phase_budget));

#line default
#line hidden
            EndContext();
            BeginContext(4851, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4907, 55, false);
#line 216 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Phases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhaseName.Phase_name));

#line default
#line hidden
            EndContext();
            BeginContext(4962, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5018, 55, false);
#line 219 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Phases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Project.Project_Code));

#line default
#line hidden
            EndContext();
            BeginContext(5073, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5128, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5eb02f10f724feaabb7cd38cb4189a0", async() => {
                BeginContext(5178, 67, true);
                WriteLiteral("<button type=\"button\"><i class=\"material-icons\">create</i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 222 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Phases\Index.cshtml"
                                       WriteLiteral(item.PhaseID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5249, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(5269, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "026901e1932f4f65ba5ad9cf910ecb6e", async() => {
                BeginContext(5322, 65, true);
                WriteLiteral("<button type=\"button\"><i class=\"material-icons\">list</i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 223 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Phases\Index.cshtml"
                                          WriteLiteral(item.PhaseID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5391, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(5411, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9bf6c9c8bb34c2d963d323e4a95d735", async() => {
                BeginContext(5463, 66, true);
                WriteLiteral("<button type=\"button\"><i class=\"material-icons\">clear</i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 224 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Phases\Index.cshtml"
                                         WriteLiteral(item.PhaseID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5533, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 227 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Phases\Index.cshtml"
}

#line default
#line hidden
            BeginContext(5572, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FlowAuth.Models.Phase>> Html { get; private set; }
    }
}
#pragma warning restore 1591
