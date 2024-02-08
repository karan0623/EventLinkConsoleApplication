//https://app.quicktype.io/ was used to help generate this code

namespace EventLinkConsoleApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class TwitterPosts
    {
        [JsonProperty("greeting")]
        public string Greeting { get; set; }

        [JsonProperty("instructions")]
        public Instruction[] Instructions { get; set; }
    }

    public partial class Instruction
    {
        [JsonProperty("user")]
        public User User { get; set; }

        [Key]
        [JsonProperty("id")]
        public string Id { get; set; }

        //[JsonProperty("conversation_id")]
        //public string ConversationId { get; set; }

        [JsonProperty("full_text")]
        public string FullText { get; set; }

        //[JsonProperty("reply_count")]
        //public long ReplyCount { get; set; }

        //[JsonProperty("retweet_count")]
        //public long RetweetCount { get; set; }

        //[JsonProperty("favorite_count")]
        //public long FavoriteCount { get; set; }

        //[JsonProperty("hashtags")]
        //public string[] Hashtags { get; set; }

        //[JsonProperty("symbols")]
        //public object[] Symbols { get; set; }

        //[JsonProperty("user_mentions")]
        //public UserMention[] UserMentions { get; set; }

        //[JsonProperty("urls")]
        //public Url[] Urls { get; set; }

        //[JsonProperty("media")]
        //public Media[] Media { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        //[JsonProperty("created_at")]
        //public DateTimeOffset CreatedAt { get; set; }

        //[JsonProperty("view_count", NullValueHandling = NullValueHandling.Ignore)]
        //public long? ViewCount { get; set; }

        //[JsonProperty("quote_count")]
        //public long QuoteCount { get; set; }

        //[JsonProperty("is_quote_tweet")]
        //public bool IsQuoteTweet { get; set; }

        //[JsonProperty("is_retweet")]
        //public bool IsRetweet { get; set; }

        //[JsonProperty("is_pinned")]
        //public bool IsPinned { get; set; }

        //[JsonProperty("is_truncated")]
        //public bool IsTruncated { get; set; }

        //[JsonProperty("startUrl")]
        //public Uri StartUrl { get; set; }
    }

    //public partial class Media
    //{
    //    [JsonProperty("media_url")]
    //    public Uri MediaUrl { get; set; }

    //    [JsonProperty("type")]
    //    public TypeEnum Type { get; set; }

    //    [JsonProperty("video_url", NullValueHandling = NullValueHandling.Ignore)]
    //    public Uri VideoUrl { get; set; }
    //}

    //public partial class Url
    //{
    //    [JsonProperty("url")]
    //    public Uri UrlUrl { get; set; }

    //    [JsonProperty("expanded_url")]
    //    public Uri ExpandedUrl { get; set; }

    //    [JsonProperty("display_url")]
    //    public string DisplayUrl { get; set; }
    //}

    public partial class User
    {
        //[JsonProperty("created_at")]
        //public DateTimeOffset CreatedAt { get; set; }

        //[JsonProperty("default_profile_image")]
        //public bool DefaultProfileImage { get; set; }

        //[JsonProperty("description")]
        //public string Description { get; set; }

        //[JsonProperty("fast_followers_count")]
        //public long FastFollowersCount { get; set; }

        //[JsonProperty("favourites_count")]
        //public long FavouritesCount { get; set; }

        //[JsonProperty("followers_count")]
        //public long FollowersCount { get; set; }

        //[JsonProperty("friends_count")]
        //public long FriendsCount { get; set; }

        //[JsonProperty("has_custom_timelines")]
        //public bool HasCustomTimelines { get; set; }

        //[JsonProperty("is_translator")]
        //public bool IsTranslator { get; set; }

        //[JsonProperty("listed_count")]
        //public long ListedCount { get; set; }

        //[JsonProperty("location")]
        //public string Location { get; set; }

        //[JsonProperty("media_count")]
        //public long MediaCount { get; set; }
        [Key]
        [JsonProperty("name")]
        public string Name { get; set; }

        //[JsonProperty("normal_followers_count")]
        //public long NormalFollowersCount { get; set; }

        //[JsonProperty("possibly_sensitive")]
        //public bool PossiblySensitive { get; set; }

        //[JsonProperty("profile_banner_url")]
        //public Uri ProfileBannerUrl { get; set; }

        //[JsonProperty("profile_image_url_https")]
        //public Uri ProfileImageUrlHttps { get; set; }

        //[JsonProperty("screen_name")]
        //public string ScreenName { get; set; }

        //[JsonProperty("statuses_count")]
        //public long StatusesCount { get; set; }

        //[JsonProperty("translator_type")]
        //public TranslatorType TranslatorType { get; set; }

        //[JsonProperty("url")]
        //public Uri Url { get; set; }

        //[JsonProperty("verified")]
        //public bool Verified { get; set; }

        //[JsonProperty("verified_type", NullValueHandling = NullValueHandling.Ignore)]
        //public string VerifiedType { get; set; }

        //[JsonProperty("withheld_in_countries")]
        //public object[] WithheldInCountries { get; set; }

        //[JsonProperty("id_str")]
        //[JsonConverter(typeof(ParseStringConverter))]
        //public long IdStr { get; set; }
    }

    //public partial class UserMention
    //{
    //    [JsonProperty("id_str")]
    //    public string IdStr { get; set; }

    //    [JsonProperty("name")]
    //    public string Name { get; set; }

    //    [JsonProperty("screen_name")]
    //    public string ScreenName { get; set; }

    //    [JsonProperty("profile")]
    //    public Uri Profile { get; set; }
    //}

    public enum TypeEnum { Photo, Video };

    public enum TranslatorType { None };

    public partial class TwitterPosts
    {
        public static TwitterPosts FromJson(string json) => JsonConvert.DeserializeObject<TwitterPosts>(json, EventLinkConsoleApp.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this TwitterPosts self) => JsonConvert.SerializeObject(self, EventLinkConsoleApp.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                TypeEnumConverter.Singleton,
                TranslatorTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "photo":
                    return TypeEnum.Photo;
                case "video":
                    return TypeEnum.Video;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.Photo:
                    serializer.Serialize(writer, "photo");
                    return;
                case TypeEnum.Video:
                    serializer.Serialize(writer, "video");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class TranslatorTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TranslatorType) || t == typeof(TranslatorType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "none")
            {
                return TranslatorType.None;
            }
            throw new Exception("Cannot unmarshal type TranslatorType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TranslatorType)untypedValue;
            if (value == TranslatorType.None)
            {
                serializer.Serialize(writer, "none");
                return;
            }
            throw new Exception("Cannot marshal type TranslatorType");
        }

        public static readonly TranslatorTypeConverter Singleton = new TranslatorTypeConverter();
    }
}

