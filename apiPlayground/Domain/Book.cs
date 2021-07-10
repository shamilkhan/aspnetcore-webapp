using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace apiPlayground.Domain
{
    public class Book
    {
        [JsonPropertyName("id")]
        public int BookId { get; set; }

        public List<Author> authros { get; set; } = new List<Author>();
    }
}
