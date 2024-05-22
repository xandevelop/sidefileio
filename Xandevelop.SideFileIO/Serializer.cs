namespace Xandevelop.SideFileIO;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

/// <summary>
/// Methods for serializing and deserializing Selenium tests from SIDE files.
/// </summary>
public static class SideSerializer
{
    /// <summary>
    /// Converts a Side object for containing tests to Json.
    /// </summary>
    /// <param name="self"></param>
    /// <returns></returns>
    public static string ToJson(this Side self) => JsonConvert.SerializeObject(self, Settings);

    /// <summary>
    /// Converts from a Json string to a Side object for containing tests.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static Side? FromJson(string json) => JsonConvert.DeserializeObject<Side>(json, Settings);

    private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    {
        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
        DateParseHandling = DateParseHandling.None,
        Converters =
        {
            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
        }
    };
}
