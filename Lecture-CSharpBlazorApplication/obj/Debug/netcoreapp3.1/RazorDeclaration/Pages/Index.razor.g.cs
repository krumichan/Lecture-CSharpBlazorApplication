// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Lecture_CSharpBlazorApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\_Imports.razor"
using Lecture_CSharpBlazorApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\_Imports.razor"
using Lecture_CSharpBlazorApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\Pages\Index.razor"
using Lecture_CSharpBlazorApplication.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\Pages\Index.razor"
               
    protected override void OnInitialized()
    {
        // breakpoint??? ???????????? ????????? ??????,
        // paymentService??? _foodService??? ????????????
        // ????????? ????????? ????????? ?????? ????????? ??? ??????.
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ScopedService scoped { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TransientService transient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SingletonService singleton { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PaymentService paymentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFoodService foodService { get; set; }
    }
}
#pragma warning restore 1591
