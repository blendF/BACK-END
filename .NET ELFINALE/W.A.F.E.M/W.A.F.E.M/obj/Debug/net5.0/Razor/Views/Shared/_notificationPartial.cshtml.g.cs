#pragma checksum "C:\Users\RS Computers\Desktop\.NET ELFINALE\W.A.F.E.M\W.A.F.E.M\Views\Shared\_notificationPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72b5cb314d652a579b39c16aad3db929361498da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__notificationPartial), @"mvc.1.0.view", @"/Views/Shared/_notificationPartial.cshtml")]
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
#line 1 "C:\Users\RS Computers\Desktop\.NET ELFINALE\W.A.F.E.M\W.A.F.E.M\Views\_ViewImports.cshtml"
using W.A.F.E.M;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RS Computers\Desktop\.NET ELFINALE\W.A.F.E.M\W.A.F.E.M\Views\_ViewImports.cshtml"
using W.A.F.E.M.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72b5cb314d652a579b39c16aad3db929361498da", @"/Views/Shared/_notificationPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc5d7c460cb4a86f0759c6897756cf1e45c8ad9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__notificationPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<script>\n    var msg = ");
#nullable restore
#line 3 "C:\Users\RS Computers\Desktop\.NET ELFINALE\W.A.F.E.M\W.A.F.E.M\Views\Shared\_notificationPartial.cshtml"
          Write(TempData["Message"]!=null? Html.Raw(TempData["Message"]) : Html.Raw("undefined"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    console.log(msg)

    if (msg) {
        if (msg.provider == ""sweetAlert"") {
            swal.fire({
                title: msg.title,
                text: msg.message,
                icon: msg.icon
            });
        } else {
            toastr[msg.type](msg.message, msg.title);
        }
    }
</script>

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
