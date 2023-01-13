﻿namespace WojtusDiscord.ActivityArchiveService.Models;

public class DiscordVoiceStatusDetails : BaseModel
{
    public bool IsSelfMuted { get; set; }
    public bool IsSelfDeafened { get; set; }
    public bool IsSelfStream { get; set; }
    public bool IsSelfVideo { get; set; }
    public bool IsServerMuted { get; set; }
    public bool IsServerDeafened { get; set; }
    public bool IsSuppressed { get; set; }
}