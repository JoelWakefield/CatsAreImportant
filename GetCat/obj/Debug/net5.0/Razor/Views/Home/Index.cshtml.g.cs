#pragma checksum "C:\dev\Improving\Practice\GetCat\GetCat\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dcdac90d0d06e8ac3ab764db35ca59e23084f1b"
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
#nullable restore
#line 1 "C:\dev\Improving\Practice\GetCat\GetCat\Views\_ViewImports.cshtml"
using GetCat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\Improving\Practice\GetCat\GetCat\Views\_ViewImports.cshtml"
using GetCat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dcdac90d0d06e8ac3ab764db35ca59e23084f1b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26fde0adb9cdf59eb02006f6813ab18dc18f1e4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\dev\Improving\Practice\GetCat\GetCat\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Cats!</h1>

    <img id=""cat-image"" />
    <video id=""cat-video"" controls />

    <style>
        img {
            max-width: 400px;
            display: none;
        }

        video {
            display: none;
        }
    </style>

    <script>
        const imgCat = document.querySelector('#cat-image');
        const vidCat = document.querySelector('#cat-video');

        function getCat() {
            fetch('https://aws.random.cat/meow')
                .then(response => response.json())
                .then(data => {
                    //  get file extension
                    const urlParts = data.file.split('.');
                    const extension = urlParts[urlParts.lastIndex];

                    //  display either image or video
                    if (extension === ""mp4"") {
                        imgCat.src = data.url;
                        imgCat.style.display = 'inline-block';
                    ");
            WriteLiteral("} else {\r\n                        vidCat.src = data.url;\r\n                        vidCat.style.display = \'inline-block\';\r\n                    }\r\n                });\r\n        }\r\n\r\n        getCat();\r\n\r\n    </script>\r\n</div>\r\n");
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
