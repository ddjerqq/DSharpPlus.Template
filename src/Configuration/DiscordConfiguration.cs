namespace @RepositoryOwner.@RepositoryName.Configuration
{
    public sealed record DiscordConfiguration
    {
        public required string? Token { get; init; }
        public string Prefix { get; init; } = "!";
        public ulong GuildId { get; init; }
        public string SupportServerInvite { get; init; } = "https://discord.gg/your-server-invite";
    }
}
