#pragma checksum "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c99c172b12cf06659c30f740f240af1f7f48531a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emprestimo_Listagem), @"mvc.1.0.view", @"/Views/Emprestimo/Listagem.cshtml")]
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
#line 1 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c99c172b12cf06659c30f740f240af1f7f48531a", @"/Views/Emprestimo/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Emprestimo_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Emprestimo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "NomeUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Livro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Empréstimos";
    string Classe ="";

    int FiltroPorPag =  int.Parse(ViewData["emprestimosPorPagina"].ToString());
    int PaginaAtual =  int.Parse(ViewData["paginaAtual"].ToString());

    int NumEmprestimosPorPag = (Model.Count<FiltroPorPag ? Model.Count:FiltroPorPag); 
    
    int NumTotalDePag =0;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
     if(NumEmprestimosPorPag>0)
    {
      NumTotalDePag = Model.Count/NumEmprestimosPorPag + (Model.Count%NumEmprestimosPorPag==0 ? 0 : 1);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c99c172b12cf06659c30f740f240af1f7f48531a6215", async() => {
                WriteLiteral("\r\n            <div class=\"form-group mb-2\">\r\n                <select name=\"TipoFiltro\" class=\"form-control\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c99c172b12cf06659c30f740f240af1f7f48531a6611", async() => {
                    WriteLiteral("Usuário");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c99c172b12cf06659c30f740f240af1f7f48531a7855", async() => {
                    WriteLiteral("Livro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
            </div>
            <div class=""form-group mb-2 mx-sm-3"">
                <input type=""text"" placeholder=""Filtro"" name=""Filtro"" class=""form-control"" />
            </div>

            <div class=""form-group mb-2 mx-sm-3"">
                <select class=""form-control"" name=""itensPorPagina"" id=""itensPorPagina"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c99c172b12cf06659c30f740f240af1f7f48531a9469", async() => {
                    WriteLiteral("10");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n            </div>\r\n\r\n            <button type=\"submit\" class=\"btn btn-primary mb-2\">Pesquisar</button>\r\n\r\n               <div id=\"SeletorPags\">\r\n                <span>Página:</span>\r\n");
#nullable restore
#line 41 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                 for (int i= 1; i < NumTotalDePag; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <span><a");
                BeginWriteAttribute("href", " href=\"", 1591, "\"", 1633, 2);
                WriteAttributeValue("", 1598, "/Emprestimo/Listagem?PaginaAtual=", 1598, 33, true);
#nullable restore
#line 43 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 1631, i, 1631, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 43 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                                   Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral(",</a></span>\r\n");
#nullable restore
#line 44 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                   <span><a");
                BeginWriteAttribute("href", " href=\"", 1697, "\"", 1751, 2);
                WriteAttributeValue("", 1704, "/Emprestimo/Listagem?PaginaAtual=", 1704, 33, true);
#nullable restore
#line 45 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 1737, NumTotalDePag, 1737, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 45 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                                              Write(NumTotalDePag);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></span>\r\n            </div>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12"">
        <table class=""table table-striped"">
            <!-- adicionado bootstrap -->
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Usuario</th>
                    <th>Data Empréstimo</th>
                    <th>Data Devolução</th>
                    <th>Livro</th>
                    <th>Autor</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 68 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                 if (Model.Count > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                     for(int i = (PaginaAtual - 1)*NumEmprestimosPorPag; i<(NumEmprestimosPorPag*PaginaAtual<Model.Count? NumEmprestimosPorPag*PaginaAtual : Model.Count); i++)
                    {

                        if (System.DateTime.Compare(System.DateTime.Now,Model[i].DataDevolucao)>0)
                        {
                            Classe = "text-danger";
                        }
                        else
                        {
                            Classe = "";
                        }


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("class", " class=\"", 2973, "\"", 2988, 1);
#nullable restore
#line 82 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 2981, Classe, 2981, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>");
#nullable restore
#line 83 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 84 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 85 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].DataEmprestimo.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 86 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].DataDevolucao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 87 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].Livro.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 88 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].Livro.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 3429, "\"", 3467, 2);
            WriteAttributeValue("", 3436, "/Emprestimo/Edicao/", 3436, 19, true);
#nullable restore
#line 89 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 3455, Model[i].Id, 3455, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 91 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"danger\">Nenhum registro encontrado!</p>\r\n");
#nullable restore
#line 96 "C:\Users\Usuario\Desktop\Senac\UUC07 - Dcoumentar e Realizar Manutencao em aplicacoes\Provas\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Emprestimo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
