using Fluxor;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorAppState.Store.WeatherUseCase
{
    public class FetchDataActionEffect : Effect<FetchDataAction>
    {
        private readonly HttpClient _http;

        public FetchDataActionEffect(HttpClient http)
        {
            _http = http;
        }

        protected override async Task HandleAsync(FetchDataAction action, IDispatcher dispatcher)
        {
            var forecasts = await _http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
            dispatcher.Dispatch(new FetchDataResultAction(forecasts));
        }
    }
}