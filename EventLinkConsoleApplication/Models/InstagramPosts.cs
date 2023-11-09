
namespace EventLink.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class InstagramPosts
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("displayUrl")]
        public Uri DisplayUrl { get; set; }

        [JsonProperty("videoUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri VideoUrl { get; set; }

        [JsonProperty("timestamp")]
        public DateTimeOffset? Timestamp { get; set; }

        [JsonProperty("ownerFullName", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerFullName { get; set; }

        [JsonProperty("ownerUsername", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerUsername { get; set; }

        [JsonProperty("ownerId")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? OwnerId { get; set; }

        [JsonProperty("locationName", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

    }


    public enum TypeEnum { Image, Sidecar, Video };

    public partial class InstagramPosts
    {
        public static InstagramPosts[] FromJson(string json) => JsonConvert.DeserializeObject<InstagramPosts[]>(json, EventLink.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this InstagramPosts[] self) => JsonConvert.SerializeObject(self, EventLink.Models.Converter.Settings);
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
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
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

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Image":
                    return TypeEnum.Image;
                case "Sidecar":
                    return TypeEnum.Sidecar;
                case "Video":
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
                case TypeEnum.Image:
                    serializer.Serialize(writer, "Image");
                    return;
                case TypeEnum.Sidecar:
                    serializer.Serialize(writer, "Sidecar");
                    return;
                case TypeEnum.Video:
                    serializer.Serialize(writer, "Video");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }
}
