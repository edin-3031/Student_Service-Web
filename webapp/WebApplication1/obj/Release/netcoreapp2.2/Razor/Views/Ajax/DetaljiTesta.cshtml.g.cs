#pragma checksum "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiTesta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e757a955cb3a01bd19b5d53be1a2570d6fd993d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ajax_DetaljiTesta), @"mvc.1.0.view", @"/Views/Ajax/DetaljiTesta.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ajax/DetaljiTesta.cshtml", typeof(AspNetCore.Views_Ajax_DetaljiTesta))]
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
#line 1 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e757a955cb3a01bd19b5d53be1a2570d6fd993d1", @"/Views/Ajax/DetaljiTesta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Ajax_DetaljiTesta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.VM.TestDetaljiVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ajax", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ZatvoriTest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiTesta.cshtml"
  
    ViewData["Title"] = "DetaljiTesta";

#line default
#line hidden
            BeginContext(96, 123, true);
            WriteLiteral("\r\n<center style=\"border-style:groove; margin-top:10px; padding-bottom:10px; border-color:grey\">\r\n    <h2>Detalji</h2>\r\n    ");
            EndContext();
            BeginContext(219, 1037, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e757a955cb3a01bd19b5d53be1a2570d6fd993d14344", async() => {
                BeginContext(272, 44, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"TestID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 316, "\"", 337, 1);
#line 9 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiTesta.cshtml"
WriteAttributeValue("", 324, Model.TestID, 324, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(338, 115, true);
                WriteLiteral(" />\r\n        <div class=\"form-group\">\r\n            <label>Kurs:</label>\r\n            <input type=\"text\" name=\"Kurs\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 453, "\"", 472, 1);
#line 12 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiTesta.cshtml"
WriteAttributeValue("", 461, Model.Kurs, 461, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(473, 152, true);
                WriteLiteral(" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Broj pitanja:</label>\r\n            <input type=\"text\" class=\"izmjenaBrPitanja\"");
                EndContext();
                BeginWriteAttribute("idtesta", " idtesta=\"", 625, "\"", 648, 1);
#line 16 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiTesta.cshtml"
WriteAttributeValue("", 635, Model.TestID, 635, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(649, 17, true);
                WriteLiteral(" name=\"BrPitanja\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 666, "\"", 692, 1);
#line 16 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiTesta.cshtml"
WriteAttributeValue("", 674, Model.BrojPitanja, 674, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(693, 147, true);
                WriteLiteral(" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Trajanje:</label>\r\n            <input type=\"text\" class=\"izmjenaTrajanje\"");
                EndContext();
                BeginWriteAttribute("idtesta", " idtesta=\"", 840, "\"", 863, 1);
#line 20 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiTesta.cshtml"
WriteAttributeValue("", 850, Model.TestID, 850, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(864, 16, true);
                WriteLiteral(" name=\"Trajanje\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 880, "\"", 903, 1);
#line 20 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiTesta.cshtml"
WriteAttributeValue("", 888, Model.Trajanje, 888, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(904, 158, true);
                WriteLiteral(" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Max. broj bodova:</label>\r\n            <input type=\"text\" class=\"izmjenaMaxBrBodova\"");
                EndContext();
                BeginWriteAttribute("idtesta", " idtesta=\"", 1062, "\"", 1085, 1);
#line 24 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiTesta.cshtml"
WriteAttributeValue("", 1072, Model.TestID, 1072, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1086, 19, true);
                WriteLiteral(" name=\"MaxBrBodova\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1105, "\"", 1131, 1);
#line 24 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiTesta.cshtml"
WriteAttributeValue("", 1113, Model.MaxBrBodova, 1113, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1132, 117, true);
                WriteLiteral(" />\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-default\" value=\"ZatvoriTest\">Zatvori</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1256, 1252, true);
            WriteLiteral(@"
</center>

<script>
    $(function (event) {
        $("".izmjenaBrPitanja"").change(function (event) {
            var brPitanja = $(this).val();
            var idtesta = $(this).attr(""idtesta"");
            $.get(""/Ajax/IzmjenaBrPitanja?TestID="" + parseInt(idtesta) + ""&BrPitanja="" + brPitanja,
                function (rezultat, status) {
                    $(""ajaxDivTestovi"").html(rezultat);
                });
        });
        $("".izmjenaTrajanje"").change(function (event) {
            var trajanje = $(this).val();
            var idtesta = $(this).attr(""idtesta"");
            $.get(""/Ajax/IzmjenaTrajanjeTesta?TestID="" + parseInt(idtesta) + ""&Trajanje="" + trajanje,
                function (rezultat, status) {
                    $(""ajaxDivTestovi"").html(rezultat);
                });
        });
        $("".izmjenaMaxBrBodova"").change(function (event) {
            var maxBodovi = $(this).val();
            var idtesta = $(this).attr(""idtesta"");
            $.get(""/Ajax/Izmjen");
            WriteLiteral("aMaxBodova?TestID=\" + parseInt(idtesta) + \"&MaxBodovi=\" + maxBodovi,\r\n                function (rezultat, status) {\r\n                    $(\"ajaxDivTestovi\").html(rezultat);\r\n                });\r\n        });\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.VM.TestDetaljiVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
