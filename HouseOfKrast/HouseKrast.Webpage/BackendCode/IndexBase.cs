using HouseKrast.Webpage.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace HouseKrast.Webpage.BackendCode
{
    public class IndexBase : ComponentBase
    {
        public int StartYear = 2100;
        public int EndYear = 3000;
        public int YearJump = 10;

        public bool Reset = true;

        [Inject]
        public HttpClient Http { get; set; }

        public TimelineItem[] KrastTimeline;

        protected override async Task OnInitializedAsync()
        {
            KrastTimeline = await Http.GetFromJsonAsync<TimelineItem[]>("data/timeline.json");

            Console.WriteLine(KrastTimeline);
        }

        protected IEnumerable<TimelineItem> GetEvents(int year)
        {
            return KrastTimeline.Where(x => x.Year >= year && x.Year < year + YearJump);
        }

        protected void SetReset(bool newValue)
        {
            Reset = newValue;
        }
    }
}
