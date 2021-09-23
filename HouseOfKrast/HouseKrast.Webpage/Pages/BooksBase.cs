using HouseKrast.Webpage.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace HouseKrast.Webpage.Pages
{
    public class BooksBase : ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }

        protected Book[] Books { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Books = await Http.GetFromJsonAsync<Book[]>("data/books.json");
        }
    }
}
