using HouseKrast.Webpage.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace HouseKrast.Webpage.Pages
{
    public class BooksBase : ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }

        protected IList<Book> PublishedBooks { get; set; }

        protected IList<Book> NotPublishedBooks { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var _books = await Http.GetFromJsonAsync<Book[]>("data/books.json");

            PublishedBooks = _books
                .Where(x => x.PublishDate <= DateTime.Now)
                .OrderByDescending(x => x.PublishDate)
                .ToList();

            NotPublishedBooks = _books
                .Where(x => x.PublishDate > DateTime.Now)
                .OrderByDescending(x => x.PublishDate)
                .ToList();
        }
    }
}
