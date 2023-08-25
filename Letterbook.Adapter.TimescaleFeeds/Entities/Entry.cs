﻿using Models = Letterbook.Core.Models;

namespace Letterbook.Adapter.TimescaleFeeds.Entities;

public class Entry
{
    // Time is when the post was added to the feed, not when it was created
    // Those are often more or less the same, except in the case of boosts
    public DateTime Time { get; set; } = DateTime.Now;  //index
    public Models.ActivityObjectType Type { get; set; }
    public string EntityId { get; set; }  //index
    public string AudienceKey { get; set; } //index
    public string? AudienceName { get; set; }
    public string[] CreatedBy { get; set; } //json
    public string Authority { get; set; }
    public string? BoostedBy { get; set; }
    public DateTime CreatedDate { get; set; }
}
