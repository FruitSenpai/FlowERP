#pragma checksum "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f71203cf1841685f4e55bb70d88fd0b727741dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Details), @"mvc.1.0.view", @"/Views/Projects/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projects/Details.cshtml", typeof(AspNetCore.Views_Projects_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f71203cf1841685f4e55bb70d88fd0b727741dc", @"/Views/Projects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89129962b79090d0f1ae5f5d5048e447eef01cf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlowAuth.Models.Project>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(75, 3640, true);
            WriteLiteral(@"<h2>Details</h2>
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
        animation");
            WriteLiteral(@": float 5s infinite;
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
        border-bottom-: 1px solid #C1C3D1;
        color: #666B85;
        font-size: 14px;
        font-weight: normal;
        text-shadow: 0 1px 1px rgba(256, 256, 256, 0.1);
    }

        tr:hover td {
            background: #4E5066;
            color: #FFFFFF;
            border-top: 1px solid #22262e;
        }

        tr:first-child {
            border-top: none;
        ");
            WriteLiteral(@"}

        tr:last-child {
            border-bottom: none;
        }

        tr:nth-child(odd) td {
            background: #EBEBEB;
        }

        tr:nth-child(odd):hover td {
            background: #4E5066;
        }

        tr:last-child td:first-child {
            border-bottom-left-radius: 3px;
        }

        tr:last-child td:last-child {
            border-bottom-right-radius: 3px;
        }

    td {
        background: #FFFFFF;
        padding: 20px;
        text-align: left;
        vertical-align: middle;
        font-weight: 300;
        font-size: 12px;
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
        text-align: left;
    }

   ");
            WriteLiteral(@" td.text-center {
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

    /* Add a background color and some padding around the form */


</style>
<div>
    <h4>Project</h4>
    <hr />
    <dl class=""dl-horizontal"">
        <dt>
            ");
            EndContext();
            BeginContext(3716, 55, false);
#line 174 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project_description));

#line default
#line hidden
            EndContext();
            BeginContext(3771, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3815, 51, false);
#line 177 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project_description));

#line default
#line hidden
            EndContext();
            BeginContext(3866, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3910, 52, false);
#line 180 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project_location));

#line default
#line hidden
            EndContext();
            BeginContext(3962, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4006, 48, false);
#line 183 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project_location));

#line default
#line hidden
            EndContext();
            BeginContext(4054, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4098, 50, false);
#line 186 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project_nature));

#line default
#line hidden
            EndContext();
            BeginContext(4148, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4192, 46, false);
#line 189 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project_nature));

#line default
#line hidden
            EndContext();
            BeginContext(4238, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4282, 53, false);
#line 192 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project_startDate));

#line default
#line hidden
            EndContext();
            BeginContext(4335, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4379, 49, false);
#line 195 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project_startDate));

#line default
#line hidden
            EndContext();
            BeginContext(4428, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4472, 51, false);
#line 198 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project_dueDate));

#line default
#line hidden
            EndContext();
            BeginContext(4523, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4567, 47, false);
#line 201 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project_dueDate));

#line default
#line hidden
            EndContext();
            BeginContext(4614, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4658, 51, false);
#line 204 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project_endDate));

#line default
#line hidden
            EndContext();
            BeginContext(4709, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4753, 47, false);
#line 207 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project_endDate));

#line default
#line hidden
            EndContext();
            BeginContext(4800, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4844, 50, false);
#line 210 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project_budget));

#line default
#line hidden
            EndContext();
            BeginContext(4894, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4938, 46, false);
#line 213 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project_budget));

#line default
#line hidden
            EndContext();
            BeginContext(4984, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5028, 50, false);
#line 216 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project_status));

#line default
#line hidden
            EndContext();
            BeginContext(5078, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5122, 46, false);
#line 219 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project_status));

#line default
#line hidden
            EndContext();
            BeginContext(5168, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5212, 42, false);
#line 222 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client));

#line default
#line hidden
            EndContext();
            BeginContext(5254, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5298, 50, false);
#line 225 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client.Client_name));

#line default
#line hidden
            EndContext();
            BeginContext(5348, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5409, 42, false);
#line 228 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phases));

#line default
#line hidden
            EndContext();
            BeginContext(5451, 281, true);
            WriteLiteral(@"
        </dt>
        <dd class=""col-sm-10"">
            <table class=""table"">
                <tr>
                    <th>Name</th>
                    <th>Start Date</th>
                    <th>End Date</th>
                    <th>Budget</th>
                </tr>
");
            EndContext();
#line 238 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
                 foreach (var item in Model.Phases)
                {

#line default
#line hidden
            BeginContext(5804, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5889, 55, false);
#line 242 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PhaseName.Phase_name));

#line default
#line hidden
            EndContext();
            BeginContext(5944, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(6036, 50, false);
#line 245 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Phase_startDate));

#line default
#line hidden
            EndContext();
            BeginContext(6086, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(6178, 48, false);
#line 248 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Phase_endDate));

#line default
#line hidden
            EndContext();
            BeginContext(6226, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(6318, 47, false);
#line 251 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Phase_budget));

#line default
#line hidden
            EndContext();
            BeginContext(6365, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 254 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(6444, 67, true);
            WriteLiteral("            </table>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(6511, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14bb4ed66ef4456ca89b63f32524066b", async() => {
                BeginContext(6567, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 260 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Projects\Details.cshtml"
                           WriteLiteral(Model.Project_Code);

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
            BeginContext(6575, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(6583, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "639fb9a0220b4dd9a3dabe43dd20ad3a", async() => {
                BeginContext(6605, 12, true);
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
            BeginContext(6621, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlowAuth.Models.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
