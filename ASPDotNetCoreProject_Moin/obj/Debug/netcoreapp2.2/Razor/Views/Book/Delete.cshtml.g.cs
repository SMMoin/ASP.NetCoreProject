#pragma checksum "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\Book\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f487eac9cde8d2a31871e08cb31c3600a367f47a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Delete), @"mvc.1.0.view", @"/Views/Book/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Delete.cshtml", typeof(AspNetCore.Views_Book_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f487eac9cde8d2a31871e08cb31c3600a367f47a", @"/Views/Book/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"588f69c3241de2b252fc41afaf261dffd5221bf4", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASPDotNetCoreProject_Moin.Models.BooksInfo>
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
            BeginContext(50, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\Book\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(90, 152, true);
            WriteLiteral("\n<h1>Delete</h1>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    \n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(243, 48, false);
#line 15 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\Book\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AuthorNumber));

#line default
#line hidden
            EndContext();
            BeginContext(291, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(352, 44, false);
#line 18 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\Book\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AuthorNumber));

#line default
#line hidden
            EndContext();
            BeginContext(396, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(456, 44, false);
#line 21 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\Book\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BookName));

#line default
#line hidden
            EndContext();
            BeginContext(500, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(561, 40, false);
#line 24 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\Book\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BookName));

#line default
#line hidden
            EndContext();
            BeginContext(601, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(661, 46, false);
#line 27 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\Book\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AuthorName));

#line default
#line hidden
            EndContext();
            BeginContext(707, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(768, 42, false);
#line 30 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\Book\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AuthorName));

#line default
#line hidden
            EndContext();
            BeginContext(810, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(870, 43, false);
#line 33 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\Book\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ISBCode));

#line default
#line hidden
            EndContext();
            BeginContext(913, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(974, 39, false);
#line 36 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\Book\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ISBCode));

#line default
#line hidden
            EndContext();
            BeginContext(1013, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1073, 41, false);
#line 39 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\Book\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1114, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1175, 37, false);
#line 42 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\Book\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1212, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1272, 50, false);
#line 45 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\Book\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PublishingDate));

#line default
#line hidden
            EndContext();
            BeginContext(1322, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1383, 46, false);
#line 48 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\Book\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PublishingDate));

#line default
#line hidden
            EndContext();
            BeginContext(1429, 34, true);
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            EndContext();
            BeginContext(1463, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f487eac9cde8d2a31871e08cb31c3600a367f47a10979", async() => {
                BeginContext(1489, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1498, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f487eac9cde8d2a31871e08cb31c3600a367f47a11369", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 53 "F:\Moin_44\1257629_CoreProject_Final\1257629_CoreProject_10012021\ASPDotNetCoreProject_Moin\ASPDotNetCoreProject_Moin\Views\Book\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BookId);

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
                BeginContext(1538, 81, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        ");
                EndContext();
                BeginContext(1619, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f487eac9cde8d2a31871e08cb31c3600a367f47a13338", async() => {
                    BeginContext(1641, 12, true);
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
                BeginContext(1657, 5, true);
                WriteLiteral("\n    ");
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
            BeginContext(1669, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPDotNetCoreProject_Moin.Models.BooksInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
