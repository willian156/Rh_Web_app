#pragma checksum "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Vagas\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01e6b3377216bec496d9bee665f8f9b570c87f4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vagas_index), @"mvc.1.0.view", @"/Views/Vagas/index.cshtml")]
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
#line 1 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\_ViewImports.cshtml"
using Rh_Web_app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\_ViewImports.cshtml"
using Rh_Web_app.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01e6b3377216bec496d9bee665f8f9b570c87f4c", @"/Views/Vagas/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d21cbd35ee2ccb2f7a3100cdc90302f887d4727", @"/Views/_ViewImports.cshtml")]
    public class Views_Vagas_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Rh_Web_app.Models.Vagas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Vagas\index.cshtml"
  
    ViewData["Title"] = "index";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Vagas</h1>\r\n\r\n<p id=\"btn btn-primary\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01e6b3377216bec496d9bee665f8f9b570c87f4c3965", async() => {
                WriteLiteral("<i class=\"fas fa-folder-plus\"></i> Nova vaga");
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
            WriteLiteral(@"
</p>
<table id=""myTable"" class=""table"">
    <thead>
        <tr>
            <th>
                Id da vaga
            </th>
            <th>
                Nome da Vaga
            </th>
            <th>
               Descri????o
            </th>
            <th>A????es</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 29 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Vagas\index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Vagas\index.cshtml"
               Write(Html.DisplayFor(modelItem => item.id_vaga));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Vagas\index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NmVaga));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Vagas\index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <i class=\"fas fa-edit\"></i> ");
#nullable restore
#line 42 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Vagas\index.cshtml"
                                           Write(Html.ActionLink("Editar", "Edit", new { id = item.id_vaga }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    <i class=\"fas fa-eye\"></i> ");
#nullable restore
#line 43 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Vagas\index.cshtml"
                                          Write(Html.ActionLink("Detalhes", "Details", new { id = item.id_vaga }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    <i class=\"fas fa-trash\"></i> ");
#nullable restore
#line 44 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Vagas\index.cshtml"
                                            Write(Html.ActionLink("Deletar", "Delete", new { id = item.id_vaga }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td >\r\n            </tr >\r\n");
#nullable restore
#line 47 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Vagas\index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            $('#myTable').DataTable({
                language: {
                    url: '//cdn.datatables.net/plug-ins/1.11.3/i18n/pt_br.json'
                }
            });
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Rh_Web_app.Models.Vagas>> Html { get; private set; }
    }
}
#pragma warning restore 1591
