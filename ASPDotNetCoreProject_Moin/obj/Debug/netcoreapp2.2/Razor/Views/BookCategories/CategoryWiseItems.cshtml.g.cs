#pragma checksum "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\BookCategories\CategoryWiseItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a3f1e5eeeb5391a718bd62b9488ba1879d3db0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookCategories_CategoryWiseItems), @"mvc.1.0.view", @"/Views/BookCategories/CategoryWiseItems.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BookCategories/CategoryWiseItems.cshtml", typeof(AspNetCore.Views_BookCategories_CategoryWiseItems))]
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
#line 1 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\_ViewImports.cshtml"
using ASPDotNetCoreProject_Moin;

#line default
#line hidden
#line 2 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\_ViewImports.cshtml"
using ASPDotNetCoreProject_Moin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a3f1e5eeeb5391a718bd62b9488ba1879d3db0b", @"/Views/BookCategories/CategoryWiseItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"588f69c3241de2b252fc41afaf261dffd5221bf4", @"/Views/_ViewImports.cshtml")]
    public class Views_BookCategories_CategoryWiseItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASPDotNetCoreProject_Moin.Models.Books>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(60, 195, true);
            WriteLiteral("\r\n<h2 style=\"text-align:center;\">Book List Of This Category</h2>\r\n\r\n\r\n<table class=\"table table-bordered table-hover table-striped justify-content-center\">\r\n    <tr>\r\n\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(256, 40, false);
#line 10 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\BookCategories\CategoryWiseItems.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(296, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(340, 47, false);
#line 13 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\BookCategories\CategoryWiseItems.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(387, 45, true);
            WriteLiteral("\r\n        </th>\r\n\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(433, 49, false);
#line 17 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\BookCategories\CategoryWiseItems.cshtml"
       Write(Html.DisplayNameFor(model => model.PublishedDate));

#line default
#line hidden
            EndContext();
            BeginContext(482, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(526, 44, false);
#line 20 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\BookCategories\CategoryWiseItems.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(570, 55, true);
            WriteLiteral("\r\n        </th>\r\n        <th>Action</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 25 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\BookCategories\CategoryWiseItems.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(666, 50, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n\r\n                ");
            EndContext();
            BeginContext(717, 39, false);
#line 30 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\BookCategories\CategoryWiseItems.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(756, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(812, 46, false);
#line 33 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\BookCategories\CategoryWiseItems.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(858, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(916, 48, false);
#line 37 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\BookCategories\CategoryWiseItems.cshtml"
           Write(Html.DisplayFor(modelItem => item.PublishedDate));

#line default
#line hidden
            EndContext();
            BeginContext(964, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1020, 43, false);
#line 40 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\BookCategories\CategoryWiseItems.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1118, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a3f1e5eeeb5391a718bd62b9488ba1879d3db0b8854", async() => {
                BeginContext(1192, 6, true);
                WriteLiteral("Delete");
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
#line 43 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\BookCategories\CategoryWiseItems.cshtml"
                                             WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1202, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 46 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\BookCategories\CategoryWiseItems.cshtml"
    }

#line default
#line hidden
            BeginContext(1245, 12, true);
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASPDotNetCoreProject_Moin.Models.Books>> Html { get; private set; }
    }
}
#pragma warning restore 1591
