//https://app.quicktype.io/ was used to help generate this code

namespace EventLinkConsoleApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class FacebookPosts
    {
        //[JsonProperty("facebookUrl")]
        //public Uri FacebookUrl { get; set; }

        [Key]
        [JsonProperty("postId")]
        public string PostId { get; set; }

        [JsonProperty("pageName")]
        public string PageName { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        //[JsonProperty("time")]
        //public DateTimeOffset Time { get; set; }

        //[JsonProperty("timestamp")]
        //public long Timestamp { get; set; }

        //[JsonProperty("user")]
        //public User User { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        //[JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        //public Uri Link { get; set; }

        //[JsonProperty("likes")]
        //public long Likes { get; set; }

        //[JsonProperty("comments")]
        //public long Comments { get; set; }

        //[JsonProperty("shares")]
        //public long Shares { get; set; }

        //[JsonProperty("media")]
        //public Media[] Media { get; set; }

        //[JsonProperty("feedbackId")]
        //public string FeedbackId { get; set; }

        //[JsonProperty("topLevelUrl")]
        //public Uri TopLevelUrl { get; set; }

        //[JsonProperty("facebookId")]
        //public string FacebookId { get; set; }

        //[JsonProperty("pageAdLibrary")]
        //public PageAdLibrary PageAdLibrary { get; set; }

        //[JsonProperty("isVideo", NullValueHandling = NullValueHandling.Ignore)]
        //public bool? IsVideo { get; set; }

        //[JsonProperty("viewsCount", NullValueHandling = NullValueHandling.Ignore)]
        //public long? ViewsCount { get; set; }
    }

    //public partial class Media
    //{
    //    [JsonProperty("thumbnail")]
    //    public Uri Thumbnail { get; set; }

    //    [JsonProperty("__typename")]
    //    public IsMedia Typename { get; set; }

    //    [JsonProperty("__isMedia", NullValueHandling = NullValueHandling.Ignore)]
    //    public IsMedia? IsMedia { get; set; }

    //    [JsonProperty("flexible_height_share_image")]
    //    public object FlexibleHeightShareImage { get; set; }

    //    [JsonProperty("large_share_image", NullValueHandling = NullValueHandling.Ignore)]
    //    public FlexibleHeightImageClass LargeShareImage { get; set; }

    //    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Id { get; set; }

    //    [JsonProperty("photo_image", NullValueHandling = NullValueHandling.Ignore)]
    //    public FlexibleHeightImageClass PhotoImage { get; set; }

    //    [JsonProperty("accent_color", NullValueHandling = NullValueHandling.Ignore)]
    //    public string AccentColor { get; set; }

    //    [JsonProperty("photo_product_tags", NullValueHandling = NullValueHandling.Ignore)]
    //    public object[] PhotoProductTags { get; set; }

    //    [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
    //    public Uri Url { get; set; }

    //    [JsonProperty("ocrText", NullValueHandling = NullValueHandling.Ignore)]
    //    public string OcrText { get; set; }

    //    [JsonProperty("is_playable", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsPlayable { get; set; }

    //    [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
    //    public FlexibleHeightImageClass Image { get; set; }

    //    [JsonProperty("photo_cix_screen")]
    //    public object PhotoCixScreen { get; set; }

    //    [JsonProperty("copyright_banner_info")]
    //    public object CopyrightBannerInfo { get; set; }

    //    [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
    //    public Owner Owner { get; set; }

    //    [JsonProperty("thumbnailImage", NullValueHandling = NullValueHandling.Ignore)]
    //    public ThumbnailImageClass ThumbnailImage { get; set; }

    //    [JsonProperty("is_clipping_enabled", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsClippingEnabled { get; set; }

    //    [JsonProperty("live_rewind_enabled", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? LiveRewindEnabled { get; set; }

    //    [JsonProperty("playable_duration_in_ms", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? PlayableDurationInMs { get; set; }

    //    [JsonProperty("is_huddle", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsHuddle { get; set; }

    //    [JsonProperty("if_viewer_can_use_latency_menu")]
    //    public object IfViewerCanUseLatencyMenu { get; set; }

    //    [JsonProperty("if_viewer_can_use_latency_menu_toggle")]
    //    public object IfViewerCanUseLatencyMenuToggle { get; set; }

    //    [JsonProperty("captions_url")]
    //    public object CaptionsUrl { get; set; }

    //    [JsonProperty("video_available_captions_locales", NullValueHandling = NullValueHandling.Ignore)]
    //    public object[] VideoAvailableCaptionsLocales { get; set; }

    //    [JsonProperty("if_viewer_can_see_community_moderation_tools")]
    //    public object IfViewerCanSeeCommunityModerationTools { get; set; }

    //    [JsonProperty("if_viewer_can_use_live_rewind")]
    //    public object IfViewerCanUseLiveRewind { get; set; }

    //    [JsonProperty("if_viewer_can_use_clipping")]
    //    public object IfViewerCanUseClipping { get; set; }

    //    [JsonProperty("if_viewer_can_see_costreaming_tools")]
    //    public object IfViewerCanSeeCostreamingTools { get; set; }

    //    [JsonProperty("video_player_scrubber_base_content_renderer")]
    //    public object VideoPlayerScrubberBaseContentRenderer { get; set; }

    //    [JsonProperty("video_player_scrubber_preview_renderer", NullValueHandling = NullValueHandling.Ignore)]
    //    public VideoPlayerScrubberPreviewRenderer VideoPlayerScrubberPreviewRenderer { get; set; }

    //    [JsonProperty("recipient_group")]
    //    public object RecipientGroup { get; set; }

    //    [JsonProperty("music_attachment_metadata")]
    //    public object MusicAttachmentMetadata { get; set; }

    //    [JsonProperty("video_container_type", NullValueHandling = NullValueHandling.Ignore)]
    //    public string VideoContainerType { get; set; }

    //    [JsonProperty("breakingStatus", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? BreakingStatus { get; set; }

    //    [JsonProperty("videoId", NullValueHandling = NullValueHandling.Ignore)]
    //    public string VideoId { get; set; }

    //    [JsonProperty("isPremiere", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsPremiere { get; set; }

    //    [JsonProperty("liveViewerCount", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? LiveViewerCount { get; set; }

    //    [JsonProperty("rehearsalInfo")]
    //    public object RehearsalInfo { get; set; }

    //    [JsonProperty("is_gaming_video", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsGamingVideo { get; set; }

    //    [JsonProperty("is_live_audio_room_v2_broadcast", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsLiveAudioRoomV2Broadcast { get; set; }

    //    [JsonProperty("publish_time", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? PublishTime { get; set; }

    //    [JsonProperty("live_speaker_count_indicator")]
    //    public object LiveSpeakerCountIndicator { get; set; }

    //    [JsonProperty("can_viewer_share", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? CanViewerShare { get; set; }

    //    [JsonProperty("end_cards_channel_info", NullValueHandling = NullValueHandling.Ignore)]
    //    public EndCardsChannelInfo EndCardsChannelInfo { get; set; }

    //    [JsonProperty("is_soundbites_video", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsSoundbitesVideo { get; set; }

    //    [JsonProperty("is_looping", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsLooping { get; set; }

    //    [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
    //    public Info Info { get; set; }

    //    //[JsonProperty("animated_image_caption")]
    //    //public object AnimatedImageCaption { get; set; }

    //    [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Width { get; set; }

    //    [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Height { get; set; }

    //    [JsonProperty("broadcaster_origin")]
    //    public object BroadcasterOrigin { get; set; }

    //    //[JsonProperty("broadcast_id")]
    //    //public object BroadcastId { get; set; }

    //    [JsonProperty("broadcast_status")]
    //    public object BroadcastStatus { get; set; }

    //    [JsonProperty("is_live_streaming", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsLiveStreaming { get; set; }

    //    [JsonProperty("is_live_trace_enabled", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsLiveTraceEnabled { get; set; }

    //    [JsonProperty("is_video_broadcast", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsVideoBroadcast { get; set; }

    //    [JsonProperty("is_podcast_video", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsPodcastVideo { get; set; }

    //    [JsonProperty("loop_count", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? LoopCount { get; set; }

    //    [JsonProperty("is_spherical", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsSpherical { get; set; }

    //    [JsonProperty("is_spherical_enabled", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsSphericalEnabled { get; set; }

    //    [JsonProperty("unsupported_browser_message")]
    //    public object UnsupportedBrowserMessage { get; set; }

    //    [JsonProperty("can_play_undiscoverable", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? CanPlayUndiscoverable { get; set; }

    //    [JsonProperty("pmv_metadata")]
    //    public object PmvMetadata { get; set; }

    //    [JsonProperty("latency_sensitive_config")]
    //    public object LatencySensitiveConfig { get; set; }

    //    [JsonProperty("live_playback_instrumentation_configs")]
    //    public object LivePlaybackInstrumentationConfigs { get; set; }

    //    [JsonProperty("is_ncsr", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsNcsr { get; set; }

    //    [JsonProperty("permalink_url", NullValueHandling = NullValueHandling.Ignore)]
    //    public Uri PermalinkUrl { get; set; }

    //    [JsonProperty("dash_prefetch_experimental", NullValueHandling = NullValueHandling.Ignore)]
    //    public string[] DashPrefetchExperimental { get; set; }

    //    [JsonProperty("video_status_type", NullValueHandling = NullValueHandling.Ignore)]
    //    public string VideoStatusType { get; set; }

    //    [JsonProperty("can_use_oz", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? CanUseOz { get; set; }

    //    [JsonProperty("dash_manifest", NullValueHandling = NullValueHandling.Ignore)]
    //    public string DashManifest { get; set; }

    //    [JsonProperty("dash_manifest_url", NullValueHandling = NullValueHandling.Ignore)]
    //    public Uri DashManifestUrl { get; set; }

    //    [JsonProperty("min_quality_preference", NullValueHandling = NullValueHandling.Ignore)]
    //    public string MinQualityPreference { get; set; }

    //    [JsonProperty("audio_user_preferred_language", NullValueHandling = NullValueHandling.Ignore)]
    //    public string AudioUserPreferredLanguage { get; set; }

    //    [JsonProperty("is_rss_podcast_video", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsRssPodcastVideo { get; set; }

    //    [JsonProperty("browser_native_sd_url", NullValueHandling = NullValueHandling.Ignore)]
    //    public Uri BrowserNativeSdUrl { get; set; }

    //    [JsonProperty("browser_native_hd_url", NullValueHandling = NullValueHandling.Ignore)]
    //    public Uri BrowserNativeHdUrl { get; set; }

    //    [JsonProperty("spherical_video_fallback_urls")]
    //    public object SphericalVideoFallbackUrls { get; set; }

    //    [JsonProperty("is_latency_menu_enabled", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsLatencyMenuEnabled { get; set; }

    //    [JsonProperty("fbls_tier")]
    //    public object FblsTier { get; set; }

    //    [JsonProperty("is_latency_sensitive_broadcast", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsLatencySensitiveBroadcast { get; set; }

    //    [JsonProperty("comet_video_player_static_config", NullValueHandling = NullValueHandling.Ignore)]
    //    public string CometVideoPlayerStaticConfig { get; set; }

    //    [JsonProperty("comet_video_player_context_sensitive_config", NullValueHandling = NullValueHandling.Ignore)]
    //    public string CometVideoPlayerContextSensitiveConfig { get; set; }

    //    [JsonProperty("video_player_shaka_performance_logger_init", NullValueHandling = NullValueHandling.Ignore)]
    //    public VideoPlayerShakaPerformanceLoggerInit VideoPlayerShakaPerformanceLoggerInit { get; set; }

    //    [JsonProperty("video_player_shaka_performance_logger_should_sample", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? VideoPlayerShakaPerformanceLoggerShouldSample { get; set; }

    //    [JsonProperty("video_player_shaka_performance_logger_init2", NullValueHandling = NullValueHandling.Ignore)]
    //    public VideoPlayerShakaPerformanceLoggerInit2 VideoPlayerShakaPerformanceLoggerInit2 { get; set; }

    //    [JsonProperty("autoplay_gating_result", NullValueHandling = NullValueHandling.Ignore)]
    //    public string AutoplayGatingResult { get; set; }

    //    [JsonProperty("viewer_autoplay_setting", NullValueHandling = NullValueHandling.Ignore)]
    //    public string ViewerAutoplaySetting { get; set; }

    //    [JsonProperty("can_autoplay", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? CanAutoplay { get; set; }

    //    [JsonProperty("drm_info", NullValueHandling = NullValueHandling.Ignore)]
    //    public string DrmInfo { get; set; }

    //    [JsonProperty("p2p_settings")]
    //    public object P2PSettings { get; set; }

    //    //[JsonProperty("audio_settings")]
    //    //public object AudioSettings { get; set; }

    //    [JsonProperty("captions_settings")]
    //    public object CaptionsSettings { get; set; }

    //    [JsonProperty("broadcast_low_latency_config")]
    //    public object BroadcastLowLatencyConfig { get; set; }

    //    [JsonProperty("audio_availability", NullValueHandling = NullValueHandling.Ignore)]
    //    public string AudioAvailability { get; set; }

    //    [JsonProperty("muted_segments", NullValueHandling = NullValueHandling.Ignore)]
    //    public object[] MutedSegments { get; set; }

    //    [JsonProperty("spherical_video_renderer")]
    //    public object SphericalVideoRenderer { get; set; }

    //    [JsonProperty("preferred_thumbnail", NullValueHandling = NullValueHandling.Ignore)]
    //    public PreferredThumbnail PreferredThumbnail { get; set; }

    //    [JsonProperty("video_imf_data")]
    //    public object VideoImfData { get; set; }

    //    [JsonProperty("original_width", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? OriginalWidth { get; set; }

    //    [JsonProperty("original_height", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? OriginalHeight { get; set; }

    //    [JsonProperty("original_rotation", NullValueHandling = NullValueHandling.Ignore)]
    //    public string OriginalRotation { get; set; }

    //    [JsonProperty("if_viewer_can_see_pay_to_access_paywall")]
    //    public object IfViewerCanSeePayToAccessPaywall { get; set; }

    //    [JsonProperty("comet_video_player_audio_overlay_renderer")]
    //    public object CometVideoPlayerAudioOverlayRenderer { get; set; }

    //    [JsonProperty("comet_video_player_audio_background_renderer")]
    //    public object CometVideoPlayerAudioBackgroundRenderer { get; set; }

    //    [JsonProperty("comet_video_player_music_sprout_background_renderer")]
    //    public object CometVideoPlayerMusicSproutBackgroundRenderer { get; set; }

    //    [JsonProperty("clip_fallback_cover")]
    //    public object ClipFallbackCover { get; set; }

    //    [JsonProperty("is_clip", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsClip { get; set; }

    //    [JsonProperty("matcha_related_keywords_links", NullValueHandling = NullValueHandling.Ignore)]
    //    public string[] MatchaRelatedKeywordsLinks { get; set; }

    //    [JsonProperty("is_music_clip", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsMusicClip { get; set; }

    //    [JsonProperty("video_collaborator_page_or_delegate_page")]
    //    public object VideoCollaboratorPageOrDelegatePage { get; set; }

    //    [JsonProperty("video_anchor_tag_info")]
    //    public object VideoAnchorTagInfo { get; set; }

    //    [JsonProperty("canonical_uri_with_fallback", NullValueHandling = NullValueHandling.Ignore)]
    //    public Uri CanonicalUriWithFallback { get; set; }

    //    [JsonProperty("flexible_height_image", NullValueHandling = NullValueHandling.Ignore)]
    //    public FlexibleHeightImageClass FlexibleHeightImage { get; set; }
    //}

    //public partial class EndCardsChannelInfo
    //{
    //    [JsonProperty("video_chaining_caller")]
    //    public string VideoChainingCaller { get; set; }

    //    [JsonProperty("video_channel_entry_point")]
    //    public string VideoChannelEntryPoint { get; set; }

    //    [JsonProperty("video")]
    //    public EndCardsChannelInfoVideo Video { get; set; }

    //    [JsonProperty("__module_operation_useVideoPlayerWatchEndScreenWithActions_video")]
    //    public ModuleVideo ModuleOperationUseVideoPlayerWatchEndScreenWithActionsVideo { get; set; }

    //    [JsonProperty("__module_component_useVideoPlayerWatchEndScreenWithActions_video")]
    //    public ModuleVideo ModuleComponentUseVideoPlayerWatchEndScreenWithActionsVideo { get; set; }
    //}

    //public partial class ModuleVideo
    //{
    //    [JsonProperty("__dr")]
    //    public string Dr { get; set; }
    //}

    //public partial class EndCardsChannelInfoVideo
    //{
    //    [JsonProperty("id")]
    //    public string Id { get; set; }

    //    [JsonProperty("can_viewer_share")]
    //    public bool CanViewerShare { get; set; }

    //    //[JsonProperty("creation_story")]
    //    //public CreationStory CreationStory { get; set; }
    //}

    ////public partial class CreationStory
    ////{
    ////    [JsonProperty("shareable")]
    ////    public object Shareable { get; set; }

    ////    [JsonProperty("id")]
    ////    public string Id { get; set; }
    ////}

    //public partial class FlexibleHeightImageClass
    //{
    //    [JsonProperty("uri")]
    //    public Uri Uri { get; set; }

    //    [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Height { get; set; }

    //    [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Width { get; set; }
    //}

    //public partial class Info
    //{
    //    [JsonProperty("video_chaining_caller")]
    //    public string VideoChainingCaller { get; set; }

    //    [JsonProperty("video_channel_entry_point")]
    //    public string VideoChannelEntryPoint { get; set; }

    //    [JsonProperty("video_id")]
    //    public string VideoId { get; set; }

    //    [JsonProperty("__module_operation_useVideoPlayerWatchPauseScreenWithActions_video")]
    //    public ModuleVideo ModuleOperationUseVideoPlayerWatchPauseScreenWithActionsVideo { get; set; }

    //    [JsonProperty("__module_component_useVideoPlayerWatchPauseScreenWithActions_video")]
    //    public ModuleVideo ModuleComponentUseVideoPlayerWatchPauseScreenWithActionsVideo { get; set; }
    //}

    //public partial class Owner
    //{
    //    [JsonProperty("__typename")]
    //    public string Typename { get; set; }

    //    [JsonProperty("id")]
    //    public string Id { get; set; }

    //    [JsonProperty("__isVideoOwner", NullValueHandling = NullValueHandling.Ignore)]
    //    public string IsVideoOwner { get; set; }

    //    [JsonProperty("has_professional_features_for_watch", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? HasProfessionalFeaturesForWatch { get; set; }
    //}

    //public partial class PreferredThumbnail
    //{
    //    [JsonProperty("image")]
    //    public ThumbnailImageClass Image { get; set; }

    //    [JsonProperty("image_preview_payload")]
    //    public string ImagePreviewPayload { get; set; }

    //    [JsonProperty("id")]
    //    public string Id { get; set; }
    //}

    //public partial class ThumbnailImageClass
    //{
    //    [JsonProperty("uri")]
    //    public Uri Uri { get; set; }
    //}

    //public partial class VideoPlayerScrubberPreviewRenderer
    //{
    //    [JsonProperty("__typename")]
    //    public string Typename { get; set; }

    //    [JsonProperty("video")]
    //    public VideoPlayerScrubberPreviewRendererVideo Video { get; set; }

    //    [JsonProperty("__module_operation_VideoPlayerScrubberPreview_video")]
    //    public ModuleVideo ModuleOperationVideoPlayerScrubberPreviewVideo { get; set; }

    //    [JsonProperty("__module_component_VideoPlayerScrubberPreview_video")]
    //    public ModuleVideo ModuleComponentVideoPlayerScrubberPreviewVideo { get; set; }
    //}

    //public partial class VideoPlayerScrubberPreviewRendererVideo
    //{
    //    [JsonProperty("scrubber_preview_thumbnail_information")]
    //    public ScrubberPreviewThumbnailInformation ScrubberPreviewThumbnailInformation { get; set; }

    //    [JsonProperty("id")]
    //    public string Id { get; set; }
    //}

    //public partial class ScrubberPreviewThumbnailInformation
    //{
    //    [JsonProperty("sprite_uris")]
    //    public Uri[] SpriteUris { get; set; }

    //    [JsonProperty("thumbnail_width")]
    //    public long ThumbnailWidth { get; set; }

    //    [JsonProperty("thumbnail_height")]
    //    public long ThumbnailHeight { get; set; }

    //    [JsonProperty("has_preview_thumbnails")]
    //    public bool HasPreviewThumbnails { get; set; }

    //    [JsonProperty("num_images_per_row")]
    //    public long NumImagesPerRow { get; set; }

    //    [JsonProperty("max_number_of_images_per_sprite")]
    //    public long MaxNumberOfImagesPerSprite { get; set; }

    //    [JsonProperty("time_interval_between_image")]
    //    public long TimeIntervalBetweenImage { get; set; }
    //}

    //public partial class VideoPlayerShakaPerformanceLoggerInit
    //{
    //    [JsonProperty("__typename")]
    //    public string Typename { get; set; }

    //    [JsonProperty("__module_operation_useVideoPlayerShakaPerformanceLoggerRelayImpl_video")]
    //    public ModuleVideo ModuleOperationUseVideoPlayerShakaPerformanceLoggerRelayImplVideo { get; set; }

    //    [JsonProperty("__module_component_useVideoPlayerShakaPerformanceLoggerRelayImpl_video")]
    //    public ModuleVideo ModuleComponentUseVideoPlayerShakaPerformanceLoggerRelayImplVideo { get; set; }
    //}

    //public partial class VideoPlayerShakaPerformanceLoggerInit2
    //{
    //    [JsonProperty("__typename")]
    //    public string Typename { get; set; }

    //    [JsonProperty("__module_operation_useVideoPlayerShakaPerformanceLoggerBuilder_video")]
    //    public ModuleVideo ModuleOperationUseVideoPlayerShakaPerformanceLoggerBuilderVideo { get; set; }

    //    [JsonProperty("__module_component_useVideoPlayerShakaPerformanceLoggerBuilder_video")]
    //    public ModuleVideo ModuleComponentUseVideoPlayerShakaPerformanceLoggerBuilderVideo { get; set; }

    //    [JsonProperty("per_session_sampling_rate")]
    //    public object PerSessionSamplingRate { get; set; }
    //}

    //public partial class PageAdLibrary
    //{
    //    [JsonProperty("is_business_page_active")]
    //    public bool IsBusinessPageActive { get; set; }

    //    [JsonProperty("id")]
    //    public string Id { get; set; }
    //}

    //public partial class User
    //{
    //    [JsonProperty("id")]
    //    public string Id { get; set; }

    //    [JsonProperty("name")]
    //    public string Name { get; set; }

    //    [JsonProperty("profileUrl")]
    //    public Uri ProfileUrl { get; set; }

    //    [JsonProperty("profilePic")]
    //    public Uri ProfilePic { get; set; }
    //}

    public enum IsMedia { GenericAttachmentMedia, Photo, ProfilePicAttachmentMedia, Video };

    public partial class FacebookPosts
    {
        public static FacebookPosts[] FromJson(string json) => JsonConvert.DeserializeObject<FacebookPosts[]>(json, EventLinkConsoleApplication.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this FacebookPosts[] self) => JsonConvert.SerializeObject(self, EventLinkConsoleApplication.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                IsMediaConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class IsMediaConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(IsMedia) || t == typeof(IsMedia?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "GenericAttachmentMedia":
                    return IsMedia.GenericAttachmentMedia;
                case "Photo":
                    return IsMedia.Photo;
                case "ProfilePicAttachmentMedia":
                    return IsMedia.ProfilePicAttachmentMedia;
                case "Video":
                    return IsMedia.Video;
            }
            throw new Exception("Cannot unmarshal type IsMedia");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (IsMedia)untypedValue;
            switch (value)
            {
                case IsMedia.GenericAttachmentMedia:
                    serializer.Serialize(writer, "GenericAttachmentMedia");
                    return;
                case IsMedia.Photo:
                    serializer.Serialize(writer, "Photo");
                    return;
                case IsMedia.ProfilePicAttachmentMedia:
                    serializer.Serialize(writer, "ProfilePicAttachmentMedia");
                    return;
                case IsMedia.Video:
                    serializer.Serialize(writer, "Video");
                    return;
            }
            throw new Exception("Cannot marshal type IsMedia");
        }

        public static readonly IsMediaConverter Singleton = new IsMediaConverter();
    }
}
