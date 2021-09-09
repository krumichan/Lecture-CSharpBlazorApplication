using Lecture_CSharpBlazorApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture_CSharpBlazorApplication.Pages
{
    // razor component에서 @code { }를 분리하고 싶으면,
    // razor와 class의 파일명을 맞추면 사용할 수 있다.
    public partial class FetchDataSep
    {
        private WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
