namespace Xandevelop.SideFileIO;
using Newtonsoft.Json;

/// <summary>
/// Represents a single command in a Selenium script.
/// </summary>
/// <remarks>
/// A Selenium command consists of a unique identifier paired with a command type, and may optionally include targets and a value. 
/// For instance, a "type" command specifies the command as "type", the target element to receive input, and the value as the input text itself.
/// Conversely, a "click" command includes the command "click" and the target element to be clicked, but does not require a value parameter.
/// 
/// When using the Selenium IDE recorder, it captures multiple targets for each action. This redundancy ensures that if the primary selector
/// fails—such as when an element's ID changes—the test can still potentially succeed by falling back to an alternative selector, like a relative XPath,
/// assuming the element's position remains unchanged from when the test was originally recorded. This feature provides a robust way to handle dynamic
/// changes in web elements during testing.
///
/// If the command type begins with "//", it denotes that the command is commented out and not executed, and commands may have additional comments.
/// </remarks>
public class Command
{
    /// <summary>
    /// Gets or sets the unique identifier for the command.
    /// </summary>
    [JsonProperty("id")]
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the comment/description part of the command.
    /// </summary>
    [JsonProperty("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// Gets or sets the command part of the command.
    /// </summary>
    [JsonProperty("command")]
    public string? CommandCommand { get; set; }

    /// <summary>
    /// Gets or sets the target part of the command.
    /// </summary>
    [JsonProperty("target")]
    public string? Target { get; set; }

    /// <summary>
    /// Gets or sets the possible alternative targets for the command.
    /// </summary>
    [JsonProperty("targets")]
    public List<List<string>> Targets { get; set; }

    /// <summary>
    /// Gets or sets the value part of the command.
    /// </summary>
    [JsonProperty("value")]
    public string Value { get; set; }

    /// <summary>
    /// Gets whether this command is commented out and not to be executed.
    /// </summary>
    public bool IsComment => CommandCommand.TrimStart().StartsWith("//") || String.IsNullOrEmpty(CommandCommand.Trim());
}