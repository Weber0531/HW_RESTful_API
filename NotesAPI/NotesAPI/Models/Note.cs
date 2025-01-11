using System;

namespace NotesAPI.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string? Location { get; set; } // 可選
        public string? Url { get; set; }      // 可選
    }
}
