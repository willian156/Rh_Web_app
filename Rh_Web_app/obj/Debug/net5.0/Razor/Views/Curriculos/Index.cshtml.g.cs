#pragma checksum "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Curriculos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d00def881fd381054771f27bcbe753fc5a825e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curriculos_Index), @"mvc.1.0.view", @"/Views/Curriculos/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d00def881fd381054771f27bcbe753fc5a825e1", @"/Views/Curriculos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d21cbd35ee2ccb2f7a3100cdc90302f887d4727", @"/Views/_ViewImports.cshtml")]
    public class Views_Curriculos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Rh_Web_app.Models.Curriculos>>
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
#line 3 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Curriculos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Curriculos</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d00def881fd381054771f27bcbe753fc5a825e13980", async() => {
                WriteLiteral("<i class=\"fas fa-folder-plus\"></i> Novo Curriculo");
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
                Id do curriculo
            </th>
            <th>
                Nome da pessoa
            </th>
            <th>
                Descrição
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 28 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Curriculos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Curriculos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.id_curriculo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Curriculos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.nmPessoa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Curriculos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PessDescricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>           \r\n                    <i class=\"fas fa-edit\"></i> ");
#nullable restore
#line 41 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Curriculos\Index.cshtml"
                                           Write(Html.ActionLink("Edit", "Edit", new { id = item.id_curriculo }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <i class=\"fas fa-eye\"></i> ");
#nullable restore
#line 42 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Curriculos\Index.cshtml"
                                          Write(Html.ActionLink("Details", "Details", new { id = item.id_curriculo }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <i class=\"fas fa-trash\"></i> ");
#nullable restore
#line 43 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Curriculos\Index.cshtml"
                                            Write(Html.ActionLink("Delete", "Delete", new { id = item.id_curriculo }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 46 "D:\C# testes\Rh_Web_app\Rh_Web_app\Views\Curriculos\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Rh_Web_app.Models.Curriculos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
