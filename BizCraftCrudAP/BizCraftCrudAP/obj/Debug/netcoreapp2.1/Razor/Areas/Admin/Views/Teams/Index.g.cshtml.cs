#pragma checksum "C:\Users\User\Desktop\PUSHIT\Asp.Net Core SamD pushit\Homework - ASP Admin panel CRUD 17.10\p310-17-10-2019-Teymurff\BizCraftCrudAP\BizCraftCrudAP\Areas\Admin\Views\Teams\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a46d3d67dfb82a70d4a7002ff85ce3168761ef4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Teams_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Teams/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Teams/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Teams_Index))]
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
#line 1 "C:\Users\User\Desktop\PUSHIT\Asp.Net Core SamD pushit\Homework - ASP Admin panel CRUD 17.10\p310-17-10-2019-Teymurff\BizCraftCrudAP\BizCraftCrudAP\Areas\Admin\Views\_ViewImports.cshtml"
using BizCraftCrudAP.Models;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\PUSHIT\Asp.Net Core SamD pushit\Homework - ASP Admin panel CRUD 17.10\p310-17-10-2019-Teymurff\BizCraftCrudAP\BizCraftCrudAP\Areas\Admin\Views\_ViewImports.cshtml"
using BizCraftCrudAP.DAL;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\PUSHIT\Asp.Net Core SamD pushit\Homework - ASP Admin panel CRUD 17.10\p310-17-10-2019-Teymurff\BizCraftCrudAP\BizCraftCrudAP\Areas\Admin\Views\_ViewImports.cshtml"
using BizCraftCrudAP.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a46d3d67dfb82a70d4a7002ff85ce3168761ef4", @"/Areas/Admin/Views/Teams/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af23b7c753d25443f5a64a103528d3de999cd247", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Teams_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Team>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\PUSHIT\Asp.Net Core SamD pushit\Homework - ASP Admin panel CRUD 17.10\p310-17-10-2019-Teymurff\BizCraftCrudAP\BizCraftCrudAP\Areas\Admin\Views\Teams\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(126, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(132, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb961f3fd9b8403cb487a33d7df450cd", async() => {
                BeginContext(194, 31, true);
                WriteLiteral("\r\n        Create New Team\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(229, 568, true);
            WriteLiteral(@"

    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Photo</th>
                <th scope=""col"">Full Name</th>
                <th scope=""col"">Position</th>
                <th scope=""col"">Facebook Logo</th>
                <th scope=""col"">Twitter Logo</th>
                <th scope=""col"">Google Logo</th>
                <th scope=""col"">Linkedin Logo</th>
                <th scope=""col"">Other Logo</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 26 "C:\Users\User\Desktop\PUSHIT\Asp.Net Core SamD pushit\Homework - ASP Admin panel CRUD 17.10\p310-17-10-2019-Teymurff\BizCraftCrudAP\BizCraftCrudAP\Areas\Admin\Views\Teams\Index.cshtml"
             foreach (var teamadm in Model)
            {

#line default
#line hidden
            BeginContext(857, 74, true);
            WriteLiteral("                <tr class=\"bg-dark\">\r\n                    <th scope=\"row\">");
            EndContext();
            BeginContext(932, 10, false);
#line 29 "C:\Users\User\Desktop\PUSHIT\Asp.Net Core SamD pushit\Homework - ASP Admin panel CRUD 17.10\p310-17-10-2019-Teymurff\BizCraftCrudAP\BizCraftCrudAP\Areas\Admin\Views\Teams\Index.cshtml"
                               Write(teamadm.Id);

#line default
#line hidden
            EndContext();
            BeginContext(942, 32, true);
            WriteLiteral("</th>\r\n                    <td> ");
            EndContext();
            BeginContext(974, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f2a8f3d21073403c83385b5299154b5d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 984, "~/images/team/", 984, 14, true);
#line 30 "C:\Users\User\Desktop\PUSHIT\Asp.Net Core SamD pushit\Homework - ASP Admin panel CRUD 17.10\p310-17-10-2019-Teymurff\BizCraftCrudAP\BizCraftCrudAP\Areas\Admin\Views\Teams\Index.cshtml"
AddHtmlAttributeValue("", 998, teamadm.Image, 998, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1025, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1057, 26, false);
#line 31 "C:\Users\User\Desktop\PUSHIT\Asp.Net Core SamD pushit\Homework - ASP Admin panel CRUD 17.10\p310-17-10-2019-Teymurff\BizCraftCrudAP\BizCraftCrudAP\Areas\Admin\Views\Teams\Index.cshtml"
                   Write(Html.Raw(teamadm.Fullname));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1115, 26, false);
#line 32 "C:\Users\User\Desktop\PUSHIT\Asp.Net Core SamD pushit\Homework - ASP Admin panel CRUD 17.10\p310-17-10-2019-Teymurff\BizCraftCrudAP\BizCraftCrudAP\Areas\Admin\Views\Teams\Index.cshtml"
                   Write(Html.Raw(teamadm.Position));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1173, 26, false);
#line 33 "C:\Users\User\Desktop\PUSHIT\Asp.Net Core SamD pushit\Homework - ASP Admin panel CRUD 17.10\p310-17-10-2019-Teymurff\BizCraftCrudAP\BizCraftCrudAP\Areas\Admin\Views\Teams\Index.cshtml"
                   Write(Html.Raw(teamadm.Facelogo));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1231, 26, false);
#line 34 "C:\Users\User\Desktop\PUSHIT\Asp.Net Core SamD pushit\Homework - ASP Admin panel CRUD 17.10\p310-17-10-2019-Teymurff\BizCraftCrudAP\BizCraftCrudAP\Areas\Admin\Views\Teams\Index.cshtml"
                   Write(Html.Raw(teamadm.Twitlogo));

#line default
#line hidden
            EndContext();
            BeginContext(1257, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1289, 26, false);
#line 35 "C:\Users\User\Desktop\PUSHIT\Asp.Net Core SamD pushit\Homework - ASP Admin panel CRUD 17.10\p310-17-10-2019-Teymurff\BizCraftCrudAP\BizCraftCrudAP\Areas\Admin\Views\Teams\Index.cshtml"
                   Write(Html.Raw(teamadm.Googlogo));

#line default
#line hidden
            EndContext();
            BeginContext(1315, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1347, 27, false);
#line 36 "C:\Users\User\Desktop\PUSHIT\Asp.Net Core SamD pushit\Homework - ASP Admin panel CRUD 17.10\p310-17-10-2019-Teymurff\BizCraftCrudAP\BizCraftCrudAP\Areas\Admin\Views\Teams\Index.cshtml"
                   Write(Html.Raw(teamadm.Linkelogo));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1406, 27, false);
#line 37 "C:\Users\User\Desktop\PUSHIT\Asp.Net Core SamD pushit\Homework - ASP Admin panel CRUD 17.10\p310-17-10-2019-Teymurff\BizCraftCrudAP\BizCraftCrudAP\Areas\Admin\Views\Teams\Index.cshtml"
                   Write(Html.Raw(teamadm.Otherlogo));

#line default
#line hidden
            EndContext();
            BeginContext(1433, 107, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <div class=\"d-flex\">\r\n                            ");
            EndContext();
            BeginContext(1540, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bb54461d77642828ee8e84ce2cadf03", async() => {
                BeginContext(1609, 97, true);
                WriteLiteral("\r\n                                <i class=\"fas fa-pencil-alt\"></i>\r\n                            ");
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
#line 40 "C:\Users\User\Desktop\PUSHIT\Asp.Net Core SamD pushit\Homework - ASP Admin panel CRUD 17.10\p310-17-10-2019-Teymurff\BizCraftCrudAP\BizCraftCrudAP\Areas\Admin\Views\Teams\Index.cshtml"
                                                   WriteLiteral(teamadm.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1710, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1740, 169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2150fadd79804b0cb4a0fbfdd95bbef9", async() => {
                BeginContext(1813, 92, true);
                WriteLiteral("\r\n                                <i class=\"fas fa-trash\"></i>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\User\Desktop\PUSHIT\Asp.Net Core SamD pushit\Homework - ASP Admin panel CRUD 17.10\p310-17-10-2019-Teymurff\BizCraftCrudAP\BizCraftCrudAP\Areas\Admin\Views\Teams\Index.cshtml"
                                                     WriteLiteral(teamadm.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1909, 84, true);
            WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 49 "C:\Users\User\Desktop\PUSHIT\Asp.Net Core SamD pushit\Homework - ASP Admin panel CRUD 17.10\p310-17-10-2019-Teymurff\BizCraftCrudAP\BizCraftCrudAP\Areas\Admin\Views\Teams\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2008, 34, true);
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Team>> Html { get; private set; }
    }
}
#pragma warning restore 1591
