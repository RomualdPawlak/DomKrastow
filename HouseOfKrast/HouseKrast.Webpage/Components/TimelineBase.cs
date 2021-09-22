using HouseKrast.Webpage.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace HouseKrast.Webpage.Components
{
    public class TimelineBase : ComponentBase
    {
        [Parameter]
        public int StartYear { get; set; } = 2100;

        [Parameter]
        public int EndYear { get; set; } = 3000;

        [Parameter]
        public int YearJump { get; set; } = 10;

        [Parameter]
        public TimelineItem[] KrastTimeline { get; set; }

        public bool Reset = true;

        protected IEnumerable<IGrouping<int, TimelineItem>> GetEvents(int year)
        {
            return KrastTimeline
                .Where(x => x.Year >= year && x.Year < year + YearJump)
                .GroupBy(x => x.Year);
        }

        protected void SetReset(bool newValue)
        {
            Reset = newValue;
        }
    }
}
