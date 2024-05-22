namespace Xandevelop.SideFileIO;
using Newtonsoft.Json;

/// <summary>
/// A class representing a single Selenium test.
/// </summary>
public class Test
{
    /// <summary>
    /// Gets or sets the ID of the test.
    /// </summary>
    [JsonProperty("id")]
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the test.
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the list of commands in the test.
    /// </summary>
    [JsonProperty("commands")] 
    public List<Command> Commands { get; set; } = new();
}