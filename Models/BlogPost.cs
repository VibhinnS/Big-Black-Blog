using System;

namespace BlogApp.Models {
    public class BlogPost {
        public int Id {get; set;}
        public required string Title {get; set;}
        public required string Content {get; set;}
        public required string Author {get; set;}
        public DateTime PublishedDate {get; set;}
    }
}
