#pragma checksum "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\Pages\TableTemplate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6cb965abe875cce8bb6813895715aaa2a8619d3"
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
    public partial class TableTemplate<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>TableTemplate</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "thead");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.AddContent(8, 
#nullable restore
#line 10 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\Pages\TableTemplate.razor"
             Header

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "tbody");
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 18 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\Pages\TableTemplate.razor"
         foreach (var item in items)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "            ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.AddContent(17, 
#nullable restore
#line 21 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\Pages\TableTemplate.razor"
                 Row(item)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 23 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\Pages\TableTemplate.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\Lecture-CSharpBlazorApplication\Pages\TableTemplate.razor"
       
    // HTML TAG 묶음을 RenderFragment에 넘겨주는 방식.
    [Parameter]
    public RenderFragment Header { get; set; }

    [Parameter]
    public RenderFragment<TItem> Row { get; set; }

    [Parameter]
    public IReadOnlyList<TItem> items { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
