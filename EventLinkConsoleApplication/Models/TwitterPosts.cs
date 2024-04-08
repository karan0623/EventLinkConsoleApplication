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

        [JsonProperty("full_text")]
        public string FullText { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

    }

    public partial class User
    {
  
        [Key]
        [JsonProperty("name")]
        public string Name { get; set; }

    }

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

