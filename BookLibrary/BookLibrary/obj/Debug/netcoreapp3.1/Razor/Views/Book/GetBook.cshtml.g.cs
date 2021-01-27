#pragma checksum "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3871373df7cf3b227bd3494eb6fff1e4b34f507"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_GetBook), @"mvc.1.0.view", @"/Views/Book/GetBook.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3871373df7cf3b227bd3494eb6fff1e4b34f507", @"/Views/Book/GetBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2caff39b736c72f885f5621f7eb6d04efe6f3072", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_GetBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
  
    ViewData["Title"] = Model.Title + " Book Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

<div class=""container"">
    <h4 class=""display-4"">Book Details</h4>
    <div class=""row"">
        <div class=""col-md-6"">
            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">
");
#nullable restore
#line 14 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
                     for (int i = 0; i < Model.Gallery.Count(); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 16 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 536, "\"", 564, 1);
#nullable restore
#line 16 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 544, i==0?"active": "", 544, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></li>\r\n");
#nullable restore
#line 17 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ol>\r\n                <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 20 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
                     for (int i = 0; i < Model.Gallery.Count(); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 786, "\"", 841, 1);
#nullable restore
#line 22 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 794, i==0?"carousel-item active": "carousel-item", 794, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d3871373df7cf3b227bd3494eb6fff1e4b34f5076155", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
                          WriteLiteral(Model.Gallery[i].URL);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
AddHtmlAttributeValue("", 959, Model.Gallery[i].Name, 959, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 25 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <h1>");
#nullable restore
#line 40 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12 text-primary\">\r\n                    <span");
            BeginWriteAttribute("class", " class=\"", 1973, "\"", 1981, 0);
            EndWriteAttribute();
            WriteLiteral(">By :</span>\r\n                    <span class=\"text-monospace\">");
#nullable restore
#line 47 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
                                            Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <p");
            BeginWriteAttribute("class", " class=\"", 2207, "\"", 2215, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 53 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
                           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-md-4"">
                    <a class=""btn btn-outline-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
                        Read Now
                    </a>
                </div>
            </div>


            <hr />

            <ul class=""list-group"">
                <li class=""list-group-item""><span class=""font-weight-bold"">Category -</span>");
#nullable restore
#line 69 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
                                                                                       Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Total Pages -</span>");
#nullable restore
#line 70 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
                                                                                          Write(Model.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Language -</span>");
#nullable restore
#line 71 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
                                                                                       Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ul>
        </div>
    </div>

    <!-- Modal for show Book Pdf-->
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""btn-close"" data-dismiss=""modal"" aria-label=""Close"">X</button>
                </div>
                <div class=""modal-body"">
");
            WriteLiteral("                    <iframe");
            BeginWriteAttribute("src", " src=\"", 3588, "\"", 3611, 1);
#nullable restore
#line 85 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 3594, Model.BookPdfUrl, 3594, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""w-100"" style=""height:400px""></iframe>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>
    <hr />
    <div class=""py-5 bg-light"">
        <h3 class=""h3"">Similar Books</h3>
        <div class=""row"">
");
#nullable restore
#line 97 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
             for (int i = 0; i < 5; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-4"">
                    <div class=""card mb-4 shadow-sm"">
                        <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"" role=""img"" aria-label=""Placeholder: Thumbnail""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c""></rect><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>
                        <div class=""card-body"">
                            <h5 class=""card-title"">Book title</h5>
                            <p class=""card-text"">This section will be use to display the discription of book.</p>
                            <div class=""d-flex justify-content-between align-items-center"">
                                <div class=""btn-group"">
                                    <a href=""#"" class=""btn btn-primary"">View Details</a>
                                </div>
                                <");
            WriteLiteral("small class=\"text-muted\">Author</small>\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 115 "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Book\GetBook.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
