#pragma checksum "C:\Users\USUARIO\Desktop\ProyectoTIC\Ciclo 3\Asignacion de oficinas\AsigOficinas.App\AsigOficinas.App.Frontend\Pages\WebGobernadorYAsesor\DetallesgobenadorAsesor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d4725411157c61633b52c79c28e1310c1d4072d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AsigOficinas.App.Frontend.Pages.WebGobernadorYAsesor.Pages_WebGobernadorYAsesor_DetallesgobenadorAsesor), @"mvc.1.0.razor-page", @"/Pages/WebGobernadorYAsesor/DetallesgobenadorAsesor.cshtml")]
namespace AsigOficinas.App.Frontend.Pages.WebGobernadorYAsesor
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
#line 1 "C:\Users\USUARIO\Desktop\ProyectoTIC\Ciclo 3\Asignacion de oficinas\AsigOficinas.App\AsigOficinas.App.Frontend\Pages\_ViewImports.cshtml"
using AsigOficinas.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d4725411157c61633b52c79c28e1310c1d4072d", @"/Pages/WebGobernadorYAsesor/DetallesgobenadorAsesor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"728c699ca76b918e1dd34a3ab32b03f4cdc05669", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WebGobernadorYAsesor_DetallesgobenadorAsesor : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/WebGobernadorYAsesor/gobenadorAsesor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<h2>Detalles del gobenador o asesor</h2>
<table class=""table"">
    <thead>
        <tr>
            <th>Nombre</th>
            <th>Apellido</th>
            <th>Identificacion</th>
            <th>Edad</th>
            <th>Estado COVID</th>
            <th>Diagnostico</th>
            <th>Oficina visitada</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>");
#nullable restore
#line 20 "C:\Users\USUARIO\Desktop\ProyectoTIC\Ciclo 3\Asignacion de oficinas\AsigOficinas.App\AsigOficinas.App.Frontend\Pages\WebGobernadorYAsesor\DetallesgobenadorAsesor.cshtml"
           Write(Model.gobernadorYAsesor.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\USUARIO\Desktop\ProyectoTIC\Ciclo 3\Asignacion de oficinas\AsigOficinas.App\AsigOficinas.App.Frontend\Pages\WebGobernadorYAsesor\DetallesgobenadorAsesor.cshtml"
           Write(Model.gobernadorYAsesor.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\USUARIO\Desktop\ProyectoTIC\Ciclo 3\Asignacion de oficinas\AsigOficinas.App\AsigOficinas.App.Frontend\Pages\WebGobernadorYAsesor\DetallesgobenadorAsesor.cshtml"
           Write(Model.gobernadorYAsesor.identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\USUARIO\Desktop\ProyectoTIC\Ciclo 3\Asignacion de oficinas\AsigOficinas.App\AsigOficinas.App.Frontend\Pages\WebGobernadorYAsesor\DetallesgobenadorAsesor.cshtml"
           Write(Model.gobernadorYAsesor.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\USUARIO\Desktop\ProyectoTIC\Ciclo 3\Asignacion de oficinas\AsigOficinas.App\AsigOficinas.App.Frontend\Pages\WebGobernadorYAsesor\DetallesgobenadorAsesor.cshtml"
           Write(Model.gobernadorYAsesor.estadoCovid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\USUARIO\Desktop\ProyectoTIC\Ciclo 3\Asignacion de oficinas\AsigOficinas.App\AsigOficinas.App.Frontend\Pages\WebGobernadorYAsesor\DetallesgobenadorAsesor.cshtml"
           Write(Model.gobernadorYAsesor.diagnostico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\USUARIO\Desktop\ProyectoTIC\Ciclo 3\Asignacion de oficinas\AsigOficinas.App\AsigOficinas.App.Frontend\Pages\WebGobernadorYAsesor\DetallesgobenadorAsesor.cshtml"
           Write(Model.gobernadorYAsesor.oficinasVisitadas);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d4725411157c61633b52c79c28e1310c1d4072d7201", async() => {
                WriteLiteral("<i class=\"bi bi-arrow-left\"></i></i>\r\n    gobenador y asesores");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AsigOficinas.App.Frontend.Pages.DetallesgobenadorAsesorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AsigOficinas.App.Frontend.Pages.DetallesgobenadorAsesorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AsigOficinas.App.Frontend.Pages.DetallesgobenadorAsesorModel>)PageContext?.ViewData;
        public AsigOficinas.App.Frontend.Pages.DetallesgobenadorAsesorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
