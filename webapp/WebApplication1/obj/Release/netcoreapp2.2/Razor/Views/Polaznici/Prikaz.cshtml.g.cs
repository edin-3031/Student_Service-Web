#pragma checksum "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d500b80c6baea34290f23084613f606c142f6f71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Polaznici_Prikaz), @"mvc.1.0.view", @"/Views/Polaznici/Prikaz.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Polaznici/Prikaz.cshtml", typeof(AspNetCore.Views_Polaznici_Prikaz))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d500b80c6baea34290f23084613f606c142f6f71", @"/Views/Polaznici/Prikaz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Polaznici_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Prikaz/PolaznikPrikaz.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Poruke_Span.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d500b80c6baea34290f23084613f606c142f6f714237", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(66, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d500b80c6baea34290f23084613f606c142f6f715487", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
  
    ViewData["Title"] = "Polaznici";
    List<PrikazPolaznika> podaci = (List<PrikazPolaznika>)ViewData["Student"];

    int brojac = 0;

    string porukaGreska = (string)TempData["greska"];
    string porukaUspjeh = (string)TempData["uspjesno"];

#line default
#line hidden
            BeginContext(384, 72, true);
            WriteLiteral("\r\n<h1 style=\"text-align:center; font-family:Consolas\">Polaznici</h1>\r\n\r\n");
            EndContext();
#line 15 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
 if (porukaGreska != null)
{

#line default
#line hidden
            BeginContext(485, 35, true);
            WriteLiteral("<center>\r\n        <div id=\"poruka\">");
            EndContext();
            BeginContext(521, 12, false);
#line 17 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
                    Write(porukaGreska);

#line default
#line hidden
            EndContext();
            BeginContext(533, 197, true);
            WriteLiteral("</div>\r\n    </center>\r\n    <script>\r\n        $(\"#poruka\").slideUp(1);\r\n        $(\"#poruka\").slideDown(1500);\r\n        $(\"#poruka\").delay(2000);\r\n        $(\"#poruka\").slideUp(1500);\r\n    </script>\r\n");
            EndContext();
#line 25 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
}

#line default
#line hidden
#line 26 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
 if (porukaUspjeh != null)
{

#line default
#line hidden
            BeginContext(764, 40, true);
            WriteLiteral("    <center>\r\n        <div id=\"poruka2\">");
            EndContext();
            BeginContext(805, 12, false);
#line 29 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
                     Write(porukaUspjeh);

#line default
#line hidden
            EndContext();
            BeginContext(817, 201, true);
            WriteLiteral("</div>\r\n    </center>\r\n    <script>\r\n        $(\"#poruka2\").slideUp(1);\r\n        $(\"#poruka2\").slideDown(1500);\r\n        $(\"#poruka2\").delay(2000);\r\n        $(\"#poruka2\").slideUp(1500);\r\n    </script>\r\n");
            EndContext();
#line 37 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
}

#line default
#line hidden
            BeginContext(1021, 479, true);
            WriteLiteral(@"
<table class=""table polaznici-table"" style=""font-family:Consolas"">
    <thead>
    <th>RB</th>
    <th>Ime i prezime</th>
    <th>Datum rođenja</th>
    <th>Spol</th>
    <th>Indeks</th>
    <th>Mail</th>
    <th>Telefon</th>
    <th>Status</th>
    <th>Način studija</th>
    <th>Upisan semestar</th>
    <th>Ovjeren semestar</th>
    <th>Godina studija</th>
    <th>Obnavlja godinu</th>
    <th>Prosječna ocjena</th>
    <th></th>
    </thead>
    <tbody>
");
            EndContext();
#line 58 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
         foreach (var x in podaci)
        {

#line default
#line hidden
            BeginContext(1547, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1587, 8, false);
#line 61 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
                Write(++brojac);

#line default
#line hidden
            EndContext();
            BeginContext(1596, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1624, 5, false);
#line 62 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
               Write(x.ime);

#line default
#line hidden
            EndContext();
            BeginContext(1629, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1631, 9, false);
#line 62 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
                      Write(x.prezime);

#line default
#line hidden
            EndContext();
            BeginContext(1640, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1668, 25, false);
#line 63 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
               Write(x.datum_rodjenja.Date.Day);

#line default
#line hidden
            EndContext();
            BeginContext(1693, 1, true);
            WriteLiteral(".");
            EndContext();
            BeginContext(1695, 27, false);
#line 63 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
                                          Write(x.datum_rodjenja.Date.Month);

#line default
#line hidden
            EndContext();
            BeginContext(1722, 1, true);
            WriteLiteral(".");
            EndContext();
            BeginContext(1724, 26, false);
#line 63 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
                                                                       Write(x.datum_rodjenja.Date.Year);

#line default
#line hidden
            EndContext();
            BeginContext(1750, 28, true);
            WriteLiteral(".</td>\r\n                <td>");
            EndContext();
            BeginContext(1779, 6, false);
#line 64 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
               Write(x.spol);

#line default
#line hidden
            EndContext();
            BeginContext(1785, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1813, 14, false);
#line 65 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
               Write(x.broj_dosijea);

#line default
#line hidden
            EndContext();
            BeginContext(1827, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1855, 6, false);
#line 66 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
               Write(x.mail);

#line default
#line hidden
            EndContext();
            BeginContext(1861, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1889, 9, false);
#line 67 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
               Write(x.telefon);

#line default
#line hidden
            EndContext();
            BeginContext(1898, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1926, 8, false);
#line 68 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
               Write(x.status);

#line default
#line hidden
            EndContext();
            BeginContext(1934, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1962, 18, false);
#line 69 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
               Write(x.nacin_studiranja);

#line default
#line hidden
            EndContext();
            BeginContext(1980, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2008, 17, false);
#line 70 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
               Write(x.upisan_semestar);

#line default
#line hidden
            EndContext();
            BeginContext(2025, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2053, 18, false);
#line 71 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
               Write(x.ovjeren_semestar);

#line default
#line hidden
            EndContext();
            BeginContext(2071, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2099, 16, false);
#line 72 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
               Write(x.godina_studija);

#line default
#line hidden
            EndContext();
            BeginContext(2115, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2143, 17, false);
#line 73 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
               Write(x.obnavlja_godinu);

#line default
#line hidden
            EndContext();
            BeginContext(2160, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2188, 18, false);
#line 74 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
               Write(x.prosjecna_ocjena);

#line default
#line hidden
            EndContext();
            BeginContext(2206, 72, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2278, "\"", 2312, 2);
            WriteAttributeValue("", 2285, "UrediForm?id=", 2285, 13, true);
#line 76 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
WriteAttributeValue("", 2298, x.Polaznik_Id, 2298, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2313, 103, true);
            WriteLiteral(">Uredi</a>\r\n                </td>\r\n                <td>\r\n                    <a class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2416, "\"", 2443, 2);
            WriteAttributeValue("", 2421, "Detalji_", 2421, 8, true);
#line 79 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
WriteAttributeValue("", 2429, x.Polaznik_Id, 2429, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2444, 76, true);
            WriteLiteral(">Detalji</a>\r\n                    <script>\r\n                    $(\"#Detalji_");
            EndContext();
            BeginContext(2521, 13, false);
#line 81 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
                           Write(x.Polaznik_Id);

#line default
#line hidden
            EndContext();
            BeginContext(2534, 83, true);
            WriteLiteral("\").click(function(event){\r\n                        $.get(\"/Ajax/DetaljiPolaznik?id=");
            EndContext();
            BeginContext(2618, 13, false);
#line 82 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
                                                   Write(x.Polaznik_Id);

#line default
#line hidden
            EndContext();
            BeginContext(2631, 300, true);
            WriteLiteral(@""", function(result){
                            $(""#box"").html(result);
                            $(""#box"").css(""border"", ""5px solid black"");
                        });
                    });
                    </script>
                </td>
                <td>
                    <a");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2931, "\"", 2956, 2);
            WriteAttributeValue("", 2936, "mouse_", 2936, 6, true);
#line 90 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
WriteAttributeValue("", 2942, x.Polaznik_Id, 2942, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2957, 23, true);
            WriteLiteral(" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2980, "\"", 3016, 2);
            WriteAttributeValue("", 2987, "Ukloni?trazeni=", 2987, 15, true);
#line 90 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
WriteAttributeValue("", 3002, x.Polaznik_Id, 3002, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3017, 38, true);
            WriteLiteral(">Ukloni</a>\r\n                <td><span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3055, "\"", 3082, 2);
            WriteAttributeValue("", 3060, "warning_", 3060, 8, true);
#line 91 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
WriteAttributeValue("", 3068, x.Polaznik_Id, 3068, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3083, 15, true);
            WriteLiteral("></span></td>\r\n");
            EndContext();
            BeginContext(3699, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 104 "C:\Users\Edin\Desktop\seminarski_rad\webapp\WebApplication1\Views\Polaznici\Prikaz.cshtml"
        }

#line default
#line hidden
            BeginContext(3752, 34, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<center>\r\n");
            EndContext();
            BeginContext(3871, 123, true);
            WriteLiteral("    <a class=\"btn btn-success\" href=\"DodajNovog\">Dodaj novog polaznika</a><br /><br />\r\n</center>\r\n\r\n<div id=\"box\">\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591