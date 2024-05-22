namespace Xandevelop.SideFileIO;
using Newtonsoft.Json;

/// <summary>
/// Represents an entire Side file, including all the tests and test suites it contains.
/// </summary>
/// <remarks>
/// Partial class so that it can be extended for plugin structure, which is complicated and not much used.
/// </remarks>
public partial class Side
{
    /// <summary>
    /// Gets or sets the unique identifier for the Side file.
    /// </summary>
    [JsonProperty("id")]
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the Schema version for the Side file.
    /// </summary>
    /// <remarks>
    /// The classes in this library are designed to work with Version 2.0.
    /// </remarks>
    [JsonProperty("version")] 
    public string? Version { get; set; }

    /// <summary>
    /// Gets or sets the name of the Side file.
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the base URL for the Side file.
    /// </summary>
    [JsonProperty("url")]
    public Uri? Url { get; set; }

    /// <summary>
    /// Gets or sets the collection of tests in the Side file.
    /// </summary>
    [JsonProperty("tests")]
    public List<Test> Tests { get; set; } = new();

    /// <summary>
    /// Gets or sets the collection of suites in the Side file.
    /// </summary>
    [JsonProperty("suites")]
    public List<Suite> Suites { get; set; } = new();

    /// <summary>
    /// Gets or sets the set of base URLs used by the tests in the file.
    /// </summary>
    [JsonProperty("urls")]
    public List<Uri> Urls { get; set; } = new();
    
}