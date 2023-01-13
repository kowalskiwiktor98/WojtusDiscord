﻿namespace WojtusDiscord.ActivityArchiveService.Models;

public class DiscordGuild : BaseDiscordModel
{
    public string Name { get; set; }
    public string? IconUrl { get; set; }

    public Guid OwnerId { get; set; }
    public DiscordUser Owner { get; set; }

    public ICollection<DiscordChannel> Channels { get; set; }
    public ICollection<DiscordGuildMember> Members { get; set; }
}
