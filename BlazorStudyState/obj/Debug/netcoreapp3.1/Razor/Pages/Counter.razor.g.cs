#pragma checksum "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyState\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f09c1bdca4ff29bd834411cffe86b26f466a59f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorStudyState.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyState\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyState\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyState\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyState\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyState\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyState\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyState\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyState\_Imports.razor"
using BlazorStudyState;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyState\_Imports.razor"
using BlazorStudyState.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 6 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyState\Pages\Counter.razor"
                   CounterState.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyState\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyState\Pages\Counter.razor"
       
    private void IncrementCount()
    {
        CounterState.Count++;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorStudyState.Data.CounterState CounterState { get; set; }
    }
}
#pragma warning restore 1591
