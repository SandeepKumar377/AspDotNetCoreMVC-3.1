#pragma checksum "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetAllBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45dad0a4ff0c4316fd239464690f8797f2e80e4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_GetAllBooks), @"mvc.1.0.view", @"/Views/Book/GetAllBooks.cshtml")]
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
#line 1 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\_ViewImports.cshtml"
using BookLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45dad0a4ff0c4316fd239464690f8797f2e80e4c", @"/Views/Book/GetAllBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65e698cb7659717f17d0df14b239646cb5804e7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_GetAllBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetAllBooks.cshtml"
  
    ViewData["Title"] = "All Books";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n    <h3>All Books</h3>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 12 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetAllBooks.cshtml"
         foreach (var book in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-4"">
                <div class=""card mb-4 shadow-sm"">
                    <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225px"" xmlns=""http://www.w3.org/2000/svg""></svg>
                    <div class=""card-body"">
                        <h5 class=""card-title"">");
#nullable restore
#line 18 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetAllBooks.cshtml"
                                          Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 19 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetAllBooks.cshtml"
                                        Write(book.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <div class=\"d-flex justify-content-between align-items-center\">\r\n                            <div class=\"btn-group\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 782, "\"", 811, 2);
            WriteAttributeValue("", 789, "/book/getBook/", 789, 14, true);
#nullable restore
#line 22 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetAllBooks.cshtml"
WriteAttributeValue("", 803, book.Id, 803, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">View Details</a>\r\n                            </div>\r\n                            <small class=\"text-muted\">");
#nullable restore
#line 24 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetAllBooks.cshtml"
                                                 Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 29 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetAllBooks.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
