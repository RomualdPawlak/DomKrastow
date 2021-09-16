using HouseKrast.Site.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HouseKrast.Site.BackendCode
{
    public class IndexBase : ComponentBase
    {
        public int StartYear = 2100;
        public int EndYear = 3000;

        [Inject]
        public HttpClient Http { get; set; }

        public TimelineItem[] KrastTimeline;

        protected override async Task OnInitializedAsync()
        {
            //KrastTimeline = new TimelineItem[] { };
            //var options = new JsonSerializerOptions()
            //{
            //    ReferenceHandler = ReferenceHandler.Preserve,
            //    PropertyNameCaseInsensitive = true
            //};
            //KrastTimeline = await Http.GetFromJsonAsync<TimelineItem[]>("data/timeline.json");
            //var file = await Http.GetStringAsync("data/timeline.json");
            //Console.WriteLine(file);
        }
    }
}
