#pragma checksum "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Claims\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aba619197b211f033e1337647fc67f5a271a51a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Claims_Index), @"mvc.1.0.view", @"/Views/Claims/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Claims/Index.cshtml", typeof(AspNetCore.Views_Claims_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aba619197b211f033e1337647fc67f5a271a51a", @"/Views/Claims/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89129962b79090d0f1ae5f5d5048e447eef01cf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Claims_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FlowAuth.Models.Claim>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Claims\Index.cshtml"
  
    ViewData["Title"] = "All";

#line default
#line hidden
            BeginContext(84, 3722, true);
            WriteLiteral(@"
<h2>My Claims</h2>
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
        anima");
            WriteLiteral(@"tion: float 5s infinite;
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
            WriteLiteral(@"
        tr:last-child {
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
        t");
            WriteLiteral(@"ext-align: left;
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

");
            EndContext();
#line 179 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Claims\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(3836, 52, true);
            WriteLiteral("    <p style=\"float:right;\">\r\n        Find by name: ");
            EndContext();
            BeginContext(3889, 28, false);
#line 182 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Claims\Index.cshtml"
                 Write(Html.TextBox("SearchString"));

#line default
#line hidden
            EndContext();
            BeginContext(3917, 239, true);
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Search\" style=\"border-radius:2px;background-color: white; color:black;padding: 6px;\r\n        border: none;\r\n        margin-top: 8px;\r\n        margin-right: 16px;\r\n        font-size: 17px;\" />\r\n        ");
            EndContext();
            BeginContext(4156, 315, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56e89443b9a84495be709ef0d82eb2cf", async() => {
                BeginContext(4178, 289, true);
                WriteLiteral(@"
            <button style=""border-radius:2px;background-color: white; color:black;padding: 4px;
        border: none;
        margin-top: 8px;
        margin-right: 16px;
        font-size: 14px;"">
                <i class=""material-icons"">reply</i>
            </button>
        ");
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
            BeginContext(4471, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 198 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Claims\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4486, 9, true);
            WriteLiteral("<p>\r\n    ");
            EndContext();
            BeginContext(4495, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4dd2e076aeb451ca69c20de89217fb3", async() => {
                BeginContext(4518, 40, true);
                WriteLiteral("<button type=\"button\">Add claim</button>");
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
            BeginContext(4562, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(4655, 53, false);
#line 206 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Claims\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Claim_description));

#line default
#line hidden
            EndContext();
            BeginContext(4708, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(4764, 46, false);
#line 209 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Claims\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Claim_date));

#line default
#line hidden
            EndContext();
            BeginContext(4810, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(4866, 48, false);
#line 212 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Claims\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Claim_amount));

#line default
#line hidden
            EndContext();
            BeginContext(4914, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(4970, 48, false);
#line 215 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Claims\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Claim_status));

#line default
#line hidden
            EndContext();
            BeginContext(5018, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(5074, 43, false);
#line 218 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Claims\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AppUser));

#line default
#line hidden
            EndContext();
            BeginContext(5117, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 224 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Claims\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(5252, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5313, 52, false);
#line 228 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Claims\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Claim_description));

#line default
#line hidden
            EndContext();
            BeginContext(5365, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5433, 45, false);
#line 231 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Claims\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Claim_date));

#line default
#line hidden
            EndContext();
            BeginContext(5478, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5546, 47, false);
#line 234 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Claims\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Claim_amount));

#line default
#line hidden
            EndContext();
            BeginContext(5593, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5661, 47, false);
#line 237 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Claims\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Claim_status));

#line default
#line hidden
            EndContext();
            BeginContext(5708, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5776, 63, false);
#line 240 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Claims\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.AppUser.Staff.Staff_fullName));

#line default
#line hidden
            EndContext();
            BeginContext(5839, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5906, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85b5992801ab4910a6685b6ae2f0e817", async() => {
                BeginContext(5959, 65, true);
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
#line 243 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Claims\Index.cshtml"
                                              WriteLiteral(item.ClaimID);

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
            BeginContext(6028, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 246 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Claims\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(6083, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FlowAuth.Models.Claim>> Html { get; private set; }
    }
}
#pragma warning restore 1591
