#pragma checksum "C:\Users\plusf\Desktop\study\4_1\cloudVM\NewF\0413\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c434099ece18fafb35dce526d892ab8551779fe"
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
#line 1 "C:\Users\plusf\Desktop\study\4_1\cloudVM\NewF\0413\Views\_ViewImports.cshtml"
using _0413;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\plusf\Desktop\study\4_1\cloudVM\NewF\0413\Views\_ViewImports.cshtml"
using _0413.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c434099ece18fafb35dce526d892ab8551779fe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1febabcd391cc21c94b01194bbc3656c30609124", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\plusf\Desktop\study\4_1\cloudVM\NewF\0413\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome Cloud</h1>

    <div>
        <p>클라우드란 인터넷에 연결된 다른 컴퓨터의 자원을 확용하는 것을 의미한다.</p>
        <p>내 기기에 저장하는게 아니라 인터넷에 연결된 다른 기기에 저장한다. 또한 저장뿐만 아니라 기능도 빌릴 수 있다.
        빌리고 싶은 만큼만 빌려서 사용할수 있다.
        </p>
    </div>
    <div>
        <p>EC2 : 가장 범용적으로 이용되는 서비스이다. (설정 및 관리가 필요하다.)</p>
        <p>AWS Lambda : 서버리스 컴퓨팅 서비스, 클라우드에서 동작하기 원하는 특정 코드만 올려 놓으면 코드가 동작할 떄만 사용하는 서버이다.</p>
        <p>AWS Aurora : Lambda의 데이터베이스 버전이라고도 한다. 서버 없이 바로 DB만 사용가능하며 사용한 만큼만 요금을 낸다.</p>
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
