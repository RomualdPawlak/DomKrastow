using HouseKrast.Webpage.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace HouseKrast.Webpage.BackendCode
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }

        protected TimelineItem[] KrastTimeline;

        protected override async Task OnInitializedAsync()
        {
            KrastTimeline = await Http.GetFromJsonAsync<TimelineItem[]>("data/timeline.json");

            Console.WriteLine(KrastTimeline);
        }
    }
}
