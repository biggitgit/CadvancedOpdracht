﻿namespace CadvancedOpdracht.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsCover { get; set; }
        public int? LocationId { get; set; }
        public Location Location { get; set; }  
    }
}
