﻿using static CadvancedOpdracht.Models.Location;

namespace CadvancedOpdracht.Models.DtoV2
{
    public class LocationDtoV2
    {
        public int id { get; set; }
        public string title { get; set; }
        public string subTitle { get; set; }
        public string description { get; set; }
        public string imageURL { get; set; }
        public string landlordAvatarURL { get; set; }
        public float price { get; set; }
        public Location.LocationType type { get; set; }
    }
}
