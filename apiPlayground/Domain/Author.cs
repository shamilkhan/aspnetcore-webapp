using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace apiPlayground.Domain
{
    public class Author
    {
        [JsonPropertyName("id")]
        public int AuthorId { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        [JsonIgnore]
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
