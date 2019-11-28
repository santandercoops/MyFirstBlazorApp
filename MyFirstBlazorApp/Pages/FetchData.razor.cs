using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using MyFirstBlazorApp.Data;

namespace MyFirstBlazorApp.Pages
{
    public class FetchDataBase : ComponentBase
    {
        [Inject] WeatherForecastService ForecastService { get; set; }

        protected WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
