#pragma checksum "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\Entradas\Entradas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56abe9cd9f62ae9eed505f6c7510f4dcfb85ce27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Entradas_Entradas), @"mvc.1.0.view", @"/Views/Entradas/Entradas.cshtml")]
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
#line 1 "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\_ViewImports.cshtml"
using ComputerSena.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\_ViewImports.cshtml"
using ComputerSena.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56abe9cd9f62ae9eed505f6c7510f4dcfb85ce27", @"/Views/Entradas/Entradas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"728158e18054a55866d6e4630d6ea3727bb66a70", @"/Views/_ViewImports.cshtml")]
    public class Views_Entradas_Entradas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ComputerSena.Models.Entidades.EntradaSalida>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/DataTable/tabla.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col mt-3\">\r\n        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 124, "\"", 234, 4);
            WriteAttributeValue("", 134, "mostrarModal(\'", 134, 14, true);
#nullable restore
#line 5 "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\Entradas\Entradas.cshtml"
WriteAttributeValue("", 148, Url.Action("CrearEntrada","Entradas",null,Context.Request.Scheme), 148, 66, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 214, "\',\'Agregar", 214, 10, true);
            WriteAttributeValue(" ", 224, "entrada\')", 225, 10, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-dark mb-3"" style=""color:white""><i class=""fas fa-user-plus mr-2""></i>registrar Entrada.</a>
            <div class=""table-responsive"">
                <table class=""table table-bordered table-striped table-hover"" cellpadding=""0"" id=""tabla"">
                    <thead>
                        <tr>
                            <th>Nombre</th>
                            <th>Documento</th>
                            <th>Elemento</th>
                            <th>Color</th>
                            <th>Serial</th>
                            <th>Fecha De entrada</th>
                            <th>Estado</th>
                            <th>Acciones</th>
                        </tr>
                    </thead>
                    <tbody>

");
#nullable restore
#line 22 "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\Entradas\Entradas.cshtml"
                         foreach (var entrada in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 25 "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\Entradas\Entradas.cshtml"
                               Write(entrada.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 26 "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\Entradas\Entradas.cshtml"
                               Write(entrada.Documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 27 "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\Entradas\Entradas.cshtml"
                               Write(entrada.Elemento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 28 "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\Entradas\Entradas.cshtml"
                               Write(entrada.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 29 "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\Entradas\Entradas.cshtml"
                               Write(entrada.Serial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 30 "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\Entradas\Entradas.cshtml"
                               Write(entrada.FechaEntrada);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 32 "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\Entradas\Entradas.cshtml"
                                     if (entrada.Estado)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"badge badge-warning\">Ingresado.</span> ");
#nullable restore
#line 34 "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\Entradas\Entradas.cshtml"
                                                                                            }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"badge badge-danger\">Salido.</span>");
#nullable restore
#line 37 "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\Entradas\Entradas.cshtml"
                                                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>\r\n\r\n                                    <div class=\"d-flex justify-content-center flex-wrap\">\r\n");
#nullable restore
#line 42 "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\Entradas\Entradas.cshtml"
                                         if (entrada.Estado)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"text-danger\"");
            BeginWriteAttribute("href", " href=\"", 2239, "\"", 2377, 3);
            WriteAttributeValue("", 2246, "javascript:cambiarEstado(\'", 2246, 26, true);
#nullable restore
#line 44 "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\Entradas\Entradas.cshtml"
WriteAttributeValue("", 2272, Url.Action("CambiarEstado","EntradasSalidas",new {id=entrada.EntradaSalidaID },Context.Request.Scheme), 2272, 103, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2375, "\')", 2375, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i title=\"Deshabilitar cliente\" class=\"fas fa-user-slash\"></i></a> ");
#nullable restore
#line 44 "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\Entradas\Entradas.cshtml"
                                                                                                                                                                                                                                                                                 }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"text-warning\"");
            BeginWriteAttribute("href", " href=\"", 2605, "\"", 2741, 3);
            WriteAttributeValue("", 2612, "javascript:cambiarEstado(\'", 2612, 26, true);
#nullable restore
#line 47 "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\Entradas\Entradas.cshtml"
WriteAttributeValue("", 2638, Url.Action("CambiarEstado","EntradasSalidas",new{id=entrada.EntradaSalidaID},Context.Request.Scheme), 2638, 101, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2739, "\')", 2739, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i title=\"Habilitar cliente\" class=\"fas fa-user-check\"></i></a>");
#nullable restore
#line 47 "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\Entradas\Entradas.cshtml"
                                                                                                                                                                                                                                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\57311\OneDrive\Escritorio\Asp .net\ComputerSena\ComputerSena.WEB\Views\Entradas\Entradas.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56abe9cd9f62ae9eed505f6c7510f4dcfb85ce2712321", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ComputerSena.Models.Entidades.EntradaSalida>> Html { get; private set; }
    }
}
#pragma warning restore 1591
