// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorStudyFormValidation.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyFormValidation\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyFormValidation\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyFormValidation\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyFormValidation\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyFormValidation\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyFormValidation\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyFormValidation\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyFormValidation\_Imports.razor"
using BlazorStudyFormValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyFormValidation\_Imports.razor"
using BlazorStudyFormValidation.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyFormValidation\Pages\FetchData.razor"
using BlazorStudyFormValidation.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\developer\unityws\lecture\web server\Lecture-CSharpBlazorApplication\BlazorStudyFormValidation\Pages\FetchData.razor"
       
    private List<WeatherForecast> _forecasts;

    bool _showPopup = false;
    WeatherForecast _addForecast;

    protected override async Task OnInitializedAsync()
    {
        _forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

    private void AddNewForecast()
    {
        _showPopup = true;
        _addForecast = new WeatherForecast();
    }

    private void SaveForecast()
    {
        _showPopup = false;
        _addForecast.Date = DateTime.Now;
        _forecasts.Add(_addForecast);
    }

    private void ClosePopup()
    {
        _showPopup = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591