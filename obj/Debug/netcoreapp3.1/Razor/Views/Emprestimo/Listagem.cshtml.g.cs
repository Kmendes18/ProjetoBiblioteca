#pragma checksum "C:\Users\Kleber\Desktop\Curso Web\MODULO 2\UC 7\Atividade 2\Biblioteca\Views\Emprestimo\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a90556a3e92afbfe619a7f0957a257615a8d2cf"
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
#line 1 "C:\Users\Kleber\Desktop\Curso Web\MODULO 2\UC 7\Atividade 2\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kleber\Desktop\Curso Web\MODULO 2\UC 7\Atividade 2\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a90556a3e92afbfe619a7f0957a257615a8d2cf", @"/Views/Emprestimo/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Emprestimo_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Emprestimo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Kleber\Desktop\Curso Web\MODULO 2\UC 7\Atividade 2\Biblioteca\Views\Emprestimo\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Empréstimos";
    string Classe = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 11 "C:\Users\Kleber\Desktop\Curso Web\MODULO 2\UC 7\Atividade 2\Biblioteca\Views\Emprestimo\Listagem.cshtml"
         if (Model.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table id=""myTable"" class=""table table-striped"">
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
#line 26 "C:\Users\Kleber\Desktop\Curso Web\MODULO 2\UC 7\Atividade 2\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                     foreach (Emprestimo e in Model)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Kleber\Desktop\Curso Web\MODULO 2\UC 7\Atividade 2\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                         if((System.DateTime.Compare(System.DateTime.Now, e.DataDevolucao)>0))
                        {
                            Classe="text-danger";
                        }
                        else
                        {
                            Classe="";
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("class", " class=\"", 1125, "\"", 1140, 1);
#nullable restore
#line 36 "C:\Users\Kleber\Desktop\Curso Web\MODULO 2\UC 7\Atividade 2\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 1133, Classe, 1133, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>");
#nullable restore
#line 37 "C:\Users\Kleber\Desktop\Curso Web\MODULO 2\UC 7\Atividade 2\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(e.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\Kleber\Desktop\Curso Web\MODULO 2\UC 7\Atividade 2\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(e.NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "C:\Users\Kleber\Desktop\Curso Web\MODULO 2\UC 7\Atividade 2\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(e.DataEmprestimo.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "C:\Users\Kleber\Desktop\Curso Web\MODULO 2\UC 7\Atividade 2\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(e.DataDevolucao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "C:\Users\Kleber\Desktop\Curso Web\MODULO 2\UC 7\Atividade 2\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(e.Livro.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "C:\Users\Kleber\Desktop\Curso Web\MODULO 2\UC 7\Atividade 2\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(e.Livro.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1539, "\"", 1570, 2);
            WriteAttributeValue("", 1546, "/Emprestimo/Edicao/", 1546, 19, true);
#nullable restore
#line 43 "C:\Users\Kleber\Desktop\Curso Web\MODULO 2\UC 7\Atividade 2\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 1565, e.Id, 1565, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Editar</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\Kleber\Desktop\Curso Web\MODULO 2\UC 7\Atividade 2\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 48 "C:\Users\Kleber\Desktop\Curso Web\MODULO 2\UC 7\Atividade 2\Biblioteca\Views\Emprestimo\Listagem.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>\"Nenhum registro encontrado\"</h3>\r\n");
#nullable restore
#line 52 "C:\Users\Kleber\Desktop\Curso Web\MODULO 2\UC 7\Atividade 2\Biblioteca\Views\Emprestimo\Listagem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'#myTable\').DataTable({\r\n            \"language\": {\r\n                \"url\": \"//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Portuguese-Brasil.json\"\r\n            }\r\n        });\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Emprestimo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
