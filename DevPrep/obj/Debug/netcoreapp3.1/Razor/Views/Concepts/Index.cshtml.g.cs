#pragma checksum "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68e2d53e392ebc1a13736b860ba385e502927c9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Concepts_Index), @"mvc.1.0.view", @"/Views/Concepts/Index.cshtml")]
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
#line 1 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\_ViewImports.cshtml"
using DevPrep;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\_ViewImports.cshtml"
using DevPrep.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68e2d53e392ebc1a13736b860ba385e502927c9e", @"/Views/Concepts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84405db5c40f1695f39328c7299ff054fba575aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Concepts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevPrep.Models.ViewModels.ConceptViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Concepts</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68e2d53e392ebc1a13736b860ba385e502927c9e3677", async() => {
                WriteLiteral("Create New Concept");
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
#nullable restore
#line 11 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
                             WriteLiteral(Model.ConceptsWithStuff[0].SoftwareLanguageId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n\r\n        <tr>\r\n            <th scope=\"col\">Concepts</th>\r\n            <th scope=\"col\">Descriptions</th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
         foreach (var item in Model.ConceptsWithStuff)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 27 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
                            Write(item.ConceptName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    \r\n                <td>\r\n");
#nullable restore
#line 30 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
                     foreach (var des in item.Descriptions)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        ");
#nullable restore
#line 33 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
                   Write(des.Paragraph);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input type=\"button\" value=\"-\" class=\"btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 816, "\"", 900, 3);
            WriteAttributeValue("", 826, "location.href=\'", 826, 15, true);
#nullable restore
#line 33 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
WriteAttributeValue("", 841, Url.Action("Delete", "Descriptions", new { id = des.id }), 841, 58, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 899, "\'", 899, 1, true);
            EndWriteAttribute();
            WriteLiteral(" /><input type=\"button\" value=\"+\" class=\"btn-outline-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 962, "\"", 1054, 3);
            WriteAttributeValue("", 972, "location.href=\'", 972, 15, true);
#nullable restore
#line 33 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
WriteAttributeValue("", 987, Url.Action("Create", "Descriptions", new { id = item.ConceptId }), 987, 66, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1053, "\'", 1053, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                    </li>\r\n");
#nullable restore
#line 36 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                    <ul>\r\n");
#nullable restore
#line 42 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
                         foreach (var link in item.UsefulLinks)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                            ");
#nullable restore
#line 45 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
                       Write(link.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <a");
            BeginWriteAttribute("href", " href=\"", 1311, "\"", 1335, 2);
            WriteAttributeValue("", 1318, "http://", 1318, 7, true);
#nullable restore
#line 45 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
WriteAttributeValue("", 1325, link.Link, 1325, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 45 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
                                                                                Write(link.Link);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a> \r\n");
#nullable restore
#line 46 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
                             if (@link.ApplicationUserId == @Model.LoggedInUser.Id) {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input type=\"button\" value=\"-\" class=\"btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1506, "\"", 1590, 3);
            WriteAttributeValue("", 1516, "location.href=\'", 1516, 15, true);
#nullable restore
#line 46 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
WriteAttributeValue("", 1531, Url.Action("Delete", "UsefulLinks", new { id = link.id }), 1531, 58, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1589, "\'", 1589, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />");
#nullable restore
#line 46 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
                                                                                                                                                                                                                               } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </li>\r\n");
#nullable restore
#line 48 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div> ");
#nullable restore
#line 49 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
                         Write(Html.ActionLink("Add Link", "Create", "UsefulLinks", new { id = item.ConceptId }, new { area = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </ul>\r\n                </td>\r\n            </tr>\r\n        <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 54 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
                           Write(Html.ActionLink("Delete", "Delete", new { id = item.ConceptId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |  ");
#nullable restore
#line 54 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
                                                                                                Write(Html.ActionLink("Edit", "Edit", new { id = item.ConceptId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n           \r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\rebec\source\repos\DevPrep\DevPrep\Views\Concepts\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevPrep.Models.ViewModels.ConceptViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
