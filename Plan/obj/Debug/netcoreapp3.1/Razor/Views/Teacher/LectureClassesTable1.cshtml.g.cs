#pragma checksum "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc5011ad5b9bed0791abd5ab5daaf49041250af1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_LectureClassesTable1), @"mvc.1.0.view", @"/Views/Teacher/LectureClassesTable1.cshtml")]
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
#line 1 "D:\Мої роботи\Редагований план\Plan\Plan\Views\_ViewImports.cshtml"
using Plan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Мої роботи\Редагований план\Plan\Plan\Views\_ViewImports.cshtml"
using Plan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc5011ad5b9bed0791abd5ab5daaf49041250af1", @"/Views/Teacher/LectureClassesTable1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fe073400293a4c6f85b13112635ee6f8959ba13", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_LectureClassesTable1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Plan.ViewModels.ListLectureClasses1ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/fontawesome-free/css/all.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/sb-admin-2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/datatables/dataTables.bootstrap4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/bootstrap/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery-easing/jquery.easing.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/sb-admin-2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/datatables/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/datatables/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/demo/datatables-demo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
  
    ViewData["Title"] = "Teacher panel";
    Layout = "~/Views/Shared/_TeacherLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<meta charset=\"utf-8\">\r\n<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n<meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 351, "\"", 361, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n<meta name=\"author\"");
            BeginWriteAttribute("content", " content=\"", 384, "\"", 394, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fc5011ad5b9bed0791abd5ab5daaf49041250af18801", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<link href=\"https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i\"\r\n      rel=\"stylesheet\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fc5011ad5b9bed0791abd5ab5daaf49041250af110160", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fc5011ad5b9bed0791abd5ab5daaf49041250af111276", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fc5011ad5b9bed0791abd5ab5daaf49041250af112392", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
<style>
    .sizeText {
        font-family: Verdana, Arial, Helvetica, sans-serif;
        font-size: 11pt;
    }

    .sizeTextSmall {
        font-family: Verdana, Arial, Helvetica, sans-serif;
        font-size: 10pt;
    }

    .colorBtn {
        background: #4e73df;
    }

    .btn-primary {
        width: 100%;
        color: var(--button-color);
        background-color: var(--button-background-color);
        border-radius: var(--border-radius);
        color: #ffffff;
    }

        .btn-primary:hover {
            width: 100%;
            box-shadow: inset 0 0 0 20rem var(--darken-1);
        }

    .tableSize {
        table-layout: fixed; /* Фиксированная ширина ячеек */
        width: 100%; /* Ширина таблицы */
    }

    .verticalTex");
            WriteLiteral(@"t {
        margin-left: -8px;
        display: inline-block;
        font-size: 15px;
        writing-mode: vertical-lr;
        -ms-writing-mode: bt-lr;
        transform-origin: center;
        transform: rotate(180deg);
        padding-top: 2mm;
        padding-bottom: 3mm;
    }

    p {
        margin-bottom: 0px;
    }
</style>

<div class=""card shadow mb-4"">
    <div class=""card-body"">
        <div class=""row"">
            <div class=""col-sm-12"">
                <table class=""tableSize table table-bordered dataTable"" id=""dataTable"" width=""100%"" cellspacing=""0"" role=""grid""
                       aria-describedby=""dataTable_info"" style=""width: 100%;"">

                    <tr>
                        <th colspan=""1"" rowspan=""6"">№</th>
                        <th colspan=""3"" rowspan=""6"">Назва навчальних дисциплін, їх загальний обсяг у годинах</th>
                        <th colspan=""16"" rowspan=""1"">Аудиторні заняття - I семестр</th>
                    </tr>
                ");
            WriteLiteral(@"    <tr>
                        <th colspan=""4"">Лекції</th>
                        <th colspan=""4"">Практичні заняття (семінари, практ.)</th>
                        <th colspan=""4"">Лаборатор. заняття</th>
                        <th colspan=""4"">Індивід. заняття</th>
                    </tr>

                    <tr>
                        <th colspan=""2"">За   бюджет.</th>
                        <th colspan=""2"">За контр.</th>
                        <th colspan=""2"">За бюджет.</th>
                        <th colspan=""2"">За контр.</th>
                        <th colspan=""2"">За бюджет.</th>
                        <th colspan=""2"">За контр.</th>
                        <th colspan=""2"">За бюджет.</th>
                        <th colspan=""2"">За контр.</th>
                    </tr>
                    <tr>
                        <th class=""sizeTextSmall"" colspan=""1"">пл</th>
                        <th class=""sizeTextSmall"" colspan=""1"">вик</th>
                        <th class=""sizeTextSm");
            WriteLiteral(@"all"" colspan=""1"">пл </th>
                        <th class=""sizeTextSmall"" colspan=""1"">вик </th>
                        <th class=""sizeTextSmall"" colspan=""1"">пл</th>
                        <th class=""sizeTextSmall"" colspan=""1"">вик</th>
                        <th class=""sizeTextSmall"" colspan=""1"">пл</th>
                        <th class=""sizeTextSmall"" colspan=""1"">вик</th>
                        <th class=""sizeTextSmall"" colspan=""1"">пл</th>
                        <th class=""sizeTextSmall"" colspan=""1"">вик</th>
                        <th class=""sizeTextSmall"" colspan=""1"">пл</th>
                        <th class=""sizeTextSmall"" colspan=""1"">вик</th>
                        <th class=""sizeTextSmall"" colspan=""1"">пл</th>
                        <th class=""sizeTextSmall"" colspan=""1"">вик</th>
                        <th class=""sizeTextSmall"" colspan=""1"">пл</th>
                        <th class=""sizeTextSmall"" colspan=""1"">вик</th>
                    </tr>
                    <tbody>
");
#nullable restore
#line 121 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                         foreach (var item in Model.listLectureClasses)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr role=\"row\" class=\"odd\">\r\n                                <td colspan=\"1\">");
#nullable restore
#line 124 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                                            Write(Model.listLectureClasses.IndexOf(item) + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td colspan=\"3\">");
#nullable restore
#line 125 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                                           Write(item.NameAcademiDisciplines);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td colspan=\"1\">");
#nullable restore
#line 126 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                                           Write(item.LectureBudPl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td colspan=\"1\">");
#nullable restore
#line 127 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                                           Write(item.LectureBudVuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td colspan=\"1\">");
#nullable restore
#line 128 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                                           Write(item.LectureConPl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td colspan=\"1\">");
#nullable restore
#line 129 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                                           Write(item.LectureConVuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td colspan=\"1\">");
#nullable restore
#line 130 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                                           Write(item.PractBudPl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td colspan=\"1\">");
#nullable restore
#line 131 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                                           Write(item.PractBudVuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td colspan=\"1\">");
#nullable restore
#line 132 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                                           Write(item.PractConPl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td colspan=\"1\">");
#nullable restore
#line 133 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                                           Write(item.PractConVuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td colspan=\"1\">");
#nullable restore
#line 134 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                                           Write(item.LabBudPl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td colspan=\"1\">");
#nullable restore
#line 135 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                                           Write(item.LabBudVuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td colspan=\"1\">");
#nullable restore
#line 136 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                                           Write(item.LabConPl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td colspan=\"1\">");
#nullable restore
#line 137 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                                           Write(item.LabConVuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td colspan=\"1\">");
#nullable restore
#line 138 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                                           Write(item.IndBudPl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td colspan=\"1\">");
#nullable restore
#line 139 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                                           Write(item.IndBudVuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td colspan=\"1\">");
#nullable restore
#line 140 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                                           Write(item.IndConPl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td colspan=\"1\">");
#nullable restore
#line 141 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                                           Write(item.IndConVuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 143 "D:\Мої роботи\Редагований план\Plan\Plan\Views\Teacher\LectureClassesTable1.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc5011ad5b9bed0791abd5ab5daaf49041250af124420", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc5011ad5b9bed0791abd5ab5daaf49041250af125460", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc5011ad5b9bed0791abd5ab5daaf49041250af126500", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc5011ad5b9bed0791abd5ab5daaf49041250af127540", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc5011ad5b9bed0791abd5ab5daaf49041250af128580", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc5011ad5b9bed0791abd5ab5daaf49041250af129621", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc5011ad5b9bed0791abd5ab5daaf49041250af130662", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script src=\"//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js\"></script>\r\n<script src=\"//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js\"></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Plan.ViewModels.ListLectureClasses1ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591