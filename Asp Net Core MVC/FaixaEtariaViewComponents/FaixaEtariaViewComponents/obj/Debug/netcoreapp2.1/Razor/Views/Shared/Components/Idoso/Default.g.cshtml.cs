#pragma checksum "C:\Users\dnascimento\estudoC#\Asp Net Core MVC\FaixaEtariaViewComponents\FaixaEtariaViewComponents\Views\Shared\Components\Idoso\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1f0d7147c157b83c3ec809788a13343221d8f59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Idoso_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Idoso/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Idoso/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Idoso_Default))]
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
#line 1 "C:\Users\dnascimento\estudoC#\Asp Net Core MVC\FaixaEtariaViewComponents\FaixaEtariaViewComponents\Views\_ViewImports.cshtml"
using FaixaEtariaViewComponents;

#line default
#line hidden
#line 2 "C:\Users\dnascimento\estudoC#\Asp Net Core MVC\FaixaEtariaViewComponents\FaixaEtariaViewComponents\Views\_ViewImports.cshtml"
using FaixaEtariaViewComponents.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1f0d7147c157b83c3ec809788a13343221d8f59", @"/Views/Shared/Components/Idoso/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dcec137ab22cee9e9e3bbf05689dd0808cb7714", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Idoso_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FaixaEtariaViewComponents.Models.Pessoa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 110, true);
            WriteLiteral("\r\n\r\n<div class=\"panel panel-primary\">\r\n     <div class=\"panel-heading\">Idosos Cadastrados <span class=\"badge\">");
            EndContext();
            BeginContext(172, 13, false);
#line 5 "C:\Users\dnascimento\estudoC#\Asp Net Core MVC\FaixaEtariaViewComponents\FaixaEtariaViewComponents\Views\Shared\Components\Idoso\Default.cshtml"
                                                                  Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(185, 175, true);
            WriteLiteral("</span></div>\r\n     <div class=\"panel-body\">\r\n         <table class=\"table\">\r\n             <thead>\r\n                 <tr>\r\n                     <th>\r\n                         ");
            EndContext();
            BeginContext(361, 40, false);
#line 11 "C:\Users\dnascimento\estudoC#\Asp Net Core MVC\FaixaEtariaViewComponents\FaixaEtariaViewComponents\Views\Shared\Components\Idoso\Default.cshtml"
                    Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(401, 82, true);
            WriteLiteral("\r\n                     </th>\r\n                     <th>\r\n                         ");
            EndContext();
            BeginContext(484, 41, false);
#line 14 "C:\Users\dnascimento\estudoC#\Asp Net Core MVC\FaixaEtariaViewComponents\FaixaEtariaViewComponents\Views\Shared\Components\Idoso\Default.cshtml"
                    Write(Html.DisplayNameFor(model => model.Idade));

#line default
#line hidden
            EndContext();
            BeginContext(525, 131, true);
            WriteLiteral("\r\n                     </th>\r\n                     <th></th>\r\n                 </tr>\r\n             </thead>\r\n             <tbody>\r\n");
            EndContext();
#line 20 "C:\Users\dnascimento\estudoC#\Asp Net Core MVC\FaixaEtariaViewComponents\FaixaEtariaViewComponents\Views\Shared\Components\Idoso\Default.cshtml"
                  foreach (var item in Model)
                 {

#line default
#line hidden
            BeginContext(723, 87, true);
            WriteLiteral("                     <tr>\r\n                         <td>\r\n                             ");
            EndContext();
            BeginContext(811, 39, false);
#line 24 "C:\Users\dnascimento\estudoC#\Asp Net Core MVC\FaixaEtariaViewComponents\FaixaEtariaViewComponents\Views\Shared\Components\Idoso\Default.cshtml"
                        Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(850, 94, true);
            WriteLiteral("\r\n                         </td>\r\n                         <td>\r\n                             ");
            EndContext();
            BeginContext(945, 40, false);
#line 27 "C:\Users\dnascimento\estudoC#\Asp Net Core MVC\FaixaEtariaViewComponents\FaixaEtariaViewComponents\Views\Shared\Components\Idoso\Default.cshtml"
                        Write(Html.DisplayFor(modelItem => item.Idade));

#line default
#line hidden
            EndContext();
            BeginContext(985, 94, true);
            WriteLiteral("\r\n                         </td>\r\n                         <td>\r\n                             ");
            EndContext();
            BeginContext(1079, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9454a00c1aad4baa9f18cc654367135f", async() => {
                BeginContext(1130, 4, true);
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
#line 30 "C:\Users\dnascimento\estudoC#\Asp Net Core MVC\FaixaEtariaViewComponents\FaixaEtariaViewComponents\Views\Shared\Components\Idoso\Default.cshtml"
                                                    WriteLiteral(item.PessoaId);

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
            BeginContext(1138, 33, true);
            WriteLiteral(" |\r\n                             ");
            EndContext();
            BeginContext(1171, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "360c819f7b7a485dbb97cd3d22a8083b", async() => {
                BeginContext(1225, 7, true);
                WriteLiteral("Details");
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
#line 31 "C:\Users\dnascimento\estudoC#\Asp Net Core MVC\FaixaEtariaViewComponents\FaixaEtariaViewComponents\Views\Shared\Components\Idoso\Default.cshtml"
                                                       WriteLiteral(item.PessoaId);

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
            BeginContext(1236, 33, true);
            WriteLiteral(" |\r\n                             ");
            EndContext();
            BeginContext(1269, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1db820bcc7a4ee4bbb4e4527f3a056b", async() => {
                BeginContext(1322, 6, true);
                WriteLiteral("Delete");
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
#line 32 "C:\Users\dnascimento\estudoC#\Asp Net Core MVC\FaixaEtariaViewComponents\FaixaEtariaViewComponents\Views\Shared\Components\Idoso\Default.cshtml"
                                                      WriteLiteral(item.PessoaId);

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
            BeginContext(1332, 62, true);
            WriteLiteral("\r\n                         </td>\r\n                     </tr>\r\n");
            EndContext();
#line 35 "C:\Users\dnascimento\estudoC#\Asp Net Core MVC\FaixaEtariaViewComponents\FaixaEtariaViewComponents\Views\Shared\Components\Idoso\Default.cshtml"
                 }

#line default
#line hidden
            BeginContext(1414, 61, true);
            WriteLiteral("             </tbody>\r\n         </table>\r\n     </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FaixaEtariaViewComponents.Models.Pessoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
