using System.Text;

namespace HouseKrast.Webpage.Models
{
    public class TimelineItem
    {
        public int Year { get; set; }
        public string Title { get; set; }
        public string BookTitle { get; set; }
        public BookSeries Volume { get; set; }
        public string PublishedIn { get; set; }
        public PublicationType Type { get; set; }

        public string PublishedInFormatted
        {
            get
            {
                if (Type == 0 || string.IsNullOrWhiteSpace(BookTitle))
                {
                    return string.Empty;
                }

                var builder = new StringBuilder($"{Type}: {BookTitle}");
                if (!string.IsNullOrWhiteSpace(PublishedIn))
                {
                    builder.Append($" ({PublishedIn})");
                }
                return builder.ToString();
            }
        }
    }

    public enum BookSeries
    {
        PodarowacNiebo = 1,
        PustyOgrod = 2,
        WyborMony = 3,
        WolnyJakHamilton = 4
    }

    public enum PublicationType
    {
        Opowiadanie = 1,
        Powiesc = 2
    }
}
