﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WojtusDiscord.ActivityArchiveService.Database;

#nullable disable

namespace WojtusDiscord.ActivityArchiveService.Migrations
{
    [DbContext(typeof(ActivityArchiveContext))]
    partial class ActivityArchiveContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordEmote", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<decimal>("DiscordId")
                        .HasColumnType("numeric(20,0)")
                        .HasColumnName("discord_id");

                    b.Property<bool>("IsAnimated")
                        .HasColumnType("boolean")
                        .HasColumnName("is_animated");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("Url")
                        .HasColumnType("text")
                        .HasColumnName("url");

                    b.HasKey("Id")
                        .HasName("pk_discord_emotes");

                    b.ToTable("discord_emotes", (string)null);
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordGuild", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<decimal>("DiscordId")
                        .HasColumnType("numeric(20,0)")
                        .HasColumnName("discord_id");

                    b.Property<string>("IconUrl")
                        .HasColumnType("text")
                        .HasColumnName("icon_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uuid")
                        .HasColumnName("owner_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_discord_guilds");

                    b.HasIndex("OwnerId")
                        .HasDatabaseName("ix_discord_guilds_owner_id");

                    b.ToTable("discord_guilds", (string)null);
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordGuildMember", b =>
                {
                    b.Property<Guid>("DiscordGuildId")
                        .HasColumnType("uuid")
                        .HasColumnName("discord_guild_id");

                    b.Property<Guid>("DiscordUserId")
                        .HasColumnType("uuid")
                        .HasColumnName("discord_user_id");

                    b.HasKey("DiscordGuildId", "DiscordUserId")
                        .HasName("pk_discord_guild_members");

                    b.HasIndex("DiscordUserId")
                        .HasDatabaseName("ix_discord_guild_members_discord_user_id");

                    b.ToTable("discord_guild_members", (string)null);
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uuid")
                        .HasColumnName("author_id");

                    b.Property<string>("Content")
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<decimal>("DiscordId")
                        .HasColumnType("numeric(20,0)")
                        .HasColumnName("discord_id");

                    b.Property<DateTime>("DiscordTimestamp")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("discord_timestamp");

                    b.Property<bool>("HasAttatchment")
                        .HasColumnType("boolean")
                        .HasColumnName("has_attatchment");

                    b.Property<bool>("IsEdited")
                        .HasColumnType("boolean")
                        .HasColumnName("is_edited");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("boolean")
                        .HasColumnName("is_removed");

                    b.Property<Guid?>("ReplyToMessageId")
                        .HasColumnType("uuid")
                        .HasColumnName("reply_to_message_id");

                    b.Property<Guid>("TextChannelId")
                        .HasColumnType("uuid")
                        .HasColumnName("text_channel_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_discord_messages");

                    b.HasIndex("AuthorId")
                        .HasDatabaseName("ix_discord_messages_author_id");

                    b.HasIndex("ReplyToMessageId")
                        .HasDatabaseName("ix_discord_messages_reply_to_message_id");

                    b.HasIndex("TextChannelId")
                        .HasDatabaseName("ix_discord_messages_text_channel_id");

                    b.ToTable("discord_messages", (string)null);
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordMessageContentEdit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Content")
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<string>("ContentBefore")
                        .HasColumnType("text")
                        .HasColumnName("content_before");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("boolean")
                        .HasColumnName("is_removed");

                    b.Property<Guid>("MessageId")
                        .HasColumnType("uuid")
                        .HasColumnName("message_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_discord_message_content_edit");

                    b.HasIndex("MessageId")
                        .HasDatabaseName("ix_discord_message_content_edit_message_id");

                    b.ToTable("discord_message_content_edit", (string)null);
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordPresenceStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<Guid>("DetailsId")
                        .HasColumnType("uuid")
                        .HasColumnName("details_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_discord_presence_statuses");

                    b.HasIndex("DetailsId")
                        .HasDatabaseName("ix_discord_presence_statuses_details_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_discord_presence_statuses_user_id");

                    b.ToTable("discord_presence_statuses", (string)null);
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordPresenceStatusDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("ActivityType")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("activity_type");

                    b.Property<Guid?>("BeforeId")
                        .HasColumnType("uuid")
                        .HasColumnName("before_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Details")
                        .HasColumnType("text")
                        .HasColumnName("details");

                    b.Property<string>("LargeImageText")
                        .HasColumnType("text")
                        .HasColumnName("large_image_text");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("SmallImageText")
                        .HasColumnType("text")
                        .HasColumnName("small_image_text");

                    b.Property<string>("State")
                        .HasColumnType("text")
                        .HasColumnName("state");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_discord_presence_status_entries");

                    b.HasIndex("BeforeId")
                        .HasDatabaseName("ix_discord_presence_status_entries_before_id");

                    b.ToTable("discord_presence_status_entries", (string)null);
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordReaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<Guid>("EmoteId")
                        .HasColumnType("uuid")
                        .HasColumnName("emote_id");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("boolean")
                        .HasColumnName("is_removed");

                    b.Property<Guid>("MessageId")
                        .HasColumnType("uuid")
                        .HasColumnName("message_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_discord_reactions");

                    b.HasIndex("EmoteId")
                        .HasDatabaseName("ix_discord_reactions_emote_id");

                    b.HasIndex("MessageId")
                        .HasDatabaseName("ix_discord_reactions_message_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_discord_reactions_user_id");

                    b.ToTable("discord_reactions", (string)null);
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordTextChannel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<decimal>("DiscordId")
                        .HasColumnType("numeric(20,0)")
                        .HasColumnName("discord_id");

                    b.Property<Guid?>("GuildId")
                        .HasColumnType("uuid")
                        .HasColumnName("guild_id");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("boolean")
                        .HasColumnName("is_private");

                    b.Property<bool>("IsThread")
                        .HasColumnType("boolean")
                        .HasColumnName("is_thread");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<Guid?>("ParentTextChannelId")
                        .HasColumnType("uuid")
                        .HasColumnName("parent_text_channel_id");

                    b.Property<string>("Topic")
                        .HasColumnType("text")
                        .HasColumnName("topic");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_discord_text_channels");

                    b.HasIndex("GuildId")
                        .HasDatabaseName("ix_discord_text_channels_guild_id");

                    b.HasIndex("ParentTextChannelId")
                        .HasDatabaseName("ix_discord_text_channels_parent_text_channel_id");

                    b.ToTable("discord_text_channels", (string)null);
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordTypingStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("ChannelId")
                        .HasColumnType("uuid")
                        .HasColumnName("channel_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<Guid>("TextChannelId")
                        .HasColumnType("uuid")
                        .HasColumnName("text_channel_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_discord_typing_statuses");

                    b.HasIndex("TextChannelId")
                        .HasDatabaseName("ix_discord_typing_statuses_text_channel_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_discord_typing_statuses_user_id");

                    b.ToTable("discord_typing_statuses", (string)null);
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("text")
                        .HasColumnName("avatar_url");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<decimal>("DiscordId")
                        .HasColumnType("numeric(20,0)")
                        .HasColumnName("discord_id");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("discriminator");

                    b.Property<bool>("IsBot")
                        .HasColumnType("boolean")
                        .HasColumnName("is_bot");

                    b.Property<bool>("IsWebhook")
                        .HasColumnType("boolean")
                        .HasColumnName("is_webhook");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username");

                    b.HasKey("Id")
                        .HasName("pk_discord_users");

                    b.ToTable("discord_users", (string)null);
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordVoiceChannel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<int>("BitRate")
                        .HasColumnType("integer")
                        .HasColumnName("bit_rate");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<decimal>("DiscordId")
                        .HasColumnType("numeric(20,0)")
                        .HasColumnName("discord_id");

                    b.Property<Guid>("GuildId")
                        .HasColumnType("uuid")
                        .HasColumnName("guild_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("RtcRegion")
                        .HasColumnType("text")
                        .HasColumnName("rtc_region");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<int>("UserLimit")
                        .HasColumnType("integer")
                        .HasColumnName("user_limit");

                    b.HasKey("Id")
                        .HasName("pk_discord_voice_channels");

                    b.HasIndex("GuildId")
                        .HasDatabaseName("ix_discord_voice_channels_guild_id");

                    b.ToTable("discord_voice_channels", (string)null);
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordVoiceStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<Guid>("DetailsId")
                        .HasColumnType("uuid")
                        .HasColumnName("details_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.Property<Guid>("VoiceChannelId")
                        .HasColumnType("uuid")
                        .HasColumnName("voice_channel_id");

                    b.HasKey("Id")
                        .HasName("pk_discord_voice_statuses");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_discord_voice_statuses_user_id");

                    b.HasIndex("VoiceChannelId")
                        .HasDatabaseName("ix_discord_voice_statuses_voice_channel_id");

                    b.ToTable("discord_voice_statuses", (string)null);
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordVoiceStatusDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("BeforeId")
                        .HasColumnType("uuid")
                        .HasColumnName("before_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<bool>("IsSelfDeafened")
                        .HasColumnType("boolean")
                        .HasColumnName("is_self_deafened");

                    b.Property<bool>("IsSelfMuted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_self_muted");

                    b.Property<bool>("IsSelfStream")
                        .HasColumnType("boolean")
                        .HasColumnName("is_self_stream");

                    b.Property<bool>("IsSelfVideo")
                        .HasColumnType("boolean")
                        .HasColumnName("is_self_video");

                    b.Property<bool>("IsServerDeafened")
                        .HasColumnType("boolean")
                        .HasColumnName("is_server_deafened");

                    b.Property<bool>("IsServerMuted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_server_muted");

                    b.Property<bool>("IsSuppressed")
                        .HasColumnType("boolean")
                        .HasColumnName("is_suppressed");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uuid")
                        .HasColumnName("status_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_discord_voice_status_entries");

                    b.HasIndex("BeforeId")
                        .HasDatabaseName("ix_discord_voice_status_entries_before_id");

                    b.HasIndex("StatusId")
                        .IsUnique()
                        .HasDatabaseName("ix_discord_voice_status_entries_status_id");

                    b.ToTable("discord_voice_status_entries", (string)null);
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordGuild", b =>
                {
                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_discord_guilds_discord_users_owner_id");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordGuildMember", b =>
                {
                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordGuild", "DiscordGuild")
                        .WithMany("Members")
                        .HasForeignKey("DiscordGuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_discord_guild_members_discord_guilds_discord_guild_id");

                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordUser", "DiscordUser")
                        .WithMany("Guilds")
                        .HasForeignKey("DiscordUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_discord_guild_members_discord_users_discord_user_id");

                    b.Navigation("DiscordGuild");

                    b.Navigation("DiscordUser");
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordMessage", b =>
                {
                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordUser", "Author")
                        .WithMany("Messages")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_discord_messages_discord_users_author_id");

                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordMessage", "ReplyToMessage")
                        .WithMany()
                        .HasForeignKey("ReplyToMessageId")
                        .HasConstraintName("fk_discord_messages_discord_messages_reply_to_message_id");

                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordTextChannel", "TextChannel")
                        .WithMany("Messages")
                        .HasForeignKey("TextChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_discord_messages_discord_text_channels_text_channel_id");

                    b.Navigation("Author");

                    b.Navigation("ReplyToMessage");

                    b.Navigation("TextChannel");
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordMessageContentEdit", b =>
                {
                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordMessage", "Message")
                        .WithMany("ContentEdits")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_discord_message_content_edit_discord_messages_message_id");

                    b.Navigation("Message");
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordPresenceStatus", b =>
                {
                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordPresenceStatusDetails", "Details")
                        .WithMany()
                        .HasForeignKey("DetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_discord_presence_statuses_discord_presence_status_entries_d");

                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordUser", "User")
                        .WithMany("PresenceStatuses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_discord_presence_statuses_discord_users_user_id");

                    b.Navigation("Details");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordPresenceStatusDetails", b =>
                {
                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordPresenceStatusDetails", "Before")
                        .WithMany()
                        .HasForeignKey("BeforeId")
                        .HasConstraintName("fk_discord_presence_status_entries_discord_presence_status_ent");

                    b.Navigation("Before");
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordReaction", b =>
                {
                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordEmote", "Emote")
                        .WithMany("Reactions")
                        .HasForeignKey("EmoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_discord_reactions_discord_emotes_emote_id");

                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordMessage", "Message")
                        .WithMany("Reactions")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_discord_reactions_discord_messages_message_id");

                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordUser", "User")
                        .WithMany("Reactions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_discord_reactions_discord_users_user_id");

                    b.Navigation("Emote");

                    b.Navigation("Message");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordTextChannel", b =>
                {
                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordGuild", "Guild")
                        .WithMany("TextChannels")
                        .HasForeignKey("GuildId")
                        .HasConstraintName("fk_discord_text_channels_discord_guilds_guild_id");

                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordTextChannel", "ParentTextChannel")
                        .WithMany()
                        .HasForeignKey("ParentTextChannelId")
                        .HasConstraintName("fk_discord_text_channels_discord_text_channels_parent_text_cha");

                    b.Navigation("Guild");

                    b.Navigation("ParentTextChannel");
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordTypingStatus", b =>
                {
                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordTextChannel", "TextChannel")
                        .WithMany()
                        .HasForeignKey("TextChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_discord_typing_statuses_discord_text_channels_text_channel_id");

                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordUser", "User")
                        .WithMany("TypingStatuses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_discord_typing_statuses_discord_users_user_id");

                    b.Navigation("TextChannel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordVoiceChannel", b =>
                {
                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordGuild", "Guild")
                        .WithMany("VoiceChannels")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_discord_voice_channels_discord_guilds_guild_id");

                    b.Navigation("Guild");
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordVoiceStatus", b =>
                {
                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordUser", "User")
                        .WithMany("VoiceStatuses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_discord_voice_statuses_discord_users_user_id");

                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordVoiceChannel", "VoiceChannel")
                        .WithMany("VoiceStatuses")
                        .HasForeignKey("VoiceChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_discord_voice_statuses_discord_voice_channels_voice_channel");

                    b.Navigation("User");

                    b.Navigation("VoiceChannel");
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordVoiceStatusDetails", b =>
                {
                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordVoiceStatusDetails", "Before")
                        .WithMany()
                        .HasForeignKey("BeforeId")
                        .HasConstraintName("fk_discord_voice_status_entries_discord_voice_status_entries_b");

                    b.HasOne("WojtusDiscord.ActivityArchiveService.Models.DiscordVoiceStatus", "Status")
                        .WithOne("Details")
                        .HasForeignKey("WojtusDiscord.ActivityArchiveService.Models.DiscordVoiceStatusDetails", "StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_discord_voice_status_entries_discord_voice_statuses_status_i");

                    b.Navigation("Before");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordEmote", b =>
                {
                    b.Navigation("Reactions");
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordGuild", b =>
                {
                    b.Navigation("Members");

                    b.Navigation("TextChannels");

                    b.Navigation("VoiceChannels");
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordMessage", b =>
                {
                    b.Navigation("ContentEdits");

                    b.Navigation("Reactions");
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordTextChannel", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordUser", b =>
                {
                    b.Navigation("Guilds");

                    b.Navigation("Messages");

                    b.Navigation("PresenceStatuses");

                    b.Navigation("Reactions");

                    b.Navigation("TypingStatuses");

                    b.Navigation("VoiceStatuses");
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordVoiceChannel", b =>
                {
                    b.Navigation("VoiceStatuses");
                });

            modelBuilder.Entity("WojtusDiscord.ActivityArchiveService.Models.DiscordVoiceStatus", b =>
                {
                    b.Navigation("Details")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
