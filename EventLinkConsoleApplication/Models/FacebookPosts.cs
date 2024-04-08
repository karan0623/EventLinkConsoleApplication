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
        [Key]
        [JsonProperty("postId")]
        public string PostId { get; set; }

        [JsonProperty("pageName")]
        public string PageName { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }


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
