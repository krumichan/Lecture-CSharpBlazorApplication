#pragma checksum "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27a89b8238ad1e394484aa2ae0196cc32c53a8b2"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\Pages\Counter.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "style", "color:" + (
#nullable restore
#line 6 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\Pages\Counter.razor"
                  _color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(2, "Counter");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, "Current count: ");
            __builder.AddContent(6, 
#nullable restore
#line 8 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-primary");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-secondary");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\Pages\Counter.razor"
                                            AutoIncrement

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Auto Increment");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\Pages\Counter.razor"
       
    [CascadingParameter(Name = "ThemeColor")]
    string _color { get; set; }

    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

    private void AutoIncrement()
    {
        var timer = new Timer(x =>
        {
            InvokeAsync(() =>
            {
                IncrementCount();
                StateHasChanged();  // ???????????? page ??????.
            });
        }, null, 1000, 1000);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
