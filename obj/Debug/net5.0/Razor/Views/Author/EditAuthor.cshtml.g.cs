#pragma checksum "C:\Training\Bookish-Project\Bookish\Views\Author\EditAuthor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e7d0032e604bd7d5ded8a2a8126c258c42829bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_EditAuthor), @"mvc.1.0.view", @"/Views/Author/EditAuthor.cshtml")]
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
#line 1 "C:\Training\Bookish-Project\Bookish\Views\_ViewImports.cshtml"
using Bookish;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Training\Bookish-Project\Bookish\Views\_ViewImports.cshtml"
using Bookish.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e7d0032e604bd7d5ded8a2a8126c258c42829bd", @"/Views/Author/EditAuthor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e05004d587bb18274aac2c03503e22cb8bcb75b", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_EditAuthor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Author>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Training\Bookish-Project\Bookish\Views\Author\EditAuthor.cshtml"
  
    ViewData["Title"] = "Add Author Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 7 "C:\Training\Bookish-Project\Bookish\Views\Author\EditAuthor.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 8 "C:\Training\Bookish-Project\Bookish\Views\Author\EditAuthor.cshtml"
     using (Html.BeginForm("EditAuthor", "Author", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table>\r\n            <tr>\r\n                <td>Author First Name: </td>\r\n                <td>");
#nullable restore
#line 13 "C:\Training\Bookish-Project\Bookish\Views\Author\EditAuthor.cshtml"
               Write(Html.TextBoxFor(m => m.first_name, new {required="required"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Author Last Name: </td>\r\n                <td>");
#nullable restore
#line 17 "C:\Training\Bookish-Project\Bookish\Views\Author\EditAuthor.cshtml"
               Write(Html.TextBoxFor(m => m.last_name, new {required="required"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\"><input type=\"submit\" value=\"Save\"></td>\r\n            </tr>\r\n        </table>\r\n");
#nullable restore
#line 23 "C:\Training\Bookish-Project\Bookish\Views\Author\EditAuthor.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class = \"text-success font-weight-bold\">");
#nullable restore
#line 24 "C:\Training\Bookish-Project\Bookish\Views\Author\EditAuthor.cshtml"
                                          Write(ViewBag.SuccessMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <a class=\"page-scroll\" href=\"/Author\"> Back To List</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Author> Html { get; private set; }
    }
}
#pragma warning restore 1591