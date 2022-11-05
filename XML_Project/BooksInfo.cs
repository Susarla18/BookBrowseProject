﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using MyBooks;
//
//    var booksInfo = BooksInfo.FromJson(jsonString);

namespace MyBooks
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class BooksInfo
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("totalItems")]
        public long TotalItems { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("kind")]
        public Kind Kind { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("selfLink")]
        public Uri SelfLink { get; set; }

        [JsonProperty("volumeInfo")]
        public VolumeInfo VolumeInfo { get; set; }

        [JsonProperty("saleInfo")]
        public SaleInfo SaleInfo { get; set; }

        [JsonProperty("accessInfo")]
        public AccessInfo AccessInfo { get; set; }
    }

    public partial class AccessInfo
    {
        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("viewability")]
        public Viewability Viewability { get; set; }

        [JsonProperty("embeddable")]
        public bool Embeddable { get; set; }

        [JsonProperty("publicDomain")]
        public bool PublicDomain { get; set; }

        [JsonProperty("textToSpeechPermission")]
        public TextToSpeechPermission TextToSpeechPermission { get; set; }

        [JsonProperty("epub")]
        public Epub Epub { get; set; }

        [JsonProperty("pdf")]
        public Pdf Pdf { get; set; }

        [JsonProperty("webReaderLink")]
        public Uri WebReaderLink { get; set; }

        [JsonProperty("accessViewStatus")]
        public AccessViewStatus AccessViewStatus { get; set; }

        [JsonProperty("quoteSharingAllowed")]
        public bool QuoteSharingAllowed { get; set; }
    }

    public partial class Epub
    {
        [JsonProperty("isAvailable")]
        public bool IsAvailable { get; set; }
    }

    public partial class Pdf
    {
        [JsonProperty("isAvailable")]
        public bool IsAvailable { get; set; }

        [JsonProperty("acsTokenLink", NullValueHandling = NullValueHandling.Ignore)]
        public Uri AcsTokenLink { get; set; }
    }

    public partial class SaleInfo
    {
        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("saleability")]
        public Saleability Saleability { get; set; }

        [JsonProperty("isEbook")]
        public bool IsEbook { get; set; }
    }

    public partial class VolumeInfo
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("authors")]
        public List<string> Authors { get; set; }

        [JsonProperty("publisher", NullValueHandling = NullValueHandling.Ignore)]
        public string Publisher { get; set; }

        [JsonProperty("publishedDate")]
        public PublishedDate PublishedDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("industryIdentifiers")]
        public List<IndustryIdentifier> IndustryIdentifiers { get; set; }

        [JsonProperty("readingModes")]
        public ReadingModes ReadingModes { get; set; }

        [JsonProperty("pageCount")]
        public long PageCount { get; set; }

        [JsonProperty("printType")]
        public PrintType PrintType { get; set; }

        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }

        [JsonProperty("averageRating", NullValueHandling = NullValueHandling.Ignore)]
        public double? AverageRating { get; set; }

        [JsonProperty("ratingsCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? RatingsCount { get; set; }

        [JsonProperty("maturityRating")]
        public MaturityRating MaturityRating { get; set; }

        [JsonProperty("allowAnonLogging")]
        public bool AllowAnonLogging { get; set; }

        [JsonProperty("contentVersion")]
        public string ContentVersion { get; set; }

        [JsonProperty("panelizationSummary", NullValueHandling = NullValueHandling.Ignore)]
        public PanelizationSummary PanelizationSummary { get; set; }

        [JsonProperty("imageLinks")]
        public ImageLinks ImageLinks { get; set; }

        [JsonProperty("language")]
        public Language Language { get; set; }

        [JsonProperty("previewLink")]
        public Uri PreviewLink { get; set; }

        [JsonProperty("infoLink")]
        public Uri InfoLink { get; set; }

        [JsonProperty("canonicalVolumeLink")]
        public Uri CanonicalVolumeLink { get; set; }

        [JsonProperty("subtitle", NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }
    }

    public partial class ImageLinks
    {
        [JsonProperty("smallThumbnail")]
        public Uri SmallThumbnail { get; set; }

        [JsonProperty("thumbnail")]
        public Uri Thumbnail { get; set; }
    }

    public partial class IndustryIdentifier
    {
        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }
    }

    public partial class PanelizationSummary
    {
        [JsonProperty("containsEpubBubbles")]
        public bool ContainsEpubBubbles { get; set; }

        [JsonProperty("containsImageBubbles")]
        public bool ContainsImageBubbles { get; set; }
    }

    public partial class ReadingModes
    {
        [JsonProperty("text")]
        public bool Text { get; set; }

        [JsonProperty("image")]
        public bool Image { get; set; }
    }

    public enum AccessViewStatus { None, Sample };

    public enum Country { Us };

    public enum TextToSpeechPermission { Allowed, AllowedForAccessibility };

    public enum Viewability { NoPages, Partial };

    public enum Kind { BooksVolume };

    public enum Saleability { NotForSale, ForSale };

    public enum Category { AdventureFiction, Fiction, Drama, Bedandbreakfastaccommodations, YoungAdultFiction, Cooking, Computers, BodyMindSpirit, BusinessEconomics, FamilyRelationships, BiographyAutobiography, Gardening, SocialScience };

    public enum TypeEnum { Isbn10, Isbn13, Other };

    public enum Language { En };

    public enum MaturityRating { NotMature };

    public enum PrintType { Book };

    public partial struct PublishedDate
    {
        public DateTimeOffset? DateTime;
        public long? Integer;

        public static implicit operator PublishedDate(DateTimeOffset DateTime) => new PublishedDate { DateTime = DateTime };
        public static implicit operator PublishedDate(long Integer) => new PublishedDate { Integer = Integer };
    }

    public partial class BooksInfo
    {
        public static BooksInfo FromJson(string json) => JsonConvert.DeserializeObject<BooksInfo>(json, MyBooks.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this BooksInfo self) => JsonConvert.SerializeObject(self, MyBooks.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                AccessViewStatusConverter.Singleton,
                CountryConverter.Singleton,
                TextToSpeechPermissionConverter.Singleton,
                ViewabilityConverter.Singleton,
                KindConverter.Singleton,
                SaleabilityConverter.Singleton,
                CategoryConverter.Singleton,
                TypeEnumConverter.Singleton,
                LanguageConverter.Singleton,
                MaturityRatingConverter.Singleton,
                PrintTypeConverter.Singleton,
                PublishedDateConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class AccessViewStatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AccessViewStatus) || t == typeof(AccessViewStatus?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "NONE":
                    return AccessViewStatus.None;
                case "SAMPLE":
                    return AccessViewStatus.Sample;
            }
            throw new Exception("Cannot unmarshal type AccessViewStatus");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AccessViewStatus)untypedValue;
            switch (value)
            {
                case AccessViewStatus.None:
                    serializer.Serialize(writer, "NONE");
                    return;
                case AccessViewStatus.Sample:
                    serializer.Serialize(writer, "SAMPLE");
                    return;
            }
            throw new Exception("Cannot marshal type AccessViewStatus");
        }

        public static readonly AccessViewStatusConverter Singleton = new AccessViewStatusConverter();
    }

    internal class CountryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Country) || t == typeof(Country?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "US")
            {
                return Country.Us;
            }
            throw new Exception("Cannot unmarshal type Country");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Country)untypedValue;
            if (value == Country.Us)
            {
                serializer.Serialize(writer, "US");
                return;
            }
            throw new Exception("Cannot marshal type Country");
        }

        public static readonly CountryConverter Singleton = new CountryConverter();
    }

    internal class TextToSpeechPermissionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TextToSpeechPermission) || t == typeof(TextToSpeechPermission?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ALLOWED":
                    return TextToSpeechPermission.Allowed;
                case "ALLOWED_FOR_ACCESSIBILITY":
                    return TextToSpeechPermission.AllowedForAccessibility;
            }
            throw new Exception("Cannot unmarshal type TextToSpeechPermission");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TextToSpeechPermission)untypedValue;
            switch (value)
            {
                case TextToSpeechPermission.Allowed:
                    serializer.Serialize(writer, "ALLOWED");
                    return;
                case TextToSpeechPermission.AllowedForAccessibility:
                    serializer.Serialize(writer, "ALLOWED_FOR_ACCESSIBILITY");
                    return;
            }
            throw new Exception("Cannot marshal type TextToSpeechPermission");
        }

        public static readonly TextToSpeechPermissionConverter Singleton = new TextToSpeechPermissionConverter();
    }

    internal class ViewabilityConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Viewability) || t == typeof(Viewability?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "NO_PAGES":
                    return Viewability.NoPages;
                case "PARTIAL":
                    return Viewability.Partial;
            }
            throw new Exception("Cannot unmarshal type Viewability");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Viewability)untypedValue;
            switch (value)
            {
                case Viewability.NoPages:
                    serializer.Serialize(writer, "NO_PAGES");
                    return;
                case Viewability.Partial:
                    serializer.Serialize(writer, "PARTIAL");
                    return;
            }
            throw new Exception("Cannot marshal type Viewability");
        }

        public static readonly ViewabilityConverter Singleton = new ViewabilityConverter();
    }

    internal class KindConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Kind) || t == typeof(Kind?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "books#volume")
            {
                return Kind.BooksVolume;
            }
            throw new Exception("Cannot unmarshal type Kind");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Kind)untypedValue;
            if (value == Kind.BooksVolume)
            {
                serializer.Serialize(writer, "books#volume");
                return;
            }
            throw new Exception("Cannot marshal type Kind");
        }

        public static readonly KindConverter Singleton = new KindConverter();
    }

    internal class SaleabilityConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Saleability) || t == typeof(Saleability?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "NOT_FOR_SALE")
            {
                return Saleability.NotForSale;
            }
            else if (value == "FOR_SALE")
            {
                return Saleability.ForSale;
            }
            throw new Exception("Cannot unmarshal type Saleability");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Saleability)untypedValue;
            if (value == Saleability.NotForSale)
            {
                serializer.Serialize(writer, "NOT_FOR_SALE");
                return;
            }
            else if (value == Saleability.ForSale)
            {
                serializer.Serialize(writer, "FOR_SALE");
                return;
            }
            throw new Exception("Cannot marshal type Saleability");
        }

        public static readonly SaleabilityConverter Singleton = new SaleabilityConverter();
    }

    internal class CategoryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Category) || t == typeof(Category?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Adventure fiction":
                    return Category.AdventureFiction;
                case "Fiction":
                    return Category.Fiction;
                case "Drama":
                    return Category.Drama;
                case "Young Adult Fiction":
                    return Category.YoungAdultFiction;
                case "Bed and breakfast accommodations":
                    return Category.Bedandbreakfastaccommodations;
                case "Cooking":
                    return Category.Cooking;
                case "Computers":
                    return Category.Computers;
                case "Body, Mind & Spirit":
                    return Category.BodyMindSpirit;
                case "Business & Economics":
                    return Category.BusinessEconomics;
                case "Family & Relationships":
                    return Category.FamilyRelationships;
                case "Biography & Autobiography":
                    return Category.BiographyAutobiography;
                case "Gardening":
                    return Category.Gardening;
                case "Social Science":
                    return Category.SocialScience;

            }
            throw new Exception("cannot unmarshal type category");
            //return value;
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Category)untypedValue;
            switch (value)
            {
                case Category.AdventureFiction:
                    serializer.Serialize(writer, "Adventure fiction");
                    return;
                case Category.Fiction:
                    serializer.Serialize(writer, "Fiction");
                    return;
                case Category.YoungAdultFiction:
                    serializer.Serialize(writer, "Young Adult Fiction");
                    return;
                case Category.Drama:
                    serializer.Serialize(writer, "Drama");
                    return;
                case Category.Bedandbreakfastaccommodations:
                    serializer.Serialize(writer, "Bed and breakfast accommodations");
                    return;
                case Category.Cooking:
                    serializer.Serialize(writer, "Cooking");
                    return;
                case Category.Computers:
                    serializer.Serialize(writer, "Computers");
                    return;
                case Category.BodyMindSpirit:
                    serializer.Serialize(writer, "Body, Mind & Spirit");
                    return;
                case Category.FamilyRelationships:
                    serializer.Serialize(writer, "Family & Relationships");
                    return;
                case Category.BusinessEconomics:
                    serializer.Serialize(writer, "Business & Economics");
                    return;
                case Category.BiographyAutobiography:
                    serializer.Serialize(writer, "Biography & Autobiography");
                    return;
                case Category.Gardening:
                    serializer.Serialize(writer, "Gardening");
                    return;
                case Category.SocialScience:
                    serializer.Serialize(writer, "Social Science");
                    return;
            }
            throw new Exception("Cannot marshal type Category");
        }

        public static readonly CategoryConverter Singleton = new CategoryConverter();
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
                case "ISBN_10":
                    return TypeEnum.Isbn10;
                case "ISBN_13":
                    return TypeEnum.Isbn13;
                case "OTHER":
                    return TypeEnum.Other;
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
                case TypeEnum.Isbn10:
                    serializer.Serialize(writer, "ISBN_10");
                    return;
                case TypeEnum.Isbn13:
                    serializer.Serialize(writer, "ISBN_13");
                    return;
                case TypeEnum.Other:
                    serializer.Serialize(writer, "OTHER");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class LanguageConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Language) || t == typeof(Language?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "en")
            {
                return Language.En;
            }
            throw new Exception("Cannot unmarshal type Language");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Language)untypedValue;
            if (value == Language.En)
            {
                serializer.Serialize(writer, "en");
                return;
            }
            throw new Exception("Cannot marshal type Language");
        }

        public static readonly LanguageConverter Singleton = new LanguageConverter();
    }

    internal class MaturityRatingConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MaturityRating) || t == typeof(MaturityRating?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "NOT_MATURE")
            {
                return MaturityRating.NotMature;
            }
            throw new Exception("Cannot unmarshal type MaturityRating");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MaturityRating)untypedValue;
            if (value == MaturityRating.NotMature)
            {
                serializer.Serialize(writer, "NOT_MATURE");
                return;
            }
            throw new Exception("Cannot marshal type MaturityRating");
        }

        public static readonly MaturityRatingConverter Singleton = new MaturityRatingConverter();
    }

    internal class PrintTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PrintType) || t == typeof(PrintType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "BOOK")
            {
                return PrintType.Book;
            }
            throw new Exception("Cannot unmarshal type PrintType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PrintType)untypedValue;
            if (value == PrintType.Book)
            {
                serializer.Serialize(writer, "BOOK");
                return;
            }
            throw new Exception("Cannot marshal type PrintType");
        }

        public static readonly PrintTypeConverter Singleton = new PrintTypeConverter();
    }

    internal class PublishedDateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PublishedDate) || t == typeof(PublishedDate?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    DateTimeOffset dt;
                    if (DateTimeOffset.TryParse(stringValue, out dt))
                    {
                        return new PublishedDate { DateTime = dt };
                    }
                    long l;
                    if (Int64.TryParse(stringValue, out l))
                    {
                        return new PublishedDate { Integer = l };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type PublishedDate");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (PublishedDate)untypedValue;
            if (value.DateTime != null)
            {
                serializer.Serialize(writer, value.DateTime.Value.ToString("o", System.Globalization.CultureInfo.InvariantCulture));
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value.ToString());
                return;
            }
            throw new Exception("Cannot marshal type PublishedDate");
        }

        public static readonly PublishedDateConverter Singleton = new PublishedDateConverter();
    }
}
