#pragma checksum "F:\#Visual Studio 2019 Project\Asp.Net Core MVC 3.1\BookLibrary\BookLibrary\BookLibrary\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6642225c4609f06cf2523152bbc111a2d1f770be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6642225c4609f06cf2523152bbc111a2d1f770be", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""jumbotron"">
    <h1 class=""display-4"">Welcome to Book Library</h1>
    <p class=""lead"">This is a simple hero unit, a simple jumbotron-style component for calling extra attention to featured content or information.</p>
    <p>It uses utility classes for typography and spacing to space content out within the larger container.</p>
    <a class=""btn btn-primary btn-lg"" href=""#"" role=""button"">Search Book</a>
</div>

<div class=""container"">
    <h3>Top Books</h3>
    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""card mb-4 shadow-sm"">
                <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225px""");
            BeginWriteAttribute("xmlns", " xmlns=\"", 677, "\"", 685, 0);
            EndWriteAttribute();
            WriteLiteral(@"></svg>
                <div class=""card-body"">
                    <h5 class=""card-title"">Book title</h5>
                    <p class=""card-text"">This section will be use to display the discription of book.</p>
                    <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                            <a href=""#"" class=""btn btn-primary"">View Details</a>
                        </div>
                        <small class=""text-muted"">Author</small>
                    </div>

                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""card mb-4 shadow-sm"">
                <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225px""");
            BeginWriteAttribute("xmlns", " xmlns=\"", 1474, "\"", 1482, 0);
            EndWriteAttribute();
            WriteLiteral(@"></svg>
                <div class=""card-body"">
                    <h5 class=""card-title"">Book title</h5>
                    <p class=""card-text"">This section will be use to display the discription of book.</p>
                    <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                            <a href=""#"" class=""btn btn-primary"">View Details</a>
                        </div>
                        <small class=""text-muted"">Author</small>
                    </div>

                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""card mb-4 shadow-sm"">
                <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225px""");
            BeginWriteAttribute("xmlns", " xmlns=\"", 2271, "\"", 2279, 0);
            EndWriteAttribute();
            WriteLiteral(@"></svg>
                <div class=""card-body"">
                    <h5 class=""card-title"">Book title</h5>
                    <p class=""card-text"">This section will be use to display the discription of book.</p>
                    <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                            <a href=""#"" class=""btn btn-primary"">View Details</a>
                        </div>
                        <small class=""text-muted"">Author</small>
                    </div>

                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n           // alert(\"Hello...Index\");\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
