#pragma checksum "C:\Users\Aurel\source\repos\Vrai_crud\Vrai_crud\Views\Acceuil\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f2eb2141afae022d25794d7b57f1bfc43ace740"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Acceuil_Index), @"mvc.1.0.view", @"/Views/Acceuil/Index.cshtml")]
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
#line 1 "C:\Users\Aurel\source\repos\Vrai_crud\Vrai_crud\Views\_ViewImports.cshtml"
using Vrai_crud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aurel\source\repos\Vrai_crud\Vrai_crud\Views\_ViewImports.cshtml"
using Vrai_crud.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f2eb2141afae022d25794d7b57f1bfc43ace740", @"/Views/Acceuil/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60b5f5b8d2045e4861e71cb65d3409d4178cff08", @"/Views/_ViewImports.cshtml")]
    public class Views_Acceuil_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Aurel\source\repos\Vrai_crud\Vrai_crud\Views\Acceuil\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""content-wrapper"" class=""d-flex flex-column"">

    <!-- Main Content -->
    <div id=""content"">

        <!-- Topbar -->
        <!-- End of Topbar -->
        <!-- Begin Page Content -->
        <div class=""container-fluid"">

            <!-- Page Heading -->
            <!-- Content Row -->
            <div class=""row"">

                <div class=""col-lg-4"">

                    <div class=""card shadow mb-4"">

                        <div class=""card-header""><b>Etudiants</b> </div>

                        <div class=""card-body"">
                            <div class=""row"">

                                <div class=""col-md-5 text-center"">
                                    <a");
            BeginWriteAttribute("href", " href=\'", 815, "\'", 854, 1);
#nullable restore
#line 31 "C:\Users\Aurel\source\repos\Vrai_crud\Vrai_crud\Views\Acceuil\Index.cshtml"
WriteAttributeValue("", 822, Url.Action("Create","etudiant"), 822, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""fas fa-user-graduate fa-2x""></i>
                                        <p>Ajouter Etudiant</p>
                                    </a>
                                </div>

                                <div class=""col-md-5 text-center"">
                                    <a");
            BeginWriteAttribute("href", " href=\'", 1197, "\'", 1235, 1);
#nullable restore
#line 38 "C:\Users\Aurel\source\repos\Vrai_crud\Vrai_crud\Views\Acceuil\Index.cshtml"
WriteAttributeValue("", 1204, Url.Action("Index","etudiant"), 1204, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""fas fa-user-friends fa-2x""></i>
                                        <p>Listes des Etudiants</p>
                                    </a>
                                </div>

                            </div>

                        </div>
                    </div>

                </div>

                <div class=""col-lg-4"">

                    <!-- Background Gradient Utilities -->
                    <div class=""card shadow mb-4"">

                        <div class=""card-header""><b>Utilisateurs</b> </div>

                        <div class=""card-body"">
                            <div class=""row"">

                                <div class=""col-md-5 text-center"">
                                    <a");
            BeginWriteAttribute("href", " href=\'", 2040, "\'", 2082, 1);
#nullable restore
#line 62 "C:\Users\Aurel\source\repos\Vrai_crud\Vrai_crud\Views\Acceuil\Index.cshtml"
WriteAttributeValue("", 2047, Url.Action("Create","Utilisateur"), 2047, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""fas fa-user-plus fa-2x""></i>
                                        <p>Ajouter Utilisateur</p>
                                    </a>
                                </div>

                                <div class=""col-md-5 text-center"">
                                    <a");
            BeginWriteAttribute("href", " href=\'", 2424, "\'", 2465, 1);
#nullable restore
#line 69 "C:\Users\Aurel\source\repos\Vrai_crud\Vrai_crud\Views\Acceuil\Index.cshtml"
WriteAttributeValue("", 2431, Url.Action("Index","Utilisateur"), 2431, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""fas fa-users fa-2x""></i>
                                        <p>Listes des utilisateurs</p>
                                    </a>
                                </div>

                                <div class=""col-md-5 text-center"">
                                    <a");
            BeginWriteAttribute("href", " href=\'", 2807, "\'", 2844, 1);
#nullable restore
#line 76 "C:\Users\Aurel\source\repos\Vrai_crud\Vrai_crud\Views\Acceuil\Index.cshtml"
WriteAttributeValue("", 2814, Url.Action("Index","Student"), 2814, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""fas fa-user-tie fa-2x""></i>
                                        <p>Type des utilisateurs</p>
                                    </a>
                                </div>
                            </div>

                        </div>
                    </div>

                </div>

                <div class=""col-lg-4"">

                    <!-- Background Gradient Utilities -->
                    <div class=""card shadow mb-4"">

                        <div class=""card-header""><b>Payement</b> </div>

                        <div class=""card-body"">
                            <div class=""row"">

                                <div class=""col-md-5 text-center"">
                                    <a");
            BeginWriteAttribute("href", " href=\'", 3640, "\'", 3678, 1);
#nullable restore
#line 99 "C:\Users\Aurel\source\repos\Vrai_crud\Vrai_crud\Views\Acceuil\Index.cshtml"
WriteAttributeValue("", 3647, Url.Action("Index","Payement"), 3647, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""fas fa-funnel-dollar fa-2x""></i>
                                        <p>Payement des etudiants</p>
                                    </a>
                                </div>

                                <div class=""col-md-5 text-center"">
                                    <a");
            BeginWriteAttribute("href", " href=\'", 4027, "\'", 4062, 1);
#nullable restore
#line 106 "C:\Users\Aurel\source\repos\Vrai_crud\Vrai_crud\Views\Acceuil\Index.cshtml"
WriteAttributeValue("", 4034, Url.Action("Index","Frais"), 4034, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""fas fa-user-friends fa-2x""></i>
                                        <p>Frais  par facultés</p>
                                    </a>
                                </div>

                            </div>

                        </div>
                    </div>

                </div>

            </div>

            <!-- Content Row -->

            <div class=""row"">

                <!-- Area Chart -->
                

                <!-- Pie Chart -->
                
            </div>

        </div>
   
    </div>

</div>

");
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
